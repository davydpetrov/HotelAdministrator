namespace HotelAdministrator
{
    partial class AddItemForm
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
            lblItemName = new Label();
            lblPrice = new Label();
            txtItemName = new TextBox();
            txtPrice = new TextBox();
            btnAddItem = new Button();
            SuspendLayout();
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(118, 15);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(66, 15);
            lblItemName.TabIndex = 0;
            lblItemName.Text = "Item Name";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(118, 44);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Price";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(12, 12);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(100, 23);
            txtItemName.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(12, 41);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 3;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(12, 70);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(75, 23);
            btnAddItem.TabIndex = 4;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // AddItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(201, 99);
            Controls.Add(btnAddItem);
            Controls.Add(txtPrice);
            Controls.Add(txtItemName);
            Controls.Add(lblPrice);
            Controls.Add(lblItemName);
            Name = "AddItem";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItemName;
        private Label lblPrice;
        private TextBox txtItemName;
        private TextBox txtPrice;
        private Button btnAddItem;
    }
}