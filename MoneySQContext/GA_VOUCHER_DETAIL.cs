using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("GA_VOUCHER_DETAIL")]
    public class GA_VOUCHER_DETAIL
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        public virtual DateTime voucher_date { get; set; }
        [Key]
        [Column(Order = 3)]
        public virtual short voucher_no { get; set; }
        [Key]
        [Column(Order = 4)]
        public virtual short voucher_account_serno { get; set; }
        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual short voucher_detail_serno { get; set; }
        [MaxLength(255)]
        public virtual string correspond_tablet_name { get; set; }
        [MaxLength(50)]
        public virtual string contract_number { get; set; }
        public virtual DateTime? scheduled_payment_date { get; set; }
        public virtual DateTime? scheduled_benefit_date { get; set; }
        [MaxLength(3)]
        public virtual string bank_code { get; set; }
        [MaxLength(4)]
        public virtual string bank_branch_code { get; set; }
        [MaxLength(50)]
        public virtual string cheque_no { get; set; }
        public virtual short? interim_account_detail_serno { get; set; }
        [MaxLength(3)]
        public virtual string currency_type { get; set; }
        public virtual decimal amount { get; set; }
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
        public GA_VOUCHER_CONTENT GaVoucherContent { get; set; }
        public GA_VOUCHER_CONTENT GaVoucherContent1 { get; set; }
        public GA_VOUCHER_CONTENT GaVoucherContent2 { get; set; }
        public GA_VOUCHER_CONTENT GaVoucherContent3 { get; set; }
        public DA_CONTRACT DaContract1 { get; set; }
    }
}
