using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("refinanceReplyHistory")]
    public class refinanceReplyHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual decimal history_id { get; set; }
        public virtual decimal? refinance_pk { get; set; }
        [MaxLength(20)]
        public virtual string loan_no { get; set; }
        [MaxLength(20)]
        public virtual string user_id { get; set; }
        public virtual bool? is_lms { get; set; }
        public virtual DateTime? reply_date { get; set; }
        [MaxLength(500)]
        public virtual string reply_history { get; set; }
    }
}
