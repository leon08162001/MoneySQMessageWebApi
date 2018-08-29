using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("CB_CREDIT_RISK_RANK_VSESION")]
    public class CB_CREDIT_RISK_RANK_VSESION
    {
        public CB_CREDIT_RISK_RANK_VSESION()
        {
            this.CbCreditRiskRanks = new List<CB_CREDIT_RISK_RANK>();
            this.CbCreditRiskRanks1 = new List<CB_CREDIT_RISK_RANK>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(3)]
        public virtual string risk_rank_version { get; set; }
        [MaxLength(1000)]
        public virtual string risk_rank_version_description { get; set; }
        public virtual DateTime enable_date { get; set; }
        public virtual DateTime? disable_date { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public JA_COMPANY JaCompany { get; set; }
        public List<CB_CREDIT_RISK_RANK> CbCreditRiskRanks { get; set; }
        public List<CB_CREDIT_RISK_RANK> CbCreditRiskRanks1 { get; set; }
    }
}
