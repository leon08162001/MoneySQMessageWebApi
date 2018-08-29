using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ZZ_BORROWER_NTOTE_CREDIT_DETAIL")]
public class ZZ_BORROWER_NTOTE_CREDIT_DETAIL
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
    [MaxLength(50)]
    [Required]
    public virtual string account_no { get; set; }
    [Key]
    [Column(Order = 4)]
    [Required]
    public virtual DateTime query_date { get; set; }
    [Key]
    [Column(Order = 5)]
    [MaxLength(3)]
    [Required]
    public virtual string reason_for_dishonor_check { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string currency_type { get; set; }
    public virtual short? cleared_check_cnt { get; set; }
    public virtual decimal? cleared_check_amt { get; set; }
    public virtual short? uncleared_check_cnt { get; set; }
    public virtual decimal? uncleared_check_amt { get; set; }
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
