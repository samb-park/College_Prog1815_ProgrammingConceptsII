/* VenueBooking.cs
 * Assignment 1  - Implementation of venue booking application which includes features such as Booking, Cancelation and adding waiting list.
 * 
 *
 * Revision History
 *		Sangbong Park, 2021.01.31: Created
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

namespace Assignment1
{
	public partial class VenueBooking : Form
	{
		public VenueBooking()
		{
			InitializeComponent();
		}

		//Initialize global variables.
		private string[,] storedBookLists = new string[5, 6];
		private string[] storedWatingLists = new string[11];
		private uint currentIndexForWaitingLists = 0;

		//Button event handler : It will close the application.
		private void btnExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		//Button event handler : It fills as "Debug" in the storedBookList array for debugging.
		private void btnDebug_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < storedBookLists.GetLength(0); i++)
			{
				for (int j = 0; j < storedBookLists.GetLength(1); j++)
				{
					storedBookLists[i, j] = "Debug";
				}
			}
		}

		//Button event handler : It displays the seat lists which are stored in the storedBookLists array to the RichTextBox.
		private void btnShowAllReservations_Click(object sender, EventArgs e)
		{
			//Clear the rich text box
			txtAllReservationLists.Text = "";

			for (int i = 0; i < storedBookLists.GetLength(0); i++)
			{
				for (int j = 0; j < storedBookLists.GetLength(1); j++)
				{
					txtAllReservationLists.Text += $"{lstRow.Items[i]}{lstSeat.Items[j]} - {storedBookLists[i, j]}\n";
				}
			}
		}

		//Button event handler : It displays the waiting lists which are stored in the currentIndexForWaitingLists array to the RichTextBox.
		private void btnShowWaitingLists_Click(object sender, EventArgs e)
		{
			//Clear the rich text box
			txtWatingLists.Text = "";

			for (int i = 0; i < storedWatingLists.GetLength(0); i++)
			{
				txtWatingLists.Text += $"{i+1} - {storedWatingLists[i]}\n";
			}
		}


		//Button event handler : It handles booking, cancelation and wating lists from arrays.
		private void ManageSeatLists_Click(object sender, EventArgs e)
		{
			Button source = sender as Button;
			var resultMessage = "";

			//Clear the Label.
			lblMessage.Text = "";

			switch (source.Text)
			{
				//It is for a "Book" button.
				case "Book":
					resultMessage = $"Request Booking\n{IsBookingPossible(sender,e)}";

					//If there is any error message, seat reservations are skipped.
					if (resultMessage == "Request Booking\n")
					{
						resultMessage += "Compleate Booking.";
						storedBookLists[lstRow.SelectedIndex, lstSeat.SelectedIndex] = txtCustomerName.Text;
					}

					lblMessage.Text = resultMessage;

					break;

				//It is for a "Cancel" button.
				case "Cancel":
					resultMessage = $"Request Cancel\n{IsCancellationPossible()}";

					//If there is any error message, cancellation of reserved seats is skipped.
					if (resultMessage == "Request Cancel\n")
					{
						//MessageBox requests to ask confirmation. If user confirms, reserved seat will be reserved.
						if(MessageBox.Show($"Would you like to cancel {storedBookLists[lstRow.SelectedIndex, lstSeat.SelectedIndex]}'s seat?", "Cancel booking",MessageBoxButtons.YesNo) == DialogResult.Yes)
						{
							resultMessage += "Compleate to cancel.";
							storedBookLists[lstRow.SelectedIndex, lstSeat.SelectedIndex] = null;

							//When the user cancels, the first customer in the waiting list is booked.						
							if (currentIndexForWaitingLists > 0)
							{
								// the first customer on the waiting list is booked to cancelled seats 
								storedBookLists[lstRow.SelectedIndex, lstSeat.SelectedIndex] = storedWatingLists[0];

								for (int i = 0; i < currentIndexForWaitingLists; i++)
								{
									storedWatingLists[i] = storedWatingLists[i + 1];
								}

								currentIndexForWaitingLists--;
							}
						}
						
					}

					lblMessage.Text = resultMessage;

					break;

				//It is for a "Add to Waiting" button.
				case "Add to Waiting":
					resultMessage = $"Add to Waiting\n{IsAddingWaitingPossible(sender, e)}";

					//If there is any error message, Adding to waiting is skipped.
					if (resultMessage == "Add to Waiting\n")
					{
						resultMessage += "Compleate to add to waiting";
						storedWatingLists[currentIndexForWaitingLists] = txtCustomerName.Text;
						currentIndexForWaitingLists++;
					}

					lblMessage.Text = resultMessage;

					break;
			}
		}

		//This method check whether booking for seats is available and return error message.
		private string IsBookingPossible(object sender, EventArgs e)
		{
			var resultMessage = "";

			// Check if there are any available seats in the array.
			if(CheckAvailableSeat() == false)
			{
				resultMessage = "Threre is no available seat.";
				resultMessage += "Please click \"Add to Waiting\" button";
			}
			else
			{
				//Display error message if label and text box are not filled.
				if(lstRow.SelectedIndex == -1 || lstSeat.SelectedIndex == -1 || txtCustomerName.Text == "")
				{
					resultMessage = lstRow.SelectedIndex == -1 ? "Please select a row\n" : null;
					resultMessage += lstSeat.SelectedIndex == -1 ? "Please select a seat\n" : null;
					resultMessage += txtCustomerName.Text == "" ? "Please enter customer name\n" : null;
				}
				//Verify that the reserved sheet is re-selected
				else if (storedBookLists[lstRow.SelectedIndex, lstSeat.SelectedIndex] != null)
				{
					resultMessage += "This seat is already taken.\n";
					//Update RichTextBox
					btnShowAllReservations_Click(sender, e);
				}
			}

			return resultMessage;
		}

		//This method checks whether adding to waiting for seats are available and returns error messages.
		private string IsAddingWaitingPossible(object sender, EventArgs e)
		{
			var resultMessage = "";

			// Check if there are any available seats in the array.
			if (CheckAvailableSeat() == true)
			{
				resultMessage = "Seats are available.\n";
				//Update RichTextBox
				btnShowAllReservations_Click(sender, e);
			}
			else
			{
				//Display error message if the text box is not filled.
				resultMessage += txtCustomerName.Text == "" ? "Please enter customer name" : null;

				//Check if there are any seats on the waiting list.
				if (currentIndexForWaitingLists >= 10)
				{
					resultMessage += "Waiting lists are full. Please click \"Show Waiting list\" Button";
				}
			}

			return resultMessage;
		}

		//This method checks whether cancellation seats are available and returns error messages.
		private string IsCancellationPossible()
		{
			var resultMessage = "";

			if (lstRow.SelectedIndex == -1 || lstSeat.SelectedIndex == -1)
			{
				resultMessage = lstRow.SelectedIndex == -1 ? "Please select a row\n" : null;
				resultMessage += lstSeat.SelectedIndex == -1 ? "Please select a seat\n" : null;
			}
			else if (storedBookLists[lstRow.SelectedIndex, lstSeat.SelectedIndex] == null)
			{
				resultMessage += "This seat is not booked.\n";
			}

			return resultMessage;
		}

		//This method check if there are empty seats.
		private bool CheckAvailableSeat()
		{
			var resultOfAvailableSeat = false;

			for (int i = 0; i < storedBookLists.GetLength(0); i++)
			{
				for (int j = 0; j < storedBookLists.GetLength(1); j++)
				{
					if (storedBookLists[i, j] == null)
					{
						resultOfAvailableSeat = true;
						break;
					}
				}
			}

			return resultOfAvailableSeat;
		}

		//Load picture to pictureBox, when the application starts

		private void VenueBooking_Load(object sender, EventArgs e)
		{
			picVenue.Load("../../VenuBooking.jpg");
			picVenue.SizeMode = PictureBoxSizeMode.StretchImage;
		}
	}
}
