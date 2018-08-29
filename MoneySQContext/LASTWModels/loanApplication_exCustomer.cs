using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("loanApplication_exCustomer")]
    public class loanApplication_exCustomer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual int order_nbr { get; set; }
        [Required]
        public virtual int status { get; set; }
        [MaxLength(20)]
        public virtual string refno { get; set; }
        public virtual DateTime? redem_date { get; set; }
        [MaxLength(20)]
        public virtual string redem_reason { get; set; }
        [MaxLength(10)]
        public virtual string loan_amt { get; set; }
        [MaxLength(10)]
        public virtual string interest { get; set; }
        [MaxLength(20)]
        public virtual string replier { get; set; }
        public virtual DateTime? reply_date { get; set; }
        [MaxLength(10)]
        public virtual string intention_level { get; set; }
        [MaxLength(100)]
        public virtual string remarks { get; set; }
    }
}
