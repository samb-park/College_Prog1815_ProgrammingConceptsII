/* TextBoxData.cs
 * Assignment 2  - Class file to store textBox data which includs name, text, error message and focuss.
 * 
 *
 * Revision History
 *		Sangbong Park, 2021.02.17: Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
	class TextBoxData
	{
		public string name { get; set; }
		public string text { get; set; }
		public string errorMessage { get; set; }
		public Boolean isFocussed { get; set; }

		public TextBoxData(string name, string text, string errorMessage = "", Boolean isFocussed = false)
		{
			this.name = name;
			this.text = text;
			this.errorMessage = errorMessage;
			this.isFocussed = isFocussed;
		}
	}
}
