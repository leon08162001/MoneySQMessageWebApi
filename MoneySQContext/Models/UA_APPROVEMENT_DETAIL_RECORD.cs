using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("UA_APPROVEMENT_DETAIL_RECORD")]
public class UA_APPROVEMENT_DETAIL_RECORD
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
    public virtual string approval_no { get; set; }
    [Key]
    [Column(Order = 3)]
    [Required]
    public virtual short sign_serial_no { get; set; }
    [Key]
    [Column(Order = 4)]
    [MaxLength(10)]
    [Required]
    public virtual string scheduled_sign_division_code { get; set; }
    [Key]
    [Column(Order = 5)]
    [Required]
    public virtual short scheduled_sign_empolyee_no { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string status_of_approvement { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string method_of_approvement { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string mark_of_ruling_manager { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string scheduled_sign_division_name { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string scheduled_sign_empolyee_name { get; set; }
    [MaxLength(10)]
    public virtual string real_sign_division_code { get; set; }
    [MaxLength(255)]
    public virtual string real_sign_division_name { get; set; }
    public virtual short? real_sign_empolyee_no { get; set; }
    [MaxLength(255)]
    public virtual string real_sign_empolyee_name { get; set; }
    public virtual DateTime? real_sign_datetime { get; set; }
    [MaxLength(2000)]
    public virtual string signed_opinion { get; set; }
    public virtual decimal? signed_interest_rate { get; set; }
    [MaxLength(3)]
    public virtual string currency_type { get; set; }
    public virtual decimal? signed_amount { get; set; }
    [MaxLength(3)]
    public virtual string signed_contract_type { get; set; }
    [MaxLength(3)]
    public virtual string acceptance_suggestion_cd { get; set; }
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
