using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("refinanceRetentionReport")]
    public class refinanceRetentionReport
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual decimal pk { get; set; }
        public virtual decimal? refinance_pk { get; set; }
        [MaxLength(10)]
        public virtual string loan_id { get; set; }
        [MaxLength(2000)]
        public virtual string address { get; set; }
        [MaxLength(50)]
        public virtual string p_type { get; set; }
        [MaxLength(10)]
        public virtual string area_g { get; set; }
        [MaxLength(50)]
        public virtual string area_n { get; set; }
        [MaxLength(100)]
        public virtual string valuation { get; set; }
        [MaxLength(10)]
        public virtual string loan_date { get; set; }
        [MaxLength(50)]
        public virtual string transfer_to { get; set; }
        [MaxLength(50)]
        public virtual string interest { get; set; }
        [MaxLength(50)]
        public virtual string pmt { get; set; }
        [MaxLength(50)]
        public virtual string loan_type { get; set; }
        [MaxLength(10)]
        public virtual string terms { get; set; }
        public virtual DateTime? completed_date { get; set; }
        public virtual DateTime? created_date { get; set; }
    }
}
