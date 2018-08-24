using System.Threading.Tasks;
using DPCoreTools.SeedWork.Models;

namespace DPCoreTools.SeedWork
{
	public interface IFrontSideHandlerService
	{
		/// <summary>
		/// Get list of handlers
		/// </summary>
		/// <param name="pEnvironment">Environment to check</param>
		/// <param name="pHost">host to retrieve the list of Front Side Handler</param>
		/// <param name="pDomain">Domain</param>
		/// <param name="protocol">Protocol</param>
		/// <returns></returns>
		Task<ServiceResponse> GetHandlers(string pEnvironment, string pHost, string pDomain, int protocol);

		/// <summary>
		/// Get details of specific Front Side Handler
		/// </summary>
		/// <param name="pEnvironment">Environment to check</param>
		/// <param name="pHost">host to retrieve the FrontSideHandler</param>
		/// <param name="pDomain">Domain</param>
		/// <param name="pName">Service name to search</param>
		/// <returns></returns>
		Task<ServiceResponse> GetHttpHandlers(string pEnvironment, string pHost, string pDomain, string pName);

		/// <summary>
		/// Get list of HTTP handlers
		/// </summary>
		/// <param name="pEnvironment">Environment to check</param>
		/// <param name="pHost">host to retrieve the list of Front Side Handler</param>
		/// <param name="pDomain">Domain</param>
		/// <returns></returns>
		Task<ServiceResponse> GetHttpHandlers(string pEnvironment, string pHost, string pDomain);

		/// <summary>
		/// Get details of a specific HTTPS Front Side Handler
		/// </summary>
		/// <param name="pEnvironment">Environment to check</param>
		/// <param name="pHost">host to retrieve the FrontSideHandler</param>
		/// <param name="pDomain">Domain</param>
		/// <param name="pName">Service name to search</param>
		/// <returns></returns>
		Task<ServiceResponse> GetHttpsHandlers(string pEnvironment, string pHost, string pDomain, string pName);

		/// <summary>
		/// Get list of HTTPS handlers
		/// </summary>
		/// <param name="pEnvironment">Environment to check</param>
		/// <param name="pHost">host to retrieve the list of Front Side Handler</param>
		/// <param name="pDomain">Domain</param>
		/// <returns></returns>
		Task<ServiceResponse> GetHttpsHandlers(string pEnvironment, string pHost, string pDomain);

		/// <summary>
		/// Get list of HTTPS and HTTP handlers
		/// </summary>
		/// <param name="pEnvironment">Environment to check</param>
		/// <param name="pHost">host to retrieve the list of Front Side Handler</param>
		/// <param name="pDomain">Domain</param>
		/// <returns></returns>
		Task<ServiceResponse> GetBothHandlers(string pEnvironment, string pHost, string pDomain);

		/// <summary>
		/// Get Operation Status of specific Front Side Handler Services
		/// </summary>
		/// <param name="pEnvironment">Environment to check</param>
		/// <param name="pHost">host to retrieve the FrontSideHandler</param>
		/// <param name="pDomain">Domain</param>
		/// <returns></returns>
		Task<ServiceResponse> GetOpStatusHttp(string pEnvironment, string pHost, string pDomain);

		/// <summary>
		/// Get Operation Status of specific Front Side Handler Services
		/// </summary>
		/// <param name="pEnvironment">Environment to check</param>
		/// <param name="pHost">host to retrieve the FrontSideHandler</param>
		/// <param name="pDomain">Domain</param>
		/// <returns></returns>
		Task<ServiceResponse> GetOpStatusHttps(string pEnvironment, string pHost, string pDomain);

		/// <summary>
		/// Get Operation Status of specific Front Side Handler
		/// </summary>
		/// <param name="pEnvironment">Environment to check</param>
		/// <param name="pHost">host to retrieve the FrontSideHandler</param>
		/// <param name="pDomain">Domain</param>
		/// <param name="pName">Service name to search</param>
		/// <returns></returns>
		Task<ServiceResponse> GetOpStatusHttp(string pEnvironment, string pHost, string pDomain, string pName);

		/// <summary>
		/// Get Operation Status of specific Front Side Handler
		/// </summary>
		/// <param name="pEnvironment">Environment to check</param>
		/// <param name="pHost">host to retrieve the FrontSideHandler</param>
		/// <param name="pDomain">Domain</param>
		/// <param name="pName">Service name to search</param>
		/// <returns></returns>
		Task<ServiceResponse> GetOpStatusHttps(string pEnvironment, string pHost, string pDomain, string pName);
	}
}
