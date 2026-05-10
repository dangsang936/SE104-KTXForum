using System;
using System.Collections.Generic;
using System.Text;

namespace KTXForum.Core.Models.Forum
{
    public class Message
    {
        private int messageId { get; set; }
        private int senderId { get; set; }
        private int receiverId { get; set; }
        private string content { get; set; }
        private DateTime createdAt { get; set; }
        private Boolean isSeen { get; set; } = false;
    }
}
