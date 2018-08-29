using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("followup_issuesItem")]
    public class followup_issuesItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual decimal pk { get; set; }
        public virtual decimal? loan_pk { get; set; }
        public virtual int? status_id { get; set; }
        public virtual bool? is_Overdue { get; set; }
        [MaxLength(10)]
        public virtual string issue_code { get; set; }
        [MaxLength(20)]
        public virtual string cusName { get; set; }
        [MaxLength(100)]
        public virtual string bank { get; set; }
        [MaxLength(50)]
        public virtual string details { get; set; }
        [MaxLength(20)]
        public virtual string amt { get; set; }
        public virtual DateTime? deadline { get; set; }
    }
}
