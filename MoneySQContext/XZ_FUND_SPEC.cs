using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("XZ_FUND_SPEC")]
    public class XZ_FUND_SPEC
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(3)]
        public virtual string bank_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(4)]
        public virtual string bank_branch_code { get; set; }
        [Key]
        [Column(Order = 3)]
        [MaxLength(50)]
        public virtual string bank_account { get; set; }
        [Key]
        [Column(Order = 4)]
        [MaxLength(3)]
        public virtual string fund_item_code { get; set; }
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        public virtual int? number_of_contract { get; set; }
        [MaxLength(3)]
        public virtual string currency_type { get; set; }
        public virtual decimal? amount_of_contract { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public XZ_BANKBRANCH XzBankbranch { get; set; }
        public XZ_BANKBRANCH XzBankbranch1 { get; set; }
        public JA_COMPANY JaCompany { get; set; }
    }
}
