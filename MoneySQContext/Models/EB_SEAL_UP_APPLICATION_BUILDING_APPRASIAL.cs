using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("EB_SEAL_UP_APPLICATION_BUILDING_APPRASIAL")]
public class EB_SEAL_UP_APPLICATION_BUILDING_APPRASIAL
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
    public virtual string seal_up_application_no { get; set; }
    [Key]
    [Column(Order = 3)]
    [MaxLength(40)]
    [Required]
    public virtual string building_number { get; set; }
    [MaxLength(20)]
    [Required]
    public virtual string appraisal_report_no { get; set; }
    [Required]
    public virtual decimal area_of_building_sqmeter { get; set; }
    [Required]
    public virtual decimal area_of_building_ping { get; set; }
    [MaxLength(3)]
    public virtual string currency_type { get; set; }
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
    public virtual int? attachment_id { get; set; }
    [MaxLength(255)]
    public virtual string realestate_address { get; set; }
    [MaxLength(40)]
    public virtual string land_lot { get; set; }
    [MaxLength(255)]
    public virtual string main_building_material { get; set; }
}
