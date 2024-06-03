using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelAdministrator.Classes;

namespace HotelAdministrator
{
    public partial class AddRoomForm : Form
    {
        MainForm mainForm;
        BindingList<Room> rooms;
        public AddRoomForm(MainForm mainForm, BindingList<Room> rooms)
        {
            this.mainForm = mainForm;
            this.rooms = rooms;
            // Add classes to combobox
            
            InitializeComponent();

            cbRoomClass.Items.Add("Economy");
            cbRoomClass.Items.Add("Luxury");
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            int roomNumber = int.Parse(txtRoomNumber.Text);
            string roomClass = cbRoomClass.SelectedItem?.ToString();
            int numberOfBeds = int.Parse(txtNumberOfBeds.Text);
            if(!RoomExists(roomNumber))
            {
                Room newRoom = new Room
                {
                    RoomNumber = roomNumber,
                    RoomClass = roomClass,
                    NumberOfBeds = numberOfBeds,
                };

                rooms.Add(newRoom);
                mainForm.UpdateGuestsTable();
                mainForm.UpdateRoomsTable();
                this.Close();
            }
            else
            {
                MessageBox.Show("Room already exists!");
            }
        }

        private bool RoomExists(int roomNumber)
        {
            int flag = 0;
            foreach (Room room in rooms)
            {
                if (room.RoomNumber == roomNumber)
                {
                    flag = 1;
                }
            }
            return flag == 0 ? false : true;
        }
    }
}
