using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("DA_CONTRACT_AMORTIZATION_DETAILS_VOUCHER")]
    public class DA_CONTRACT_AMORTIZATION_DETAILS_VOUCHER
    {
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
        public virtual DateTime scheduled_benefit_date { get; set; }
        [Key]
        [Column(Order = 4)]
        public virtual DateTime voucher_date { get; set; }
        [Key]
        [Column(Order = 5)]
        public virtual short voucher_no { get; set; }
        [MaxLength(3)]
        public virtual string currency_type { get; set; }
        public virtual decimal pay_out_principal_paid { get; set; }
        public virtual decimal pay_out_interest_paid { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public DA_CONTRACT_AMORTIZATION_DETAILS DaContractAmortizationDetail { get; set; }
        public GA_VOUCHER_CONTROL GaVoucherControl { get; set; }
        public DA_CONTRACT_AMORTIZATION_DETAILS DaContractAmortizationDetail1 { get; set; }
        public DA_CONTRACT_AMORTIZATION_DETAILS DaContractAmortizationDetail2 { get; set; }
        public GA_VOUCHER_CONTROL GaVoucherControl1 { get; set; }
        public GA_VOUCHER_CONTROL GaVoucherControl2 { get; set; }
    }
}
