using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("JA_LEAVE")]
    public class JA_LEAVE
    {
        public JA_LEAVE()
        {
            this.JaEmpolyeeLeaves = new List<JA_EMPOLYEE_LEAVE>();
            this.JaEmpolyeeLeaves1 = new List<JA_EMPOLYEE_LEAVE>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(3)]
        public virtual string leave_code { get; set; }
        [MaxLength(50)]
        public virtual string leave_name { get; set; }
        public virtual DateTime enable_date { get; set; }
        public virtual DateTime? disable_date { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public List<JA_EMPOLYEE_LEAVE> JaEmpolyeeLeaves { get; set; }
        public List<JA_EMPOLYEE_LEAVE> JaEmpolyeeLeaves1 { get; set; }
    }
}
