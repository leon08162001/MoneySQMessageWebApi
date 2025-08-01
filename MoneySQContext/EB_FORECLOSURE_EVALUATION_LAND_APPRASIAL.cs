using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("EB_FORECLOSURE_EVALUATION_LAND_APPRASIAL")]
    public class EB_FORECLOSURE_EVALUATION_LAND_APPRASIAL
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string foreclosure_evaluation_no { get; set; }
        [Key]
        [Column(Order = 3)]
        [MaxLength(40)]
        public virtual string land_lot { get; set; }
        [MaxLength(20)]
        public virtual string appraisal_report_no { get; set; }
        public virtual decimal area_of_land_sqmeter { get; set; }
        public virtual decimal area_of_land_ping { get; set; }
        [MaxLength(3)]
        public virtual string currency_type { get; set; }
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

        public CC_APPRAISAL_LAND CcAppraisalLand { get; set; }
        public EB_FORECLOSURE_EVALUATION EbForeclosureEvaluation { get; set; }
        public EB_FORECLOSURE_EVALUATION EbForeclosureEvaluation1 { get; set; }
        public CC_APPRAISAL_LAND CcAppraisalLand1 { get; set; }
        public CC_APPRAISAL_LAND CcAppraisalLand2 { get; set; }
    }
}
