/* Employee.cs
 * 
 * Inclass 3  - Implementation of the aplication to compute service of year using class.
 *
 * Revision History
 *		Sangbong Park, 2021.03.22: Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass3
{
	class Employee
	{
		#region properties
		public String FirstName { get; set; }
		public String LastName { get; set; }
		public DateTime StartDate { get; set; }
		public Double AnnualSalary { get; set; }
		#endregion

		#region Constructor
		/// <summary>
		/// Constructor to receive user input values.
		/// </summary>
		/// <param name="firstName"></param>
		/// <param name="lastName"></param>
		/// <param name="startDate"></param>
		/// <param name="annualSalary"></param>
		public Employee(String firstName, String lastName, DateTime startDate, Double annualSalary)
		{
			FirstName = firstName;
			LastName = lastName;
			StartDate = startDate;
			AnnualSalary = annualSalary;
		}
		#endregion

		#region methods GetYearsOfService
		/// <summary>
		/// Calculate the yeares of service and retur integer value.
		/// </summary>
		/// <returns></returns>
		public Int32 GetYearsOfService()
		{
			var year = DateTime.Today.Year - StartDate.Year;
			var month = DateTime.Today.Month - StartDate.Month;
			var day = DateTime.Today.Day - StartDate.Day;

			var resultValue = 0;

			if(year == 0)
			{
				return resultValue;
			}

			if (Convert.ToInt32(month) > 0)
			{
				resultValue = year;
			}
			else if(month == 0 && day >= 0)
			{
				resultValue = year;
			}
			else
			{
				resultValue = year - 1;
			}

			return resultValue;
		}
		#endregion
	}
}
