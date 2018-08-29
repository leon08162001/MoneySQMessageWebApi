using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("loanApplication_exCustomer_status")]
    public class loanApplication_exCustomer_status
    {
        [Key]
        [Required]
        public virtual int status_id { get; set; }
        [MaxLength(30)]
        public virtual string status { get; set; }
    }
}
