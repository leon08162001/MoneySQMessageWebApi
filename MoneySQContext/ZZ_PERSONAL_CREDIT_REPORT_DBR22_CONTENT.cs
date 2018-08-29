using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("ZZ_PERSONAL_CREDIT_REPORT_DBR22_CONTENT")]
    public class ZZ_PERSONAL_CREDIT_REPORT_DBR22_CONTENT
    {
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
        [Key]
        [Column(Order = 4)]
        [MaxLength(100)]
        public virtual string financial_Institution_name { get; set; }
        [MaxLength(3)]
        public virtual string currency_type { get; set; }
        public virtual decimal? unsecured_loan_balance { get; set; }
        public virtual decimal? cash_card_loan_balance { get; set; }
        public virtual decimal? revolving_credit_balance { get; set; }
        public virtual decimal? credit_card_due_account { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public ZZ_PERSONAL_CREDIT_REPORT_DBR22 ZzPersonalCreditReportDbR22 { get; set; }
        public ZZ_PERSONAL_CREDIT_REPORT_DBR22 ZzPersonalCreditReportDbR221 { get; set; }
        public ZZ_PERSONAL_CREDIT_REPORT_DBR22 ZzPersonalCreditReportDbR222 { get; set; }
    }
}
