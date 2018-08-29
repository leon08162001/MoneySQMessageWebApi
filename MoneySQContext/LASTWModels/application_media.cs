using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("application_media")]
    public class application_media
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(8)]
        [Required]
        public virtual string order_nbr { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(3)]
        [Required]
        public virtual string country { get; set; }
        [Key]
        [Column(Order = 3)]
        [MaxLength(8)]
        [Required]
        public virtual string media_id { get; set; }
    }
}
