using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("FB_PAYMENT_INSTRUCTION_FAIL_DETAIL")]
public class FB_PAYMENT_INSTRUCTION_FAIL_DETAIL
{
    [Key]
    [Column(Order = 1)]
    [MaxLength(10)]
    [Required]
    public virtual string company_code { get; set; }
    [Key]
    [Column(Order = 4)]
    [Required]
    public virtual DateTime payment_date { get; set; }
    [Key]
    [Column(Order = 2)]
    [Required]
    public virtual short failpayment_batch_no { get; set; }
    [Key]
    [Column(Order = 3)]
    [Required]
    public virtual short payment_serial_no { get; set; }
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
