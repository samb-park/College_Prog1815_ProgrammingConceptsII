
namespace Assignment1
{
	partial class VenueBooking
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
			this.picVenue = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnShowWaitingLists = new System.Windows.Forms.Button();
			this.txtWatingLists = new System.Windows.Forms.RichTextBox();
			this.btnShowAllReservations = new System.Windows.Forms.Button();
			this.txtAllReservationLists = new System.Windows.Forms.RichTextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnDebug = new System.Windows.Forms.Button();
			this.btnAddToWating = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnBook = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lstSeat = new System.Windows.Forms.ListBox();
			this.lstRow = new System.Windows.Forms.ListBox();
			this.lblMessage = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picVenue)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// picVenue
			// 
			this.picVenue.Location = new System.Drawing.Point(43, 43);
			this.picVenue.Name = "picVenue";
			this.picVenue.Size = new System.Drawing.Size(503, 452);
			this.picVenue.TabIndex = 0;
			this.picVenue.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnShowWaitingLists);
			this.groupBox1.Controls.Add(this.txtWatingLists);
			this.groupBox1.Controls.Add(this.btnShowAllReservations);
			this.groupBox1.Controls.Add(this.txtAllReservationLists);
			this.groupBox1.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.groupBox1.Location = new System.Drawing.Point(552, 43);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(826, 451);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Booking and Reservations";
			// 
			// btnShowWaitingLists
			// 
			this.btnShowWaitingLists.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnShowWaitingLists.Location = new System.Drawing.Point(449, 43);
			this.btnShowWaitingLists.Name = "btnShowWaitingLists";
			this.btnShowWaitingLists.Size = new System.Drawing.Size(335, 49);
			this.btnShowWaitingLists.TabIndex = 3;
			this.btnShowWaitingLists.Text = "Show Wating LIst";
			this.btnShowWaitingLists.UseVisualStyleBackColor = true;
			this.btnShowWaitingLists.Click += new System.EventHandler(this.btnShowWaitingLists_Click);
			// 
			// txtWatingLists
			// 
			this.txtWatingLists.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtWatingLists.Location = new System.Drawing.Point(422, 109);
			this.txtWatingLists.Name = "txtWatingLists";
			this.txtWatingLists.Size = new System.Drawing.Size(389, 323);
			this.txtWatingLists.TabIndex = 2;
			this.txtWatingLists.Text = "";
			// 
			// btnShowAllReservations
			// 
			this.btnShowAllReservations.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnShowAllReservations.Location = new System.Drawing.Point(43, 43);
			this.btnShowAllReservations.Name = "btnShowAllReservations";
			this.btnShowAllReservations.Size = new System.Drawing.Size(335, 49);
			this.btnShowAllReservations.TabIndex = 1;
			this.btnShowAllReservations.Text = "Show All Reservations";
			this.btnShowAllReservations.UseVisualStyleBackColor = true;
			this.btnShowAllReservations.Click += new System.EventHandler(this.btnShowAllReservations_Click);
			// 
			// txtAllReservationLists
			// 
			this.txtAllReservationLists.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtAllReservationLists.Location = new System.Drawing.Point(16, 109);
			this.txtAllReservationLists.Name = "txtAllReservationLists";
			this.txtAllReservationLists.Size = new System.Drawing.Size(389, 323);
			this.txtAllReservationLists.TabIndex = 0;
			this.txtAllReservationLists.Text = "";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnExit);
			this.groupBox2.Controls.Add(this.btnDebug);
			this.groupBox2.Controls.Add(this.btnAddToWating);
			this.groupBox2.Controls.Add(this.btnCancel);
			this.groupBox2.Controls.Add(this.txtCustomerName);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.btnBook);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.lstSeat);
			this.groupBox2.Controls.Add(this.lstRow);
			this.groupBox2.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.groupBox2.Location = new System.Drawing.Point(43, 501);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1335, 317);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Bookings_Cancellations";
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnExit.ForeColor = System.Drawing.Color.Red;
			this.btnExit.Location = new System.Drawing.Point(1065, 238);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(254, 54);
			this.btnExit.TabIndex = 10;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnDebug
			// 
			this.btnDebug.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnDebug.ForeColor = System.Drawing.Color.Red;
			this.btnDebug.Location = new System.Drawing.Point(525, 238);
			this.btnDebug.Name = "btnDebug";
			this.btnDebug.Size = new System.Drawing.Size(524, 54);
			this.btnDebug.TabIndex = 9;
			this.btnDebug.Text = "Debug - Fill All Seats";
			this.btnDebug.UseVisualStyleBackColor = true;
			this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
			// 
			// btnAddToWating
			// 
			this.btnAddToWating.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnAddToWating.Location = new System.Drawing.Point(1065, 178);
			this.btnAddToWating.Name = "btnAddToWating";
			this.btnAddToWating.Size = new System.Drawing.Size(254, 54);
			this.btnAddToWating.TabIndex = 8;
			this.btnAddToWating.Text = "Add to Waiting";
			this.btnAddToWating.UseVisualStyleBackColor = true;
			this.btnAddToWating.Click += new System.EventHandler(this.ManageSeatLists_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnCancel.Location = new System.Drawing.Point(795, 178);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(254, 54);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.ManageSeatLists_Click);
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtCustomerName.Location = new System.Drawing.Point(525, 90);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(795, 28);
			this.txtCustomerName.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(361, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(153, 18);
			this.label3.TabIndex = 5;
			this.label3.Text = "Customer Name";
			// 
			// btnBook
			// 
			this.btnBook.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnBook.Location = new System.Drawing.Point(525, 178);
			this.btnBook.Name = "btnBook";
			this.btnBook.Size = new System.Drawing.Size(254, 54);
			this.btnBook.TabIndex = 4;
			this.btnBook.Text = "Book";
			this.btnBook.UseVisualStyleBackColor = true;
			this.btnBook.Click += new System.EventHandler(this.ManageSeatLists_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(234, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "Seat";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(56, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Row";
			// 
			// lstSeat
			// 
			this.lstSeat.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lstSeat.FormattingEnabled = true;
			this.lstSeat.ItemHeight = 18;
			this.lstSeat.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
			this.lstSeat.Location = new System.Drawing.Point(196, 90);
			this.lstSeat.Name = "lstSeat";
			this.lstSeat.Size = new System.Drawing.Size(124, 202);
			this.lstSeat.TabIndex = 1;
			// 
			// lstRow
			// 
			this.lstRow.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lstRow.FormattingEnabled = true;
			this.lstRow.ItemHeight = 18;
			this.lstRow.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
			this.lstRow.Location = new System.Drawing.Point(16, 90);
			this.lstRow.Name = "lstRow";
			this.lstRow.Size = new System.Drawing.Size(124, 202);
			this.lstRow.TabIndex = 0;
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblMessage.Location = new System.Drawing.Point(40, 841);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(24, 25);
			this.lblMessage.TabIndex = 11;
			this.lblMessage.Text = "...";
			// 
			// VenueBooking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1427, 977);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.picVenue);
			this.Name = "VenueBooking";
			this.Text = "Venue Booking";
			this.Load += new System.EventHandler(this.VenueBooking_Load);
			((System.ComponentModel.ISupportInitialize)(this.picVenue)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picVenue;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnShowWaitingLists;
		private System.Windows.Forms.RichTextBox txtWatingLists;
		private System.Windows.Forms.Button btnShowAllReservations;
		private System.Windows.Forms.RichTextBox txtAllReservationLists;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnDebug;
		private System.Windows.Forms.Button btnAddToWating;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtCustomerName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnBook;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lstSeat;
		private System.Windows.Forms.ListBox lstRow;
		private System.Windows.Forms.Label lblMessage;
	}
}

