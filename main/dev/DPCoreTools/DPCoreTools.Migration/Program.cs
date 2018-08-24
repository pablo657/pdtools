using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Gelf.Extensions.Logging;
using DpCoreTools.Service;
using DPCoreTools.SeedWork;

namespace DPCoreTools.Migration
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Configure Apps
			var configuration = new ConfigurationBuilder()
				.AddJsonFile("appsettings.json")
				.Build();

			//setup our DI
			var svcProvider = new ServiceCollection()
				//.Configure<GelfLoggerOptions>(configuration.GetSection("Logging"))
				.AddLogging()
				.AddSingleton<IMigrationService, MigrationService>()
				.BuildServiceProvider();
			#endregion

			if (!args.Any())
			{
				Console.WriteLine("Debe ingresar los parámetros");
			}
			else
			{
				//REM < -----PARAMETROS----->
				//REM	--	0 Tipo de Migracion: C -> Archivos comunes / Z -> Archivos Zip
				//REM	--	1 AMBIENTE
				//REM < -----PARAMETROS----->
				var migrationType = args[0];
				var ambiente = args[1];
				var hostReceived = false;
				var hostDP = "10.76.60.18";
				switch (migrationType.ToUpper())
				{
					case "C":
						//REM <-----PARAMETROS----->
						//REM --	2 Host
						//REM <-----PARAMETROS----->

						break;
					case "Z":
						//REM <-----PARAMETROS----->
						//REM --	2 MPGW Name
						//REM	--	3 Host
						//REM <-----PARAMETROS----->
						var mpgName = args[2];
						var ambienteDecript = "DESARROLLO";
						if (args.ToList().Count > 3)
						{
							hostReceived = true;
							hostDP = args[3];
						}
						//Chequear si recibi el host de RA o no.
						//Loguear los parametros recibidos.
						//Desencriptar user y pwd

						break;
					default:
						Console.WriteLine("Se ha ingresado una opción que no es válida!");
						break;
				}
			}
		}

		private static void UseLogger(ILogger<Program> logger)
		{
			const string framework = "netcoreapp2.0";

			logger.LogInformation("Information log from {framework}", framework);

			using (logger.BeginScope(("scope_field_1", "migration")))
			{
				logger.LogDebug("Debug log from {framework}", framework);

				using (logger.BeginScope(new Dictionary<string, object>
				{
					["scope_field_2"] = "bar",
					["scope_field_3"] = "baz"
				}))
				{
					logger.LogTrace("Trace log from {framework}", framework);
				}

				logger.LogError(new EventId(), new Exception("Example exception!"),
					"Error log from {framework}", framework);
			}
		}
	}
}
