using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("WA_MESSAGE")]
    public class WA_MESSAGE
    {
        public WA_MESSAGE()
        {
            this.DaContractMessages = new List<DA_CONTRACT_MESSAGE>();
            this.WaMessageAddressees = new List<WA_MESSAGE_ADDRESSEE>();
            this.ZzAppliactionMessages = new List<ZZ_APPLIACTION_MESSAGE>();
            this.DaContractMessages1 = new List<DA_CONTRACT_MESSAGE>();
            this.WaMessageAddressees1 = new List<WA_MESSAGE_ADDRESSEE>();
            this.ZzAppliactionMessages1 = new List<ZZ_APPLIACTION_MESSAGE>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public virtual string message_idno { get; set; }
        [MaxLength(255)]
        public virtual string message_subject { get; set; }
        [MaxLength(4000)]
        public virtual string content { get; set; }
        public virtual DateTime message_send_datetime { get; set; }
        public virtual short message_send_empolyeeno { get; set; }
        [MaxLength(255)]
        public virtual string message_send_empolyeename { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public List<DA_CONTRACT_MESSAGE> DaContractMessages { get; set; }
        public List<WA_MESSAGE_ADDRESSEE> WaMessageAddressees { get; set; }
        public List<ZZ_APPLIACTION_MESSAGE> ZzAppliactionMessages { get; set; }
        public List<DA_CONTRACT_MESSAGE> DaContractMessages1 { get; set; }
        public List<WA_MESSAGE_ADDRESSEE> WaMessageAddressees1 { get; set; }
        public List<ZZ_APPLIACTION_MESSAGE> ZzAppliactionMessages1 { get; set; }
    }
}
