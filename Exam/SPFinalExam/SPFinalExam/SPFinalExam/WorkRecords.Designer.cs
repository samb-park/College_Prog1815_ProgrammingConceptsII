
namespace SPFinalExam
{
	partial class WorkRecords
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtWorkId = new System.Windows.Forms.TextBox();
			this.txtContractName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.datStartDate = new System.Windows.Forms.DateTimePicker();
			this.txtConsultanName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtHoursWorked = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.datDateWorked = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.txtHourlyRate = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.lblMessage = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnDisplay = new System.Windows.Forms.Button();
			this.gridResult = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(322, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(220, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Work Records";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 127);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Work ID";
			// 
			// txtWorkId
			// 
			this.txtWorkId.Location = new System.Drawing.Point(311, 118);
			this.txtWorkId.Name = "txtWorkId";
			this.txtWorkId.Size = new System.Drawing.Size(546, 31);
			this.txtWorkId.TabIndex = 2;
			// 
			// txtContractName
			// 
			this.txtContractName.Location = new System.Drawing.Point(311, 174);
			this.txtContractName.Name = "txtContractName";
			this.txtContractName.Size = new System.Drawing.Size(546, 31);
			this.txtContractName.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(40, 183);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(155, 25);
			this.label3.TabIndex = 3;
			this.label3.Text = "Contract Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(40, 231);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(195, 25);
			this.label4.TabIndex = 5;
			this.label4.Text = "Contract Start Date";
			// 
			// datStartDate
			// 
			this.datStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.datStartDate.Location = new System.Drawing.Point(311, 231);
			this.datStartDate.Name = "datStartDate";
			this.datStartDate.Size = new System.Drawing.Size(546, 31);
			this.datStartDate.TabIndex = 6;
			// 
			// txtConsultanName
			// 
			this.txtConsultanName.Location = new System.Drawing.Point(311, 284);
			this.txtConsultanName.Name = "txtConsultanName";
			this.txtConsultanName.Size = new System.Drawing.Size(546, 31);
			this.txtConsultanName.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(40, 293);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(177, 25);
			this.label5.TabIndex = 7;
			this.label5.Text = "Consultant Name";
			// 
			// txtHoursWorked
			// 
			this.txtHoursWorked.Location = new System.Drawing.Point(311, 392);
			this.txtHoursWorked.Name = "txtHoursWorked";
			this.txtHoursWorked.Size = new System.Drawing.Size(546, 31);
			this.txtHoursWorked.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(40, 401);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(149, 25);
			this.label6.TabIndex = 9;
			this.label6.Text = "Hours Worked";
			// 
			// datDateWorked
			// 
			this.datDateWorked.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.datDateWorked.Location = new System.Drawing.Point(311, 344);
			this.datDateWorked.Name = "datDateWorked";
			this.datDateWorked.Size = new System.Drawing.Size(546, 31);
			this.datDateWorked.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(40, 350);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(132, 25);
			this.label7.TabIndex = 11;
			this.label7.Text = "Date worked";
			// 
			// txtHourlyRate
			// 
			this.txtHourlyRate.Location = new System.Drawing.Point(311, 442);
			this.txtHourlyRate.Name = "txtHourlyRate";
			this.txtHourlyRate.Size = new System.Drawing.Size(546, 31);
			this.txtHourlyRate.TabIndex = 14;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(40, 451);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(125, 25);
			this.label8.TabIndex = 13;
			this.label8.Text = "Hourly Rate";
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.ForeColor = System.Drawing.Color.Red;
			this.lblMessage.Location = new System.Drawing.Point(40, 505);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(99, 25);
			this.lblMessage.TabIndex = 15;
			this.lblMessage.Text = "message";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(1033, 110);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(442, 41);
			this.btnAdd.TabIndex = 16;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(1033, 183);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(442, 41);
			this.btnUpdate.TabIndex = 17;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnExit
			// 
			this.btnExit.ForeColor = System.Drawing.Color.Red;
			this.btnExit.Location = new System.Drawing.Point(1033, 253);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(442, 41);
			this.btnExit.TabIndex = 18;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnDisplay
			// 
			this.btnDisplay.Location = new System.Drawing.Point(1033, 321);
			this.btnDisplay.Name = "btnDisplay";
			this.btnDisplay.Size = new System.Drawing.Size(442, 41);
			this.btnDisplay.TabIndex = 19;
			this.btnDisplay.Text = "Display Contract Totals";
			this.btnDisplay.UseVisualStyleBackColor = true;
			this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
			// 
			// gridResult
			// 
			this.gridResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridResult.Location = new System.Drawing.Point(45, 772);
			this.gridResult.Name = "gridResult";
			this.gridResult.RowHeadersVisible = false;
			this.gridResult.RowHeadersWidth = 82;
			this.gridResult.RowTemplate.Height = 33;
			this.gridResult.Size = new System.Drawing.Size(1947, 410);
			this.gridResult.TabIndex = 20;
			// 
			// WorkRecords
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2032, 1254);
			this.Controls.Add(this.gridResult);
			this.Controls.Add(this.btnDisplay);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.txtHourlyRate);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.datDateWorked);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtHoursWorked);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtConsultanName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.datStartDate);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtContractName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtWorkId);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "WorkRecords";
			this.Text = "Final Exam - Sangbong Park";
			((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtWorkId;
		private System.Windows.Forms.TextBox txtContractName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker datStartDate;
		private System.Windows.Forms.TextBox txtConsultanName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtHoursWorked;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker datDateWorked;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtHourlyRate;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnDisplay;
		private System.Windows.Forms.DataGridView gridResult;
	}
}

