/* SPValidation.cs
 * Assignment 2  - Class file to validate text
 *
 * Revision History
 *		Sangbong Park, 2021.02.17: Created
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment2
{
	class SPValidation
	{
		//A function that changes capital letters. The first letter is capitalized and the rest is lowercase. 
		public static string SPCapitalize(params string[] wordsParameters)
		{
			var returnValue = "";

			foreach(var parameter in wordsParameters)
			{
				if (!string.IsNullOrWhiteSpace(parameter))
				{
					var words = parameter.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

					foreach (var word in words)
					{
						returnValue += $"{char.ToUpper(word[0])}{word.ToLower().Substring(1)} ";
					}
				}
				
				returnValue += '\n';
			}

			return returnValue;
		}
		//Check the member code.The member code must be 9 characters  and returns to true if it consist of 4 digits and 5 letters
		public static Boolean SPMemberCodeValidation(string memberCode)
		{
			var returnValue = false;
			var numOfDigit = 0;
			var numOfLetter = 0;

			if (string.IsNullOrWhiteSpace(memberCode))
			{
				return returnValue;
			}

			if(memberCode.Length == 9)
			{
				foreach(var item in memberCode)
				{
					if(char.IsDigit(item))
					{
						numOfDigit++;
					}
					else if(char.IsLetter(item) && char.IsUpper(item))
					{
						numOfLetter++;
					}
				}
				if (numOfDigit == 5 && numOfLetter == 4)
				{
					returnValue = true;
				}
			}

			return returnValue;
		}

		//Validate the phone number by using Regex. It returns true in case of (XXX XXX XXXX or XXX.XXX.XXXX)
		public static Boolean SPPhoneNumberValidation(string phoneNumber)
		{
			var returnValue = false;
			var regex = new Regex(@"(^[0-9]{3} [0-9]{3} [0-9]{4}$)|(^[0-9]{3}\.[0-9]{3}\.[0-9]{4}$)");

			if (string.IsNullOrEmpty(phoneNumber))
			{
				return true;
			}

			if (regex.IsMatch(phoneNumber))
			{
				returnValue = true;
			}

			return returnValue;
		}

		//Check if the postal code is correct using regex. If there is no space between postal codes, add the space after the third letter.
		public static Boolean SPUKPostalValidation(ref string postalCode)
		{
			var returnValue = false;
			Regex pattern = new Regex(@"^[A-Z][A-Z]?[0-9][A-Z0-9]? ?\d[A-Z]{2}$");

			postalCode = postalCode.Trim().ToUpper();

			if (string.IsNullOrWhiteSpace(postalCode))
			{
				return returnValue;
			}

			if(pattern.IsMatch(postalCode))
			{
				returnValue = true;
				if (postalCode.IndexOf(' ') == -1)
				{
					postalCode = postalCode.Insert(postalCode.Length - 3, " ");
				}				
			}

			return returnValue;
		}

		
	}
}
