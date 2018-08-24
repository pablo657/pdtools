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
using DPCoreTools.SeedWork.Services;

namespace DPCoreTools.UI.Controllers
{
	[Route("[controller]/[action]")]
	public class XmlFirewallController : Controller
	{
		readonly IXmlFirewallService _xmlFirewallService;
		private readonly ILogger _logger;

		public XmlFirewallController(IXmlFirewallService xmlFirewallService, ILogger<XmlFirewallController> logger)
		{
			_xmlFirewallService = xmlFirewallService;
			_logger = logger;
		}

		public async Task<ActionResult> Index()
		{
			_logger.LogInformation("Iniciando vista Index XMLFirewall");
			ViewBag.Hosts = EntitiesExtensions.GetDropDownItems(EntitiesExtensions.GetHostsList());
			ViewBag.Environments = EntitiesExtensions.GetDropDownItems(EntitiesExtensions.GetEnvironmentsList());
			ViewBag.Domains = EntitiesExtensions.GetDropDownItems();
			return View();
		}

		public async Task<ActionResult> Details(string id, string environment, string host, string domain, string protocol)
		{
			_logger.LogInformation("Iniciando la vista Detalle del servicio: " + id);
			var result = new ServiceResponse();
			try
			{
				if (ModelState.IsValid)
					result = await _xmlFirewallService.GetXmlFirewall(environment, host, domain, id);
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

		public async Task<IActionResult> GetXmlFirewallList(DpSelectModel model)
		{
			_logger.LogInformation("Buscando XML Firewall");
			var result = new ServiceResponse();
			try
			{
				if (ModelState.IsValid)
					result = await _xmlFirewallService.GetXmlFirewall(model.Environment, model.Host, model.Domain);
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
			_logger.LogInformation("Activando Probe en Firewall: " + id);
			var result = new ServiceResponse() { Code = 1 };
			try
			{
				if (ModelState.IsValid)
				{
					if (enable.ToLower() == "off")
						result = await _xmlFirewallService.ChangeProbe(environment, host, domain, id, true);
					else
						result = await _xmlFirewallService.ChangeProbe(environment, host, domain, id, false);
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