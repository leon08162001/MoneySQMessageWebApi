using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("EB_LEGAL_PETITION")]
    public class EB_LEGAL_PETITION
    {
        public EB_LEGAL_PETITION()
        {
            this.EbLegalPetitionAttachements = new List<EB_LEGAL_PETITION_ATTACHEMENT>();
            this.EbLegalPetitionInvoices = new List<EB_LEGAL_PETITION_INVOICE>();
            this.EbLegalPetitionRespondents = new List<EB_LEGAL_PETITION_RESPONDENT>();
            this.EbLegalPetitionThirdParties = new List<EB_LEGAL_PETITION_THIRD_PARTY>();
            this.EbLegalPetitionAttachements1 = new List<EB_LEGAL_PETITION_ATTACHEMENT>();
            this.EbLegalPetitionInvoices1 = new List<EB_LEGAL_PETITION_INVOICE>();
            this.EbLegalPetitionRespondents1 = new List<EB_LEGAL_PETITION_RESPONDENT>();
            this.EbLegalPetitionThirdParties1 = new List<EB_LEGAL_PETITION_THIRD_PARTY>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string legal_attest_letters_no { get; set; }
        [MaxLength(3)]
        public virtual string legal_petition_category { get; set; }
        [MaxLength(100)]
        public virtual string court { get; set; }
        [MaxLength(100)]
        public virtual string petitioner { get; set; }
        [MaxLength(255)]
        public virtual string petitioner_address { get; set; }
        [MaxLength(50)]
        public virtual string applicant_telno { get; set; }
        [MaxLength(50)]
        public virtual string legal_representative { get; set; }
        [MaxLength(255)]
        public virtual string legal_representative_address { get; set; }
        [MaxLength(50)]
        public virtual string appointed_collecting_agent { get; set; }
        [MaxLength(255)]
        public virtual string appointed_collecting_agent_address { get; set; }
        [MaxLength(3)]
        public virtual string currency_type { get; set; }
        public virtual decimal? subject_matter_amounts_of_money { get; set; }
        [MaxLength(4000)]
        public virtual string petition_matter { get; set; }
        [MaxLength(4000)]
        public virtual string facts_and_reasons { get; set; }
        [MaxLength(4000)]
        public virtual string arbitrated_petition_matter { get; set; }
        [MaxLength(4000)]
        public virtual string petition_facts_and_reasons { get; set; }
        [MaxLength(4000)]
        public virtual string petition_subject_and_amount { get; set; }
        [MaxLength(4000)]
        public virtual string petition_facts_reasons_and_statements { get; set; }
        [MaxLength(4000)]
        public virtual string required_amount { get; set; }
        [MaxLength(4000)]
        public virtual string reason_of_civil_execution { get; set; }
        [MaxLength(4000)]
        public virtual string subject_of_civil_execution { get; set; }
        [MaxLength(4000)]
        public virtual string petition_reason { get; set; }
        [MaxLength(255)]
        public virtual string descrition_of_document_attachment { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public List<EB_LEGAL_PETITION_ATTACHEMENT> EbLegalPetitionAttachements { get; set; }
        public List<EB_LEGAL_PETITION_INVOICE> EbLegalPetitionInvoices { get; set; }
        public List<EB_LEGAL_PETITION_RESPONDENT> EbLegalPetitionRespondents { get; set; }
        public List<EB_LEGAL_PETITION_THIRD_PARTY> EbLegalPetitionThirdParties { get; set; }
        public List<EB_LEGAL_PETITION_ATTACHEMENT> EbLegalPetitionAttachements1 { get; set; }
        public List<EB_LEGAL_PETITION_INVOICE> EbLegalPetitionInvoices1 { get; set; }
        public List<EB_LEGAL_PETITION_RESPONDENT> EbLegalPetitionRespondents1 { get; set; }
        public List<EB_LEGAL_PETITION_THIRD_PARTY> EbLegalPetitionThirdParties1 { get; set; }
    }
}
