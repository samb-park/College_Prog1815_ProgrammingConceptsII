/* SPGynMemberManagement.cs
 * Assignment 2  - Implementation of validation form.
 * 
 *
 * Revision History
 *		Sangbong Park, 2021.02.17: Created
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Assignment2
{
	public partial class SPGymMemberManagement : Form
	{

		// Initialize the Enum
		enum Box
		{
			fullName = 0,    
			memberGoal,      
			homePhone,
			workPhone,
			cellPhone,
			emailAddress,         
			dateJoined,
			memberCode,
			mailingAddress,
			town,
			country,
			provinceCode,
			postalCode
		}
		public SPGymMemberManagement()
		{
			InitializeComponent();
		}

		//Event handler : When user click the "Submit button", this method start and validate the text in TextBox.
		private void btnSubmit_Click(object sender, EventArgs e)
		{
			// Initialize TextBox array. Enum and array are in the same order as form.
			TextBox[] txtBoxes =
			{
				txtFullName,		
				txtMemberGoal,		
				txtHomePhone,		
				txtWorkPhone,
				txtCellPhone,
				txtEmail,			
				txtDateJoined,
				txtMemberCode,		
				txtMailingAddress,
				txtTownAddress,
				txtCountry,
				txtProvinceCodeAddress,
				txtPostalCode		
			};
			
			// Declare the TextBoxData class which contains the information such as text, errormessage, fucussing and textbox name.
			TextBoxData[] textData = new TextBoxData[txtBoxes.Length];
			var focussingNumber = 0;
			var errorMessage = "";

			lblMessage.Text = "";
			InitializedData(txtBoxes, textData);
			CapitalizeTextBox(textData);
			RemovePunctuation(textData);

			errorMessage += CheckEmptyText(textData);
			errorMessage += ValidataTextBox(textData);

			UpdateTextBox(txtBoxes, textData);

			//find the top of text which has errorMessage.
			foreach (var data in textData)
			{
				if (data.isFocussed)
				{
					break;
				}
				focussingNumber++;
				focussingNumber %= textData.Length;
			}
			//It is focussed on the text which has errormessage at the top.
			txtBoxes[focussingNumber].Focus();

			//All of error message displays
			foreach (var data in textData)
			{
				lblMessage.Text += data.errorMessage;
			}
			lblMessage.Text += errorMessage;
		}

		//Event handler : When user click the "Close button", form is closed
		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		//Event handler : When user click the "Prefill" button, All of textBox are filed out as valid value.
		private void btnPrefill_Click(object sender, EventArgs e)
		{
			txtFullName.Text = "sangbong park";
			txtMemberGoal.Text = "To Run 126 mileS; in 2 hours. Perform 300 situps, and Squat 100 pOUNDS, by January of 2021.";
			txtMemberCode.Text = "1A2B3C4D5";
			txtHomePhone.Text = "123.456.7890";
			txtCellPhone.Text = "123 456 7890";
			txtWorkPhone.Text = "123 456 7890";
			txtEmail.Text = "Spark2765@Conestogac.on.Ca";
			txtDateJoined.Text = "2021/01/15";
			txtMailingAddress.Text = "annie craig dr";
			txtTownAddress.Text = "toronto";
			txtProvinceCodeAddress.Text = "on";
			txtPostalCode.Text = "aa3a3aa";
			txtCountry.Text = "canada";
		}

		//Event handler : When user click the "Clear" button, All of textBox are cleared.
		private void btnClear_Click(object sender, EventArgs e)
		{
			txtFullName.Text = "";
			txtMemberGoal.Text = "";
			txtMemberCode.Text = "";
			txtHomePhone.Text = "";
			txtCellPhone.Text = "";
			txtWorkPhone.Text = "";
			txtEmail.Text = "";
			txtDateJoined.Text = "";
			txtMailingAddress.Text = "";
			txtTownAddress.Text = "";
			txtProvinceCodeAddress.Text = "";
			txtPostalCode.Text = "";
			txtCountry.Text = "";
			lblMessage.Text = "";
		}

		//Store default value which contain errormessage, focussing, text and textbox name. if a textBox is empty, the class data changes the error message and the focusing flag.
		private void InitializedData(TextBox[] txtBoxes, TextBoxData[] textData)
		{
			for (int i = 0; i < txtBoxes.Length; i++)
			{
				var message = "";
				var isFocused = false;

				if (string.IsNullOrWhiteSpace(txtBoxes[i].Text))
				{
					message += $"{txtBoxes[i].Name.Substring(3)} is required\n";
					isFocused = true;
				}

				if (txtBoxes[i].Name.Contains("Phone"))
				{
					message = "";
				}
				else if (txtBoxes[i].Name.Contains("Address") || txtBoxes[i].Name.Contains("Country") || txtBoxes[i].Name.Contains("Email") || txtBoxes[i].Name.Contains("DateJoined"))
				{
					message = "";
					isFocused = false;
				}

				textData[i] = new TextBoxData(txtBoxes[i].Name, txtBoxes[i].Text.Trim(), message, isFocused);
			}
		}

		//Method to handle addressing phone number, when these textBoxes are empty.
		private string CheckEmptyText(TextBoxData[] textData)
		{
			var errorMessage = "At least one phone number is required.\n"; ;

			// At leat one phone number required
			if (!string.IsNullOrWhiteSpace(textData[(int)Box.workPhone].text) || !string.IsNullOrWhiteSpace(textData[(int)Box.homePhone].text) || !string.IsNullOrWhiteSpace(textData[(int)Box.cellPhone].text))
			{
				textData[(int)Box.workPhone].isFocussed = false;
				textData[(int)Box.cellPhone].isFocussed = false;
				textData[(int)Box.homePhone].isFocussed = false;
				errorMessage = "";
			}

			//If email address is not provided, address information need to be requried
			if (string.IsNullOrWhiteSpace(textData[(int)Box.emailAddress].text))
			{
				var numberOfAddress = 0;

				if (string.IsNullOrWhiteSpace(textData[(int)Box.mailingAddress].text))
				{
					errorMessage += "\"Mailing Address\" ";
					textData[(int)Box.mailingAddress].isFocussed = true;
					numberOfAddress++;
				}

				if (string.IsNullOrWhiteSpace(textData[(int)Box.town].text))
				{
					errorMessage += "\"Town\" ";
					textData[(int)Box.town].isFocussed = true;
					numberOfAddress++;
				}

				if (string.IsNullOrWhiteSpace(textData[(int)Box.provinceCode].text))
				{
					errorMessage += "\"Province Code\" ";
					textData[(int)Box.provinceCode].isFocussed = true;
					numberOfAddress++;
				}

				if (numberOfAddress == 3)
				{
					textData[(int)Box.emailAddress].isFocussed = true;
				}
				errorMessage += string.IsNullOrWhiteSpace(errorMessage) ? "" : "if Email is not provided\n";
			}

			return errorMessage;
		}

		//It sends the required text to the SPCaptialize function to capitalize the first letter.
		private void CapitalizeTextBox(TextBoxData[] textData)
		{
			var returnValue =  SPValidation.SPCapitalize(textData[(int)Box.fullName].text, textData[(int)Box.memberGoal].text, textData[(int)Box.mailingAddress].text, textData[(int)Box.town].text, textData[(int)Box.country].text).Split('\n');

			textData[(int)Box.fullName].text = returnValue[0].Trim();
			textData[(int)Box.memberGoal].text = returnValue[1].Trim();
			textData[(int)Box.mailingAddress].text = returnValue[2].Trim();
			textData[(int)Box.town].text = returnValue[3].Trim();
			textData[(int)Box.country].text = returnValue[4].Trim();
		}

		//All adjusted texts are updated in textBox.
		private void UpdateTextBox(TextBox[] txtBoxes, TextBoxData[] textData)
		{
			for(int i = 0; i < textData.Length; i++)
			{
				txtBoxes[i].Text = textData[i].text;
			}
		}

		//This method removes the punctuations except '.'
		private void RemovePunctuation(TextBoxData[] textData)
		{
			var memberGoal = "";

			foreach (var word in textData[(int)Box.memberGoal].text)
			{
				if (Char.IsPunctuation(word) == false || word == '.')
				{
					memberGoal += word;
				}
			}
			textData[(int)Box.memberGoal].text = memberGoal;
		}

		//It checks all of textBox to validate textBox from stored textData.
		private string ValidataTextBox(TextBoxData[] textData)
		{
			var errorMessage = "";
			var data = textData[(int)Box.fullName];

			errorMessage += CheckFullName(data);

			data = textData[(int)Box.cellPhone];
			errorMessage += CheckPhoneNumber(data);

			data = textData[(int)Box.workPhone];
			errorMessage += CheckPhoneNumber(data);

			data = textData[(int)Box.homePhone];
			errorMessage += CheckPhoneNumber(data);

			data = textData[(int)Box.emailAddress];
			errorMessage += CheckMailAddress(data);
			textData[(int)Box.emailAddress].text = data.text.ToLower();

			data = textData[(int)Box.memberCode];
			errorMessage += CheckMemberCode(data);

			var dateJoined = textData[(int)Box.dateJoined];
			errorMessage += CheckDateJoined(dateJoined);
			textData[(int)Box.dateJoined].text = dateJoined.text;
			

			errorMessage += CheckMinimumNumber(textData[(int)Box.mailingAddress], 3);
			errorMessage += CheckMinimumNumber(textData[(int)Box.town], 3);
			errorMessage += CheckMinimumNumber(textData[(int)Box.country], 3);

			var provinceCode = textData[(int)Box.provinceCode];
			errorMessage += CheckProvinceCode(provinceCode);
			textData[(int)Box.provinceCode].text = provinceCode.text;

			var postalCode = textData[(int)Box.postalCode];
			errorMessage += CheckPostalCode(postalCode);
			textData[(int)Box.postalCode].text = postalCode.text;

			//Save all error messages and return them.
			return errorMessage;
		}

		//All phone number are checked whether it is validate
		private string CheckPhoneNumber(TextBoxData phoneNumber)
		{
			var errorMessage = "";

			if (!SPValidation.SPPhoneNumberValidation(phoneNumber.text) && !string.IsNullOrWhiteSpace(phoneNumber.text))
			{
				errorMessage = $"{phoneNumber.name.Substring(3)} is not valid\n";
				phoneNumber.isFocussed = true;
			}

			return errorMessage;
		}

		// This method check by using "try catch" whether entered mail is valid. if it is not valid, it will return the error message
		private string CheckMailAddress(TextBoxData mailAddress)
		{
			var errorMessage = "";

			if (String.IsNullOrWhiteSpace(mailAddress.text))
			{
				return errorMessage;
			}

			try
			{
				MailAddress email = new MailAddress(mailAddress.text);
			}
			catch (Exception)
			{
				errorMessage += "Email address is not valid\n";
				mailAddress.isFocussed = true;
			}

			return errorMessage;
		}

		//This metod uses the split the words and count number of words.
		private static int CountNumberOfWords(string words)
		{
			var num = words.Split(' ').Length;
			return num;
		}


		//It checks that entered text is satisfied the minimum word length.
		private static string CheckMinimumNumber(TextBoxData textData, int minmumNumber)
		{
			var errorMessage = "";

			if(String.IsNullOrWhiteSpace(textData.text))
			{
				return errorMessage;
			}

			if (textData.text.Length < minmumNumber)
			{
				errorMessage += $"{textData.name.Substring(3)} must be at least {minmumNumber} letters.\n";
				textData.isFocussed = true;
			}

			return errorMessage;
		}

		//Validate date format and compare date between current date and entered date.
		private string CheckDateJoined(TextBoxData dateJoined)
		{
			var errorMessage = "";
			DateTime date;

			if (String.IsNullOrWhiteSpace(dateJoined.text))
			{
				return errorMessage;
			}

			if (!DateTime.TryParse(dateJoined.text, out date))
			{
				errorMessage = "Date is not valid\n";
				dateJoined.isFocussed = true;
			}
			else
			{
				if (DateTime.Compare(DateTime.Today, date) >= 0)
				{
					dateJoined.text = date.ToString("yyyy MMM dd");
				}
				else
				{
					errorMessage += "Date is not valid because entered date is future.\n";
					dateJoined.isFocussed = true;
				}
			}

			return errorMessage;
		}

		//Check the postal code and update
		private string CheckPostalCode(TextBoxData postalCode)
		{
			var errorMessage = "";
			if (String.IsNullOrWhiteSpace(postalCode.text))
			{
				return errorMessage;
			}
			var postal = postalCode.text;
			if (SPValidation.SPUKPostalValidation(ref postal))
			{
				postalCode.text = postal;
			}
			else
			{
				errorMessage += "Posta code is not valid\n";
				postalCode.isFocussed = true;
			}

			return errorMessage;
		}

		//Provinces code changes to upper case and check if text is 2 letters.
		private string CheckProvinceCode(TextBoxData provinceCode)
		{
			var errorMessage = "";
			if (String.IsNullOrWhiteSpace(provinceCode.text))
			{
				return errorMessage;
			}

			if (Regex.IsMatch(provinceCode.text, @"^[a-zA-z]{2}$"))
			{
				provinceCode.text = provinceCode.text.ToUpper();
			}
			else
			{
				errorMessage += "Provice code must be 2 letters.\n";
				provinceCode.isFocussed = true;
			}

			return errorMessage;
		}

		//Check full name is more than two words
		private string CheckFullName(TextBoxData fullName)
		{
			var errorMessage = "";
			if (String.IsNullOrWhiteSpace(fullName.text))
			{
				return errorMessage;
			}

			if (CountNumberOfWords(fullName.text) <= 1)
			{
				errorMessage = "Full Name must be more than one word.\n";
				fullName.isFocussed = true;
			}

			return errorMessage;
		}

		//Send a member code to SPMemberCodeValidation to validate. 
		private string CheckMemberCode(TextBoxData memberCode)
		{
			var errorMessage = "";

			if (String.IsNullOrWhiteSpace(memberCode.text))
			{
				return errorMessage;
			}

			if (!SPValidation.SPMemberCodeValidation(memberCode.text))
			{
				errorMessage = "Member Code is not valid\n";
				memberCode.isFocussed = true;
			}

			return errorMessage;
		}

	}

}
