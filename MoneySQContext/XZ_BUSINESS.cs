using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("XZ_BUSINESS")]
    public class XZ_BUSINESS
    {
        public XZ_BUSINESS()
        {
            this.XzDocumentByBussines = new List<XZ_DOCUMENT_BY_BUSSINES>();
            this.XzDocumentByBussines1 = new List<XZ_DOCUMENT_BY_BUSSINES>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(3)]
        public virtual string business_category { get; set; }
        [MaxLength(255)]
        public virtual string business_category_name { get; set; }
        [MaxLength(3)]
        public virtual string business_category_status { get; set; }
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
        public List<XZ_DOCUMENT_BY_BUSSINES> XzDocumentByBussines { get; set; }
        public List<XZ_DOCUMENT_BY_BUSSINES> XzDocumentByBussines1 { get; set; }
    }
}
