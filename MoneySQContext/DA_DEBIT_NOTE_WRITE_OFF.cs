using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("DA_DEBIT_NOTE_WRITE_OFF")]
    public class DA_DEBIT_NOTE_WRITE_OFF
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string debit_note_no { get; set; }
        [Key]
        [Column(Order = 3)]
        public virtual DateTime write_off_date { get; set; }
        [Key]
        [Column(Order = 4)]
        public virtual DateTime voucher_date { get; set; }
        [Key]
        [Column(Order = 5)]
        public virtual short voucher_no { get; set; }
        [MaxLength(3)]
        public virtual string currency_type { get; set; }
        public virtual decimal write_off_amount { get; set; }
        public virtual decimal write_off_business_tax { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public GA_VOUCHER_CONTROL GaVoucherControl { get; set; }
        public DA_DEBIT_NOTE_CONTROL DaDebitNoteControl { get; set; }
        public DA_DEBIT_NOTE_CONTROL DaDebitNoteControl1 { get; set; }
        public GA_VOUCHER_CONTROL GaVoucherControl1 { get; set; }
        public GA_VOUCHER_CONTROL GaVoucherControl2 { get; set; }
    }
}
