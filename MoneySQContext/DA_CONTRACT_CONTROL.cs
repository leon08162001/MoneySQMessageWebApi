using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("DA_CONTRACT_CONTROL")]
    public class DA_CONTRACT_CONTROL
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string contract_number { get; set; }
        [Key]
        [Column(Order = 3)]
        public virtual short check_item_no { get; set; }
        [MaxLength(255)]
        public virtual string check_item { get; set; }
        [MaxLength(2000)]
        public virtual string check_points { get; set; }
        [MaxLength(3)]
        public virtual string check_necessity_mark { get; set; }
        public virtual short? check_staff_employeeno { get; set; }
        [MaxLength(255)]
        public virtual string check_staff_name { get; set; }
        public virtual DateTime? check_datetime { get; set; }
        [MaxLength(3)]
        public virtual string contract_suspend_mark { get; set; }
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
