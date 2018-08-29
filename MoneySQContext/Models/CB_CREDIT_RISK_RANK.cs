using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("CB_CREDIT_RISK_RANK")]
public class CB_CREDIT_RISK_RANK
{
    [Key]
    [Column(Order = 1)]
    [MaxLength(10)]
    [Required]
    public virtual string company_code { get; set; }
    [Key]
    [Column(Order = 2)]
    [MaxLength(3)]
    [Required]
    public virtual string risk_rank_version { get; set; }
    [Key]
    [Column(Order = 3)]
    [Required]
    public virtual short risk_rank_code { get; set; }
    [Key]
    [Column(Order = 4)]
    [MaxLength(5)]
    [Required]
    public virtual string language_type { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string risk_rank { get; set; }
    [Required]
    public virtual short credit_score_start { get; set; }
    [Required]
    public virtual short credit_score_end { get; set; }
    [Required]
    public virtual short unsecured_bebt_ratio { get; set; }
    [Required]
    public virtual short total_bebt_ratio { get; set; }
    [Required]
    public virtual decimal interest_rate_by_credit { get; set; }
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
