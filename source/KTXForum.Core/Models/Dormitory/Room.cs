using KTXForum.Core.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace KTXForum.Core.Models.Dormitory
{
    public class Room
    {
        public int roomId { get; set; }
        public string building { get; set; }
        public string dormName { get; set; }
        public int roomNumber { get; set; }
        public int capacity { get; set; }
        public int currentOccupancy { get; set; }
        public decimal pricePerMonth { get; set; }
        public RoomStatus status { get; set; }
        public RoomType type { get; set; }
    }
}
