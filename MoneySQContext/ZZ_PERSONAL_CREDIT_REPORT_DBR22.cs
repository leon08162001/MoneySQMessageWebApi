using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("ZZ_PERSONAL_CREDIT_REPORT_DBR22")]
    public class ZZ_PERSONAL_CREDIT_REPORT_DBR22
    {
        public ZZ_PERSONAL_CREDIT_REPORT_DBR22()
        {
            this.ZzPersonalCreditReportDbR22Contents = new List<ZZ_PERSONAL_CREDIT_REPORT_DBR22_CONTENT>();
            this.ZzPersonalCreditReportDbR22Contents1 = new List<ZZ_PERSONAL_CREDIT_REPORT_DBR22_CONTENT>();
            this.ZzPersonalCreditReportDbR22Contents2 = new List<ZZ_PERSONAL_CREDIT_REPORT_DBR22_CONTENT>();
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
        public virtual DateTime? loan_balance_data_date { get; set; }
        public virtual DateTime? cash_card_data_date { get; set; }
        public virtual DateTime? credit_card_start_date { get; set; }
        public virtual DateTime? credit_card_end_date { get; set; }
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
        public List<ZZ_PERSONAL_CREDIT_REPORT_DBR22_CONTENT> ZzPersonalCreditReportDbR22Contents { get; set; }
        public List<ZZ_PERSONAL_CREDIT_REPORT_DBR22_CONTENT> ZzPersonalCreditReportDbR22Contents1 { get; set; }
        public List<ZZ_PERSONAL_CREDIT_REPORT_DBR22_CONTENT> ZzPersonalCreditReportDbR22Contents2 { get; set; }
    }
}
