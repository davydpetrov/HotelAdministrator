namespace HotelAdministrator
{
    partial class OrderBreakfastForm
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
            dgvMenuTable = new DataGridView();
            dgvOrderTable = new DataGridView();
            btnConfirmOrderBreakfast = new Button();
            dtpBreakfastTime = new DateTimePicker();
            lblOrderBreakfast = new Label();
            btnAddItem = new Button();
            btnDeleteItem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMenuTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderTable).BeginInit();
            SuspendLayout();
            // 
            // dgvMenuTable
            // 
            dgvMenuTable.AllowUserToAddRows = false;
            dgvMenuTable.AllowUserToDeleteRows = false;
            dgvMenuTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenuTable.Location = new Point(12, 12);
            dgvMenuTable.Name = "dgvMenuTable";
            dgvMenuTable.Size = new Size(240, 150);
            dgvMenuTable.TabIndex = 0;
            dgvMenuTable.CellDoubleClick += dgvMenuTable_CellDoubleClick;
            dgvMenuTable.CellValueChanged += dgvMenuTable_CellValueChanged;
            // 
            // dgvOrderTable
            // 
            dgvOrderTable.AllowUserToAddRows = false;
            dgvOrderTable.AllowUserToDeleteRows = false;
            dgvOrderTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderTable.Location = new Point(258, 12);
            dgvOrderTable.Name = "dgvOrderTable";
            dgvOrderTable.ReadOnly = true;
            dgvOrderTable.Size = new Size(240, 150);
            dgvOrderTable.TabIndex = 1;
            dgvOrderTable.CellDoubleClick += dgvOrderTable_CellDoubleClick;
            // 
            // btnConfirmOrderBreakfast
            // 
            btnConfirmOrderBreakfast.Location = new Point(12, 226);
            btnConfirmOrderBreakfast.Name = "btnConfirmOrderBreakfast";
            btnConfirmOrderBreakfast.Size = new Size(111, 23);
            btnConfirmOrderBreakfast.TabIndex = 2;
            btnConfirmOrderBreakfast.Text = "Order Breakfast";
            btnConfirmOrderBreakfast.UseVisualStyleBackColor = true;
            btnConfirmOrderBreakfast.Click += btnConfirmOrderBreakfast_Click;
            // 
            // dtpBreakfastTime
            // 
            dtpBreakfastTime.CustomFormat = "HH:mm";
            dtpBreakfastTime.Format = DateTimePickerFormat.Custom;
            dtpBreakfastTime.Location = new Point(152, 226);
            dtpBreakfastTime.Name = "dtpBreakfastTime";
            dtpBreakfastTime.ShowUpDown = true;
            dtpBreakfastTime.Size = new Size(100, 23);
            dtpBreakfastTime.TabIndex = 3;
            // 
            // lblOrderBreakfast
            // 
            lblOrderBreakfast.AutoSize = true;
            lblOrderBreakfast.Location = new Point(129, 230);
            lblOrderBreakfast.Name = "lblOrderBreakfast";
            lblOrderBreakfast.Size = new Size(17, 15);
            lblOrderBreakfast.TabIndex = 4;
            lblOrderBreakfast.Text = "at";
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(12, 168);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(240, 23);
            btnAddItem.TabIndex = 5;
            btnAddItem.Text = "Add Item To Menu";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Location = new Point(12, 197);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(240, 23);
            btnDeleteItem.TabIndex = 6;
            btnDeleteItem.Text = "Delete Item From Menu";
            btnDeleteItem.UseVisualStyleBackColor = true;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // OrderBreakfastForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 259);
            Controls.Add(btnDeleteItem);
            Controls.Add(btnAddItem);
            Controls.Add(lblOrderBreakfast);
            Controls.Add(dtpBreakfastTime);
            Controls.Add(btnConfirmOrderBreakfast);
            Controls.Add(dgvOrderTable);
            Controls.Add(dgvMenuTable);
            Name = "OrderBreakfastForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order Breakfast";
            ((System.ComponentModel.ISupportInitialize)dgvMenuTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMenuTable;
        private DataGridView dgvOrderTable;
        private Button btnConfirmOrderBreakfast;
        private DateTimePicker dtpBreakfastTime;
        private Label lblOrderBreakfast;
        private Button btnAddItem;
        private Button btnDeleteItem;
    }
}