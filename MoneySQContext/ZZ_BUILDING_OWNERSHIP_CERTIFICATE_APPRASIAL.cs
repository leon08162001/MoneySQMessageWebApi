using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("ZZ_BUILDING_OWNERSHIP_CERTIFICATE_APPRASIAL")]
    public class ZZ_BUILDING_OWNERSHIP_CERTIFICATE_APPRASIAL
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string application_no { get; set; }
        [Key]
        [Column(Order = 3)]
        public virtual int attachment_id { get; set; }
        [Key]
        [Column(Order = 4)]
        [MaxLength(20)]
        public virtual string appraisal_report_no { get; set; }
        [Key]
        [Column(Order = 5)]
        [MaxLength(40)]
        public virtual string building_number { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public ZZ_BUILDING_OWNERSHIP_CERTIFICATE_DESCRIPTION ShippedBy { get; set; }
        public CC_APPRAISAL_BUILDING CcAppraisalBuilding { get; set; }
        public ZZ_BUILDING_OWNERSHIP_CERTIFICATE_DESCRIPTION ShippedBy1 { get; set; }
        public ZZ_BUILDING_OWNERSHIP_CERTIFICATE_DESCRIPTION ShippedBy2 { get; set; }
        public CC_APPRAISAL_BUILDING CcAppraisalBuilding1 { get; set; }
        public CC_APPRAISAL_BUILDING CcAppraisalBuilding2 { get; set; }
    }
}
