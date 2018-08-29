using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("GA_INTERIM_ACCOUNT_DETAIL")]
public class GA_INTERIM_ACCOUNT_DETAIL
{
    [Key]
    [Column(Order = 1)]
    [MaxLength(10)]
    [Required]
    public virtual string company_code { get; set; }
    [Key]
    [Column(Order = 2)]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Required]
    public virtual short interim_account_detail_serno { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string interim_account_category { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string currency_type { get; set; }
    [Required]
    public virtual decimal amount { get; set; }
    [Required]
    public virtual decimal accumulative_total_offset_amount { get; set; }
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
    [MaxLength(50)]
    public virtual string contract_number { get; set; }
    public virtual short? payment_serial_no { get; set; }
    [Required]
    public virtual DateTime date_of_registration { get; set; }
}
