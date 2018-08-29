using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ZZ_LAND_OWNERSHIP_CERTIFICATE_ONWER_RIGHTS")]
public class ZZ_LAND_OWNERSHIP_CERTIFICATE_ONWER_RIGHTS
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
    [Required]
    public virtual short registration_sequence_no { get; set; }
    public virtual short? serial_number { get; set; }
    [Required]
    public virtual DateTime date_of_registration { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string reason_of_registration { get; set; }
    [Required]
    public virtual DateTime date_reason_of_registration { get; set; }
    [MaxLength(100)]
    [Required]
    public virtual string onwer_name { get; set; }
    [MaxLength(50)]
    [Required]
    public virtual string owner_idno { get; set; }
    [Required]
    public virtual DateTime owner_birthday { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string owner_address { get; set; }
    [Required]
    public virtual short denominator_of_ownership { get; set; }
    [Required]
    public virtual short numerator_of_ownership { get; set; }
    [Required]
    public virtual decimal area_of_ownership_sqmeter { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string ownership_certificate_no { get; set; }
    [Required]
    public virtual short year_of_declared_land_value { get; set; }
    [Required]
    public virtual short month_of_declared_land_value { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string currency_type { get; set; }
    [Required]
    public virtual decimal declared_land_value { get; set; }
    [Required]
    public virtual decimal previous_announced_current_value { get; set; }
    [MaxLength(255)]
    public virtual string scope_of_ownership { get; set; }
    [MaxLength(255)]
    public virtual string related_registration_sequence_no { get; set; }
    [MaxLength(255)]
    public virtual string other_registration_matters { get; set; }
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
