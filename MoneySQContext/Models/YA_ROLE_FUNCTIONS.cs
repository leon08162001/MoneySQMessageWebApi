using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("YA_ROLE_FUNCTIONS")]
public class YA_ROLE_FUNCTIONS
{
    [Key]
    [Column(Order = 1)]
    [MaxLength(10)]
    [Required]
    public virtual string company_code { get; set; }
    [Key]
    [Column(Order = 2)]
    [MaxLength(10)]
    [Required]
    public virtual string role_id { get; set; }
    [Key]
    [Column(Order = 3)]
    [MaxLength(35)]
    [Required]
    public virtual string function_code { get; set; }
    [Required]
    public virtual DateTime enable_date { get; set; }
    public virtual DateTime? disable_date { get; set; }
    [Required]
    public virtual int permission { get; set; }
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
