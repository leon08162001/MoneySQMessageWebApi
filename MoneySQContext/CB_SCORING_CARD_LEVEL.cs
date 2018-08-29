using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("CB_SCORING_CARD_LEVEL")]
    public class CB_SCORING_CARD_LEVEL
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public virtual string company_code { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(3)]
        public virtual string scoring_card_version { get; set; }
        [Key]
        [Column(Order = 3)]
        [MaxLength(3)]
        public virtual string scoring_level { get; set; }
        public virtual short total_scoring_score_start { get; set; }
        public virtual short total_scoring_score_end { get; set; }
        public virtual short risk_rank_adjusted { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public CB_SCORING_CARD_VERSION CbScoringCardVersion { get; set; }
        public CB_SCORING_CARD_VERSION CbScoringCardVersion1 { get; set; }
    }
}
