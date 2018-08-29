using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("CC_APPRAISAL_LAND")]
    public class CC_APPRAISAL_LAND
    {
        public CC_APPRAISAL_LAND()
        {
            this.EbForeclosureEvaluationLandApprasials = new List<EB_FORECLOSURE_EVALUATION_LAND_APPRASIAL>();
            this.EbSealUpApplicationLandApprasials = new List<EB_SEAL_UP_APPLICATION_LAND_APPRASIAL>();
            this.ShippedBy = new List<ZZ_LAND_OWNERSHIP_CERTIFICATE_APPRASIAL>();
            this.EbForeclosureEvaluationLandApprasials1 = new List<EB_FORECLOSURE_EVALUATION_LAND_APPRASIAL>();
            this.EbSealUpApplicationLandApprasials1 = new List<EB_SEAL_UP_APPLICATION_LAND_APPRASIAL>();
            this.ShippedBy1 = new List<ZZ_LAND_OWNERSHIP_CERTIFICATE_APPRASIAL>();
            this.EbForeclosureEvaluationLandApprasials2 = new List<EB_FORECLOSURE_EVALUATION_LAND_APPRASIAL>();
            this.EbSealUpApplicationLandApprasials2 = new List<EB_SEAL_UP_APPLICATION_LAND_APPRASIAL>();
            this.ShippedBy2 = new List<ZZ_LAND_OWNERSHIP_CERTIFICATE_APPRASIAL>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(40)]
        public virtual string land_lot { get; set; }
        [Key]
        [Column(Order = 3)]
        [MaxLength(20)]
        public virtual string appraisal_report_no { get; set; }
        [MaxLength(3)]
        public virtual string currency_type { get; set; }
        public virtual decimal announced_current_value_sqmeter { get; set; }
        public virtual decimal? announced_current_value_ping { get; set; }
        public virtual decimal? apprasial_value_sqmeter { get; set; }
        public virtual decimal? apprasial_value_ping { get; set; }
        public virtual decimal? appraisal_price { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public CC_APPRAISAL_REPORT CcAppraisalReport { get; set; }
        public CC_APPRAISAL_REPORT CcAppraisalReport1 { get; set; }
        public List<EB_FORECLOSURE_EVALUATION_LAND_APPRASIAL> EbForeclosureEvaluationLandApprasials { get; set; }
        public List<EB_SEAL_UP_APPLICATION_LAND_APPRASIAL> EbSealUpApplicationLandApprasials { get; set; }
        public List<ZZ_LAND_OWNERSHIP_CERTIFICATE_APPRASIAL> ShippedBy { get; set; }
        public List<EB_FORECLOSURE_EVALUATION_LAND_APPRASIAL> EbForeclosureEvaluationLandApprasials1 { get; set; }
        public List<EB_SEAL_UP_APPLICATION_LAND_APPRASIAL> EbSealUpApplicationLandApprasials1 { get; set; }
        public List<ZZ_LAND_OWNERSHIP_CERTIFICATE_APPRASIAL> ShippedBy1 { get; set; }
        public List<EB_FORECLOSURE_EVALUATION_LAND_APPRASIAL> EbForeclosureEvaluationLandApprasials2 { get; set; }
        public List<EB_SEAL_UP_APPLICATION_LAND_APPRASIAL> EbSealUpApplicationLandApprasials2 { get; set; }
        public List<ZZ_LAND_OWNERSHIP_CERTIFICATE_APPRASIAL> ShippedBy2 { get; set; }
    }
}
