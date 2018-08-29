using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("addressLog")]
    public class addressLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual decimal logID { get; set; }
        [MaxLength(8)]
        public virtual string order_nbr { get; set; }
        [MaxLength(3)]
        [Required]
        public virtual string country { get; set; }
        [MaxLength(5)]
        public virtual string address_type { get; set; }
        [MaxLength(10)]
        public virtual string property_type { get; set; }
        [MaxLength(120)]
        public virtual string address { get; set; }
        [MaxLength(20)]
        public virtual string others { get; set; }
        public virtual bool? isRent { get; set; }
        [MaxLength(20)]
        public virtual string rentAmt { get; set; }
        [MaxLength(20)]
        public virtual string areaN { get; set; }
        [MaxLength(20)]
        public virtual string areaG { get; set; }
        [MaxLength(20)]
        public virtual string property_age { get; set; }
        [MaxLength(30)]
        public virtual string loan_outstanding { get; set; }
        [MaxLength(50)]
        public virtual string loan_bank { get; set; }
        public virtual DateTime? log_date { get; set; }
        [MaxLength(20)]
        public virtual string last_upd_user { get; set; }
    }
}
