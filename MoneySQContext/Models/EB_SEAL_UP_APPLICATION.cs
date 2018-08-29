using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("EB_SEAL_UP_APPLICATION")]
public class EB_SEAL_UP_APPLICATION
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
    public virtual string seal_up_application_no { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string status_of_seal_up_application { get; set; }
    [Required]
    public virtual DateTime date_of_application { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string item_of_application { get; set; }
    [Required]
    public virtual short employeeno_of_applicant { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string name_of_applicant { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string currency_type { get; set; }
    [Required]
    public virtual decimal loan_amount { get; set; }
    [Required]
    public virtual decimal loan_balance { get; set; }
    [Required]
    public virtual decimal predecessors_oustanding_balance { get; set; }
    [MaxLength(500)]
    public virtual string explaination { get; set; }
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
