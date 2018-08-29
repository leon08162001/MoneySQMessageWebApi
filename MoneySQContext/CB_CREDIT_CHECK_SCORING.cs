using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("CB_CREDIT_CHECK_SCORING")]
    public class CB_CREDIT_CHECK_SCORING
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string application_no { get; set; }
        [Key]
        [Column(Order = 3)]
        [MaxLength(20)]
        public virtual string credit_check_reprot_no { get; set; }
        [Key]
        [Column(Order = 4)]
        [MaxLength(3)]
        public virtual string scoring_item { get; set; }
        [MaxLength(255)]
        public virtual string scoring_content { get; set; }
        public virtual short score { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public CB_CREDIT_CHECK_REPROT CbCreditCheckReprot { get; set; }
        public CB_CREDIT_CHECK_REPROT CbCreditCheckReprot1 { get; set; }
        public CB_CREDIT_CHECK_REPROT CbCreditCheckReprot2 { get; set; }
    }
}
