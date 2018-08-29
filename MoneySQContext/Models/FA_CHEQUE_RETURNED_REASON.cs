using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("FA_CHEQUE_RETURNED_REASON")]
public class FA_CHEQUE_RETURNED_REASON
{
    [Key]
    [Column(Order = 1)]
    [MaxLength(10)]
    [Required]
    public virtual string company_code { get; set; }
    [Key]
    [Column(Order = 2)]
    [MaxLength(3)]
    [Required]
    public virtual string cheque_return_reason_code { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string cheque_return_reason { get; set; }
    [MaxLength(3)]
    public virtual string status { get; set; }
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
