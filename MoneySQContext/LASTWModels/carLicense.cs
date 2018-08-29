using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("carLicense")]
    public class carLicense
    {
        [Key]
        [MaxLength(50)]
        [Required]
        public virtual string licensePlate { get; set; }
    }
}
