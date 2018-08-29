using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("loanApplication")]
    public class loanApplication
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(8)]
        [Required]
        public virtual string order_nbr { get; set; }
        [MaxLength(8)]
        public virtual string order_nbr_old { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(3)]
        [Required]
        public virtual string country { get; set; }
        public virtual int? status_id { get; set; }
        public virtual int? pre_approved_id { get; set; }
        public virtual bool? urgent { get; set; }
        public virtual bool? isExp { get; set; }
        public virtual DateTime? order_date { get; set; }
        [MaxLength(5)]
        public virtual string order_time { get; set; }
        public virtual DateTime? not_consider_date { get; set; }
        public virtual DateTime? apply_date { get; set; }
        public virtual DateTime? replyCus_date { get; set; }
        [MaxLength(20)]
        [Required]
        public virtual string user_id { get; set; }
        [MaxLength(50)]
        public virtual string rej_reason { get; set; }
        [MaxLength(30)]
        public virtual string applicant { get; set; }
        [MaxLength(30)]
        public virtual string proprietor { get; set; }
        [MaxLength(40)]
        public virtual string phone { get; set; }
        [MaxLength(10)]
        public virtual string income_proff { get; set; }
        [MaxLength(30)]
        public virtual string income_proff_amt { get; set; }
        [MaxLength(5)]
        public virtual string loan_type { get; set; }
        [MaxLength(20)]
        public virtual string mortgage { get; set; }
        [MaxLength(50)]
        public virtual string loan_amt { get; set; }
        [MaxLength(30)]
        public virtual string req_loanRevDate { get; set; }
        [MaxLength(50)]
        public virtual string loan_purpose { get; set; }
        [MaxLength(300)]
        public virtual string remarks { get; set; }
        [MaxLength(60)]
        public virtual string checker1 { get; set; }
        [MaxLength(60)]
        public virtual string checker2 { get; set; }
        [MaxLength(10)]
        public virtual string approver { get; set; }
        [MaxLength(1)]
        public virtual string pass_approved { get; set; }
        [MaxLength(1)]
        public virtual string exclusiveFlag { get; set; }
        public virtual bool? exclude { get; set; }
        public virtual bool? isSMS { get; set; }
        public virtual bool? isSMS_sent { get; set; }
        public virtual bool? noSMS { get; set; }
        public virtual bool? is_followup { get; set; }
        public virtual int? smsCount { get; set; }
        public virtual DateTime? lst_smsDate { get; set; }
        public virtual DateTime? lst_replyDate { get; set; }
        public virtual DateTime? threeMonSMSDate { get; set; }
        [MaxLength(10)]
        public virtual string smsMobile { get; set; }
        [MaxLength(20)]
        public virtual string smsAmt1 { get; set; }
        [MaxLength(20)]
        public virtual string smsAmt2 { get; set; }
        [MaxLength(20)]
        public virtual string smsAmt3 { get; set; }
        [MaxLength(20)]
        public virtual string smsAmt4 { get; set; }
        [MaxLength(20)]
        public virtual string smsAmt5 { get; set; }
        [MaxLength(20)]
        public virtual string smsReplier { get; set; }
        [MaxLength(200)]
        public virtual string credit_notes { get; set; }
        public virtual bool? re_approval { get; set; }
        [MaxLength(10)]
        public virtual string intention_level { get; set; }
        public virtual bool? privacy { get; set; }
        [MaxLength(20)]
        public virtual string editing_by { get; set; }
        [MaxLength(20)]
        public virtual string refno { get; set; }
        public virtual DateTime? sign_date { get; set; }
        [MaxLength(4)]
        public virtual string sign_time { get; set; }
        public virtual DateTime? start_rent_date { get; set; }
        [MaxLength(5)]
        public virtual string loan_term { get; set; }
        [MaxLength(5)]
        public virtual string loan_penalty_term { get; set; }
        [MaxLength(10)]
        public virtual string payment_method { get; set; }
        [MaxLength(10)]
        public virtual string interest_flag { get; set; }
        [MaxLength(10)]
        public virtual string interest { get; set; }
        [MaxLength(5)]
        public virtual string iOnly_period { get; set; }
        [MaxLength(20)]
        public virtual string accName { get; set; }
        [MaxLength(30)]
        public virtual string accNum { get; set; }
        [MaxLength(100)]
        public virtual string accBank { get; set; }
        [MaxLength(30)]
        public virtual string refinance_amt { get; set; }
        [MaxLength(30)]
        public virtual string setup_amt { get; set; }
        [MaxLength(10)]
        public virtual string first_install_method { get; set; }
        [MaxLength(30)]
        public virtual string mon_install_amt { get; set; }
        [MaxLength(20)]
        public virtual string pay_day { get; set; }
        public virtual DateTime? first_install_date { get; set; }
        public virtual DateTime? property_view_date { get; set; }
        [MaxLength(10)]
        public virtual string property_view_time { get; set; }
        [MaxLength(100)]
        public virtual string contractPropertyNum { get; set; }
        [MaxLength(100)]
        public virtual string contractType { get; set; }
        [MaxLength(20)]
        public virtual string contractConpenAmt { get; set; }
        [MaxLength(20)]
        public virtual string contractConpenName { get; set; }
        [MaxLength(20)]
        public virtual string contractBorrowerOut { get; set; }
        [MaxLength(20)]
        public virtual string contractAdminFee { get; set; }
        [MaxLength(20)]
        public virtual string payBack_accName { get; set; }
        [MaxLength(30)]
        public virtual string payBack_accNum { get; set; }
        [MaxLength(100)]
        public virtual string payBack_accBank { get; set; }
        public virtual DateTime? completed_date { get; set; }
        public virtual bool? is_contractTaxFee { get; set; }
        public virtual bool? is_contractAdminFee { get; set; }
        public virtual bool? is_contractClaimFee { get; set; }
        public virtual bool? is_payWithTax { get; set; }
        [MaxLength(20)]
        [Required]
        public virtual string last_upd_user { get; set; }
        public virtual DateTime? last_upd_date { get; set; }
        public virtual bool? IsRefinance { get; set; }
        [MaxLength(100)]
        public virtual string accBranch { get; set; }
        [MaxLength(100)]
        public virtual string payBack_accBranch { get; set; }
        public virtual bool? is_from_callcenter { get; set; }
        [MaxLength(20)]
        public virtual string callcenter_user_id { get; set; }
        [MaxLength(1)]
        public virtual string pass_pendingForApproval { get; set; }
        public virtual DateTime? legal_attest_letter_last_pay_date { get; set; }
        [MaxLength(1)]
        public virtual string legal_attest_letter_amt_type { get; set; }
        [MaxLength(100)]
        public virtual string legal_attest_letter_breach_clause { get; set; }
        [MaxLength(1)]
        public virtual string legal_attest_letter_company_type { get; set; }
        public virtual int? pre_status_id { get; set; }
        [MaxLength(200)]
        public virtual string all_status_id { get; set; }
        public virtual bool? agent { get; set; }
    }
}
