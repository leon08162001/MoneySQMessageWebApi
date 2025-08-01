using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("XZ_BANKBRANCH")]
public class XZ_BANKBRANCH
{
    [Key]
    [Column(Order = 1)]
    [MaxLength(3)]
    [Required]
    public virtual string bank_code { get; set; }
    [Key]
    [Column(Order = 2)]
    [MaxLength(7)]
    [Required]
    public virtual string bank_branch_code { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string bank_branch_name { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string bank_abbreviation { get; set; }
    [MaxLength(255)]
    public virtual string bank_address { get; set; }
    [MaxLength(255)]
    public virtual string bank_phone_no { get; set; }
    [MaxLength(3)]
    public virtual string dissolve_mark { get; set; }
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
