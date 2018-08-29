using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("ZZ_BUILDING_OWNERSHIP_CERTIFICATE_DESCRIPTION")]
    public class ZZ_BUILDING_OWNERSHIP_CERTIFICATE_DESCRIPTION
    {
        public ZZ_BUILDING_OWNERSHIP_CERTIFICATE_DESCRIPTION()
        {
            this.ShippedBy3 = new List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_ACCESSORY>();
            this.ShippedBy4 = new List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_APPRASIAL>();
            this.ShippedBy5 = new List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_ONWER_RIGHTS>();
            this.ShippedBy6 = new List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_OTHER_RIGHTS>();
            this.ShippedBy7 = new List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_ACCESSORY>();
            this.ShippedBy8 = new List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_APPRASIAL>();
            this.ShippedBy9 = new List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_ONWER_RIGHTS>();
            this.ShippedBy10 = new List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_OTHER_RIGHTS>();
            this.ShippedBy11 = new List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_ACCESSORY>();
            this.ShippedBy12 = new List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_APPRASIAL>();
            this.ShippedBy13 = new List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_ONWER_RIGHTS>();
            this.ShippedBy14 = new List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_OTHER_RIGHTS>();
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
        public virtual DateTime? prinrted_date { get; set; }
        [MaxLength(100)]
        public virtual string building_number { get; set; }
        [MaxLength(10)]
        public virtual string building_number_city { get; set; }
        [MaxLength(10)]
        public virtual string building_number_district { get; set; }
        [MaxLength(10)]
        public virtual string building_number_section { get; set; }
        [MaxLength(10)]
        public virtual string building_subsection { get; set; }
        [MaxLength(20)]
        public virtual string building_number_no { get; set; }
        public virtual short? yearmonth_of_receipt { get; set; }
        [MaxLength(255)]
        public virtual string no_of_receipt { get; set; }
        public virtual DateTime? date_of_registration { get; set; }
        [MaxLength(50)]
        public virtual string certificate_category_no { get; set; }
        [MaxLength(2)]
        public virtual string certificate_category { get; set; }
        [MaxLength(255)]
        public virtual string reason_of_registration { get; set; }
        [MaxLength(100)]
        public virtual string land_lot { get; set; }
        [MaxLength(10)]
        public virtual string land_lot_city { get; set; }
        [MaxLength(10)]
        public virtual string land_lot_district { get; set; }
        [MaxLength(10)]
        public virtual string land_lot_section { get; set; }
        [MaxLength(10)]
        public virtual string land_lot_subsection { get; set; }
        [MaxLength(20)]
        public virtual string land_lot_no { get; set; }
        [MaxLength(255)]
        public virtual string realestate_address { get; set; }
        [MaxLength(5)]
        public virtual string realestate_address_zipcode { get; set; }
        [MaxLength(20)]
        public virtual string realestate_address_city { get; set; }
        [MaxLength(20)]
        public virtual string realestate_address_town { get; set; }
        [MaxLength(20)]
        public virtual string realestate_address_street { get; set; }
        [MaxLength(20)]
        public virtual string realestate_address_li { get; set; }
        [MaxLength(6)]
        public virtual string realestate_address_lin { get; set; }
        [MaxLength(6)]
        public virtual string realestate_address_section { get; set; }
        [MaxLength(6)]
        public virtual string realestate_address_lane { get; set; }
        [MaxLength(6)]
        public virtual string realestate_address_alley { get; set; }
        [MaxLength(6)]
        public virtual string realestate_address_no { get; set; }
        [MaxLength(6)]
        public virtual string realestate_address_floor { get; set; }
        [MaxLength(6)]
        public virtual string realestate_address_room { get; set; }
        [MaxLength(255)]
        public virtual string main_use { get; set; }
        [MaxLength(255)]
        public virtual string main_building_material { get; set; }
        [MaxLength(255)]
        public virtual string number_of_stories { get; set; }
        public virtual decimal? area_of_building_sqmeter { get; set; }
        [MaxLength(255)]
        public virtual string floor { get; set; }
        public virtual decimal? area_of_floor_sqmeter { get; set; }
        public virtual DateTime? building_construction_finished_date { get; set; }
        [MaxLength(255)]
        public virtual string other_registration_matters { get; set; }
        [MaxLength(3)]
        public virtual string collateral_mark { get; set; }
        [MaxLength(3)]
        public virtual string appraisal_mark { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public ZZ_APPLICATION_LOANINFO ZzApplicationLoaninfo { get; set; }
        public XZ_ATTACHMENT XzAttachment { get; set; }
        public ZZ_BUILDING_OWNERSHIP_CERTIFICATE_SHARESECTION ShippedBy { get; set; }
        public ZZ_BUILDING_OWNERSHIP_CERTIFICATE_SHARESECTION ShippedBy1 { get; set; }
        public ZZ_APPLICATION_LOANINFO ZzApplicationLoaninfo1 { get; set; }
        public XZ_ATTACHMENT XzAttachment1 { get; set; }
        public ZZ_BUILDING_OWNERSHIP_CERTIFICATE_SHARESECTION ShippedBy2 { get; set; }
        public List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_ACCESSORY> ShippedBy3 { get; set; }
        public List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_APPRASIAL> ShippedBy4 { get; set; }
        public List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_ONWER_RIGHTS> ShippedBy5 { get; set; }
        public List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_OTHER_RIGHTS> ShippedBy6 { get; set; }
        public List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_ACCESSORY> ShippedBy7 { get; set; }
        public List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_APPRASIAL> ShippedBy8 { get; set; }
        public List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_ONWER_RIGHTS> ShippedBy9 { get; set; }
        public List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_OTHER_RIGHTS> ShippedBy10 { get; set; }
        public List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_ACCESSORY> ShippedBy11 { get; set; }
        public List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_APPRASIAL> ShippedBy12 { get; set; }
        public List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_ONWER_RIGHTS> ShippedBy13 { get; set; }
        public List<ZZ_BUILDING_OWNERSHIP_CERTIFICATE_OTHER_RIGHTS> ShippedBy14 { get; set; }
    }
}
