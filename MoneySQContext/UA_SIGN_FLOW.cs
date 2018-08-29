using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("UA_SIGN_FLOW")]
    public class UA_SIGN_FLOW
    {
        public UA_SIGN_FLOW()
        {
            this.UaScheduleSignSequences = new List<UA_SCHEDULE_SIGN_SEQUENCE>();
            this.UaScheduleSignSequences1 = new List<UA_SCHEDULE_SIGN_SEQUENCE>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string sign_flow_code { get; set; }
        [MaxLength(255)]
        public virtual string sign_flow_name { get; set; }
        [MaxLength(3)]
        public virtual string status { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public JA_COMPANY JaCompany { get; set; }
        public List<UA_SCHEDULE_SIGN_SEQUENCE> UaScheduleSignSequences { get; set; }
        public List<UA_SCHEDULE_SIGN_SEQUENCE> UaScheduleSignSequences1 { get; set; }
    }
}
