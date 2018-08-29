using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("CB_CREDIT_CHECK_REPROT")]
    public class CB_CREDIT_CHECK_REPROT
    {
        public CB_CREDIT_CHECK_REPROT()
        {
            this.CbCreditCheckLegalOpinions = new List<CB_CREDIT_CHECK_LEGAL_OPINION>();
            this.CbCreditCheckReprotApprovements = new List<CB_CREDIT_CHECK_REPROT_APPROVEMENT>();
            this.CbCreditCheckReprotAttachments = new List<CB_CREDIT_CHECK_REPROT_ATTACHMENT>();
            this.CbCreditCheckScorings = new List<CB_CREDIT_CHECK_SCORING>();
            this.CbCreditCheckLegalOpinions1 = new List<CB_CREDIT_CHECK_LEGAL_OPINION>();
            this.CbCreditCheckReprotApprovements1 = new List<CB_CREDIT_CHECK_REPROT_APPROVEMENT>();
            this.CbCreditCheckReprotAttachments1 = new List<CB_CREDIT_CHECK_REPROT_ATTACHMENT>();
            this.CbCreditCheckScorings1 = new List<CB_CREDIT_CHECK_SCORING>();
            this.CbCreditCheckLegalOpinions2 = new List<CB_CREDIT_CHECK_LEGAL_OPINION>();
            this.CbCreditCheckReprotApprovements2 = new List<CB_CREDIT_CHECK_REPROT_APPROVEMENT>();
            this.CbCreditCheckReprotAttachments2 = new List<CB_CREDIT_CHECK_REPROT_ATTACHMENT>();
            this.CbCreditCheckScorings2 = new List<CB_CREDIT_CHECK_SCORING>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string application_no { get; set; }
        [Key]
        [Column(Order = 3)]
        [MaxLength(20)]
        public virtual string credit_check_reprot_no { get; set; }
        public virtual DateTime date_of_application { get; set; }
        [MaxLength(3)]
        public virtual string currency_type { get; set; }
        public virtual decimal amt_for_applying { get; set; }
        public virtual short period_for_applying { get; set; }
        [MaxLength(100)]
        public virtual string idno_of_applicant { get; set; }
        [MaxLength(255)]
        public virtual string name_of_applicant { get; set; }
        public virtual DateTime birthday { get; set; }
        public virtual short? age_years { get; set; }
        public virtual short? age_months { get; set; }
        [MaxLength(3)]
        public virtual string marital_status_cd { get; set; }
        [MaxLength(3)]
        public virtual string name_changed_mark { get; set; }
        [MaxLength(3)]
        public virtual string consistent_mark_nic_front_page { get; set; }
        [MaxLength(3)]
        public virtual string consistent_mark_nic_back_page { get; set; }
        [MaxLength(3)]
        public virtual string consistent_mark_hic_front_page { get; set; }
        [MaxLength(3)]
        public virtual string nic_renew_mark { get; set; }
        [MaxLength(3)]
        public virtual string guardianship_overtwenty_mark { get; set; }
        [MaxLength(3)]
        public virtual string guardianship_queryed_mark { get; set; }
        [MaxLength(3)]
        public virtual string guardianship_noted_mark { get; set; }
        [MaxLength(3)]
        public virtual string education_level_scoring_group { get; set; }
        [MaxLength(255)]
        public virtual string employed_company { get; set; }
        [MaxLength(3)]
        public virtual string employed_company_scoring_group { get; set; }
        public virtual DateTime? employed_company_setup_date { get; set; }
        public virtual DateTime? on_board_date { get; set; }
        public virtual short? seniority_years { get; set; }
        public virtual short? seniority_months { get; set; }
        [MaxLength(3)]
        public virtual string seniority_scoring_group { get; set; }
        [MaxLength(3)]
        public virtual string job_scoring_group { get; set; }
        [MaxLength(3)]
        public virtual string job_noted_mark { get; set; }
        public virtual decimal? calculated_annual_income { get; set; }
        public virtual decimal? calculated_monthly_income { get; set; }
        public virtual decimal? total_deposit { get; set; }
        [MaxLength(3)]
        public virtual string half_year_avergae_deposit_scoring_group { get; set; }
        [MaxLength(3)]
        public virtual string income_stability_scoring_group { get; set; }
        [MaxLength(100)]
        public virtual string realestate_address { get; set; }
        [MaxLength(100)]
        public virtual string ping { get; set; }
        [MaxLength(3)]
        public virtual string parking_holding_code { get; set; }
        [MaxLength(100)]
        public virtual string occupation_ratio { get; set; }
        [MaxLength(255)]
        public virtual string ping_of_praking_spaces { get; set; }
        [MaxLength(255)]
        public virtual string buliding_ages { get; set; }
        [MaxLength(255)]
        public virtual string rent_description { get; set; }
        public virtual decimal? total_apprasial_price { get; set; }
        [MaxLength(3)]
        public virtual string housing_stability_scoring_group { get; set; }
        [MaxLength(3)]
        public virtual string real_estate_holding_scoring_group { get; set; }
        [MaxLength(3)]
        public virtual string real_estate_mortgage_scoring_group { get; set; }
        public virtual short? credit_check_new_business_queryws_number { get; set; }
        public virtual decimal? total_credit_line { get; set; }
        public virtual decimal? total_credit_card_unpaid_balance { get; set; }
        public virtual decimal? unsecured_bebt_balance { get; set; }
        public virtual short? unsecured_bebt_ratio { get; set; }
        public virtual decimal? estimated_monthly_payment { get; set; }
        public virtual short? total_bebt_ratio { get; set; }
        [MaxLength(3)]
        public virtual string note_credit_scoring_group { get; set; }
        [MaxLength(3)]
        public virtual string guarantee_scoring_group { get; set; }
        public virtual short? credit_score { get; set; }
        public virtual short? adjusted_credit_score { get; set; }
        [MaxLength(3)]
        public virtual string loan_approval_mark { get; set; }
        public virtual short? suggested_unsecured_bebt_ratio_adopted { get; set; }
        public virtual decimal? suggested_loanable_amt_unsecured_debt { get; set; }
        public virtual short? suggested_total_bebt_ratio_adopted { get; set; }
        public virtual decimal? suggested_loanable_amt_total_debt { get; set; }
        public virtual decimal? loanable_amt_by_credit { get; set; }
        [MaxLength(3)]
        public virtual string credit_risk_level { get; set; }
        public virtual decimal? interest_rate_by_credit { get; set; }
        public virtual decimal? loan_amt_by_credit { get; set; }
        [MaxLength(3)]
        public virtual string contact_countersign_mark { get; set; }
        [MaxLength(2000)]
        public virtual string cred_opinion { get; set; }
        [MaxLength(3)]
        public virtual string scoring_card_version { get; set; }
        [MaxLength(3)]
        public virtual string risk_rank_version { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public JA_COMPANY JaCompany { get; set; }
        public ZZ_APPLICATION_LOANINFO ZzApplicationLoaninfo { get; set; }
        public ZZ_APPLICATION_LOANINFO ZzApplicationLoaninfo1 { get; set; }
        public List<CB_CREDIT_CHECK_LEGAL_OPINION> CbCreditCheckLegalOpinions { get; set; }
        public List<CB_CREDIT_CHECK_REPROT_APPROVEMENT> CbCreditCheckReprotApprovements { get; set; }
        public List<CB_CREDIT_CHECK_REPROT_ATTACHMENT> CbCreditCheckReprotAttachments { get; set; }
        public List<CB_CREDIT_CHECK_SCORING> CbCreditCheckScorings { get; set; }
        public List<CB_CREDIT_CHECK_LEGAL_OPINION> CbCreditCheckLegalOpinions1 { get; set; }
        public List<CB_CREDIT_CHECK_REPROT_APPROVEMENT> CbCreditCheckReprotApprovements1 { get; set; }
        public List<CB_CREDIT_CHECK_REPROT_ATTACHMENT> CbCreditCheckReprotAttachments1 { get; set; }
        public List<CB_CREDIT_CHECK_SCORING> CbCreditCheckScorings1 { get; set; }
        public List<CB_CREDIT_CHECK_LEGAL_OPINION> CbCreditCheckLegalOpinions2 { get; set; }
        public List<CB_CREDIT_CHECK_REPROT_APPROVEMENT> CbCreditCheckReprotApprovements2 { get; set; }
        public List<CB_CREDIT_CHECK_REPROT_ATTACHMENT> CbCreditCheckReprotAttachments2 { get; set; }
        public List<CB_CREDIT_CHECK_SCORING> CbCreditCheckScorings2 { get; set; }
    }
}
