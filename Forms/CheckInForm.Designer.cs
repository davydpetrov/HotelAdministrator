namespace HotelAdministrator
{
    partial class CheckInForm
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
            txtFullName = new TextBox();
            txtBirthPlace = new TextBox();
            txtRegistrationPlace = new TextBox();
            txtCitizenship = new TextBox();
            txtTaxNumber = new TextBox();
            btnRegister = new Button();
            lblFullName = new Label();
            lblGender = new Label();
            lblBirthYear = new Label();
            lblBirthPlace = new Label();
            lblRegistrationPlace = new Label();
            lblCitizenship = new Label();
            lblIssuePlace = new Label();
            lblIssueDate = new Label();
            lblValidUntil = new Label();
            lblTaxNumber = new Label();
            lblArrivalDate = new Label();
            lblDepartureDate = new Label();
            lblRoomNumber = new Label();
            cbGender = new ComboBox();
            cbBirthYear = new ComboBox();
            dtpIssueDate = new DateTimePicker();
            dtpValidUntil = new DateTimePicker();
            dtpArrivalDate = new DateTimePicker();
            dtpDepartureDate = new DateTimePicker();
            cbRoomNumber = new ComboBox();
            txtIssuePlace = new TextBox();
            lblPassportData = new Label();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(12, 36);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(100, 23);
            txtFullName.TabIndex = 0;
            // 
            // txtBirthPlace
            // 
            txtBirthPlace.Location = new Point(12, 123);
            txtBirthPlace.Name = "txtBirthPlace";
            txtBirthPlace.Size = new Size(100, 23);
            txtBirthPlace.TabIndex = 3;
            // 
            // txtRegistrationPlace
            // 
            txtRegistrationPlace.Location = new Point(12, 152);
            txtRegistrationPlace.Name = "txtRegistrationPlace";
            txtRegistrationPlace.Size = new Size(100, 23);
            txtRegistrationPlace.TabIndex = 4;
            // 
            // txtCitizenship
            // 
            txtCitizenship.Location = new Point(12, 181);
            txtCitizenship.Name = "txtCitizenship";
            txtCitizenship.Size = new Size(100, 23);
            txtCitizenship.TabIndex = 5;
            // 
            // txtTaxNumber
            // 
            txtTaxNumber.Location = new Point(12, 297);
            txtTaxNumber.Name = "txtTaxNumber";
            txtTaxNumber.Size = new Size(100, 23);
            txtTaxNumber.TabIndex = 9;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(434, 297);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 14;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(118, 39);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(61, 15);
            lblFullName.TabIndex = 15;
            lblFullName.Text = "Full Name";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(118, 68);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(45, 15);
            lblGender.TabIndex = 16;
            lblGender.Text = "Gender";
            // 
            // lblBirthYear
            // 
            lblBirthYear.AutoSize = true;
            lblBirthYear.Location = new Point(118, 97);
            lblBirthYear.Name = "lblBirthYear";
            lblBirthYear.Size = new Size(57, 15);
            lblBirthYear.TabIndex = 17;
            lblBirthYear.Text = "Birth Year";
            // 
            // lblBirthPlace
            // 
            lblBirthPlace.AutoSize = true;
            lblBirthPlace.Location = new Point(118, 126);
            lblBirthPlace.Name = "lblBirthPlace";
            lblBirthPlace.Size = new Size(63, 15);
            lblBirthPlace.TabIndex = 18;
            lblBirthPlace.Text = "Birth Place";
            // 
            // lblRegistrationPlace
            // 
            lblRegistrationPlace.AutoSize = true;
            lblRegistrationPlace.Location = new Point(118, 155);
            lblRegistrationPlace.Name = "lblRegistrationPlace";
            lblRegistrationPlace.Size = new Size(101, 15);
            lblRegistrationPlace.TabIndex = 19;
            lblRegistrationPlace.Text = "Registration Place";
            // 
            // lblCitizenship
            // 
            lblCitizenship.AutoSize = true;
            lblCitizenship.Location = new Point(118, 184);
            lblCitizenship.Name = "lblCitizenship";
            lblCitizenship.Size = new Size(65, 15);
            lblCitizenship.TabIndex = 20;
            lblCitizenship.Text = "Citizenship";
            // 
            // lblIssuePlace
            // 
            lblIssuePlace.AutoSize = true;
            lblIssuePlace.Location = new Point(118, 213);
            lblIssuePlace.Name = "lblIssuePlace";
            lblIssuePlace.Size = new Size(64, 15);
            lblIssuePlace.TabIndex = 21;
            lblIssuePlace.Text = "Issue Place";
            // 
            // lblIssueDate
            // 
            lblIssueDate.AutoSize = true;
            lblIssueDate.Location = new Point(118, 242);
            lblIssueDate.Name = "lblIssueDate";
            lblIssueDate.Size = new Size(60, 15);
            lblIssueDate.TabIndex = 22;
            lblIssueDate.Text = "Issue Date";
            // 
            // lblValidUntil
            // 
            lblValidUntil.AutoSize = true;
            lblValidUntil.Location = new Point(118, 271);
            lblValidUntil.Name = "lblValidUntil";
            lblValidUntil.Size = new Size(60, 15);
            lblValidUntil.TabIndex = 23;
            lblValidUntil.Text = "Valid Until";
            // 
            // lblTaxNumber
            // 
            lblTaxNumber.AutoSize = true;
            lblTaxNumber.Location = new Point(118, 300);
            lblTaxNumber.Name = "lblTaxNumber";
            lblTaxNumber.Size = new Size(71, 15);
            lblTaxNumber.TabIndex = 24;
            lblTaxNumber.Text = "Tax Number";
            // 
            // lblArrivalDate
            // 
            lblArrivalDate.AutoSize = true;
            lblArrivalDate.Location = new Point(335, 13);
            lblArrivalDate.Name = "lblArrivalDate";
            lblArrivalDate.Size = new Size(68, 15);
            lblArrivalDate.TabIndex = 25;
            lblArrivalDate.Text = "Arrival Date";
            // 
            // lblDepartureDate
            // 
            lblDepartureDate.AutoSize = true;
            lblDepartureDate.Location = new Point(317, 40);
            lblDepartureDate.Name = "lblDepartureDate";
            lblDepartureDate.Size = new Size(86, 15);
            lblDepartureDate.TabIndex = 26;
            lblDepartureDate.Text = "Departure Date";
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Location = new Point(317, 68);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(86, 15);
            lblRoomNumber.TabIndex = 27;
            lblRoomNumber.Text = "Room Number";
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(12, 65);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(100, 23);
            cbGender.TabIndex = 29;
            // 
            // cbBirthYear
            // 
            cbBirthYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBirthYear.FormattingEnabled = true;
            cbBirthYear.Location = new Point(12, 94);
            cbBirthYear.Name = "cbBirthYear";
            cbBirthYear.Size = new Size(100, 23);
            cbBirthYear.TabIndex = 30;
            // 
            // dtpIssueDate
            // 
            dtpIssueDate.CustomFormat = "";
            dtpIssueDate.Format = DateTimePickerFormat.Short;
            dtpIssueDate.ImeMode = ImeMode.NoControl;
            dtpIssueDate.Location = new Point(12, 239);
            dtpIssueDate.Name = "dtpIssueDate";
            dtpIssueDate.Size = new Size(100, 23);
            dtpIssueDate.TabIndex = 31;
            // 
            // dtpValidUntil
            // 
            dtpValidUntil.Format = DateTimePickerFormat.Short;
            dtpValidUntil.Location = new Point(12, 268);
            dtpValidUntil.Name = "dtpValidUntil";
            dtpValidUntil.Size = new Size(100, 23);
            dtpValidUntil.TabIndex = 32;
            // 
            // dtpArrivalDate
            // 
            dtpArrivalDate.Format = DateTimePickerFormat.Short;
            dtpArrivalDate.Location = new Point(409, 9);
            dtpArrivalDate.Name = "dtpArrivalDate";
            dtpArrivalDate.Size = new Size(100, 23);
            dtpArrivalDate.TabIndex = 33;
            // 
            // dtpDepartureDate
            // 
            dtpDepartureDate.Format = DateTimePickerFormat.Short;
            dtpDepartureDate.Location = new Point(409, 36);
            dtpDepartureDate.Name = "dtpDepartureDate";
            dtpDepartureDate.Size = new Size(100, 23);
            dtpDepartureDate.TabIndex = 34;
            // 
            // cbRoomNumber
            // 
            cbRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoomNumber.FormattingEnabled = true;
            cbRoomNumber.Location = new Point(409, 65);
            cbRoomNumber.Name = "cbRoomNumber";
            cbRoomNumber.Size = new Size(100, 23);
            cbRoomNumber.TabIndex = 35;
            // 
            // txtIssuePlace
            // 
            txtIssuePlace.Location = new Point(12, 210);
            txtIssuePlace.Name = "txtIssuePlace";
            txtIssuePlace.Size = new Size(100, 23);
            txtIssuePlace.TabIndex = 36;
            // 
            // lblPassportData
            // 
            lblPassportData.AutoSize = true;
            lblPassportData.Location = new Point(12, 15);
            lblPassportData.Name = "lblPassportData";
            lblPassportData.Size = new Size(112, 15);
            lblPassportData.TabIndex = 37;
            lblPassportData.Text = "Enter Passport Data:";
            // 
            // CheckInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 329);
            Controls.Add(lblPassportData);
            Controls.Add(txtIssuePlace);
            Controls.Add(cbRoomNumber);
            Controls.Add(dtpDepartureDate);
            Controls.Add(dtpArrivalDate);
            Controls.Add(dtpValidUntil);
            Controls.Add(dtpIssueDate);
            Controls.Add(cbBirthYear);
            Controls.Add(cbGender);
            Controls.Add(lblRoomNumber);
            Controls.Add(lblDepartureDate);
            Controls.Add(lblArrivalDate);
            Controls.Add(lblTaxNumber);
            Controls.Add(lblValidUntil);
            Controls.Add(lblIssueDate);
            Controls.Add(lblIssuePlace);
            Controls.Add(lblCitizenship);
            Controls.Add(lblRegistrationPlace);
            Controls.Add(lblBirthPlace);
            Controls.Add(lblBirthYear);
            Controls.Add(lblGender);
            Controls.Add(lblFullName);
            Controls.Add(btnRegister);
            Controls.Add(txtTaxNumber);
            Controls.Add(txtCitizenship);
            Controls.Add(txtRegistrationPlace);
            Controls.Add(txtBirthPlace);
            Controls.Add(txtFullName);
            Name = "CheckInForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Check In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private TextBox txtBirthPlace;
        private TextBox txtRegistrationPlace;
        private TextBox txtCitizenship;
        private TextBox txtTaxNumber;
        private Button btnRegister;
        private Label lblFullName;
        private Label lblGender;
        private Label lblBirthYear;
        private Label lblBirthPlace;
        private Label lblRegistrationPlace;
        private Label lblCitizenship;
        private Label lblIssuePlace;
        private Label lblIssueDate;
        private Label lblValidUntil;
        private Label lblTaxNumber;
        private Label lblArrivalDate;
        private Label lblDepartureDate;
        private Label lblRoomNumber;
        private ComboBox cbGender;
        private ComboBox cbBirthYear;
        private DateTimePicker dtpIssueDate;
        private DateTimePicker dtpValidUntil;
        private DateTimePicker dtpArrivalDate;
        private DateTimePicker dtpDepartureDate;
        private ComboBox cbRoomNumber;
        private TextBox txtIssuePlace;
        private Label lblPassportData;
    }
}