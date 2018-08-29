using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("EB_LEGAL_ATTEST_LETTERS")]
    public class EB_LEGAL_ATTEST_LETTERS
    {
        public EB_LEGAL_ATTEST_LETTERS()
        {
            this.DaContractLegalAttestLetters = new List<DA_CONTRACT_LEGAL_ATTEST_LETTERS>();
            this.DaContractLegalPetitions = new List<DA_CONTRACT_LEGAL_PETITION>();
            this.EbLegalAttestAttachements = new List<EB_LEGAL_ATTEST_ATTACHEMENT>();
            this.EbLegalAttestInvoices = new List<EB_LEGAL_ATTEST_INVOICE>();
            this.EbLegalAttestLettersAddressees = new List<EB_LEGAL_ATTEST_LETTERS_ADDRESSEE>();
            this.DaContractLegalAttestLetters1 = new List<DA_CONTRACT_LEGAL_ATTEST_LETTERS>();
            this.DaContractLegalPetitions1 = new List<DA_CONTRACT_LEGAL_PETITION>();
            this.EbLegalAttestAttachements1 = new List<EB_LEGAL_ATTEST_ATTACHEMENT>();
            this.EbLegalAttestInvoices1 = new List<EB_LEGAL_ATTEST_INVOICE>();
            this.EbLegalAttestLettersAddressees1 = new List<EB_LEGAL_ATTEST_LETTERS_ADDRESSEE>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string legal_attest_letters_no { get; set; }
        [MaxLength(4000)]
        public virtual string content { get; set; }
        public virtual short empolyeeno_of_writer { get; set; }
        [MaxLength(255)]
        public virtual string name_of_writer { get; set; }
        public virtual DateTime datetime_of_writing { get; set; }
        [MaxLength(255)]
        public virtual string addressor { get; set; }
        [MaxLength(100)]
        public virtual string addressor_job_title { get; set; }
        [MaxLength(255)]
        public virtual string mailing_address { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public List<DA_CONTRACT_LEGAL_ATTEST_LETTERS> DaContractLegalAttestLetters { get; set; }
        public List<DA_CONTRACT_LEGAL_PETITION> DaContractLegalPetitions { get; set; }
        public List<EB_LEGAL_ATTEST_ATTACHEMENT> EbLegalAttestAttachements { get; set; }
        public List<EB_LEGAL_ATTEST_INVOICE> EbLegalAttestInvoices { get; set; }
        public List<EB_LEGAL_ATTEST_LETTERS_ADDRESSEE> EbLegalAttestLettersAddressees { get; set; }
        public List<DA_CONTRACT_LEGAL_ATTEST_LETTERS> DaContractLegalAttestLetters1 { get; set; }
        public List<DA_CONTRACT_LEGAL_PETITION> DaContractLegalPetitions1 { get; set; }
        public List<EB_LEGAL_ATTEST_ATTACHEMENT> EbLegalAttestAttachements1 { get; set; }
        public List<EB_LEGAL_ATTEST_INVOICE> EbLegalAttestInvoices1 { get; set; }
        public List<EB_LEGAL_ATTEST_LETTERS_ADDRESSEE> EbLegalAttestLettersAddressees1 { get; set; }
    }
}
