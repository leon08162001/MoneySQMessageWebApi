using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("XZ_DOCUMENT")]
    public class XZ_DOCUMENT
    {
        public XZ_DOCUMENT()
        {
            this.XzAttachments = new List<XZ_ATTACHMENT>();
            this.XzDocumentByBussines = new List<XZ_DOCUMENT_BY_BUSSINES>();
            this.ZzAppliactionDocumentChecks = new List<ZZ_APPLIACTION_DOCUMENT_CHECK>();
            this.XzAttachments1 = new List<XZ_ATTACHMENT>();
            this.XzDocumentByBussines1 = new List<XZ_DOCUMENT_BY_BUSSINES>();
            this.ZzAppliactionDocumentChecks1 = new List<ZZ_APPLIACTION_DOCUMENT_CHECK>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string document_code { get; set; }
        [MaxLength(255)]
        public virtual string document_name { get; set; }
        [MaxLength(3)]
        public virtual string document_category { get; set; }
        [MaxLength(3)]
        public virtual string document_source { get; set; }
        [MaxLength(3)]
        public virtual string document_status { get; set; }
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
        public List<XZ_ATTACHMENT> XzAttachments { get; set; }
        public List<XZ_DOCUMENT_BY_BUSSINES> XzDocumentByBussines { get; set; }
        public List<ZZ_APPLIACTION_DOCUMENT_CHECK> ZzAppliactionDocumentChecks { get; set; }
        public List<XZ_ATTACHMENT> XzAttachments1 { get; set; }
        public List<XZ_DOCUMENT_BY_BUSSINES> XzDocumentByBussines1 { get; set; }
        public List<ZZ_APPLIACTION_DOCUMENT_CHECK> ZzAppliactionDocumentChecks1 { get; set; }
    }
}
