using System;
using System.Collections.Generic;
using System.Text;

namespace KTXForum.Core.Models.User
{
    public class Notification
    {
        public int notificationId { get; set; }
        public int userId { get; set; }
        public string content { get; set; }
        public bool isRead { get; set; } = false;
        public DateTime createdAt { get; set; }
    }
}
