/* StockPortfolioTracker.cs
 * Assignment 3  - Implementation of stock portfolio track application using FileIo for Assignment3
 * 
 *
 * Revision History
 *		Sangbong Park, 2021.03.16: Created
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
using System.IO;
using System.Text.RegularExpressions;

namespace Assignment3
{
	public partial class StockPortfolioTracker : Form
	{
		public StockPortfolioTracker()
		{
			InitializeComponent();
		}
		

		//Initialize variables.
		private void Assignment3_Load(object sender, EventArgs e)
		{
			txtPathFile.Text = @"c:\peter\src\dotnet\assignments\txn-record-test1.txt";
			gridView.Rows.Clear();
			gridView.RowHeadersVisible = false;
			gridView.ReadOnly = true;
			gridView.AllowUserToAddRows = false;
			gridView.AllowUserToResizeColumns = false;
			gridView.ColumnCount = 10;
			gridView.Columns[0].Name = "Transaction ID";
			gridView.Columns[1].Name = "Tricker Symbol";
			gridView.Columns[2].Name = "Company";
			gridView.Columns[3].Name = "Transaction Type";
			gridView.Columns[4].Name = "Date";
			gridView.Columns[5].Name = "Share Price";
			gridView.Columns[6].Name = "# Share";
			gridView.Columns[7].Name = "Commission";
			gridView.Columns[8].Name = "Total Asset Value";
			gridView.Columns[9].Name = "Total Transaction Value";

			gridView.ColumnHeadersVisible = false;
			dateInput.MaxDate = DateTime.Now;
		}

		//It opens or creates a file and then updates the gridView.
		private void btnCreateOpen_Click(object sender, EventArgs e)
		{
			txtMessage.Text = "";
			gridView.Rows.Clear();
			txtPathFile.Text = (txtPathFile.Text + "").Trim();

			if (string.IsNullOrWhiteSpace(txtPathFile.Text))
			{
				txtMessage.Text += "Path and file are required.";
				txtMessage.Focus();
				return;
			}
			else if (File.Exists(txtPathFile.Text))
			{
				txtMessage.Text += "File loads";
			}
			else
			{
				CreateFile(txtPathFile.Text);
				txtMessage.Text += "New file creates";
			}
			gridView.ColumnHeadersVisible = true;
			CreateArchive();
			UpdateGridView(ReadAllRecords(txtPathFile.Text));
		}

		//Find and return the smallest value that does not overlap the data.
		private void btnGetNewId_Click(object sender, EventArgs e)
		{
			var data = ReadArchiveData();
			var pathFileName = data[0];
			var isOpenFile = Convert.ToBoolean(data[1]);

			if (isOpenFile == false)
			{
				txtMessage.Text = "Please create or open a file.\n";
				btnCreateOpen.Focus();
				return;
			}

			var records = ReadAllRecords(pathFileName);
			var ids = new int[records.Count];
			var index = 0;
			var newValue = 1;

			if (records.Count == 0)
			{
				txtTransactionId.Text = "1";
				return;
			}

			records.ForEach(record=> {
				ids[index++] = Int32.Parse(record.Split('\t')[0]);
			});

			Array.Sort(ids);

			for (int i = 0; i < ids[records.Count-1]; i++)
			{
				if (ids[i] <= newValue)
				{
					newValue++;
				}
				else
				{
					break;
				}
			}

			txtMessage.Text = $"Transaction ID ({newValue}) generates\n";
			txtTransactionId.Text = newValue.ToString();
		}

		//After checking if the value obtained in the field is valid,
		//update the existing data in the file if id exists, and add the data if new id.
		private void btnAddUpdate_Click(object sender, EventArgs e)
		{
			var data = ReadArchiveData();
			var pathFileName = data[0];
			var isOpenFile = Convert.ToBoolean(data[1]);

			if (isOpenFile == false)
			{
				txtMessage.Text = "Please create or open a file.\n";
				btnCreateOpen.Focus();
				return;
			}

			txtMessage.Text = "";
			var record = "";
			var errorMessage = ValidateFields(ref record);

			if (errorMessage == "")
			{
				var records = ReadAllRecords(pathFileName);
				var index = FindRecord(record.Split('\t')[0]);
				if (index == -1)
				{
					records.Add(record);
					AddRecord(record);
					UpdateGridView(records);
					txtMessage.Text = $"New item added\n";
				}
				else
				{
					UpdateRecord(index, record);
					txtMessage.Text = $"Item {index} updated\n";
				}
			}
			else
			{
				txtMessage.Text = errorMessage;
			}
		}

		//Clear all values in the field.
		private void btnClear_Click(object sender, EventArgs e)
		{
			var data = ReadArchiveData();
			var isOpenFile = Convert.ToBoolean(data[1]);

			if (isOpenFile == false)
			{
				txtMessage.Text = "Please create or open a file.\n";
				btnCreateOpen.Focus();
				return;
			}

			txtTransactionId.Text = "";
			txtTickerSymbol.Text = "";
			txtCompany.Text = "";
			radioBuy.Checked = true;
			dateInput.Value = DateTime.Today;
			txtNotes.Text = "";
			txtSharePrice.Text = "";
			txtNumberOfShare.Text = "";
			txtCommission.Text = "";

			txtMessage.Text = "All fields clear\n";
		}

		//Delete the entered value if it exists in the data.
		private void btnDeleteId_Click(object sender, EventArgs e)
		{
			var data = ReadArchiveData();
			var pathFileName = data[0];
			var isOpenFile = Convert.ToBoolean(data[1]);

			if (isOpenFile == false)
			{
				txtMessage.Text = "Please create or open a file.\n";
				btnCreateOpen.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(txtDeleteId.Text))
			{
				txtMessage.Text = "Transaction Id is requried to delete\n";
				txtDeleteId.Focus();
				return;
			}

			var index = FindRecord(txtDeleteId.Text);
			if(index == -1)
			{
				txtMessage.Text = "Records not found.\n";
				txtDeleteId.Focus();
				return;
			}

			UpdateRecord(index, "");

			
		}

		//If there are no files and directories, create them.
		private void CreateFile(string pathAndFileName)
		{
			var path = Path.GetDirectoryName(pathAndFileName);
			var fileName = Path.GetFileName(pathAndFileName);

			try
			{
				if (!Directory.Exists(path) && path != "")
				{
					Directory.CreateDirectory(path);
					txtMessage.Text += "Directory created\n";
				}
				File.Create(pathAndFileName).Dispose();
			}
			catch (IOException ex)
			{
				txtMessage.Text = "IOException :" + ex.Message;
			}
			catch(ArgumentNullException ex)
			{
				txtMessage.Text = "ArgumentNullException :" + ex.Message;
			}
			catch (Exception ex)
			{
				txtMessage.Text = "Expception :" + ex.Message;
			}
		}
	

		//The data is loaded from the file and returned to the list type.
		private List<string> ReadAllRecords(string pathAndFileName)
		{
			var record = new List<string>();

			try
			{
				using (StreamReader reader = new StreamReader(pathAndFileName))
				{
					while (!reader.EndOfStream)
					{
						record.Add(reader.ReadLine());
					}
				}
			}
			catch(IOException ex)
			{
				txtMessage.Text = "IOException :" + ex.Message;
			}

			catch(ArgumentException ex)
			{
				txtMessage.Text = "ArgumentException :" + ex.Message;
			}
			catch (Exception ex)
			{
				txtMessage.Text = "Exception :" + ex.Message;
			}

			return record;
		}

		//Create Archive file. It stores data which are file path, name and flag. Flag checks that the file is loaded.
		private void CreateArchive()
		{
			var archiveData = new List<string>();

			CreateFile(@".\archive.txt");

			archiveData.Add(txtPathFile.Text);
			archiveData.Add("true");

			WriteAllRecord(archiveData,"archive.txt");
		}

		//Loads the file path, name and flag.
		private List<string> ReadArchiveData()
		{
			var archive = ReadAllRecords(@"archive.txt");

			if(archive.Count != 2)
			{
				archive.Add("");
				archive.Add("false");
			}

			return archive;
		}

		//Delete archive file if there is archive.txt.
		private void deleteArchive()
		{
			var archive = @"archive.txt";

			if (File.Exists(archive))
			{
				File.Delete(archive);
			}
				
		}

		//This methods is to allow mulitline with '\n' in Notes field. When records are loaded from file, '\\' will parse to '\n' in Notes field.
		private string ParseFromNote(string input)
		{
			return input.Replace('\\', '\n'); 
		}

		//This methods is to allow mulitline with '\n' in Notes field. When records are stored to file, '\n' will conver to '\\'.
		private string ParseToNote(string input)
		{
			return input.Replace('\n', '\\');
		}


		//The list which contains the transaction data is received and the data is stored in a file.
		private void WriteAllRecord(List<string> records, string pathAndFileNaem)
		{
			try
			{
				using (StreamWriter writer = new StreamWriter(pathAndFileNaem, append: false))
				{
					records.ForEach(record =>
					{
						writer.WriteLine(record);
					});
				}
				UpdateGridView(records);
			}
			catch (Exception ex)
			{
				txtMessage.Text += "Expception :" + ex.Message;
			}
		}

		//Add one record last in the file
		private void AddRecord(string record)
		{
			try
			{
				using (StreamWriter writer = new StreamWriter(txtPathFile.Text, append: true))
				{
					writer.WriteLine(ParseToNote(record));
				}
			}
			catch (Exception ex)
			{
				txtMessage.Text += "Expception :" + ex.Message;
			}
		}


		//Find the added record in the file and return it to which number it is in.
		private Int32 FindRecord(string recordId)
		{
			var index = 0;
			var isFound = false;
			var pathFileName = ReadArchiveData()[0];
			var records = ReadAllRecords(pathFileName);

			for(index = 0; index < records.Count; index++)
			{
				if (records[index].Split('\t')[0] == recordId)
				{
					isFound = true;
					break;
				}
			}

			return (isFound == true) ?index:-1;
		}


		//Update selected index if parameter record is not null.
		//If parameter record contains the data, replace with this.
		private void UpdateRecord(Int32 index, string record)
		{
			var pathFileName = ReadArchiveData()[0];
			var records = ReadAllRecords(pathFileName);
			var temp = new List<string>();

			if (record == "")
			{
				for(int i = 0; i < records.Count; i++)
				{
					if(i != index)
					{
						temp.Add(records[i]);
					}
				}
			}
			else
			{
				for (int i = 0; i < records.Count; i++)
				{
					if (i != index)
					{
						temp.Add(records[i]);
					}
					else
					{
						temp.Add(record);
					}
				}
			}
			WriteAllRecord(temp,txtPathFile.Text);
		}

		//Receive the list as a parameter and update the grid view.
		private void UpdateGridView(List<string> records)
		{
			gridView.Rows.Clear();

			records.ForEach(record=> { 
				gridView.Rows.Add(record.Split('\t')); 
			});
		}

		//Check if the value entered in the field is valid and returns an error message.
		//If valid, store the new record in the string parameter.
		private string ValidateFields(ref string records)
		{
			var errorMessage = "";
			var buyOrCell = "BUY";

			Int32 transactionId = 0;
			Int32 numOfShares = 0;
			Double sharePrice = 0.0;
			Double commission = 0.0;

			if (string.IsNullOrWhiteSpace(txtTransactionId.Text))
			{
				if (errorMessage == "")
				{
					txtTransactionId.Focus();
				}
				errorMessage += "Transaction ID is required\n";
			}
			else if (!Int32.TryParse(txtTransactionId.Text, out transactionId))
			{

				if (errorMessage == "")
				{
					txtTransactionId.Focus();
				}
				errorMessage += "Transaction ID must be numberic\n";
			}
			else
			{
				if (transactionId <= 0)
				{
					if (errorMessage == "")
					{
						txtTransactionId.Focus();
					}
					errorMessage += "Transaction ID must be great than zero\n";
				}
			}

			if (string.IsNullOrWhiteSpace(txtTickerSymbol.Text))
			{
				if (errorMessage == "")
				{
					txtTickerSymbol.Focus();
				}
				errorMessage += "Ticker symbol is required\n";
			}


			if (string.IsNullOrWhiteSpace(txtCompany.Text.Trim()))
			{
				if (errorMessage == "")
				{
					txtCompany.Focus();
				}
				errorMessage += "Compnay is required\n";
			}


			if (!radioBuy.Checked)
			{
				buyOrCell = "SELL";
			}

			if (DateTime.Now < dateInput.Value)
			{
				if (errorMessage == "")
				{
					dateInput.Focus();
				}
				errorMessage += "Input date is in future\n";
			}

			if (string.IsNullOrWhiteSpace(txtNotes.Text))
			{
				if (errorMessage == "")
				{
					txtNotes.Focus();
				}
				errorMessage += "Notes is required\n";
			}

			if (string.IsNullOrWhiteSpace(txtSharePrice.Text))
			{
				if (errorMessage == "")
				{
					txtSharePrice.Focus();
				}
				errorMessage += "Share price is required\n";
			}
			else if (!Double.TryParse(txtSharePrice.Text, out sharePrice))
			{
				if (errorMessage == "")
				{
					txtSharePrice.Focus();
				}
				errorMessage += "Share price must be numberic.\n";
			}
			else
			{
				if (sharePrice <= 0)
				{
					if (errorMessage == "")
					{
						txtSharePrice.Focus();
					}
					errorMessage += "Share price must be great than zero\n";
				}
			}

			if (string.IsNullOrWhiteSpace(txtNumberOfShare.Text))
			{
				if (errorMessage == "")
				{
					txtNumberOfShare.Focus();
				}
				errorMessage += "Number of shares is required\n";
			}
			else if (!Int32.TryParse(txtNumberOfShare.Text, out numOfShares))
			{
				if (errorMessage == "")
				{
					txtNumberOfShare.Focus();
				}
				errorMessage += "Number of shares must be numberic.\n";
			}
			else
			{
				if (numOfShares <= 0)
				{
					if (errorMessage == "")
					{
						txtNumberOfShare.Focus();
					}
					errorMessage += "Number of share must be great than zero.\n";
				}
			}

			if (string.IsNullOrWhiteSpace(txtCommission.Text))
			{
				if (errorMessage == "")
				{
					txtCommission.Focus();
				}
				errorMessage += "Commission is required.\n";
			}
			else if (!Double.TryParse(txtCommission.Text, out commission))
			{
				if (errorMessage == "")
				{
					txtCommission.Focus();
				}
				errorMessage += "Commision must be numeric.\n";
			}
			else
			{
				if (numOfShares <= 0)
				{
					if (errorMessage == "")
					{
						txtCommission.Focus();
					}
					errorMessage += "Commission must be great than zero.\n";
				}
			}

			if (errorMessage == "")
			{
				var totalAssetValue = numOfShares * sharePrice;
				records = $"{transactionId.ToString()}\t" 
						+ $"{txtTickerSymbol.Text.Trim()}\t"
						+ $"{txtCompany.Text.Trim()}\t"
						+ $"{buyOrCell}\t"
						+ $"{dateInput.Value.ToString("yyyy-MM-dd")}\t"
						+ $"{sharePrice.ToString("C")}\t"
						+ $"{numOfShares.ToString()}\t"
						+ $"{commission.ToString("C")}\t"
						+ $"{totalAssetValue.ToString("C")}\t"
						+ $"{(totalAssetValue + commission).ToString("C")}\t"
						+ ParseToNote(txtNotes.Text.Trim());
			}

			return errorMessage;
		}

		//Close the form.
		private void btnExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		//Relaod the data from the file and update the gridview.
		private void btnReadFile_Click(object sender, EventArgs e)
		{
			var data = ReadArchiveData();
			var pathFileName = data[0];
			var isOpenFile = Convert.ToBoolean(data[1]);

			if (isOpenFile == false)
			{
				txtMessage.Text = "Please create or open a file.\n";
				btnCreateOpen.Focus();
				return;
			}

			UpdateGridView(ReadAllRecords(pathFileName));
			txtMessage.Text = "File reloads\n";
		}

		//Remove all data in the file.
		private void btnEmptyFile_Click(object sender, EventArgs e)
		{
			var data = ReadArchiveData();
			var pathFileName = data[0];
			var isOpenFile = Convert.ToBoolean(data[1]);

			if (isOpenFile == false)
			{
				txtMessage.Text = "Please create or open a file.\n";
				btnCreateOpen.Focus();
				return;
			}

			var emptyRecord = new List<string>();

			WriteAllRecord(emptyRecord,txtPathFile.Text);

			txtMessage.Text = "All Lists delete.\n";
		}

		//When user double-click a cell in a gridView,
		//the corresponding rows value is updated in the field.
		private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var data = ReadArchiveData();
			var pathFileName = data[0];
			var isOpenFile = Convert.ToBoolean(data[1]);

			if (isOpenFile == false)
			{
				txtMessage.Text = "Please create or open a file.\n";
				btnCreateOpen.Focus();
				return;
			}

			var index = gridView.CurrentRow.Index;
			var fields = ReadAllRecords(pathFileName)[index].Split('\t');

			radioBuy.Checked = true;
			txtTransactionId.Text = fields[0];
			txtTickerSymbol.Text = fields[1];
			txtCompany.Text = fields[2];

			if (fields[3] == "SELL")
			{
				radioSell.Checked = true;
			}

			dateInput.Value = DateTime.Parse(fields[4]);
			txtNotes.Text = ParseFromNote(fields[10]);
			txtSharePrice.Text = fields[5].Substring(1);
			txtNumberOfShare.Text = fields[6];
			txtCommission.Text = fields[7].Substring(1);
	
			txtMessage.Text = $"Row {index} loads";
		}

		//delete archive file when application is closed
		private void StockPortfolioTracker_FormClosed(object sender, FormClosedEventArgs e)
		{
			deleteArchive();
		}
	}

}


