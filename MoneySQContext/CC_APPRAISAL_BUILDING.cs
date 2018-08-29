using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("CC_APPRAISAL_BUILDING")]
    public class CC_APPRAISAL_BUILDING
    {
        public CC_APPRAISAL_BUILDING()
        {
            this.CcAppraisalBuildingContents = new List<CC_APPRAISAL_BUILDING_CONTENT>();
            this.EbForeclosureEvaluationBuildingApprasials = new List<EB_FORECLOSURE_EVALUATION_BUILDING_APPRASIAL>();
            this.EbSealUpApplicationBuildingApprasials = new List<EB_SEAL_UP_APPLICATION_BUILDING_APPRASIAL>();
            this.ShippedBy = new List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_APPRASIAL>();
            this.CcAppraisalBuildingContents1 = new List<CC_APPRAISAL_BUILDING_CONTENT>();
            this.EbForeclosureEvaluationBuildingApprasials1 = new List<EB_FORECLOSURE_EVALUATION_BUILDING_APPRASIAL>();
            this.EbSealUpApplicationBuildingApprasials1 = new List<EB_SEAL_UP_APPLICATION_BUILDING_APPRASIAL>();
            this.ShippedBy1 = new List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_APPRASIAL>();
            this.CcAppraisalBuildingContents2 = new List<CC_APPRAISAL_BUILDING_CONTENT>();
            this.EbForeclosureEvaluationBuildingApprasials2 = new List<EB_FORECLOSURE_EVALUATION_BUILDING_APPRASIAL>();
            this.EbSealUpApplicationBuildingApprasials2 = new List<EB_SEAL_UP_APPLICATION_BUILDING_APPRASIAL>();
            this.ShippedBy2 = new List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_APPRASIAL>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(40)]
        public virtual string building_number { get; set; }
        [Key]
        [Column(Order = 3)]
        [MaxLength(20)]
        public virtual string appraisal_report_no { get; set; }
        public virtual decimal ping_announced_current_value { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public CC_APPRAISAL_REPORT CcAppraisalReport { get; set; }
        public CC_APPRAISAL_REPORT CcAppraisalReport1 { get; set; }
        public List<CC_APPRAISAL_BUILDING_CONTENT> CcAppraisalBuildingContents { get; set; }
        public List<EB_FORECLOSURE_EVALUATION_BUILDING_APPRASIAL> EbForeclosureEvaluationBuildingApprasials { get; set; }
        public List<EB_SEAL_UP_APPLICATION_BUILDING_APPRASIAL> EbSealUpApplicationBuildingApprasials { get; set; }
        public List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_APPRASIAL> ShippedBy { get; set; }
        public List<CC_APPRAISAL_BUILDING_CONTENT> CcAppraisalBuildingContents1 { get; set; }
        public List<EB_FORECLOSURE_EVALUATION_BUILDING_APPRASIAL> EbForeclosureEvaluationBuildingApprasials1 { get; set; }
        public List<EB_SEAL_UP_APPLICATION_BUILDING_APPRASIAL> EbSealUpApplicationBuildingApprasials1 { get; set; }
        public List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_APPRASIAL> ShippedBy1 { get; set; }
        public List<CC_APPRAISAL_BUILDING_CONTENT> CcAppraisalBuildingContents2 { get; set; }
        public List<EB_FORECLOSURE_EVALUATION_BUILDING_APPRASIAL> EbForeclosureEvaluationBuildingApprasials2 { get; set; }
        public List<EB_SEAL_UP_APPLICATION_BUILDING_APPRASIAL> EbSealUpApplicationBuildingApprasials2 { get; set; }
        public List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_APPRASIAL> ShippedBy2 { get; set; }
    }
}
