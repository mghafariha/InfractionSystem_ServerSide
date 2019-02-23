using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Violations.Models
{
    public class Plain
    {
        public int ID { get; set; }

        [DisplayName("نام")]
        [Required]
        public string Title { get; set; }

       
        [DisplayName("محدوده مطالعاتی")]
        [Required]
        public int AreaStudy { get; set; }

        [DisplayName("وضعیت بهره برداری")]
        [Required]
        public string Status { get; set; }
    }
}