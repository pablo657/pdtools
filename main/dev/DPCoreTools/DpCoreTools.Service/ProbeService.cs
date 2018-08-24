using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DPCoreTools.SeedWork.Models;
using DPCoreTools.SeedWork.Services;

namespace DpCoreTools.Service.Main
{
	public class ProbeService : BaseService, IProbeService
	{
		public Task<ServiceResponse> DisableProbe(string pEnvironment, string pHost, string pDomain, string pName)
		{
			var response = new ServiceResponse();
			this.Host = pHost;
			this.Environment = pEnvironment.ToUpper();
			this.UseAmp = true;
			var pCmd = new StringBuilder();
			pCmd.AppendLine("<dp:request xmlns:dp=\"http://www.datapower.com/schemas/management\">");
			pCmd.AppendLine("<dp:modify-config>");
			pCmd.AppendLine("<MultiProtocolGateway name=\"1234\">");
			pCmd.AppendLine("<DebugMode>on</DebugMode>");
			pCmd.AppendLine("</MultiProtocolGateway>");
			pCmd.AppendLine("</dp:modify-config>");
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
				XNamespace amp = "http://www.datapower.com/schemas/appliance/management/1.0";
				response.Entity = new List<Domain>(from x in XDocument.Parse(execCmd).Descendants(amp + "Domain")
																					 select new Domain { Name = x.Value });
			}
			return Task.FromResult(response);
		}
	}
}