using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("DA_CONTRACT_REPAYMENT_DETAILS")]
    public class DA_CONTRACT_REPAYMENT_DETAILS
    {
        public DA_CONTRACT_REPAYMENT_DETAILS()
        {
            this.DaContractRepaymentDetailsVouchers = new List<DA_CONTRACT_REPAYMENT_DETAILS_VOUCHER>();
            this.DaContractRepaymentDetailsVouchers1 = new List<DA_CONTRACT_REPAYMENT_DETAILS_VOUCHER>();
            this.DaContractRepaymentDetailsVouchers2 = new List<DA_CONTRACT_REPAYMENT_DETAILS_VOUCHER>();
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
        public virtual DateTime scheduled_payment_date { get; set; }
        [MaxLength(3)]
        public virtual string currency_type { get; set; }
        public virtual decimal pay_in_principal_payable { get; set; }
        public virtual decimal pay_in_interest_payable { get; set; }
        public virtual decimal? pay_in_default_fine_payable { get; set; }
        public virtual decimal? pay_in_overdue_interest_payable { get; set; }
        public virtual decimal? pay_in_late_fine_payable { get; set; }
        public virtual decimal total_pay_in_amounr_payable { get; set; }
        public virtual decimal? pay_in_principal_paid { get; set; }
        public virtual decimal? pay_in_interest_paid { get; set; }
        public virtual decimal? pay_in_default_fine_paid { get; set; }
        public virtual decimal? pay_in_overdue_interest_paid { get; set; }
        public virtual decimal? pay_in_late_fine_paid { get; set; }
        public virtual decimal? total_repayment_paid { get; set; }
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
        public DA_CONTRACT DaContract1 { get; set; }
        public List<DA_CONTRACT_REPAYMENT_DETAILS_VOUCHER> DaContractRepaymentDetailsVouchers { get; set; }
        public List<DA_CONTRACT_REPAYMENT_DETAILS_VOUCHER> DaContractRepaymentDetailsVouchers1 { get; set; }
        public List<DA_CONTRACT_REPAYMENT_DETAILS_VOUCHER> DaContractRepaymentDetailsVouchers2 { get; set; }
    }
}
