using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("FA_CHEQUE_RETURNED_PROCESS_VOUCHER")]
    public class FA_CHEQUE_RETURNED_PROCESS_VOUCHER
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string return_cheque_process_no { get; set; }
        [Key]
        [Column(Order = 3)]
        public virtual DateTime voucher_date { get; set; }
        [Key]
        [Column(Order = 4)]
        public virtual short voucher_no { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public FA_CHEQUE_RETURNED_PROCESS FaChequeReturnedProcess { get; set; }
        public GA_VOUCHER_CONTROL GaVoucherControl { get; set; }
        public FA_CHEQUE_RETURNED_PROCESS FaChequeReturnedProcess1 { get; set; }
        public GA_VOUCHER_CONTROL GaVoucherControl1 { get; set; }
        public GA_VOUCHER_CONTROL GaVoucherControl2 { get; set; }
    }
}
