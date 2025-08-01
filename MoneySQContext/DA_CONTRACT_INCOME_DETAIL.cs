using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("DA_CONTRACT_INCOME_DETAIL")]
    public class DA_CONTRACT_INCOME_DETAIL
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
        [MaxLength(100)]
        public virtual string list_number { get; set; }
        [Key]
        [Column(Order = 4)]
        public virtual short income_serial_number { get; set; }
        [MaxLength(100)]
        public virtual string income_category { get; set; }
        [MaxLength(50)]
        public virtual string taxpayer_idno { get; set; }
        [MaxLength(10)]
        public virtual string income_code { get; set; }
        [MaxLength(50)]
        public virtual string filing_by_the_Media { get; set; }
        [MaxLength(3)]
        public virtual string currency_type { get; set; }
        public virtual decimal total_amount_paid { get; set; }
        public virtual decimal net_withholding_tax { get; set; }
        [MaxLength(50)]
        public virtual string income_data_source { get; set; }
        public virtual decimal? loss_from_property_transactions { get; set; }
        [MaxLength(100)]
        public virtual string taxpayer_name { get; set; }
        [MaxLength(100)]
        public virtual string file_address_saved { get; set; }
        public virtual decimal income_amount { get; set; }
        public virtual decimal? imputation_tax_credit { get; set; }
        [MaxLength(10)]
        public virtual string income_modification_date { get; set; }
        [MaxLength(50)]
        public virtual string income_modification_institution { get; set; }
        [MaxLength(255)]
        public virtual string withholding_agencies_name { get; set; }
        [MaxLength(255)]
        public virtual string withholding_agencies_address { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public DA_CONTRACT_INCOME DaContractIncome { get; set; }
        public DA_CONTRACT_INCOME DaContractIncome1 { get; set; }
        public DA_CONTRACT_INCOME DaContractIncome2 { get; set; }
    }
}
