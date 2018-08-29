using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneySQContext.LASTWModels
{
    [Table("access")]
    public class access
    {
        [MaxLength(50)]
        public virtual string 估價單編號 { get; set; }
        [MaxLength(50)]
        public virtual string 客戶編號 { get; set; }
        [MaxLength(50)]
        public virtual string 貸款號碼 { get; set; }
        [MaxLength(50)]
        public virtual string 貸款日期 { get; set; }
        [MaxLength(120)]
        public virtual string 借款人姓名1 { get; set; }
        [MaxLength(50)]
        public virtual string 身份證號碼1 { get; set; }
        [MaxLength(120)]
        public virtual string 借款人姓名2 { get; set; }
        [MaxLength(50)]
        public virtual string 身份證號碼2 { get; set; }
        [MaxLength(120)]
        public virtual string 擔保人姓名 { get; set; }
        [MaxLength(50)]
        public virtual string 身份證號碼 { get; set; }
        [MaxLength(50)]
        public virtual string 性別 { get; set; }
        [MaxLength(50)]
        public virtual string 電話號碼 { get; set; }
        [MaxLength(200)]
        public virtual string 種類 { get; set; }
        [MaxLength(500)]
        public virtual string 地址 { get; set; }
        [MaxLength(50)]
        public virtual string 方法 { get; set; }
        [MaxLength(50)]
        public virtual string 貸款額 { get; set; }
        [MaxLength(50)]
        public virtual string 淨息 { get; set; }
        [MaxLength(50)]
        public virtual string 息本 { get; set; }
        [MaxLength(50)]
        public virtual string 年期 { get; set; }
        [MaxLength(50)]
        public virtual string 每月還款額 { get; set; }
        [MaxLength(50)]
        public virtual string 登記人 { get; set; }
        [MaxLength(50)]
        public virtual string 回覆人 { get; set; }
        [MaxLength(50)]
        public virtual string 律師行 { get; set; }
        [MaxLength(50)]
        public virtual string 律師行收費 { get; set; }
        [MaxLength(50)]
        public virtual string 特質 { get; set; }
        [MaxLength(50)]
        public virtual string 需要回契 { get; set; }
        [MaxLength(50)]
        public virtual string 備用信用額 { get; set; }
        [MaxLength(50)]
        public virtual string tu_outstanding { get; set; }
        [MaxLength(50)]
        public virtual string pastDue { get; set; }
        [MaxLength(50)]
        public virtual string 入息証明 { get; set; }
        [MaxLength(50)]
        public virtual string 總入息 { get; set; }
        [MaxLength(50)]
        public virtual string 途徑 { get; set; }
        [MaxLength(50)]
        public virtual string 用途 { get; set; }
        [MaxLength(50)]
        public virtual string 落單日期 { get; set; }
        [MaxLength(50)]
        public virtual string 申請日期 { get; set; }
        [MaxLength(50)]
        public virtual string 要求取款日期 { get; set; }
        [MaxLength(50)]
        public virtual string 不能達到客人要求原因 { get; set; }
        [MaxLength(50)]
        public virtual string 信 { get; set; }
        [MaxLength(50)]
        public virtual string 風險程度 { get; set; }
        [MaxLength(50)]
        public virtual string 使用急先鋒 { get; set; }
    }
}
