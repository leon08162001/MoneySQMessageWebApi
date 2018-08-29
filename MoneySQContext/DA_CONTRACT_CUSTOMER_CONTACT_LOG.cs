using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("DA_CONTRACT_CUSTOMER_CONTACT_LOG")]
    public class DA_CONTRACT_CUSTOMER_CONTACT_LOG
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
        public virtual DateTime contact_datetime { get; set; }
        [MaxLength(100)]
        public virtual string contact_person { get; set; }
        [MaxLength(1200)]
        public virtual string contact_content { get; set; }
        public virtual short record_keyin_empolyeeno { get; set; }
        [MaxLength(100)]
        public virtual string record_keyin_person { get; set; }
        public virtual DateTime record_keyin_datetime { get; set; }
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
