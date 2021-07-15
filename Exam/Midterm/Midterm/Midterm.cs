/* Midterm.cs
 * Midterm - Solve questions.
 * 
 *
 * Revision History
 *		Sangbong Park, 2021.03.04: Created
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

namespace Midterm
{
	public partial class Midterm : Form
	{
		string[,] ingredients = new string[5, 3];

		public Midterm()
		{
			InitializeComponent();
		}
		//Question 1

		//Validate Date using Regex
		private void btnDate_Click(object sender, EventArgs e)
		{
			Regex pattern = new Regex(@"^\d{4}-\d{2}-\d{2}$");

			if (pattern.IsMatch(txtQestion1.Text))
			{
				txtResult.Text = "Date is valid";
			}
			else
			{
				txtResult.Text = "Date is not valid";
			}
		}


		//Validate IP using Regex
		private void btnIpValidation_Click(object sender, EventArgs e)
		{
			Regex pattern = new Regex(@"^\d{3}\.\d{3}\.\d{3}\.\d{3}$");

			if (pattern.IsMatch(txtQestion1.Text))
			{
				txtResult.Text = "IP is valid";
			}
			else
			{
				txtResult.Text = "IP is not valid";
			}
		}


		//Question3

		//To check if input number is a part of fibonacci
		private void btnFibonacci_Click(object sender, EventArgs e)
		{
			Int64 fibonacci = 0;
			txtResult.Text = "";

			if(txtFibonacci.Text == "")
			{
				txtResult.Text = "Input is empty";
				return;
			}

			if (!Int64.TryParse(txtFibonacci.Text, out fibonacci))
			{
				txtResult.Text = "Input is not numberic";
				return;
			}

			if (fibonacci < 10000 || fibonacci > 99999999999999)
			{
				txtResult.Text = "Input must be at least 5 digits and no more than 14 digits";
				return;
			}

			var flag = false;
			Int64 firstNumber = 0,
					secondNumber = 1,
					currentNumber = 0;

			for(int i = 2; i.ToString().Length <= 14; i++)
			{
				currentNumber = firstNumber + secondNumber;
				firstNumber = secondNumber;
				secondNumber = currentNumber;
				if(currentNumber == fibonacci)
				{
					txtResult.Text = $"{fibonacci} is part of a Fibonacci sequency";
					flag = true;
					break;
				}

				if(fibonacci < currentNumber)
				{
					flag = false;
					break;
				}
			}

			if(flag == false)
			{
				txtResult.Text = $"{fibonacci} is not part of a Fibonacci sequency";
			}
	




		}

		//Question4

		//To add the date to richTextBox
		private void btnAdd_Click(object sender, EventArgs e)
		{
			txtErrorMessage.Text = "";
			var errorMessage = "";
			Int32 i = 0;

			for(i =0; i < ingredients.GetLength(0); i++)
			{
				if(ingredients[i,0] == null)
				{
					break;
				}
			}

			if(i == 5)
			{
				txtName.Focus();
				txtErrorMessage.Text = "Stored data is full.";

				return;
			}

			errorMessage = ValidateText();

			if (errorMessage == "")
			{
				ingredients[i, 0] = txtName.Text;
				ingredients[i, 1] = txtQuantity.Text;
				ingredients[i, 2] = txtMeasure.Text;
				txtResult.Text = "";

				for (int j = 0; j < ingredients.GetLength(0); j++)
				{
					txtResult.Text += $"{ingredients[j, 0]}\t{ingredients[j, 1]}\t{ingredients[j, 2]}\n";
				}
			}
			else
			{
				txtErrorMessage.Text = errorMessage;
			}
		}

		//Validate all text box.
		private string ValidateText()
		{
			var errorMessage = "";
			//Validate ingredient name
			if (txtName.Text != "")
			{
				if (txtName.Text.Length < 1 || txtName.Text.Length > 20)
				{
					if (errorMessage == "")
					{
						txtName.Focus();
					}
					errorMessage += "Ingredient Name must be 1-20 characters\n";
				}

				for (int j = 0; j < ingredients.GetLength(0); j++)
				{
					if (txtName.Text == ingredients[j, 0])
					{
						if (errorMessage == "")
						{
							txtName.Focus();
						}
						errorMessage += "Same ingredient name is stored\n";
					}
				}
			}
			else
			{
				if (errorMessage == "")
				{
					txtName.Focus();
				}
				errorMessage += "Ingredient Name is empty\n";
			}

			//Validate quantity
			double quentity = 0.0;
			if (txtQuantity.Text != "")
			{
				if (double.TryParse(txtQuantity.Text, out quentity))
				{
					if (quentity < 0)
					{
						if (errorMessage == "")
						{
							txtQuantity.Focus();
						}
						errorMessage += "Quantity must greater then zero\n";
					}
				}
				else
				{
					if (errorMessage == "")
					{
						txtQuantity.Focus();
					}
					errorMessage += "Quantity must be numeric\n";
				}
			}
			else
			{
				if (errorMessage == "")
				{
					txtQuantity.Focus();
				}
				errorMessage += "Quantity is empty\n";
			}

			//Validate Measure
			Regex pattern = new Regex(@"^\d+ ?(kg|ml|oz|tsp)$");

			if (txtMeasure.Text != "")
			{
				if (!pattern.IsMatch(txtMeasure.Text))
				{
					if (errorMessage == "")
					{
						txtMeasure.Focus();
					}
					errorMessage += "Measure is not valid\n";
				}
			}
			else
			{
				if (errorMessage == "")
				{
					txtMeasure.Focus();
				}
				errorMessage += "Measure is empty\n";
			}

			return errorMessage;
		}

		//Validate quentity text box only and no focuss in here.
		private string ValidateQuentity()
		{
			var errorMessage = "";

			//Validate quantity
			double quentity = 0.0;
			if (txtQuantity.Text != "")
			{
				if (double.TryParse(txtQuantity.Text, out quentity))
				{
					if (quentity < 0)
					{

						errorMessage += "Quantity must greater then zero\n";
					}
				}
				else
				{

					errorMessage += "Quantity must be numeric\n";
				}
			}
			else
			{

				errorMessage += "Quantity is empty\n";
			}
			return errorMessage;
		}

		//Validate Measure text box only and no focuss in here.
		private string ValidateMeasure()
		{
			var errorMessage = "";

			Regex pattern = new Regex(@"^\d+ ?(kg|ml|oz|tsp)$");

			if (txtMeasure.Text != "")
			{
				if (!pattern.IsMatch(txtMeasure.Text))
				{

					errorMessage += "Measure is not valid\n";
				}
			}
			else
			{

				errorMessage += "Measure is empty\n";
			}

			return errorMessage;
		}

		//Update the date and check if input date is valid
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			var errorMessage = "";
			var isFocuss = false;

			errorMessage = ValidateText();

			if (errorMessage.Contains("Same ingredient name is stored"))
			{
				for (int i = 0; i < ingredients.GetLength(0); i++)
				{
					if (ingredients[i, 0] == txtName.Text)
					{
						ingredients[i, 0] = txtName.Text;
						ingredients[i, 1] = txtQuantity.Text;
						ingredients[i, 2] = txtMeasure.Text;
						txtResult.Text = "";

						errorMessage = ValidateQuentity();
						if(isFocuss == false && errorMessage != "")
						{
							txtQuantity.Focus();
							isFocuss = true;

						}

						errorMessage += ValidateMeasure();
						if (isFocuss == false && errorMessage != "")
						{
							txtMeasure.Focus();
							isFocuss = true;
						}

						if (errorMessage != "")
						{
							txtErrorMessage.Text = "Item is found\nhowever," + errorMessage;
							break;
						}

						for (int j = 0; j < ingredients.GetLength(0); j++)
						{
							txtResult.Text += $"{ingredients[j, 0]}\t{ingredients[j, 1]}\t{ingredients[j, 2]}\n";
						}
						txtErrorMessage.Text = "item is found and updated.";
						break;
					}
				}
			}
			else
			{
				txtErrorMessage.Text = errorMessage;
			}
		}

		//Search the date and check if input date is valid

		private void btnFind_Click(object sender, EventArgs e)
		{
			var errorMessage = "";
			txtErrorMessage.Text = "";
			txtResult.Text = "";

			errorMessage = ValidateText();

			if(errorMessage.Contains("Same ingredient name is stored"))
			{
				for (int j = 0; j < ingredients.GetLength(0); j++)
				{
					if (ingredients[j, 0] == txtName.Text)
					{
						txtErrorMessage.Text = "Item is found";
						txtResult.Text = txtResult.Text += $"{ingredients[j, 0]}\t{ingredients[j, 1]}\t{ingredients[j, 2]}";
						break;
					}
				}
			}
			else
			{
				txtErrorMessage.Text = errorMessage;
			}
		}



	}
}
