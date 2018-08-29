using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("FA_CHEQUE_WITHDRAW")]
    public class FA_CHEQUE_WITHDRAW
    {
        public FA_CHEQUE_WITHDRAW()
        {
            this.FaChequeWithdrawDetails = new List<FA_CHEQUE_WITHDRAW_DETAIL>();
            this.FaChequeWithdrawDetails1 = new List<FA_CHEQUE_WITHDRAW_DETAIL>();
            this.FaChequeWithdrawDetails2 = new List<FA_CHEQUE_WITHDRAW_DETAIL>();
        }

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
        public virtual short empolyeeno_of_withdraw_staff { get; set; }
        [MaxLength(200)]
        public virtual string name_of_withdraw_staff { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public List<FA_CHEQUE_WITHDRAW_DETAIL> FaChequeWithdrawDetails { get; set; }
        public List<FA_CHEQUE_WITHDRAW_DETAIL> FaChequeWithdrawDetails1 { get; set; }
        public List<FA_CHEQUE_WITHDRAW_DETAIL> FaChequeWithdrawDetails2 { get; set; }
    }
}
