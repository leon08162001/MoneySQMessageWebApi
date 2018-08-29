using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("DA_DEBIT_NOTE_CONTROL")]
public class DA_DEBIT_NOTE_CONTROL
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
    public virtual string debit_note_no { get; set; }
    [MaxLength(50)]
    [Required]
    public virtual string contract_number { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string status_of_debit_note { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string reason_for_apply { get; set; }
    [Required]
    public virtual short employeeno_of_applicant { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string name_of_applicant { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string currency_type { get; set; }
    [Required]
    public virtual decimal total_amount { get; set; }
    [Required]
    public virtual decimal business_tax { get; set; }
    [Required]
    public virtual decimal write_off_amount { get; set; }
    [Required]
    public virtual decimal write_off_business_tax { get; set; }
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
    public virtual DateTime date_of_application { get; set; }
}
