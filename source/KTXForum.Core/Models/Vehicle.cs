using System;
using System.Collections.Generic;
using System.Text;

namespace KTXForum.Core.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public int UserId { get; set; }
        public string LicensePlate { get; set; }
        public string VehicleType { get; set; }
    }
}