using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("DA_CONTRACT_PROPERTY")]
public class DA_CONTRACT_PROPERTY
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
    public virtual string contract_number { get; set; }
    [Key]
    [Column(Order = 3)]
    [MaxLength(100)]
    [Required]
    public virtual string list_number { get; set; }
    [MaxLength(50)]
    [Required]
    public virtual string social_security_number { get; set; }
    [MaxLength(100)]
    [Required]
    public virtual string issuance_unit { get; set; }
    [MaxLength(100)]
    [Required]
    public virtual string document_number { get; set; }
    [MaxLength(100)]
    [Required]
    public virtual string property_applicant { get; set; }
    [MaxLength(50)]
    [Required]
    public virtual string property_applicant_idno { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string property_applicant_address { get; set; }
    [Required]
    public virtual int attachment_id { get; set; }
    [MaxLength(50)]
    [Required]
    public virtual string TXI_application_no { get; set; }
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
