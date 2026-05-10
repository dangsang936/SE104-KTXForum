using KTXForum.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KTXForum.Core.Models.Billing
{
    public class Utility_Bill
    {
        public int billId { get; set; }
        public int userId { get; set; }
        public int month { get; set; }
        public int year { get; set; }

        public decimal electricFee { get; set; }
        public decimal waterFee { get; set; }
        public decimal otherFee { get; set; }
        public decimal totalAmount => electricFee + waterFee + otherFee;

        public string status { get; set; }
        public DateTime createdAt { get; set; }
        public PaymentStatus paymentStatus { get; set; } = PaymentStatus.Pending;
    }
}
