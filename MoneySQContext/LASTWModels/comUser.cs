using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("comUser")]
    public class comUser
    {
        [Key]
        [MaxLength(20)]
        [Required]
        public virtual string user_id { get; set; }
        [MaxLength(3)]
        [Required]
        public virtual string country { get; set; }
        [MaxLength(20)]
        public virtual string first_name { get; set; }
        [MaxLength(50)]
        public virtual string last_name { get; set; }
        [MaxLength(10)]
        public virtual string nickname { get; set; }
        [MaxLength(10)]
        public virtual string directline { get; set; }
        [MaxLength(255)]
        public virtual string password { get; set; }
        [MaxLength(30)]
        public virtual string dept { get; set; }
        [MaxLength(20)]
        public virtual string role { get; set; }
        [MaxLength(50)]
        public virtual string email { get; set; }
        public virtual bool? active { get; set; }
        public virtual bool? show_report { get; set; }
        public virtual bool? access_report { get; set; }
        public virtual bool? access_print { get; set; }
        public virtual bool? limited_user { get; set; }
        public virtual bool? advanced_user { get; set; }
        [MaxLength(20)]
        public virtual string last_upd_user { get; set; }
        public virtual DateTime? last_upd_date { get; set; }
        public virtual short? employee_no { get; set; }
    }
}
