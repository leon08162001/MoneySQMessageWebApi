using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("UserActivityLog")]
    public class UserActivityLog
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(20)]
        [Required]
        public virtual string user_id { get; set; }
        [MaxLength(6)]
        public virtual string act_type { get; set; }
        [Key]
        [Column(Order = 2)]
        [Required]
        public virtual DateTime act_datetime { get; set; }
    }
}
