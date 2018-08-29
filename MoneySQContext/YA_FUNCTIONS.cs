using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("YA_FUNCTIONS")]
    public class YA_FUNCTIONS
    {
        public YA_FUNCTIONS()
        {
            this.YaMenuSubs = new List<YA_MENU_SUB>();
            this.YaRoleFunctions = new List<YA_ROLE_FUNCTIONS>();
            this.YaMenuSubs1 = new List<YA_MENU_SUB>();
            this.YaRoleFunctions1 = new List<YA_ROLE_FUNCTIONS>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(35)]
        public virtual string function_code { get; set; }
        [MaxLength(50)]
        public virtual string function_name { get; set; }
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

        public List<YA_MENU_SUB> YaMenuSubs { get; set; }
        public List<YA_ROLE_FUNCTIONS> YaRoleFunctions { get; set; }
        public List<YA_MENU_SUB> YaMenuSubs1 { get; set; }
        public List<YA_ROLE_FUNCTIONS> YaRoleFunctions1 { get; set; }
    }
}
