using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("DA_CONTRACT_CHECK_ITEM")]
public class DA_CONTRACT_CHECK_ITEM
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
    public virtual string contract_category { get; set; }
    [Key]
    [Column(Order = 3)]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Required]
    public virtual short check_item_no { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string check_item { get; set; }
    [MaxLength(4000)]
    public virtual string check_points { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string check_necessity_mark { get; set; }
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
