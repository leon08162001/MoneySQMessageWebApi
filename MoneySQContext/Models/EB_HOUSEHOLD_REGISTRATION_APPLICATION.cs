using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("EB_HOUSEHOLD_REGISTRATION_APPLICATION")]
public class EB_HOUSEHOLD_REGISTRATION_APPLICATION
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
    public virtual string HRT_application_no { get; set; }
    [Required]
    public virtual DateTime date_of_application { get; set; }
    [MaxLength(100)]
    [Required]
    public virtual string idno_of_applicant { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string name_of_applicant { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string applicant_address { get; set; }
    [MaxLength(50)]
    public virtual string recognizor { get; set; }
    [MaxLength(50)]
    public virtual string head_of_the_household { get; set; }
    [MaxLength(50)]
    public virtual string household_id_number { get; set; }
    [MaxLength(50)]
    [Required]
    public virtual string respondent { get; set; }
    [MaxLength(50)]
    [Required]
    public virtual string respondent_idno { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string respondent_address { get; set; }
    [MaxLength(3)]
    public virtual string apply_item_hrt_current_full_copy { get; set; }
    [MaxLength(3)]
    public virtual string apply_item_hrt_current_partial_copy { get; set; }
    [MaxLength(3)]
    public virtual string apply_item_hrt_cancelled { get; set; }
    [MaxLength(3)]
    public virtual string apply_item_hrt_application_form { get; set; }
    [MaxLength(3)]
    public virtual string apply_item_hrt_read { get; set; }
    [MaxLength(3)]
    public virtual string apply_item_hrt_japanese_occupation_era { get; set; }
    [MaxLength(3)]
    public virtual string apply_item_hrt_other { get; set; }
    [MaxLength(3)]
    public virtual string year_of_hrt_cancelled { get; set; }
    [Required]
    public virtual short copy_of_application { get; set; }
    public virtual short? sheetno_of_application { get; set; }
    [MaxLength(255)]
    public virtual string descrition_of_document_attachment { get; set; }
    [MaxLength(50)]
    [Required]
    public virtual string commissioned_applicant { get; set; }
    [MaxLength(50)]
    [Required]
    public virtual string legal_representative { get; set; }
    [MaxLength(255)]
    [Required]
    public virtual string commissioned_applicant_address { get; set; }
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
