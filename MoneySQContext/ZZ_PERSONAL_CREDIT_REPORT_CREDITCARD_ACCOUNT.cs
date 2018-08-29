using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("ZZ_PERSONAL_CREDIT_REPORT_CREDITCARD_ACCOUNT")]
    public class ZZ_PERSONAL_CREDIT_REPORT_CREDITCARD_ACCOUNT
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
        [MaxLength(50)]
        public virtual string card_issuer { get; set; }
        [Key]
        [Column(Order = 5)]
        [MaxLength(15)]
        public virtual string crad_name { get; set; }
        [Key]
        [Column(Order = 6)]
        public virtual DateTime closing_date { get; set; }
        [MaxLength(255)]
        public virtual string cash_advance { get; set; }
        [MaxLength(255)]
        public virtual string last_payment_status { get; set; }
        [MaxLength(255)]
        public virtual string last_payment_status_memo { get; set; }
        [MaxLength(3)]
        public virtual string currency_type { get; set; }
        public virtual decimal crdit_line { get; set; }
        public virtual decimal current_account_payable { get; set; }
        public virtual decimal current_due_account { get; set; }
        [MaxLength(255)]
        public virtual string claim_status { get; set; }
        [MaxLength(255)]
        public virtual string case_closed_description { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public ZZ_PERSONAL_CREDIT_REPORT ZzPersonalCreditReport { get; set; }
        public ZZ_PERSONAL_CREDIT_REPORT ZzPersonalCreditReport1 { get; set; }
        public ZZ_PERSONAL_CREDIT_REPORT ZzPersonalCreditReport2 { get; set; }
    }
}
