using KTXForum.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KTXForum.Core.Models.Billing
{
    internal class ParkingBill
    {
        public int parkingBillId { get; set; }
        public int parkingRegistrationId { get; set; }
        public decimal totalPrice { get; set; }
        public PaymentStatus paymentStatus { get; set; } = PaymentStatus.Pending;
    }
}
