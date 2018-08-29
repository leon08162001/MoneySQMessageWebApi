using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("loanApplication_PropertyType")]
    public class loanApplication_PropertyType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual int pk { get; set; }
        public virtual int? seq { get; set; }
        [MaxLength(50)]
        public virtual string propertyType { get; set; }
    }
}
