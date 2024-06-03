using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using HotelAdministrator.Classes;

namespace HotelAdministrator
{
    public partial class MainForm : Form
    {
        private Hotel hotel;
        private bool sortAscendingRooms = false;
        private bool sortAscendingGuests = false;

        public MainForm()
        {
            InitializeComponent();
            hotel = new Hotel();
            hotel.LoadData("data.txt");
            dgvRoomsTable.DataSource = hotel.Rooms;
            dgvGuestsTable.DataSource = hotel.Guests;
        }

        public void UpdateGuestsTable()
        {
            hotel.SaveData("data.txt");
            dgvGuestsTable.DataSource = hotel.Guests;
            dgvGuestsTable.Refresh();
        }

        public void UpdateRoomsTable()
        {
            hotel.SaveData("data.txt");
            dgvRoomsTable.DataSource = hotel.Rooms;
            dgvRoomsTable.Refresh();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            CheckInForm checkInForm = new CheckInForm(this, hotel.Rooms, hotel.Guests);
            checkInForm.Show();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            var guestsDepartingToday = hotel.Guests.Where(g => g.DepartureDate.Date == DateTime.Today.Date).ToList();

            if (guestsDepartingToday.Count > 0)
            {
                var confirmationResult = MessageBox.Show("Confirm?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmationResult == DialogResult.OK)
                {
                    foreach (var guest in guestsDepartingToday)
                    {
                        // Remove the guest
                        hotel.Guests.Remove(guest);

                        // Find the room and update it
                        Room room = hotel.Rooms.FirstOrDefault(r => r.RoomNumber == guest.RoomNumber);
                        if (room != null)
                        {
                            for (int i = 0; i < room.Roommates.Length; i++)
                            {
                                if (room.Roommates[i] == guest)
                                {
                                    room.Roommates[i] = null;
                                    break;
                                }
                            }
                        }

                        //write code here xdddd
                        // Calculate the total stay duration in days
                        int totalDays = (guest.DepartureDate - guest.ArrivalDate).Days;
                        if (totalDays < 0)
                        {
                            MessageBox.Show("Departure date cannot be before the arrival date.");
                            return;
                        }

                        // Calculate the total amount
                        int ratePerDay = room.RatePerDay;
                        int totalAmount = totalDays * ratePerDay;

                        // Replace the MessageBox.Show with file creation and writing

                        // Construct the file name based on guest's full name
                        string fileName = $"Receipt_Check_Out_{guest.FullName}.txt";

                        // Define the path where the file will be saved
                        string filePath = Path.Combine(Environment.CurrentDirectory, fileName);

                        // Write guest details and total amount into the text file
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            writer.WriteLine($"Guest Details:");
                            writer.WriteLine($"Full Name: {guest.FullName}");
                            writer.WriteLine($"Gender: {guest.Gender}");
                            writer.WriteLine($"Birth Year: {guest.BirthYear}");
                            writer.WriteLine($"Birth Place: {guest.BirthPlace}");
                            writer.WriteLine($"Registration Place: {guest.RegistrationPlace}");
                            writer.WriteLine($"Citizenship: {guest.Citizenship}");
                            writer.WriteLine($"Issue Place: {guest.IssuePlace}");
                            writer.WriteLine($"Issue Date: {guest.IssueDate.ToShortDateString()}");
                            writer.WriteLine($"Valid Until: {guest.ValidUntil.ToShortDateString()}");
                            writer.WriteLine($"Tax Number: {guest.TaxNumber}");
                            writer.WriteLine($"Arrival Date: {guest.ArrivalDate.ToShortDateString()}");
                            writer.WriteLine($"Departure Date: {guest.DepartureDate.ToShortDateString()}");
                            writer.WriteLine($"Room Number: {guest.RoomNumber}");
                            writer.WriteLine($"Room Class: {room.RoomClass}");
                            writer.WriteLine($"Total Days: {totalDays}");
                            writer.WriteLine($"Total Amount: ${totalAmount}");
                        }

                        // Open the text file after writing
                        ProcessStartInfo psi = new ProcessStartInfo(filePath)
                        {
                            UseShellExecute = true
                        };
                        Process.Start(psi);

                    }

                    // Update the tables
                    UpdateGuestsTable();
                    UpdateRoomsTable();
                }
            }
            else
            {
                MessageBox.Show("No guests with a departure date of today.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExtendStay_Click(object sender, EventArgs e)
        {
            DateTime extendUntil = dtpExtendUntil.Value.Date;
            var selectedGuests = new List<Guest>();

            foreach (DataGridViewRow row in dgvGuestsTable.SelectedRows)
            {
                var guest = row.DataBoundItem as Guest;
                if (guest != null)
                {
                    selectedGuests.Add(guest);
                }
            }

            if (selectedGuests.Count > 0)
            {
                if (selectedGuests.Any(g => extendUntil <= g.DepartureDate))
                {
                    MessageBox.Show("Extend until date must be greater than the current departure date of the selected guest(s).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirmationResult = MessageBox.Show("Confirm?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmationResult == DialogResult.OK)
                {
                    foreach (var guest in selectedGuests) guest.DepartureDate = extendUntil;
                    foreach (var guest in selectedGuests)
                    {
                        Room room = hotel.Rooms.FirstOrDefault(r => r.RoomNumber == guest.RoomNumber);
                        // Calculate the total stay duration in days
                        int totalDays = (guest.DepartureDate - guest.ArrivalDate).Days;
                        if (totalDays < 0)
                        {
                            MessageBox.Show("Departure date cannot be before the arrival date.");
                            return;
                        }
                        //write code here xddd
                        // Calculate the total amount
                        int ratePerDay = room.RatePerDay;
                        int totalAmount = totalDays * ratePerDay;

                        // Replace the MessageBox.Show with file creation and writing

                        // Construct the file name based on guest's full name
                        string fileName = $"Receipt_Extention_{guest.FullName}.txt";

                        // Define the path where the file will be saved
                        string filePath = Path.Combine(Environment.CurrentDirectory, fileName);

                        // Write guest details and total amount into the text file
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            writer.WriteLine($"Guest Details:");
                            writer.WriteLine($"Full Name: {guest.FullName}");
                            writer.WriteLine($"Gender: {guest.Gender}");
                            writer.WriteLine($"Birth Year: {guest.BirthYear}");
                            writer.WriteLine($"Birth Place: {guest.BirthPlace}");
                            writer.WriteLine($"Registration Place: {guest.RegistrationPlace}");
                            writer.WriteLine($"Citizenship: {guest.Citizenship}");
                            writer.WriteLine($"Issue Place: {guest.IssuePlace}");
                            writer.WriteLine($"Issue Date: {guest.IssueDate.ToShortDateString()}");
                            writer.WriteLine($"Valid Until: {guest.ValidUntil.ToShortDateString()}");
                            writer.WriteLine($"Tax Number: {guest.TaxNumber}");
                            writer.WriteLine($"Arrival Date: {guest.ArrivalDate.ToShortDateString()}");
                            writer.WriteLine($"Departure Date: {guest.DepartureDate.ToShortDateString()}");
                            writer.WriteLine($"Room Number: {guest.RoomNumber}");
                            writer.WriteLine($"Room Class: {room.RoomClass}");
                            writer.WriteLine($"Total Days: {totalDays}");
                            writer.WriteLine($"Total Amount: ${totalAmount}");
                        }

                        // Open the text file after writing
                        ProcessStartInfo psi = new ProcessStartInfo(filePath)
                        {
                            UseShellExecute = true
                        };
                        Process.Start(psi);
                    }

                    // Update the tables
                    UpdateGuestsTable();
                    UpdateRoomsTable();
                }
            }
            else
            {
                MessageBox.Show("No guests selected for extension.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEarlyDeparture_Click(object sender, EventArgs e)
        {
            DateTime earlyDeparture = dtpEarlyDeparture.Value.Date;
            var selectedGuests = new List<Guest>();

            foreach (DataGridViewRow row in dgvGuestsTable.SelectedRows)
            {
                var guest = row.DataBoundItem as Guest;
                if (guest != null)
                {
                    selectedGuests.Add(guest);
                }
            }

            if (selectedGuests.Count > 0)
            {
                var confirmationResult = MessageBox.Show("Confirm?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmationResult == DialogResult.OK)
                {
                    foreach (var guest in selectedGuests) guest.DepartureDate = earlyDeparture;
                    foreach (var guest in selectedGuests)
                    {

                        // Find the room and update it
                        Room room = hotel.Rooms.FirstOrDefault(r => r.RoomNumber == guest.RoomNumber);
                        if (room != null)
                        {
                            for (int i = 0; i < room.Roommates.Length; i++)
                            {
                                if (room.Roommates[i] == guest)
                                {
                                    room.Roommates[i] = null;
                                    break;
                                }
                            }
                        }
                        // write code here xxdddd
                        // Calculate the total stay duration in days
                        int totalDays = (guest.DepartureDate - guest.ArrivalDate).Days;
                        if (totalDays < 0)
                        {
                            MessageBox.Show("Departure date cannot be before the arrival date.");
                            return;
                        }

                        // Calculate the total amount
                        int ratePerDay = room.RatePerDay;
                        int totalAmount = totalDays == 0 ? ratePerDay : totalDays * ratePerDay;

                        // Replace the MessageBox.Show with file creation and writing

                        // Construct the file name based on guest's full name
                        string fileName = $"Receipt_Early_Departure_{guest.FullName}.txt";

                        // Define the path where the file will be saved
                        string filePath = Path.Combine(Environment.CurrentDirectory, fileName);

                        // Write guest details and total amount into the text file
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            writer.WriteLine($"Guest Details:");
                            writer.WriteLine($"Full Name: {guest.FullName}");
                            writer.WriteLine($"Gender: {guest.Gender}");
                            writer.WriteLine($"Birth Year: {guest.BirthYear}");
                            writer.WriteLine($"Birth Place: {guest.BirthPlace}");
                            writer.WriteLine($"Registration Place: {guest.RegistrationPlace}");
                            writer.WriteLine($"Citizenship: {guest.Citizenship}");
                            writer.WriteLine($"Issue Place: {guest.IssuePlace}");
                            writer.WriteLine($"Issue Date: {guest.IssueDate.ToShortDateString()}");
                            writer.WriteLine($"Valid Until: {guest.ValidUntil.ToShortDateString()}");
                            writer.WriteLine($"Tax Number: {guest.TaxNumber}");
                            writer.WriteLine($"Arrival Date: {guest.ArrivalDate.ToShortDateString()}");
                            writer.WriteLine($"Departure Date: {guest.DepartureDate.ToShortDateString()}");
                            writer.WriteLine($"Room Number: {guest.RoomNumber}");
                            writer.WriteLine($"Room Class: {room.RoomClass}");
                            writer.WriteLine($"Total Days: {totalDays}");
                            writer.WriteLine($"Total Amount: ${totalAmount}");
                        }

                        // Open the text file after writing
                        ProcessStartInfo psi = new ProcessStartInfo(filePath)
                        {
                            UseShellExecute = true
                        };
                        Process.Start(psi);
                    }

                    // Update the tables
                    UpdateGuestsTable();
                    UpdateRoomsTable();
                }
            }
            else
            {
                MessageBox.Show("No guests selected for early departure.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearchGuests_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchGuests.Text.ToLower();
            var filteredGuests = hotel.Guests.Where(g =>
                g.FullName.ToLower().Contains(searchText) ||
                g.Gender.ToLower().Contains(searchText) ||
                g.BirthYear.ToString().Contains(searchText) ||
                g.BirthPlace.ToLower().Contains(searchText) ||
                g.RegistrationPlace.ToLower().Contains(searchText) ||
                g.Citizenship.ToLower().Contains(searchText) ||
                g.IssuePlace.ToLower().Contains(searchText) ||
                g.IssueDate.ToString("d").Contains(searchText) ||
                g.ValidUntil.ToString("d").Contains(searchText) ||
                g.TaxNumber.ToLower().Contains(searchText) ||
                g.ArrivalDate.ToString("d").Contains(searchText) ||
                g.DepartureDate.ToString("d").Contains(searchText) ||
                g.RoomNumber.ToString().Contains(searchText) ||
                g.RoomClass.ToLower().Contains(searchText) ||
                g.BreakfastTime.ToLower().Contains(searchText)).ToList();

            dgvGuestsTable.DataSource = new BindingList<Guest>(filteredGuests);
        }

        private void btnOrderBreakfast_Click(object sender, EventArgs e)
        {
            if (dgvGuestsTable.SelectedRows.Count > 0)
            {
                var selectedRow = dgvGuestsTable.SelectedRows[0];
                var selectedGuest = (Guest)selectedRow.DataBoundItem;
                if (selectedGuest.RoomClass == "Luxury")
                {
                    OrderBreakfastForm orderBreakfastForm = new OrderBreakfastForm(this, selectedGuest, hotel.Menu, hotel);
                    orderBreakfastForm.Show();
                }
                else MessageBox.Show("Luxury only!");
            }
            else
            {
                MessageBox.Show("Please select a guest first.");
            }
        }

        private void btnOrderCleaning_Click(object sender, EventArgs e)
        {
            DateTime cleaningTime = dtpCleaningTime.Value;
            var selectedRooms = new List<Room>();

            int luxuryCheck = 1;
            foreach (DataGridViewRow row in dgvRoomsTable.SelectedRows)
            {
                var room = row.DataBoundItem as Room;

                if (room != null && room.RoomClass != "Economy")
                {
                    selectedRooms.Add(room);
                }
                else if (room.RoomClass == "Economy")
                {
                    luxuryCheck = 0;
                }
            }

            if (luxuryCheck == 0)
            {
                MessageBox.Show("Luxury only!");
            }
            else
            {
                if (selectedRooms.Count > 0)
                {
                    var confirmationResult = MessageBox.Show("Confirm?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmationResult == DialogResult.OK)
                    {
                        foreach (var room in selectedRooms)
                        {
                            room.CleaningTime = $"{cleaningTime.Hour}" + $":{cleaningTime.Minute}";
                        }

                        // Update the tables
                        UpdateGuestsTable();
                        UpdateRoomsTable();
                    }
                }
                else
                {
                    MessageBox.Show("No rooms selected for cleaning.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            AddRoomForm addRoomForm = new AddRoomForm(this, hotel.Rooms);
            addRoomForm.Show();
        }

        private void dgvGuestsTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Get the updated guest object
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGuestsTable.Rows[e.RowIndex];
                Guest updatedGuest = (Guest)row.DataBoundItem;

                // Ensure all required fields are filled
                if (string.IsNullOrWhiteSpace(updatedGuest.FullName) ||
                    string.IsNullOrWhiteSpace(updatedGuest.Gender) ||
                    updatedGuest.BirthYear == 0 ||
                    string.IsNullOrWhiteSpace(updatedGuest.BirthPlace) ||
                    string.IsNullOrWhiteSpace(updatedGuest.RegistrationPlace) ||
                    string.IsNullOrWhiteSpace(updatedGuest.Citizenship) ||
                    string.IsNullOrWhiteSpace(updatedGuest.IssuePlace) ||
                    updatedGuest.IssueDate == default ||
                    updatedGuest.ValidUntil == default ||
                    string.IsNullOrWhiteSpace(updatedGuest.TaxNumber) ||
                    updatedGuest.ArrivalDate == default ||
                    updatedGuest.DepartureDate == default ||
                    updatedGuest.RoomNumber == 0 ||
                    string.IsNullOrWhiteSpace(updatedGuest.RoomClass))
                {
                    MessageBox.Show("Please fill in all the fields.");
                    return;
                }
                else
                {
                    // Update the guest in the BindingList
                    hotel.Guests[e.RowIndex] = updatedGuest;

                    // Save the updated data
                    UpdateGuestsTable();
                    UpdateRoomsTable();
                }

                
            }
        }

        private void dgvRoomsTable_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = dgvRoomsTable.Columns[e.ColumnIndex].DataPropertyName;
            if (sortAscendingRooms)
            {
                hotel.Rooms = new BindingList<Room>(hotel.Rooms.OrderBy(r => GetPropertyValue(r, columnName)).ToList());
            }
            else
            {
                hotel.Rooms = new BindingList<Room>(hotel.Rooms.OrderByDescending(r => GetPropertyValue(r, columnName)).ToList());
            }
            sortAscendingRooms = !sortAscendingRooms;
            dgvRoomsTable.DataSource = hotel.Rooms;
        }

        private object GetPropertyValue(object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName).GetValue(obj, null);
        }

        private void dgvGuestsTable_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = dgvGuestsTable.Columns[e.ColumnIndex].DataPropertyName;
            if (sortAscendingGuests)
            {
                hotel.Guests = new BindingList<Guest>(hotel.Guests.OrderBy(r => GetPropertyValue(r, columnName)).ToList());
            }
            else
            {
                hotel.Guests = new BindingList<Guest>(hotel.Guests.OrderByDescending(r => GetPropertyValue(r, columnName)).ToList());
            }
            sortAscendingGuests = !sortAscendingGuests;
            dgvGuestsTable.DataSource = hotel.Guests;
        }

        private void dgvRoomsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var room = dgvRoomsTable.Rows[e.RowIndex].DataBoundItem as Room;
                if (room != null)
                {
                    var confirmationResult = MessageBox.Show($"Are you sure you want to delete Room {room.RoomNumber}? \nALL GUESTS IN THE ROOM WILL BE DELETED!", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmationResult == DialogResult.Yes)
                    {
                        // Remove guests associated with the room
                        var guestsToRemove = hotel.Guests.Where(g => g.RoomNumber == room.RoomNumber).ToList();
                        foreach (var guest in guestsToRemove)
                        {
                            hotel.Guests.Remove(guest);
                        }

                        // Remove the room
                        hotel.Rooms.Remove(room);

                        // Update the DataGridViews
                        UpdateRoomsTable();
                        UpdateGuestsTable();
                    }
                }
            }
        }

        private void dgvGuestsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var guest = dgvGuestsTable.Rows[e.RowIndex].DataBoundItem as Guest;
            if (guest != null)
            {
                var confirmationResult = MessageBox.Show($"Are you sure you want to delete Guest {guest.FullName}?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmationResult == DialogResult.Yes)
                {

                    // Remove the guest
                    hotel.Guests.Remove(guest);

                    // Update the DataGridViews
                    UpdateRoomsTable();
                    UpdateGuestsTable();
                }
            }
        }

        private void dgvRoomsTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Get the updated room object
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRoomsTable.Rows[e.RowIndex];
                Room updatedRoom = (Room)row.DataBoundItem;

                // Ensure all required fields are filled
                if (updatedRoom.RoomNumber == 0 ||
                    string.IsNullOrWhiteSpace(updatedRoom.RoomClass) ||
                    updatedRoom.NumberOfBeds == 0)
                {
                    MessageBox.Show("Please fill in all the fields.");
                    return;
                }
                else
                {
                    // Update the rooms in the BindingList
                    hotel.Rooms[e.RowIndex] = updatedRoom;

                    // Save the updated data
                    UpdateGuestsTable();
                    UpdateRoomsTable();
                }
            }
        }
    }
}
