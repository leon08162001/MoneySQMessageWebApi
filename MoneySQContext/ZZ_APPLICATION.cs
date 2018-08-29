using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("ZZ_APPLICATION")]
    public class ZZ_APPLICATION
    {
        public ZZ_APPLICATION()
        {
            this.DaContractApplications = new List<DA_CONTRACT_APPLICATION>();
            this.ZzAppliactionMessages = new List<ZZ_APPLIACTION_MESSAGE>();
            this.ZzApplicationApprovements = new List<ZZ_APPLICATION_APPROVEMENT>();
            this.ZzApplicationAttachments = new List<ZZ_APPLICATION_ATTACHMENT>();
            this.DaContractApplications1 = new List<DA_CONTRACT_APPLICATION>();
            this.ZzAppliactionMessages1 = new List<ZZ_APPLIACTION_MESSAGE>();
            this.ZzApplicationApprovements1 = new List<ZZ_APPLICATION_APPROVEMENT>();
            this.ZzApplicationAttachments1 = new List<ZZ_APPLICATION_ATTACHMENT>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string application_no { get; set; }
        [MaxLength(50)]
        public virtual string application_no_front { get; set; }
        [MaxLength(3)]
        public virtual string application_category { get; set; }
        public virtual DateTime? date_of_application { get; set; }
        [MaxLength(3)]
        public virtual string status_of_application { get; set; }
        [MaxLength(3)]
        public virtual string data_created_method { get; set; }
        [MaxLength(3)]
        public virtual string type_of_applicant { get; set; }
        [MaxLength(100)]
        public virtual string idno_of_applicant { get; set; }
        [MaxLength(255)]
        public virtual string name_of_applicant { get; set; }
        public virtual DateTime? birthday { get; set; }
        [MaxLength(3)]
        public virtual string sex_code { get; set; }
        public virtual DateTime? issue_date { get; set; }
        [MaxLength(3)]
        public virtual string issue_category { get; set; }
        [MaxLength(50)]
        public virtual string name_of_father { get; set; }
        [MaxLength(50)]
        public virtual string name_of_mother { get; set; }
        [MaxLength(50)]
        public virtual string name_of_spouse { get; set; }
        [MaxLength(50)]
        public virtual string birthplace { get; set; }
        [MaxLength(50)]
        public virtual string military_category { get; set; }
        [MaxLength(50)]
        public virtual string identity_card_no { get; set; }
        [MaxLength(50)]
        public virtual string nhi_ic_card_no { get; set; }
        [MaxLength(2)]
        public virtual string issue_city { get; set; }
        public virtual DateTime? setup_date { get; set; }
        [MaxLength(3)]
        public virtual string currency_type { get; set; }
        public virtual decimal? amt_for_applying { get; set; }
        public virtual short? period_for_applying { get; set; }
        [MaxLength(255)]
        public virtual string programid_for_applying { get; set; }
        public virtual short? empolyeeno_of_service_staff { get; set; }
        public virtual short? empolyeeno_for_performance { get; set; }
        [MaxLength(10)]
        public virtual string divisioncode_for_performance { get; set; }
        [MaxLength(255)]
        public virtual string permanent_address { get; set; }
        [MaxLength(5)]
        public virtual string permanent_address_zipcode { get; set; }
        [MaxLength(20)]
        public virtual string permanent_address_city { get; set; }
        [MaxLength(20)]
        public virtual string permanent_address_town { get; set; }
        [MaxLength(20)]
        public virtual string permanent_address_street { get; set; }
        [MaxLength(20)]
        public virtual string permanent_address_li { get; set; }
        [MaxLength(6)]
        public virtual string permanent_address_lin { get; set; }
        [MaxLength(6)]
        public virtual string permanent_address_section { get; set; }
        [MaxLength(6)]
        public virtual string permanent_address_lane { get; set; }
        [MaxLength(6)]
        public virtual string permanent_address_alley { get; set; }
        [MaxLength(6)]
        public virtual string permanent_address_no { get; set; }
        [MaxLength(6)]
        public virtual string permanent_address_floor { get; set; }
        [MaxLength(6)]
        public virtual string permanent_address_room { get; set; }
        [MaxLength(255)]
        public virtual string mailing_address { get; set; }
        [MaxLength(5)]
        public virtual string mailing_address_zipcode { get; set; }
        [MaxLength(20)]
        public virtual string mailing_address_city { get; set; }
        [MaxLength(20)]
        public virtual string mailing_address_town { get; set; }
        [MaxLength(20)]
        public virtual string mailing_address_street { get; set; }
        [MaxLength(20)]
        public virtual string mailing_addresss_li { get; set; }
        [MaxLength(6)]
        public virtual string mailing_addresss_lin { get; set; }
        [MaxLength(6)]
        public virtual string mailing_address_section { get; set; }
        [MaxLength(6)]
        public virtual string mailing_address_lane { get; set; }
        [MaxLength(6)]
        public virtual string mailing_address_alley { get; set; }
        [MaxLength(6)]
        public virtual string mailing_address_no { get; set; }
        [MaxLength(6)]
        public virtual string mailing_address_floor { get; set; }
        [MaxLength(6)]
        public virtual string mailing_address_room { get; set; }
        [MaxLength(255)]
        public virtual string email { get; set; }
        [MaxLength(40)]
        public virtual string cell_phone { get; set; }
        [MaxLength(255)]
        public virtual string job_title { get; set; }
        [MaxLength(3)]
        public virtual string education_level_cd { get; set; }
        [MaxLength(3)]
        public virtual string living_condition_cd { get; set; }
        [MaxLength(3)]
        public virtual string monthly_income_code { get; set; }
        [MaxLength(3)]
        public virtual string marital_status_cd { get; set; }
        [MaxLength(3)]
        public virtual string digital_certificate_status { get; set; }
        [MaxLength(3)]
        public virtual string consent_letter_sign_status { get; set; }
        [MaxLength(3)]
        public virtual string applicant_bankcode { get; set; }
        [MaxLength(4)]
        public virtual string applicant_bankbranch_code { get; set; }
        [MaxLength(50)]
        public virtual string applicant_bank_account { get; set; }
        public virtual decimal? suggested_interest_rate { get; set; }
        public virtual decimal? suggested_amt { get; set; }
        [MaxLength(3)]
        public virtual string suggested_contract_type { get; set; }
        [MaxLength(2000)]
        public virtual string suggested_opinion { get; set; }
        public virtual decimal? approved_interest_rate { get; set; }
        public virtual decimal? approved_amt { get; set; }
        [MaxLength(3)]
        public virtual string approved_contract_type { get; set; }
        public virtual DateTime? datetime_of_acceptence { get; set; }
        public virtual short? case_officer_employeeno { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }
        public virtual bool? enable_push { get; set; }

        public JA_COMPANY JaCompany { get; set; }
        public List<DA_CONTRACT_APPLICATION> DaContractApplications { get; set; }
        public List<ZZ_APPLIACTION_MESSAGE> ZzAppliactionMessages { get; set; }
        public List<ZZ_APPLICATION_APPROVEMENT> ZzApplicationApprovements { get; set; }
        public List<ZZ_APPLICATION_ATTACHMENT> ZzApplicationAttachments { get; set; }
        public ZZ_APPLICATION_LOANINFO ZzApplicationLoaninfo { get; set; }
        public List<DA_CONTRACT_APPLICATION> DaContractApplications1 { get; set; }
        public List<ZZ_APPLIACTION_MESSAGE> ZzAppliactionMessages1 { get; set; }
        public List<ZZ_APPLICATION_APPROVEMENT> ZzApplicationApprovements1 { get; set; }
        public List<ZZ_APPLICATION_ATTACHMENT> ZzApplicationAttachments1 { get; set; }
        public ZZ_APPLICATION_LOANINFO ZzApplicationLoaninfo1 { get; set; }
    }
}
