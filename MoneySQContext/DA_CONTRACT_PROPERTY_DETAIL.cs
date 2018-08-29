using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("DA_CONTRACT_PROPERTY_DETAIL")]
    public class DA_CONTRACT_PROPERTY_DETAIL
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
        public virtual short property_serial_number { get; set; }
        [MaxLength(100)]
        public virtual string property_category { get; set; }
        public virtual decimal? area_of_building_sqmeter { get; set; }
        public virtual decimal? property_hold_ratio { get; set; }
        public virtual decimal? occupation_area_sqmeter { get; set; }
        [MaxLength(3)]
        public virtual string currency_type { get; set; }
        public virtual decimal? property_current_value_sqmeter { get; set; }
        [MaxLength(100)]
        public virtual string land_ownership_description { get; set; }
        [MaxLength(50)]
        public virtual string property_tax_registration_number { get; set; }
        [MaxLength(20)]
        public virtual string yearmonth_of_reporting_period { get; set; }
        [MaxLength(50)]
        public virtual string cylinder_capacity { get; set; }
        [MaxLength(100)]
        public virtual string brand_name_of_vehicle { get; set; }
        [MaxLength(100)]
        public virtual string vehicle_type_and_number { get; set; }
        [MaxLength(20)]
        public virtual string yearmonth_of_registration { get; set; }
        [MaxLength(100)]
        public virtual string property_owner { get; set; }
        [MaxLength(255)]
        public virtual string lot_segment_number { get; set; }
        [MaxLength(255)]
        public virtual string vehicle_owner_address { get; set; }
        [MaxLength(255)]
        public virtual string land_category { get; set; }
        [MaxLength(10)]
        public virtual string year_of_vehicle { get; set; }
        [MaxLength(50)]
        public virtual string city { get; set; }
        [MaxLength(50)]
        public virtual string movable_property_guarantee_mark { get; set; }
        public virtual short? denominator_of_ownership { get; set; }
        public virtual short? numerator_of_ownership { get; set; }
        [MaxLength(100)]
        public virtual string trust_mark { get; set; }
        public virtual DateTime? date_of_registration { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public DA_CONTRACT_PROPERTY DaContractProperty { get; set; }
        public DA_CONTRACT_PROPERTY DaContractProperty1 { get; set; }
        public DA_CONTRACT_PROPERTY DaContractProperty2 { get; set; }
    }
}
