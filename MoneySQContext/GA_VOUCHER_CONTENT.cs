using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("GA_VOUCHER_CONTENT")]
    public class GA_VOUCHER_CONTENT
    {
        public GA_VOUCHER_CONTENT()
        {
            this.GaVoucherDetails = new List<GA_VOUCHER_DETAIL>();
            this.GaVoucherDetails1 = new List<GA_VOUCHER_DETAIL>();
            this.GaVoucherDetails2 = new List<GA_VOUCHER_DETAIL>();
            this.GaVoucherDetails3 = new List<GA_VOUCHER_DETAIL>();
        }

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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual short voucher_account_serno { get; set; }
        [MaxLength(20)]
        public virtual string account_first_grade { get; set; }
        [MaxLength(20)]
        public virtual string account_second_grade { get; set; }
        [MaxLength(20)]
        public virtual string account_third_grade { get; set; }
        [MaxLength(20)]
        public virtual string account_fourth_grade { get; set; }
        [MaxLength(3)]
        public virtual string bebit_credit_mark { get; set; }
        [MaxLength(3)]
        public virtual string currency_type { get; set; }
        public virtual decimal amount { get; set; }
        [MaxLength(1000)]
        public virtual string account_memo { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public GA_VOUCHER_CONTROL GaVoucherControl { get; set; }
        public GA_VOUCHER_CONTROL GaVoucherControl1 { get; set; }
        public GA_VOUCHER_CONTROL GaVoucherControl2 { get; set; }
        public List<GA_VOUCHER_DETAIL> GaVoucherDetails { get; set; }
        public List<GA_VOUCHER_DETAIL> GaVoucherDetails1 { get; set; }
        public List<GA_VOUCHER_DETAIL> GaVoucherDetails2 { get; set; }
        public List<GA_VOUCHER_DETAIL> GaVoucherDetails3 { get; set; }
    }
}
