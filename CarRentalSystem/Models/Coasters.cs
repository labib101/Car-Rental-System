using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentalSystem.Models
{
    public class Coasters: CarDetails
    {
        public string Entertainment { get; set; }
        public string TourGuide { get; set; }
    }
}