using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("XZ_DOCUMENT")]
public class XZ_DOCUMENT
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
    public virtual string document_code { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string document_name { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string document_category { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string document_source { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string document_status { get; set; }
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
