using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("DA_CONTRACT_AMORTIZATION_DETAILS")]
public class DA_CONTRACT_AMORTIZATION_DETAILS
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
    public virtual string contract_number { get; set; }
    [Key]
    [Column(Order = 3)]
    [Required]
    public virtual DateTime scheduled_benefit_date { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string currency_type { get; set; }
    [Required]
    public virtual decimal pay_out_principal_payable { get; set; }
    [Required]
    public virtual decimal pay_out_interest_payable { get; set; }
    public virtual decimal? pay_out_principal_paid { get; set; }
    public virtual decimal? pay_out_interest_paid { get; set; }
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
    [Required]
    public virtual DateTime extratct_datetime { get; set; }
}
