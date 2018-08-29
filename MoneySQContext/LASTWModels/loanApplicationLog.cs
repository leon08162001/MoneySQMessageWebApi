using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("loanApplicationLog")]
    public class loanApplicationLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual decimal pk { get; set; }
        [MaxLength(8)]
        public virtual string order_nbr { get; set; }
        [MaxLength(3)]
        [Required]
        public virtual string country { get; set; }
        [MaxLength(50)]
        public virtual string loan_amt { get; set; }
        [MaxLength(30)]
        public virtual string req_loanRevDate { get; set; }
        [MaxLength(50)]
        public virtual string loan_purpose { get; set; }
        [MaxLength(300)]
        public virtual string remarks { get; set; }
        [MaxLength(10)]
        public virtual string intention_level { get; set; }
        [MaxLength(20)]
        public virtual string modified_by { get; set; }
        public virtual DateTime? modified_date { get; set; }
    }
}
