using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneySQContext.ApiModels
{
    public class JsonLoanApplication
    {
        public virtual string ErrorCode { get; set; }
        public virtual string ErrorMsg { get; set; }
        public virtual List<ApiLoanApplication> LoanApplications { get; set; }
    }
}
