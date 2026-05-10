using System;
using System.Collections.Generic;
using System.Text;

namespace KTXForum.Core.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int RoomRegistrationId { get; set; }
        public double Amount { get; set; }
       
    }
}
