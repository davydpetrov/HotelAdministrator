namespace HotelAdministrator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvRoomsTable = new DataGridView();
            dgvGuestsTable = new DataGridView();
            txtSearchGuests = new TextBox();
            btnCheckIn = new Button();
            btnCheckOut = new Button();
            btnExtendStay = new Button();
            btnEarlyDeparture = new Button();
            dtpExtendUntil = new DateTimePicker();
            lblExtendUntil = new Label();
            btnOrderCleaning = new Button();
            btnOrderBreakfast = new Button();
            lblOrderCleaning = new Label();
            dtpCleaningTime = new DateTimePicker();
            btnAddRoom = new Button();
            lblEarlyDeparture = new Label();
            dtpEarlyDeparture = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvRoomsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGuestsTable).BeginInit();
            SuspendLayout();
            // 
            // dgvRoomsTable
            // 
            dgvRoomsTable.AllowUserToAddRows = false;
            dgvRoomsTable.AllowUserToDeleteRows = false;
            dgvRoomsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomsTable.Location = new Point(12, 12);
            dgvRoomsTable.Name = "dgvRoomsTable";
            dgvRoomsTable.Size = new Size(734, 150);
            dgvRoomsTable.TabIndex = 0;
            dgvRoomsTable.CellDoubleClick += dgvRoomsTable_CellDoubleClick;
            dgvRoomsTable.CellValueChanged += dgvRoomsTable_CellValueChanged;
            dgvRoomsTable.ColumnHeaderMouseClick += dgvRoomsTable_ColumnHeaderMouseClick;
            // 
            // dgvGuestsTable
            // 
            dgvGuestsTable.AllowUserToAddRows = false;
            dgvGuestsTable.AllowUserToDeleteRows = false;
            dgvGuestsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGuestsTable.Location = new Point(12, 168);
            dgvGuestsTable.Name = "dgvGuestsTable";
            dgvGuestsTable.Size = new Size(734, 150);
            dgvGuestsTable.TabIndex = 1;
            dgvGuestsTable.CellDoubleClick += dgvGuestsTable_CellDoubleClick;
            dgvGuestsTable.CellValueChanged += dgvGuestsTable_CellValueChanged;
            dgvGuestsTable.ColumnHeaderMouseClick += dgvGuestsTable_ColumnHeaderMouseClick;
            // 
            // txtSearchGuests
            // 
            txtSearchGuests.Location = new Point(12, 324);
            txtSearchGuests.Name = "txtSearchGuests";
            txtSearchGuests.Size = new Size(734, 23);
            txtSearchGuests.TabIndex = 2;
            txtSearchGuests.TextChanged += txtSearchGuests_TextChanged;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Location = new Point(12, 382);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(111, 23);
            btnCheckIn.TabIndex = 3;
            btnCheckIn.Text = "Check In";
            btnCheckIn.UseVisualStyleBackColor = true;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(12, 411);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(111, 23);
            btnCheckOut.TabIndex = 4;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // btnExtendStay
            // 
            btnExtendStay.Location = new Point(12, 440);
            btnExtendStay.Name = "btnExtendStay";
            btnExtendStay.Size = new Size(111, 23);
            btnExtendStay.TabIndex = 5;
            btnExtendStay.Text = "Extend Stay";
            btnExtendStay.UseVisualStyleBackColor = true;
            btnExtendStay.Click += btnExtendStay_Click;
            // 
            // btnEarlyDeparture
            // 
            btnEarlyDeparture.Location = new Point(12, 469);
            btnEarlyDeparture.Name = "btnEarlyDeparture";
            btnEarlyDeparture.Size = new Size(111, 23);
            btnEarlyDeparture.TabIndex = 6;
            btnEarlyDeparture.Text = "Early Departure";
            btnEarlyDeparture.UseVisualStyleBackColor = true;
            btnEarlyDeparture.Click += btnEarlyDeparture_Click;
            // 
            // dtpExtendUntil
            // 
            dtpExtendUntil.Format = DateTimePickerFormat.Short;
            dtpExtendUntil.Location = new Point(166, 440);
            dtpExtendUntil.Name = "dtpExtendUntil";
            dtpExtendUntil.Size = new Size(100, 23);
            dtpExtendUntil.TabIndex = 9;
            // 
            // lblExtendUntil
            // 
            lblExtendUntil.AutoSize = true;
            lblExtendUntil.Location = new Point(129, 444);
            lblExtendUntil.Name = "lblExtendUntil";
            lblExtendUntil.Size = new Size(31, 15);
            lblExtendUntil.TabIndex = 8;
            lblExtendUntil.Text = "until";
            // 
            // btnOrderCleaning
            // 
            btnOrderCleaning.Location = new Point(12, 527);
            btnOrderCleaning.Name = "btnOrderCleaning";
            btnOrderCleaning.Size = new Size(111, 23);
            btnOrderCleaning.TabIndex = 11;
            btnOrderCleaning.Text = "Order Cleaning";
            btnOrderCleaning.UseVisualStyleBackColor = true;
            btnOrderCleaning.Click += btnOrderCleaning_Click;
            // 
            // btnOrderBreakfast
            // 
            btnOrderBreakfast.Location = new Point(12, 498);
            btnOrderBreakfast.Name = "btnOrderBreakfast";
            btnOrderBreakfast.Size = new Size(111, 23);
            btnOrderBreakfast.TabIndex = 10;
            btnOrderBreakfast.Text = "Order Breakfast";
            btnOrderBreakfast.UseVisualStyleBackColor = true;
            btnOrderBreakfast.Click += btnOrderBreakfast_Click;
            // 
            // lblOrderCleaning
            // 
            lblOrderCleaning.AutoSize = true;
            lblOrderCleaning.Location = new Point(129, 531);
            lblOrderCleaning.Name = "lblOrderCleaning";
            lblOrderCleaning.Size = new Size(17, 15);
            lblOrderCleaning.TabIndex = 12;
            lblOrderCleaning.Text = "at";
            // 
            // dtpCleaningTime
            // 
            dtpCleaningTime.CustomFormat = "HH:mm";
            dtpCleaningTime.Format = DateTimePickerFormat.Custom;
            dtpCleaningTime.Location = new Point(152, 527);
            dtpCleaningTime.Name = "dtpCleaningTime";
            dtpCleaningTime.ShowUpDown = true;
            dtpCleaningTime.Size = new Size(111, 23);
            dtpCleaningTime.TabIndex = 13;
            // 
            // btnAddRoom
            // 
            btnAddRoom.Location = new Point(12, 353);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(111, 23);
            btnAddRoom.TabIndex = 14;
            btnAddRoom.Text = "Add Room";
            btnAddRoom.UseVisualStyleBackColor = true;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // lblEarlyDeparture
            // 
            lblEarlyDeparture.AutoSize = true;
            lblEarlyDeparture.Location = new Point(129, 473);
            lblEarlyDeparture.Name = "lblEarlyDeparture";
            lblEarlyDeparture.Size = new Size(21, 15);
            lblEarlyDeparture.TabIndex = 15;
            lblEarlyDeparture.Text = "on";
            // 
            // dtpEarlyDeparture
            // 
            dtpEarlyDeparture.Format = DateTimePickerFormat.Short;
            dtpEarlyDeparture.Location = new Point(156, 469);
            dtpEarlyDeparture.Name = "dtpEarlyDeparture";
            dtpEarlyDeparture.Size = new Size(100, 23);
            dtpEarlyDeparture.TabIndex = 16;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 561);
            Controls.Add(dtpEarlyDeparture);
            Controls.Add(lblEarlyDeparture);
            Controls.Add(btnAddRoom);
            Controls.Add(dtpCleaningTime);
            Controls.Add(lblOrderCleaning);
            Controls.Add(btnOrderCleaning);
            Controls.Add(btnOrderBreakfast);
            Controls.Add(dtpExtendUntil);
            Controls.Add(lblExtendUntil);
            Controls.Add(btnEarlyDeparture);
            Controls.Add(btnExtendStay);
            Controls.Add(btnCheckOut);
            Controls.Add(btnCheckIn);
            Controls.Add(txtSearchGuests);
            Controls.Add(dgvGuestsTable);
            Controls.Add(dgvRoomsTable);
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel Administrator";
            ((System.ComponentModel.ISupportInitialize)dgvRoomsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGuestsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRoomsTable;
        private DataGridView dgvGuestsTable;
        private TextBox txtSearchGuests;
        private Button btnCheckIn;
        private Button btnCheckOut;
        private Button btnExtendStay;
        private Button btnEarlyDeparture;
        private DateTimePicker dtpExtendUntil;
        private Label lblExtendUntil;
        private Button btnOrderCleaning;
        private Button btnOrderBreakfast;
        private Label lblOrderCleaning;
        private DateTimePicker dtpCleaningTime;
        private Button btnAddRoom;
        private Label lblEarlyDeparture;
        private DateTimePicker dtpEarlyDeparture;
    }
}
