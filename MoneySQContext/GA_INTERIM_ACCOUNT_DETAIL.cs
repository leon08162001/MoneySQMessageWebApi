using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("GA_INTERIM_ACCOUNT_DETAIL")]
    public class GA_INTERIM_ACCOUNT_DETAIL
    {
        public GA_INTERIM_ACCOUNT_DETAIL()
        {
            this.DaContractInterimAccounts = new List<DA_CONTRACT_INTERIM_ACCOUNT>();
            this.DaContractInterimAccounts1 = new List<DA_CONTRACT_INTERIM_ACCOUNT>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual short interim_account_detail_serno { get; set; }
        [MaxLength(3)]
        public virtual string interim_account_category { get; set; }
        [MaxLength(3)]
        public virtual string currency_type { get; set; }
        public virtual decimal amount { get; set; }
        public virtual decimal accumulative_total_offset_amount { get; set; }
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
        public List<DA_CONTRACT_INTERIM_ACCOUNT> DaContractInterimAccounts { get; set; }
        public List<DA_CONTRACT_INTERIM_ACCOUNT> DaContractInterimAccounts1 { get; set; }
    }
}
