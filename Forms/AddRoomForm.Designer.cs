namespace HotelAdministrator
{
    partial class AddRoomForm
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
            txtRoomNumber = new TextBox();
            txtNumberOfBeds = new TextBox();
            btnAddRoom = new Button();
            lblRoomNumber = new Label();
            lblRoomClass = new Label();
            lblNumberOfbeds = new Label();
            cbRoomClass = new ComboBox();
            SuspendLayout();
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new Point(12, 12);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(100, 23);
            txtRoomNumber.TabIndex = 0;
            // 
            // txtNumberOfBeds
            // 
            txtNumberOfBeds.Location = new Point(12, 70);
            txtNumberOfBeds.Name = "txtNumberOfBeds";
            txtNumberOfBeds.Size = new Size(100, 23);
            txtNumberOfBeds.TabIndex = 2;
            // 
            // btnAddRoom
            // 
            btnAddRoom.Location = new Point(12, 99);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(75, 23);
            btnAddRoom.TabIndex = 3;
            btnAddRoom.Text = "Add Room";
            btnAddRoom.UseVisualStyleBackColor = true;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Location = new Point(118, 15);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(86, 15);
            lblRoomNumber.TabIndex = 4;
            lblRoomNumber.Text = "Room Number";
            // 
            // lblRoomClass
            // 
            lblRoomClass.AutoSize = true;
            lblRoomClass.Location = new Point(118, 44);
            lblRoomClass.Name = "lblRoomClass";
            lblRoomClass.Size = new Size(69, 15);
            lblRoomClass.TabIndex = 5;
            lblRoomClass.Text = "Room Class";
            // 
            // lblNumberOfbeds
            // 
            lblNumberOfbeds.AutoSize = true;
            lblNumberOfbeds.Location = new Point(118, 73);
            lblNumberOfbeds.Name = "lblNumberOfbeds";
            lblNumberOfbeds.Size = new Size(95, 15);
            lblNumberOfbeds.TabIndex = 6;
            lblNumberOfbeds.Text = "Number Of Beds";
            // 
            // cbRoomClass
            // 
            cbRoomClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoomClass.FormattingEnabled = true;
            cbRoomClass.Location = new Point(12, 41);
            cbRoomClass.Name = "cbRoomClass";
            cbRoomClass.Size = new Size(100, 23);
            cbRoomClass.TabIndex = 7;
            // 
            // AddRoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(220, 129);
            Controls.Add(cbRoomClass);
            Controls.Add(lblNumberOfbeds);
            Controls.Add(lblRoomClass);
            Controls.Add(lblRoomNumber);
            Controls.Add(btnAddRoom);
            Controls.Add(txtNumberOfBeds);
            Controls.Add(txtRoomNumber);
            Name = "AddRoomForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Room";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRoomNumber;
        private TextBox txtNumberOfBeds;
        private Button btnAddRoom;
        private Label lblRoomNumber;
        private Label lblRoomClass;
        private Label lblNumberOfbeds;
        private ComboBox cbRoomClass;
    }
}