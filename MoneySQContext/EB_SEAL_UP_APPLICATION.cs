using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("EB_SEAL_UP_APPLICATION")]
    public class EB_SEAL_UP_APPLICATION
    {
        public EB_SEAL_UP_APPLICATION()
        {
            this.EbSealUpApplicationApprovements = new List<EB_SEAL_UP_APPLICATION_APPROVEMENT>();
            this.EbSealUpApplicationAttachments = new List<EB_SEAL_UP_APPLICATION_ATTACHMENT>();
            this.EbSealUpApplicationBuildingApprasials = new List<EB_SEAL_UP_APPLICATION_BUILDING_APPRASIAL>();
            this.EbSealUpApplicationLandApprasials = new List<EB_SEAL_UP_APPLICATION_LAND_APPRASIAL>();
            this.EbSealUpApplicationApprovements1 = new List<EB_SEAL_UP_APPLICATION_APPROVEMENT>();
            this.EbSealUpApplicationAttachments1 = new List<EB_SEAL_UP_APPLICATION_ATTACHMENT>();
            this.EbSealUpApplicationBuildingApprasials1 = new List<EB_SEAL_UP_APPLICATION_BUILDING_APPRASIAL>();
            this.EbSealUpApplicationLandApprasials1 = new List<EB_SEAL_UP_APPLICATION_LAND_APPRASIAL>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string seal_up_application_no { get; set; }
        [MaxLength(3)]
        public virtual string status_of_seal_up_application { get; set; }
        public virtual DateTime date_of_application { get; set; }
        [MaxLength(255)]
        public virtual string item_of_application { get; set; }
        public virtual short employeeno_of_applicant { get; set; }
        [MaxLength(255)]
        public virtual string name_of_applicant { get; set; }
        [MaxLength(3)]
        public virtual string currency_type { get; set; }
        public virtual decimal loan_amount { get; set; }
        public virtual decimal loan_balance { get; set; }
        public virtual decimal predecessors_oustanding_balance { get; set; }
        [MaxLength(500)]
        public virtual string explaination { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public List<EB_SEAL_UP_APPLICATION_APPROVEMENT> EbSealUpApplicationApprovements { get; set; }
        public List<EB_SEAL_UP_APPLICATION_ATTACHMENT> EbSealUpApplicationAttachments { get; set; }
        public List<EB_SEAL_UP_APPLICATION_BUILDING_APPRASIAL> EbSealUpApplicationBuildingApprasials { get; set; }
        public List<EB_SEAL_UP_APPLICATION_LAND_APPRASIAL> EbSealUpApplicationLandApprasials { get; set; }
        public List<EB_SEAL_UP_APPLICATION_APPROVEMENT> EbSealUpApplicationApprovements1 { get; set; }
        public List<EB_SEAL_UP_APPLICATION_ATTACHMENT> EbSealUpApplicationAttachments1 { get; set; }
        public List<EB_SEAL_UP_APPLICATION_BUILDING_APPRASIAL> EbSealUpApplicationBuildingApprasials1 { get; set; }
        public List<EB_SEAL_UP_APPLICATION_LAND_APPRASIAL> EbSealUpApplicationLandApprasials1 { get; set; }
    }
}
