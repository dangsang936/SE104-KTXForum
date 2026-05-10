using KTXForum.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KTXForum.Core.Models
{
    public class Reaction
    {
        public int reactionId { get; set; }

        public int userId { get; set; }

        public int postId { get; set; }
        public ReactionType type { get; set; }
    }
}
