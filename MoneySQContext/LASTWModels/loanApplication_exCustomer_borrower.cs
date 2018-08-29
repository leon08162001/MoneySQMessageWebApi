using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("loanApplication_exCustomer_borrower")]
    public class loanApplication_exCustomer_borrower
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual int pk { get; set; }
        [MaxLength(20)]
        public virtual string refno { get; set; }
        [MaxLength(30)]
        public virtual string borrower { get; set; }
        [MaxLength(2)]
        public virtual string priority { get; set; }
        [MaxLength(20)]
        public virtual string tel { get; set; }
        [MaxLength(30)]
        public virtual string id_num { get; set; }
    }
}
