using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("refinanceItem")]
    public class refinanceItem
    {
        [Key]
        [Required]
        public virtual decimal refinance_pk { get; set; }
        [MaxLength(20)]
        public virtual string loan_no { get; set; }
        public virtual DateTime? sign_date { get; set; }
        [MaxLength(4)]
        public virtual string sign_time { get; set; }
        [MaxLength(5)]
        public virtual string loan_term { get; set; }
        [MaxLength(20)]
        public virtual string handled_by { get; set; }
        public virtual bool? stop_autocash { get; set; }
        public virtual bool? autocash_form { get; set; }
        [MaxLength(10)]
        public virtual string payment_method { get; set; }
        [MaxLength(10)]
        public virtual string interest_flag { get; set; }
        [MaxLength(10)]
        public virtual string interest { get; set; }
        [MaxLength(30)]
        public virtual string refinance_amt { get; set; }
        [MaxLength(10)]
        public virtual string first_install_method { get; set; }
        [MaxLength(30)]
        public virtual string mon_install_amt { get; set; }
        [MaxLength(20)]
        public virtual string pay_day { get; set; }
        public virtual DateTime? first_install_date { get; set; }
        [MaxLength(20)]
        public virtual string first_install_type { get; set; }
        [MaxLength(50)]
        public virtual string first_install_by { get; set; }
        [MaxLength(50)]
        public virtual string sec_install_by { get; set; }
        public virtual DateTime? property_view_date { get; set; }
        [MaxLength(10)]
        public virtual string property_view_time { get; set; }
        public virtual bool? property_view_approve { get; set; }
        [MaxLength(10)]
        public virtual string first_mort_outstanding_flag { get; set; }
        [MaxLength(50)]
        public virtual string first_mort_outstanding_amt { get; set; }
        public virtual DateTime? first_mort_outstanding_date { get; set; }
        [MaxLength(4)]
        public virtual string first_mort_outstanding_time { get; set; }
        [MaxLength(10)]
        public virtual string credit_card_outstanding_flag { get; set; }
        [MaxLength(50)]
        public virtual string credit_card_outstanding_amt { get; set; }
        public virtual DateTime? credit_card_outstanding_date { get; set; }
        [MaxLength(4)]
        public virtual string credit_card_outstanding_time { get; set; }
        [MaxLength(10)]
        public virtual string management_fee_flag { get; set; }
        [MaxLength(50)]
        public virtual string management_fee_amt { get; set; }
        public virtual DateTime? management_fee_date { get; set; }
        [MaxLength(4)]
        public virtual string management_fee_time { get; set; }
        [MaxLength(10)]
        public virtual string rates_flag { get; set; }
        [MaxLength(50)]
        public virtual string rates_amt { get; set; }
        public virtual DateTime? rates_date { get; set; }
        [MaxLength(4)]
        public virtual string rates_time { get; set; }
        [MaxLength(7)]
        public virtual string declare_item1_flag { get; set; }
        [MaxLength(50)]
        public virtual string declare_item1 { get; set; }
        [MaxLength(50)]
        public virtual string declare_item1_amt { get; set; }
        [MaxLength(7)]
        public virtual string declare_item2_flag { get; set; }
        [MaxLength(50)]
        public virtual string declare_item2 { get; set; }
        [MaxLength(50)]
        public virtual string declare_item2_amt { get; set; }
        [MaxLength(200)]
        public virtual string legal_remarks { get; set; }
        [MaxLength(20)]
        public virtual string legal_remarks_read_by { get; set; }
        public virtual bool? legal_remarks_highlight { get; set; }
        public virtual bool? legal_checked { get; set; }
        public virtual bool? is_authLetter { get; set; }
        public virtual bool? is_dischargeCancel { get; set; }
    }
}
