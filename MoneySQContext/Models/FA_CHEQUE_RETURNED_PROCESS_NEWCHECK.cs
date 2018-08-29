using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("FA_CHEQUE_RETURNED_PROCESS_NEWCHECK")]
public class FA_CHEQUE_RETURNED_PROCESS_NEWCHECK
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
    public virtual string return_cheque_process_no { get; set; }
    [Key]
    [Column(Order = 3)]
    [MaxLength(3)]
    [Required]
    public virtual string bank_code { get; set; }
    [Key]
    [Column(Order = 4)]
    [MaxLength(7)]
    [Required]
    public virtual string bank_branch_code { get; set; }
    [Key]
    [Column(Order = 5)]
    [MaxLength(50)]
    [Required]
    public virtual string cheque_no { get; set; }
    [Key]
    [Column(Order = 6)]
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
