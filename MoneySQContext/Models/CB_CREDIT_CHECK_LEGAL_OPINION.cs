using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("CB_CREDIT_CHECK_LEGAL_OPINION")]
public class CB_CREDIT_CHECK_LEGAL_OPINION
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
    [MaxLength(20)]
    [Required]
    public virtual string credit_check_reprot_no { get; set; }
    [Key]
    [Column(Order = 4)]
    [Required]
    public virtual DateTime consult_datetime { get; set; }
    [Required]
    public virtual short consult_employee_no { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string consult_employee_name { get; set; }
    [MaxLength(2000)]
    [Required]
    public virtual string consult_content { get; set; }
    public virtual DateTime? reply_datetime { get; set; }
    public virtual short? reply_employee_no { get; set; }
    [MaxLength(255)]
    public virtual string reply_employee_name { get; set; }
    [MaxLength(2000)]
    public virtual string reply_content { get; set; }
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
