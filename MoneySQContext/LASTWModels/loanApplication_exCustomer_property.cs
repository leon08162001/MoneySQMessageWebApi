using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("loanApplication_exCustomer_property")]
    public class loanApplication_exCustomer_property
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual int pk { get; set; }
        [MaxLength(20)]
        public virtual string refno { get; set; }
        [MaxLength(500)]
        public virtual string address { get; set; }
    }
}
