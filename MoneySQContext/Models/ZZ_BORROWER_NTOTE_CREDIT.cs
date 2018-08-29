using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ZZ_BORROWER_NTOTE_CREDIT")]
public class ZZ_BORROWER_NTOTE_CREDIT
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
    public virtual string application_no { get; set; }
    [Key]
    [Column(Order = 3)]
    [MaxLength(50)]
    [Required]
    public virtual string account_no { get; set; }
    [Key]
    [Column(Order = 4)]
    [Required]
    public virtual DateTime query_date { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string account_name { get; set; }
    [Required]
    public virtual DateTime data_dealine { get; set; }
    [MaxLength(100)]
    public virtual string rp_account_no { get; set; }
    [MaxLength(10)]
    public virtual string note_bank_code { get; set; }
    [MaxLength(100)]
    public virtual string note_bank_account { get; set; }
    [MaxLength(2000)]
    public virtual string dishonored_account_info { get; set; }
    [MaxLength(2000)]
    public virtual string drawee_for_cashier_order { get; set; }
    public virtual short? total_account_amt { get; set; }
    [MaxLength(2000)]
    public virtual string other_material_info { get; set; }
    [MaxLength(2000)]
    public virtual string related_parties_info { get; set; }
    public virtual int? attachment_id { get; set; }
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
