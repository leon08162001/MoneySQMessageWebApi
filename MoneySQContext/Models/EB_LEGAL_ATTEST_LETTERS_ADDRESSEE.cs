using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("EB_LEGAL_ATTEST_LETTERS_ADDRESSEE")]
public class EB_LEGAL_ATTEST_LETTERS_ADDRESSEE
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
    public virtual string legal_attest_letters_no { get; set; }
    [Key]
    [Column(Order = 3)]
    [Required]
    public virtual short addressee_serial_number { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string addressee_categroy { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string addressee { get; set; }
    [MaxLength(255)]
    public virtual string mailing_address { get; set; }
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
