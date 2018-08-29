using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("ZZ_BUILDING_OWNERSHIP_CERTIFICATE_ONWER_RIGHTS")]
    public class ZZ_BUILDING_OWNERSHIP_CERTIFICATE_ONWER_RIGHTS
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string application_no { get; set; }
        [Key]
        [Column(Order = 3)]
        public virtual int attachment_id { get; set; }
        [Key]
        [Column(Order = 4)]
        public virtual short registration_sequence_no { get; set; }
        public virtual short? serial_number { get; set; }
        public virtual DateTime date_of_registration { get; set; }
        [MaxLength(255)]
        public virtual string reason_of_registration { get; set; }
        public virtual DateTime date_reason_of_registration { get; set; }
        [MaxLength(100)]
        public virtual string onwer_name { get; set; }
        [MaxLength(50)]
        public virtual string owner_idno { get; set; }
        [MaxLength(255)]
        public virtual string owner_address { get; set; }
        public virtual short denominator_of_ownership { get; set; }
        public virtual short numerator_of_ownership { get; set; }
        public virtual decimal area_of_ownership_sqmeter { get; set; }
        [MaxLength(255)]
        public virtual string ownership_certificate_no { get; set; }
        [MaxLength(255)]
        public virtual string other_registration_matters { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public ZZ_BUILDING_OWNERSHIP_CERTIFICATE_DESCRIPTION ShippedBy { get; set; }
        public ZZ_BUILDING_OWNERSHIP_CERTIFICATE_DESCRIPTION ShippedBy1 { get; set; }
        public ZZ_BUILDING_OWNERSHIP_CERTIFICATE_DESCRIPTION ShippedBy2 { get; set; }
    }
}
