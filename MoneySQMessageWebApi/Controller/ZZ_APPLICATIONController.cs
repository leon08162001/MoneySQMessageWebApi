using DataAccess;
using MoneySQContext;
using MoneySQContext.ApiModels;
using MoneySQContext.LASTWModels;
using MoneySQMessageWebApi.ApiQuery;
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
        [HttpPost]
        [Route("GetApplicantIDByID")]
        public string GetApplicantIDByID([FromBody] ZZ_APPLICATIONuery Query)
        {
            string applicantID = string.Empty;
            SpecificEntityRepository<ZZ_APPLICATION> db = new SpecificEntityRepository<ZZ_APPLICATION>(new MoneySQEntities("MONEYSQ_Encrypt"));
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("idno_of_applicant", Query.ID);
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
        public bool UpdateApplicantPushByID([FromBody] ZZ_APPLICATIONuery Query)
        {
            bool result = false;
            SpecificEntityRepository<ZZ_APPLICATION> db = new SpecificEntityRepository<ZZ_APPLICATION>(new MoneySQEntities("MONEYSQ_Encrypt"));
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("@idno_of_applicant", Query.ID);
            List<ZZ_APPLICATION> applicants = db.Find("select * from[dbo].[ZZ_APPLICATION] where idno_of_applicant = @idno_of_applicant", dic);
            foreach (ZZ_APPLICATION ap in applicants)
            {
                ap.opr_id = ap.idno_of_applicant;
                ap.opr_name = ap.name_of_applicant;
                ap.opr_date = DateTime.Now;
                ap.opr_ip_address = Common.Utility.Util.GetClientIp(Request);
                ap.enable_push = true;
                result = db.Update(ap);
            }
            return result;
        }
        //[HttpGet]
        //[HttpPost]
        //[Route("GetAllApplications")]
        //public IList GetAllApplications()
        //{
        //    IList Result;
        //    SpecificEntityRepository<ZZ_APPLICATION> db = new SpecificEntityRepository<ZZ_APPLICATION>(new MoneySQEntities("MONEYSQ_Encrypt"));
        //    Result = db.GetAll();
        //    if (Result.Count == 0)
        //    {
        //        throw new MoneySQMessageWebApiException(MoneySQMessageWebApiErrror.ObjectNotFound);
        //    }
        //    else
        //    {
        //        return Result;
        //    }
        //}
        //[HttpGet]
        //[HttpPost]
        //[Route("GetApplicantIDByID")]
        //public string GetApplicantIDByID(string ID)
        //{
        //    string applicantID = string.Empty;
        //    SpecificEntityRepository<ZZ_APPLICATION> db = new SpecificEntityRepository<ZZ_APPLICATION>(new MoneySQEntities("MONEYSQ_Encrypt"));
        //    Dictionary<string, object> dic = new Dictionary<string, object>();
        //    dic.Add("idno_of_applicant", ID);
        //    List<ZZ_APPLICATION> applicants = db.Find("select * from[dbo].[ZZ_APPLICATION] where idno_of_applicant = @idno_of_applicant", dic);
        //    if (applicants.Count > 0)
        //    {
        //        applicantID = applicants[0].idno_of_applicant;
        //    }
        //    return applicantID;
        //    //return Request.CreateResponse(HttpStatusCode.OK, applicantID);
        //}
        //[HttpPut]
        //[HttpPost]
        //[Route("UpdateApplicantPushByID")]
        //public bool UpdateApplicantPushByID(string ID)
        //{
        //    bool result = false;
        //    SpecificEntityRepository<ZZ_APPLICATION> db = new SpecificEntityRepository<ZZ_APPLICATION>(new MoneySQEntities("MONEYSQ_Encrypt"));
        //    Dictionary<string, object> dic = new Dictionary<string, object>();
        //    dic.Add("@idno_of_applicant", ID);
        //    List<ZZ_APPLICATION> applicants = db.Find("select * from[dbo].[ZZ_APPLICATION] where idno_of_applicant = @idno_of_applicant", dic);
        //    foreach(ZZ_APPLICATION ap in applicants)
        //    {
        //        ap.opr_id = ap.idno_of_applicant;
        //        ap.opr_name = ap.name_of_applicant;
        //        ap.opr_date = DateTime.Now;
        //        ap.opr_ip_address = Common.Utility.Util.GetClientIp(Request);
        //        ap.enable_push = true;
        //        result = db.Update(ap);
        //    }
        //    return result;
        //    //if (!result)
        //    //{
        //    //    return Request.CreateResponse(HttpStatusCode.NotModified, false);
        //    //}
        //    //else
        //    //{
        //    //    return Request.CreateResponse(HttpStatusCode.OK, true);
        //    //}
        //}
    }
}
