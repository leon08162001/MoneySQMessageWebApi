using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("GA_VOUCHER_CONTROL")]
public class GA_VOUCHER_CONTROL
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
    [MaxLength(3)]
    [Required]
    public virtual string voucher_status { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string voucher_category { get; set; }
    [MaxLength(1000)]
    public virtual string voucher_memo { get; set; }
    [Required]
    public virtual short empolyeeno_of_keep_account { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string name_of_keep_account { get; set; }
    [Required]
    public virtual DateTime datetime_of_keep_account { get; set; }
    public virtual short? empolyeeno_of_confirmation { get; set; }
    [MaxLength(255)]
    public virtual string name_of_confirmation { get; set; }
    public virtual DateTime? datetime_of_confirmation { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string currency_type { get; set; }
    [Required]
    public virtual decimal total_debit_amount { get; set; }
    [Required]
    public virtual decimal total_credit_ampunt { get; set; }
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
    [MaxLength(50)]
    [Required]
    public virtual string voucher_source { get; set; }
    [MaxLength(10)]
    [Required]
    public virtual string division_code { get; set; }
}
