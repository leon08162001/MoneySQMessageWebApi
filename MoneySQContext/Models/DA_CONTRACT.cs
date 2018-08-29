using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("DA_CONTRACT")]
public class DA_CONTRACT
{
    [Key]
    [Column(Order = 1)]
    [MaxLength(10)]
    [Required]
    public virtual string company_code { get; set; }
    [Key]
    [Column(Order = 2)]
    [MaxLength(50)]
    [Required]
    public virtual string contract_number { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string contract_name { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string contract_status { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string contract_category { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string currency_type { get; set; }
    [Required]
    public virtual decimal amount_of_contract { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string approved_contract_type { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string interest_bearing_period { get; set; }
    [MaxLength(3)]
    public virtual string repayment_method_code { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string interest_calculation_method { get; set; }
    [Required]
    public virtual decimal contract_interest_rate { get; set; }
    [Required]
    public virtual short contract_terms { get; set; }
    public virtual DateTime? contract_start_date { get; set; }
    public virtual DateTime? contract_expiration_date { get; set; }
    public virtual decimal? contract_overdue_interest { get; set; }
    public virtual decimal? contract_default_fine_rate { get; set; }
    public virtual decimal? contract_late_fine_rate { get; set; }
    public virtual decimal? tax_amount { get; set; }
    public virtual decimal? fee_amount { get; set; }
    public virtual DateTime? sign_contract_date { get; set; }
    public virtual short? epmloyeeno_of_contract_signed_confirmation { get; set; }
    [MaxLength(255)]
    public virtual string name_of_contract_signed_confirmation { get; set; }
    public virtual DateTime? loan_appropriation_date { get; set; }
    public virtual DateTime? investment_received_date { get; set; }
    public virtual decimal? out_on_loan_of_investment { get; set; }
    public virtual decimal? loanable_amt_of_investment { get; set; }
    public virtual decimal? total_debt_paid { get; set; }
    public virtual decimal? total_debt_outstanding { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string bankcode_of_contractor { get; set; }
    [MaxLength(7)]
    [Required]
    public virtual string bankbranchcode_of_contractor { get; set; }
    [MaxLength(50)]
    [Required]
    public virtual string account_of_contractor { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string bankname_of_contractor { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string bankcode_for_contract { get; set; }
    [MaxLength(7)]
    [Required]
    public virtual string bankbranchcode_for_contract { get; set; }
    [MaxLength(50)]
    [Required]
    public virtual string virtualaccount_for_contract { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string bankname_for_contract { get; set; }
    [Required]
    public virtual decimal principal_per_issue { get; set; }
    [Required]
    public virtual decimal interest_per_issue { get; set; }
    [Required]
    public virtual decimal instalment { get; set; }
    public virtual short? number_of_checks { get; set; }
    public virtual int? attachment_id { get; set; }
    [MaxLength(100)]
    [Required]
    public virtual string opr_id { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string opr_name { get; set; }
    [Required]
    public virtual DateTime opr_date { get; set; }
    [MaxLength(40)]
    [Required]
    public virtual string opr_ip_address { get; set; }
    [MaxLength(40)]
    public virtual string opr_gps_address { get; set; }
    [MaxLength(100)]
    [Required]
    public virtual string account_name_of_contractor { get; set; }
    [Required]
    public virtual short Empolyeeno_of_service_staff { get; set; }
}
