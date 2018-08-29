using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("JA_COMPANY")]
public class JA_COMPANY
{
    [Key]
    [MaxLength(10)]
    [Required]
    public virtual string company_code { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string company_name { get; set; }
    [Required]
    public virtual DateTime establish_date { get; set; }
    public virtual DateTime? dissolve_date { get; set; }
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
    [MaxLength(3)]
    public virtual string currency_type { get; set; }
}
