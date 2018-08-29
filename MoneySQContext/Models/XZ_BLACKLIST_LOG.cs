using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("XZ_BLACKLIST_LOG")]
public class XZ_BLACKLIST_LOG
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
    public virtual string blacklist_id { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string blacklist_name { get; set; }
    [MaxLength(300)]
    [Required]
    public virtual string blacklist_english_name { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string data_source { get; set; }
    [MaxLength(2000)]
    [Required]
    public virtual string watch_reason { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string status { get; set; }
    [MaxLength(100)]
    [Required]
    public virtual string opr_id { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string opr_name { get; set; }
    [Key]
    [Column(Order = 3)]
    [Required]
    public virtual DateTime opr_date { get; set; }
    [MaxLength(40)]
    [Required]
    public virtual string opr_ip_address { get; set; }
    [MaxLength(40)]
    public virtual string opr_gps_address { get; set; }
}
