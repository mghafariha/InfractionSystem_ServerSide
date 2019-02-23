using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Violations.Models
{
    public class NotAllowedViolations
    {
        public int ID { get; set; }

        [DisplayName("شماره پرونده")]
        public String Index { get; set; }

        //[DisplayName("محدوده مطالعاتی")]
        //public int? StudyAreaId { get; set; }
        //public virtual AreaStudy StudyArea { get; set; }

        [DisplayName("دشت")]
        public int? PlainId { get; set; }
        public virtual Plain Plain { get; set; }

        [DisplayName("نام و نام خانوادگی متخلف")]
        public String OwnerName { get; set; }

        //[DisplayName("شهرستان")]
        //public int? CityId { get; set; }
        //public virtual City City { get; set; }


        [DisplayName("روستا")]
        public String Village { get; set; }


        [DisplayName("طول جغرافیایی")]
        public Decimal Longitude { get; set; }

        [DisplayName("عرض جغرافیایی")]
        public Decimal Latitude { get; set; }

        [DisplayName("تاریخ حفر")]
        public DateTime? DugDate { get; set; }

        [DisplayName("ساعت كاركرد")]
        public decimal WorkHours { get; set; }

        [DisplayName("نوع مصرف")]
        public string TypeUse { get; set; }

        [DisplayName("تاریخ شروع بهره برداری")]
        public DateTime? StartDateOperation { get; set; }

        [DisplayName("آبدهی لحظه ای چاه (لیتردرثانیه)")]
        public decimal DebiMoment { get; set; }

        [DisplayName("حجم آب صرفه جویی شده سالانه(هزارمتر مکعب)")]
        public decimal VolumeSaved { get; set; }

        [DisplayName("خسارت آبخوان")]
        public string AquiferDamage { get; set; }

        [DisplayName("توضیحات")]
        public string Description { get; set; }

        [DisplayName("شماره سریال پلمپ")]
        public string SerialPlumb { get; set; }

        [DisplayName("سال حفر چاه")]
        public string years { get; set; }

        [DisplayName("میزان مصرف آب فعلی")]
        public decimal UsePresent { get; set; }

        [DisplayName("عمق چاه")]
        public decimal WellDepthViolation { get; set; }

        [DisplayName("نوع چاه")]
        public string TypeWellViolation { get; set; }

        [DisplayName("وضعیت چاه")]
        public string WellPosition { get; set; }

        [DisplayName("نوع موتور")]
        public string EngineType { get; set; }

        [DisplayName("تاریخ پر و مسلوب المنفعه نمودن چاه")]
        public DateTime? DateFull { get; set; }

        [DisplayName("تخلیه سالانه (هزار متر مکعب)")]
        public decimal AnnualDischarge { get; set; }

        [DisplayName("سابقه انسداد")]
        public string HistoryBlocked { get; set; }

        [DisplayName("نوع تخلف")]
        public String InfractionType { get; set; }

        [DisplayName("وضعیت")]
        public String Status { get; set; }
    }

    public class NotAllowedViolationsViewModel
    {
        public int ID { get; set; }

        [DisplayName("شماره پرونده")]
        public String Index { get; set; }

        [DisplayName("محدوده مطالعاتی")]
        public int? StudyAreaId { get; set; }
        public string StudyArea { get; set; }

        [DisplayName("دشت")]
        public int? PlainId { get; set; }
        public virtual Plain Plain { get; set; }

        [DisplayName("نام و نام خانوادگی متخلف")]
        public String OwnerName { get; set; }

        [DisplayName("شهرستان")]
        public int? CityId { get; set; }
        public string City { get; set; }


        [DisplayName("روستا")]
        public String Village { get; set; }


        [DisplayName("طول جغرافیایی")]
        public Decimal Longitude { get; set; }

        [DisplayName("عرض جغرافیایی")]
        public Decimal Latitude { get; set; }

        [DisplayName("تاریخ حفر")]
        public DateTime? DugDate { get; set; }

        [DisplayName("ساعت كاركرد")]
        public decimal WorkHours { get; set; }

        [DisplayName("نوع مصرف")]
        public string TypeUse { get; set; }

        [DisplayName("تاریخ شروع بهره برداری")]
        public DateTime? StartDateOperation { get; set; }

        [DisplayName("آبدهی لحظه ای چاه (لیتردرثانیه)")]
        public decimal DebiMoment { get; set; }

        [DisplayName("حجم آب صرفه جویی شده سالانه(هزارمتر مکعب)")]
        public decimal VolumeSaved { get; set; }

        [DisplayName("خسارت آبخوان")]
        public string AquiferDamage { get; set; }

        [DisplayName("توضیحات")]
        public string Description { get; set; }

        [DisplayName("شماره سریال پلمپ")]
        public string SerialPlumb { get; set; }

        [DisplayName("سال حفر چاه")]
        public string years { get; set; }

        [DisplayName("میزان مصرف آب فعلی")]
        public decimal UsePresent { get; set; }

        [DisplayName("عمق چاه")]
        public decimal WellDepthViolation { get; set; }

        [DisplayName("نوع چاه")]
        public string TypeWellViolation { get; set; }

        [DisplayName("وضعیت چاه")]
        public string WellPosition { get; set; }

        [DisplayName("نوع موتور")]
        public string EngineType { get; set; }

        [DisplayName("تاریخ پر و مسلوب المنفعه نمودن چاه")]
        public DateTime? DateFull { get; set; }

        [DisplayName("تخلیه سالانه (هزار متر مکعب)")]
        public decimal AnnualDischarge { get; set; }

        [DisplayName("سابقه انسداد")]
        public string HistoryBlocked { get; set; }

        [DisplayName("نوع تخلف")]
        public String InfractionType { get; set; }

        [DisplayName("وضعیت")]
        public String Status { get; set; }
    }
}