using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("XZ_DATA_DICTIONARY")]
    public class XZ_DATA_DICTIONARY
    {
        public XZ_DATA_DICTIONARY()
        {
            this.XzDataIdentifierMeanings = new List<XZ_DATA_IDENTIFIER_MEANING>();
            this.XzDataIdentifierMeanings1 = new List<XZ_DATA_IDENTIFIER_MEANING>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(100)]
        public virtual string tuple_name { get; set; }
        [MaxLength(255)]
        public virtual string tuple_meaning { get; set; }
        [MaxLength(50)]
        public virtual string tuple_data_type { get; set; }
        [MaxLength(50)]
        public virtual string tuple_data_length { get; set; }
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
        public List<XZ_DATA_IDENTIFIER_MEANING> XzDataIdentifierMeanings { get; set; }
        public List<XZ_DATA_IDENTIFIER_MEANING> XzDataIdentifierMeanings1 { get; set; }
    }
}
