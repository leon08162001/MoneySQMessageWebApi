using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("YA_ROLE_DIVISION")]
public class YA_ROLE_DIVISION
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
    [MaxLength(10)]
    [Required]
    public virtual string division_code { get; set; }
    [Required]
    public virtual DateTime enable_date { get; set; }
    public virtual DateTime? disable_date { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string manager_authorization_mark { get; set; }
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
