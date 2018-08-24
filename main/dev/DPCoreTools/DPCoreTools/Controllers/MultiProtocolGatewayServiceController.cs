using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DPCoreTools.Controllers;
using DPCoreTools.SeedWork;
using DPCoreTools.SeedWork.Models;
using DPCoreTools.UI.Extensions;
using DPCoreTools.UI.Models;
using DpCoreTools.Service;

namespace DPCoreTools.UI.Controllers
{
	[Route("[controller]/[action]")]
	public class MultiProtocolGatewayServiceController : BaseController
	{
		readonly IMultiProtocolGatewayService _multiProtocolGatewayService;
		private readonly ILogger _logger;
		private FrontSideHandlerService fsh = new FrontSideHandlerService();

		public MultiProtocolGatewayServiceController(IMultiProtocolGatewayService multiProtocolGatewayService, ILogger<MultiProtocolGatewayServiceController> logger)
		{
			_multiProtocolGatewayService = multiProtocolGatewayService;
			_logger = logger;
		}

		public async Task<ActionResult> Index()
		{
			_logger.LogInformation("Iniciando vista Index MultiProtocolGatewayService");
			ViewBag.Hosts = EntitiesExtensions.GetDropDownItems(EntitiesExtensions.GetHostsList());
			ViewBag.Environments = EntitiesExtensions.GetDropDownItems(EntitiesExtensions.GetEnvironmentsList());
			ViewBag.Domains = EntitiesExtensions.GetDropDownItems();
			return View();
		}

		public async Task<ActionResult> Details(string id, string environment, string host, string domain)
		{
			_logger.LogInformation("Iniciando la vista Detalle del servicio: " + id);
			var result = new ServiceResponse();
			try
			{
				if (ModelState.IsValid)
					result = await _multiProtocolGatewayService.GetMultiProtocolGatewayService(environment, host, domain, id);
				foreach (var item in ((MultiProtocolGateway)(result.Entity)).FrontProtocol)
				{
					switch (item.Class.Replace("SourceProtocolHandler", ""))
					{
						case "HTTP":
							item.OpState = ((OpStatus)((Task<ServiceResponse>)fsh.GetOpStatusHttp(item.Environment, item.Host, item.Domain, item.Name)).Result.Entity);
							break;
						case "HTTPS":
							item.OpState = ((OpStatus)((Task<ServiceResponse>)fsh.GetOpStatusHttps(item.Environment, item.Host, item.Domain, item.Name)).Result.Entity);
							break;
						default:
							break;
					}
				}
				if (result.Code == 1)
					return PartialView("_ServiceResultError", result);
				return View(result.Entity);
			}
			catch (Exception e)
			{
				_logger.LogError(e.InnerException.Message);
				return PartialView("_ServiceResultError", result);
			}
		}

		public async Task<IActionResult> GetGetMultiProtocolGatewayServicesList(DpSelectModel model)
		{
			_logger.LogInformation("Buscando MultiProtocolGatewayServices");
			var result = new ServiceResponse();
			try
			{
				if (ModelState.IsValid)
					result = await _multiProtocolGatewayService.GetMultiProtocolGatewayService(model.Environment, model.Host, model.Domain);
				if (result.Code == 1)
					return PartialView("_ServiceResultError", result);
				return PartialView("_Grid", result.Entity);
			}
			catch (Exception e)
			{
				_logger.LogError(e.InnerException.Message);
				return PartialView("_ServiceResultError", result);
			}
		}

		public async Task<ActionResult> ChangeProbe(string id, string environment, string host, string domain, string enable)
		{
			_logger.LogInformation("Activando Probe en servicio: " + id);
			var result = new ServiceResponse() { Code = 1 };
			try
			{
				if (ModelState.IsValid)
				{
					if (enable.ToLower() == "off")
						result = await _multiProtocolGatewayService.ChangeProbe(environment, host, domain, id, true);
					else
						result = await _multiProtocolGatewayService.ChangeProbe(environment, host, domain, id, false);
					if (result.Code == 1)
						return PartialView("_ServiceResultError", result);
				}
				return Json(result);
			}
			catch (Exception e)
			{
				_logger.LogError(e.InnerException.Message);
				return PartialView("_ServiceResultError", result);
			}
		}
	}
}