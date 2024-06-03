using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using HotelAdministrator.Classes;

namespace HotelAdministrator
{
    public partial class CheckInForm : Form
    {
        MainForm mainForm;
        BindingList<Room> rooms;
        BindingList<Guest> guests;

        public CheckInForm(MainForm mainForm, BindingList<Room> rooms, BindingList<Guest> guests)
        {
            this.mainForm = mainForm;
            this.rooms = rooms;
            this.guests = guests;
            InitializeComponent();

            // Add years to combobox
            for (int year = DateTime.Now.Year; year >= 1900; year--)
            {
                cbBirthYear.Items.Add(year);
            }

            // Add genders to combobox
            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");

            // Add room numbers to combobox
            foreach (var room in rooms)
            {
                cbRoomNumber.Items.Add(room.RoomNumber);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            string gender = cbGender.SelectedItem?.ToString();
            int? birthYear = cbBirthYear.SelectedItem as int?;
            string birthPlace = txtBirthPlace.Text;
            string registrationPlace = txtRegistrationPlace.Text;
            string citizenship = txtCitizenship.Text;
            string issuePlace = txtIssuePlace.Text;
            DateTime issueDate = dtpIssueDate.Value.Date;
            DateTime validUntil = dtpValidUntil.Value.Date;
            string taxNumber = txtTaxNumber.Text;
            DateTime arrivalDate = dtpArrivalDate.Value.Date;
            DateTime departureDate = dtpDepartureDate.Value.Date;
            int? roomNumber = cbRoomNumber.SelectedItem as int?;

            // Ensure all required fields are filled
            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(gender) ||
                birthYear == null ||
                string.IsNullOrWhiteSpace(birthPlace) ||
                string.IsNullOrWhiteSpace(registrationPlace) ||
                string.IsNullOrWhiteSpace(citizenship) ||
                string.IsNullOrWhiteSpace(issuePlace) ||
                string.IsNullOrWhiteSpace(taxNumber) ||
                roomNumber == null)
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            // Check if a guest with the same TaxNumber already exists
            if (guests.Any(g => g.TaxNumber == taxNumber))
            {
                MessageBox.Show("A guest with the same passport details already exists.");
                return;
            }

            // Check if issueDate is later than validUntil
            if (issueDate > validUntil)
            {
                MessageBox.Show("The issue date cannot be later than the valid until date.");
                return;
            }

            // Check if arrivalDate is later than departureDate
            if (arrivalDate > departureDate)
            {
                MessageBox.Show("The arrival date cannot be later than the departure date.");
                return;
            }

            Room selectedRoom = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber.Value);

            if (selectedRoom != null && selectedRoom.FreeSpaces > 0)
            {
                Guest newGuest = new Guest
                {
                    FullName = fullName,
                    Gender = gender,
                    BirthYear = birthYear.Value,
                    BirthPlace = birthPlace,
                    RegistrationPlace = registrationPlace,
                    Citizenship = citizenship,
                    IssuePlace = issuePlace,
                    IssueDate = issueDate,
                    ValidUntil = validUntil,
                    TaxNumber = taxNumber,
                    ArrivalDate = arrivalDate,
                    DepartureDate = departureDate,
                    RoomNumber = roomNumber.Value,
                    RoomClass = selectedRoom.RoomClass
                };

                if (selectedRoom.AddGuest(newGuest))
                {
                    guests.Add(newGuest);
                    mainForm.UpdateGuestsTable();
                    mainForm.UpdateRoomsTable();

                    // Calculate the total stay duration in days
                    int totalDays = (departureDate - arrivalDate).Days;

                    // Calculate the total amount
                    int ratePerDay = selectedRoom.RatePerDay;
                    int totalAmount = totalDays * ratePerDay;

                    // Replace the MessageBox.Show with file creation and writing

                    // Construct the file name based on guest's full name
                    string fileName = $"Receipt_Check_In_{newGuest.FullName}.txt";

                    // Define the path where the file will be saved
                    string filePath = Path.Combine(Environment.CurrentDirectory, fileName);

                    // Write guest details and total amount into the text file
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine($"Guest Details:");
                        writer.WriteLine($"Full Name: {newGuest.FullName}");
                        writer.WriteLine($"Gender: {newGuest.Gender}");
                        writer.WriteLine($"Birth Year: {newGuest.BirthYear}");
                        writer.WriteLine($"Birth Place: {newGuest.BirthPlace}");
                        writer.WriteLine($"Registration Place: {newGuest.RegistrationPlace}");
                        writer.WriteLine($"Citizenship: {newGuest.Citizenship}");
                        writer.WriteLine($"Issue Place: {newGuest.IssuePlace}");
                        writer.WriteLine($"Issue Date: {newGuest.IssueDate.ToShortDateString()}");
                        writer.WriteLine($"Valid Until: {newGuest.ValidUntil.ToShortDateString()}");
                        writer.WriteLine($"Tax Number: {newGuest.TaxNumber}");
                        writer.WriteLine($"Arrival Date: {newGuest.ArrivalDate.ToShortDateString()}");
                        writer.WriteLine($"Departure Date: {newGuest.DepartureDate.ToShortDateString()}");
                        writer.WriteLine($"Room Number: {newGuest.RoomNumber}");
                        writer.WriteLine($"Room Class: {selectedRoom.RoomClass}");
                        writer.WriteLine($"Total Days: {totalDays}");
                        writer.WriteLine($"Total Amount: ${totalAmount}");
                    }

                    // Open the text file after writing
                    ProcessStartInfo psi = new ProcessStartInfo(filePath)
                    {
                        UseShellExecute = true
                    };
                    Process.Start(psi);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add guest to the room.");
                }
            }
            else
            {
                MessageBox.Show("Room not found or no free spaces available.");
            }
        }
    }
}
