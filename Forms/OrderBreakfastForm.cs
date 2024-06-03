using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelAdministrator.Classes;

namespace HotelAdministrator
{
    public partial class OrderBreakfastForm : Form
    {
        MainForm mainForm;
        Guest selectedGuest;
        BindingList<Item> menu;
        Hotel hotel;
        BindingList<Item> order = new BindingList<Item>();
        public OrderBreakfastForm(MainForm mainForm, Guest selectedGuest, BindingList<Item> menu, Hotel hotel)
        {
            this.mainForm = mainForm;
            this.selectedGuest = selectedGuest;
            this.menu = menu;
            this.hotel = hotel;
            InitializeComponent();
            InitializeMenuTable();
            InitializeOrderTable();
        }

        private void InitializeMenuTable()
        {
            dgvMenuTable.DataSource = menu;
        }

        private void InitializeOrderTable()
        {
            dgvOrderTable.DataSource = order;
        }

        public void UpdateMenuTable()
        {
            dgvMenuTable.DataSource = hotel.Menu;
            dgvMenuTable.Refresh();
            hotel.SaveData("data.txt");
        }

        private void btnConfirmOrderBreakfast_Click(object sender, EventArgs e)
        {
            DateTime selectedTime = dtpBreakfastTime.Value;
            if (selectedTime.Hour < 6 || selectedTime.Hour >= 9)
            {
                MessageBox.Show("Please select the time between 6 and 9AM.");
                return;
            }
            else
            {
                selectedGuest.BreakfastTime = selectedTime.ToString("HH:mm");
                selectedGuest.Order = string.Join(", ", order.Select(o => o.ItemName));

                mainForm.UpdateGuestsTable();
                mainForm.UpdateRoomsTable();

                // Replace the MessageBox.Show with file creation and writing

                // Construct the file name based on guest's full name
                string fileName = $"Receipt_Breakfast_{selectedGuest.FullName}.txt";

                // Define the path where the file will be saved
                string filePath = Path.Combine(Environment.CurrentDirectory, fileName);

                // Write guest details and total amount into the text file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Breakfast ordered for " + selectedGuest.FullName);
                    writer.WriteLine(" at " + selectedTime.ToString("HH:mm"));
                    writer.WriteLine("\nOrder details: " + string.Join(", ", order.Select(o => o.ItemName)));
                    writer.WriteLine("\nTotal: " + order.Sum(item => item.Price));
                }

                // Open the text file after writing
                ProcessStartInfo psi = new ProcessStartInfo(filePath)
                {
                    UseShellExecute = true
                };
                Process.Start(psi);

                this.Close();
            }
        }

        private void dgvMenuTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Item selectedItem = menu[e.RowIndex];
                order.Add(selectedItem);
            }
        }

        private void dgvOrderTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Item selectedItem = menu[e.RowIndex];
                order.Remove(selectedItem);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItemForm addItem = new AddItemForm(this, menu);
            addItem.Show();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvMenuTable.SelectedRows.Count > 0)
            {
                var selectedRow = dgvMenuTable.SelectedRows[0];
                var selectedItem = selectedRow.DataBoundItem as Item;

                if (selectedItem != null)
                {
                    var confirmationResult = MessageBox.Show($"Are you sure you want to delete the item {selectedItem.ItemName}?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmationResult == DialogResult.Yes)
                    {
                        menu.Remove(selectedItem);
                        UpdateMenuTable();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvMenuTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var updatedItem = dgvMenuTable.Rows[e.RowIndex].DataBoundItem as Item;
                if (updatedItem != null)
                {
                    // Update the menu list to reflect the changes
                    menu[e.RowIndex] = updatedItem;
                    UpdateMenuTable();
                }
            }
        }
    }
}
