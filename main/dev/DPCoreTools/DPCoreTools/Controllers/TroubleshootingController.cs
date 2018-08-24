using System;
using System.Dynamic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DPCoreTools.Controllers;
using DPCoreTools.SeedWork;
using DPCoreTools.SeedWork.Models;
using DPCoreTools.UI.Extensions;
using DPCoreTools.UI.Models;

namespace DPCoreTools.UI.Controllers
{
	[Route("[controller]/[action]")]
	public class TroubleshootingController : BaseController
	{
		readonly ITroubleshootingService _troubleshootingService;
		private readonly ILogger _logger;

		public TroubleshootingController(ITroubleshootingService troubleshootingService, ILogger<TroubleshootingController> logger)
		{
			_troubleshootingService = troubleshootingService;
			_logger = logger;
		}

		public async Task<ActionResult> GetPing()
		{
			_logger.LogInformation("Iniciando vista GetPing Troubleshooting");
			var model = new PingModel { Uri = string.Empty, Domain = string.Empty, Host = string.Empty };
			ViewBag.Hosts = EntitiesExtensions.GetDropDownItems(EntitiesExtensions.GetHostsList());
			ViewBag.Environments = EntitiesExtensions.GetDropDownItems(EntitiesExtensions.GetEnvironmentsList());
			ViewBag.Domains = EntitiesExtensions.GetDropDownItems();
			return View(model);
		}

		[HttpPost]
		public async Task<ActionResult> GetPing(PingModel model)
		{
			var result = new ServiceResponse();
			try
			{
				if (ModelState.IsValid)
					result = await _troubleshootingService.Ping(model.Environment, model.Host, model.Domain, model.Uri);
			}
			catch (Exception e)
			{
				_logger.LogError(e.InnerException.Message);
				result.Code = -1;
				result.Message = e.Message;
			}
			return Json(result);
		}

		public async Task<ActionResult> GetTcpPing()
		{
			_logger.LogInformation("Iniciando vista GetTcpPing Troubleshooting");
			var model = new PingModel { Uri = string.Empty, Domain = string.Empty, Host = string.Empty };
			ViewBag.Hosts = EntitiesExtensions.GetDropDownItems(EntitiesExtensions.GetHostsList());
			ViewBag.Environments = EntitiesExtensions.GetDropDownItems(EntitiesExtensions.GetEnvironmentsList());
			ViewBag.Domains = EntitiesExtensions.GetDropDownItems();
			return View(model);
		}

		[HttpPost]
		public async Task<ActionResult> GetTcpPing(PingModel model)
		{
			var result = new ServiceResponse();
			try
			{
				if (ModelState.IsValid)
					result = await _troubleshootingService.TcpPing(model.Environment, model.Host, model.Domain, model.Uri, model.Port);
			}
			catch (Exception e)
			{
				_logger.LogError(e.InnerException.Message);
				result.Code = -1;
				result.Message = e.Message;
			}
			return Json(result);
		}

	}
}