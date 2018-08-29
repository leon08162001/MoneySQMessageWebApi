using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("FD_INVOICE_DETAIL")]
    public class FD_INVOICE_DETAIL
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string invoice_no { get; set; }
        [Key]
        [Column(Order = 3)]
        public virtual short invoice_detail_serial_number { get; set; }
        [MaxLength(255)]
        public virtual string memo { get; set; }
        [MaxLength(500)]
        public virtual string explaination { get; set; }
        [MaxLength(3)]
        public virtual string charge_to_customer_mark { get; set; }
        [MaxLength(3)]
        public virtual string currency_type { get; set; }
        public virtual decimal amount { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public FD_INVOICE_CONTROL FdInvoiceControl { get; set; }
        public FD_INVOICE_CONTROL FdInvoiceControl1 { get; set; }
    }
}
