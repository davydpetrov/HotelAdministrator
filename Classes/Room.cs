using System;

namespace HotelAdministrator.Classes
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public string RoomClass { get; set; }
        public int RatePerDay
        {
            get
            {
                if (RoomClass == "Luxury") return 100;
                else if (RoomClass == "Economy") return 20;
                else return 0;
            }
        }
        private int numberOfBeds;
        public int NumberOfBeds
        {
            get { return numberOfBeds; }
            set
            {
                numberOfBeds = value;
                Roommates = new Guest[numberOfBeds];
            }
        }
        public string CleaningTime { get; set; } = "--:--";

        private Guest[] roommates;
        public Guest[] Roommates
        {
            get { return roommates; }
            set { roommates = value; }
        }

        public Room() { }

        public Room(int roomNumber, string roomClass, int numberOfBeds)
        {
            RoomNumber = roomNumber;
            RoomClass = roomClass;
            NumberOfBeds = numberOfBeds;
            Roommates = new Guest[numberOfBeds];
        }


        public bool AddGuest(Guest guest)
        {
            for (int i = 0; i < roommates.Length; i++)
            {
                if (roommates[i] == null)
                {
                    roommates[i] = guest;
                    return true;
                }
            }
            return false;
        }

        public int FreeSpaces
        {
            get
            {
                int freeSpaces = 0;
                foreach (var roommate in roommates)
                {
                    if (roommate == null)
                    {
                        freeSpaces++;
                    }
                }
                return freeSpaces;
            }
        }
    }
}
