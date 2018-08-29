using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("loanApplication_addressValuation")]
    public class loanApplication_addressValuation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual int pk { get; set; }
        public virtual int? addr_pk { get; set; }
        [MaxLength(20)]
        public virtual string company { get; set; }
        [MaxLength(20)]
        public virtual string estAmtSqr { get; set; }
        [MaxLength(20)]
        public virtual string contact { get; set; }
    }
}
