using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("CC_APPRAISAL_REPORT")]
    public class CC_APPRAISAL_REPORT
    {
        public CC_APPRAISAL_REPORT()
        {
            this.CcAppraisalBuildings = new List<CC_APPRAISAL_BUILDING>();
            this.CcAppraisalLands = new List<CC_APPRAISAL_LAND>();
            this.CcAppraisalReportApprovements = new List<CC_APPRAISAL_REPORT_APPROVEMENT>();
            this.CcAppraisalReportAttachments = new List<CC_APPRAISAL_REPORT_ATTACHMENT>();
            this.CcAppraisalBuildings1 = new List<CC_APPRAISAL_BUILDING>();
            this.CcAppraisalLands1 = new List<CC_APPRAISAL_LAND>();
            this.CcAppraisalReportApprovements1 = new List<CC_APPRAISAL_REPORT_APPROVEMENT>();
            this.CcAppraisalReportAttachments1 = new List<CC_APPRAISAL_REPORT_ATTACHMENT>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(20)]
        public virtual string appraisal_report_no { get; set; }
        [MaxLength(3)]
        public virtual string appraisal_report_status { get; set; }
        public virtual short empolyeeno_of_service_staff { get; set; }
        [MaxLength(50)]
        public virtual string approval_no { get; set; }
        [MaxLength(3)]
        public virtual string currency_type { get; set; }
        public virtual decimal? exclusive_area_sqmeter { get; set; }
        public virtual decimal? exclusive_area_ping { get; set; }
        public virtual decimal? public_facility_area_sqmeter { get; set; }
        public virtual decimal? public_facility_area_ping { get; set; }
        public virtual decimal? parking_lot_area_sqmeter { get; set; }
        public virtual decimal? parking_lot_area_ping { get; set; }
        public virtual decimal? area_of_building_sqmeter { get; set; }
        public virtual decimal? area_of_building_ping { get; set; }
        [MaxLength(255)]
        public virtual string parking_lot_floor_description { get; set; }
        [MaxLength(3)]
        public virtual string ground_parking_space_mark { get; set; }
        [MaxLength(3)]
        public virtual string elevator_parking_space { get; set; }
        [MaxLength(255)]
        public virtual string other_parking_space { get; set; }
        [MaxLength(2000)]
        public virtual string building_status_explation { get; set; }
        [MaxLength(255)]
        public virtual string parking_lot_no_description { get; set; }
        [MaxLength(255)]
        public virtual string parking_lot_amt_description { get; set; }
        public virtual decimal? total_apprasial_price { get; set; }
        public virtual decimal? total_land_apprasial_price { get; set; }
        public virtual decimal? total_building_apprasial_price { get; set; }
        public virtual decimal? total_other_apprasial_price { get; set; }
        public virtual DateTime? house_prospecting_date { get; set; }
        [MaxLength(3)]
        public virtual string house_rent_mark { get; set; }
        [MaxLength(3)]
        public virtual string house_own_usw_mark { get; set; }
        [MaxLength(3)]
        public virtual string house_idle_mark { get; set; }
        [MaxLength(255)]
        public virtual string house_other_use { get; set; }
        [MaxLength(3)]
        public virtual string building_addition_mark { get; set; }
        [MaxLength(255)]
        public virtual string building_addition_floor { get; set; }
        public virtual decimal? area_of_building_addition_sqmeter { get; set; }
        public virtual decimal? area_of_building_addition_ping { get; set; }
        [MaxLength(3)]
        public virtual string addition_entery_way_inner { get; set; }
        [MaxLength(3)]
        public virtual string addition_entery_way_external { get; set; }
        [MaxLength(3)]
        public virtual string flawed_house_mark { get; set; }
        [MaxLength(3)]
        public virtual string radiated_house_mark { get; set; }
        [MaxLength(3)]
        public virtual string chloride_ioned_house_mark { get; set; }
        [MaxLength(255)]
        public virtual string other_flaw_mark { get; set; }
        [MaxLength(2000)]
        public virtual string prospecting_opinion { get; set; }
        public virtual DateTime? appraisal_date { get; set; }
        public virtual short? empolyeeno_of_appraisal_staff { get; set; }
        [MaxLength(200)]
        public virtual string name_of_appraisal_staff { get; set; }
        [MaxLength(2000)]
        public virtual string apprasial_opinion { get; set; }
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
        public List<CC_APPRAISAL_BUILDING> CcAppraisalBuildings { get; set; }
        public List<CC_APPRAISAL_LAND> CcAppraisalLands { get; set; }
        public List<CC_APPRAISAL_REPORT_APPROVEMENT> CcAppraisalReportApprovements { get; set; }
        public List<CC_APPRAISAL_REPORT_ATTACHMENT> CcAppraisalReportAttachments { get; set; }
        public List<CC_APPRAISAL_BUILDING> CcAppraisalBuildings1 { get; set; }
        public List<CC_APPRAISAL_LAND> CcAppraisalLands1 { get; set; }
        public List<CC_APPRAISAL_REPORT_APPROVEMENT> CcAppraisalReportApprovements1 { get; set; }
        public List<CC_APPRAISAL_REPORT_ATTACHMENT> CcAppraisalReportAttachments1 { get; set; }
    }
}
