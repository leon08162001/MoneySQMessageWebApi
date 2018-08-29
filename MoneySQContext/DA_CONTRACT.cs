using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("DA_CONTRACT")]
    public class DA_CONTRACT
    {
        public DA_CONTRACT()
        {
            this.DaContractAmortizationDetails = new List<DA_CONTRACT_AMORTIZATION_DETAILS>();
            this.DaContractApplications = new List<DA_CONTRACT_APPLICATION>();
            this.DaContractApprovements = new List<DA_CONTRACT_APPROVEMENT>();
            this.DaContractAttachments = new List<DA_CONTRACT_ATTACHMENT>();
            this.DaContractCheques = new List<DA_CONTRACT_CHEQUE>();
            this.DaContractCollaterals = new List<DA_CONTRACT_COLLATERAL>();
            this.DaContractControls = new List<DA_CONTRACT_CONTROL>();
            this.DaContractCustomerContactLogs = new List<DA_CONTRACT_CUSTOMER_CONTACT_LOG>();
            this.DaContractHouseholdRegistrationApplications = new List<DA_CONTRACT_HOUSEHOLD_REGISTRATION_APPLICATION>();
            this.DaContractIncomes = new List<DA_CONTRACT_INCOME>();
            this.DaContractInterimAccounts = new List<DA_CONTRACT_INTERIM_ACCOUNT>();
            this.DaContractLegalActionInstructions = new List<DA_CONTRACT_LEGAL_ACTION_INSTRUCTION>();
            this.DaContractLegalAttestLetters = new List<DA_CONTRACT_LEGAL_ATTEST_LETTERS>();
            this.DaContractLegalPetitions = new List<DA_CONTRACT_LEGAL_PETITION>();
            this.DaContractMatcheds = new List<DA_CONTRACT_MATCHED>();
            this.DaContractMessages = new List<DA_CONTRACT_MESSAGE>();
            this.DaContractProperties = new List<DA_CONTRACT_PROPERTY>();
            this.DaContractRepaymentDetails = new List<DA_CONTRACT_REPAYMENT_DETAILS>();
            this.DaContractTaxationInformationApplications = new List<DA_CONTRACT_TAXATION_INFORMATION_APPLICATION>();
            this.DaContractors = new List<DA_CONTRACTOR>();
            this.DaDebitNoteControls = new List<DA_DEBIT_NOTE_CONTROL>();
            this.GaVoucherDetails = new List<GA_VOUCHER_DETAIL>();
            this.IaCuatomerServiceApplications = new List<IA_CUATOMER_SERVICE_APPLICATION>();
            this.JaDatebooks = new List<JA_DATEBOOK>();
            this.DaContractAmortizationDetails1 = new List<DA_CONTRACT_AMORTIZATION_DETAILS>();
            this.DaContractApplications1 = new List<DA_CONTRACT_APPLICATION>();
            this.DaContractApprovements1 = new List<DA_CONTRACT_APPROVEMENT>();
            this.DaContractAttachments1 = new List<DA_CONTRACT_ATTACHMENT>();
            this.DaContractCheques1 = new List<DA_CONTRACT_CHEQUE>();
            this.DaContractCollaterals1 = new List<DA_CONTRACT_COLLATERAL>();
            this.DaContractControls1 = new List<DA_CONTRACT_CONTROL>();
            this.DaContractCustomerContactLogs1 = new List<DA_CONTRACT_CUSTOMER_CONTACT_LOG>();
            this.DaContractHouseholdRegistrationApplications1 = new List<DA_CONTRACT_HOUSEHOLD_REGISTRATION_APPLICATION>();
            this.DaContractIncomes1 = new List<DA_CONTRACT_INCOME>();
            this.DaContractInterimAccounts1 = new List<DA_CONTRACT_INTERIM_ACCOUNT>();
            this.DaContractLegalActionInstructions1 = new List<DA_CONTRACT_LEGAL_ACTION_INSTRUCTION>();
            this.DaContractLegalAttestLetters1 = new List<DA_CONTRACT_LEGAL_ATTEST_LETTERS>();
            this.DaContractLegalPetitions1 = new List<DA_CONTRACT_LEGAL_PETITION>();
            this.DaContractMatcheds1 = new List<DA_CONTRACT_MATCHED>();
            this.DaContractMessages1 = new List<DA_CONTRACT_MESSAGE>();
            this.DaContractProperties1 = new List<DA_CONTRACT_PROPERTY>();
            this.DaContractRepaymentDetails1 = new List<DA_CONTRACT_REPAYMENT_DETAILS>();
            this.DaContractTaxationInformationApplications1 = new List<DA_CONTRACT_TAXATION_INFORMATION_APPLICATION>();
            this.DaContractors1 = new List<DA_CONTRACTOR>();
            this.DaDebitNoteControls1 = new List<DA_DEBIT_NOTE_CONTROL>();
            this.GaVoucherDetails1 = new List<GA_VOUCHER_DETAIL>();
            this.IaCuatomerServiceApplications1 = new List<IA_CUATOMER_SERVICE_APPLICATION>();
            this.JaDatebooks1 = new List<JA_DATEBOOK>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string contract_number { get; set; }
        [MaxLength(255)]
        public virtual string contract_name { get; set; }
        [MaxLength(3)]
        public virtual string contract_status { get; set; }
        [MaxLength(3)]
        public virtual string contract_category { get; set; }
        [MaxLength(3)]
        public virtual string currency_type { get; set; }
        public virtual decimal amount_of_contract { get; set; }
        [MaxLength(3)]
        public virtual string approved_contract_type { get; set; }
        [MaxLength(3)]
        public virtual string interest_bearing_period { get; set; }
        [MaxLength(3)]
        public virtual string repayment_method_code { get; set; }
        [MaxLength(255)]
        public virtual string interest_calculation_method { get; set; }
        public virtual decimal contract_interest_rate { get; set; }
        public virtual short contract_terms { get; set; }
        public virtual DateTime contract_start_date { get; set; }
        public virtual DateTime contract_expiration_date { get; set; }
        public virtual decimal contract_overdue_interest { get; set; }
        public virtual decimal contract_default_fine_rate { get; set; }
        public virtual decimal? contract_late_fine_rate { get; set; }
        public virtual decimal? tax_amount { get; set; }
        public virtual decimal? fee_amount { get; set; }
        public virtual DateTime? sign_contract_date { get; set; }
        public virtual short? epmloyeeno_of_contract_signed_confirmation { get; set; }
        [MaxLength(255)]
        public virtual string name_of_contract_signed_confirmation { get; set; }
        public virtual DateTime? loan_appropriation_date { get; set; }
        public virtual DateTime? investment_received_date { get; set; }
        public virtual decimal? out_on_loan_of_investment { get; set; }
        public virtual decimal? loanable_amt_of_investment { get; set; }
        public virtual decimal? total_debt_paid { get; set; }
        public virtual decimal? total_debt_outstanding { get; set; }
        [MaxLength(3)]
        public virtual string bankcode_of_contractor { get; set; }
        [MaxLength(4)]
        public virtual string bankbranchcode_of_contractor { get; set; }
        [MaxLength(50)]
        public virtual string account_of_contractor { get; set; }
        [MaxLength(255)]
        public virtual string bankname_of_contractor { get; set; }
        [MaxLength(3)]
        public virtual string bankcode_for_contract { get; set; }
        [MaxLength(4)]
        public virtual string bankbranchcode_for_contract { get; set; }
        [MaxLength(50)]
        public virtual string virtualaccount_for_contract { get; set; }
        [MaxLength(255)]
        public virtual string bankname_for_contract { get; set; }
        public virtual decimal principal_per_issue { get; set; }
        public virtual decimal interest_per_issue { get; set; }
        public virtual decimal instalment { get; set; }
        public virtual short? number_of_checks { get; set; }
        public virtual int? attachment_id { get; set; }
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
        public List<DA_CONTRACT_AMORTIZATION_DETAILS> DaContractAmortizationDetails { get; set; }
        public List<DA_CONTRACT_APPLICATION> DaContractApplications { get; set; }
        public List<DA_CONTRACT_APPROVEMENT> DaContractApprovements { get; set; }
        public List<DA_CONTRACT_ATTACHMENT> DaContractAttachments { get; set; }
        public List<DA_CONTRACT_CHEQUE> DaContractCheques { get; set; }
        public List<DA_CONTRACT_COLLATERAL> DaContractCollaterals { get; set; }
        public List<DA_CONTRACT_CONTROL> DaContractControls { get; set; }
        public List<DA_CONTRACT_CUSTOMER_CONTACT_LOG> DaContractCustomerContactLogs { get; set; }
        public List<DA_CONTRACT_HOUSEHOLD_REGISTRATION_APPLICATION> DaContractHouseholdRegistrationApplications { get; set; }
        public List<DA_CONTRACT_INCOME> DaContractIncomes { get; set; }
        public List<DA_CONTRACT_INTERIM_ACCOUNT> DaContractInterimAccounts { get; set; }
        public List<DA_CONTRACT_LEGAL_ACTION_INSTRUCTION> DaContractLegalActionInstructions { get; set; }
        public List<DA_CONTRACT_LEGAL_ATTEST_LETTERS> DaContractLegalAttestLetters { get; set; }
        public List<DA_CONTRACT_LEGAL_PETITION> DaContractLegalPetitions { get; set; }
        public List<DA_CONTRACT_MATCHED> DaContractMatcheds { get; set; }
        public List<DA_CONTRACT_MESSAGE> DaContractMessages { get; set; }
        public List<DA_CONTRACT_PROPERTY> DaContractProperties { get; set; }
        public List<DA_CONTRACT_REPAYMENT_DETAILS> DaContractRepaymentDetails { get; set; }
        public List<DA_CONTRACT_TAXATION_INFORMATION_APPLICATION> DaContractTaxationInformationApplications { get; set; }
        public List<DA_CONTRACTOR> DaContractors { get; set; }
        public List<DA_DEBIT_NOTE_CONTROL> DaDebitNoteControls { get; set; }
        public List<GA_VOUCHER_DETAIL> GaVoucherDetails { get; set; }
        public List<IA_CUATOMER_SERVICE_APPLICATION> IaCuatomerServiceApplications { get; set; }
        public List<JA_DATEBOOK> JaDatebooks { get; set; }
        public List<DA_CONTRACT_AMORTIZATION_DETAILS> DaContractAmortizationDetails1 { get; set; }
        public List<DA_CONTRACT_APPLICATION> DaContractApplications1 { get; set; }
        public List<DA_CONTRACT_APPROVEMENT> DaContractApprovements1 { get; set; }
        public List<DA_CONTRACT_ATTACHMENT> DaContractAttachments1 { get; set; }
        public List<DA_CONTRACT_CHEQUE> DaContractCheques1 { get; set; }
        public List<DA_CONTRACT_COLLATERAL> DaContractCollaterals1 { get; set; }
        public List<DA_CONTRACT_CONTROL> DaContractControls1 { get; set; }
        public List<DA_CONTRACT_CUSTOMER_CONTACT_LOG> DaContractCustomerContactLogs1 { get; set; }
        public List<DA_CONTRACT_HOUSEHOLD_REGISTRATION_APPLICATION> DaContractHouseholdRegistrationApplications1 { get; set; }
        public List<DA_CONTRACT_INCOME> DaContractIncomes1 { get; set; }
        public List<DA_CONTRACT_INTERIM_ACCOUNT> DaContractInterimAccounts1 { get; set; }
        public List<DA_CONTRACT_LEGAL_ACTION_INSTRUCTION> DaContractLegalActionInstructions1 { get; set; }
        public List<DA_CONTRACT_LEGAL_ATTEST_LETTERS> DaContractLegalAttestLetters1 { get; set; }
        public List<DA_CONTRACT_LEGAL_PETITION> DaContractLegalPetitions1 { get; set; }
        public List<DA_CONTRACT_MATCHED> DaContractMatcheds1 { get; set; }
        public List<DA_CONTRACT_MESSAGE> DaContractMessages1 { get; set; }
        public List<DA_CONTRACT_PROPERTY> DaContractProperties1 { get; set; }
        public List<DA_CONTRACT_REPAYMENT_DETAILS> DaContractRepaymentDetails1 { get; set; }
        public List<DA_CONTRACT_TAXATION_INFORMATION_APPLICATION> DaContractTaxationInformationApplications1 { get; set; }
        public List<DA_CONTRACTOR> DaContractors1 { get; set; }
        public List<DA_DEBIT_NOTE_CONTROL> DaDebitNoteControls1 { get; set; }
        public List<GA_VOUCHER_DETAIL> GaVoucherDetails1 { get; set; }
        public List<IA_CUATOMER_SERVICE_APPLICATION> IaCuatomerServiceApplications1 { get; set; }
        public List<JA_DATEBOOK> JaDatebooks1 { get; set; }
    }
}
