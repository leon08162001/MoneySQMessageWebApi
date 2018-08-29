using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("CB_CREDIT_RISK_RANK")]
    public class CB_CREDIT_RISK_RANK
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(3)]
        public virtual string risk_rank_version { get; set; }
        [Key]
        [Column(Order = 3)]
        public virtual short risk_rank_code { get; set; }
        [MaxLength(3)]
        public virtual string risk_rank { get; set; }
        public virtual short credit_score_start { get; set; }
        public virtual short credit_score_end { get; set; }
        public virtual short unsecured_bebt_ratio { get; set; }
        public virtual short total_bebt_ratio { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public CB_CREDIT_RISK_RANK_VSESION CbCreditRiskRankVsesion { get; set; }
        public CB_CREDIT_RISK_RANK_VSESION CbCreditRiskRankVsesion1 { get; set; }
    }
}
