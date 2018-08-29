using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("XZ_ATTACHMENT")]
    public class XZ_ATTACHMENT
    {
        public XZ_ATTACHMENT()
        {
            this.CbCreditCheckReprotAttachments = new List<CB_CREDIT_CHECK_REPROT_ATTACHMENT>();
            this.CcAppraisalReportAttachments = new List<CC_APPRAISAL_REPORT_ATTACHMENT>();
            this.DaContractAttachments = new List<DA_CONTRACT_ATTACHMENT>();
            this.DaContractCollaterals = new List<DA_CONTRACT_COLLATERAL>();
            this.DaContractIncomes = new List<DA_CONTRACT_INCOME>();
            this.DaContractProperties = new List<DA_CONTRACT_PROPERTY>();
            this.EbForeclosureEvaluationAttachments = new List<EB_FORECLOSURE_EVALUATION_ATTACHMENT>();
            this.EbHouseholdRegistrationApplicationAttachements = new List<EB_HOUSEHOLD_REGISTRATION_APPLICATION_ATTACHEMENT>();
            this.EbLegalAttestAttachements = new List<EB_LEGAL_ATTEST_ATTACHEMENT>();
            this.EbLegalPetitionAttachements = new List<EB_LEGAL_PETITION_ATTACHEMENT>();
            this.EbTaxationInformationApplicationAttachements = new List<EB_TAXATION_INFORMATION_APPLICATION_ATTACHEMENT>();
            this.FaCheques = new List<FA_CHEQUE>();
            this.IaCuatomerServiceApplicationAttachments = new List<IA_CUATOMER_SERVICE_APPLICATION_ATTACHMENT>();
            this.JaEmpolyeeAttachments = new List<JA_EMPOLYEE_ATTACHMENT>();
            this.UaApprovementAttachments = new List<UA_APPROVEMENT_ATTACHMENT>();
            this.XzBulletinAttachments = new List<XZ_BULLETIN_ATTACHMENT>();
            this.ZzApplicationAttachments = new List<ZZ_APPLICATION_ATTACHMENT>();
            this.ZzBorrowerNtoteCredits = new List<ZZ_BORROWER_NTOTE_CREDIT>();
            this.ShippedBy = new List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_DESCRIPTION>();
            this.ShippedBy1 = new List<ZZ_LAND_OWNERSHIP_CERTIFICATE_DESCRIPTION>();
            this.ZzLoanRelatedPartiesAttachments = new List<ZZ_LOAN_RELATED_PARTIES_ATTACHMENT>();
            this.ZzPersonalCreditReports = new List<ZZ_PERSONAL_CREDIT_REPORT>();
            this.ZzPersonalCreditReportDbR22 = new List<ZZ_PERSONAL_CREDIT_REPORT_DBR22>();
            this.CbCreditCheckReprotAttachments1 = new List<CB_CREDIT_CHECK_REPROT_ATTACHMENT>();
            this.CcAppraisalReportAttachments1 = new List<CC_APPRAISAL_REPORT_ATTACHMENT>();
            this.DaContractAttachments1 = new List<DA_CONTRACT_ATTACHMENT>();
            this.DaContractCollaterals1 = new List<DA_CONTRACT_COLLATERAL>();
            this.DaContractIncomes1 = new List<DA_CONTRACT_INCOME>();
            this.DaContractProperties1 = new List<DA_CONTRACT_PROPERTY>();
            this.EbForeclosureEvaluationAttachments1 = new List<EB_FORECLOSURE_EVALUATION_ATTACHMENT>();
            this.EbHouseholdRegistrationApplicationAttachements1 = new List<EB_HOUSEHOLD_REGISTRATION_APPLICATION_ATTACHEMENT>();
            this.EbLegalAttestAttachements1 = new List<EB_LEGAL_ATTEST_ATTACHEMENT>();
            this.EbLegalPetitionAttachements1 = new List<EB_LEGAL_PETITION_ATTACHEMENT>();
            this.EbTaxationInformationApplicationAttachements1 = new List<EB_TAXATION_INFORMATION_APPLICATION_ATTACHEMENT>();
            this.FaCheques1 = new List<FA_CHEQUE>();
            this.IaCuatomerServiceApplicationAttachments1 = new List<IA_CUATOMER_SERVICE_APPLICATION_ATTACHMENT>();
            this.JaEmpolyeeAttachments1 = new List<JA_EMPOLYEE_ATTACHMENT>();
            this.UaApprovementAttachments1 = new List<UA_APPROVEMENT_ATTACHMENT>();
            this.XzBulletinAttachments1 = new List<XZ_BULLETIN_ATTACHMENT>();
            this.ZzApplicationAttachments1 = new List<ZZ_APPLICATION_ATTACHMENT>();
            this.ZzBorrowerNtoteCredits1 = new List<ZZ_BORROWER_NTOTE_CREDIT>();
            this.ShippedBy2 = new List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_DESCRIPTION>();
            this.ShippedBy3 = new List<ZZ_LAND_OWNERSHIP_CERTIFICATE_DESCRIPTION>();
            this.ZzLoanRelatedPartiesAttachments1 = new List<ZZ_LOAN_RELATED_PARTIES_ATTACHMENT>();
            this.ZzPersonalCreditReports1 = new List<ZZ_PERSONAL_CREDIT_REPORT>();
            this.ZzPersonalCreditReportDbR221 = new List<ZZ_PERSONAL_CREDIT_REPORT_DBR22>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int attachment_id { get; set; }
        [MaxLength(50)]
        public virtual string document_code { get; set; }
        [MaxLength(255)]
        public virtual string file_name { get; set; }
        [MaxLength(255)]
        public virtual string file_saved_address { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public XZ_DOCUMENT XzDocument { get; set; }
        public XZ_DOCUMENT XzDocument1 { get; set; }
        public List<CB_CREDIT_CHECK_REPROT_ATTACHMENT> CbCreditCheckReprotAttachments { get; set; }
        public List<CC_APPRAISAL_REPORT_ATTACHMENT> CcAppraisalReportAttachments { get; set; }
        public List<DA_CONTRACT_ATTACHMENT> DaContractAttachments { get; set; }
        public List<DA_CONTRACT_COLLATERAL> DaContractCollaterals { get; set; }
        public List<DA_CONTRACT_INCOME> DaContractIncomes { get; set; }
        public List<DA_CONTRACT_PROPERTY> DaContractProperties { get; set; }
        public List<EB_FORECLOSURE_EVALUATION_ATTACHMENT> EbForeclosureEvaluationAttachments { get; set; }
        public List<EB_HOUSEHOLD_REGISTRATION_APPLICATION_ATTACHEMENT> EbHouseholdRegistrationApplicationAttachements { get; set; }
        public List<EB_LEGAL_ATTEST_ATTACHEMENT> EbLegalAttestAttachements { get; set; }
        public List<EB_LEGAL_PETITION_ATTACHEMENT> EbLegalPetitionAttachements { get; set; }
        public List<EB_TAXATION_INFORMATION_APPLICATION_ATTACHEMENT> EbTaxationInformationApplicationAttachements { get; set; }
        public List<FA_CHEQUE> FaCheques { get; set; }
        public List<IA_CUATOMER_SERVICE_APPLICATION_ATTACHMENT> IaCuatomerServiceApplicationAttachments { get; set; }
        public List<JA_EMPOLYEE_ATTACHMENT> JaEmpolyeeAttachments { get; set; }
        public List<UA_APPROVEMENT_ATTACHMENT> UaApprovementAttachments { get; set; }
        public List<XZ_BULLETIN_ATTACHMENT> XzBulletinAttachments { get; set; }
        public List<ZZ_APPLICATION_ATTACHMENT> ZzApplicationAttachments { get; set; }
        public List<ZZ_BORROWER_NTOTE_CREDIT> ZzBorrowerNtoteCredits { get; set; }
        public List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_DESCRIPTION> ShippedBy { get; set; }
        public List<ZZ_LAND_OWNERSHIP_CERTIFICATE_DESCRIPTION> ShippedBy1 { get; set; }
        public List<ZZ_LOAN_RELATED_PARTIES_ATTACHMENT> ZzLoanRelatedPartiesAttachments { get; set; }
        public List<ZZ_PERSONAL_CREDIT_REPORT> ZzPersonalCreditReports { get; set; }
        public List<ZZ_PERSONAL_CREDIT_REPORT_DBR22> ZzPersonalCreditReportDbR22 { get; set; }
        public List<CB_CREDIT_CHECK_REPROT_ATTACHMENT> CbCreditCheckReprotAttachments1 { get; set; }
        public List<CC_APPRAISAL_REPORT_ATTACHMENT> CcAppraisalReportAttachments1 { get; set; }
        public List<DA_CONTRACT_ATTACHMENT> DaContractAttachments1 { get; set; }
        public List<DA_CONTRACT_COLLATERAL> DaContractCollaterals1 { get; set; }
        public List<DA_CONTRACT_INCOME> DaContractIncomes1 { get; set; }
        public List<DA_CONTRACT_PROPERTY> DaContractProperties1 { get; set; }
        public List<EB_FORECLOSURE_EVALUATION_ATTACHMENT> EbForeclosureEvaluationAttachments1 { get; set; }
        public List<EB_HOUSEHOLD_REGISTRATION_APPLICATION_ATTACHEMENT> EbHouseholdRegistrationApplicationAttachements1 { get; set; }
        public List<EB_LEGAL_ATTEST_ATTACHEMENT> EbLegalAttestAttachements1 { get; set; }
        public List<EB_LEGAL_PETITION_ATTACHEMENT> EbLegalPetitionAttachements1 { get; set; }
        public List<EB_TAXATION_INFORMATION_APPLICATION_ATTACHEMENT> EbTaxationInformationApplicationAttachements1 { get; set; }
        public List<FA_CHEQUE> FaCheques1 { get; set; }
        public List<IA_CUATOMER_SERVICE_APPLICATION_ATTACHMENT> IaCuatomerServiceApplicationAttachments1 { get; set; }
        public List<JA_EMPOLYEE_ATTACHMENT> JaEmpolyeeAttachments1 { get; set; }
        public List<UA_APPROVEMENT_ATTACHMENT> UaApprovementAttachments1 { get; set; }
        public List<XZ_BULLETIN_ATTACHMENT> XzBulletinAttachments1 { get; set; }
        public List<ZZ_APPLICATION_ATTACHMENT> ZzApplicationAttachments1 { get; set; }
        public List<ZZ_BORROWER_NTOTE_CREDIT> ZzBorrowerNtoteCredits1 { get; set; }
        public List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_DESCRIPTION> ShippedBy2 { get; set; }
        public List<ZZ_LAND_OWNERSHIP_CERTIFICATE_DESCRIPTION> ShippedBy3 { get; set; }
        public List<ZZ_LOAN_RELATED_PARTIES_ATTACHMENT> ZzLoanRelatedPartiesAttachments1 { get; set; }
        public List<ZZ_PERSONAL_CREDIT_REPORT> ZzPersonalCreditReports1 { get; set; }
        public List<ZZ_PERSONAL_CREDIT_REPORT_DBR22> ZzPersonalCreditReportDbR221 { get; set; }
    }
}
