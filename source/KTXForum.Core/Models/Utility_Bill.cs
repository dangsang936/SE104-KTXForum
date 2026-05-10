using System;
using System.Collections.Generic;
using System.Text;

namespace KTXForum.Core.Models
{
    public class Utility_Bill
    {
        public int BillId { get; set; }
        public int UserId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public decimal ElectricFee { get; set; }
        public decimal WaterFee { get; set; }
        public decimal OtherFee { get; set; }

        public decimal TotalAmount => ElectricFee + WaterFee + OtherFee;

        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
