using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ZZ_LAND_OWNERSHIP_CERTIFICATE_DESCRIPTION")]
public class ZZ_LAND_OWNERSHIP_CERTIFICATE_DESCRIPTION
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
    public virtual string application_no { get; set; }
    [Key]
    [Column(Order = 3)]
    [Required]
    public virtual int attachment_id { get; set; }
    public virtual DateTime? prinrted_date { get; set; }
    [MaxLength(100)]
    public virtual string land_lot { get; set; }
    [MaxLength(50)]
    public virtual string land_lot_city { get; set; }
    [MaxLength(50)]
    public virtual string land_lot_district { get; set; }
    [MaxLength(50)]
    public virtual string land_lot_section { get; set; }
    [MaxLength(50)]
    public virtual string land_lot_subsection { get; set; }
    [MaxLength(50)]
    public virtual string land_lot_no { get; set; }
    public virtual short? yearmonth_of_receipt { get; set; }
    [MaxLength(255)]
    public virtual string no_of_receipt { get; set; }
    public virtual DateTime? date_of_registration { get; set; }
    [MaxLength(255)]
    public virtual string certificate_category_no { get; set; }
    [MaxLength(2)]
    public virtual string certificate_category { get; set; }
    [MaxLength(255)]
    public virtual string reason_of_registration { get; set; }
    public virtual decimal? area_sqmeter { get; set; }
    [MaxLength(255)]
    public virtual string zoning { get; set; }
    [MaxLength(255)]
    public virtual string zoning_category { get; set; }
    [MaxLength(3)]
    public virtual string currency_type { get; set; }
    public virtual decimal? announced_current_value_sqmeter { get; set; }
    public virtual short? year_of_announced_current_value { get; set; }
    public virtual short? month_of_announced_current_value { get; set; }
    [MaxLength(255)]
    public virtual string land_category { get; set; }
    [MaxLength(255)]
    public virtual string grade_of_land_productivity { get; set; }
    [MaxLength(255)]
    public virtual string building_number { get; set; }
    [MaxLength(255)]
    public virtual string other_registration_matters { get; set; }
    [MaxLength(3)]
    public virtual string collateral_mark { get; set; }
    [MaxLength(3)]
    public virtual string appraisal_mark { get; set; }
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
