using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("DA_CONTRACT_INCOME")]
    public class DA_CONTRACT_INCOME
    {
        public DA_CONTRACT_INCOME()
        {
            this.DaContractIncomeDetails = new List<DA_CONTRACT_INCOME_DETAIL>();
            this.DaContractIncomeDetails1 = new List<DA_CONTRACT_INCOME_DETAIL>();
            this.DaContractIncomeDetails2 = new List<DA_CONTRACT_INCOME_DETAIL>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string contract_number { get; set; }
        [Key]
        [Column(Order = 3)]
        [MaxLength(100)]
        public virtual string list_number { get; set; }
        [MaxLength(50)]
        public virtual string social_security_number { get; set; }
        [MaxLength(100)]
        public virtual string issuance_unit { get; set; }
        public virtual DateTime inquery_date { get; set; }
        [MaxLength(100)]
        public virtual string property_applicant { get; set; }
        [MaxLength(50)]
        public virtual string property_applicant_idno { get; set; }
        [MaxLength(255)]
        public virtual string property_applicant_address { get; set; }
        public virtual int attachment_id { get; set; }
        [MaxLength(50)]
        public virtual string TXI_application_no { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public DA_CONTRACT DaContract { get; set; }
        public EB_TAXATION_INFORMATION_APPLICATION EbTaxationInformationApplication { get; set; }
        public XZ_ATTACHMENT XzAttachment { get; set; }
        public DA_CONTRACT DaContract1 { get; set; }
        public XZ_ATTACHMENT XzAttachment1 { get; set; }
        public EB_TAXATION_INFORMATION_APPLICATION EbTaxationInformationApplication1 { get; set; }
        public List<DA_CONTRACT_INCOME_DETAIL> DaContractIncomeDetails { get; set; }
        public List<DA_CONTRACT_INCOME_DETAIL> DaContractIncomeDetails1 { get; set; }
        public List<DA_CONTRACT_INCOME_DETAIL> DaContractIncomeDetails2 { get; set; }
    }
}
