using KTXForum.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KTXForum.Core.Models.Dormitory
{
    internal class Building
    {
        public int buildingId { get; set; }
        public string name { get; set; }
        public int floors { get; set; }
        public  Gender gender { get; set; }

    }
}
