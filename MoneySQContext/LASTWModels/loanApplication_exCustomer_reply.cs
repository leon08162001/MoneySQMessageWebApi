using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("loanApplication_exCustomer_reply")]
    public class loanApplication_exCustomer_reply
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual int pk { get; set; }
        [MaxLength(8)]
        [Required]
        public virtual string order_nbr { get; set; }
        [MaxLength(20)]
        public virtual string user_id { get; set; }
        public virtual DateTime? reply_date { get; set; }
        [MaxLength(500)]
        public virtual string reply_history { get; set; }
    }
}
