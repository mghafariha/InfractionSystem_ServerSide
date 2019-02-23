using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Violations.Models
{
    public class Attachment
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
    }
}