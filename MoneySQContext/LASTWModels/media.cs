using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("media")]
    public class media
    {
        [Key]
        [MaxLength(8)]
        [Required]
        public virtual string media_id { get; set; }
        [MaxLength(3)]
        [Required]
        public virtual string country { get; set; }
        public virtual int? seq_no { get; set; }
        [MaxLength(100)]
        public virtual string media_name { get; set; }
        [MaxLength(100)]
        public virtual string title { get; set; }
        [MaxLength(500)]
        public virtual string media_content { get; set; }
        [MaxLength(1)]
        public virtual string above_line { get; set; }
        public virtual DateTime? start_date { get; set; }
        public virtual DateTime? end_date { get; set; }
        [MaxLength(100)]
        public virtual string start_time { get; set; }
        [MaxLength(20)]
        public virtual string mc { get; set; }
        [MaxLength(20)]
        public virtual string view_point { get; set; }
        public virtual bool? publish { get; set; }
        [MaxLength(50)]
        public virtual string active { get; set; }
        [MaxLength(20)]
        public virtual string last_upd_user { get; set; }
        public virtual DateTime? last_upd_date { get; set; }
    }
}
