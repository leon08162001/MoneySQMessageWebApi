using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("FA_CHEQUE")]
public class FA_CHEQUE
{
    [Key]
    [Column(Order = 1)]
    [MaxLength(3)]
    [Required]
    public virtual string bank_code { get; set; }
    [Key]
    [Column(Order = 2)]
    [MaxLength(7)]
    [Required]
    public virtual string bank_branch_code { get; set; }
    [Key]
    [Column(Order = 3)]
    [MaxLength(50)]
    [Required]
    public virtual string cheque_no { get; set; }
    [Key]
    [Column(Order = 4)]
    [Required]
    public virtual DateTime cheque_received_date { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string cheque_status { get; set; }
    [Required]
    public virtual DateTime cheque_date { get; set; }
    [Required]
    public virtual decimal amount_in_figures { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string amount_in_words { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string payee_on_cheque { get; set; }
    [MaxLength(10)]
    [Required]
    public virtual string company_code { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string bank_branch_name { get; set; }
    [Required]
    public virtual int attachment_id { get; set; }
    public virtual DateTime? cash_date { get; set; }
    [MaxLength(3)]
    public virtual string cheque_location { get; set; }
    public virtual DateTime? cheque_return_date { get; set; }
    [MaxLength(3)]
    public virtual string cheque_return_reason_code { get; set; }
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
    public virtual string bank_account { get; set; }
}
