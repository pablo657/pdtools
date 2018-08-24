using System;
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
	public class FrontSideHandlerController : BaseController
	{
		readonly IFrontSideHandlerService _frontSideHandlerService;
		private readonly ILogger _logger;

		public FrontSideHandlerController(IFrontSideHandlerService handlerService, ILogger<FrontSideHandlerController> logger)
		{
			_frontSideHandlerService = handlerService;
			_logger = logger;
		}

		public async Task<ActionResult> Index()
		{
			_logger.LogInformation("Iniciando vista Index Handlers");
			ViewBag.Hosts = EntitiesExtensions.GetDropDownItems(EntitiesExtensions.GetHostsList());
			ViewBag.Environments = EntitiesExtensions.GetDropDownItems(EntitiesExtensions.GetEnvironmentsList());
			ViewBag.Domains = EntitiesExtensions.GetDropDownItems();
			ViewBag.FSHProtocols = EntitiesExtensions.GetDropDownItems(EntitiesExtensions.GetProtocolsList());
			return View();
		}

		public async Task<ActionResult> Details(string id, string environment, string host, string domain, string protocol)
		{
			_logger.LogInformation("Iniciando la vista Detalle del servicio: ");
			var result = new ServiceResponse();
			try
			{
				if (ModelState.IsValid)
				{
					if (protocol == "HTTP")
						result = await _frontSideHandlerService.GetHttpHandlers(environment, host, domain, id);
					else
						result = await _frontSideHandlerService.GetHttpsHandlers(environment, host, domain, id);
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

		public async Task<ActionResult> GetFrontSideHandlers(FshSelectModel model)
		{
			_logger.LogInformation("Buscando SourceProtocolHandlerService");
			var result = new ServiceResponse();
			try
			{
				if (ModelState.IsValid) //Valida que sea valido el model que llega por parametro
					result = await _frontSideHandlerService.GetHandlers(model.Environment, model.Host, model.Domain, model.Class);
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
	}
}