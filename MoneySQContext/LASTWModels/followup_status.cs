using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("followup_status")]
    public class followup_status
    {
        [Key]
        [Required]
        public virtual int status_id { get; set; }
        public virtual int? seq { get; set; }
        [MaxLength(20)]
        public virtual string status { get; set; }
    }
}
