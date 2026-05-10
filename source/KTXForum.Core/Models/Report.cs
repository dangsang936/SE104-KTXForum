using System;
using System.Collections.Generic;
using System.Text;

namespace KTXForum.Core.Models
{
    public class Report
    {
        public int reportId { get; set; }
        
        public int userId { get; set; }

        public int postId { get; set; }

        public string reason { get; set; }

        public DateTime createdAt { get; set; }
    }
}
