using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("XZ_DATA_IDENTIFIER_MEANING")]
    public class XZ_DATA_IDENTIFIER_MEANING
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(100)]
        public virtual string tuple_name { get; set; }
        [Key]
        [Column(Order = 3)]
        [MaxLength(20)]
        public virtual string data_identifier { get; set; }
        [Key]
        [Column(Order = 4)]
        [MaxLength(5)]
        public virtual string language_type { get; set; }
        [MaxLength(100)]
        public virtual string data_identifier_meaning { get; set; }
        public virtual DateTime enable_date { get; set; }
        public virtual DateTime? disable_date { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public XZ_DATA_DICTIONARY XzDataDictionary { get; set; }
        public XZ_DATA_DICTIONARY XzDataDictionary1 { get; set; }
    }
}
