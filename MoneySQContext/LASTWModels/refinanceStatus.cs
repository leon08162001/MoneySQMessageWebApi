using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("refinanceStatus")]
    public class refinanceStatus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual decimal status_id { get; set; }
        [MaxLength(30)]
        public virtual string status { get; set; }
        [MaxLength(10)]
        public virtual string dept { get; set; }
    }
}
