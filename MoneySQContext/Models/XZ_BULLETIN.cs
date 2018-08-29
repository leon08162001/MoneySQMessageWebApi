using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("XZ_BULLETIN")]
public class XZ_BULLETIN
{
    [Key]
    [Column(Order = 1)]
    [MaxLength(10)]
    [Required]
    public virtual string company_code { get; set; }
    [Key]
    [Column(Order = 2)]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Required]
    public virtual int bulletin_id { get; set; }
    [MaxLength(4000)]
    [Required]
    public virtual string bulletin_content { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string annoucement_division { get; set; }
    [MaxLength(50)]
    [Required]
    public virtual string annoucement_empolyee_id { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string annoucement_empolyee_name { get; set; }
    [Required]
    public virtual DateTime create_date { get; set; }
    [Required]
    public virtual DateTime annoucemenyt_start_datetime { get; set; }
    [Required]
    public virtual DateTime annoucemenyt_end_datetime { get; set; }
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
