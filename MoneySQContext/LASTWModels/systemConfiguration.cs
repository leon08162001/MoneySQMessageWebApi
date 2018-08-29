using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("systemConfiguration")]
    public class systemConfiguration
    {
        [MaxLength(100)]
        public virtual string system_key { get; set; }
        [MaxLength(100)]
        public virtual string system_value { get; set; }
        public virtual DateTime? lst_upd_date { get; set; }
    }
}
