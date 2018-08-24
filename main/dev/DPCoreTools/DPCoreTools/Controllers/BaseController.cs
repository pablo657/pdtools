using System.Collections.Generic;
using System.Threading.Tasks;
using DPCoreTools.UI.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace DPCoreTools.Controllers
{
	public class BaseController : Controller
	{

		[HttpPost]
		public async Task<ActionResult> GetHostsList(string pEnvironment)
		{
			var hosts = new List<string>(){ "-- Seleccione --" };
			if (!string.IsNullOrEmpty(pEnvironment))
				hosts.AddRange(EntitiesExtensions.GetHostsList(pEnvironment));
			return Json(hosts);
		}

		public async Task<ActionResult> GetEnviromnentsLis()
		{
			var environments = new List<string>() { "-- Seleccione --" };
			environments.AddRange(EntitiesExtensions.GetEnvironmentsList());
			return Json(environments);
		}

		[HttpPost]
		public async Task<ActionResult> GetDomainsList()
		{
			var hosts = new List<string>() { "-- Seleccione --" };
			return Json(hosts);
		}
	}
}
