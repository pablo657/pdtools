using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DPCoreTools.SeedWork.Models;
using DPCoreTools.SeedWork.Services;

namespace DpCoreTools.Service.Main
{
	public class XmlFirewallService : BaseService, IXmlFirewallService
	{
		public Task<ServiceResponse> GetXmlFirewall(string pEnvironment, string pHost, string pDomain)
		{
			return GetXmlFirewall(pEnvironment, pHost, pDomain, string.Empty);
		}
		public Task<ServiceResponse> GetXmlFirewall(string pEnvironment, string pHost, string pDomain, string pName)
		{
			var response = new ServiceResponse();
			this.Environment = pEnvironment;
			this.Host = pHost;
			this.Domain = pDomain.ToUpper();
			var pCmd = new StringBuilder();
			pCmd.AppendLine("<dp:request domain=\"" + this.Domain + "\" xmlns:dp=\"http://www.datapower.com/schemas/management\">");
			if (string.IsNullOrEmpty(pName))
				pCmd.AppendLine("<dp:get-config class=\"XMLFirewallService\"/>");
			else
				pCmd.AppendLine("<dp:get-config class=\"XMLFirewallService\" name=\"" + pName + "\"/>");
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
				var lstXmlF = new List<XmlFirewall>(from x in XDocument.Parse(execCmd).Descendants("XMLFirewallService")
																						select new XmlFirewall(x, pEnvironment, pHost, pDomain));
				var rOpStatus = GetOpStatus(pEnvironment, pHost, pDomain);
				if (rOpStatus.Result.Code == 0)
				{
					var lstOpStatus = (List<OpStatus>)rOpStatus.Result.Entity;
					foreach (var item in lstXmlF)
					{
						item.OpState = lstOpStatus.FirstOrDefault(y => y.Name.Trim().ToLower() == item.Name.Trim().ToLower());
					}
				}
				//se obtienen las ip del local address
				var rIpAdd = GetIpAddress(pEnvironment, pHost, pDomain, string.Empty);
				if (rIpAdd.Result.Code == 0)
				{
					var lstIpAdd = (List<DnsStaticHostStatus>)rIpAdd.Result.Entity;
					foreach (var item in lstXmlF)
					{
						item.Dns = lstIpAdd.FirstOrDefault(y => y.Alias.Trim().ToLower() == item.LocalAddress.Trim().ToLower());
					}
				}

				if (string.IsNullOrEmpty(pName))
					response.Entity = lstXmlF;
				else
					response.Entity = lstXmlF.FirstOrDefault();
			}
			return Task.FromResult(response);
		}
		public Task<ServiceResponse> GetOpStatus(string pEnvironment, string pHost, string pDomain)
		{
			return GetOpStatus(pEnvironment, pHost, pDomain, string.Empty);
		}
		public Task<ServiceResponse> GetOpStatus(string pEnvironment, string pHost, string pDomain, string pName)
		{
			var response = new ServiceResponse();
			this.Environment = pEnvironment;
			this.Host = pHost;
			this.Domain = pDomain.ToUpper();
			var pCmd = new StringBuilder();
			pCmd.AppendLine("<dp:request domain=\"" + this.Domain + "\" xmlns:dp=\"http://www.datapower.com/schemas/management\">");
			if (string.IsNullOrEmpty(pName))
				pCmd.AppendLine("<dp:get-status class=\"ObjectStatus\" object-class=\"XMLFirewallService\"/>");
			else
				pCmd.AppendLine("<dp:get-status class=\"ObjectStatus\" object-class=\"XMLFirewallService\" object-name=\"" + pName + "\"/>");
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
		public Task<ServiceResponse> ChangeProbe(string pEnvironment, string pHost, string pDomain, string pName, bool pEnable)
		{
			var response = new ServiceResponse();
			this.Environment = pEnvironment;
			this.Host = pHost;
			this.Domain = pDomain.ToUpper();
			var pCmd = new StringBuilder();
			pCmd.AppendLine("<dp:request domain=\"" + this.Domain + "\" xmlns:dp=\"http://www.datapower.com/schemas/management\">");
			pCmd.AppendLine("<dp:modify-config>");
			pCmd.AppendLine("<XMLFirewallService name=\"" + pName + "\">");
			pCmd.AppendLine(pEnable ? "<DebugMode>on</DebugMode>" : "<DebugMode>off</DebugMode>");
			pCmd.AppendLine("</XMLFirewallService>");
			pCmd.AppendLine("</dp:modify-config>");
			pCmd.AppendLine("</dp:request>");
			var execCmd = ExecuteCommands(pCmd);
			if (execCmd.Contains("Fault"))
			{
				response.Code = 1;
				response.Titulo = "Error en la invocación del servicio";
				response.Message = (from x in XDocument.Parse(execCmd).Descendants("faultstring")
														select x.Value).FirstOrDefault();
			}
			else if (execCmd.Contains("error-log"))
			{
				response.Code = 1;
				response.Titulo = "Error al ejecutar el servicio";
				response.Message = (from x in XDocument.Parse(execCmd).Descendants("log-event")
														select x.Value).FirstOrDefault();
			}
			else
			{
				response.Code = 0;
				response.Message = pEnable ? "Habilitar Probe: OK" : "Deshabilitar Probe: OK";
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
