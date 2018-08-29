using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("followup_issues")]
    public class followup_issues
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual decimal pk { get; set; }
        [MaxLength(20)]
        public virtual string loan_id { get; set; }
        public virtual int? status_id { get; set; }
        [MaxLength(20)]
        public virtual string cs_officer { get; set; }
        [MaxLength(20)]
        public virtual string cr_officer { get; set; }
        public virtual DateTime? sign_date { get; set; }
        [MaxLength(20)]
        public virtual string cusName { get; set; }
        [MaxLength(20)]
        public virtual string tel { get; set; }
        public virtual DateTime? telCheckDate { get; set; }
        [MaxLength(4)]
        public virtual string telCheckTime { get; set; }
        [MaxLength(10)]
        public virtual string priority { get; set; }
        public virtual DateTime? received_date { get; set; }
        public virtual DateTime? completed_date { get; set; }
        [MaxLength(20)]
        public virtual string byCR { get; set; }
        [MaxLength(20)]
        public virtual string byCS { get; set; }
        [MaxLength(20)]
        public virtual string byLR { get; set; }
    }
}
