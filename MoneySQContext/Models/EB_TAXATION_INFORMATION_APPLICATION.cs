using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("EB_TAXATION_INFORMATION_APPLICATION")]
public class EB_TAXATION_INFORMATION_APPLICATION
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
    [Required]
    public virtual DateTime date_of_application { get; set; }
    [MaxLength(100)]
    [Required]
    public virtual string taxation_bureau { get; set; }
    [MaxLength(100)]
    [Required]
    public virtual string creditor { get; set; }
    [MaxLength(50)]
    [Required]
    public virtual string creditor_idno { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string creditor_address { get; set; }
    [MaxLength(100)]
    [Required]
    public virtual string responsible_person { get; set; }
    [MaxLength(100)]
    [Required]
    public virtual string procurator { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string procurator_address { get; set; }
    [MaxLength(50)]
    [Required]
    public virtual string procurator_idno { get; set; }
    [MaxLength(50)]
    public virtual string procurator_telno { get; set; }
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
