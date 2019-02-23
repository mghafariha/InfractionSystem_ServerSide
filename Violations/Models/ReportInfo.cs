using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Violations.Models
{
    public class ReportInfo
    {
        public int ReportId { get; set; }
        public string ReportName { get; set; }
        public object[] parameters{ get; set; }
       
    }
}