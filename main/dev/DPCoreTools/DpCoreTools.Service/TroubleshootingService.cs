using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DPCoreTools.SeedWork;
using DPCoreTools.SeedWork.Models;

namespace DpCoreTools.Service
{
	public class TroubleshootingService : BaseService, ITroubleshootingService
	{
		public Task<ServiceResponse> Ping(string pEnvironment, string pHost, string pDomain, string pUri)
		{
			var response = new ServiceResponse();
			this.Environment = pEnvironment;
			this.Host = pHost;
			this.Domain = pDomain.ToUpper();
			var pCmd = new StringBuilder();
			pCmd.AppendLine("<dp:request domain=\"" + this.Domain + "\" xmlns:dp=\"http://www.datapower.com/schemas/management\">");
			pCmd.AppendLine("<dp:do-action>");
			pCmd.AppendLine("<Ping>");
			pCmd.AppendLine("<RemoteHost>" + pUri + "</RemoteHost>");
			pCmd.AppendLine("</Ping>");
			pCmd.AppendLine("</dp:do-action>");
			pCmd.AppendLine("</dp:request>");
			var execCmd = ExecuteCommands(pCmd);
			if (execCmd.Contains("error-log"))
			{
				response.Code = 1;
				response.Titulo = "Error al ejecutar el servicio";
				response.Message = (from x in XDocument.Parse(execCmd).Descendants("error-log")
														select x.Descendants("log-event").First().Value).FirstOrDefault();
			}
			else
			{
				response.Code = 0;
				response.Message = "Ejecución Ping: OK";
			}
			return Task.FromResult(response);
		}

		public Task<ServiceResponse> TcpPing(string pEnvironment, string pHost, string pDomain, string pUri, string pPort)
		{
			var response = new ServiceResponse();
			this.Environment = pEnvironment;
			this.Host = pHost;
			this.Domain = pDomain.ToUpper();
			var pCmd = new StringBuilder();
			pCmd.AppendLine("<dp:request domain=\"" + this.Domain + "\" xmlns:dp=\"http://www.datapower.com/schemas/management\">");
			pCmd.AppendLine("<dp:do-action>");
			pCmd.AppendLine("<TCPConnectionTest>");
			pCmd.AppendLine("<RemoteHost>" + pUri + "</RemoteHost>");
			pCmd.AppendLine("<RemotePort>" + pPort + "</RemotePort>");
			pCmd.AppendLine("</TCPConnectionTest>");
			pCmd.AppendLine("</dp:do-action>");
			pCmd.AppendLine("</dp:request>");
			var execCmd = ExecuteCommands(pCmd);
			if (execCmd.Contains("error-log"))
			{
				response.Code = 1;
				response.Titulo = "Error al ejecutar el servicio";
				response.Message = (from x in XDocument.Parse(execCmd).Descendants("error-log")
														select x.Descendants("log-event").First().Value).FirstOrDefault();
			}
			else
			{
				response.Code = 0;
				response.Message = "Ejecución Ping: OK";
			}
			return Task.FromResult(response);
		}

	}
}