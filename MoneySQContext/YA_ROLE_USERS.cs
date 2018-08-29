using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("YA_ROLE_USERS")]
    public class YA_ROLE_USERS
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(10)]
        public virtual string role_id { get; set; }
        [Key]
        [Column(Order = 3)]
        public virtual short empolyee_no { get; set; }
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

        public YA_ROLES YaRole { get; set; }
        public YA_ROLES YaRole1 { get; set; }
    }
}
