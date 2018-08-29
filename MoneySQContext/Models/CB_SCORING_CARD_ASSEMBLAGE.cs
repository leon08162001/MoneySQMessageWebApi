using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("CB_SCORING_CARD_ASSEMBLAGE")]
public class CB_SCORING_CARD_ASSEMBLAGE
{
    [Key]
    [Column(Order = 1)]
    [MaxLength(10)]
    [Required]
    public virtual string company_code { get; set; }
    [Key]
    [Column(Order = 2)]
    [MaxLength(3)]
    [Required]
    public virtual string scoring_card_version { get; set; }
    [Key]
    [Column(Order = 3)]
    [MaxLength(3)]
    [Required]
    public virtual string scoring_item_code { get; set; }
    [Key]
    [Column(Order = 4)]
    [MaxLength(3)]
    [Required]
    public virtual string scoring_content_code { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string scoring_content { get; set; }
    [Required]
    public virtual short score { get; set; }
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
