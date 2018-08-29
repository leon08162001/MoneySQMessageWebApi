using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("UA_APPROVEMENT_CONTROL_RECORD")]
    public class UA_APPROVEMENT_CONTROL_RECORD
    {
        public UA_APPROVEMENT_CONTROL_RECORD()
        {
            this.CbCreditCheckReprotApprovements = new List<CB_CREDIT_CHECK_REPROT_APPROVEMENT>();
            this.CcAppraisalReportApprovements = new List<CC_APPRAISAL_REPORT_APPROVEMENT>();
            this.DaContractApprovements = new List<DA_CONTRACT_APPROVEMENT>();
            this.EbForeclosureEvaluationApprovements = new List<EB_FORECLOSURE_EVALUATION_APPROVEMENT>();
            this.EbSealUpApplicationApprovements = new List<EB_SEAL_UP_APPLICATION_APPROVEMENT>();
            this.IaCuatomerServiceApplicationApprovements = new List<IA_CUATOMER_SERVICE_APPLICATION_APPROVEMENT>();
            this.UaApprovementAttachments = new List<UA_APPROVEMENT_ATTACHMENT>();
            this.UaApprovementDetailRecords = new List<UA_APPROVEMENT_DETAIL_RECORD>();
            this.ZzApplicationApprovements = new List<ZZ_APPLICATION_APPROVEMENT>();
            this.CbCreditCheckReprotApprovements1 = new List<CB_CREDIT_CHECK_REPROT_APPROVEMENT>();
            this.CcAppraisalReportApprovements1 = new List<CC_APPRAISAL_REPORT_APPROVEMENT>();
            this.DaContractApprovements1 = new List<DA_CONTRACT_APPROVEMENT>();
            this.EbForeclosureEvaluationApprovements1 = new List<EB_FORECLOSURE_EVALUATION_APPROVEMENT>();
            this.EbSealUpApplicationApprovements1 = new List<EB_SEAL_UP_APPLICATION_APPROVEMENT>();
            this.IaCuatomerServiceApplicationApprovements1 = new List<IA_CUATOMER_SERVICE_APPLICATION_APPROVEMENT>();
            this.UaApprovementAttachments1 = new List<UA_APPROVEMENT_ATTACHMENT>();
            this.UaApprovementDetailRecords1 = new List<UA_APPROVEMENT_DETAIL_RECORD>();
            this.ZzApplicationApprovements1 = new List<ZZ_APPLICATION_APPROVEMENT>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string approval_no { get; set; }
        [MaxLength(255)]
        public virtual string casename_of_approvement { get; set; }
        public virtual DateTime datetime_of_submit { get; set; }
        [MaxLength(10)]
        public virtual string divisioncode_of_submit { get; set; }
        [MaxLength(255)]
        public virtual string divisionname_of_submit { get; set; }
        public virtual short employeeno_of_submit { get; set; }
        [MaxLength(255)]
        public virtual string employeename_of_submit { get; set; }
        [MaxLength(3)]
        public virtual string status_of_approvement { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public List<CB_CREDIT_CHECK_REPROT_APPROVEMENT> CbCreditCheckReprotApprovements { get; set; }
        public List<CC_APPRAISAL_REPORT_APPROVEMENT> CcAppraisalReportApprovements { get; set; }
        public List<DA_CONTRACT_APPROVEMENT> DaContractApprovements { get; set; }
        public List<EB_FORECLOSURE_EVALUATION_APPROVEMENT> EbForeclosureEvaluationApprovements { get; set; }
        public List<EB_SEAL_UP_APPLICATION_APPROVEMENT> EbSealUpApplicationApprovements { get; set; }
        public List<IA_CUATOMER_SERVICE_APPLICATION_APPROVEMENT> IaCuatomerServiceApplicationApprovements { get; set; }
        public List<UA_APPROVEMENT_ATTACHMENT> UaApprovementAttachments { get; set; }
        public List<UA_APPROVEMENT_DETAIL_RECORD> UaApprovementDetailRecords { get; set; }
        public List<ZZ_APPLICATION_APPROVEMENT> ZzApplicationApprovements { get; set; }
        public List<CB_CREDIT_CHECK_REPROT_APPROVEMENT> CbCreditCheckReprotApprovements1 { get; set; }
        public List<CC_APPRAISAL_REPORT_APPROVEMENT> CcAppraisalReportApprovements1 { get; set; }
        public List<DA_CONTRACT_APPROVEMENT> DaContractApprovements1 { get; set; }
        public List<EB_FORECLOSURE_EVALUATION_APPROVEMENT> EbForeclosureEvaluationApprovements1 { get; set; }
        public List<EB_SEAL_UP_APPLICATION_APPROVEMENT> EbSealUpApplicationApprovements1 { get; set; }
        public List<IA_CUATOMER_SERVICE_APPLICATION_APPROVEMENT> IaCuatomerServiceApplicationApprovements1 { get; set; }
        public List<UA_APPROVEMENT_ATTACHMENT> UaApprovementAttachments1 { get; set; }
        public List<UA_APPROVEMENT_DETAIL_RECORD> UaApprovementDetailRecords1 { get; set; }
        public List<ZZ_APPLICATION_APPROVEMENT> ZzApplicationApprovements1 { get; set; }
    }
}
