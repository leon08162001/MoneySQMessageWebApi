using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("refinanceApplicationLog")]
    public class refinanceApplicationLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual decimal pk { get; set; }
        public virtual decimal? refinance_pk { get; set; }
        [MaxLength(50)]
        public virtual string request_amt { get; set; }
        [MaxLength(10)]
        public virtual string require_redem { get; set; }
        [MaxLength(50)]
        public virtual string require_redem_item { get; set; }
        [MaxLength(50)]
        public virtual string net_amt { get; set; }
        [MaxLength(100)]
        public virtual string os_item { get; set; }
        [MaxLength(100)]
        public virtual string os_item_amt { get; set; }
        [MaxLength(100)]
        public virtual string remarks_refinance { get; set; }
        [MaxLength(10)]
        public virtual string last_upd_user { get; set; }
        public virtual DateTime? log_date { get; set; }
    }
}
