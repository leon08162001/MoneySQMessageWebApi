using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("JA_JOB_TILE")]
    public class JA_JOB_TILE
    {
        public JA_JOB_TILE()
        {
            this.JaEmpolyees = new List<JA_EMPOLYEE>();
            this.JaEmpolyees1 = new List<JA_EMPOLYEE>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(3)]
        public virtual string job_title_code { get; set; }
        [MaxLength(255)]
        public virtual string job_title { get; set; }
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
        public List<JA_EMPOLYEE> JaEmpolyees1 { get; set; }
    }
}
