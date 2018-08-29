using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("XZ_BULLETIN")]
    public class XZ_BULLETIN
    {
        public XZ_BULLETIN()
        {
            this.XzBulletinAttachments = new List<XZ_BULLETIN_ATTACHMENT>();
            this.XzBulletinAttachments1 = new List<XZ_BULLETIN_ATTACHMENT>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int bulletin_id { get; set; }
        [MaxLength(4000)]
        public virtual string bulletin_content { get; set; }
        [MaxLength(255)]
        public virtual string annoucement_division { get; set; }
        [MaxLength(50)]
        public virtual string annoucement_empolyee_id { get; set; }
        [MaxLength(255)]
        public virtual string annoucement_empolyee_name { get; set; }
        public virtual DateTime create_date { get; set; }
        public virtual DateTime annoucemenyt_start_datetime { get; set; }
        public virtual DateTime annoucemenyt_end_datetime { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public JA_COMPANY JaCompany { get; set; }
        public List<XZ_BULLETIN_ATTACHMENT> XzBulletinAttachments { get; set; }
        public List<XZ_BULLETIN_ATTACHMENT> XzBulletinAttachments1 { get; set; }
    }
}
