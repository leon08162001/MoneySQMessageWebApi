using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("ZZ_APPLICATION_LOANINFO")]
    public class ZZ_APPLICATION_LOANINFO
    {
        public ZZ_APPLICATION_LOANINFO()
        {
            this.CbCreditCheckReprots = new List<CB_CREDIT_CHECK_REPROT>();
            this.ZzAppliactionDocumentChecks = new List<ZZ_APPLIACTION_DOCUMENT_CHECK>();
            this.ZzBorrowerNtoteCredits = new List<ZZ_BORROWER_NTOTE_CREDIT>();
            this.ShippedBy = new List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_DESCRIPTION>();
            this.ShippedBy1 = new List<ZZ_LAND_OWNERSHIP_CERTIFICATE_DESCRIPTION>();
            this.ZzLoanRelatedParties = new List<ZZ_LOAN_RELATED_PARTIES>();
            this.ZzPersonalCreditReports = new List<ZZ_PERSONAL_CREDIT_REPORT>();
            this.ZzPersonalCreditReportDbR22 = new List<ZZ_PERSONAL_CREDIT_REPORT_DBR22>();
            this.CbCreditCheckReprots1 = new List<CB_CREDIT_CHECK_REPROT>();
            this.ZzAppliactionDocumentChecks1 = new List<ZZ_APPLIACTION_DOCUMENT_CHECK>();
            this.ZzBorrowerNtoteCredits1 = new List<ZZ_BORROWER_NTOTE_CREDIT>();
            this.ShippedBy2 = new List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_DESCRIPTION>();
            this.ShippedBy3 = new List<ZZ_LAND_OWNERSHIP_CERTIFICATE_DESCRIPTION>();
            this.ZzLoanRelatedParties1 = new List<ZZ_LOAN_RELATED_PARTIES>();
            this.ZzPersonalCreditReports1 = new List<ZZ_PERSONAL_CREDIT_REPORT>();
            this.ZzPersonalCreditReportDbR221 = new List<ZZ_PERSONAL_CREDIT_REPORT_DBR22>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string application_no { get; set; }
        [MaxLength(3)]
        public virtual string loan_purpose_code { get; set; }
        [MaxLength(2000)]
        public virtual string purpose_for_applying { get; set; }
        [MaxLength(3)]
        public virtual string repayment_method_code { get; set; }
        [MaxLength(3)]
        public virtual string employment_status_code { get; set; }
        [MaxLength(255)]
        public virtual string industry_category { get; set; }
        [MaxLength(255)]
        public virtual string job_position { get; set; }
        [MaxLength(255)]
        public virtual string company_name { get; set; }
        [MaxLength(255)]
        public virtual string office_phone_no { get; set; }
        [MaxLength(255)]
        public virtual string office_address { get; set; }
        public virtual DateTime? onboard_date { get; set; }
        public virtual decimal? monthly_salary { get; set; }
        public virtual decimal? yearly_salary { get; set; }
        [MaxLength(255)]
        public virtual string salary_pay_day { get; set; }
        public virtual decimal? other_income { get; set; }
        [MaxLength(100)]
        public virtual string realestate_address { get; set; }
        [MaxLength(5)]
        public virtual string realestate_address_zipcode { get; set; }
        [MaxLength(100)]
        public virtual string realestate_address_city { get; set; }
        [MaxLength(100)]
        public virtual string realestate_address_town { get; set; }
        [MaxLength(100)]
        public virtual string realestate_address_street { get; set; }
        [MaxLength(100)]
        public virtual string realestate_address_li { get; set; }
        [MaxLength(100)]
        public virtual string realestate_address_lin { get; set; }
        [MaxLength(100)]
        public virtual string realestate_address_section { get; set; }
        [MaxLength(100)]
        public virtual string realestate_address_lane { get; set; }
        [MaxLength(100)]
        public virtual string realestate_address_alley { get; set; }
        [MaxLength(100)]
        public virtual string realestate_address_no { get; set; }
        [MaxLength(100)]
        public virtual string realestate_address_floor { get; set; }
        [MaxLength(100)]
        public virtual string realestate_address_room { get; set; }
        [MaxLength(100)]
        public virtual string ping { get; set; }
        [MaxLength(100)]
        public virtual string occupation_ratio { get; set; }
        [MaxLength(255)]
        public virtual string buliding_ages { get; set; }
        [MaxLength(255)]
        public virtual string rent_ages { get; set; }
        [MaxLength(3)]
        public virtual string currency_type { get; set; }
        public virtual decimal? predecessors_oustanding_balance { get; set; }
        [MaxLength(3)]
        public virtual string parking_holding_code { get; set; }
        [MaxLength(255)]
        public virtual string ping_of_praking_spaces { get; set; }
        [MaxLength(255)]
        public virtual string rent_description { get; set; }
        [MaxLength(255)]
        public virtual string loan_bank { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public ZZ_APPLICATION ZzApplication { get; set; }
        public ZZ_APPLICATION ZzApplication1 { get; set; }
        public List<CB_CREDIT_CHECK_REPROT> CbCreditCheckReprots { get; set; }
        public List<ZZ_APPLIACTION_DOCUMENT_CHECK> ZzAppliactionDocumentChecks { get; set; }
        public List<ZZ_BORROWER_NTOTE_CREDIT> ZzBorrowerNtoteCredits { get; set; }
        public List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_DESCRIPTION> ShippedBy { get; set; }
        public List<ZZ_LAND_OWNERSHIP_CERTIFICATE_DESCRIPTION> ShippedBy1 { get; set; }
        public List<ZZ_LOAN_RELATED_PARTIES> ZzLoanRelatedParties { get; set; }
        public List<ZZ_PERSONAL_CREDIT_REPORT> ZzPersonalCreditReports { get; set; }
        public List<ZZ_PERSONAL_CREDIT_REPORT_DBR22> ZzPersonalCreditReportDbR22 { get; set; }
        public List<CB_CREDIT_CHECK_REPROT> CbCreditCheckReprots1 { get; set; }
        public List<ZZ_APPLIACTION_DOCUMENT_CHECK> ZzAppliactionDocumentChecks1 { get; set; }
        public List<ZZ_BORROWER_NTOTE_CREDIT> ZzBorrowerNtoteCredits1 { get; set; }
        public List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_DESCRIPTION> ShippedBy2 { get; set; }
        public List<ZZ_LAND_OWNERSHIP_CERTIFICATE_DESCRIPTION> ShippedBy3 { get; set; }
        public List<ZZ_LOAN_RELATED_PARTIES> ZzLoanRelatedParties1 { get; set; }
        public List<ZZ_PERSONAL_CREDIT_REPORT> ZzPersonalCreditReports1 { get; set; }
        public List<ZZ_PERSONAL_CREDIT_REPORT_DBR22> ZzPersonalCreditReportDbR221 { get; set; }
    }
}
