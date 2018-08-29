using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("approvalLog")]
    public class approvalLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual decimal logID { get; set; }
        [MaxLength(50)]
        public virtual string order_nbr { get; set; }
        public virtual int? status { get; set; }
        [MaxLength(50)]
        public virtual string last_upd_user { get; set; }
        public virtual DateTime? last_upd_date { get; set; }
    }
}
