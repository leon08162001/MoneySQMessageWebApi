using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("FD_INVOICE_CONTROL")]
    public class FD_INVOICE_CONTROL
    {
        public FD_INVOICE_CONTROL()
        {
            this.EbHouseholdRegistrationApplicationInvoices = new List<EB_HOUSEHOLD_REGISTRATION_APPLICATION_INVOICE>();
            this.EbLegalAttestInvoices = new List<EB_LEGAL_ATTEST_INVOICE>();
            this.EbTaxationInformationApplicationInvoices = new List<EB_TAXATION_INFORMATION_APPLICATION_INVOICE>();
            this.FdInvoiceDetails = new List<FD_INVOICE_DETAIL>();
            this.FdInvoiceVouchers = new List<FD_INVOICE_VOUCHER>();
            this.EbHouseholdRegistrationApplicationInvoices1 = new List<EB_HOUSEHOLD_REGISTRATION_APPLICATION_INVOICE>();
            this.EbLegalAttestInvoices1 = new List<EB_LEGAL_ATTEST_INVOICE>();
            this.EbTaxationInformationApplicationInvoices1 = new List<EB_TAXATION_INFORMATION_APPLICATION_INVOICE>();
            this.FdInvoiceDetails1 = new List<FD_INVOICE_DETAIL>();
            this.FdInvoiceVouchers1 = new List<FD_INVOICE_VOUCHER>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string invoice_no { get; set; }
        [MaxLength(3)]
        public virtual string status_of_invoice { get; set; }
        [MaxLength(3)]
        public virtual string payment_request_category { get; set; }
        [MaxLength(255)]
        public virtual string reason_for_apply { get; set; }
        public virtual short employeeno_of_applicant { get; set; }
        [MaxLength(255)]
        public virtual string name_of_applicant { get; set; }
        [MaxLength(3)]
        public virtual string currency_type { get; set; }
        public virtual decimal total_amount { get; set; }
        [MaxLength(3)]
        public virtual string basis_of_payment { get; set; }
        [MaxLength(255)]
        public virtual string payee { get; set; }
        public virtual DateTime schedule_payment_date { get; set; }
        public virtual DateTime? payment_date { get; set; }
        [MaxLength(3)]
        public virtual string bank_code { get; set; }
        [MaxLength(4)]
        public virtual string bank_branch_code { get; set; }
        [MaxLength(50)]
        public virtual string bank_account { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public List<EB_HOUSEHOLD_REGISTRATION_APPLICATION_INVOICE> EbHouseholdRegistrationApplicationInvoices { get; set; }
        public List<EB_LEGAL_ATTEST_INVOICE> EbLegalAttestInvoices { get; set; }
        public List<EB_TAXATION_INFORMATION_APPLICATION_INVOICE> EbTaxationInformationApplicationInvoices { get; set; }
        public List<FD_INVOICE_DETAIL> FdInvoiceDetails { get; set; }
        public List<FD_INVOICE_VOUCHER> FdInvoiceVouchers { get; set; }
        public List<EB_HOUSEHOLD_REGISTRATION_APPLICATION_INVOICE> EbHouseholdRegistrationApplicationInvoices1 { get; set; }
        public List<EB_LEGAL_ATTEST_INVOICE> EbLegalAttestInvoices1 { get; set; }
        public List<EB_TAXATION_INFORMATION_APPLICATION_INVOICE> EbTaxationInformationApplicationInvoices1 { get; set; }
        public List<FD_INVOICE_DETAIL> FdInvoiceDetails1 { get; set; }
        public List<FD_INVOICE_VOUCHER> FdInvoiceVouchers1 { get; set; }
    }
}
