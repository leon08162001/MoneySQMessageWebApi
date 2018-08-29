using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("UA_SCHEDULE_SIGN_SEQUENCE")]
public class UA_SCHEDULE_SIGN_SEQUENCE
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
    public virtual string sign_flow_code { get; set; }
    [Key]
    [Column(Order = 3)]
    [Required]
    public virtual short sign_serial_no { get; set; }
    [Key]
    [Column(Order = 4)]
    [MaxLength(10)]
    [Required]
    public virtual string scheduled_sign_division_code { get; set; }
    [Key]
    [Column(Order = 5)]
    [MaxLength(10)]
    [Required]
    public virtual string scheduled_sign_role_id { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string method_of_approvement { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string mark_of_ruling_manager { get; set; }
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
