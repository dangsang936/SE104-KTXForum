using KTXForum.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KTXForum.Core.Models.Forum
{
    public class Category
    {
        public int categoryId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public CategoryType categoryType { get; set; }
        public CategoryStatus categoryStatus { get; set; }
        public DateTime createdAt { get; set; }
    }
}
