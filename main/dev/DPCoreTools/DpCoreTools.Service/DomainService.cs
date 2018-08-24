using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DPCoreTools.SeedWork;
using DPCoreTools.SeedWork.Models;

namespace DpCoreTools.Service
{
	public class DomainService : BaseService, IDomainService
	{
		public Task<ServiceResponse> GetDomains(string pEnvironment, string pHost)
		{
			var response = new ServiceResponse();
			this.Host = pHost;
			this.Environment = pEnvironment.ToUpper();
			this.UseAmp = true;
			var pCmd = new StringBuilder();
			pCmd.AppendLine("<dp:GetDomainListRequest xmlns:dp=\"http://www.datapower.com/schemas/appliance/management/1.0\"/>");
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