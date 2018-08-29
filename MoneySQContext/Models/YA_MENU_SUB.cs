using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("YA_MENU_SUB")]
public class YA_MENU_SUB
{
    [Key]
    [Column(Order = 1)]
    [MaxLength(10)]
    [Required]
    public virtual string company_code { get; set; }
    [Key]
    [Column(Order = 2)]
    [MaxLength(20)]
    [Required]
    public virtual string menu_code { get; set; }
    [Key]
    [Column(Order = 3)]
    [MaxLength(20)]
    [Required]
    public virtual string submenu_code { get; set; }
    [MaxLength(50)]
    [Required]
    public virtual string submenu_name { get; set; }
    [MaxLength(50)]
    [Required]
    public virtual string action_name { get; set; }
    [MaxLength(50)]
    [Required]
    public virtual string controller_name { get; set; }
    [Required]
    public virtual DateTime enable_date { get; set; }
    public virtual DateTime? disable_date { get; set; }
    [MaxLength(35)]
    [Required]
    public virtual string function_code { get; set; }
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
    [Required]
    public virtual byte sort { get; set; }
}
