using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("CC_APPRAISAL_LAND")]
public class CC_APPRAISAL_LAND
{
    [Key]
    [Column(Order = 1)]
    [MaxLength(10)]
    [Required]
    public virtual string company_code { get; set; }
    [Key]
    [Column(Order = 2)]
    [MaxLength(40)]
    [Required]
    public virtual string land_lot { get; set; }
    [Key]
    [Column(Order = 3)]
    [MaxLength(20)]
    [Required]
    public virtual string appraisal_report_no { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string currency_type { get; set; }
    [Required]
    public virtual decimal announced_current_value_sqmeter { get; set; }
    public virtual decimal? announced_current_value_ping { get; set; }
    public virtual decimal? apprasial_value_sqmeter { get; set; }
    public virtual decimal? apprasial_value_ping { get; set; }
    public virtual decimal? appraisal_price { get; set; }
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
