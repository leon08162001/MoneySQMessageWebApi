using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("CC_APPRAISAL_BUILDING_CONTENT")]
    public class CC_APPRAISAL_BUILDING_CONTENT
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(40)]
        public virtual string building_number { get; set; }
        [Key]
        [Column(Order = 3)]
        [MaxLength(20)]
        public virtual string appraisal_report_no { get; set; }
        [Key]
        [Column(Order = 4)]
        [MaxLength(3)]
        public virtual string appraisal_item { get; set; }
        [MaxLength(3)]
        public virtual string currency_type { get; set; }
        public virtual decimal? sqmeter_unit_price { get; set; }
        public virtual decimal? ping_unit_price { get; set; }
        public virtual decimal? total_price { get; set; }
        public virtual decimal? depreciation_ratio { get; set; }
        public virtual decimal? appreciation_rate { get; set; }
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

        public CC_APPRAISAL_BUILDING CcAppraisalBuilding { get; set; }
        public CC_APPRAISAL_BUILDING CcAppraisalBuilding1 { get; set; }
        public CC_APPRAISAL_BUILDING CcAppraisalBuilding2 { get; set; }
    }
}
