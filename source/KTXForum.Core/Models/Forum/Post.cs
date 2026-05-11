using KTXForum.Core.Enums;
using System;

namespace KTXForum.Core.Models.Forum
{
    public class Post
    {
        public int postId { get; set; }

        public string title { get; set; }

        public string content { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime updatedAt { get; set; }

        public int userId { get; set; }

        public int categoryId { get; set; }

        public PostStatus status { get; set; }

        public string imageUrl { get; set; }

        public int viewCount { get; set; }

        public int likeCount { get; set; }

        public int dislikeCount { get; set; }

        public int commentCount { get; set; }

        public int shareCount { get; set; }
        public int reportCount { get; set; }
    }
}