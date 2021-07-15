/* SPStock.cs
 * Assignment 4  - Implementation of stock maintenance application which is exercise in file I/O and encapsulate class.
 * 
 *
 * Revision History
 *		Sangbong Park, 2021.04.06: Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assigment4.SPClasses
{
	class SPStock
	{
		#region properties
		public Int32 StockId { get; set; }
		public String Name { get; set; }
		public String Description { get; set; }
		public Double Price { get; set; }
		public Int32 Minutes { get; set; }
		public Boolean IsProcedure { get; set; }
		#endregion

		#region variables
		public static String stockPath = "Stock.txt";
		#endregion

		#region constructor
		public SPStock()
		{

		}

		#endregion

		#region get methods

		/// <summary>
		/// Load the data from the file and return the list of stocks.
		/// </summary>
		/// <returns></returns>
		public static List<SPStock> SPGetStocks()
		{
			verifyFile();
			var stocks = new List<SPStock>();

			try
			{

				using (StreamReader reader = new StreamReader(stockPath))
				{
					while (!reader.EndOfStream)
					{
						stocks.Add(SPParse(reader.ReadLine()));
					}
				}
			}
			catch (Exception ex)
			{

				throw new Exception("exception reading recod: " + ex.Message); 
			}
			

			return stocks;
		}

		/// <summary>
		/// Get stockId and find the stock object from the file.
		/// then stock object is returned.
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static SPStock SPGetByStockId(Int32 input)
		{
			var record = "";
			SPStock stock = null;

			try
			{
				using (StreamReader reader = new StreamReader(stockPath))
				{
					while (!reader.EndOfStream)
					{
						record = reader.ReadLine();
						if (record.StartsWith(input.ToString() + '\t'))
						{
							stock = SPParse(record);
						}
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception("exception reading recod: " + ex.Message);
			}

			return stock;
		}

		/// <summary>
		/// Get string parameter which is name or descripton
		/// then return stock lists which is matched with name or description.
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static List<SPStock> SPGetByDescription(string input)
		{
			var record = "";
			List<SPStock> stocks = new List<SPStock>();

			try
			{
				using (StreamReader reader = new StreamReader(stockPath))
				{
					while (!reader.EndOfStream)
					{
						record = reader.ReadLine();
						string[] fields = record.Split('\t');

						if (fields[1] == input || fields[2].Contains(input))
						{
							stocks.Add(SPParse(record));
						}
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception("exception reading recod: " + ex.Message);
			}

			return stocks;
		}
		#endregion

		#region Edit, Add, Update, Delete methods

		//check properties if these are not valid, exception handling is occured.
		private void SPEdit()
		{
			var errorMessage = "";

			//Trim all strings, converting nulls into an empty string.
			Name = Name.Trim() != null?Name.Trim():"";
			Description = Description.Trim() != null ? Description.Trim() : "";

			if(StockId == 0)
			{
				StockId = FindUnitquStockId();
			}
			else if (StockId != 0)
			{
				if (SPGetByStockId(StockId) == null)
				{
					errorMessage += $" Property 'StockId' is {StockId}. It is not on file\n";
				}
			}

			if (string.IsNullOrWhiteSpace(Name))
			{
				errorMessage += $" Property 'Name' is required.\n";
			}
			else
			{
				SPGetByDescription(Name).ForEach(stock => {
					if (stock.Name == Name && stock.StockId != StockId)
					{
						errorMessage += $" Property 'Name' is {Name}. It is not unique on the file\n";
					}
				});
			}

			if (string.IsNullOrWhiteSpace(Description))
			{
				errorMessage += $" Property 'Description' is required.\n";
			}

			if (Price < 0)
			{
				errorMessage += $" Property 'Price' is {Price}. It cannot be less than zero.\n";
			}

			if (Minutes < 0)
			{
				errorMessage += $" Property 'Minutes' is {Minutes}. It cannot be less than zero.\n";
			}

			if (IsProcedure == false)
			{
				if (Minutes != 0)
				{
					errorMessage += $" Property 'Minutes' is {Minutes}. It must be zero when it is not a procedure.\n";
				}
			}

			if (!string.IsNullOrWhiteSpace(errorMessage))
			{
				throw new Exception(errorMessage);
			}
		}


		//If properties are valid in SPEdit, properties are stored to file.
		public void SPAdd()
		{
			SPEdit();

			try
			{
				using (StreamWriter writer = new StreamWriter(stockPath, append: true))
				{
					writer.WriteLine(ToString());
				}
			}
			catch (Exception ex)
			{

				throw new Exception("exception writing recod: " + ex.Message);
			}
		}

		//If all of properties are valid, laod the all data from the file and then replace item which is matched with user input
		public void SPUpdate()
		{
			SPEdit();

			var stocks = SPGetStocks();

			try
			{
				using (StreamWriter writer = new StreamWriter(stockPath, append: false))
				{
					stocks.ForEach(stock =>
					{
						if (stock.StockId == this.StockId)
						{
							stock.Minutes = this.Minutes;
							stock.Name = this.Name;
							stock.Price = this.Price;
							stock.Description = this.Description;
							stock.IsProcedure = this.IsProcedure;
						}
						writer.WriteLine(stock.ToString());
					});
				}
			}
			catch (Exception ex)
			{
				throw new Exception("exception writing recod: " + ex.Message);
			}
		}


		//Load the all data from the file and delete a stock object if it is matched with selected item.
		public static void SPDelete(string stockId)
		{
			var stocks = SPGetStocks();

			try
			{
				using (StreamWriter writer = new StreamWriter(stockPath, append: false))
				{
					stocks.ForEach(stock =>
					{
						if (stock.StockId != Convert.ToInt32(stockId))
						{
							writer.WriteLine(stock.ToString());
						}
					});
				}
			}
			catch (Exception ex)
			{
				throw new Exception("exception writing recod: " + ex.Message);
			}
		}
		#endregion

		#region Utility methods

		//If file is not exsited, file will be created
		private static void verifyFile()
		{
			try
			{
				if (!File.Exists(stockPath))
				{
					File.Create(stockPath).Dispose();
				}
			}
			catch (Exception ex )
			{
				throw new Exception("exception creating file: " + ex.Message);
			}

		}


		//overriding method for ToString();
		//It lists all properties and return
		public override string ToString()
		{
			return $"{StockId}\t{Name}\t{Description}\t{Price}\t{Minutes}\t{IsProcedure}";
		}

		//Parse the data which is listed data from the file.
		public static SPStock SPParse(String input)
		{
			string[] fields = input.Split('\t');

			SPStock stock = new SPStock()
			{
				StockId = Convert.ToInt32(fields[0]),
				Name = fields[1],
				Description = fields[2],
				Price = Convert.ToDouble(fields[3]),
				Minutes = Convert.ToInt32(fields[4]),
				IsProcedure = Convert.ToBoolean(fields[5])
			};

			return stock;
		}

		// Find unique stockid as a possible small value from the files.
		private Int32 FindUnitquStockId()
		{
			var index = 1;

			SPGetStocks().ForEach(stock => {
				if (index == stock.StockId)
				{
					index++;
				}
			});

			return index;
		}

		#endregion

	}
}
