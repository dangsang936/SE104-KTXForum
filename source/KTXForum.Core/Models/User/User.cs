using KTXForum.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KTXForum.Core.Models.User
{
    public class User
    {
        private string name { get; set; } 
        private string email { get; set; }
        private string password { get; set; }
        private string avatar { get; set; }
        private int userId { get; set; }
        private Roles role { get; set; }
        private string university { get; set; }
        private string dormName { get; set; }
        private int roomNumber { get; set; }
        private DateTime createdAt { get; set; }
        private string studentCode { get; set; }
        private Gender gender { get; set; }
    }
}
