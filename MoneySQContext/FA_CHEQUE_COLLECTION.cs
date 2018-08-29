using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("FA_CHEQUE_COLLECTION")]
    public class FA_CHEQUE_COLLECTION
    {
        public FA_CHEQUE_COLLECTION()
        {
            this.FaChequeCollectionDetails = new List<FA_CHEQUE_COLLECTION_DETAIL>();
            this.FaChequeCollectionDetails1 = new List<FA_CHEQUE_COLLECTION_DETAIL>();
            this.FaChequeCollectionDetails2 = new List<FA_CHEQUE_COLLECTION_DETAIL>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        public virtual DateTime collection_date { get; set; }
        [Key]
        [Column(Order = 3)]
        public virtual short collection_batch_no { get; set; }
        [MaxLength(3)]
        public virtual string collection_bank_code { get; set; }
        [MaxLength(4)]
        public virtual string collection_bankbranch_code { get; set; }
        [MaxLength(50)]
        public virtual string collection_account { get; set; }
        public virtual short empolyeeno_of_collection_staff { get; set; }
        [MaxLength(200)]
        public virtual string name_of_collection_staff { get; set; }
        public virtual DateTime voucher_date { get; set; }
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

        public GA_VOUCHER_CONTROL GaVoucherControl { get; set; }
        public GA_VOUCHER_CONTROL GaVoucherControl1 { get; set; }
        public GA_VOUCHER_CONTROL GaVoucherControl2 { get; set; }
        public List<FA_CHEQUE_COLLECTION_DETAIL> FaChequeCollectionDetails { get; set; }
        public List<FA_CHEQUE_COLLECTION_DETAIL> FaChequeCollectionDetails1 { get; set; }
        public List<FA_CHEQUE_COLLECTION_DETAIL> FaChequeCollectionDetails2 { get; set; }
    }
}
