using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("GA_VOUCHER_CONTENT")]
public class GA_VOUCHER_CONTENT
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
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Required]
    public virtual short voucher_account_serno { get; set; }
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
