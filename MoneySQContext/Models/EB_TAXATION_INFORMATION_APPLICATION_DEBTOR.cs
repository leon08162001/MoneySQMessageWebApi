using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("EB_TAXATION_INFORMATION_APPLICATION_DEBTOR")]
public class EB_TAXATION_INFORMATION_APPLICATION_DEBTOR
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
    public virtual string TXI_application_no { get; set; }
    [Key]
    [Column(Order = 3)]
    [MaxLength(50)]
    [Required]
    public virtual string debtor_idno { get; set; }
    [MaxLength(100)]
    [Required]
    public virtual string debtor { get; set; }
    [MaxLength(3)]
    public virtual string income_queried_mark { get; set; }
    [MaxLength(100)]
    public virtual string income_year { get; set; }
    [MaxLength(3)]
    public virtual string property_queried_mark { get; set; }
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
