using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("JA_EMPOLYEE")]
    public class JA_EMPOLYEE
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        public virtual short empolyee_no { get; set; }
        [Index("IX_JA_EMPOLYEE", IsUnique = true)]
        [MaxLength(50)]
        public virtual string social_security_number { get; set; }
        [MaxLength(255)]
        public virtual string empolyee_name { get; set; }
        [MaxLength(55)]
        public virtual string empolyee_last_name { get; set; }
        [MaxLength(200)]
        public virtual string empolyee_first_name { get; set; }
        [MaxLength(255)]
        public virtual string employee_english_name { get; set; }
        [MaxLength(55)]
        public virtual string empolyee_english_last_name { get; set; }
        [MaxLength(200)]
        public virtual string empolyee_english_first_name { get; set; }
        [MaxLength(3)]
        public virtual string in_services_status { get; set; }
        public virtual DateTime on_board_date { get; set; }
        public virtual DateTime? leaving_date { get; set; }
        [MaxLength(40)]
        public virtual string cell_phone { get; set; }
        [MaxLength(40)]
        public virtual string home_phone_no { get; set; }
        [MaxLength(40)]
        public virtual string office_phone_no { get; set; }
        [MaxLength(10)]
        public virtual string office_phone_extension { get; set; }
        [MaxLength(255)]
        public virtual string email { get; set; }
        [MaxLength(255)]
        public virtual string mailing_address { get; set; }
        [MaxLength(10)]
        public virtual string division_code { get; set; }
        public virtual DateTime? division_effective_date { get; set; }
        [MaxLength(3)]
        public virtual string job_title_code { get; set; }
        public virtual DateTime? job_effective_date { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }
        public virtual bool? enable_push { get; set; }

        public JA_COMPANY JaCompany { get; set; }
        public JA_DIVISION JaDivision { get; set; }
        public JA_JOB_TILE JaJobTile { get; set; }
        public JA_DIVISION JaDivision1 { get; set; }
        public JA_JOB_TILE JaJobTile1 { get; set; }
    }
}
