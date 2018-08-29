using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("WA_MESSAGE_ADDRESSEE")]
    public class WA_MESSAGE_ADDRESSEE
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string message_idno { get; set; }
        [Key]
        [Column(Order = 3)]
        [MaxLength(255)]
        public virtual string addressee { get; set; }
        [MaxLength(3)]
        public virtual string addressee_categroy { get; set; }
        [MaxLength(3)]
        public virtual string message_send_method { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public WA_MESSAGE WaMessage { get; set; }
        public WA_MESSAGE WaMessage1 { get; set; }
    }
}
