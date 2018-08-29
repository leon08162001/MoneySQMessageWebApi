using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("refinanceAttachmentLog")]
    public class refinanceAttachmentLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual decimal pk { get; set; }
        [MaxLength(10)]
        public virtual string userAction { get; set; }
        [MaxLength(200)]
        public virtual string docName { get; set; }
        [MaxLength(20)]
        public virtual string lst_upd_user { get; set; }
        public virtual DateTime? lst_upd_date { get; set; }
    }
}
