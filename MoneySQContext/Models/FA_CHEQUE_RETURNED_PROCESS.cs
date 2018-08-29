using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("FA_CHEQUE_RETURNED_PROCESS")]
public class FA_CHEQUE_RETURNED_PROCESS
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
    [Required]
    public virtual DateTime return_cheque_process_date { get; set; }
    [Required]
    public virtual short empolyeeno_of_rcprocess_staff { get; set; }
    [MaxLength(200)]
    [Required]
    public virtual string name_of_rcprocess_staff { get; set; }
    [MaxLength(3)]
    public virtual string same_cheque_mark { get; set; }
    public virtual decimal? cash_amount { get; set; }
    public virtual decimal? total_remittance_amount { get; set; }
    public virtual decimal? total_cheque_amount { get; set; }
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
