using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("WA_MESSAGE")]
public class WA_MESSAGE
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
    public virtual string message_idno { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string message_subject { get; set; }
    [MaxLength(4000)]
    [Required]
    public virtual string content { get; set; }
    [Required]
    public virtual DateTime message_send_datetime { get; set; }
    [Required]
    public virtual short message_send_empolyeeno { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string message_send_empolyeename { get; set; }
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
