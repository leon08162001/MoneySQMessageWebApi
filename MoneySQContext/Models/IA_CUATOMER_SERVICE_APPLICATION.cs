using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("IA_CUATOMER_SERVICE_APPLICATION")]
public class IA_CUATOMER_SERVICE_APPLICATION
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
    public virtual string customer_service_application_no { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string status_of_customer_service_application { get; set; }
    [MaxLength(50)]
    [Required]
    public virtual string contract_number { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string contract_category { get; set; }
    [Required]
    public virtual DateTime date_of_application { get; set; }
    [Required]
    public virtual short empolyeeno_of_service_staff { get; set; }
    public virtual DateTime? advance_redemption_date { get; set; }
    [MaxLength(3)]
    public virtual string partial_advance_redemption_mark { get; set; }
    [MaxLength(3)]
    public virtual string currency_type { get; set; }
    public virtual decimal? advance_redemption_amount { get; set; }
    public virtual DateTime? contract_expiration_date_changed { get; set; }
    public virtual short? day_of_scheduled_repayment_date { get; set; }
    public virtual short? day_of_scheduled_repayment_date_changed { get; set; }
    [MaxLength(3)]
    public virtual string repayment_method_code { get; set; }
    [MaxLength(3)]
    public virtual string repayment_method_code_changed { get; set; }
    [MaxLength(3)]
    public virtual string record_of_trading_mark { get; set; }
    [MaxLength(3)]
    public virtual string certificate_of_trading_mark { get; set; }
    [MaxLength(500)]
    public virtual string other_apply_item { get; set; }
    [MaxLength(3)]
    public virtual string advance_redemption_agree_mark { get; set; }
    [MaxLength(3)]
    public virtual string contract_expiration_date_changed_agree_mark { get; set; }
    [MaxLength(3)]
    public virtual string day_of_scheduled_date_changed_agree_mark { get; set; }
    [MaxLength(3)]
    public virtual string repayment_method_agree_mark { get; set; }
    [MaxLength(3)]
    public virtual string record_of_trading_print_mark { get; set; }
    [MaxLength(3)]
    public virtual string certificate_of_trading_print_mark { get; set; }
    [MaxLength(500)]
    public virtual string other_apply_item_acceptence_opion { get; set; }
    public virtual DateTime? datetime_of_acceptence { get; set; }
    public virtual short? case_officer_employeeno { get; set; }
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
