using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("history")]
    public class history
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual decimal history_id { get; set; }
        [MaxLength(8)]
        public virtual string order_nbr { get; set; }
        [MaxLength(3)]
        [Required]
        public virtual string country { get; set; }
        [MaxLength(20)]
        public virtual string user_id { get; set; }
        public virtual DateTime? reply_date { get; set; }
        [MaxLength(500)]
        public virtual string reply_history { get; set; }
        public virtual bool? is_old { get; set; }
    }
}
