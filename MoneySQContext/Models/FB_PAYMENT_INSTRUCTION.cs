using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("FB_PAYMENT_INSTRUCTION")]
public class FB_PAYMENT_INSTRUCTION
{
    [Key]
    [Column(Order = 1)]
    [MaxLength(10)]
    [Required]
    public virtual string company_code { get; set; }
    [Key]
    [Column(Order = 2)]
    [Required]
    public virtual short payment_serial_no { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string payment_instruction_status { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string basis_of_payment { get; set; }
    [MaxLength(50)]
    [Required]
    public virtual string payment_instruction_source { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string trust_bankcode { get; set; }
    [MaxLength(7)]
    [Required]
    public virtual string trust_bankbranchcode { get; set; }
    [MaxLength(50)]
    [Required]
    public virtual string trust_account { get; set; }
    [MaxLength(3)]
    public virtual string beneficiary_bankcode { get; set; }
    [MaxLength(7)]
    [Required]
    public virtual string beneficiary_bankbranchcode { get; set; }
    [MaxLength(50)]
    public virtual string beneficiary_account { get; set; }
    [MaxLength(100)]
    public virtual string beneficiary_account_name { get; set; }
    [MaxLength(50)]
    public virtual string beneficiary_id { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string currency_type { get; set; }
    [Required]
    public virtual decimal amount_payable { get; set; }
    [Required]
    public virtual decimal payment_amount { get; set; }
    public virtual decimal? withholding_taxes { get; set; }
    [Required]
    public virtual DateTime schedule_payment_date { get; set; }
    public virtual DateTime? payment_date { get; set; }
    public virtual short? payment_batch_no { get; set; }
    public virtual short? empolyeeno_of_confirmation { get; set; }
    [MaxLength(255)]
    public virtual string name_of_confirmation { get; set; }
    public virtual DateTime? datetime_of_confirmation { get; set; }
    public virtual short? failpayment_batch_no { get; set; }
    public virtual short? empolyeeno_of_failpayment_confirmation { get; set; }
    [MaxLength(255)]
    public virtual string name_of_failpayment_confirmation { get; set; }
    public virtual DateTime? datetime_of_failpayment_confirmation { get; set; }
    public virtual short? empolyeeno_of_failpayment_process { get; set; }
    [MaxLength(255)]
    public virtual string name_of_failpayment_process { get; set; }
    public virtual DateTime? datetime_of_failpayment_process { get; set; }
    public virtual DateTime? voucher_date { get; set; }
    public virtual short? voucher_no { get; set; }
    [MaxLength(100)]
    [Required]
    public virtual string opr_id { get; set; }
    [Required]
    public virtual DateTime opr_date { get; set; }
    [MaxLength(40)]
    [Required]
    public virtual string opr_ip_address { get; set; }
    [MaxLength(40)]
    public virtual string opr_gps_address { get; set; }
}
