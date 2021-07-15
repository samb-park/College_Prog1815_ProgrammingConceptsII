/* EmployeeYearsOfService.cs
 * 
 * Inclass 3  - Implementation of the aplication to compute service of year using class.
 *
 * Revision History
 *		Sangbong Park, 2021.03.22: Created
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

namespace InClass3
{
	public partial class EmployeeYearsOfService : Form
	{
		public EmployeeYearsOfService()
		{
			InitializeComponent();
		}
		#region event handler
		private void EmployeeYearsOfService_Load(object sender, EventArgs e)
		{
			dateStartDate.MaxDate = DateTime.Today;
			txtResult.Enabled = false;
		}


		/// <summary>
		/// If the information entered by the user is valid, 
		/// the number of years of service is calculated and shown.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnCalculate_Click(object sender, EventArgs e)
		{
			var firstName = txtFirstName.Text;
			var lastName = txtLastName.Text;
			var startDate = dateStartDate.Value;
			double annualSalary = 0.0;

			var errorMessage = CheckFields(ref annualSalary);

			if (errorMessage!="")
			{
				txtResult.Text = errorMessage;
				return;
			}

			Employee employee = new Employee(firstName,lastName,startDate,annualSalary);

			txtResult.Text = $"Name : {employee.FirstName} {employee.LastName}\n" +
							  $"Start Date : {employee.StartDate.ToString("MMM dd, yyyy")}\n" +
							  $"Annual Salary : {employee.AnnualSalary.ToString()}\n\n" +
							  $"Year of service : {employee.GetYearsOfService().ToString()}";
		}
		#endregion

		#region method CheckFields
		/// <summary>
		/// Return the error or null message if fields entered by user are vaild or invalid.
		/// </summary>
		/// <param name="annualSalary"></param>
		/// <returns></returns>
		private string CheckFields(ref double annualSalary)
		{
			var errorMessage = "";

			if (string.IsNullOrWhiteSpace(txtFirstName.Text))
			{
				errorMessage += "FirstName is empty\n";
			}

			if (string.IsNullOrWhiteSpace(txtLastName.Text))
			{
				errorMessage += "LirstName is empty\n";
			}

			if (string.IsNullOrWhiteSpace(txtAnnualSalary.Text))
			{
				errorMessage += "Annual Salary is empty\n";
			}
			else if (!Double.TryParse(txtAnnualSalary.Text, out annualSalary))
			{
				errorMessage += "AnnualSalary is invalid.\n";
			}

			return errorMessage;
		}
		#endregion
	}
}
