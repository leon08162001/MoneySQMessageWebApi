using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("EB_LEGAL_ATTEST_INVOICE")]
    public class EB_LEGAL_ATTEST_INVOICE
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string legal_attest_letters_no { get; set; }
        [Key]
        [Column(Order = 3)]
        [MaxLength(50)]
        public virtual string invoice_no { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public EB_LEGAL_ATTEST_LETTERS EbLegalAttestLetter { get; set; }
        public FD_INVOICE_CONTROL FdInvoiceControl { get; set; }
        public EB_LEGAL_ATTEST_LETTERS EbLegalAttestLetter1 { get; set; }
        public FD_INVOICE_CONTROL FdInvoiceControl1 { get; set; }
    }
}
