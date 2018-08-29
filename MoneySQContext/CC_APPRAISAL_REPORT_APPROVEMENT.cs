using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("CC_APPRAISAL_REPORT_APPROVEMENT")]
    public class CC_APPRAISAL_REPORT_APPROVEMENT
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(20)]
        public virtual string appraisal_report_no { get; set; }
        [Key]
        [Column(Order = 3)]
        [MaxLength(50)]
        public virtual string approval_no { get; set; }
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
        public UA_APPROVEMENT_CONTROL_RECORD UaApprovementControlRecord { get; set; }
        public CC_APPRAISAL_REPORT CcAppraisalReport1 { get; set; }
        public UA_APPROVEMENT_CONTROL_RECORD UaApprovementControlRecord1 { get; set; }
    }
}
