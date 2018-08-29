using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("DA_DEBIT_NOTE_CONTROL")]
    public class DA_DEBIT_NOTE_CONTROL
    {
        public DA_DEBIT_NOTE_CONTROL()
        {
            this.DaDebitNoteDetails = new List<DA_DEBIT_NOTE_DETAIL>();
            this.WrittenBy = new List<DA_DEBIT_NOTE_WRITE_OFF>();
            this.DaDebitNoteDetails1 = new List<DA_DEBIT_NOTE_DETAIL>();
            this.WrittenBy1 = new List<DA_DEBIT_NOTE_WRITE_OFF>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string debit_note_no { get; set; }
        [MaxLength(50)]
        public virtual string contract_number { get; set; }
        [MaxLength(3)]
        public virtual string status_of_debit_note { get; set; }
        [MaxLength(255)]
        public virtual string reason_for_apply { get; set; }
        public virtual short employeeno_of_applicant { get; set; }
        [MaxLength(255)]
        public virtual string name_of_applicant { get; set; }
        [MaxLength(3)]
        public virtual string currency_type { get; set; }
        public virtual decimal total_amount { get; set; }
        public virtual decimal business_tax { get; set; }
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

        public DA_CONTRACT DaContract { get; set; }
        public DA_CONTRACT DaContract1 { get; set; }
        public List<DA_DEBIT_NOTE_DETAIL> DaDebitNoteDetails { get; set; }
        public List<DA_DEBIT_NOTE_WRITE_OFF> WrittenBy { get; set; }
        public List<DA_DEBIT_NOTE_DETAIL> DaDebitNoteDetails1 { get; set; }
        public List<DA_DEBIT_NOTE_WRITE_OFF> WrittenBy1 { get; set; }
    }
}
