using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("legalCase_Status")]
    public class legalCase_Status
    {
        [Key]
        [Required]
        public virtual int status_id { get; set; }
        public virtual int? seq { get; set; }
        [MaxLength(50)]
        public virtual string status { get; set; }
        public virtual bool? is_active { get; set; }
    }
}
