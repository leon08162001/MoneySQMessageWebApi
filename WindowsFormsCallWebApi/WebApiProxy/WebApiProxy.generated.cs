//------------------------------------------------------------------------------
//<auto-generated>
//  This file is auto-generated by WebApiProxy
//  Project site: http://github.com/faniereynders/webapiproxy
//  
//  Any changes to this file will be overwritten
//</auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net;
using WebApi.Proxies.Models;
using System.Collections;

#region Proxies
namespace WebApi.Proxies
{
	/// <summary>
	/// Client configuration.
	/// </summary>
	public static partial class Configuration
	{
		/// <summary>
		/// Web Api Base Address.
		/// </summary>
		public static string MyWebApiProxyBaseAddress = "http://localhost:2180/";
	}
}
#endregion

#region Models
namespace WebApi.Proxies.Models
{
	public class WebApiProxyResponseException : Exception
	{
		public HttpStatusCode StatusCode { get; private set; }
		public string Content { get; private set; }

		public WebApiProxyResponseException(HttpStatusCode statusCode, string content) : base("A " + statusCode + " (" + (int)statusCode + ") http exception occured. See Content for response body.")
		{
			StatusCode = statusCode;
			Content = content;
		}
	}


	
}
#endregion

#region Interfaces
namespace WebApi.Proxies.Interfaces
{
	public interface IClientBase : IDisposable
	{
		HttpClient HttpClient { get; }
	}

	
	public partial interface IJA_EMPOLYEEClient : IClientBase
	{	


		/// <returns></returns>
		Task<HttpResponseMessage> GetAsync();

		/// <returns></returns>
		String Get();


		/// <returns></returns>
		Task<HttpResponseMessage> GetAllEmployeesAsync();

		/// <returns></returns>
		IList GetAllEmployees();

		/// <param name="ID"></param>

		/// <returns></returns>
		Task<HttpResponseMessage> GetEmployeeIDAsync(String ID);

		/// <param name="ID"></param>
		/// <returns></returns>
		String GetEmployeeID(String ID);

		/// <param name="ID"></param>

		/// <returns></returns>
		Task<HttpResponseMessage> UpdateEmployeePushByIDAsync(String ID);

		/// <param name="ID"></param>
		/// <returns></returns>
		Boolean UpdateEmployeePushByID(String ID);
				
	}
	
	public partial interface IZZ_APPLICATIONClient : IClientBase
	{	


		/// <returns></returns>
		Task<HttpResponseMessage> GetAsync();

		/// <returns></returns>
		String Get();


		/// <returns></returns>
		Task<HttpResponseMessage> GetAllApplicationsAsync();

		/// <returns></returns>
		IList GetAllApplications();

		/// <param name="ID"></param>

		/// <returns></returns>
		Task<HttpResponseMessage> GetApplicantIDByIDAsync(String ID);

		/// <param name="ID"></param>
		/// <returns></returns>
		HttpResponseMessage GetApplicantIDByID(String ID);

		/// <param name="ID"></param>

		/// <returns></returns>
		Task<HttpResponseMessage> UpdateApplicantPushByIDAsync(String ID);

		/// <param name="ID"></param>
		/// <returns></returns>
		HttpResponseMessage UpdateApplicantPushByID(String ID);
				
	}

}
#endregion

#region Clients
namespace WebApi.Proxies.Clients
{
	/// <summary>
	/// Client base class.
	/// </summary>
	public abstract partial class ClientBase : IDisposable
	{
		/// <summary>
		/// Gests the HttpClient.
		/// </summary>
		public HttpClient HttpClient { get; protected set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ClientBase"/> class.
		/// </summary>
		protected ClientBase()
		{
			HttpClient = new HttpClient()
			{
				BaseAddress = new Uri(Configuration.MyWebApiProxyBaseAddress)
			};
		}
		
		/// <summary>
		/// Ensures that response has a valid (200 - OK) status code
		/// </summary>
		public virtual void EnsureSuccess(HttpResponseMessage response)
		{			
			if (response.IsSuccessStatusCode)				
				return;
													
			var content = response.Content.ReadAsStringAsync().Result;
			throw new WebApiProxyResponseException(response.StatusCode, content);			
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ClientBase"/> class.
		/// </summary>
		/// <param name="handler">The handler.</param>
		/// <param name="disposeHandler">if set to <c>true</c> [dispose handler].</param>
		protected ClientBase(HttpMessageHandler handler, bool disposeHandler = true)
		{
			HttpClient = new HttpClient(handler, disposeHandler)
			{
				BaseAddress = new Uri(Configuration.MyWebApiProxyBaseAddress)
			};
		}

		/// <summary>
		/// Encode the input parameter as a string
		/// </summary>
		protected string EncodeParam<T>(T value) 
		{
			return System.Net.WebUtility.UrlEncode(value.ToString());
		}
		
		/// <summary>
		/// Encode the input parameter as a string
		/// </summary>
		protected string EncodeParam(DateTime value) 
		{
			return System.Net.WebUtility.UrlEncode(value.ToString("s"));
		}
		
		/// <summary>
		/// Encode the input parameter as a string
		/// </summary>
		protected string EncodeParam(DateTimeOffset value)
		{
			return System.Net.WebUtility.UrlEncode(value.ToString("s"));
		}
		
		/// <summary>
		/// Releases the unmanaged resources and disposes of the managed resources.       
		/// </summary>
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && HttpClient != null)
			{
				HttpClient.Dispose();
				HttpClient = null;
			}
		}
		
