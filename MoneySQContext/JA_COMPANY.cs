using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("JA_COMPANY")]
    public class JA_COMPANY
    {
        public JA_COMPANY()
        {
            this.CbCreditCheckReprots = new List<CB_CREDIT_CHECK_REPROT>();
            this.CbCreditRiskRankVsesions = new List<CB_CREDIT_RISK_RANK_VSESION>();
            this.CbScoringCardVersions = new List<CB_SCORING_CARD_VERSION>();
            this.CcAppraisalReports = new List<CC_APPRAISAL_REPORT>();
            this.DaContracts = new List<DA_CONTRACT>();
            this.GaInterimAccountDetails = new List<GA_INTERIM_ACCOUNT_DETAIL>();
            this.GaVoucherControls = new List<GA_VOUCHER_CONTROL>();
            this.JaDivisions = new List<JA_DIVISION>();
            this.JaEmpolyees = new List<JA_EMPOLYEE>();
            this.JaJobTiles = new List<JA_JOB_TILE>();
            this.UaApprovementDetailRecords = new List<UA_APPROVEMENT_DETAIL_RECORD>();
            this.UaSignFlows = new List<UA_SIGN_FLOW>();
            this.XzBlacklists = new List<XZ_BLACKLIST>();
            this.XzBulletins = new List<XZ_BULLETIN>();
            this.XzBusinesses = new List<XZ_BUSINESS>();
            this.XzDataDictionaries = new List<XZ_DATA_DICTIONARY>();
            this.XzDocuments = new List<XZ_DOCUMENT>();
            this.XzFundSpecs = new List<XZ_FUND_SPEC>();
            this.XzSerialNumbers = new List<XZ_SERIAL_NUMBER>();
            this.YaMenus = new List<YA_MENU>();
            this.ZzApplications = new List<ZZ_APPLICATION>();
        }

        [Key]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [MaxLength(255)]
        public virtual string company_name { get; set; }
        public virtual DateTime establish_date { get; set; }
        public virtual DateTime? dissolve_date { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public List<CB_CREDIT_CHECK_REPROT> CbCreditCheckReprots { get; set; }
        public List<CB_CREDIT_RISK_RANK_VSESION> CbCreditRiskRankVsesions { get; set; }
        public List<CB_SCORING_CARD_VERSION> CbScoringCardVersions { get; set; }
        public List<CC_APPRAISAL_REPORT> CcAppraisalReports { get; set; }
        public List<DA_CONTRACT> DaContracts { get; set; }
        public List<GA_INTERIM_ACCOUNT_DETAIL> GaInterimAccountDetails { get; set; }
        public List<GA_VOUCHER_CONTROL> GaVoucherControls { get; set; }
        public List<JA_DIVISION> JaDivisions { get; set; }
        public List<JA_EMPOLYEE> JaEmpolyees { get; set; }
        public List<JA_JOB_TILE> JaJobTiles { get; set; }
        public List<UA_APPROVEMENT_DETAIL_RECORD> UaApprovementDetailRecords { get; set; }
        public List<UA_SIGN_FLOW> UaSignFlows { get; set; }
        public List<XZ_BLACKLIST> XzBlacklists { get; set; }
        public List<XZ_BULLETIN> XzBulletins { get; set; }
        public List<XZ_BUSINESS> XzBusinesses { get; set; }
        public List<XZ_DATA_DICTIONARY> XzDataDictionaries { get; set; }
        public List<XZ_DOCUMENT> XzDocuments { get; set; }
        public List<XZ_FUND_SPEC> XzFundSpecs { get; set; }
        public List<XZ_SERIAL_NUMBER> XzSerialNumbers { get; set; }
        public List<YA_MENU> YaMenus { get; set; }
        public List<ZZ_APPLICATION> ZzApplications { get; set; }
    }
}
