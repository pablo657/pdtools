using System;
using System.Threading.Tasks;
using DPCoreTools.SeedWork.Models;

namespace DPCoreTools.SeedWork
{
	public interface ITroubleshootingService
	{
		/// <summary>
		/// Get Ping to Uri passed
		/// </summary>
		/// <param name="pEnvironment">Environment to check</param>
		/// <param name="pHost">host to execute the Ping</param>
		/// <param name="pDomain">Domain to execute the Ping</param>
		/// <param name="pUri">host to Ping</param>
		/// <returns></returns>
		Task<ServiceResponse> Ping(string pEnvironment, string pHost, string pDomain, string pUri);

		/// <summary>
		/// Get TCP Ping to Uri and Port passed
		/// </summary>
		/// <param name="pEnvironment">Environment to check</param>
		/// <param name="pHost">host to execute the Ping</param>
		/// <param name="pDomain">Domain to execute the Ping</param>
		/// <param name="pUri">uri to Ping</param>
		/// <param name="pPort">port to Ping</param>
		/// <returns></returns>
		Task<ServiceResponse> TcpPing(string pEnvironment, string pHost, string pDomain, string pUri, string pPort);

	}
}
