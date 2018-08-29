using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("XZ_DATA_DICTIONARY")]
public class XZ_DATA_DICTIONARY
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
    [MaxLength(255)]
    [Required]
    public virtual string tuple_meaning { get; set; }
    [MaxLength(50)]
    [Required]
    public virtual string tuple_data_type { get; set; }
    [MaxLength(50)]
    [Required]
    public virtual string tuple_data_length { get; set; }
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
