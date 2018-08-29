using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("SystemMessage")]
    public class SystemMessage
    {
        [Key]
        [MaxLength(10)]
        [Required]
        public virtual string msg_id { get; set; }
        [MaxLength(500)]
        public virtual string message { get; set; }
    }
}
