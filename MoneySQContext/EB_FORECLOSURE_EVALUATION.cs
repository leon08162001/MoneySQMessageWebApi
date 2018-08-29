using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("EB_FORECLOSURE_EVALUATION")]
    public class EB_FORECLOSURE_EVALUATION
    {
        public EB_FORECLOSURE_EVALUATION()
        {
            this.EbForeclosureEvaluationApprovements = new List<EB_FORECLOSURE_EVALUATION_APPROVEMENT>();
            this.EbForeclosureEvaluationAttachments = new List<EB_FORECLOSURE_EVALUATION_ATTACHMENT>();
            this.EbForeclosureEvaluationBuildingApprasials = new List<EB_FORECLOSURE_EVALUATION_BUILDING_APPRASIAL>();
            this.EbForeclosureEvaluationLandApprasials = new List<EB_FORECLOSURE_EVALUATION_LAND_APPRASIAL>();
            this.EbForeclosureEvaluationApprovements1 = new List<EB_FORECLOSURE_EVALUATION_APPROVEMENT>();
            this.EbForeclosureEvaluationAttachments1 = new List<EB_FORECLOSURE_EVALUATION_ATTACHMENT>();
            this.EbForeclosureEvaluationBuildingApprasials1 = new List<EB_FORECLOSURE_EVALUATION_BUILDING_APPRASIAL>();
            this.EbForeclosureEvaluationLandApprasials1 = new List<EB_FORECLOSURE_EVALUATION_LAND_APPRASIAL>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string foreclosure_evaluation_no { get; set; }
        [MaxLength(3)]
        public virtual string status_of_foreclosure_evaluation { get; set; }
        public virtual DateTime date_of_application { get; set; }
        [MaxLength(255)]
        public virtual string item_of_application { get; set; }
        public virtual short employeeno_of_applicant { get; set; }
        [MaxLength(255)]
        public virtual string name_of_applicant { get; set; }
        [MaxLength(3)]
        public virtual string currency_type { get; set; }
        public virtual decimal predecessors_oustanding_balance { get; set; }
        public virtual decimal predecessors_oustanding_balance_end { get; set; }
        public virtual decimal court_appraisal_price { get; set; }
        public virtual decimal acquisition_cost { get; set; }
        [MaxLength(3)]
        public virtual string cash_bid_mark { get; set; }
        [MaxLength(3)]
        public virtual string fail_bid_bear_mark { get; set; }
        [MaxLength(3)]
        public virtual string special_auction_procedures_mark { get; set; }
        public virtual decimal buying_price_suggested { get; set; }
        [MaxLength(255)]
        public virtual string useage_after_buying { get; set; }
        public virtual decimal loanable_amt_by_bank_approved { get; set; }
        public virtual decimal financing_rate { get; set; }
        [MaxLength(255)]
        public virtual string payment_category { get; set; }
        [MaxLength(500)]
        public virtual string legal_memo { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public List<EB_FORECLOSURE_EVALUATION_APPROVEMENT> EbForeclosureEvaluationApprovements { get; set; }
        public List<EB_FORECLOSURE_EVALUATION_ATTACHMENT> EbForeclosureEvaluationAttachments { get; set; }
        public List<EB_FORECLOSURE_EVALUATION_BUILDING_APPRASIAL> EbForeclosureEvaluationBuildingApprasials { get; set; }
        public List<EB_FORECLOSURE_EVALUATION_LAND_APPRASIAL> EbForeclosureEvaluationLandApprasials { get; set; }
        public List<EB_FORECLOSURE_EVALUATION_APPROVEMENT> EbForeclosureEvaluationApprovements1 { get; set; }
        public List<EB_FORECLOSURE_EVALUATION_ATTACHMENT> EbForeclosureEvaluationAttachments1 { get; set; }
        public List<EB_FORECLOSURE_EVALUATION_BUILDING_APPRASIAL> EbForeclosureEvaluationBuildingApprasials1 { get; set; }
        public List<EB_FORECLOSURE_EVALUATION_LAND_APPRASIAL> EbForeclosureEvaluationLandApprasials1 { get; set; }
    }
}
