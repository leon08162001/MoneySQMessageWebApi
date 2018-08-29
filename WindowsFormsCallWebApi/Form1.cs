using MoneySQContext;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WebApi.Proxies;
using WebApi.Proxies.Clients;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using RestSharp;

namespace WindowsFormsCallWebApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://192.168.43.114:90/MoneySQMessageWebApi/api/MoneySQ/JA_EMPOLYEE/GetEmployeeID?id=F123755175");
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);
            bool b = response.IsSuccessful;
            string s = response.Content;

            client = new RestClient("http://192.168.43.114:90/MoneySQMessageWebApi/api/MoneySQ/JA_EMPOLYEE/UpdateEmployeePushByID?id=F123755175");
            request = new RestRequest(Method.PUT);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/json");
            response = client.Execute(request);
            b = response.IsSuccessful;


            Configuration.MyWebApiProxyBaseAddress = "http://192.168.43.114:90/MoneySQMessageWebApi/";
            JA_EMPOLYEEClient JA_EMPOLYEE = new JA_EMPOLYEEClient();
            //ZZ_APPLICATIONClient ZZ_APPLICATION = new ZZ_APPLICATIONClient();

            List<object> objs = (List<object>)JA_EMPOLYEE.GetAllEmployees();
            List<JA_EMPOLYEE> employees = new List<JA_EMPOLYEE>();
            foreach (object obj in objs)
            {
                JA_EMPOLYEE emp = JsonConvert.DeserializeObject<JA_EMPOLYEE>(obj.ToString());
                employees.Add(emp);
            }
            JA_EMPOLYEE.GetAllEmployees();
            var EmployeeID = JA_EMPOLYEE.GetEmployeeID("F123755175");
            bool result = JA_EMPOLYEE.UpdateEmployeePushByID("F123755175");
            ///string ApplicantID = ZZ_APPLICATION.GetApplicantIDByID("F123755175");
            //result = ZZ_APPLICATION.UpdateApplicantPushByID("F123755175");
        }
    }
}