		/// <summary>
		/// Releases the unmanaged resources and disposes of the managed resources.       
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		
		/// <summary>
		/// Destructor
		/// </summary>
		~ClientBase() 
		{
			Dispose(false);
		}
	}

	/// <summary>
	/// Helper class to access all clients at once
	/// </summary>
	public partial class WebApiClients
	{
		public JA_EMPOLYEEClient JA_EMPOLYEE { get; private set; }
		public ZZ_APPLICATIONClient ZZ_APPLICATION { get; private set; }
		
        protected IEnumerable<Interfaces.IClientBase> Clients
        {
            get
            {
				yield return JA_EMPOLYEE;
				yield return ZZ_APPLICATION;
            }
        }

		public WebApiClients(Uri baseAddress = null)
		{
            if (baseAddress != null)
                Configuration.MyWebApiProxyBaseAddress = baseAddress.AbsoluteUri;

			JA_EMPOLYEE = new JA_EMPOLYEEClient();
			ZZ_APPLICATION = new ZZ_APPLICATIONClient();
		}

        public void SetAuthentication(AuthenticationHeaderValue auth)
        {
            foreach (var client in Clients)
                client.HttpClient.DefaultRequestHeaders.Authorization = auth;
        }
		
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                foreach (var client in Clients)
                    client.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

