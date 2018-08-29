using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("refinancePayableTo")]
    public class refinancePayableTo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual decimal pk { get; set; }
        public virtual decimal? refinance_pk { get; set; }
        [MaxLength(20)]
        public virtual string loan_no { get; set; }
        [MaxLength(40)]
        public virtual string payable_to { get; set; }
        public virtual decimal? payable_to_amt { get; set; }
        public virtual bool? is_crossChq { get; set; }
        public virtual bool? is_cashChq { get; set; }
    }
}
