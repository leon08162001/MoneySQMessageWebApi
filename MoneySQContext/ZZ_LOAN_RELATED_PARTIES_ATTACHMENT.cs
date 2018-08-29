using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("ZZ_LOAN_RELATED_PARTIES_ATTACHMENT")]
    public class ZZ_LOAN_RELATED_PARTIES_ATTACHMENT
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string application_no { get; set; }
        [Key]
        [Column(Order = 3)]
        [MaxLength(50)]
        public virtual string social_security_number { get; set; }
        [Key]
        [Column(Order = 4)]
        public virtual int attachment_id { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public ZZ_LOAN_RELATED_PARTIES ZzLoanRelatedParty { get; set; }
        public XZ_ATTACHMENT XzAttachment { get; set; }
        public ZZ_LOAN_RELATED_PARTIES ZzLoanRelatedParty1 { get; set; }
        public ZZ_LOAN_RELATED_PARTIES ZzLoanRelatedParty2 { get; set; }
        public XZ_ATTACHMENT XzAttachment1 { get; set; }
    }
}
