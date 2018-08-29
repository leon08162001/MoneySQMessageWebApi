using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("ZZ_BORROWER_NTOTE_CREDIT")]
    public class ZZ_BORROWER_NTOTE_CREDIT
    {
        public ZZ_BORROWER_NTOTE_CREDIT()
        {
            this.ZzBorrowerNtoteCreditDetails = new List<ZZ_BORROWER_NTOTE_CREDIT_DETAIL>();
            this.ZzBorrowerNtoteCreditDetails1 = new List<ZZ_BORROWER_NTOTE_CREDIT_DETAIL>();
            this.ZzBorrowerNtoteCreditDetails2 = new List<ZZ_BORROWER_NTOTE_CREDIT_DETAIL>();
            this.ZzBorrowerNtoteCreditDetails3 = new List<ZZ_BORROWER_NTOTE_CREDIT_DETAIL>();
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
        public virtual string account_no { get; set; }
        [Key]
        [Column(Order = 4)]
        public virtual DateTime query_date { get; set; }
        [MaxLength(255)]
        public virtual string account_name { get; set; }
        public virtual DateTime data_dealine { get; set; }
        [MaxLength(100)]
        public virtual string rp_account_no { get; set; }
        [MaxLength(10)]
        public virtual string note_bank_code { get; set; }
        [MaxLength(100)]
        public virtual string note_bank_account { get; set; }
        [MaxLength(2000)]
        public virtual string dishonored_account_info { get; set; }
        [MaxLength(2000)]
        public virtual string drawee_for_cashier_order { get; set; }
        public virtual short? total_account_amt { get; set; }
        [MaxLength(2000)]
        public virtual string other_material_info { get; set; }
        [MaxLength(2000)]
        public virtual string related_parties_info { get; set; }
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

        public XZ_ATTACHMENT XzAttachment { get; set; }
        public ZZ_APPLICATION_LOANINFO ZzApplicationLoaninfo { get; set; }
        public ZZ_APPLICATION_LOANINFO ZzApplicationLoaninfo1 { get; set; }
        public XZ_ATTACHMENT XzAttachment1 { get; set; }
        public List<ZZ_BORROWER_NTOTE_CREDIT_DETAIL> ZzBorrowerNtoteCreditDetails { get; set; }
        public List<ZZ_BORROWER_NTOTE_CREDIT_DETAIL> ZzBorrowerNtoteCreditDetails1 { get; set; }
        public List<ZZ_BORROWER_NTOTE_CREDIT_DETAIL> ZzBorrowerNtoteCreditDetails2 { get; set; }
        public List<ZZ_BORROWER_NTOTE_CREDIT_DETAIL> ZzBorrowerNtoteCreditDetails3 { get; set; }
    }
}
