using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("loanApplicationPassStevenLog")]
    public class loanApplicationPassStevenLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual decimal pk { get; set; }
        [MaxLength(20)]
        public virtual string user_id { get; set; }
        public virtual bool? is_check { get; set; }
        public virtual DateTime? lst_upd_date { get; set; }
    }
}
