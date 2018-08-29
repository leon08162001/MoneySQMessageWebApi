using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("GA_VOUCHER_DETAIL")]
public class GA_VOUCHER_DETAIL
{
    [Key]
    [Column(Order = 1)]
    [MaxLength(10)]
    [Required]
    public virtual string company_code { get; set; }
    [Key]
    [Column(Order = 2)]
    [Required]
    public virtual DateTime voucher_date { get; set; }
    [Key]
    [Column(Order = 3)]
    [Required]
    public virtual short voucher_no { get; set; }
    [Key]
    [Column(Order = 4)]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Required]
    public virtual short voucher_detail_serno { get; set; }
    [MaxLength(20)]
    [Required]
    public virtual string account_first_grade { get; set; }
    [MaxLength(20)]
    [Required]
    public virtual string account_second_grade { get; set; }
    [MaxLength(20)]
    [Required]
    public virtual string account_third_grade { get; set; }
    [MaxLength(20)]
    [Required]
    public virtual string account_fourth_grade { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string debit_credit_mark { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string currency_type { get; set; }
    [Required]
    public virtual decimal amount { get; set; }
    [MaxLength(1000)]
    public virtual string account_memo { get; set; }
    [MaxLength(255)]
    public virtual string correspond_tablet_name { get; set; }
    [MaxLength(3)]
    public virtual string trust_bankcode { get; set; }
    [MaxLength(7)]
    public virtual string trust_bankbranchcode { get; set; }
    [MaxLength(50)]
    public virtual string trust_account { get; set; }
    public virtual DateTime? traction_date { get; set; }
    public virtual int? serial_no { get; set; }
    public virtual short? interim_account_detail_serno { get; set; }
    public virtual short? payment_serial_no { get; set; }
    [MaxLength(50)]
    public virtual string contract_number { get; set; }
    public virtual DateTime? scheduled_repayment_date { get; set; }
    public virtual DateTime? scheduled_benefit_date { get; set; }
    [MaxLength(3)]
    public virtual string bank_code { get; set; }
    [MaxLength(7)]
    public virtual string bank_branch_code { get; set; }
    [MaxLength(50)]
    public virtual string cheque_no { get; set; }
    [MaxLength(50)]
    public virtual string invoice_no { get; set; }
    public virtual short? invoice_detail_serial_number { get; set; }
    [MaxLength(50)]
    public virtual string debit_note_no { get; set; }
    public virtual short? da_debit_note_detail_serial_no { get; set; }
    public virtual DateTime? date_of_registration { get; set; }
    public virtual DateTime? write_off_date { get; set; }
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
