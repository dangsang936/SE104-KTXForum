using System;
using System.Collections.Generic;
using System.Text;

namespace KTXForum.Core.Models.Complaint
{
    public class Complaint
    {
        public int complaintId { get; set; }
        public int userId { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string status { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? resolvedAt { get; set; }
    }
}