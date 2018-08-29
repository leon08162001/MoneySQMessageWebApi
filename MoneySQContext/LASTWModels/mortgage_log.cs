using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("mortgage_log")]
    public class mortgage_log
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual decimal pk { get; set; }
        [MaxLength(8)]
        [Required]
        public virtual string order_nbr { get; set; }
        [MaxLength(3)]
        [Required]
        public virtual string country { get; set; }
        public virtual int? status { get; set; }
        public virtual DateTime? log_date { get; set; }
        [MaxLength(5)]
        public virtual string address_type { get; set; }
        [MaxLength(5)]
        public virtual string loan_type { get; set; }
        [MaxLength(100)]
        public virtual string first_mort_amt { get; set; }
        [MaxLength(30)]
        public virtual string first_mort_rate { get; set; }
        [MaxLength(30)]
        public virtual string first_mort_pastDue { get; set; }
        [MaxLength(30)]
        public virtual string first_mort_loPosCr { get; set; }
        [MaxLength(30)]
        public virtual string first_mort_loRate { get; set; }
        [MaxLength(5)]
        public virtual string loan_type1 { get; set; }
        [MaxLength(100)]
        public virtual string sec_mort_amt { get; set; }
        [MaxLength(30)]
        public virtual string sec_mort_rate { get; set; }
        [MaxLength(30)]
        public virtual string sec_mort_pastDue { get; set; }
        [MaxLength(30)]
        public virtual string sec_mort_loPosCr { get; set; }
        [MaxLength(30)]
        public virtual string sec_mort_loRate { get; set; }
        [MaxLength(30)]
        public virtual string estAmt { get; set; }
        public virtual DateTime? estAmtDate { get; set; }
        [MaxLength(30)]
        public virtual string intEstAmt { get; set; }
        public virtual DateTime? intEstAmtDate { get; set; }
        [MaxLength(20)]
        public virtual string intEstAmtStaff { get; set; }
        [MaxLength(30)]
        public virtual string creditLimit { get; set; }
        [MaxLength(500)]
        public virtual string mortRemarks { get; set; }
        [MaxLength(1)]
        public virtual string risk_level { get; set; }
        [MaxLength(10)]
        public virtual string approver { get; set; }
    }
}
