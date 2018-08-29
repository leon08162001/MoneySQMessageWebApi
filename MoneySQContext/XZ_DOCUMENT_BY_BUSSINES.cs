using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("XZ_DOCUMENT_BY_BUSSINES")]
    public class XZ_DOCUMENT_BY_BUSSINES
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string document_code { get; set; }
        [Key]
        [Column(Order = 3)]
        [MaxLength(3)]
        public virtual string business_category { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public XZ_BUSINESS XzBusiness { get; set; }
        public XZ_DOCUMENT XzDocument { get; set; }
        public XZ_DOCUMENT XzDocument1 { get; set; }
        public XZ_BUSINESS XzBusiness1 { get; set; }
    }
}
