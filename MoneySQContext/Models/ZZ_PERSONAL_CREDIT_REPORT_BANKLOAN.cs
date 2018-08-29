using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ZZ_PERSONAL_CREDIT_REPORT_BANKLOAN")]
public class ZZ_PERSONAL_CREDIT_REPORT_BANKLOAN
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
    public virtual string application_no { get; set; }
    [Key]
    [Column(Order = 3)]
    [Required]
    public virtual int attachment_id { get; set; }
    [Key]
    [Column(Order = 4)]
    [MaxLength(100)]
    [Required]
    public virtual string financial_Institution_name { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string currency_type { get; set; }
    [Required]
    public virtual decimal amount_of_contract { get; set; }
    [Required]
    public virtual decimal loan_balance { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string subject { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string delay_repayment_over_past_year { get; set; }
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
