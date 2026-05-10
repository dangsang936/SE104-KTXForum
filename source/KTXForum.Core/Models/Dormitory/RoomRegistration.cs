using KTXForum.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KTXForum.Core.Models.Dormitory
{
    public class RoomRegistration
    {
        public int roomRegistrationId { get; set; }
        public int userId { get; set; }
        public int roomId { get; set; }
        public DateTime startDate {  get; set; }
        public DateTime endDate {  get; set; }
        public double totalPrice{  get; set; }
        public RoomRegistrationStatus status { get; set; }
        public DateTime createdAt { get; set; }

    }
}
