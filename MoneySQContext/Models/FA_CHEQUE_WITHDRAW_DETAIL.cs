using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("FA_CHEQUE_WITHDRAW_DETAIL")]
public class FA_CHEQUE_WITHDRAW_DETAIL
{
    [Key]
    [Column(Order = 1)]
    [MaxLength(10)]
    [Required]
    public virtual string company_code { get; set; }
    [Key]
    [Column(Order = 2)]
    [Required]
    public virtual DateTime withdraw_apply_date { get; set; }
    [Key]
    [Column(Order = 3)]
    [Required]
    public virtual short withdraw_apply_batch_no { get; set; }
    [Key]
    [Column(Order = 4)]
    [MaxLength(3)]
    [Required]
    public virtual string bank_code { get; set; }
    [Key]
    [Column(Order = 5)]
    [MaxLength(7)]
    [Required]
    public virtual string bank_branch_code { get; set; }
    [Key]
    [Column(Order = 6)]
    [MaxLength(50)]
    [Required]
    public virtual string cheque_no { get; set; }
    [Key]
    [Column(Order = 7)]
    [Required]
    public virtual DateTime cheque_received_date { get; set; }
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
