using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("refinanceApplication")]
    public class refinanceApplication
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual decimal refinance_pk { get; set; }
        [MaxLength(20)]
        [Required]
        public virtual string loan_no { get; set; }
        public virtual int? status { get; set; }
        public virtual DateTime? callin_date { get; set; }
        [MaxLength(4)]
        public virtual string callin_time { get; set; }
        public virtual int? version { get; set; }
        public virtual bool? exclude { get; set; }
        [MaxLength(20)]
        public virtual string contact_person { get; set; }
        [MaxLength(40)]
        public virtual string phone { get; set; }
        [MaxLength(30)]
        public virtual string contract_type { get; set; }
        [MaxLength(20)]
        public virtual string loan_type { get; set; }
        [MaxLength(50)]
        public virtual string request_amt { get; set; }
        [MaxLength(10)]
        public virtual string require_redem { get; set; }
        [MaxLength(50)]
        public virtual string require_redem_item { get; set; }
        [MaxLength(50)]
        public virtual string net_amt { get; set; }
        [MaxLength(20)]
        public virtual string handle_by_1 { get; set; }
        [MaxLength(2)]
        public virtual string purpose_type { get; set; }
        [MaxLength(100)]
        public virtual string purpose { get; set; }
        [MaxLength(100)]
        public virtual string os_item { get; set; }
        [MaxLength(100)]
        public virtual string os_item_amt { get; set; }
        [MaxLength(500)]
        public virtual string other_properties { get; set; }
        public virtual bool? print_redem_report { get; set; }
        [MaxLength(10)]
        public virtual string reten_repaid_exp_flag { get; set; }
        [MaxLength(30)]
        public virtual string reten_repaid_exp { get; set; }
        [MaxLength(10)]
        public virtual string repaid_exp_flag { get; set; }
        [MaxLength(30)]
        public virtual string repaid_exp { get; set; }
        [MaxLength(3)]
        public virtual string prepaid_exp_flag { get; set; }
        [MaxLength(10)]
        public virtual string prepaid_exp { get; set; }
        [MaxLength(3)]
        public virtual string credit_limit_flag { get; set; }
        [MaxLength(30)]
        public virtual string credit_limit { get; set; }
        [MaxLength(50)]
        public virtual string credit_limit_source { get; set; }
        [MaxLength(7)]
        public virtual string tu_flag { get; set; }
        [MaxLength(50)]
        public virtual string tu_amt { get; set; }
        [MaxLength(7)]
        public virtual string add_flag { get; set; }
        [MaxLength(7)]
        public virtual string property_view_flag { get; set; }
        [MaxLength(20)]
        public virtual string property_view { get; set; }
        [MaxLength(20)]
        public virtual string trans_to { get; set; }
        [MaxLength(50)]
        public virtual string trans_source { get; set; }
        [MaxLength(20)]
        public virtual string trans_loanType { get; set; }
        [MaxLength(20)]
        public virtual string trans_loan_amt { get; set; }
        [MaxLength(10)]
        public virtual string trans_terms { get; set; }
        [MaxLength(20)]
        public virtual string trans_interest { get; set; }
        [MaxLength(20)]
        public virtual string trans_pmt { get; set; }
        public virtual bool? trans_IsPrincipal { get; set; }
        public virtual bool? trans_IsInterest { get; set; }
        [MaxLength(10)]
        public virtual string trans_bargainRate { get; set; }
        [MaxLength(200)]
        public virtual string trans_reason { get; set; }
        [MaxLength(200)]
        public virtual string trans_reject_reason { get; set; }
        public virtual bool? remarks_checked { get; set; }
        [MaxLength(100)]
        public virtual string remarks_refinance { get; set; }
        public virtual bool? hight_remarks { get; set; }
        public virtual bool? pass_to_cc { get; set; }
        public virtual bool? isNewAction { get; set; }
        [MaxLength(10)]
        public virtual string hasLegalFee { get; set; }
        [MaxLength(2)]
        public virtual string interest_type { get; set; }
        [MaxLength(30)]
        public virtual string refinance_amt { get; set; }
        [MaxLength(20)]
        public virtual string redeem { get; set; }
        [MaxLength(10)]
        public virtual string redeem_item { get; set; }
        [MaxLength(10)]
        public virtual string interest_flag { get; set; }
        [MaxLength(30)]
        public virtual string interest { get; set; }
        [MaxLength(30)]
        public virtual string valuation_amt { get; set; }
        public virtual DateTime? valuation_date { get; set; }
        [MaxLength(20)]
        public virtual string valuation_staff { get; set; }
        [MaxLength(3)]
        public virtual string new_credit_limit_flag { get; set; }
        [MaxLength(50)]
        public virtual string new_credit_limit_amt { get; set; }
        [MaxLength(500)]
        public virtual string remarks { get; set; }
        [MaxLength(200)]
        public virtual string credit_notes { get; set; }
        [MaxLength(20)]
        public virtual string approved_by { get; set; }
        [MaxLength(20)]
        public virtual string tu_outstanding { get; set; }
        [MaxLength(20)]
        public virtual string credit_ratio_tu { get; set; }
        [MaxLength(20)]
        public virtual string credit_ratio_notu { get; set; }
        [MaxLength(10)]
        public virtual string risk_level { get; set; }
        [MaxLength(2000)]
        public virtual string refinance_details { get; set; }
        [MaxLength(4000)]
        public virtual string refinance_history { get; set; }
        public virtual bool? checkByCC { get; set; }
        [MaxLength(15)]
        public virtual string approval_status { get; set; }
        public virtual bool? revise_data { get; set; }
        public virtual bool? isApproved { get; set; }
        public virtual bool? isReturn { get; set; }
        public virtual bool? is_redemLetter { get; set; }
        public virtual DateTime? redem_date { get; set; }
        [MaxLength(10)]
        public virtual string last_upd_user { get; set; }
        public virtual DateTime? last_upd_date { get; set; }
    }
}
