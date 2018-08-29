using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("CB_SCORING_CARD_VERSION")]
    public class CB_SCORING_CARD_VERSION
    {
        public CB_SCORING_CARD_VERSION()
        {
            this.CbScoringCardItems = new List<CB_SCORING_CARD_ITEM>();
            this.CbScoringCardLevels = new List<CB_SCORING_CARD_LEVEL>();
            this.CbScoringCardItems1 = new List<CB_SCORING_CARD_ITEM>();
            this.CbScoringCardLevels1 = new List<CB_SCORING_CARD_LEVEL>();
        }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(3)]
        public virtual string scoring_card_version { get; set; }
        [MaxLength(1000)]
        public virtual string scoring_card_version_name { get; set; }
        public virtual DateTime enable_date { get; set; }
        public virtual DateTime? disable_date { get; set; }
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
        public List<CB_SCORING_CARD_ITEM> CbScoringCardItems { get; set; }
        public List<CB_SCORING_CARD_LEVEL> CbScoringCardLevels { get; set; }
        public List<CB_SCORING_CARD_ITEM> CbScoringCardItems1 { get; set; }
        public List<CB_SCORING_CARD_LEVEL> CbScoringCardLevels1 { get; set; }
    }
}
