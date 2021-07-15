
namespace InClass2
{
	partial class AlarmClock
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.lblClock = new System.Windows.Forms.Label();
			this.btnStop = new System.Windows.Forms.Button();
			this.timerClock = new System.Windows.Forms.Timer(this.components);
			this.chk24 = new System.Windows.Forms.CheckBox();
			this.txtAlarm = new System.Windows.Forms.TextBox();
			this.chkAlarm = new System.Windows.Forms.CheckBox();
			this.lblMessage = new System.Windows.Forms.Label();
			this.timerAlarm = new System.Windows.Forms.Timer(this.components);
			this.btnAbout = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblClock
			// 
			this.lblClock.AutoSize = true;
			this.lblClock.Font = new System.Drawing.Font("Gulim", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblClock.Location = new System.Drawing.Point(30, 30);
			this.lblClock.Name = "lblClock";
			this.lblClock.Size = new System.Drawing.Size(615, 96);
			this.lblClock.TabIndex = 0;
			this.lblClock.Text = "12:45:00 AM";
			// 
			// btnStop
			// 
			this.btnStop.Font = new System.Drawing.Font("Gulim", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnStop.Location = new System.Drawing.Point(663, 30);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(230, 96);
			this.btnStop.TabIndex = 1;
			this.btnStop.Text = "Stop Alarm";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// timerClock
			// 
			this.timerClock.Enabled = true;
			this.timerClock.Interval = 1000;
			this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
			// 
			// chk24
			// 
			this.chk24.AutoSize = true;
			this.chk24.Location = new System.Drawing.Point(59, 161);
			this.chk24.Name = "chk24";
			this.chk24.Size = new System.Drawing.Size(149, 22);
			this.chk24.TabIndex = 2;
			this.chk24.Text = "24-hour clock";
			this.chk24.UseVisualStyleBackColor = true;
			this.chk24.CheckedChanged += new System.EventHandler(this.chk24_CheckedChanged);
			// 
			// txtAlarm
			// 
			this.txtAlarm.Font = new System.Drawing.Font("Gulim", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtAlarm.Location = new System.Drawing.Point(59, 214);
			this.txtAlarm.Name = "txtAlarm";
			this.txtAlarm.Size = new System.Drawing.Size(235, 44);
			this.txtAlarm.TabIndex = 3;
			this.txtAlarm.Text = "12:45:15 AM";
			this.txtAlarm.Leave += new System.EventHandler(this.txtAlarm_Leave);
			// 
			// chkAlarm
			// 
			this.chkAlarm.AutoSize = true;
			this.chkAlarm.Location = new System.Drawing.Point(344, 225);
			this.chkAlarm.Name = "chkAlarm";
			this.chkAlarm.Size = new System.Drawing.Size(136, 22);
			this.chkAlarm.TabIndex = 4;
			this.chkAlarm.Text = "Alarm Active";
			this.chkAlarm.UseVisualStyleBackColor = true;
			this.chkAlarm.CheckedChanged += new System.EventHandler(this.chkAlarm_CheckedChanged);
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblMessage.ForeColor = System.Drawing.Color.Red;
			this.lblMessage.Location = new System.Drawing.Point(59, 292);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(37, 24);
			this.lblMessage.TabIndex = 5;
			this.lblMessage.Text = "...";
			// 
			// timerAlarm
			// 
			this.timerAlarm.Tick += new System.EventHandler(this.timerAlarm_Tick);
			// 
			// btnAbout
			// 
			this.btnAbout.Font = new System.Drawing.Font("Gulim", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnAbout.Location = new System.Drawing.Point(663, 151);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(230, 96);
			this.btnAbout.TabIndex = 6;
			this.btnAbout.Text = "About";
			this.btnAbout.UseVisualStyleBackColor = true;
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			// 
			// AlarmClock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(929, 471);
			this.Controls.Add(this.btnAbout);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.chkAlarm);
			this.Controls.Add(this.txtAlarm);
			this.Controls.Add(this.chk24);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.lblClock);
			this.Name = "AlarmClock";
			this.Text = "Alarm Clock";
			this.Load += new System.EventHandler(this.AlarmClock_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblClock;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Timer timerClock;
		private System.Windows.Forms.CheckBox chk24;
		private System.Windows.Forms.TextBox txtAlarm;
		private System.Windows.Forms.CheckBox chkAlarm;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.Timer timerAlarm;
		private System.Windows.Forms.Button btnAbout;
	}
}

