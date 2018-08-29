using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("IA_CUATOMER_SERVICE_APPLICATION_ATTACHMENT")]
    public class IA_CUATOMER_SERVICE_APPLICATION_ATTACHMENT
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string customer_service_application_no { get; set; }
        [Key]
        [Column(Order = 3)]
        public virtual int attachment_id { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public IA_CUATOMER_SERVICE_APPLICATION IaCuatomerServiceApplication { get; set; }
        public XZ_ATTACHMENT XzAttachment { get; set; }
        public IA_CUATOMER_SERVICE_APPLICATION IaCuatomerServiceApplication1 { get; set; }
        public XZ_ATTACHMENT XzAttachment1 { get; set; }
    }
}
