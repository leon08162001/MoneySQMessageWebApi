using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("JA_DIVISION_MANAGER")]
public class JA_DIVISION_MANAGER
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
    public virtual string division_code { get; set; }
    [Key]
    [Column(Order = 3)]
    [Required]
    public virtual DateTime on_board_date { get; set; }
    [Required]
    public virtual short empolyee_no { get; set; }
    public virtual DateTime? leaving_date { get; set; }
    [MaxLength(3)]
    public virtual string manager_type { get; set; }
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
