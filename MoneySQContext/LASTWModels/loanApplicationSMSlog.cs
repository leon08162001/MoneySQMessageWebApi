using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("loanApplicationSMSlog")]
    public class loanApplicationSMSlog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual decimal sms_pk { get; set; }
        [MaxLength(8)]
        public virtual string order_nbr { get; set; }
        [MaxLength(10)]
        public virtual string mobile { get; set; }
        [MaxLength(20)]
        public virtual string user_id { get; set; }
        [MaxLength(100)]
        public virtual string sms_content { get; set; }
        public virtual DateTime? smsDate { get; set; }
    }
}
