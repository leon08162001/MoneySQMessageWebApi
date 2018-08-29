using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("ZZ_PERSONAL_CREDIT_REPORT_QUERY")]
    public class ZZ_PERSONAL_CREDIT_REPORT_QUERY
    {
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
        [MaxLength(50)]
        public virtual string social_security_number { get; set; }
        [Key]
        [Column(Order = 4)]
        public virtual DateTime prinrted_date { get; set; }
        [Key]
        [Column(Order = 5)]
        [MaxLength(50)]
        public virtual string report_no { get; set; }
        [Key]
        [Column(Order = 6)]
        public virtual DateTime query_date { get; set; }
        [Key]
        [Column(Order = 7)]
        [MaxLength(100)]
        public virtual string query_institution { get; set; }
        [Key]
        [Column(Order = 8)]
        [MaxLength(100)]
        public virtual string query_reason { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }
    }
}
