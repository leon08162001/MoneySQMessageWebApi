using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("EB_TAXATION_INFORMATION_APPLICATION")]
    public class EB_TAXATION_INFORMATION_APPLICATION
    {
        public EB_TAXATION_INFORMATION_APPLICATION()
        {
            this.DaContractIncomes = new List<DA_CONTRACT_INCOME>();
            this.DaContractProperties = new List<DA_CONTRACT_PROPERTY>();
            this.DaContractTaxationInformationApplications = new List<DA_CONTRACT_TAXATION_INFORMATION_APPLICATION>();
            this.EbTaxationInformationApplicationAttachements = new List<EB_TAXATION_INFORMATION_APPLICATION_ATTACHEMENT>();
            this.EbTaxationInformationApplicationDebtors = new List<EB_TAXATION_INFORMATION_APPLICATION_DEBTOR>();
            this.EbTaxationInformationApplicationInvoices = new List<EB_TAXATION_INFORMATION_APPLICATION_INVOICE>();
            this.DaContractIncomes1 = new List<DA_CONTRACT_INCOME>();
            this.DaContractProperties1 = new List<DA_CONTRACT_PROPERTY>();
            this.DaContractTaxationInformationApplications1 = new List<DA_CONTRACT_TAXATION_INFORMATION_APPLICATION>();
            this.EbTaxationInformationApplicationAttachements1 = new List<EB_TAXATION_INFORMATION_APPLICATION_ATTACHEMENT>();
            this.EbTaxationInformationApplicationDebtors1 = new List<EB_TAXATION_INFORMATION_APPLICATION_DEBTOR>();
            this.EbTaxationInformationApplicationInvoices1 = new List<EB_TAXATION_INFORMATION_APPLICATION_INVOICE>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string TXI_application_no { get; set; }
        public virtual DateTime date_of_application { get; set; }
        [MaxLength(100)]
        public virtual string taxation_bureau { get; set; }
        [MaxLength(100)]
        public virtual string creditor { get; set; }
        [MaxLength(50)]
        public virtual string creditor_idno { get; set; }
        [MaxLength(255)]
        public virtual string creditor_address { get; set; }
        [MaxLength(100)]
        public virtual string responsible_person { get; set; }
        [MaxLength(100)]
        public virtual string procurator { get; set; }
        [MaxLength(255)]
        public virtual string procurator_address { get; set; }
        [MaxLength(50)]
        public virtual string procurator_idno { get; set; }
        [MaxLength(50)]
        public virtual string procurator_telno { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public List<DA_CONTRACT_INCOME> DaContractIncomes { get; set; }
        public List<DA_CONTRACT_PROPERTY> DaContractProperties { get; set; }
        public List<DA_CONTRACT_TAXATION_INFORMATION_APPLICATION> DaContractTaxationInformationApplications { get; set; }
        public List<EB_TAXATION_INFORMATION_APPLICATION_ATTACHEMENT> EbTaxationInformationApplicationAttachements { get; set; }
        public List<EB_TAXATION_INFORMATION_APPLICATION_DEBTOR> EbTaxationInformationApplicationDebtors { get; set; }
        public List<EB_TAXATION_INFORMATION_APPLICATION_INVOICE> EbTaxationInformationApplicationInvoices { get; set; }
        public List<DA_CONTRACT_INCOME> DaContractIncomes1 { get; set; }
        public List<DA_CONTRACT_PROPERTY> DaContractProperties1 { get; set; }
        public List<DA_CONTRACT_TAXATION_INFORMATION_APPLICATION> DaContractTaxationInformationApplications1 { get; set; }
        public List<EB_TAXATION_INFORMATION_APPLICATION_ATTACHEMENT> EbTaxationInformationApplicationAttachements1 { get; set; }
        public List<EB_TAXATION_INFORMATION_APPLICATION_DEBTOR> EbTaxationInformationApplicationDebtors1 { get; set; }
        public List<EB_TAXATION_INFORMATION_APPLICATION_INVOICE> EbTaxationInformationApplicationInvoices1 { get; set; }
    }
}
