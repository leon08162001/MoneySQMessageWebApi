using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("DA_CONTRACT_HOUSEHOLD_REGISTRATION_APPLICATION")]
    public class DA_CONTRACT_HOUSEHOLD_REGISTRATION_APPLICATION
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
        [MaxLength(50)]
        public virtual string HRT_application_no { get; set; }
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
        public EB_HOUSEHOLD_REGISTRATION_APPLICATION EbHouseholdRegistrationApplication { get; set; }
        public DA_CONTRACT DaContract1 { get; set; }
        public EB_HOUSEHOLD_REGISTRATION_APPLICATION EbHouseholdRegistrationApplication1 { get; set; }
    }
}
