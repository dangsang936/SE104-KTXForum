using System;
using System.Collections.Generic;
using System.Text;

namespace KTXForum.Core.Models
{
    public class RoomRegistration
    {
        public int registrationId { get; set; }
        public int userId { get; set; }
        public int roomId { get; set; }
        public DateTime startDate {  get; set; }
        public DateTime endDate {  get; set; }
        public double totalPrice{  get; set; }
        public string status { get; set; }
        public DateTime createdAt { get; set; }

    }
}
