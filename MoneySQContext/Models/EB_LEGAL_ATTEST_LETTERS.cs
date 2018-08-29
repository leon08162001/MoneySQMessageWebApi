using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("EB_LEGAL_ATTEST_LETTERS")]
public class EB_LEGAL_ATTEST_LETTERS
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
    public virtual string legal_attest_letters_no { get; set; }
    [MaxLength(4000)]
    [Required]
    public virtual string content { get; set; }
    [Required]
    public virtual short empolyeeno_of_writer { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string name_of_writer { get; set; }
    [Required]
    public virtual DateTime datetime_of_writing { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string addressor { get; set; }
    [MaxLength(100)]
    [Required]
    public virtual string addressor_job_title { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string mailing_address { get; set; }
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
