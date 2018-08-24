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
	public class DomainController : BaseController
	{
		readonly IDomainService _domainService;
		private readonly ILogger _logger;

		public DomainController(IDomainService domainService, ILogger<DomainController> logger)
		{
			_domainService = domainService;
			_logger = logger;
		}

		public async Task<ActionResult> Index()
		{
			_logger.LogInformation("Iniciando vista Index Domains");
			var model = new ServiceResponse();
			ViewBag.Hosts = EntitiesExtensions.GetDropDownItems(EntitiesExtensions.GetHostsList());
			ViewBag.Environments = EntitiesExtensions.GetDropDownItems(EntitiesExtensions.GetEnvironmentsList());
			return View(model);
		}

		[HttpPost]
		public async Task<ActionResult> GetDomains(DpSelectModel model)
		{
			_logger.LogInformation("Buscando Dominios");
			var result = new ServiceResponse();
			try
			{
				if (ModelState.IsValid)
					result = await _domainService.GetDomains(model.Environment, model.Host);
			}
			catch (Exception e)
			{
				_logger.LogError(e.InnerException.Message);
			}
			return Json(result);
		}

		public async Task<IActionResult> GetDomainsGrid(DpSelectModel model)
		{
			_logger.LogInformation("Buscando Dominios");
			var result = new ServiceResponse();
			try
			{
				if (ModelState.IsValid)
					result = await _domainService.GetDomains(model.Environment, model.Host);
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