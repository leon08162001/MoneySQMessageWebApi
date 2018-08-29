using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("FB_PAYMENT_INSTRUCTION_FAIL")]
public class FB_PAYMENT_INSTRUCTION_FAIL
{
    [Key]
    [Column(Order = 1)]
    [MaxLength(10)]
    [Required]
    public virtual string company_code { get; set; }
    [Key]
    [Column(Order = 3)]
    [Required]
    public virtual DateTime payment_date { get; set; }
    [Key]
    [Column(Order = 2)]
    [Required]
    public virtual short failpayment_batch_no { get; set; }
    public virtual short? empolyeeno_of_failpayment_confirmation { get; set; }
    [MaxLength(255)]
    public virtual string name_of_failpayment_confirmation { get; set; }
    public virtual DateTime? datetime_of_failpayment_confirmation { get; set; }
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
