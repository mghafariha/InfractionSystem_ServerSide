using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Violations.Models;

namespace Violations.Models
{
    public class AllowedViolationsWorkflow
    {

        public int ID { get; set; }


        [DisplayName("تاريخ")]
        public DateTime? Date { get; set; }

        [DisplayName("توضیحات")]
        public String Description { get; set; }

        [DisplayName("فایل")]
        public string File { get; set; }

        [DisplayName("نوع مرحله")]
        public string Step{ get; set; }

        [DisplayName("تخلف")]
        public int? ViolationId { get; set; }
        public virtual AllowedViolations AllowedViolation { get; set; }

        [DisplayName("نوع تخلف")]
        public string InfractionType { get; set; }
    }
}