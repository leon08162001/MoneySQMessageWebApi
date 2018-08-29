using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("systemConfiguration_log")]
    public class systemConfiguration_log
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual int pk { get; set; }
        [MaxLength(100)]
        public virtual string system_key { get; set; }
        [MaxLength(100)]
        public virtual string old_value { get; set; }
        [MaxLength(100)]
        public virtual string new_value { get; set; }
        public virtual DateTime? lst_upd_date { get; set; }
    }
}
