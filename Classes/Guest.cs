using System;
using System.ComponentModel;

namespace HotelAdministrator.Classes
{
    public class Guest
    {
        public string FullName { get; set; }
        public string Gender { get; set; }
        public int BirthYear { get; set; }
        public string BirthPlace { get; set; }
        public string RegistrationPlace { get; set; }
        public string Citizenship { get; set; }
        public string IssuePlace { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ValidUntil { get; set; }
        public string TaxNumber { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public int RoomNumber { get; set; }
        public string RoomClass { get; set; }
        public string BreakfastTime { get; set; } = "--:--";
        public string Order { get; set; } = "";
    }
}
