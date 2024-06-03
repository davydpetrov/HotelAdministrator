using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json;

namespace HotelAdministrator.Classes
{
    public class Hotel
    {
        public BindingList<Room> Rooms { get; set; }
        public BindingList<Guest> Guests { get; set; }
        public BindingList<Item> Menu { get; set; }

        public Hotel()
        {
            Rooms = new BindingList<Room>();
            Guests = new BindingList<Guest>();
            Menu = new BindingList<Item>();
        }

        // Method to save data to a file
        public void SaveData(string filePath)
        {
            var data = new
            {
                Rooms,
                Guests,
                Menu
            };

            string jsonString = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonString);
        }

        // Method to load data from a file
        public void LoadData(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                var data = JsonSerializer.Deserialize<Hotel>(jsonString);

                Rooms.Clear();
                foreach (var room in data.Rooms)
                {
                    Rooms.Add(room);
                }

                Guests.Clear();
                foreach (var guest in data.Guests)
                {
                    Guests.Add(guest);
                }

                Menu.Clear();
                foreach (var item in data.Menu)
                {
                    Menu.Add(item);
                }
            }
            else
            {
                Console.WriteLine("Data file not found. Starting with default data.");
            }
        }

    }
}

