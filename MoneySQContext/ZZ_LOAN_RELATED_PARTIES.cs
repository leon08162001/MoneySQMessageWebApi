using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("ZZ_LOAN_RELATED_PARTIES")]
    public class ZZ_LOAN_RELATED_PARTIES
    {
        public ZZ_LOAN_RELATED_PARTIES()
        {
            this.ZzLoanRelatedPartiesAttachments = new List<ZZ_LOAN_RELATED_PARTIES_ATTACHMENT>();
            this.ZzLoanRelatedPartiesAttachments1 = new List<ZZ_LOAN_RELATED_PARTIES_ATTACHMENT>();
            this.ZzLoanRelatedPartiesAttachments2 = new List<ZZ_LOAN_RELATED_PARTIES_ATTACHMENT>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string application_no { get; set; }
        [Key]
        [Column(Order = 3)]
        [MaxLength(50)]
        public virtual string social_security_number { get; set; }
        [MaxLength(255)]
        public virtual string related_parties_name { get; set; }
        [MaxLength(3)]
        public virtual string status { get; set; }
        [MaxLength(3)]
        public virtual string related_parties_category { get; set; }
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
        public virtual string military_category { get; set; }
        [MaxLength(50)]
        public virtual string identity_card_no { get; set; }
        [MaxLength(2)]
        public virtual string issue_city { get; set; }
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
        public virtual string consent_letter_sign_status { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public ZZ_APPLICATION_LOANINFO ZzApplicationLoaninfo { get; set; }
        public ZZ_APPLICATION_LOANINFO ZzApplicationLoaninfo1 { get; set; }
        public List<ZZ_LOAN_RELATED_PARTIES_ATTACHMENT> ZzLoanRelatedPartiesAttachments { get; set; }
        public List<ZZ_LOAN_RELATED_PARTIES_ATTACHMENT> ZzLoanRelatedPartiesAttachments1 { get; set; }
        public List<ZZ_LOAN_RELATED_PARTIES_ATTACHMENT> ZzLoanRelatedPartiesAttachments2 { get; set; }
    }
}
