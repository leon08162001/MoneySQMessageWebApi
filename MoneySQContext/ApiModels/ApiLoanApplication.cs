using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneySQContext.ApiModels
{
    public class ApiLoanApplication
    {
        /// <summary>
        /// 估價單編號
        /// </summary>
        [Key]
        public virtual string order_nbr { get; set; }
        /// <summary>
        /// 進件日期
        /// </summary>
        public virtual string order_date { get; set; }
        /// <summary>
        /// 進件時間
        /// </summary>
        public virtual string order_time { get; set; }
        /// <summary>
        /// 公司名稱
        /// </summary>
        public virtual string applicant { get; set; }
        /// <summary>
        /// 公司統編
        /// </summary>
        public virtual string id_num { get; set; }
        /// <summary>
        /// 營業員
        /// </summary>
        public virtual string employee_no_cs { get; set; }
        /// <summary>
        /// 內勤人員
        /// </summary>
        public virtual string employee_no_cr { get; set; }
    }
}
