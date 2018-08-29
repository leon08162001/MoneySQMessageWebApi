using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("JA_DATEBOOK")]
    public class JA_DATEBOOK
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
        public virtual DateTime schedule_date { get; set; }
        [Key]
        [Column(Order = 4)]
        public virtual short schedule_start_time { get; set; }
        public virtual short schedule_end_time { get; set; }
        [MaxLength(3)]
        public virtual string date_status { get; set; }
        [MaxLength(50)]
        public virtual string contract_number { get; set; }
        [MaxLength(255)]
        public virtual string date_name { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public DA_CONTRACT DaContract { get; set; }
        public DA_CONTRACT DaContract1 { get; set; }
    }
}
