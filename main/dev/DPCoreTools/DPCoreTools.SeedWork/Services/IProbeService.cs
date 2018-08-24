using System.Threading.Tasks;
using DPCoreTools.SeedWork.Models;

namespace DPCoreTools.SeedWork.Services
{
	public interface IProbeService
	{
		/// <summary>
		/// Disable Probe on MultiProtocol Gateway Service
		/// </summary>
		/// <param name="pEnvironment">Environment to check</param>
		/// <param name="pHost">host to retrieve the list of domains</param>
		/// <param name="pDomain">Domain</param>
		/// <param name="pName">Name of MultiProtocol Gateway</param>
		/// <returns></returns>
		Task<ServiceResponse> DisableProbe(string pEnvironment, string pHost, string pDomain, string pName);
	}
}
