using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("loanApplicationPayableTo")]
    public class loanApplicationPayableTo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual int pk { get; set; }
        [MaxLength(8)]
        public virtual string order_nbr { get; set; }
        [MaxLength(3)]
        [Required]
        public virtual string country { get; set; }
        [MaxLength(40)]
        public virtual string payable_to { get; set; }
        public virtual decimal? payable_to_amt { get; set; }
    }
}
