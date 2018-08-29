using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("lmsStaffMapping")]
    public class lmsStaffMapping
    {
        [MaxLength(10)]
        public virtual string lms_staff { get; set; }
        [MaxLength(20)]
        public virtual string acs_staff { get; set; }
    }
}
