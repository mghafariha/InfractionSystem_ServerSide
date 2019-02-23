using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Violations.Models
{
    public class AllowedViolations
    {

        public int ID { get; set; }

        [DisplayName("اندکس")]
        public String Index { get; set; }

        //[DisplayName("محدوده مطالعاتی")]
        //public int? StudyAreaId { get; set; }
        //public virtual AreaStudy StudyArea { get; set; }

        [DisplayName("دشت")]
        public int? PlainId { get; set; }
        public virtual Plain Plain { get; set; }
        [DisplayName("نام و نام خانوادگی مالک")]
        public String OwnerName { get; set; }

        //[DisplayName("شهرستان")]
        //public int? CityId { get; set; }
        //public virtual City City { get; set; }

        [DisplayName("روستا")]
        public String Village { get; set; }

        [DisplayName("شماره اشتراک")]
        public String Subscribe { get; set; }

        [DisplayName("شماره پروانه بهره برداری/حفر/مجوزصادر")]
        public String LicenseNumber { get; set; }

        [DisplayName("تاریخ پروانه بهره برداری/حفر/مجوزصادره")]
        public DateTime? LicenseDate { get; set; }

        [DisplayName("طول جغرافیایی")]
        public Decimal Longitude { get; set; }

        [DisplayName("عرض جغرافیایی")]
        public Decimal Latitude { get; set; }

        [DisplayName("قطر لوله آبده قبلی")]
        public Decimal Pipe { get; set; }

        [DisplayName("قدرت موتورقبلی")]
        public Decimal EnginePower { get; set; }

        [DisplayName("نوع مجوز")]
        public String TypeLicense { get; set; }

        [DisplayName("سطح زیر کشت")]
        public Decimal Cultivated { get; set; }

        [DisplayName("نوع کشت")]
        public String CultivateType { get; set; }

        [DisplayName("صنعت و خدمات")]
        public String Industry { get; set; }

        [DisplayName("شرب")]
        public String Drinking { get; set; }

        [DisplayName("آبدهی مجاز (لیتر بر ثانیه)")]
        public Decimal DebiMojaz { get; set; }

        [DisplayName("ساعت كاركرد")]
        public Decimal WorkHours { get; set; }

        [DisplayName("نو ع منصوبات مجاز")]
        public String ArtifactsType { get; set; }
        [DisplayName("عمق چاه")]

        public Decimal WellDepth { get; set; }
        [DisplayName("روش حفر")]
        public String DugMethod { get; set; }

        [DisplayName("نوع چاه ")]
        public String TypeWell { get; set; }

        [DisplayName("حجم برداشت مجاز  سالانه(هزارمترمکعب)")]
        public Decimal Volume { get; set; }

        [DisplayName("توضیحات")]
        public String Description { get; set; }

        [DisplayName("سطح زیر کشت غیر مجاز")]
        public Decimal CultivatedFalse { get; set; }

        [DisplayName("نوع کشت غیر مجاز")]
        public String CultivateTypeFalse { get; set; }

        [DisplayName("نوع مصرف  غیر مجاز ")]
        public String UseFalse { get; set; }

        [DisplayName("آبدهي فعلي(لیتردرثانیه) ")]
        public Decimal DebiPresent { get; set; }

        [DisplayName("حجم برداشت فعلي(هزارمتر مکعب)")]
        public Decimal VolumePresent { get; set; }

        [DisplayName("تغییر نوع مصرف ")]
        public String ChangeUse { get; set; }

        [DisplayName("ریز مصرف")]
        public String UseTiny { get; set; }

        [DisplayName("حجم اضافه برداشت")]
        public Decimal Overdrawn { get; set; }

        [DisplayName("نوع کنتور ")]
        public String TypeMeter { get; set; }

        [DisplayName("نام شرکت سازنده يا پيمانکار")]
        public String MeterCompany { get; set; }

        [DisplayName("تاريخ نصب")]
        public DateTime? DateInstallation { get; set; }

        [DisplayName("شارژ")]
        public String ChargeMeter { get; set; }

        [DisplayName("قرائت")]
        public Decimal NumberMeter { get; set; }

        [DisplayName("محل تهیه کنتور")]
        public String PlaceMeter { get; set; }

        [DisplayName("اضافه برداشت قبلي(هزار متر مکعب در سال)")]
        public Decimal OverdrawnPrv { get; set; }

        [DisplayName("صرفه جويي با نصب کنتور (هزار متر مکعب در سال)")]
        public Decimal Saving { get; set; }

        [DisplayName("پلمپ کنتور")]
        public String PlumbMeter { get; set; }

        [DisplayName("قطر لوله آبده جدید")]
        public Decimal PipeNew { get; set; }

        [DisplayName("قدرت موتور جدید")]
        public Decimal EnginePowerNew { get; set; }

        [DisplayName("مقادير حجم آب صرفه جویی شده")]
        public Decimal VolumeSaving { get; set; }

        [DisplayName("طول خط انتقال آب")]
        public Decimal TransferLine { get; set; }

        [DisplayName("میزان کف شکنی/عمق فعلی")]
        public Decimal FloorBreaker { get; set; }

        [DisplayName("آب فروشی ")]
        public Decimal WaterSupply { get; set; }

        [DisplayName("کاربری غیر مجاز")]
        public String UserFalse { get; set; }

        [DisplayName("تاریخ اتمام مدت پروانه بهره برداری ")]
        public DateTime? EndDate { get; set; }

        [DisplayName("طول جغرافیایی تخلف ")]
        public Decimal LongitudeViolation { get; set; }

        [DisplayName("عرض جغرافیایی تخلف")]
        public Decimal LatitudeViolation { get; set; }

        [DisplayName("حجم برداشت از چاه ")]
        public Decimal VolumOfWell { get; set; }


        [DisplayName("حجم پساب ")]
        public Decimal WasteWater { get; set; }


        [DisplayName("حجم آب تصفیه شده")]
        public Decimal VolumeFiltration { get; set; }

        [DisplayName("نوع تخلف")]
        public String InfractionType { get; set; }

        [DisplayName("وضعیت")]
        public String Status{ get; set; }
    }

    public class AllowedViolationsViewModel
    {

        public int ID { get; set; }

        [DisplayName("اندکس")]
        public String Index { get; set; }

        [DisplayName("محدوده مطالعاتی")]
        public int? StudyAreaId { get; set; }
        public string StudyArea { get; set; }

        [DisplayName("دشت")]
        public int? PlainId { get; set; }
        public string  Plain { get; set; }

        [DisplayName("نام و نام خانوادگی مالک")]
        public String OwnerName { get; set; }

        [DisplayName("شهرستان")]
        public int? CityId { get; set; }
        public string City { get; set; }

        [DisplayName("روستا")]
        public String Village { get; set; }

        [DisplayName("شماره اشتراک")]
        public String Subscribe { get; set; }

        [DisplayName("شماره پروانه بهره برداری/حفر/مجوزصادر")]
        public String LicenseNumber { get; set; }

        [DisplayName("تاریخ پروانه بهره برداری/حفر/مجوزصادره")]
        public DateTime? LicenseDate { get; set; }

        [DisplayName("طول جغرافیایی")]
        public Decimal Longitude { get; set; }

        [DisplayName("عرض جغرافیایی")]
        public Decimal Latitude { get; set; }

        [DisplayName("قطر لوله آبده قبلی")]
        public Decimal Pipe { get; set; }

        [DisplayName("قدرت موتورقبلی")]
        public Decimal EnginePower { get; set; }

        [DisplayName("نوع مجوز")]
        public String TypeLicense { get; set; }

        [DisplayName("سطح زیر کشت")]
        public Decimal Cultivated { get; set; }

        [DisplayName("نوع کشت")]
        public String CultivateType { get; set; }

        [DisplayName("صنعت و خدمات")]
        public String Industry { get; set; }

        [DisplayName("شرب")]
        public String Drinking { get; set; }

        [DisplayName("آبدهی مجاز (لیتر بر ثانیه)")]
        public Decimal DebiMojaz { get; set; }

        [DisplayName("ساعت كاركرد")]
        public Decimal WorkHours { get; set; }

        [DisplayName("نو ع منصوبات مجاز")]
        public String ArtifactsType { get; set; }
        [DisplayName("عمق چاه")]

        public Decimal WellDepth { get; set; }
        [DisplayName("روش حفر")]
        public String DugMethod { get; set; }

        [DisplayName("نوع چاه ")]
        public String TypeWell { get; set; }

        [DisplayName("حجم برداشت مجاز  سالانه(هزارمترمکعب)")]
        public Decimal Volume { get; set; }

        [DisplayName("توضیحات")]
        public String Description { get; set; }

        [DisplayName("سطح زیر کشت غیر مجاز")]
        public Decimal CultivatedFalse { get; set; }

        [DisplayName("نوع کشت غیر مجاز")]
        public String CultivateTypeFalse { get; set; }

        [DisplayName("نوع مصرف  غیر مجاز ")]
        public String UseFalse { get; set; }

        [DisplayName("آبدهي فعلي(لیتردرثانیه) ")]
        public Decimal DebiPresent { get; set; }

        [DisplayName("حجم برداشت فعلي(هزارمتر مکعب)")]
        public Decimal VolumePresent { get; set; }

        [DisplayName("تغییر نوع مصرف ")]
        public String ChangeUse { get; set; }

        [DisplayName("ریز مصرف")]
        public String UseTiny { get; set; }

        [DisplayName("حجم اضافه برداشت")]
        public Decimal Overdrawn { get; set; }

        [DisplayName("نوع کنتور ")]
        public String TypeMeter { get; set; }

        [DisplayName("نام شرکت سازنده يا پيمانکار")]
        public String MeterCompany { get; set; }

        [DisplayName("تاريخ نصب")]
        public DateTime? DateInstallation { get; set; }

        [DisplayName("شارژ")]
        public String ChargeMeter { get; set; }

        [DisplayName("قرائت")]
        public Decimal NumberMeter { get; set; }

        [DisplayName("محل تهیه کنتور")]
        public String PlaceMeter { get; set; }

        [DisplayName("اضافه برداشت قبلي(هزار متر مکعب در سال)")]
        public Decimal OverdrawnPrv { get; set; }

        [DisplayName("صرفه جويي با نصب کنتور (هزار متر مکعب در سال)")]
        public Decimal Saving { get; set; }

        [DisplayName("پلمپ کنتور")]
        public String PlumbMeter { get; set; }

        [DisplayName("قطر لوله آبده جدید")]
        public Decimal PipeNew { get; set; }

        [DisplayName("قدرت موتور جدید")]
        public Decimal EnginePowerNew { get; set; }

        [DisplayName("مقادير حجم آب صرفه جویی شده")]
        public Decimal VolumeSaving { get; set; }

        [DisplayName("طول خط انتقال آب")]
        public Decimal TransferLine { get; set; }

        [DisplayName("میزان کف شکنی/عمق فعلی")]
        public Decimal FloorBreaker { get; set; }

        [DisplayName("آب فروشی ")]
        public Decimal WaterSupply { get; set; }

        [DisplayName("کاربری غیر مجاز")]
        public String UserFalse { get; set; }

        [DisplayName("تاریخ اتمام مدت پروانه بهره برداری ")]
        public DateTime? EndDate { get; set; }

        [DisplayName("طول جغرافیایی تخلف ")]
        public Decimal LongitudeViolation { get; set; }

        [DisplayName("عرض جغرافیایی تخلف")]
        public Decimal LatitudeViolation { get; set; }

        [DisplayName("حجم برداشت از چاه ")]
        public Decimal VolumOfWell { get; set; }


        [DisplayName("حجم پساب ")]
        public Decimal WasteWater { get; set; }


        [DisplayName("حجم آب تصفیه شده")]
        public Decimal VolumeFiltration { get; set; }

        [DisplayName("نوع تخلف")]
        public String InfractionType { get; set; }

        [DisplayName("وضعیت")]
        public String Status { get; set; }
    }
}