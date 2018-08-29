using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("EB_FORECLOSURE_EVALUATION")]
public class EB_FORECLOSURE_EVALUATION
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
    public virtual string foreclosure_evaluation_no { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string status_of_foreclosure_evaluation { get; set; }
    [Required]
    public virtual DateTime date_of_application { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string item_of_application { get; set; }
    [Required]
    public virtual short employeeno_of_applicant { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string name_of_applicant { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string currency_type { get; set; }
    [Required]
    public virtual decimal predecessors_oustanding_balance { get; set; }
    [Required]
    public virtual decimal predecessors_oustanding_balance_end { get; set; }
    [Required]
    public virtual decimal court_appraisal_price { get; set; }
    [Required]
    public virtual decimal acquisition_cost { get; set; }
    [MaxLength(3)]
    public virtual string cash_bid_mark { get; set; }
    [MaxLength(3)]
    public virtual string fail_bid_bear_mark { get; set; }
    [MaxLength(3)]
    public virtual string special_auction_procedures_mark { get; set; }
    [Required]
    public virtual decimal buying_price_suggested { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string useage_after_buying { get; set; }
    [Required]
    public virtual decimal loanable_amt_by_bank_approved { get; set; }
    [Required]
    public virtual decimal financing_rate { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string payment_category { get; set; }
    [MaxLength(500)]
    [Required]
    public virtual string legal_memo { get; set; }
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
}
