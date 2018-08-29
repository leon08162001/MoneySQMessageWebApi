using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("EB_FORECLOSURE_EVALUATION_ATTACHMENT")]
    public class EB_FORECLOSURE_EVALUATION_ATTACHMENT
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string foreclosure_evaluation_no { get; set; }
        [Key]
        [Column(Order = 3)]
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

        public EB_FORECLOSURE_EVALUATION EbForeclosureEvaluation { get; set; }
        public XZ_ATTACHMENT XzAttachment { get; set; }
        public EB_FORECLOSURE_EVALUATION EbForeclosureEvaluation1 { get; set; }
        public XZ_ATTACHMENT XzAttachment1 { get; set; }
    }
}
