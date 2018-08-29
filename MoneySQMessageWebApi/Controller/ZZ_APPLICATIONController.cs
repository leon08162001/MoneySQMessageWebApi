using DataAccess;
using MoneySQContext;
using MoneySQContext.ApiModels;
using MoneySQContext.LASTWModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;


namespace WebApiAp.Controller
{
    [RoutePrefix("api/MoneySQ/ZZ_APPLICATION")]
    public class ZZ_APPLICATIONController : ApiController
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [Route("Get")]
        public string Get()
        {
            return "Hello World";
        }
        [HttpGet]
        [HttpPost]
        [Route("GetAllApplications")]
        public IList GetAllApplications()
        {
            IList Result;
            SpecificEntityRepository<ZZ_APPLICATION> db = new SpecificEntityRepository<ZZ_APPLICATION>(new MoneySQEntities("MONEYSQ_Encrypt"));
            Result = db.GetAll();
            if (Result.Count == 0)
            {
                throw new MoneySQMessageWebApiException(MoneySQMessageWebApiErrror.ObjectNotFound);
            }
            else
            {
                return Result;
            }
        }
        [HttpGet]
        [HttpPost]
        [Route("GetApplicantIDByID")]
        public string GetApplicantIDByID(string ID)
        {
            string applicantID = string.Empty;
            SpecificEntityRepository<ZZ_APPLICATION> db = new SpecificEntityRepository<ZZ_APPLICATION>(new MoneySQEntities("MONEYSQ_Encrypt"));
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("idno_of_applicant", ID);
            List<ZZ_APPLICATION> applicants = db.Find("select * from[dbo].[ZZ_APPLICATION] where idno_of_applicant = @idno_of_applicant", dic);
            if (applicants.Count > 0)
            {
                applicantID = applicants[0].idno_of_applicant;
            }
            return applicantID;
            //return Request.CreateResponse(HttpStatusCode.OK, applicantID);
        }
        [HttpPut]
        [HttpPost]
        [Route("UpdateApplicantPushByID")]
        public bool UpdateApplicantPushByID(string ID)
        {
            bool result = false;
            SpecificEntityRepository<ZZ_APPLICATION> db = new SpecificEntityRepository<ZZ_APPLICATION>(new MoneySQEntities("MONEYSQ_Encrypt"));
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("@idno_of_applicant", ID);
            List<ZZ_APPLICATION> applicants = db.Find("select * from[dbo].[ZZ_APPLICATION] where idno_of_applicant = @idno_of_applicant", dic);
            foreach(ZZ_APPLICATION ap in applicants)
            {
                ap.opr_id = ap.idno_of_applicant;
                ap.opr_name = ap.name_of_applicant;
                ap.opr_date = DateTime.Now;
                ap.opr_ip_address = Common.Utility.Util.GetClientIp(Request);
                ap.enable_push = true;
                result = db.Update(ap);
            }
            return result;
            //if (!result)
            //{
            //    return Request.CreateResponse(HttpStatusCode.NotModified, false);
            //}
            //else
            //{
            //    return Request.CreateResponse(HttpStatusCode.OK, true);
            //}
        }
        [HttpGet]
        [HttpPost]
        [Route("GetLoanApplication")]
        public JsonLoanApplication GetLoanApplication(string orderNbr, [FromUri] List<int> statusIds)
        {
            // code to retrieve categories from database
            JsonLoanApplication JLoanApp = new JsonLoanApplication();
            List<ApiLoanApplication> LoanApps = new List<ApiLoanApplication>();
            try
            {
                bool isFirstStatusId = true;
                int i = 1;
                StringBuilder sSql = new StringBuilder("select * from[dbo].[loanApplication] where order_nbr > @order_nbr");
                foreach (int statusId in statusIds)
                {
                    if (isFirstStatusId)
                    {
                        sSql.Append(" and (status_id=@status_id" + i.ToString());
                        isFirstStatusId = false;
                        i++;
                    }
                    else
                    {
                        sSql.Append(" or status_id=@status_id" + i.ToString());
                        i++;
                    }
                }
                sSql.Append(")");
                i = 1;
                SpecificEntityRepository<loanApplication> db = new SpecificEntityRepository<loanApplication>(new LasTWEntities("LASTW_Encrypt"));
                SpecificEntityRepository<comUser> db1 = new SpecificEntityRepository<comUser>(new LasTWEntities("LASTW_Encrypt"));
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic.Add("order_nbr", orderNbr);
                foreach (int statusId in statusIds)
                {
                    dic.Add("status_id" + i.ToString(), statusId);
                    i++;
                }
                sSql.Append(" order by order_nbr");

                List<loanApplication> applicants = db.Find(sSql.ToString(), dic);
                List<comUser> users = db1.GetAll();

                if (applicants.Count > 0)
                {
                    foreach (loanApplication loan in applicants)
                    {
                        comUser user = users.Find(u => u.user_id.Equals(loan.last_upd_user));
                        ApiLoanApplication ApiLanApp = new ApiLoanApplication();
                        ApiLanApp.order_nbr = loan.order_nbr;
                        ApiLanApp.order_date = loan.order_date?.ToString("yyyy/MM/dd");
                        ApiLanApp.order_time = loan.order_time;
                        ApiLanApp.applicant = loan.applicant;
                        ApiLanApp.id_num = "";
                        if (user != null)
                        {
                            ApiLanApp.employee_no_cs = user.dept.Trim().ToUpper().Equals("CS") ? loan.last_upd_user : "";
                            ApiLanApp.employee_no_cr = user.dept.Trim().ToUpper().Equals("CR") ? loan.last_upd_user : "";
                        }
                        else
                        {
                            ApiLanApp.employee_no_cs = "";
                            ApiLanApp.employee_no_cr = "";
                        }
                        LoanApps.Add(ApiLanApp);
                    }
                }
                JLoanApp.ErrorCode = "0000";
                JLoanApp.ErrorMsg = "";
                JLoanApp.LoanApplications = LoanApps;
            }
            catch(Exception ex)
            {
                if (log.IsErrorEnabled) log.Error(ex.Message, ex);
                LoanApps.Clear();
                JLoanApp.ErrorCode = "0001";
                JLoanApp.ErrorMsg = ex.StackTrace;
                JLoanApp.LoanApplications = LoanApps;
            }
            return JLoanApp;
        }

