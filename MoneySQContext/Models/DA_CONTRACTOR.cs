using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("DA_CONTRACTOR")]
public class DA_CONTRACTOR
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
    public virtual string contract_number { get; set; }
    [Key]
    [Column(Order = 3)]
    [MaxLength(50)]
    [Required]
    public virtual string contractor_idno { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string contractor_name { get; set; }
    [MaxLength(3)]
    [Required]
    public virtual string contractor_identity { get; set; }
    [MaxLength(100)]
    public virtual string deputy_idno { get; set; }
    [MaxLength(255)]
    public virtual string deputy_name { get; set; }
    [MaxLength(100)]
    public virtual string representative_idno { get; set; }
    [MaxLength(255)]
    public virtual string representative_name { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string permanent_address { get; set; }
    [MaxLength(40)]
    [Required]
    public virtual string cell_phone { get; set; }
    [MaxLength(40)]
    [Required]
    public virtual string home_phone_no { get; set; }
    [MaxLength(40)]
    public virtual string office_phone_no { get; set; }
    [MaxLength(10)]
    public virtual string office_phone_extension { get; set; }
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
    [MaxLength(255)]
    public virtual string email { get; set; }
}
