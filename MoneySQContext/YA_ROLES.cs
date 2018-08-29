using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("YA_ROLES")]
    public class YA_ROLES
    {
        public YA_ROLES()
        {
            this.UaScheduleSignSequences = new List<UA_SCHEDULE_SIGN_SEQUENCE>();
            this.YaRoleDivisions = new List<YA_ROLE_DIVISION>();
            this.YaRoleFunctions = new List<YA_ROLE_FUNCTIONS>();
            this.YaRoleUsers = new List<YA_ROLE_USERS>();
            this.UaScheduleSignSequences1 = new List<UA_SCHEDULE_SIGN_SEQUENCE>();
            this.YaRoleDivisions1 = new List<YA_ROLE_DIVISION>();
            this.YaRoleFunctions1 = new List<YA_ROLE_FUNCTIONS>();
            this.YaRoleUsers1 = new List<YA_ROLE_USERS>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(10)]
        public virtual string role_id { get; set; }
        [MaxLength(50)]
        public virtual string role_name { get; set; }
        [MaxLength(3)]
        public virtual string role_category { get; set; }
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

        public List<UA_SCHEDULE_SIGN_SEQUENCE> UaScheduleSignSequences { get; set; }
        public List<YA_ROLE_DIVISION> YaRoleDivisions { get; set; }
        public List<YA_ROLE_FUNCTIONS> YaRoleFunctions { get; set; }
        public List<YA_ROLE_USERS> YaRoleUsers { get; set; }
        public List<UA_SCHEDULE_SIGN_SEQUENCE> UaScheduleSignSequences1 { get; set; }
        public List<YA_ROLE_DIVISION> YaRoleDivisions1 { get; set; }
        public List<YA_ROLE_FUNCTIONS> YaRoleFunctions1 { get; set; }
        public List<YA_ROLE_USERS> YaRoleUsers1 { get; set; }
    }
}