        [HttpGet]
        [HttpPost]
        [Route("GetLoanApplication1")]
        public JsonLoanApplication GetLoanApplication1(string orderNbr, [FromUri] List<int> statusIds)
        {
            // code to retrieve categories from database
            JsonLoanApplication JLoanApp = new JsonLoanApplication();
            List<ApiLoanApplication> LoanApps = new List<ApiLoanApplication>();
            try
            {
                bool isFirstStatusId = true;
                int i = 1;
                StringBuilder sSql = new StringBuilder("select * from[dbo].[loanApplication] where order_nbr > @order_nbr");
                foreach (int statusId in statusIds)
                {
                    if (isFirstStatusId)
                    {
                        sSql.Append(" and (status_id=@status_id" + i.ToString());
                        isFirstStatusId = false;
                        i++;
                    }
                    else
                    {
                        sSql.Append(" or status_id=@status_id" + i.ToString());
                        i++;
                    }
                }
                sSql.Append(")");
                i = 1;
                SpecificEntityRepository<loanApplication> db = new SpecificEntityRepository<loanApplication>(new LasTWEntities("LASTW_Encrypt"));
                SpecificEntityRepository<comUser> db1 = new SpecificEntityRepository<comUser>(new LasTWEntities("LASTW_Encrypt"));
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic.Add("order_nbr", orderNbr);
                foreach (int statusId in statusIds)
                {
                    dic.Add("status_id" + i.ToString(), statusId);
                    i++;
                }
                sSql.Append(" order by order_nbr");

                List<loanApplication> applicants = db.Find(sSql.ToString(), dic);
                if (applicants.Count > 0)
                {
                    foreach (loanApplication loan in applicants)
                    {
                        dic.Clear();
                        dic.Add("user_id", loan.last_upd_user);
                        List<comUser> users = db1.Find("select top 1 * from [dbo].[comUser] where user_id=@user_id", dic);
                        ApiLoanApplication ApiLanApp = new ApiLoanApplication();
                        ApiLanApp.order_nbr = loan.order_nbr;
                        ApiLanApp.order_date = loan.order_date?.ToString("yyyy/MM/dd");
                        ApiLanApp.order_time = loan.order_time;
                        ApiLanApp.applicant = loan.applicant;
                        ApiLanApp.id_num = "";
                        if (users.Count > 0)
                        {
                            ApiLanApp.employee_no_cs = users[0].dept.Trim().ToUpper().Equals("CS") ? loan.last_upd_user : "";
                            ApiLanApp.employee_no_cr = users[0].dept.Trim().ToUpper().Equals("CR") ? loan.last_upd_user : "";
                        }
                        else
                        {
                            ApiLanApp.employee_no_cs = "";
                            ApiLanApp.employee_no_cr = "";
                        }
                        LoanApps.Add(ApiLanApp);
                    }
                }
                JLoanApp.ErrorCode = "0000";
                JLoanApp.ErrorMsg = "";
                JLoanApp.LoanApplications = LoanApps;
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled) log.Error(ex.Message, ex);
                LoanApps.Clear();
                JLoanApp.ErrorCode = "0001";
                JLoanApp.ErrorMsg = ex.StackTrace;
                JLoanApp.LoanApplications = LoanApps;
            }
            return JLoanApp;
        }

    }
}
