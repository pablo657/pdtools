using System.Threading.Tasks;
using DPCoreTools.SeedWork.Models;

namespace DPCoreTools.SeedWork.Services
{
	public interface IXmlFirewallService
	{
		/// <summary>
		/// Get list of XML Firewalls
		/// </summary>
		/// <param name="pEnvironment">Environment to check</param>
		/// <param name="pHost">host to retrieve the list of XMLFirewalls</param>
		/// <param name="pDomain">Domain</param>
		/// <returns></returns>
		Task<ServiceResponse> GetXmlFirewall(string pEnvironment, string pHost, string pDomain);

		/// <summary>
		/// Get list of XML Firewalls for specific Name
		/// </summary>
		/// <param name="pEnvironment">Environment to check</param>
		/// <param name="pHost">host to retrieve the list of XMLFirewalls</param>
		/// <param name="pDomain">Domain</param>
		/// <param name="pName">Service name to search</param>
		/// <returns></returns>
		Task<ServiceResponse> GetXmlFirewall(string pEnvironment, string pHost, string pDomain, string pName);

		/// <summary>
		/// This method allow to enable or disable Probe in specific XML Frirewall
		/// </summary>
		/// <param name="pEnvironment">Environment to check</param>
		/// <param name="pHost">host</param>
		/// <param name="pDomain">Domain</param>
		/// <param name="pName">Service name</param>
		/// <param name="pEnable">true/false</param>
		/// <returns></returns>
		Task<ServiceResponse> ChangeProbe(string pEnvironment, string pHost, string pDomain, string pName, bool pEnable);
	}
}
