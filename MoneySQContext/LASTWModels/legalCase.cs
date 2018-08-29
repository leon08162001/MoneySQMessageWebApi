using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("legalCase")]
    public class legalCase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual int pk { get; set; }
        [MaxLength(20)]
        public virtual string refno { get; set; }
        [MaxLength(20)]
        public virtual string loan_id { get; set; }
        public virtual int? status_id { get; set; }
        [MaxLength(20)]
        public virtual string staff { get; set; }
        public virtual DateTime? deadline { get; set; }
        [MaxLength(20)]
        public virtual string review { get; set; }
        [MaxLength(1)]
        public virtual string discussion { get; set; }
        public virtual int? solicitor_pk { get; set; }
        [MaxLength(20)]
        public virtual string read_by_ld { get; set; }
        public virtual DateTime? read_by_ld_date { get; set; }
        [MaxLength(20)]
        public virtual string assigned_to_ld { get; set; }
        [MaxLength(20)]
        public virtual string read_by_cr { get; set; }
        public virtual DateTime? read_by_cr_date { get; set; }
        [MaxLength(20)]
        public virtual string assigned_to_cr { get; set; }
        [MaxLength(20)]
        public virtual string read_by_ed { get; set; }
        public virtual DateTime? read_by_ed_date { get; set; }
        [MaxLength(200)]
        public virtual string remarks { get; set; }
        [MaxLength(200)]
        public virtual string cr_remarks { get; set; }
        public virtual bool? checked_by_cr { get; set; }
        public virtual bool? checked_by_cr_ass { get; set; }
        [MaxLength(200)]
        public virtual string cr_reply { get; set; }
        [MaxLength(1)]
        public virtual string is_registered { get; set; }
        [MaxLength(1)]
        public virtual string is_instrucLetter { get; set; }
        public virtual DateTime? reg_bill_date { get; set; }
        public virtual DateTime? instrucLetter_date { get; set; }
        public virtual bool? checked_by_ld { get; set; }
        [MaxLength(200)]
        public virtual string instruction_letters { get; set; }
        public virtual bool? is_LMSupdated { get; set; }
        [MaxLength(20)]
        public virtual string created_by { get; set; }
        public virtual DateTime? created_date { get; set; }
        public virtual int? unpaid_period { get; set; }
    }
}
