using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("loanApplication_customer")]
    public class loanApplication_customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual decimal pk { get; set; }
        [MaxLength(20)]
        public virtual string order_nbr { get; set; }
        [MaxLength(3)]
        [Required]
        public virtual string country { get; set; }
        public virtual int? seq { get; set; }
        [MaxLength(20)]
        public virtual string customer_type { get; set; }
        [MaxLength(20)]
        public virtual string nickname { get; set; }
        [MaxLength(255)]
        public virtual string eng_name { get; set; }
        public virtual bool? is_pay { get; set; }
        [MaxLength(20)]
        public virtual string id_num { get; set; }
        public virtual DateTime? date_of_birth { get; set; }
        [MaxLength(10)]
        public virtual string phone_mobile { get; set; }
        [MaxLength(10)]
        public virtual string phone_home { get; set; }
        [MaxLength(10)]
        public virtual string phone_office { get; set; }
        [MaxLength(500)]
        public virtual string add_1 { get; set; }
        [MaxLength(200)]
        public virtual string add_2 { get; set; }
        [MaxLength(20)]
        public virtual string refno { get; set; }
        [MaxLength(20)]
        public virtual string lst_upd_user { get; set; }
        public virtual DateTime? lst_upd_date { get; set; }
        [Required]
        public virtual bool is_shareholder { get; set; }
        [MaxLength(20)]
        public virtual string shareholder_contributions { get; set; }
        [MaxLength(20)]
        public virtual string shareholder_contributions_shares { get; set; }
    }
}
