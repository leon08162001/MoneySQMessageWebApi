using DataAccess;
using MoneySQContext;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.Http;

namespace WebApiAp.Controller
{
    [RoutePrefix("api/MoneySQ/JA_EMPOLYEE")]
    public class JA_EMPOLYEEController : ApiController
    {
        [Route("Get")]
        public string Get()
        {
            return "Hello World";
        }
        [HttpGet]
        [HttpPost]
        [Route("GetAllEmployees")]
        public IList GetAllEmployees()
        {
            IList Result;
            SpecificEntityRepository<JA_EMPOLYEE> db = new SpecificEntityRepository<JA_EMPOLYEE>(new MoneySQEntities("MONEYSQ_Encrypt"));
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
        [Route("GetEmployeeID")]
        public string GetEmployeeID(string ID)
        {
            string Id = string.Empty;
            SpecificEntityRepository<JA_EMPOLYEE> db = new SpecificEntityRepository<JA_EMPOLYEE>(new MoneySQEntities("MONEYSQ_Encrypt"));
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("social_security_number", ID);
            List<JA_EMPOLYEE> emps = db.Find("select * from [dbo].[JA_EMPOLYEE] where social_security_number= @social_security_number and in_services_status='1'", dic);
            if (emps.Count > 0)
            {
                Id = emps[0].social_security_number;
            }
            return Id;
        }
        [HttpPut]
        [HttpPost]
        [Route("UpdateEmployeePushByID")]
        public bool UpdateEmployeePushByID(string ID)
        {
            bool result = false;
            SpecificEntityRepository<JA_EMPOLYEE> db = new SpecificEntityRepository<JA_EMPOLYEE>(new MoneySQEntities("MONEYSQ_Encrypt"));
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("@social_security_number", ID);
            List<JA_EMPOLYEE> emps = db.Find("select * from [dbo].[JA_EMPOLYEE] where social_security_number= @social_security_number and in_services_status='1'", dic);
            if (emps.Count > 0)
            {
                emps[0].opr_id = emps[0].empolyee_no.ToString();
                emps[0].opr_name = emps[0].empolyee_name;
                emps[0].opr_date = DateTime.Now;
                emps[0].opr_ip_address = Common.Utility.Util.GetClientIp(Request);
                emps[0].enable_push = true;
                result = db.Update(emps[0]);
            }
            return result;
            //if(!result)
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
        [Route("CheckIDValidation")]
        public bool CheckIDValidation(string ID)
        {
            bool result = false;
            SpecificEntityRepository<JA_EMPOLYEE> db = new SpecificEntityRepository<JA_EMPOLYEE>(new MoneySQEntities("MONEYSQ_Encrypt"));
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("social_security_number", ID);
            List<JA_EMPOLYEE> emps = db.Find("select * from [dbo].[JA_EMPOLYEE] where social_security_number= @social_security_number and in_services_status='1'", dic);
            if (emps.Count > 0)
            {
                result = true;
            }
            return result;
        }
    }
}
