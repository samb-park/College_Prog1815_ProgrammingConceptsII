/* Calculator.cs
 * InClassTask 2  - Timer and Alram using Datetime and timerHandler.
 * 
 *
 * Revision History
 *		Sangbong Park, 2021.02.17: Created
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

namespace InClass2
{
	public partial class AlarmClock : Form
	{
		public AlarmClock()
		{
			InitializeComponent();
		}

		//A method to change time format and return the changed string.
		private string FormatTime(DateTime time)
		{
			if (chk24.Checked)
			{
				return time.ToString("HH:mm:ss tt");
			}
			else
			{
				return time.ToString("hh:mm:ss tt");
			}
		}


		//Event handler to run alarm.
		private void timerClock_Tick(object sender, EventArgs e)
		{
			lblClock.Text = FormatTime(DateTime.Now);

			if(chkAlarm.Checked && lblClock.Text == txtAlarm.Text)
			{					
				timerAlarm.Enabled = true;
			}
		}

		//Time is updated to current when form loads
		private void AlarmClock_Load(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;
			lblClock.Text = now.ToString("hh:mm:ss tt");
			txtAlarm.Text = now.ToString("hh:mm:ss tt");
		}

		//When the alarm timer is active, it will sound the alarm every tick
		private void timerAlarm_Tick(object sender, EventArgs e)
		{
			System.Media.SoundPlayer player = new System.Media.SoundPlayer();
			player.SoundLocation = @"c:\windows\media\Windows Logoff Sound.wav";
			player.Play();

			if (Int32.Parse(DateTime.Now.ToString("ss")) % 2 == 0)
			{
				BackColor = Color.Green;
			}
			else
			{
				BackColor = Color.Red;
			}

		}

		//It can stop the alarm, when alaram is running.
		private void btnStop_Click(object sender, EventArgs e)
		{
			timerAlarm.Enabled = false;
			BackColor = Color.Empty;
			lblMessage.Text = $"Stop the alarm.";
		}

		//Event handler to check whether formatting is available and change the date format.
		private void txtAlarm_Leave(object sender, EventArgs e)
		{
			DateTime date;
			if (DateTime.TryParse(txtAlarm.Text, out date))
			{
				txtAlarm.Text = date.ToString("HH:mm:ss tt");
				lblMessage.Text = $"Entered value is valid.";
			}
			else
			{
				lblMessage.Text = $"Please enter the valid time.";
			}
		}

		//Event Handler to change date format from 24 hour to 12 hour
		private void chk24_CheckedChanged(object sender, EventArgs e)
		{
			DateTime date;

			if (DateTime.TryParse(txtAlarm.Text, out date))
			{
				if (chk24.Checked)
				{
					lblClock.Text = DateTime.Now.ToString("HH:mm:ss tt");
					txtAlarm.Text = date.ToString("HH:mm:ss tt");
				}
				else
				{
					lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
					txtAlarm.Text = date.ToString("hh:mm:ss tt");
				}
			}
		}

		private void chkAlarm_CheckedChanged(object sender, EventArgs e)
		{
			lblMessage.Text = $"Waiting for entered time";
			if (chkAlarm.Checked == false)
			{
				timerAlarm.Enabled = false;
				BackColor = Color.Empty;
				lblMessage.Text = $"Stop the alarm.";
			}
		}

		private void btnAbout_Click(object sender, EventArgs e)
		{
			MessageBox.Show(
				"Author\t: Sangbong Park\n" +
				"email\t: spark2765@conestogac.on.ca\n" +
				"phone\t: 226-789-8016", 
				"about Alarm Clock",
				MessageBoxButtons.OK);
		}
	}
}
