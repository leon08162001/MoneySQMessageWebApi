using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("FA_CHEQUE")]
    public class FA_CHEQUE
    {
        public FA_CHEQUE()
        {
            this.DaContractCheques = new List<DA_CONTRACT_CHEQUE>();
            this.FaChequeCollectionDetails = new List<FA_CHEQUE_COLLECTION_DETAIL>();
            this.FaChequeReturnedProcessDetails = new List<FA_CHEQUE_RETURNED_PROCESS_DETAIL>();
            this.FaChequeReturnedProcessNewchecks = new List<FA_CHEQUE_RETURNED_PROCESS_NEWCHECK>();
            this.FaChequeWithdrawDetails = new List<FA_CHEQUE_WITHDRAW_DETAIL>();
            this.DaContractCheques1 = new List<DA_CONTRACT_CHEQUE>();
            this.FaChequeCollectionDetails1 = new List<FA_CHEQUE_COLLECTION_DETAIL>();
            this.FaChequeReturnedProcessDetails1 = new List<FA_CHEQUE_RETURNED_PROCESS_DETAIL>();
            this.FaChequeReturnedProcessNewchecks1 = new List<FA_CHEQUE_RETURNED_PROCESS_NEWCHECK>();
            this.FaChequeWithdrawDetails1 = new List<FA_CHEQUE_WITHDRAW_DETAIL>();
            this.DaContractCheques2 = new List<DA_CONTRACT_CHEQUE>();
            this.FaChequeCollectionDetails2 = new List<FA_CHEQUE_COLLECTION_DETAIL>();
            this.FaChequeReturnedProcessDetails2 = new List<FA_CHEQUE_RETURNED_PROCESS_DETAIL>();
            this.FaChequeReturnedProcessNewchecks2 = new List<FA_CHEQUE_RETURNED_PROCESS_NEWCHECK>();
            this.FaChequeWithdrawDetails2 = new List<FA_CHEQUE_WITHDRAW_DETAIL>();
            this.DaContractCheques3 = new List<DA_CONTRACT_CHEQUE>();
            this.FaChequeCollectionDetails3 = new List<FA_CHEQUE_COLLECTION_DETAIL>();
            this.FaChequeReturnedProcessDetails3 = new List<FA_CHEQUE_RETURNED_PROCESS_DETAIL>();
            this.FaChequeReturnedProcessNewchecks3 = new List<FA_CHEQUE_RETURNED_PROCESS_NEWCHECK>();
            this.FaChequeWithdrawDetails3 = new List<FA_CHEQUE_WITHDRAW_DETAIL>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(3)]
        public virtual string bank_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(4)]
        public virtual string bank_branch_code { get; set; }
        [Key]
        [Column(Order = 3)]
        [MaxLength(50)]
        public virtual string cheque_no { get; set; }
        [Key]
        [Column(Order = 4)]
        public virtual DateTime cheque_received_date { get; set; }
        [MaxLength(3)]
        public virtual string cheque_status { get; set; }
        public virtual DateTime cheque_date { get; set; }
        public virtual decimal amount_in_figures { get; set; }
        [MaxLength(255)]
        public virtual string amount_in_words { get; set; }
        [MaxLength(255)]
        public virtual string payee_on_cheque { get; set; }
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [MaxLength(255)]
        public virtual string bank_branch_name { get; set; }
        public virtual int attachment_id { get; set; }
        public virtual DateTime? cash_date { get; set; }
        [MaxLength(3)]
        public virtual string cheque_location { get; set; }
        public virtual DateTime? cheque_return_date { get; set; }
        [MaxLength(3)]
        public virtual string cheque_return_reason_code { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public XZ_ATTACHMENT XzAttachment { get; set; }
        public XZ_ATTACHMENT XzAttachment1 { get; set; }
        public List<DA_CONTRACT_CHEQUE> DaContractCheques { get; set; }
        public List<FA_CHEQUE_COLLECTION_DETAIL> FaChequeCollectionDetails { get; set; }
        public List<FA_CHEQUE_RETURNED_PROCESS_DETAIL> FaChequeReturnedProcessDetails { get; set; }
        public List<FA_CHEQUE_RETURNED_PROCESS_NEWCHECK> FaChequeReturnedProcessNewchecks { get; set; }
        public List<FA_CHEQUE_WITHDRAW_DETAIL> FaChequeWithdrawDetails { get; set; }
        public List<DA_CONTRACT_CHEQUE> DaContractCheques1 { get; set; }
        public List<FA_CHEQUE_COLLECTION_DETAIL> FaChequeCollectionDetails1 { get; set; }
        public List<FA_CHEQUE_RETURNED_PROCESS_DETAIL> FaChequeReturnedProcessDetails1 { get; set; }
        public List<FA_CHEQUE_RETURNED_PROCESS_NEWCHECK> FaChequeReturnedProcessNewchecks1 { get; set; }
        public List<FA_CHEQUE_WITHDRAW_DETAIL> FaChequeWithdrawDetails1 { get; set; }
        public List<DA_CONTRACT_CHEQUE> DaContractCheques2 { get; set; }
        public List<FA_CHEQUE_COLLECTION_DETAIL> FaChequeCollectionDetails2 { get; set; }
        public List<FA_CHEQUE_RETURNED_PROCESS_DETAIL> FaChequeReturnedProcessDetails2 { get; set; }
        public List<FA_CHEQUE_RETURNED_PROCESS_NEWCHECK> FaChequeReturnedProcessNewchecks2 { get; set; }
        public List<FA_CHEQUE_WITHDRAW_DETAIL> FaChequeWithdrawDetails2 { get; set; }
        public List<DA_CONTRACT_CHEQUE> DaContractCheques3 { get; set; }
        public List<FA_CHEQUE_COLLECTION_DETAIL> FaChequeCollectionDetails3 { get; set; }
        public List<FA_CHEQUE_RETURNED_PROCESS_DETAIL> FaChequeReturnedProcessDetails3 { get; set; }
        public List<FA_CHEQUE_RETURNED_PROCESS_NEWCHECK> FaChequeReturnedProcessNewchecks3 { get; set; }
        public List<FA_CHEQUE_WITHDRAW_DETAIL> FaChequeWithdrawDetails3 { get; set; }
    }
}
