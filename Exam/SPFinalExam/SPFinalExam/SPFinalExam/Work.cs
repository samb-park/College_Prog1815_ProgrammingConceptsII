using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPFinalExam
{
	class Work
	{
		#region Properties

		public Int32 WorkId { get; set; }
		public String ContractName { get; set; }
		public DateTime ContractStartDate { get; set; }
		public String ConsultantName { get; set; }
		public DateTime DateWorked { get; set; }
		public Double HoursWokred { get; set; }
		public Double HourlyRate { get; set; }

		#endregion

		public Work()
		{
			WorkId = 0;
		}

		#region variables
		private static string fileName = "work.txt";
		private static string archive = "archive.txt";
		private static StreamReader reader;
		private static StreamWriter writer;
		#endregion

		#region Get methods

		static public List<Work> GetWorkRecords()
		{
			CheckFile();
			List<Work> work = new List<Work>();

			using (reader = new StreamReader(fileName))
			{
				var record = "";
				while (!reader.EndOfStream)
				{
					record = reader.ReadLine();

					work.Add(Parse(record));
				}
			}

			return work;
		}

		static public Work GetWorkRecordById(Int32 workId)
		{
			CheckFile();
			Work work = null;

			using (reader = new StreamReader(fileName))
			{
				var record = "";
				while (!reader.EndOfStream)
				{
					record = reader.ReadLine();
					if (record.StartsWith(workId.ToString() + "\t"))
					{
						work = Parse(record);
						break;
					}
				}
			}

			return work;
		}

		static public Work GetWorkRecordsByCotract(String contractName)
		{
			CheckFile();
			Work work = null;

			using (reader = new StreamReader(fileName))
			{
				var record = "";
				while (!reader.EndOfStream)
				{
					record = reader.ReadLine();
					if (record.StartsWith(contractName + "\t"))
					{
						work = Parse(record);
						break;
					}
				}
			}

			return work;
		}
		#endregion

		#region Add, Update, Edit Methods
		public void Add()
		{
			Edit();

			var exsistingWork = GetWorkRecordById(WorkId);

			if(exsistingWork != null)
			{
				throw new Exception("WorkId is already in the file.\n");
			}

			try
			{
				using (writer = new StreamWriter(fileName, append: true))
				{
					writer.WriteLine(ToString());
				}
			}
			catch (Exception ex)
			{
				throw new Exception("exception trying to add new record:\n" + ex.Message);
			}

		}

		public void Update()
		{
			Edit();

			var exsistingWork = GetWorkRecordById(WorkId);

			if (exsistingWork == null)
			{
				throw new Exception("WorkId is not in the file.\n");
			}

			try
			{
				if (File.Exists(archive))
				{
					File.Delete(archive);
				}
				File.Move(fileName, archive);

			}
			catch (Exception ex)
			{
				throw new Exception("exception trying to archive before update:\n" + ex.Message);
			}

			try
			{
				var record = "";
				using (reader = new StreamReader(archive))
				{
					using (writer = new StreamWriter(fileName, false))
					{
						while (!reader.EndOfStream)
						{
							record = reader.ReadLine();
							if (record.StartsWith(WorkId.ToString() + "\t"))
							{
								writer.WriteLine(ToString());
							}
							else
							{
								writer.WriteLine(record);
							}
						}
					}
				}
				File.Delete(archive);
			}
			catch (Exception ex)
			{
				throw new Exception("exception trying to update exiting record:\n" + ex.Message);
			}
		}

		private void Edit()
		{
			var errorMessage = "";

			ContractName = (ContractName + "").Trim();
			ConsultantName = (ConsultantName + "").Trim();

			if (WorkId <= 0)
			{
				errorMessage += "The WorkId must be greater than zero.\n";
			}

			if (String.IsNullOrWhiteSpace(ContractName))
			{
				errorMessage += "ContractName must not be all spaces.\n";
			}
			else if(ContractName.Length <3 || ContractName.Length>40)
			{
				errorMessage += "ContractName must be minimum 3 characters trimmed, max 40 characters.\n";
			}
			
			if(ContractStartDate > DateTime.Today)
			{
				errorMessage += "The ContractStartDate must not be in the future.\n";
			}

			if (String.IsNullOrWhiteSpace(ConsultantName))
			{
				errorMessage += "ConsultantName must not be all spaces.\n";
			}
			else if (ConsultantName.Length < 3 || ConsultantName.Length > 40)
			{
				errorMessage += "ConsultantName must be minimum 3 characters trimmed, max 40 characters.\n";
			}

			if (DateWorked > DateTime.Today)
			{
				errorMessage += "The DateWorked must not be in the future.\n";
			}
			else if(DateWorked < ContractStartDate)
			{
				errorMessage += "The DateWorked must not be in the ContractStartDate.\n";
			}

			if (HoursWokred <= 0)
			{
				errorMessage += "The HoursWokred must be greater than zero.\n";
			}

			if (HourlyRate < 0)
			{
				errorMessage += "The HourlyRate must be greater than zero.\n";
			}

			if (errorMessage != "")
			{
				throw new Exception(errorMessage);
			}
		}
		#endregion

		#region Utilites methods

		public override string ToString()
		{
			return $"{WorkId}\t{ContractName}\t{ContractStartDate}\t{ConsultantName}\t{DateWorked}\t{HoursWokred}\t{HourlyRate}\t"; ;
		}
		private static Work Parse(string records)
		{
			Work work = new Work();

			string[] fields = records.Split('\t');

			work.WorkId = Convert.ToInt32(fields[0]);
			work.ContractName = fields[1];
			work.ContractStartDate = Convert.ToDateTime(fields[2]);
			work.ConsultantName = fields[3];
			work.DateWorked = Convert.ToDateTime(fields[4]);
			work.HoursWokred = Convert.ToDouble(fields[5]);
			work.HourlyRate = Convert.ToDouble(fields[6]);

			return work;
		}

		private static void CheckFile()
		{
			if (!File.Exists(fileName))
			{
				if (File.Exists(archive))
				{
					File.Move(archive, fileName);
				}
				else
				{
					File.Create(fileName).Dispose();
				}
			}
		}

		#endregion

}
}
