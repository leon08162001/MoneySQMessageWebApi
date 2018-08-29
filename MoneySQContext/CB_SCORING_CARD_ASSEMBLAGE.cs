using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext
{
    [Table("CB_SCORING_CARD_ASSEMBLAGE")]
    public class CB_SCORING_CARD_ASSEMBLAGE
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
        public virtual string scoring_item_code { get; set; }
        [Key]
        [Column(Order = 4)]
        [MaxLength(3)]
        public virtual string scoring_content_code { get; set; }
        [MaxLength(255)]
        public virtual string scoring_content { get; set; }
        public virtual short score { get; set; }
        [MaxLength(100)]
        public virtual string opr_id { get; set; }
        [MaxLength(255)]
        public virtual string opr_name { get; set; }
        public virtual DateTime opr_date { get; set; }
        [MaxLength(40)]
        public virtual string opr_ip_address { get; set; }
        [MaxLength(40)]
        public virtual string opr_gps_address { get; set; }

        public CB_SCORING_CARD_ITEM CbScoringCardItem { get; set; }
        public CB_SCORING_CARD_ITEM CbScoringCardItem1 { get; set; }
        public CB_SCORING_CARD_ITEM CbScoringCardItem2 { get; set; }
    }
}
