using KTXForum.Core.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace KTXForum.Core.Models
{
    public class Room
    {
        public int roomId { get; set; }
        public string building { get; set; }
        public string dormName { get; set; }
        public int roomNumber { get; set; }
        public Gender gender { get; set; }
        public int capacity { get; set; }
        public int CurrentOccupancy { get; set; }
        public decimal PricePerMonth { get; set; }
        public RoomStatus status { get; set; }
    }
}
