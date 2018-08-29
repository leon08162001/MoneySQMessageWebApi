using System;
using System.Configuration;
using System.Data.Entity;

namespace MoneySQContext
{
    public partial class MoneySQEntities : DbContext
    {
        public MoneySQEntities(String Connectionname)
        {
            string ConnStr = ConfigurationManager.ConnectionStrings[Connectionname].ToString();
            string DecryptConn = Utility.DBConnection.GetEntityServerPlainConnString(ConnStr);
            DbContext DbContext = new DbContext(DecryptConn);
            base.Database.Connection.ConnectionString = DbContext.Database.Connection.ConnectionString;
            //base.Database.Connection.ConnectionString = Utility.DBConnection.GetSqlServerPlainConnString(ConnStr);
        }
        public virtual DbSet<CB_CREDIT_CHECK_LEGAL_OPINION> CB_CREDIT_CHECK_LEGAL_OPINION { get; set; }
        public virtual DbSet<CB_CREDIT_CHECK_REPROT> CB_CREDIT_CHECK_REPROT { get; set; }
        public virtual DbSet<CB_CREDIT_CHECK_REPROT_APPROVEMENT> CB_CREDIT_CHECK_REPROT_APPROVEMENT { get; set; }
        public virtual DbSet<CB_CREDIT_CHECK_REPROT_ATTACHMENT> CB_CREDIT_CHECK_REPROT_ATTACHMENT { get; set; }
        public virtual DbSet<CB_CREDIT_CHECK_SCORING> CB_CREDIT_CHECK_SCORING { get; set; }
        public virtual DbSet<CB_CREDIT_RISK_RANK> CB_CREDIT_RISK_RANK { get; set; }
        public virtual DbSet<CB_CREDIT_RISK_RANK_VSESION> CB_CREDIT_RISK_RANK_VSESION { get; set; }
        public virtual DbSet<CB_SCORING_CARD_ASSEMBLAGE> CB_SCORING_CARD_ASSEMBLAGE { get; set; }
        public virtual DbSet<CB_SCORING_CARD_ITEM> CB_SCORING_CARD_ITEM { get; set; }
        public virtual DbSet<CB_SCORING_CARD_LEVEL> CB_SCORING_CARD_LEVEL { get; set; }
        public virtual DbSet<CB_SCORING_CARD_VERSION> CB_SCORING_CARD_VERSION { get; set; }
        public virtual DbSet<CC_APPRAISAL_BUILDING> CC_APPRAISAL_BUILDING { get; set; }
        public virtual DbSet<CC_APPRAISAL_BUILDING_CONTENT> CC_APPRAISAL_BUILDING_CONTENT { get; set; }
        public virtual DbSet<CC_APPRAISAL_LAND> CC_APPRAISAL_LAND { get; set; }
        public virtual DbSet<CC_APPRAISAL_REPORT> CC_APPRAISAL_REPORT { get; set; }
        public virtual DbSet<CC_APPRAISAL_REPORT_APPROVEMENT> CC_APPRAISAL_REPORT_APPROVEMENT { get; set; }
        public virtual DbSet<CC_APPRAISAL_REPORT_ATTACHMENT> CC_APPRAISAL_REPORT_ATTACHMENT { get; set; }
        public virtual DbSet<DA_CONTRACT> DA_CONTRACT { get; set; }
        public virtual DbSet<DA_CONTRACT_AMORTIZATION_DETAILS> DA_CONTRACT_AMORTIZATION_DETAILS { get; set; }
        public virtual DbSet<DA_CONTRACT_AMORTIZATION_DETAILS_VOUCHER> DA_CONTRACT_AMORTIZATION_DETAILS_VOUCHER { get; set; }
        public virtual DbSet<DA_CONTRACT_APPLICATION> DA_CONTRACT_APPLICATION { get; set; }
        public virtual DbSet<DA_CONTRACT_APPROVEMENT> DA_CONTRACT_APPROVEMENT { get; set; }
        public virtual DbSet<DA_CONTRACT_ATTACHMENT> DA_CONTRACT_ATTACHMENT { get; set; }
        public virtual DbSet<DA_CONTRACT_CHECK_ITEM> DA_CONTRACT_CHECK_ITEM { get; set; }
        public virtual DbSet<DA_CONTRACT_CHEQUE> DA_CONTRACT_CHEQUE { get; set; }
        public virtual DbSet<DA_CONTRACT_COLLATERAL> DA_CONTRACT_COLLATERAL { get; set; }
        public virtual DbSet<DA_CONTRACT_CONTROL> DA_CONTRACT_CONTROL { get; set; }
        public virtual DbSet<DA_CONTRACT_CUSTOMER_CONTACT_LOG> DA_CONTRACT_CUSTOMER_CONTACT_LOG { get; set; }
        public virtual DbSet<DA_CONTRACT_HOUSEHOLD_REGISTRATION_APPLICATION> DA_CONTRACT_HOUSEHOLD_REGISTRATION_APPLICATION { get; set; }
        public virtual DbSet<DA_CONTRACT_INCOME> DA_CONTRACT_INCOME { get; set; }
        public virtual DbSet<DA_CONTRACT_INCOME_DETAIL> DA_CONTRACT_INCOME_DETAIL { get; set; }
        public virtual DbSet<DA_CONTRACT_INTERIM_ACCOUNT> DA_CONTRACT_INTERIM_ACCOUNT { get; set; }
        public virtual DbSet<DA_CONTRACT_LEGAL_ACTION_INSTRUCTION> DA_CONTRACT_LEGAL_ACTION_INSTRUCTION { get; set; }
        public virtual DbSet<DA_CONTRACT_LEGAL_ATTEST_LETTERS> DA_CONTRACT_LEGAL_ATTEST_LETTERS { get; set; }
        public virtual DbSet<DA_CONTRACT_LEGAL_PETITION> DA_CONTRACT_LEGAL_PETITION { get; set; }
        public virtual DbSet<DA_CONTRACT_MATCHED> DA_CONTRACT_MATCHED { get; set; }
        public virtual DbSet<DA_CONTRACT_MESSAGE> DA_CONTRACT_MESSAGE { get; set; }
        public virtual DbSet<DA_CONTRACT_PROPERTY> DA_CONTRACT_PROPERTY { get; set; }
        public virtual DbSet<DA_CONTRACT_PROPERTY_DETAIL> DA_CONTRACT_PROPERTY_DETAIL { get; set; }
        public virtual DbSet<DA_CONTRACT_REPAYMENT_DETAILS> DA_CONTRACT_REPAYMENT_DETAILS { get; set; }
        public virtual DbSet<DA_CONTRACT_REPAYMENT_DETAILS_VOUCHER> DA_CONTRACT_REPAYMENT_DETAILS_VOUCHER { get; set; }
        public virtual DbSet<DA_CONTRACT_TAXATION_INFORMATION_APPLICATION> DA_CONTRACT_TAXATION_INFORMATION_APPLICATION { get; set; }
        public virtual DbSet<DA_CONTRACTOR> DA_CONTRACTOR { get; set; }
        public virtual DbSet<DA_DEBIT_NOTE_CONTROL> DA_DEBIT_NOTE_CONTROL { get; set; }
        public virtual DbSet<DA_DEBIT_NOTE_DETAIL> DA_DEBIT_NOTE_DETAIL { get; set; }
        public virtual DbSet<DA_DEBIT_NOTE_WRITE_OFF> DA_DEBIT_NOTE_WRITE_OFF { get; set; }
        public virtual DbSet<EB_FORECLOSURE_EVALUATION> EB_FORECLOSURE_EVALUATION { get; set; }
        public virtual DbSet<EB_FORECLOSURE_EVALUATION_APPROVEMENT> EB_FORECLOSURE_EVALUATION_APPROVEMENT { get; set; }
        public virtual DbSet<EB_FORECLOSURE_EVALUATION_ATTACHMENT> EB_FORECLOSURE_EVALUATION_ATTACHMENT { get; set; }
        public virtual DbSet<EB_FORECLOSURE_EVALUATION_BUILDING_APPRASIAL> EB_FORECLOSURE_EVALUATION_BUILDING_APPRASIAL { get; set; }
        public virtual DbSet<EB_FORECLOSURE_EVALUATION_LAND_APPRASIAL> EB_FORECLOSURE_EVALUATION_LAND_APPRASIAL { get; set; }
        public virtual DbSet<EB_HOUSEHOLD_REGISTRATION_APPLICATION> EB_HOUSEHOLD_REGISTRATION_APPLICATION { get; set; }
        public virtual DbSet<EB_HOUSEHOLD_REGISTRATION_APPLICATION_ATTACHEMENT> EB_HOUSEHOLD_REGISTRATION_APPLICATION_ATTACHEMENT { get; set; }
        public virtual DbSet<EB_HOUSEHOLD_REGISTRATION_APPLICATION_INVOICE> EB_HOUSEHOLD_REGISTRATION_APPLICATION_INVOICE { get; set; }
        public virtual DbSet<EB_LEGAL_ATTEST_ATTACHEMENT> EB_LEGAL_ATTEST_ATTACHEMENT { get; set; }
        public virtual DbSet<EB_LEGAL_ATTEST_INVOICE> EB_LEGAL_ATTEST_INVOICE { get; set; }
        public virtual DbSet<EB_LEGAL_ATTEST_LETTERS> EB_LEGAL_ATTEST_LETTERS { get; set; }
        public virtual DbSet<EB_LEGAL_ATTEST_LETTERS_ADDRESSEE> EB_LEGAL_ATTEST_LETTERS_ADDRESSEE { get; set; }
        public virtual DbSet<EB_LEGAL_PETITION> EB_LEGAL_PETITION { get; set; }
        public virtual DbSet<EB_LEGAL_PETITION_ATTACHEMENT> EB_LEGAL_PETITION_ATTACHEMENT { get; set; }
        public virtual DbSet<EB_LEGAL_PETITION_INVOICE> EB_LEGAL_PETITION_INVOICE { get; set; }
        public virtual DbSet<EB_LEGAL_PETITION_RESPONDENT> EB_LEGAL_PETITION_RESPONDENT { get; set; }
        public virtual DbSet<EB_LEGAL_PETITION_THIRD_PARTY> EB_LEGAL_PETITION_THIRD_PARTY { get; set; }
        public virtual DbSet<EB_SEAL_UP_APPLICATION> EB_SEAL_UP_APPLICATION { get; set; }
        public virtual DbSet<EB_SEAL_UP_APPLICATION_APPROVEMENT> EB_SEAL_UP_APPLICATION_APPROVEMENT { get; set; }
        public virtual DbSet<EB_SEAL_UP_APPLICATION_ATTACHMENT> EB_SEAL_UP_APPLICATION_ATTACHMENT { get; set; }
        public virtual DbSet<EB_SEAL_UP_APPLICATION_BUILDING_APPRASIAL> EB_SEAL_UP_APPLICATION_BUILDING_APPRASIAL { get; set; }
        public virtual DbSet<EB_SEAL_UP_APPLICATION_LAND_APPRASIAL> EB_SEAL_UP_APPLICATION_LAND_APPRASIAL { get; set; }
        public virtual DbSet<EB_TAXATION_INFORMATION_APPLICATION> EB_TAXATION_INFORMATION_APPLICATION { get; set; }
        public virtual DbSet<EB_TAXATION_INFORMATION_APPLICATION_ATTACHEMENT> EB_TAXATION_INFORMATION_APPLICATION_ATTACHEMENT { get; set; }
        public virtual DbSet<EB_TAXATION_INFORMATION_APPLICATION_DEBTOR> EB_TAXATION_INFORMATION_APPLICATION_DEBTOR { get; set; }
        public virtual DbSet<EB_TAXATION_INFORMATION_APPLICATION_INVOICE> EB_TAXATION_INFORMATION_APPLICATION_INVOICE { get; set; }
        public virtual DbSet<FA_CHEQUE> FA_CHEQUE { get; set; }
        public virtual DbSet<FA_CHEQUE_COLLECTION> FA_CHEQUE_COLLECTION { get; set; }
        public virtual DbSet<FA_CHEQUE_COLLECTION_DETAIL> FA_CHEQUE_COLLECTION_DETAIL { get; set; }
        public virtual DbSet<FA_CHEQUE_RETURNED_PROCESS> FA_CHEQUE_RETURNED_PROCESS { get; set; }
        public virtual DbSet<FA_CHEQUE_RETURNED_PROCESS_CHECK> FA_CHEQUE_RETURNED_PROCESS_CHECK { get; set; }
        public virtual DbSet<FA_CHEQUE_RETURNED_PROCESS_DETAIL> FA_CHEQUE_RETURNED_PROCESS_DETAIL { get; set; }
        public virtual DbSet<FA_CHEQUE_RETURNED_PROCESS_NEWCHECK> FA_CHEQUE_RETURNED_PROCESS_NEWCHECK { get; set; }
        public virtual DbSet<FA_CHEQUE_RETURNED_PROCESS_VOUCHER> FA_CHEQUE_RETURNED_PROCESS_VOUCHER { get; set; }
        public virtual DbSet<FA_CHEQUE_RETURNED_REASON> FA_CHEQUE_RETURNED_REASON { get; set; }
        public virtual DbSet<FA_CHEQUE_WITHDRAW> FA_CHEQUE_WITHDRAW { get; set; }
        public virtual DbSet<FA_CHEQUE_WITHDRAW_DETAIL> FA_CHEQUE_WITHDRAW_DETAIL { get; set; }
        public virtual DbSet<FD_INVOICE_CONTROL> FD_INVOICE_CONTROL { get; set; }
        public virtual DbSet<FD_INVOICE_DETAIL> FD_INVOICE_DETAIL { get; set; }
        public virtual DbSet<FD_INVOICE_VOUCHER> FD_INVOICE_VOUCHER { get; set; }
        public virtual DbSet<GA_INTERIM_ACCOUNT_DETAIL> GA_INTERIM_ACCOUNT_DETAIL { get; set; }
        public virtual DbSet<GA_VOUCHER_CONTENT> GA_VOUCHER_CONTENT { get; set; }
        public virtual DbSet<GA_VOUCHER_CONTROL> GA_VOUCHER_CONTROL { get; set; }
        public virtual DbSet<GA_VOUCHER_DETAIL> GA_VOUCHER_DETAIL { get; set; }
        public virtual DbSet<IA_CUATOMER_SERVICE_APPLICATION> IA_CUATOMER_SERVICE_APPLICATION { get; set; }
        public virtual DbSet<IA_CUATOMER_SERVICE_APPLICATION_APPROVEMENT> IA_CUATOMER_SERVICE_APPLICATION_APPROVEMENT { get; set; }
        public virtual DbSet<IA_CUATOMER_SERVICE_APPLICATION_ATTACHMENT> IA_CUATOMER_SERVICE_APPLICATION_ATTACHMENT { get; set; }
        public virtual DbSet<JA_COMPANY> JA_COMPANY { get; set; }
        public virtual DbSet<JA_DATEBOOK> JA_DATEBOOK { get; set; }
        public virtual DbSet<JA_DEPUTY> JA_DEPUTY { get; set; }
        public virtual DbSet<JA_DIVISION> JA_DIVISION { get; set; }
        public virtual DbSet<JA_EMPOLYEE> JA_EMPOLYEE { get; set; }
        public virtual DbSet<JA_EMPOLYEE_ATTACHMENT> JA_EMPOLYEE_ATTACHMENT { get; set; }
        public virtual DbSet<JA_EMPOLYEE_LEAVE> JA_EMPOLYEE_LEAVE { get; set; }
        public virtual DbSet<JA_HOLIDAY> JA_HOLIDAY { get; set; }
        public virtual DbSet<JA_JOB_TILE> JA_JOB_TILE { get; set; }
        public virtual DbSet<JA_LEAVE> JA_LEAVE { get; set; }
        public virtual DbSet<UA_APPROVEMENT_ATTACHMENT> UA_APPROVEMENT_ATTACHMENT { get; set; }
        public virtual DbSet<UA_APPROVEMENT_CONTROL_RECORD> UA_APPROVEMENT_CONTROL_RECORD { get; set; }
        public virtual DbSet<UA_APPROVEMENT_DETAIL_RECORD> UA_APPROVEMENT_DETAIL_RECORD { get; set; }
        public virtual DbSet<UA_SCHEDULE_SIGN_SEQUENCE> UA_SCHEDULE_SIGN_SEQUENCE { get; set; }
        public virtual DbSet<UA_SIGN_FLOW> UA_SIGN_FLOW { get; set; }
        public virtual DbSet<WA_MESSAGE> WA_MESSAGE { get; set; }
        public virtual DbSet<WA_MESSAGE_ADDRESSEE> WA_MESSAGE_ADDRESSEE { get; set; }
        public virtual DbSet<XZ_ATTACHMENT> XZ_ATTACHMENT { get; set; }
        public virtual DbSet<XZ_BANK> XZ_BANK { get; set; }
        public virtual DbSet<XZ_BANKBRANCH> XZ_BANKBRANCH { get; set; }
        public virtual DbSet<XZ_BLACKLIST> XZ_BLACKLIST { get; set; }
        public virtual DbSet<XZ_BLACKLIST_LOG> XZ_BLACKLIST_LOG { get; set; }
        public virtual DbSet<XZ_BULLETIN> XZ_BULLETIN { get; set; }
        public virtual DbSet<XZ_BULLETIN_ATTACHMENT> XZ_BULLETIN_ATTACHMENT { get; set; }
        public virtual DbSet<XZ_BUSINESS> XZ_BUSINESS { get; set; }
        public virtual DbSet<XZ_DATA_DICTIONARY> XZ_DATA_DICTIONARY { get; set; }
        public virtual DbSet<XZ_DATA_IDENTIFIER_MEANING> XZ_DATA_IDENTIFIER_MEANING { get; set; }
        public virtual DbSet<XZ_DOCUMENT> XZ_DOCUMENT { get; set; }
        public virtual DbSet<XZ_DOCUMENT_BY_BUSSINES> XZ_DOCUMENT_BY_BUSSINES { get; set; }
        public virtual DbSet<XZ_FUND_SPEC> XZ_FUND_SPEC { get; set; }
        public virtual DbSet<XZ_SERIAL_NUMBER> XZ_SERIAL_NUMBER { get; set; }
        public virtual DbSet<YA_FUNCTIONS> YA_FUNCTIONS { get; set; }
        public virtual DbSet<YA_MENU> YA_MENU { get; set; }
        public virtual DbSet<YA_MENU_SUB> YA_MENU_SUB { get; set; }
        public virtual DbSet<YA_ROLE_DIVISION> YA_ROLE_DIVISION { get; set; }
        public virtual DbSet<YA_ROLE_FUNCTIONS> YA_ROLE_FUNCTIONS { get; set; }
        public virtual DbSet<YA_ROLE_USERS> YA_ROLE_USERS { get; set; }
        public virtual DbSet<YA_ROLES> YA_ROLES { get; set; }
        public virtual DbSet<ZZ_APPLIACTION_DOCUMENT_CHECK> ZZ_APPLIACTION_DOCUMENT_CHECK { get; set; }
        public virtual DbSet<ZZ_APPLIACTION_MESSAGE> ZZ_APPLIACTION_MESSAGE { get; set; }
        public virtual DbSet<ZZ_APPLICATION> ZZ_APPLICATION { get; set; }
        public virtual DbSet<ZZ_APPLICATION_APPROVEMENT> ZZ_APPLICATION_APPROVEMENT { get; set; }
        public virtual DbSet<ZZ_APPLICATION_ATTACHMENT> ZZ_APPLICATION_ATTACHMENT { get; set; }
        public virtual DbSet<ZZ_APPLICATION_LOANINFO> ZZ_APPLICATION_LOANINFO { get; set; }
        public virtual DbSet<ZZ_APPLICATION_LOANINFO_LOG> ZZ_APPLICATION_LOANINFO_LOG { get; set; }
        public virtual DbSet<ZZ_APPLICATION_LOG> ZZ_APPLICATION_LOG { get; set; }
        public virtual DbSet<ZZ_BORROWER_NTOTE_CREDIT> ZZ_BORROWER_NTOTE_CREDIT { get; set; }
        public virtual DbSet<ZZ_BORROWER_NTOTE_CREDIT_DETAIL> ZZ_BORROWER_NTOTE_CREDIT_DETAIL { get; set; }
        public virtual DbSet<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_ACCESSORY> ZZ_BUILDING_OWNERSHIP_CERTIFICATE_ACCESSORY { get; set; }
        public virtual DbSet<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_APPRASIAL> ZZ_BUILDING_OWNERSHIP_CERTIFICATE_APPRASIAL { get; set; }
        public virtual DbSet<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_DESCRIPTION> ZZ_BUILDING_OWNERSHIP_CERTIFICATE_DESCRIPTION { get; set; }
        public virtual DbSet<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_ONWER_RIGHTS> ZZ_BUILDING_OWNERSHIP_CERTIFICATE_ONWER_RIGHTS { get; set; }
        public virtual DbSet<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_OTHER_RIGHTS> ZZ_BUILDING_OWNERSHIP_CERTIFICATE_OTHER_RIGHTS { get; set; }
        public virtual DbSet<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_SHARESECTION> ZZ_BUILDING_OWNERSHIP_CERTIFICATE_SHARESECTION { get; set; }
        public virtual DbSet<ZZ_LAND_OWNERSHIP_CERTIFICATE_APPRASIAL> ZZ_LAND_OWNERSHIP_CERTIFICATE_APPRASIAL { get; set; }
        public virtual DbSet<ZZ_LAND_OWNERSHIP_CERTIFICATE_DESCRIPTION> ZZ_LAND_OWNERSHIP_CERTIFICATE_DESCRIPTION { get; set; }
        public virtual DbSet<ZZ_LAND_OWNERSHIP_CERTIFICATE_ONWER_RIGHTS> ZZ_LAND_OWNERSHIP_CERTIFICATE_ONWER_RIGHTS { get; set; }
        public virtual DbSet<ZZ_LOAN_RELATED_PARTIES> ZZ_LOAN_RELATED_PARTIES { get; set; }
        public virtual DbSet<ZZ_LOAN_RELATED_PARTIES_ATTACHMENT> ZZ_LOAN_RELATED_PARTIES_ATTACHMENT { get; set; }
        public virtual DbSet<ZZ_PERSONAL_CREDIT_REPORT> ZZ_PERSONAL_CREDIT_REPORT { get; set; }
        public virtual DbSet<ZZ_PERSONAL_CREDIT_REPORT_BADDEBT> ZZ_PERSONAL_CREDIT_REPORT_BADDEBT { get; set; }
        public virtual DbSet<ZZ_PERSONAL_CREDIT_REPORT_BANKLOAN> ZZ_PERSONAL_CREDIT_REPORT_BANKLOAN { get; set; }
        public virtual DbSet<ZZ_PERSONAL_CREDIT_REPORT_CREDITCARD> ZZ_PERSONAL_CREDIT_REPORT_CREDITCARD { get; set; }
        public virtual DbSet<ZZ_PERSONAL_CREDIT_REPORT_CREDITCARD_ACCOUNT> ZZ_PERSONAL_CREDIT_REPORT_CREDITCARD_ACCOUNT { get; set; }
        public virtual DbSet<ZZ_PERSONAL_CREDIT_REPORT_DBR22> ZZ_PERSONAL_CREDIT_REPORT_DBR22 { get; set; }
        public virtual DbSet<ZZ_PERSONAL_CREDIT_REPORT_DBR22_CONTENT> ZZ_PERSONAL_CREDIT_REPORT_DBR22_CONTENT { get; set; }
        public virtual DbSet<ZZ_PERSONAL_CREDIT_REPORT_QUERY> ZZ_PERSONAL_CREDIT_REPORT_QUERY { get; set; }
    }
}
