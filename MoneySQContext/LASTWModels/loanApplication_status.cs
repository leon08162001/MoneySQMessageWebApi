using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("loanApplication_status")]
    public class loanApplication_status
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual int status_id { get; set; }
        [MaxLength(30)]
        public virtual string status { get; set; }
    }
}
