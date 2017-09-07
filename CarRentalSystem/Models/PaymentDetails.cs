using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentalSystem.Models
{
    public class PaymentDetails
    {
        public int ID { get; set; }
        
        public int BookingToken { get; set; }
        public string IssueDate { get; set; }
        public int Payment { get; set; }
    }
}