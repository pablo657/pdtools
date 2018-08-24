using System.Collections.Generic;
using System.Threading.Tasks;
using DPCoreTools.SeedWork.Models;

namespace DPCoreTools.SeedWork
{
	public interface IDomainService
	{
		/// <summary>
		/// Get list of domains
		/// </summary>
		/// <param name="pEnvironment">Environment to check</param>
		/// <param name="pHost">host to retrieve the list of domains</param>
		/// <returns></returns>
		Task<ServiceResponse> GetDomains(string pEnvironment, string pHost);
	}
}
