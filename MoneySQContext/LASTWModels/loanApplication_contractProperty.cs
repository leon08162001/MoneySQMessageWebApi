using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("loanApplication_contractProperty")]
    public class loanApplication_contractProperty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual int pk { get; set; }
        [MaxLength(8)]
        public virtual string order_nbr { get; set; }
        [MaxLength(3)]
        [Required]
        public virtual string country { get; set; }
        [MaxLength(50)]
        public virtual string owner { get; set; }
        [MaxLength(50)]
        public virtual string propertyType { get; set; }
        [MaxLength(100)]
        public virtual string address { get; set; }
        [MaxLength(100)]
        public virtual string contractPropertyNum { get; set; }
        [MaxLength(5)]
        public virtual string contractPortion1 { get; set; }
        [MaxLength(5)]
        public virtual string contractPortion2 { get; set; }
        [MaxLength(20)]
        public virtual string property_area { get; set; }
        [MaxLength(255)]
        public virtual string property_remarks { get; set; }
        [MaxLength(20)]
        public virtual string contractPropertyCity { get; set; }
        [MaxLength(20)]
        public virtual string contractPropertyRegion { get; set; }
        [MaxLength(20)]
        public virtual string contractPropertySection { get; set; }
        [MaxLength(20)]
        public virtual string contractPropertySectionNum { get; set; }
        [MaxLength(20)]
        public virtual string contractPropertyOwner { get; set; }
    }
}
