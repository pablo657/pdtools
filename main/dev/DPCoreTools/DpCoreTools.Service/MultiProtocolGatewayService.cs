using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DPCoreTools.SeedWork;
using DPCoreTools.SeedWork.Models;

namespace DpCoreTools.Service
{
	public class MultiProtocolGatewayService : BaseService, IMultiProtocolGatewayService
	{
		public Task<ServiceResponse> GetMultiProtocolGatewayService(string pEnvironment, string pHost, string pDomain)
		{
			return GetMultiProtocolGatewayService(pEnvironment, pHost, pDomain, string.Empty);
		}

		public Task<ServiceResponse> GetMultiProtocolGatewayService(string pEnvironment, string pHost, string pDomain, string pName)
		{
			var response = new ServiceResponse();
			this.Environment = pEnvironment;
			this.Host = pHost;
			this.Domain = pDomain.ToUpper();
			var pCmd = new StringBuilder();
			pCmd.AppendLine("<dp:request domain=\"" + this.Domain + "\" xmlns:dp=\"http://www.datapower.com/schemas/management\">");
			if (string.IsNullOrEmpty(pName))
				pCmd.AppendLine("<dp:get-config class=\"MultiProtocolGateway\"/>");
			else
				pCmd.AppendLine("<dp:get-config class=\"MultiProtocolGateway\" name=\"" + pName + "\"/>");
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
				var lstMpg = new List<MultiProtocolGateway>(from x in XDocument.Parse(execCmd).Descendants("MultiProtocolGateway")
																										select new MultiProtocolGateway(x, pEnvironment, pHost, pDomain));
				var rOpStatus = GetOpStatus(pEnvironment, pHost, pDomain);
				if (rOpStatus.Result.Code == 0)
				{
					var lstOpStatus = (List<OpStatus>)rOpStatus.Result.Entity;
					foreach (var item in lstMpg)
					{
						item.OpState = lstOpStatus.FirstOrDefault(y => y.Name.Trim().ToLower() == item.Name.Trim().ToLower());
					}
				}
				if (string.IsNullOrEmpty(pName))
					response.Entity = lstMpg;
				else
					response.Entity = lstMpg.FirstOrDefault();
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
				pCmd.AppendLine("<dp:get-status class=\"ObjectStatus\" object-class=\"MultiProtocolGateway\"/>");
			else
				pCmd.AppendLine("<dp:get-status class=\"ObjectStatus\" object-class=\"MultiProtocolGateway\" object-name=\"" + pName + "\"/>");
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
			pCmd.AppendLine("<MultiProtocolGateway name=\"" + pName + "\">");
			pCmd.AppendLine(pEnable ? "<DebugMode>on</DebugMode>" : "<DebugMode>off</DebugMode>");
			pCmd.AppendLine("</MultiProtocolGateway>");
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
	}
}