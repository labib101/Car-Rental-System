using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentalSystem.Models
{
    public class BankingDetails
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string CardType { get; set; }
        public string AccountNumber { get; set; }
        public string CardPin { get; set; }
    }
}