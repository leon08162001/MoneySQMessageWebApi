using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("ZZ_BUILDING_OWNERSHIP_CERTIFICATE_SHARESECTION")]
    public class ZZ_BUILDING_OWNERSHIP_CERTIFICATE_SHARESECTION
    {
        public ZZ_BUILDING_OWNERSHIP_CERTIFICATE_SHARESECTION()
        {
            this.ShippedBy = new List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_DESCRIPTION>();
            this.ShippedBy1 = new List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_DESCRIPTION>();
            this.ShippedBy2 = new List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_DESCRIPTION>();
        }

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
        [MaxLength(100)]
        public virtual string building_number_of_sharesection { get; set; }
        public virtual decimal area_of_sharesection_sqmeter { get; set; }
        public virtual short denominator_of_ownership { get; set; }
        public virtual short numerator_of_ownership { get; set; }
        public virtual decimal area_of_ownership_sqmeter { get; set; }
        [MaxLength(3)]
        public virtual string parking_lot_mark { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_DESCRIPTION> ShippedBy { get; set; }
        public List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_DESCRIPTION> ShippedBy1 { get; set; }
        public List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_DESCRIPTION> ShippedBy2 { get; set; }
    }
}
