using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("JA_DIVISION")]
    public class JA_DIVISION
    {
        public JA_DIVISION()
        {
            this.JaEmpolyees = new List<JA_EMPOLYEE>();
            this.UaScheduleSignSequences = new List<UA_SCHEDULE_SIGN_SEQUENCE>();
            this.YaRoleDivisions = new List<YA_ROLE_DIVISION>();
            this.JaEmpolyees1 = new List<JA_EMPOLYEE>();
            this.UaScheduleSignSequences1 = new List<UA_SCHEDULE_SIGN_SEQUENCE>();
            this.YaRoleDivisions1 = new List<YA_ROLE_DIVISION>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(10)]
        public virtual string division_code { get; set; }
        [MaxLength(255)]
        public virtual string division_name { get; set; }
        public virtual DateTime establish_date { get; set; }
        public virtual DateTime? dissolve_date { get; set; }
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
        public List<JA_EMPOLYEE> JaEmpolyees { get; set; }
        public List<UA_SCHEDULE_SIGN_SEQUENCE> UaScheduleSignSequences { get; set; }
        public List<YA_ROLE_DIVISION> YaRoleDivisions { get; set; }
        public List<JA_EMPOLYEE> JaEmpolyees1 { get; set; }
        public List<UA_SCHEDULE_SIGN_SEQUENCE> UaScheduleSignSequences1 { get; set; }
        public List<YA_ROLE_DIVISION> YaRoleDivisions1 { get; set; }
    }
}
