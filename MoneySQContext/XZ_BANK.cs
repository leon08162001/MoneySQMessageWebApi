using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("XZ_BANK")]
    public class XZ_BANK
    {
        public XZ_BANK()
        {
            this.XzBankbranches = new List<XZ_BANKBRANCH>();
        }

        [Key]
        [MaxLength(3)]
        public virtual string bank_code { get; set; }
        [MaxLength(255)]
        public virtual string bank_name { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public List<XZ_BANKBRANCH> XzBankbranches { get; set; }
    }
}
