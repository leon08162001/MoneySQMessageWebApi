using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("DA_DEBIT_NOTE_DETAIL")]
    public class DA_DEBIT_NOTE_DETAIL
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
        public virtual short da_debit_note_detail_serial_no { get; set; }
        [MaxLength(255)]
        public virtual string memo { get; set; }
        [MaxLength(3)]
        public virtual string currency_type { get; set; }
        public virtual decimal amount { get; set; }
        [MaxLength(3)]
        public virtual string business_tax_mark { get; set; }
        public virtual decimal business_tax { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public DA_DEBIT_NOTE_CONTROL DaDebitNoteControl { get; set; }
        public DA_DEBIT_NOTE_CONTROL DaDebitNoteControl1 { get; set; }
    }
}
