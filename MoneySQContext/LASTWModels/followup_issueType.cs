using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("followup_issueType")]
    public class followup_issueType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual decimal pk { get; set; }
        [MaxLength(20)]
        public virtual string issue_type { get; set; }
        [MaxLength(10)]
        public virtual string issue_code { get; set; }
        [MaxLength(50)]
        public virtual string issue_desc { get; set; }
    }
}
