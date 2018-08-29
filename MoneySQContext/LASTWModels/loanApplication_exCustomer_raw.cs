using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("loanApplication_exCustomer_raw")]
    public class loanApplication_exCustomer_raw
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual int pk { get; set; }
        [MaxLength(20)]
        public virtual string refno { get; set; }
        [MaxLength(10)]
        public virtual string loan_amt { get; set; }
        [MaxLength(5)]
        public virtual string interest { get; set; }
        [MaxLength(30)]
        public virtual string tel { get; set; }
        [MaxLength(500)]
        public virtual string address { get; set; }
        [MaxLength(2)]
        public virtual string priority { get; set; }
        [MaxLength(50)]
        public virtual string borrower { get; set; }
        [MaxLength(30)]
        public virtual string id_num { get; set; }
        public virtual DateTime? redemption_date { get; set; }
        [MaxLength(20)]
        public virtual string redemption_reason { get; set; }
    }
}
