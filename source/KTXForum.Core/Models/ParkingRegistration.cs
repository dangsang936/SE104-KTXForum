using System;
using System.Collections.Generic;
using System.Text;

namespace KTXForum.Core.Models
{
    public class ParkingRegistration
    {
        public int ParkingRegistrationId { get; set; }
        public int VehicleId { get; set; }
        public int DurationMonths { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }
    }
}