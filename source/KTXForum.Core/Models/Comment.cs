using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace KTXForum.Core.Models
{
    internal class Comment
    {
        private int commentId { get; set; }
        private string content { get; set; }
        private DateTime createdAt { get; set; }
        private Boolean isUpdated { get; set; }=false;
        private int userId { get; set; }
        private int postId { get; set; }
        private int parentCommentId { get; set; }
    }
}
