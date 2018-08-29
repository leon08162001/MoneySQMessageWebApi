using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("ZZ_APPLIACTION_DOCUMENT_CHECK")]
    public class ZZ_APPLIACTION_DOCUMENT_CHECK
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
        public virtual string document_code { get; set; }
        [MaxLength(3)]
        public virtual string image_status { get; set; }
        public virtual short? image_check_staff_employeeno { get; set; }
        [MaxLength(255)]
        public virtual string image_check_staff_name { get; set; }
        public virtual DateTime? image_check_datetime { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public XZ_DOCUMENT XzDocument { get; set; }
        public ZZ_APPLICATION_LOANINFO ZzApplicationLoaninfo { get; set; }
        public ZZ_APPLICATION_LOANINFO ZzApplicationLoaninfo1 { get; set; }
        public XZ_DOCUMENT XzDocument1 { get; set; }
    }
}
