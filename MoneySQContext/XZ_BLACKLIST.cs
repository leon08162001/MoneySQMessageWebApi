using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("XZ_BLACKLIST")]
    public class XZ_BLACKLIST
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(100)]
        public virtual string blacklist_id { get; set; }
        [MaxLength(255)]
        public virtual string blacklist_name { get; set; }
        [MaxLength(300)]
        public virtual string blacklist_english_name { get; set; }
        [MaxLength(3)]
        public virtual string data_source { get; set; }
        [MaxLength(2000)]
        public virtual string watch_reason { get; set; }
        [MaxLength(3)]
        public virtual string status { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public JA_COMPANY JaCompany { get; set; }
    }
}
