using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("GA_VOUCHER_CONTROL")]
    public class GA_VOUCHER_CONTROL
    {
        public GA_VOUCHER_CONTROL()
        {
            this.DaContractAmortizationDetailsVouchers = new List<DA_CONTRACT_AMORTIZATION_DETAILS_VOUCHER>();
            this.DaContractRepaymentDetailsVouchers = new List<DA_CONTRACT_REPAYMENT_DETAILS_VOUCHER>();
            this.WrittenBy = new List<DA_DEBIT_NOTE_WRITE_OFF>();
            this.FaChequeCollections = new List<FA_CHEQUE_COLLECTION>();
            this.FaChequeReturnedProcessVouchers = new List<FA_CHEQUE_RETURNED_PROCESS_VOUCHER>();
            this.FdInvoiceVouchers = new List<FD_INVOICE_VOUCHER>();
            this.GaVoucherContents = new List<GA_VOUCHER_CONTENT>();
            this.DaContractAmortizationDetailsVouchers1 = new List<DA_CONTRACT_AMORTIZATION_DETAILS_VOUCHER>();
            this.DaContractRepaymentDetailsVouchers1 = new List<DA_CONTRACT_REPAYMENT_DETAILS_VOUCHER>();
            this.WrittenBy1 = new List<DA_DEBIT_NOTE_WRITE_OFF>();
            this.FaChequeCollections1 = new List<FA_CHEQUE_COLLECTION>();
            this.FaChequeReturnedProcessVouchers1 = new List<FA_CHEQUE_RETURNED_PROCESS_VOUCHER>();
            this.FdInvoiceVouchers1 = new List<FD_INVOICE_VOUCHER>();
            this.GaVoucherContents1 = new List<GA_VOUCHER_CONTENT>();
            this.DaContractAmortizationDetailsVouchers2 = new List<DA_CONTRACT_AMORTIZATION_DETAILS_VOUCHER>();
            this.DaContractRepaymentDetailsVouchers2 = new List<DA_CONTRACT_REPAYMENT_DETAILS_VOUCHER>();
            this.WrittenBy2 = new List<DA_DEBIT_NOTE_WRITE_OFF>();
            this.FaChequeCollections2 = new List<FA_CHEQUE_COLLECTION>();
            this.FaChequeReturnedProcessVouchers2 = new List<FA_CHEQUE_RETURNED_PROCESS_VOUCHER>();
            this.FdInvoiceVouchers2 = new List<FD_INVOICE_VOUCHER>();
            this.GaVoucherContents2 = new List<GA_VOUCHER_CONTENT>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        public virtual DateTime voucher_date { get; set; }
        [Key]
        [Column(Order = 3)]
        public virtual short voucher_no { get; set; }
        [MaxLength(3)]
        public virtual string voucher_status { get; set; }
        [MaxLength(3)]
        public virtual string voucher_category { get; set; }
        [MaxLength(1000)]
        public virtual string voucher_memo { get; set; }
        public virtual short empolyeeno_of_keep_account { get; set; }
        [MaxLength(255)]
        public virtual string name_of_keep_account { get; set; }
        public virtual DateTime datetime_of_keep_account { get; set; }
        public virtual short? empolyeeno_of_confirmation { get; set; }
        [MaxLength(255)]
        public virtual string name_of_confirmation { get; set; }
        public virtual DateTime? datetime_of_confirmation { get; set; }
        [MaxLength(3)]
        public virtual string currency_type { get; set; }
        public virtual decimal total_debit_amount { get; set; }
        public virtual decimal total_credit_ampunt { get; set; }
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
        public List<DA_CONTRACT_AMORTIZATION_DETAILS_VOUCHER> DaContractAmortizationDetailsVouchers { get; set; }
        public List<DA_CONTRACT_REPAYMENT_DETAILS_VOUCHER> DaContractRepaymentDetailsVouchers { get; set; }
        public List<DA_DEBIT_NOTE_WRITE_OFF> WrittenBy { get; set; }
        public List<FA_CHEQUE_COLLECTION> FaChequeCollections { get; set; }
        public List<FA_CHEQUE_RETURNED_PROCESS_VOUCHER> FaChequeReturnedProcessVouchers { get; set; }
        public List<FD_INVOICE_VOUCHER> FdInvoiceVouchers { get; set; }
        public List<GA_VOUCHER_CONTENT> GaVoucherContents { get; set; }
        public List<DA_CONTRACT_AMORTIZATION_DETAILS_VOUCHER> DaContractAmortizationDetailsVouchers1 { get; set; }
        public List<DA_CONTRACT_REPAYMENT_DETAILS_VOUCHER> DaContractRepaymentDetailsVouchers1 { get; set; }
        public List<DA_DEBIT_NOTE_WRITE_OFF> WrittenBy1 { get; set; }
        public List<FA_CHEQUE_COLLECTION> FaChequeCollections1 { get; set; }
        public List<FA_CHEQUE_RETURNED_PROCESS_VOUCHER> FaChequeReturnedProcessVouchers1 { get; set; }
        public List<FD_INVOICE_VOUCHER> FdInvoiceVouchers1 { get; set; }
        public List<GA_VOUCHER_CONTENT> GaVoucherContents1 { get; set; }
        public List<DA_CONTRACT_AMORTIZATION_DETAILS_VOUCHER> DaContractAmortizationDetailsVouchers2 { get; set; }
        public List<DA_CONTRACT_REPAYMENT_DETAILS_VOUCHER> DaContractRepaymentDetailsVouchers2 { get; set; }
        public List<DA_DEBIT_NOTE_WRITE_OFF> WrittenBy2 { get; set; }
        public List<FA_CHEQUE_COLLECTION> FaChequeCollections2 { get; set; }
        public List<FA_CHEQUE_RETURNED_PROCESS_VOUCHER> FaChequeReturnedProcessVouchers2 { get; set; }
        public List<FD_INVOICE_VOUCHER> FdInvoiceVouchers2 { get; set; }
        public List<GA_VOUCHER_CONTENT> GaVoucherContents2 { get; set; }
    }
}
