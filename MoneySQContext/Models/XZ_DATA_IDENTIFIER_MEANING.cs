using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("XZ_DATA_IDENTIFIER_MEANING")]
public class XZ_DATA_IDENTIFIER_MEANING
{
    [Key]
    [Column(Order = 1)]
    [MaxLength(10)]
    [Required]
    public virtual string company_code { get; set; }
    [Key]
    [Column(Order = 2)]
    [MaxLength(100)]
    [Required]
    public virtual string tuple_name { get; set; }
    [Key]
    [Column(Order = 3)]
    [MaxLength(25)]
    [Required]
    public virtual string data_identifier { get; set; }
    [Key]
    [Column(Order = 4)]
    [MaxLength(5)]
    [Required]
    public virtual string language_type { get; set; }
    [MaxLength(100)]
    [Required]
    public virtual string data_identifier_meaning { get; set; }
    [Required]
    public virtual DateTime enable_date { get; set; }
    public virtual DateTime? disable_date { get; set; }
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
