using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Violations.Models
{
    public class NotAllowedViolationsWorkflow
    {
        public int ID { get; set; }


        [DisplayName("تاريخ")]
        public DateTime? Date { get; set; }

        [DisplayName("توضیحات")]
        public String Description { get; set; }

        [DisplayName("فایل")]
        public string File { get; set; }

        [DisplayName("شماره دستور قضایی")]
        public string Number { get; set; }

        [DisplayName("تاريخ دستور قضایی")]
        public DateTime? DateRun { get; set; }

        [DisplayName("نوع مرحله")]
        public string Step { get; set; }

        [DisplayName("تخلف")]
        public int? ViolationId { get; set; }
        public virtual AllowedViolations NotAllowedViolation { get; set; }
        [DisplayName("نوع تخلف")]
        public string InfractionType { get; set; }

      
    }
}