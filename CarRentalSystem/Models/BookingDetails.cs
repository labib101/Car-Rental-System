using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentalSystem.Models
{
    public class BookingDetails
    {
        public int ID { get; set; }
        public string IssueDate { get; set; }
        public int CarNumber { get; set; }
        public string Pickup { get; set; }
        public string Drop { get; set; }
        public string Fare { get; set; }
        public string JourneyDate { get; set; }
        public string BookingToken { get; set; }
    }
}