using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("JA_EMPOLYEE_LEAVE")]
    public class JA_EMPOLYEE_LEAVE
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        public virtual short empolyee_no { get; set; }
        [Key]
        [Column(Order = 3)]
        public virtual DateTime calendar_date { get; set; }
        [Key]
        [Column(Order = 4)]
        public virtual TimeSpan start_time { get; set; }
        public virtual TimeSpan? end_time { get; set; }
        public virtual decimal? total_days { get; set; }
        [MaxLength(3)]
        public virtual string leave_code { get; set; }
        [MaxLength(255)]
        public virtual string leave_reason { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public JA_LEAVE JaLeave { get; set; }
        public JA_LEAVE JaLeave1 { get; set; }
    }
}
