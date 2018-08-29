using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("privacy")]
    public class privacy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual int pk { get; set; }
        public virtual bool? agree { get; set; }
        [MaxLength(50)]
        public virtual string cus_name { get; set; }
        [MaxLength(20)]
        public virtual string idnum { get; set; }
        [MaxLength(20)]
        public virtual string mobile { get; set; }
        [MaxLength(200)]
        public virtual string address { get; set; }
        public virtual DateTime? callin_date { get; set; }
        public virtual bool? is_print { get; set; }
        public virtual DateTime? created_date { get; set; }
        [MaxLength(20)]
        public virtual string created_by { get; set; }
        public virtual DateTime? lst_print_date { get; set; }
        [MaxLength(20)]
        public virtual string printed_by { get; set; }
    }
}
