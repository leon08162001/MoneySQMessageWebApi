using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("mortgageCar_schedule")]
    public class mortgageCar_schedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual decimal pk { get; set; }
        [MaxLength(20)]
        public virtual string status { get; set; }
        [MaxLength(20)]
        public virtual string supervisor { get; set; }
        [MaxLength(8)]
        public virtual string order_nbr { get; set; }
        public virtual DateTime? request_date { get; set; }
        [MaxLength(4)]
        public virtual string request_time { get; set; }
        [MaxLength(4)]
        public virtual string est_time { get; set; }
        [MaxLength(4)]
        public virtual string complete_time { get; set; }
        [MaxLength(100)]
        public virtual string location { get; set; }
        [MaxLength(20)]
        public virtual string cus_name { get; set; }
        [MaxLength(20)]
        public virtual string tel { get; set; }
        [MaxLength(20)]
        public virtual string driverName { get; set; }
        [MaxLength(20)]
        public virtual string licensePlate { get; set; }
        public virtual DateTime? created_date { get; set; }
        [MaxLength(20)]
        public virtual string created_by { get; set; }
        [MaxLength(20)]
        public virtual string updated_by { get; set; }
    }
}
