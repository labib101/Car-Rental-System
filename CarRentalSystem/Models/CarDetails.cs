using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentalSystem.Models
{
    public class CarDetails
    {
        public int ID { get; set; }
        
        public string RegNum { get; set; }
        public string DriverName { get; set; }
        public string CarManufacturer { get; set; }
        public string ModelName { get; set; }
        public string FuelType { get; set; }
        public int NumberofSeats { get; set; }

    }
}