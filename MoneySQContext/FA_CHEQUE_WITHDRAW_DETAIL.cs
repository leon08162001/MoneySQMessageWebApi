using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("FA_CHEQUE_WITHDRAW_DETAIL")]
    public class FA_CHEQUE_WITHDRAW_DETAIL
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        public virtual DateTime withdraw_apply_date { get; set; }
        [Key]
        [Column(Order = 3)]
        public virtual short withdraw_apply_batch_no { get; set; }
        [Key]
        [Column(Order = 4)]
        [MaxLength(3)]
        public virtual string bank_code { get; set; }
        [Key]
        [Column(Order = 5)]
        [MaxLength(4)]
        public virtual string bank_branch_code { get; set; }
        [Key]
        [Column(Order = 6)]
        [MaxLength(50)]
        public virtual string cheque_no { get; set; }
        [Key]
        [Column(Order = 7)]
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

        public FA_CHEQUE_WITHDRAW FaChequeWithdraw { get; set; }
        public FA_CHEQUE_WITHDRAW FaChequeWithdraw1 { get; set; }
        public FA_CHEQUE_WITHDRAW FaChequeWithdraw2 { get; set; }
        public FA_CHEQUE FaCheque { get; set; }
        public FA_CHEQUE FaCheque1 { get; set; }
        public FA_CHEQUE FaCheque2 { get; set; }
        public FA_CHEQUE FaCheque3 { get; set; }
    }
}
