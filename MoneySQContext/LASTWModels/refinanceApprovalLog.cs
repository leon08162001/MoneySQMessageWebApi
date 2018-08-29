using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("refinanceApprovalLog")]
    public class refinanceApprovalLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual decimal pk { get; set; }
        public virtual decimal? refinance_pk { get; set; }
        [MaxLength(20)]
        public virtual string loan_no { get; set; }
        [MaxLength(10)]
        public virtual string status { get; set; }
        [MaxLength(30)]
        public virtual string refinance_amt { get; set; }
        [MaxLength(20)]
        public virtual string redeem { get; set; }
        [MaxLength(50)]
        public virtual string redeem_item { get; set; }
        [MaxLength(50)]
        public virtual string interest_flag { get; set; }
        [MaxLength(30)]
        public virtual string interest { get; set; }
        [MaxLength(50)]
        public virtual string valuation_amt { get; set; }
        public virtual DateTime? valuation_date { get; set; }
        [MaxLength(20)]
        public virtual string valuation_staff { get; set; }
        [MaxLength(50)]
        public virtual string new_credit_limit_flag { get; set; }
        [MaxLength(50)]
        public virtual string new_credit_limit_amt { get; set; }
        [MaxLength(500)]
        public virtual string remarks { get; set; }
        [MaxLength(50)]
        public virtual string approved_by { get; set; }
        [MaxLength(50)]
        public virtual string risk_level { get; set; }
        [MaxLength(20)]
        public virtual string last_upd_user { get; set; }
        public virtual DateTime? log_date { get; set; }
    }
}
