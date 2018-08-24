using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DPCoreTools.SeedWork;
using DPCoreTools.SeedWork.Models;

namespace DpCoreTools.Service
{
	public class FrontSideHandlerService : BaseService, IFrontSideHandlerService
	{
		public Task<ServiceResponse> GetHandlers(string pEnvironment, string pHost, string pDomain, int protocol)
		{
			switch (protocol)
			{
				case 1:
					return GetHttpHandlers(pEnvironment, pHost, pDomain);
				case 2:
					return GetHttpsHandlers(pEnvironment, pHost, pDomain);
				case 3:
					return GetBothHandlers(pEnvironment, pHost, pDomain);
				default:
					break;
			}
			return null;
		}
		public Task<ServiceResponse> GetHttpHandlers(string pEnvironment, string pHost, string pDomain)
		{
			return GetHttpHandlers(pEnvironment, pHost, pDomain, string.Empty);
		}
		public Task<ServiceResponse> GetHttpHandlers(string pEnvironment, string pHost, string pDomain, string pName)
		{
			var response = new ServiceResponse();
			this.Environment = pEnvironment;
			this.Host = pHost;
			this.Domain = pDomain.ToUpper();
			var pCmd = new StringBuilder();
			pCmd.AppendLine("<dp:request domain=\"" + this.Domain + "\" xmlns:dp=\"http://www.datapower.com/schemas/management\">");
			if (string.IsNullOrEmpty(pName))
				pCmd.AppendLine("<dp:get-config class=\"HTTPSourceProtocolHandler\"/>");
			else
				pCmd.AppendLine("<dp:get-config class=\"HTTPSourceProtocolHandler\" name=\"" + pName + "\"/>");
			pCmd.AppendLine("</dp:request>");
			var execCmd = ExecuteCommands(pCmd);
			if (execCmd.Contains("error-log"))
			{
				response.Code = 1;
				response.Titulo = "Error al ejecutar el servicio";
				response.Message = (from x in XDocument.Parse(execCmd).Descendants("log-event")
														select x.Value).FirstOrDefault();
			}
			else
			{
				response.Code = 0;
				var lstFsh = new List<FrontSideHandler>(from x in XDocument.Parse(execCmd).Descendants("HTTPSourceProtocolHandler")
																								select new FrontSideHandler(x, pEnvironment, pHost, pDomain, "HTTP"));
				var rOpStatus = GetOpStatusHttp(pEnvironment, pHost, pDomain);
				if (rOpStatus.Result.Code == 0)
				{
					var lstOpStatus = (List<OpStatus>)rOpStatus.Result.Entity;
					foreach (var item in lstFsh)
					{
						item.OpState = lstOpStatus.FirstOrDefault(y => y.Name.Trim().ToLower() == item.Name.Trim().ToLower());
					}
				}

				//se obtienen las ip del local address
				var rIpAdd = GetIpAddress(pEnvironment, pHost, pDomain, string.Empty);
				if (rIpAdd.Result.Code == 0)
				{
					var lstIpAdd = (List<DnsStaticHostStatus>)rIpAdd.Result.Entity;
					foreach (var item in lstFsh)
					{
						item.Dns = lstIpAdd.FirstOrDefault(y => y.Alias.Trim().ToLower() == item.LocalAddress.Trim().ToLower());
					}
				}

				if (string.IsNullOrEmpty(pName))
					response.Entity = lstFsh;
				else
					response.Entity = lstFsh.FirstOrDefault();
			}
			return Task.FromResult(response);
		}
		public Task<ServiceResponse> GetHttpsHandlers(string pEnvironment, string pHost, string pDomain)
		{
			return GetHttpsHandlers(pEnvironment, pHost, pDomain, string.Empty);
		}
		public Task<ServiceResponse> GetHttpsHandlers(string pEnvironment, string pHost, string pDomain, string pName)
		{
			var response = new ServiceResponse();
			this.Environment = pEnvironment;
			this.Host = pHost;
			this.Domain = pDomain.ToUpper();
			var pCmd = new StringBuilder();
			pCmd.AppendLine("<dp:request domain=\"" + this.Domain + "\" xmlns:dp=\"http://www.datapower.com/schemas/management\">");
			if (string.IsNullOrEmpty(pName))
				pCmd.AppendLine("<dp:get-config class=\"HTTPSSourceProtocolHandler\"/>");
			else
				pCmd.AppendLine("<dp:get-config class=\"HTTPSSourceProtocolHandler\" name=\"" + pName + "\"/>");
			pCmd.AppendLine("</dp:request>");
			var execCmd = ExecuteCommands(pCmd);
			if (execCmd.Contains("error-log"))
			{
				response.Code = 1;
				response.Titulo = "Error al ejecutar el servicio";
				response.Message = (from x in XDocument.Parse(execCmd).Descendants("log-event")
														select x.Value).FirstOrDefault();
			}
			else
			{
				response.Code = 0;
				var lstFsh = new List<FrontSideHandler>(from x in XDocument.Parse(execCmd).Descendants("HTTPSSourceProtocolHandler")
																								select new FrontSideHandler(x, pEnvironment, pHost, pDomain, "HTTPS"));
				var rOpStatus = GetOpStatusHttps(pEnvironment, pHost, pDomain);
				if (rOpStatus.Result.Code == 0)
				{
					var lstOpStatus = (List<OpStatus>)rOpStatus.Result.Entity;
					foreach (var item in lstFsh)
					{
						item.OpState = lstOpStatus.FirstOrDefault(y => y.Name.Trim().ToLower() == item.Name.Trim().ToLower());
					}
				}
				if (string.IsNullOrEmpty(pName))
					response.Entity = lstFsh;
				else
					response.Entity = lstFsh.FirstOrDefault();
			}
			return Task.FromResult(response);
		}
		public Task<ServiceResponse> GetBothHandlers(string pEnvironment, string pHost, string pDomain)
		{
			var response = new ServiceResponse();
			var respHttp = ((List<FrontSideHandler>)GetHttpHandlers(pEnvironment, pHost, pDomain, string.Empty).Result.Entity);
			var respHttps = ((List<FrontSideHandler>)GetHttpsHandlers(pEnvironment, pHost, pDomain, string.Empty).Result.Entity);
			response.Entity = respHttp.Concat(respHttps).ToList();
			return Task.FromResult(response);
		}
		public Task<ServiceResponse> GetOpStatusHttp(string pEnvironment, string pHost, string pDomain)
		{
			return GetOpStatusHttp(pEnvironment, pHost, pDomain, string.Empty);
		}
		public Task<ServiceResponse> GetOpStatusHttps(string pEnvironment, string pHost, string pDomain)
		{
			return GetOpStatusHttps(pEnvironment, pHost, pDomain, string.Empty);
		}
		public Task<ServiceResponse> GetOpStatusHttp(string pEnvironment, string pHost, string pDomain, string pName)
		{
			var response = new ServiceResponse();
			this.Environment = pEnvironment;
			this.Host = pHost;
			this.Domain = pDomain.ToUpper();
			var pCmd = new StringBuilder();
			pCmd.AppendLine("<dp:request domain=\"" + this.Domain + "\" xmlns:dp=\"http://www.datapower.com/schemas/management\">");
			if (string.IsNullOrEmpty(pName))
				pCmd.AppendLine("<dp:get-status class=\"ObjectStatus\" object-class=\"HTTPSourceProtocolHandler\"/>");
			else
				pCmd.AppendLine("<dp:get-status class=\"ObjectStatus\" object-class=\"HTTPSourceProtocolHandler\" object-name=\"" + pName + "\"/>");
			pCmd.AppendLine("</dp:request>");
			var execCmd = ExecuteCommands(pCmd);
			if (execCmd.Contains("error-log"))
			{
				response.Code = 1;
				response.Titulo = "Error al ejecutar el servicio";
				response.Message = (from x in XDocument.Parse(execCmd).Descendants("log-event")
														select x.Value).FirstOrDefault();
			}
			else
			{
				response.Code = 0;
				var lstCast = new List<OpStatus>(from x in XDocument.Parse(execCmd).Descendants("ObjectStatus")
																				 select new OpStatus(x, pEnvironment, pHost, pDomain));
				if (string.IsNullOrEmpty(pName))
					response.Entity = lstCast;
				else
					response.Entity = lstCast.FirstOrDefault();
			}
			return Task.FromResult(response);
		}
		public Task<ServiceResponse> GetOpStatusHttps(string pEnvironment, string pHost, string pDomain, string pName)
		{
			var response = new ServiceResponse();
			this.Environment = pEnvironment;
			this.Host = pHost;
			this.Domain = pDomain.ToUpper();
			var pCmd = new StringBuilder();
			pCmd.AppendLine("<dp:request domain=\"" + this.Domain + "\" xmlns:dp=\"http://www.datapower.com/schemas/management\">");
			if (string.IsNullOrEmpty(pName))
				pCmd.AppendLine("<dp:get-status class=\"ObjectStatus\" object-class=\"HTTPSSourceProtocolHandler\"/>");
			else
				pCmd.AppendLine("<dp:get-status class=\"ObjectStatus\" object-class=\"HTTPSSourceProtocolHandler\" object-name=\"" + pName + "\"/>");
			pCmd.AppendLine("</dp:request>");
			var execCmd = ExecuteCommands(pCmd);
			if (execCmd.Contains("error-log"))
			{
				response.Code = 1;
				response.Titulo = "Error al ejecutar el servicio";
				response.Message = (from x in XDocument.Parse(execCmd).Descendants("log-event")
														select x.Value).FirstOrDefault();
			}
			else
			{
				response.Code = 0;
				var lstCast = new List<OpStatus>(from x in XDocument.Parse(execCmd).Descendants("ObjectStatus")
																				 select new OpStatus(x, pEnvironment, pHost, pDomain));
				if (string.IsNullOrEmpty(pName))
					response.Entity = lstCast;
				else
					response.Entity = lstCast.FirstOrDefault();
			}
			return Task.FromResult(response);
		}
		public Task<ServiceResponse> GetIpAddress(string pEnvironment, string pHost, string pDomain, string pName)
		{
			var response = new ServiceResponse();
			this.Environment = pEnvironment;
			this.Host = pHost;
			this.Domain = pDomain.ToUpper();
			var pCmd = new StringBuilder();
			pCmd.AppendLine("<dp:request domain=\"" + this.Domain + "\" xmlns:dp=\"http://www.datapower.com/schemas/management\">");
			if (string.IsNullOrEmpty(pName))
				pCmd.AppendLine("<dp:get-status class=\"DNSStaticHostStatus\"/>");
			pCmd.AppendLine("</dp:request>");
			var execCmd = ExecuteCommands(pCmd);
			if (execCmd.Contains("error-log"))
			{
				response.Code = 1;
				response.Titulo = "Error al ejecutar el servicio";
				response.Message = (from x in XDocument.Parse(execCmd).Descendants("log-event")
														select x.Value).FirstOrDefault();
			}
			else
			{
				response.Code = 0;
				var lstCast = new List<DnsStaticHostStatus>(from x in XDocument.Parse(execCmd).Descendants("DNSStaticHostStatus")
																										select new DnsStaticHostStatus(x, pEnvironment, pHost, pDomain));
				if (string.IsNullOrEmpty(pName))
					response.Entity = lstCast;
				else
					response.Entity = lstCast.FirstOrDefault();
			}
			return Task.FromResult(response);
		}
	}
}
