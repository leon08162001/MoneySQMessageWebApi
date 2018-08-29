using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("DA_CONTRACT_CHEQUE")]
    public class DA_CONTRACT_CHEQUE
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
        [MaxLength(3)]
        public virtual string bank_code { get; set; }
        [Key]
        [Column(Order = 4)]
        [MaxLength(4)]
        public virtual string bank_branch_code { get; set; }
        [Key]
        [Column(Order = 5)]
        [MaxLength(50)]
        public virtual string cheque_no { get; set; }
        [Key]
        [Column(Order = 6)]
        public virtual DateTime cheque_received_date { get; set; }
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
        public FA_CHEQUE FaCheque { get; set; }
        public FA_CHEQUE FaCheque1 { get; set; }
        public FA_CHEQUE FaCheque2 { get; set; }
        public FA_CHEQUE FaCheque3 { get; set; }
    }
}
