using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("FD_INVOICE_CONTROL")]
public class FD_INVOICE_CONTROL
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
    public virtual string invoice_no { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string status_of_invoice { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string payment_request_category { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string reason_for_apply { get; set; }
    [Required]
    public virtual short employeeno_of_applicant { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string name_of_applicant { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string currency_type { get; set; }
    [Required]
    public virtual decimal total_amount { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string basis_of_payment { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string payee { get; set; }
    [Required]
    public virtual DateTime schedule_payment_date { get; set; }
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
    [MaxLength(3)]
    public virtual string beneficiary_bankcode { get; set; }
    [MaxLength(7)]
    public virtual string beneficiary_bankbranchcode { get; set; }
    [MaxLength(50)]
    public virtual string beneficiary_account { get; set; }
    [MaxLength(100)]
    public virtual string beneficiary_account_name { get; set; }
    [MaxLength(50)]
    public virtual string beneficiary_id { get; set; }
}