		~WebApiClients() 
		{
            Dispose(false);
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public partial class JA_EMPOLYEEClient : ClientBase, Interfaces.IJA_EMPOLYEEClient
	{		

		/// <summary>
		/// 
		/// </summary>
		public JA_EMPOLYEEClient() : base()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		public JA_EMPOLYEEClient(HttpMessageHandler handler, bool disposeHandler = true) : base(handler, disposeHandler)
		{
		}

		#region Methods

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected virtual async Task<HttpResponseMessage> GetAsyncMsg()
		{
			return await HttpClient.GetAsync("api/MoneySQ/JA_EMPOLYEE");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public virtual async Task<HttpResponseMessage> GetAsync()
		{
			return await HttpClient.GetAsync("api/MoneySQ/JA_EMPOLYEE");
		}

		/// <summary>
		/// 
		/// </summary>
		public virtual String Get()
		{
			var result = Task.Run(() => GetAsyncMsg()).Result;		 
			 
			EnsureSuccess(result);
			 			 
			return result.Content.ReadAsAsync<String>().Result;
			 		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected virtual async Task<HttpResponseMessage> GetAllEmployeesAsyncMsg()
		{
			return await HttpClient.PostAsJsonAsync("api/MoneySQ/JA_EMPOLYEE", default(HttpResponseMessage));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public virtual async Task<HttpResponseMessage> GetAllEmployeesAsync()
		{
			return await HttpClient.PostAsJsonAsync("api/MoneySQ/JA_EMPOLYEE", default(HttpResponseMessage));
		}

		/// <summary>
		/// 
		/// </summary>
		public virtual IList GetAllEmployees()
		{
			var result = Task.Run(() => GetAllEmployeesAsyncMsg()).Result;		 
			 
			EnsureSuccess(result);
			 			 
			return result.Content.ReadAsAsync<IList>().Result;
			 		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ID"></param>
		/// <returns></returns>
		protected virtual async Task<HttpResponseMessage> GetEmployeeIDAsyncMsg(String ID)
		{
			return await HttpClient.GetAsync("api/MoneySQ/JA_EMPOLYEE/" + ID);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ID"></param>
		/// <returns></returns>
		public virtual async Task<HttpResponseMessage> GetEmployeeIDAsync(String ID)
		{
			return await HttpClient.GetAsync("api/MoneySQ/JA_EMPOLYEE/" + ID);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ID"></param>
		public virtual String GetEmployeeID(String ID)
		{
			var result = Task.Run(() => GetEmployeeIDAsyncMsg(ID)).Result;		 
			 
			EnsureSuccess(result);
			 			 
			return result.Content.ReadAsAsync<String>().Result;
			 		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ID"></param>
		/// <returns></returns>
		protected virtual async Task<HttpResponseMessage> UpdateEmployeePushByIDAsyncMsg(String ID)
		{
			return await HttpClient.PutAsJsonAsync("api/MoneySQ/JA_EMPOLYEE/" + ID, default(HttpResponseMessage));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ID"></param>
		/// <returns></returns>
		public virtual async Task<HttpResponseMessage> UpdateEmployeePushByIDAsync(String ID)
		{
			return await HttpClient.PutAsJsonAsync("api/MoneySQ/JA_EMPOLYEE/" + ID, default(HttpResponseMessage));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ID"></param>
		public virtual Boolean UpdateEmployeePushByID(String ID)
		{
			var result = Task.Run(() => UpdateEmployeePushByIDAsyncMsg(ID)).Result;		 
			 
			EnsureSuccess(result);
			 			 
			return result.Content.ReadAsAsync<Boolean>().Result;
			 		}

		#endregion
	}
	/// <summary>
	/// 
	/// </summary>
	public partial class ZZ_APPLICATIONClient : ClientBase, Interfaces.IZZ_APPLICATIONClient
	{		

		/// <summary>
		/// 
		/// </summary>
		public ZZ_APPLICATIONClient() : base()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		public ZZ_APPLICATIONClient(HttpMessageHandler handler, bool disposeHandler = true) : base(handler, disposeHandler)
		{
		}

		#region Methods

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected virtual async Task<HttpResponseMessage> GetAsyncMsg()
		{
			return await HttpClient.GetAsync("api/MoneySQ/ZZ_APPLICATION");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public virtual async Task<HttpResponseMessage> GetAsync()
		{
			return await HttpClient.GetAsync("api/MoneySQ/ZZ_APPLICATION");
		}

		/// <summary>
		/// 
		/// </summary>
		public virtual String Get()
		{
			var result = Task.Run(() => GetAsyncMsg()).Result;		 
			 
			EnsureSuccess(result);
			 			 
			return result.Content.ReadAsAsync<String>().Result;
			 		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected virtual async Task<HttpResponseMessage> GetAllApplicationsAsyncMsg()
		{
			return await HttpClient.PostAsJsonAsync("api/MoneySQ/ZZ_APPLICATION", default(HttpResponseMessage));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public virtual async Task<HttpResponseMessage> GetAllApplicationsAsync()
		{
			return await HttpClient.PostAsJsonAsync("api/MoneySQ/ZZ_APPLICATION", default(HttpResponseMessage));
		}

		/// <summary>
		/// 
		/// </summary>
		public virtual IList GetAllApplications()
		{
			var result = Task.Run(() => GetAllApplicationsAsyncMsg()).Result;		 
			 
			EnsureSuccess(result);
			 			 
			return result.Content.ReadAsAsync<IList>().Result;
			 		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ID"></param>
		/// <returns></returns>
		protected virtual async Task<HttpResponseMessage> GetApplicantIDByIDAsyncMsg(String ID)
		{
			return await HttpClient.GetAsync("api/MoneySQ/ZZ_APPLICATION/" + ID);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ID"></param>
		/// <returns></returns>
		public virtual async Task<HttpResponseMessage> GetApplicantIDByIDAsync(String ID)
		{
			return await HttpClient.GetAsync("api/MoneySQ/ZZ_APPLICATION/" + ID);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ID"></param>
		public virtual HttpResponseMessage GetApplicantIDByID(String ID)
		{
			var result = Task.Run(() => GetApplicantIDByIDAsyncMsg(ID)).Result;		 
			 
			EnsureSuccess(result);
			 			 
			return result.Content.ReadAsAsync<HttpResponseMessage>().Result;
			 		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ID"></param>
		/// <returns></returns>
		protected virtual async Task<HttpResponseMessage> UpdateApplicantPushByIDAsyncMsg(String ID)
		{
			return await HttpClient.PutAsJsonAsync("api/MoneySQ/ZZ_APPLICATION/" + ID, default(HttpResponseMessage));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ID"></param>
		/// <returns></returns>
		public virtual async Task<HttpResponseMessage> UpdateApplicantPushByIDAsync(String ID)
		{
			return await HttpClient.PutAsJsonAsync("api/MoneySQ/ZZ_APPLICATION/" + ID, default(HttpResponseMessage));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ID"></param>
		public virtual HttpResponseMessage UpdateApplicantPushByID(String ID)
		{
			var result = Task.Run(() => UpdateApplicantPushByIDAsyncMsg(ID)).Result;		 
			 
			EnsureSuccess(result);
			 			 
			return result.Content.ReadAsAsync<HttpResponseMessage>().Result;
			 		}

		#endregion
	}
}
#endregion

