using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ZZ_BUILDING_OWNERSHIP_CERTIFICATE_OTHER RIGHTS")]
public class ZZ_BUILDING_OWNERSHIP_CERTIFICATE_OTHER_RIGHTS
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
    public virtual short? yearmonth_of_receipt { get; set; }
    [MaxLength(255)]
    public virtual string no_of_receipt { get; set; }
    [MaxLength(100)]
    public virtual string obligee_category { get; set; }
    [MaxLength(50)]
    public virtual string obligee_id { get; set; }
    [MaxLength(100)]
    public virtual string obligee { get; set; }
    [MaxLength(255)]
    public virtual string obligee_address { get; set; }
    [MaxLength(255)]
    public virtual string loan_rights_ratio { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string currency_type { get; set; }
    [Required]
    public virtual decimal secured_debt_amt { get; set; }
    [MaxLength(255)]
    public virtual string secured_debt_coverage { get; set; }
    public virtual DateTime? secured_debt_confirm_date { get; set; }
    public virtual DateTime? settlement_date { get; set; }
    [MaxLength(50)]
    public virtual string interest_on_certificate { get; set; }
    [MaxLength(50)]
    public virtual string overdue_interest_on_certificate { get; set; }
    [MaxLength(50)]
    public virtual string default_fine_on_certificate { get; set; }
    [MaxLength(255)]
    public virtual string other_secured_debt_coverage { get; set; }
    [MaxLength(255)]
    public virtual string obligor_and_coverage { get; set; }
    [MaxLength(255)]
    public virtual string target_of_rights { get; set; }
    [MaxLength(255)]
    public virtual string registration_sequence_of_target { get; set; }
    [MaxLength(255)]
    public virtual string registrated_claim_coverage { get; set; }
    [MaxLength(255)]
    public virtual string certificate_no { get; set; }
    [MaxLength(255)]
    public virtual string registrated_obligor { get; set; }
    [MaxLength(100)]
    public virtual string joint_secured_land_no { get; set; }
    [MaxLength(100)]
    public virtual string joint_secured_building_no { get; set; }
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
