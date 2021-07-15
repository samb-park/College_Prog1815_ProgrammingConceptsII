
namespace Assignment3
{
	partial class StockPortfolioTracker
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
			this.txtPathFile = new System.Windows.Forms.TextBox();
			this.btnCreateOpen = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnAddUpdate = new System.Windows.Forms.Button();
			this.txtCommission = new System.Windows.Forms.TextBox();
			this.txtNumberOfShare = new System.Windows.Forms.TextBox();
			this.txtSharePrice = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtNotes = new System.Windows.Forms.RichTextBox();
			this.dateInput = new System.Windows.Forms.DateTimePicker();
			this.radioSell = new System.Windows.Forms.RadioButton();
			this.radioBuy = new System.Windows.Forms.RadioButton();
			this.txtCompany = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTickerSymbol = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnGetNewId = new System.Windows.Forms.Button();
			this.txtTransactionId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnDeleteId = new System.Windows.Forms.Button();
			this.txtDeleteId = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.btnReadFile = new System.Windows.Forms.Button();
			this.btnEmptyFile = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.gridView = new System.Windows.Forms.DataGridView();
			this.label12 = new System.Windows.Forms.Label();
			this.txtMessage = new System.Windows.Forms.RichTextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(202, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "File name and path:";
			// 
			// txtPathFile
			// 
			this.txtPathFile.Location = new System.Drawing.Point(30, 62);
			this.txtPathFile.Name = "txtPathFile";
			this.txtPathFile.Size = new System.Drawing.Size(485, 31);
			this.txtPathFile.TabIndex = 0;
			// 
			// btnCreateOpen
			// 
			this.btnCreateOpen.Location = new System.Drawing.Point(532, 53);
			this.btnCreateOpen.Name = "btnCreateOpen";
			this.btnCreateOpen.Size = new System.Drawing.Size(202, 49);
			this.btnCreateOpen.TabIndex = 1;
			this.btnCreateOpen.Text = "Create/open file";
			this.btnCreateOpen.UseVisualStyleBackColor = true;
			this.btnCreateOpen.Click += new System.EventHandler(this.btnCreateOpen_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnClear);
			this.groupBox1.Controls.Add(this.btnAddUpdate);
			this.groupBox1.Controls.Add(this.txtCommission);
			this.groupBox1.Controls.Add(this.txtNumberOfShare);
			this.groupBox1.Controls.Add(this.txtSharePrice);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtNotes);
			this.groupBox1.Controls.Add(this.dateInput);
			this.groupBox1.Controls.Add(this.radioSell);
			this.groupBox1.Controls.Add(this.radioBuy);
			this.groupBox1.Controls.Add(this.txtCompany);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtTickerSymbol);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.btnGetNewId);
			this.groupBox1.Controls.Add(this.txtTransactionId);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(30, 116);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(704, 780);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add/update transaction:";
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(364, 712);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(309, 41);
			this.btnClear.TabIndex = 15;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnAddUpdate
			// 
			this.btnAddUpdate.Location = new System.Drawing.Point(29, 712);
			this.btnAddUpdate.Name = "btnAddUpdate";
			this.btnAddUpdate.Size = new System.Drawing.Size(309, 41);
			this.btnAddUpdate.TabIndex = 14;
			this.btnAddUpdate.Text = "Add/update";
			this.btnAddUpdate.UseVisualStyleBackColor = true;
			this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
			// 
			// txtCommission
			// 
			this.txtCommission.Location = new System.Drawing.Point(211, 655);
			this.txtCommission.Name = "txtCommission";
			this.txtCommission.Size = new System.Drawing.Size(462, 31);
			this.txtCommission.TabIndex = 13;
			// 
			// txtNumberOfShare
			// 
			this.txtNumberOfShare.Location = new System.Drawing.Point(211, 607);
			this.txtNumberOfShare.Name = "txtNumberOfShare";
			this.txtNumberOfShare.Size = new System.Drawing.Size(462, 31);
			this.txtNumberOfShare.TabIndex = 12;
			// 
			// txtSharePrice
			// 
			this.txtSharePrice.Location = new System.Drawing.Point(211, 559);
			this.txtSharePrice.Name = "txtSharePrice";
			this.txtSharePrice.Size = new System.Drawing.Size(462, 31);
			this.txtSharePrice.TabIndex = 11;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label10.Location = new System.Drawing.Point(24, 657);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(129, 26);
			this.label10.TabIndex = 18;
			this.label10.Text = "Commision:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label9.Location = new System.Drawing.Point(24, 609);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(125, 26);
			this.label9.TabIndex = 17;
			this.label9.Text = "# of shares:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label8.Location = new System.Drawing.Point(24, 561);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(129, 26);
			this.label8.TabIndex = 16;
			this.label8.Text = "Share price:";
			// 
			// txtNotes
			// 
			this.txtNotes.Location = new System.Drawing.Point(211, 311);
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Size = new System.Drawing.Size(462, 211);
			this.txtNotes.TabIndex = 10;
			this.txtNotes.Text = "";
			// 
			// dateInput
			// 
			this.dateInput.CustomFormat = "dddd.MMMMdd.yyyy";
			this.dateInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateInput.Location = new System.Drawing.Point(211, 255);
			this.dateInput.Name = "dateInput";
			this.dateInput.Size = new System.Drawing.Size(462, 31);
			this.dateInput.TabIndex = 9;
			// 
			// radioSell
			// 
			this.radioSell.AutoSize = true;
			this.radioSell.Location = new System.Drawing.Point(423, 208);
			this.radioSell.Name = "radioSell";
			this.radioSell.Size = new System.Drawing.Size(79, 29);
			this.radioSell.TabIndex = 8;
			this.radioSell.TabStop = true;
			this.radioSell.Text = "Sell";
			this.radioSell.UseVisualStyleBackColor = true;
			// 
			// radioBuy
			// 
			this.radioBuy.AutoSize = true;
			this.radioBuy.Checked = true;
			this.radioBuy.Location = new System.Drawing.Point(211, 206);
			this.radioBuy.Name = "radioBuy";
			this.radioBuy.Size = new System.Drawing.Size(80, 29);
			this.radioBuy.TabIndex = 7;
			this.radioBuy.TabStop = true;
			this.radioBuy.Text = "Buy";
			this.radioBuy.UseVisualStyleBackColor = true;
			// 
			// txtCompany
			// 
			this.txtCompany.Location = new System.Drawing.Point(211, 154);
			this.txtCompany.Name = "txtCompany";
			this.txtCompany.Size = new System.Drawing.Size(462, 31);
			this.txtCompany.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label7.Location = new System.Drawing.Point(24, 311);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 26);
			this.label7.TabIndex = 10;
			this.label7.Text = "Notes:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label6.Location = new System.Drawing.Point(24, 259);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 26);
			this.label6.TabIndex = 9;
			this.label6.Text = "Date:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(24, 208);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(174, 25);
			this.label5.TabIndex = 8;
			this.label5.Text = "Transation Type:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(24, 157);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(109, 25);
			this.label4.TabIndex = 7;
			this.label4.Text = "Company:";
			// 
			// txtTickerSymbol
			// 
			this.txtTickerSymbol.Location = new System.Drawing.Point(211, 103);
			this.txtTickerSymbol.Name = "txtTickerSymbol";
			this.txtTickerSymbol.Size = new System.Drawing.Size(462, 31);
			this.txtTickerSymbol.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 106);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(151, 25);
			this.label3.TabIndex = 5;
			this.label3.Text = "Ticker symbol:";
			// 
			// btnGetNewId
			// 
			this.btnGetNewId.Location = new System.Drawing.Point(502, 47);
			this.btnGetNewId.Name = "btnGetNewId";
			this.btnGetNewId.Size = new System.Drawing.Size(171, 41);
			this.btnGetNewId.TabIndex = 4;
			this.btnGetNewId.Text = "Get new ID";
			this.btnGetNewId.UseVisualStyleBackColor = true;
			this.btnGetNewId.Click += new System.EventHandler(this.btnGetNewId_Click);
			// 
			// txtTransactionId
			// 
			this.txtTransactionId.Location = new System.Drawing.Point(211, 52);
			this.txtTransactionId.Name = "txtTransactionId";
			this.txtTransactionId.Size = new System.Drawing.Size(274, 31);
			this.txtTransactionId.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(157, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "Transaction ID:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnDeleteId);
			this.groupBox2.Controls.Add(this.txtDeleteId);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Location = new System.Drawing.Point(30, 926);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(704, 114);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Dlete transaction:";
			// 
			// btnDeleteId
			// 
			this.btnDeleteId.Location = new System.Drawing.Point(441, 43);
			this.btnDeleteId.Name = "btnDeleteId";
			this.btnDeleteId.Size = new System.Drawing.Size(232, 41);
			this.btnDeleteId.TabIndex = 17;
			this.btnDeleteId.Text = "Delete transaction";
			this.btnDeleteId.UseVisualStyleBackColor = true;
			this.btnDeleteId.Click += new System.EventHandler(this.btnDeleteId_Click);
			// 
			// txtDeleteId
			// 
			this.txtDeleteId.Location = new System.Drawing.Point(205, 48);
			this.txtDeleteId.Name = "txtDeleteId";
			this.txtDeleteId.Size = new System.Drawing.Size(216, 31);
			this.txtDeleteId.TabIndex = 16;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label11.Location = new System.Drawing.Point(24, 50);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(158, 26);
			this.label11.TabIndex = 19;
			this.label11.Text = "Transaction ID:";
			// 
			// btnReadFile
			// 
			this.btnReadFile.Location = new System.Drawing.Point(765, 969);
			this.btnReadFile.Name = "btnReadFile";
			this.btnReadFile.Size = new System.Drawing.Size(154, 41);
			this.btnReadFile.TabIndex = 4;
			this.btnReadFile.Text = "Read file";
			this.btnReadFile.UseVisualStyleBackColor = true;
			this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
			// 
			// btnEmptyFile
			// 
			this.btnEmptyFile.Location = new System.Drawing.Point(948, 969);
			this.btnEmptyFile.Name = "btnEmptyFile";
			this.btnEmptyFile.Size = new System.Drawing.Size(154, 41);
			this.btnEmptyFile.TabIndex = 5;
			this.btnEmptyFile.Text = "Empty file";
			this.btnEmptyFile.UseVisualStyleBackColor = true;
			this.btnEmptyFile.Click += new System.EventHandler(this.btnEmptyFile_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(1131, 969);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(154, 41);
			this.btnExit.TabIndex = 6;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// gridView
			// 
			this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridView.Location = new System.Drawing.Point(753, 131);
			this.gridView.Name = "gridView";
			this.gridView.RowHeadersWidth = 82;
			this.gridView.RowTemplate.Height = 33;
			this.gridView.Size = new System.Drawing.Size(1964, 765);
			this.gridView.TabIndex = 28;
			this.gridView.TabStop = false;
			this.gridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellDoubleClick);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label12.Location = new System.Drawing.Point(1500, 86);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(1187, 26);
			this.label12.TabIndex = 29;
			this.label12.Text = "Note: double clicking anywhere on a row in the grid will load the details of that" +
    " transaction for viewing and protential editing";
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(1313, 948);
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(1374, 118);
			this.txtMessage.TabIndex = 7;
			this.txtMessage.Text = "";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label13.Location = new System.Drawing.Point(1308, 909);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(106, 26);
			this.label13.TabIndex = 8;
			this.label13.Text = "Message:";
			// 
			// StockPortfolioTracker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(2734, 1098);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.gridView);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnEmptyFile);
			this.Controls.Add(this.btnReadFile);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCreateOpen);
			this.Controls.Add(this.txtPathFile);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(2554, 1169);
			this.Name = "StockPortfolioTracker";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Stock Portfolio Tracker";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StockPortfolioTracker_FormClosed);
			this.Load += new System.EventHandler(this.Assignment3_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPathFile;
		private System.Windows.Forms.Button btnCreateOpen;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnAddUpdate;
		private System.Windows.Forms.TextBox txtCommission;
		private System.Windows.Forms.TextBox txtNumberOfShare;
		private System.Windows.Forms.TextBox txtSharePrice;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.RichTextBox txtNotes;
		private System.Windows.Forms.DateTimePicker dateInput;
		private System.Windows.Forms.RadioButton radioSell;
		private System.Windows.Forms.RadioButton radioBuy;
		private System.Windows.Forms.TextBox txtCompany;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTickerSymbol;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnGetNewId;
		private System.Windows.Forms.TextBox txtTransactionId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnDeleteId;
		private System.Windows.Forms.TextBox txtDeleteId;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btnReadFile;
		private System.Windows.Forms.Button btnEmptyFile;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.DataGridView gridView;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.RichTextBox txtMessage;
		private System.Windows.Forms.Label label13;
	}
}

