using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("mortgageCar_Survey")]
    public class mortgageCar_Survey
    {
        [Key]
        [MaxLength(10)]
        [Required]
        public virtual string order_nbr { get; set; }
        [MaxLength(20)]
        public virtual string driver { get; set; }
        [MaxLength(500)]
        public virtual string result { get; set; }
        public virtual DateTime? created_date { get; set; }
    }
}
