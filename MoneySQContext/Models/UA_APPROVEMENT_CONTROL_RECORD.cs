using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("UA_APPROVEMENT_CONTROL_RECORD")]
public class UA_APPROVEMENT_CONTROL_RECORD
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
    public virtual string approval_no { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string casename_of_approvement { get; set; }
    [Required]
    public virtual DateTime datetime_of_submit { get; set; }
    [MaxLength(10)]
    [Required]
    public virtual string divisioncode_of_submit { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string divisionname_of_submit { get; set; }
    [Required]
    public virtual short employeeno_of_submit { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string employeename_of_submit { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string status_of_approvement { get; set; }
    [MaxLength(10)]
    [Required]
    public virtual string approvement_category { get; set; }
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
