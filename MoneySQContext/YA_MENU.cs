using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("YA_MENU")]
    public class YA_MENU
    {
        public YA_MENU()
        {
            this.YaMenuSubs = new List<YA_MENU_SUB>();
            this.YaMenuSubs1 = new List<YA_MENU_SUB>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(20)]
        public virtual string menu_code { get; set; }
        [MaxLength(50)]
        public virtual string menu_name { get; set; }
        [MaxLength(50)]
        public virtual string menu_icon { get; set; }
        public virtual DateTime? enable_date { get; set; }
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

        public JA_COMPANY JaCompany { get; set; }
        public List<YA_MENU_SUB> YaMenuSubs { get; set; }
        public List<YA_MENU_SUB> YaMenuSubs1 { get; set; }
    }
}
