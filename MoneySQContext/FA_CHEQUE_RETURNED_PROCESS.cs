using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("FA_CHEQUE_RETURNED_PROCESS")]
    public class FA_CHEQUE_RETURNED_PROCESS
    {
        public FA_CHEQUE_RETURNED_PROCESS()
        {
            this.FaChequeReturnedProcessDetails = new List<FA_CHEQUE_RETURNED_PROCESS_DETAIL>();
            this.FaChequeReturnedProcessNewchecks = new List<FA_CHEQUE_RETURNED_PROCESS_NEWCHECK>();
            this.FaChequeReturnedProcessVouchers = new List<FA_CHEQUE_RETURNED_PROCESS_VOUCHER>();
            this.FaChequeReturnedProcessDetails1 = new List<FA_CHEQUE_RETURNED_PROCESS_DETAIL>();
            this.FaChequeReturnedProcessNewchecks1 = new List<FA_CHEQUE_RETURNED_PROCESS_NEWCHECK>();
            this.FaChequeReturnedProcessVouchers1 = new List<FA_CHEQUE_RETURNED_PROCESS_VOUCHER>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string return_cheque_process_no { get; set; }
        public virtual DateTime return_cheque_process_date { get; set; }
        public virtual short empolyeeno_of_rcprocess_staff { get; set; }
        [MaxLength(200)]
        public virtual string name_of_rcprocess_staff { get; set; }
        [MaxLength(3)]
        public virtual string same_cheque_mark { get; set; }
        public virtual decimal? cash_amount { get; set; }
        public virtual decimal? total_remittance_amount { get; set; }
        public virtual decimal? total_cheque_amount { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public List<FA_CHEQUE_RETURNED_PROCESS_DETAIL> FaChequeReturnedProcessDetails { get; set; }
        public List<FA_CHEQUE_RETURNED_PROCESS_NEWCHECK> FaChequeReturnedProcessNewchecks { get; set; }
        public List<FA_CHEQUE_RETURNED_PROCESS_VOUCHER> FaChequeReturnedProcessVouchers { get; set; }
        public List<FA_CHEQUE_RETURNED_PROCESS_DETAIL> FaChequeReturnedProcessDetails1 { get; set; }
        public List<FA_CHEQUE_RETURNED_PROCESS_NEWCHECK> FaChequeReturnedProcessNewchecks1 { get; set; }
        public List<FA_CHEQUE_RETURNED_PROCESS_VOUCHER> FaChequeReturnedProcessVouchers1 { get; set; }
    }
}
