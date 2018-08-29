using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("loanApplication_address")]
    public class loanApplication_address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual decimal pk { get; set; }
        public virtual int? seq { get; set; }
        [MaxLength(10)]
        public virtual string order_nbr { get; set; }
        [MaxLength(3)]
        [Required]
        public virtual string country { get; set; }
        [MaxLength(10)]
        public virtual string property_type { get; set; }
        [MaxLength(10)]
        public virtual string add_1 { get; set; }
        [MaxLength(10)]
        public virtual string add_2 { get; set; }
        [MaxLength(10)]
        public virtual string add_3 { get; set; }
        [MaxLength(10)]
        public virtual string add_4 { get; set; }
        [MaxLength(10)]
        public virtual string add_5 { get; set; }
        [MaxLength(10)]
        public virtual string add_6 { get; set; }
        [MaxLength(10)]
        public virtual string add_7 { get; set; }
        [MaxLength(10)]
        public virtual string add_8 { get; set; }
        [MaxLength(10)]
        public virtual string add_9 { get; set; }
        [MaxLength(10)]
        public virtual string add_10 { get; set; }
        [MaxLength(100)]
        public virtual string address { get; set; }
        [MaxLength(20)]
        public virtual string others { get; set; }
        public virtual bool? isRent { get; set; }
        [MaxLength(20)]
        public virtual string rentAmt { get; set; }
        public virtual bool? isBindContract { get; set; }
        [MaxLength(20)]
        public virtual string bindContract { get; set; }
        [MaxLength(20)]
        public virtual string areaN { get; set; }
        [MaxLength(20)]
        public virtual string areaG { get; set; }
        [MaxLength(20)]
        public virtual string carPark { get; set; }
        [MaxLength(20)]
        public virtual string carParkAreaN { get; set; }
        [MaxLength(20)]
        public virtual string carParkAreaG { get; set; }
        [MaxLength(100)]
        public virtual string carParkRemarks { get; set; }
        [MaxLength(20)]
        public virtual string property_age { get; set; }
        [MaxLength(50)]
        public virtual string loan_bank { get; set; }
        [MaxLength(20)]
        public virtual string tax { get; set; }
        [MaxLength(50)]
        public virtual string loan_outstanding1 { get; set; }
        [MaxLength(20)]
        public virtual string loan_outstandingAmt1 { get; set; }
        [MaxLength(50)]
        public virtual string loan_outstanding2 { get; set; }
        [MaxLength(20)]
        public virtual string loan_outstandingAmt2 { get; set; }
        [MaxLength(50)]
        public virtual string loan_outstanding3 { get; set; }
        [MaxLength(20)]
        public virtual string loan_outstandingAmt3 { get; set; }
        [MaxLength(20)]
        public virtual string mortgage_item { get; set; }
        [MaxLength(20)]
        public virtual string mortgage_period { get; set; }
        [MaxLength(1)]
        [Required]
        public virtual string is_mortgage { get; set; }
        [MaxLength(20)]
        public virtual string redeem { get; set; }
        [MaxLength(5)]
        public virtual string loan_type1_add { get; set; }
        [MaxLength(200)]
        public virtual string first_mort_amt { get; set; }
        [MaxLength(30)]
        public virtual string first_mort_rate { get; set; }
        [MaxLength(30)]
        public virtual string first_mort_pastDue { get; set; }
        [MaxLength(30)]
        public virtual string estAmt { get; set; }
        public virtual DateTime? estAmtDate { get; set; }
        [MaxLength(30)]
        public virtual string intEstAmt { get; set; }
        public virtual DateTime? intEstAmtDate { get; set; }
        [MaxLength(20)]
        public virtual string intEstAmtStaff { get; set; }
        [MaxLength(20)]
        public virtual string creditLimit { get; set; }
        [MaxLength(500)]
        public virtual string mortRemarks { get; set; }
        [MaxLength(200)]
        public virtual string mortRef { get; set; }
        [MaxLength(1)]
        public virtual string risk_level { get; set; }
        [MaxLength(10)]
        public virtual string approver { get; set; }
        public virtual bool? checkedByCC_G { get; set; }
        public virtual bool? checkedByCC_N { get; set; }
        [MaxLength(20)]
        public virtual string redeem_approved { get; set; }
        [MaxLength(20)]
        public virtual string final_est_amt { get; set; }
        [MaxLength(20)]
        public virtual string collateral_sellout_rating { get; set; }
        [MaxLength(20)]
        public virtual string loan_safe_limit { get; set; }
    }
}
