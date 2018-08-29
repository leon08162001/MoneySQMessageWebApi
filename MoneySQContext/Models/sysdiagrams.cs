using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("sysdiagrams")]
public class sysdiagrams
{
    [MaxLength(128)]
    [Required]
    public virtual string name { get; set; }
    [Required]
    public virtual int principal_id { get; set; }
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Required]
    public virtual int diagram_id { get; set; }
    public virtual int? version { get; set; }
    [MaxLength]
    public virtual byte[] definition { get; set; }
}
