using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ZZ_PERSONAL_CREDIT_REPORT")]
public class ZZ_PERSONAL_CREDIT_REPORT
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
    [MaxLength(50)]
    [Required]
    public virtual string social_security_number { get; set; }
    [Required]
    public virtual DateTime prinrted_date { get; set; }
    [MaxLength(50)]
    [Required]
    public virtual string report_no { get; set; }
    [MaxLength(10)]
    [Required]
    public virtual string notification_mark { get; set; }
    [Required]
    public virtual short credit_score { get; set; }
    [MaxLength(6)]
    public virtual string yearmonth_of_bankloan_data { get; set; }
    [MaxLength(6)]
    public virtual string yearmonth_of_baddebt_data { get; set; }
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
