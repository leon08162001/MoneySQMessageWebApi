using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ZZ_BUILDING_OWNERSHIP_CERTIFICATE_SHARESECTION")]
public class ZZ_BUILDING_OWNERSHIP_CERTIFICATE_SHARESECTION
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
    [Key]
    [Column(Order = 4)]
    [MaxLength(100)]
    [Required]
    public virtual string building_number_of_sharesection { get; set; }
    [Required]
    public virtual decimal area_of_sharesection_sqmeter { get; set; }
    [Required]
    public virtual short denominator_of_ownership { get; set; }
    [Required]
    public virtual short numerator_of_ownership { get; set; }
    [Required]
    public virtual decimal area_of_ownership_sqmeter { get; set; }
    [MaxLength(3)]
    public virtual string parking_lot_mark { get; set; }
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
