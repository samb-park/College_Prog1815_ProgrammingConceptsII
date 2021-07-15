
namespace InClass3
{
	partial class EmployeeYearsOfService
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
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dateStartDate = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.txtAnnualSalary = new System.Windows.Forms.TextBox();
			this.txtResult = new System.Windows.Forms.RichTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "First Name";
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(233, 83);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(322, 31);
			this.txtFirstName.TabIndex = 1;
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(233, 145);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(322, 31);
			this.txtLastName.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(47, 148);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Last Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(47, 208);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "Start Date";
			// 
			// dateStartDate
			// 
			this.dateStartDate.Location = new System.Drawing.Point(233, 203);
			this.dateStartDate.Name = "dateStartDate";
			this.dateStartDate.Size = new System.Drawing.Size(322, 31);
			this.dateStartDate.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(47, 262);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(146, 25);
			this.label4.TabIndex = 6;
			this.label4.Text = "Annual Salary";
			// 
			// txtAnnualSalary
			// 
			this.txtAnnualSalary.Location = new System.Drawing.Point(233, 259);
			this.txtAnnualSalary.Name = "txtAnnualSalary";
			this.txtAnnualSalary.Size = new System.Drawing.Size(322, 31);
			this.txtAnnualSalary.TabIndex = 7;
			// 
			// txtResult
			// 
			this.txtResult.Location = new System.Drawing.Point(233, 316);
			this.txtResult.Name = "txtResult";
			this.txtResult.Size = new System.Drawing.Size(322, 140);
			this.txtResult.TabIndex = 8;
			this.txtResult.Text = "";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(47, 316);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 25);
			this.label5.TabIndex = 9;
			this.label5.Text = "Result";
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(45, 484);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(510, 52);
			this.btnCalculate.TabIndex = 10;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// EmployeeYearsOfService
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(620, 612);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.txtAnnualSalary);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dateStartDate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.label1);
			this.Name = "EmployeeYearsOfService";
			this.Text = "Employee Years of Service";
			this.Load += new System.EventHandler(this.EmployeeYearsOfService_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dateStartDate;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtAnnualSalary;
		private System.Windows.Forms.RichTextBox txtResult;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnCalculate;
	}
}

