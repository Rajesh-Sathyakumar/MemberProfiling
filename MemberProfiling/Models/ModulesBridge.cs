using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemberProfiling.Models
{
    public class ModulesBridge
    {
        public string[] moduleServices { get; set; }
        public string[] moduleProduct { get; set; }
        public string[] moduleAccessed { get; set; }
        public string[] moduleNotAccessed { get; set; }
    }
}