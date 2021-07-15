using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPFinalExam
{
	public partial class WorkRecords : Form
	{
		public WorkRecords()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			lblMessage.Text = "";
			Work work = new Work();
			Int32 workId;
			Double hoursWorked, hourlyRate;
			var errorMessage = "";


			if (Int32.TryParse(txtWorkId.Text, out workId))
			{
				work.WorkId = workId;
			}
			else
			{
				errorMessage += "Work Id must be an integer number\n";
			}

			work.ContractName = txtContractName.Text;
			work.ContractStartDate = datStartDate.Value;
			work.ConsultantName = txtConsultanName.Text;
			work.DateWorked = datDateWorked.Value;

			if (Double.TryParse(txtHoursWorked.Text, out hoursWorked))
			{
				work.HoursWokred = hoursWorked;
			}
			else
			{
				errorMessage += "HoursWorked must be an number\n";
			}

			if (Double.TryParse(txtHourlyRate.Text, out hourlyRate))
			{
				work.HourlyRate = hourlyRate;
			}
			else
			{
				errorMessage += "HoursWorked must be an number\n";
			}

			try
			{
				work.Add();
				lblMessage.Text = "record saved for work Id " + txtWorkId.Text;
			}
			catch (Exception ex)
			{
				lblMessage.Text = ex.Message;
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			lblMessage.Text = "";
			Work work = new Work();
			Int32 workId;
			Double hoursWorked, hourlyRate;
			var errorMessage = "";


			if (Int32.TryParse(txtWorkId.Text, out workId))
			{
				work.WorkId = workId;
			}
			else
			{
				errorMessage += "Work Id must be an integer number\n";
			}

			work.ContractName = txtContractName.Text;
			work.ContractStartDate = datStartDate.Value;
			work.ConsultantName = txtConsultanName.Text;
			work.DateWorked = datDateWorked.Value;

			if (Double.TryParse(txtHoursWorked.Text, out hoursWorked))
			{
				work.HoursWokred = hoursWorked;
			}
			else
			{
				errorMessage += "HoursWorked must be an number\n";
			}

			if (Double.TryParse(txtHourlyRate.Text, out hourlyRate))
			{
				work.HourlyRate = hourlyRate;
			}
			else
			{
				errorMessage += "HoursWorked must be an number\n";
			}

			try
			{
				work.Update();
				lblMessage.Text = "record update for work Id " + txtWorkId.Text;
			}
			catch (Exception ex)
			{
				lblMessage.Text = ex.Message;
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnDisplay_Click(object sender, EventArgs e)
		{
			List<Work> works = Work.GetWorkRecords();
			gridResult.Rows.Clear();
			gridResult.ColumnCount = 4;

			gridResult.Columns[0].Name = "Contract";
			gridResult.Columns[1].Name = "Start Date";
			gridResult.Columns[2].Name = "Hours Worked";
			gridResult.Columns[3].Name = "Total Charge";

			works = works.OrderBy(work => work.ContractName).ToList();

			foreach (var item in works)
			{
				var fields = item.ToString().Split('\t');

				Double hoursWorked = Convert.ToDouble(fields[5]); 
				Double hourlyRate = Convert.ToDouble(fields[6]);
				Double totalCharge = hoursWorked * hourlyRate;
				
				string startDate = Convert.ToDateTime(fields[2]).ToString("yyyy-MM-dd");
				string contractName = fields[1];
				string totalHours = String.Format("{0:N}", hoursWorked);

				string[] result =
				{
					contractName,
					startDate,
					totalHours,
					totalCharge.ToString("C2")
				};

				gridResult.Rows.Add(result);
			}
		}
	}
}
