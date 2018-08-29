using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("ZZ_PERSONAL_CREDIT_REPORT")]
    public class ZZ_PERSONAL_CREDIT_REPORT
    {
        public ZZ_PERSONAL_CREDIT_REPORT()
        {
            this.ZzPersonalCreditReportBaddebts = new List<ZZ_PERSONAL_CREDIT_REPORT_BADDEBT>();
            this.ZzPersonalCreditReportBankloans = new List<ZZ_PERSONAL_CREDIT_REPORT_BANKLOAN>();
            this.ZzPersonalCreditReportCreditcards = new List<ZZ_PERSONAL_CREDIT_REPORT_CREDITCARD>();
            this.ZzPersonalCreditReportCreditcardAccounts = new List<ZZ_PERSONAL_CREDIT_REPORT_CREDITCARD_ACCOUNT>();
            this.ZzPersonalCreditReportBaddebts1 = new List<ZZ_PERSONAL_CREDIT_REPORT_BADDEBT>();
            this.ZzPersonalCreditReportBankloans1 = new List<ZZ_PERSONAL_CREDIT_REPORT_BANKLOAN>();
            this.ZzPersonalCreditReportCreditcards1 = new List<ZZ_PERSONAL_CREDIT_REPORT_CREDITCARD>();
            this.ZzPersonalCreditReportCreditcardAccounts1 = new List<ZZ_PERSONAL_CREDIT_REPORT_CREDITCARD_ACCOUNT>();
            this.ZzPersonalCreditReportBaddebts2 = new List<ZZ_PERSONAL_CREDIT_REPORT_BADDEBT>();
            this.ZzPersonalCreditReportBankloans2 = new List<ZZ_PERSONAL_CREDIT_REPORT_BANKLOAN>();
            this.ZzPersonalCreditReportCreditcards2 = new List<ZZ_PERSONAL_CREDIT_REPORT_CREDITCARD>();
            this.ZzPersonalCreditReportCreditcardAccounts2 = new List<ZZ_PERSONAL_CREDIT_REPORT_CREDITCARD_ACCOUNT>();
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
        public virtual int attachment_id { get; set; }
        [MaxLength(50)]
        public virtual string social_security_number { get; set; }
        public virtual DateTime prinrted_date { get; set; }
        [MaxLength(50)]
        public virtual string report_no { get; set; }
        [MaxLength(10)]
        public virtual string notification_mark { get; set; }
        public virtual short credit_score { get; set; }
        public virtual short? yearmonth_of_bankloan_data { get; set; }
        public virtual short? yearmonth_of_baddebt_data { get; set; }
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
        public XZ_ATTACHMENT XzAttachment { get; set; }
        public ZZ_APPLICATION_LOANINFO ZzApplicationLoaninfo1 { get; set; }
        public XZ_ATTACHMENT XzAttachment1 { get; set; }
        public List<ZZ_PERSONAL_CREDIT_REPORT_BADDEBT> ZzPersonalCreditReportBaddebts { get; set; }
        public List<ZZ_PERSONAL_CREDIT_REPORT_BANKLOAN> ZzPersonalCreditReportBankloans { get; set; }
        public List<ZZ_PERSONAL_CREDIT_REPORT_CREDITCARD> ZzPersonalCreditReportCreditcards { get; set; }
        public List<ZZ_PERSONAL_CREDIT_REPORT_CREDITCARD_ACCOUNT> ZzPersonalCreditReportCreditcardAccounts { get; set; }
        public List<ZZ_PERSONAL_CREDIT_REPORT_BADDEBT> ZzPersonalCreditReportBaddebts1 { get; set; }
        public List<ZZ_PERSONAL_CREDIT_REPORT_BANKLOAN> ZzPersonalCreditReportBankloans1 { get; set; }
        public List<ZZ_PERSONAL_CREDIT_REPORT_CREDITCARD> ZzPersonalCreditReportCreditcards1 { get; set; }
        public List<ZZ_PERSONAL_CREDIT_REPORT_CREDITCARD_ACCOUNT> ZzPersonalCreditReportCreditcardAccounts1 { get; set; }
        public List<ZZ_PERSONAL_CREDIT_REPORT_BADDEBT> ZzPersonalCreditReportBaddebts2 { get; set; }
        public List<ZZ_PERSONAL_CREDIT_REPORT_BANKLOAN> ZzPersonalCreditReportBankloans2 { get; set; }
        public List<ZZ_PERSONAL_CREDIT_REPORT_CREDITCARD> ZzPersonalCreditReportCreditcards2 { get; set; }
        public List<ZZ_PERSONAL_CREDIT_REPORT_CREDITCARD_ACCOUNT> ZzPersonalCreditReportCreditcardAccounts2 { get; set; }
    }
}
