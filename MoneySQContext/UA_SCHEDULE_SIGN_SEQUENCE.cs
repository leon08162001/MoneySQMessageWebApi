using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("UA_SCHEDULE_SIGN_SEQUENCE")]
    public class UA_SCHEDULE_SIGN_SEQUENCE
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string sign_flow_code { get; set; }
        [Key]
        [Column(Order = 3)]
        public virtual short sign_serial_no { get; set; }
        [MaxLength(3)]
        public virtual string method_of_approvement { get; set; }
        [MaxLength(3)]
        public virtual string mark_of_ruling_manager { get; set; }
        [MaxLength(10)]
        public virtual string scheduled_sign_division_code { get; set; }
        [MaxLength(10)]
        public virtual string scheduled_sign_role_id { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public JA_DIVISION JaDivision { get; set; }
        public UA_SIGN_FLOW UaSignFlow { get; set; }
        public YA_ROLES YaRole { get; set; }
        public UA_SIGN_FLOW UaSignFlow1 { get; set; }
        public JA_DIVISION ScheduledSign { get; set; }
        public YA_ROLES ScheduledSign1 { get; set; }
    }
}
