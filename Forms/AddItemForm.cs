using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelAdministrator.Classes;

namespace HotelAdministrator
{
    public partial class AddItemForm : Form
    {
        OrderBreakfastForm orderBreakfastForm;
        BindingList<Item> menu;
        public AddItemForm(OrderBreakfastForm orderBreakfastForm, BindingList<Item> menu)
        {
            this.orderBreakfastForm = orderBreakfastForm;
            this.menu = menu;
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string itemName = txtItemName.Text;
            double price = double.Parse(txtPrice.Text);

            Item newItem = new Item
            {
                ItemName = itemName,
                Price = price,
            };

            menu.Add(newItem);
            orderBreakfastForm.UpdateMenuTable();
            this.Close();
        }
    }
}
