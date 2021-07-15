/* Calculator.cs
 * InClassTask 1  - Developing calculator 
 * 
 *
 * Revision History
 *		Sangbong Park, 2021.01.25: Created
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week2
{
	public partial class Calculator : Form
	{
		public Calculator()
		{
			InitializeComponent();
		}

		private double storedNumberX;
		private string pendingAction = null;
		private bool newNumber = true;

		private void Digits_Click(object sender, EventArgs e)
		{
			Button source = (Button)sender;

			//clear the textbox and label.
			if(newNumber == true)
			{
				newNumber = false;
				txtDisplay.Text = "";
				lblEquation.Text = "";
			}

			txtDisplay.Text += source.Text;
		}

		private void btnPeriod_Click(object sender, EventArgs e)
		{
			if (!txtDisplay.Text.Contains("."))
			{
				Digits_Click(sender, e);
			}
		}

		private void Operator_Click(object sender, EventArgs e)
		{
			Button source = (Button)sender;

			pendingAction = source.Text;

			//Avoiding the covert number if there is no number on the textbox
			if (txtDisplay.Text != "")
			{
				//Operator keys clear the textbox.
				storedNumberX = Convert.ToDouble(txtDisplay.Text);
				txtDisplay.Text = "";
			}

			//Put number + operator when user clicks the operator button.
			lblEquation.Text = storedNumberX.ToString() + " " + pendingAction + " ";

		}

		//Compute both numbers
		private double ComputeNumbers()
		{
			double result = 0;
			double numberY = Convert.ToDouble(txtDisplay.Text);


			switch (pendingAction)
			{
				case "+":
					result = storedNumberX + numberY;
					lblEquation.Text = storedNumberX + " " + pendingAction + " " + numberY + " = " + result;
					break;
				case "-":
					result = storedNumberX - numberY;
					lblEquation.Text = storedNumberX + " " + pendingAction + " " + numberY + " = " + result;
					break;
				case "/":
					if (numberY == 0)
					{
						throw new DivideByZeroException();
					}
					result = storedNumberX / numberY;
					lblEquation.Text = storedNumberX + " " + pendingAction + " " + numberY + " = " + result;

					break;
				case "*":
					result = storedNumberX * numberY;
					lblEquation.Text = storedNumberX + " " + pendingAction + " " + numberY + " = " + result;
					break;
			}
			return result;
		}

		private void btnEquals_Click(object sender, EventArgs e)
		{
			double result = 0;

			//Exit if there is no any number on the txtDisplay.
			if (txtDisplay.Text == "" || newNumber == true)
			{
				return;
			}

			try
			{
				result = ComputeNumbers();
			}
			catch (DivideByZeroException)
			{
				//If the number is divided by zero, an Error exception will occur.
				result = 0;
				lblEquation.Text = "Error : It cannot divide by zero";
			}
			catch (Exception)
			{
				//Unexpected errors handling.
				result = 0;
				lblEquation.Text = "Error : Please enter numbers.";
			}
			finally
			{
				//Display result and clear variables.
				txtDisplay.Text = result.ToString();
				pendingAction = "";
				storedNumberX = 0;
				newNumber = true;
			}
			
		}

		private void btnClearEverything_Click(object sender, EventArgs e)
		{
			btnClear_Click(sender, e);
			lblEquation.Text = "";
			pendingAction = "";
			storedNumberX = 0;
			newNumber = true;
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = "";
		}
	}
}
