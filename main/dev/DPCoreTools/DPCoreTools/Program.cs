using System;
using System.Net.Sockets;
using Gelf.Extensions.Logging;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

namespace DPCoreTools
{
	public class Program
	{
		public static void Main(string[] args)
		{
			CreateWebHostBuilder(args)
				.UseStartup<Startup>()
				.ConfigureLogging((context, builder) =>
				{
					builder.AddConfiguration(context.Configuration.GetSection("Logging"))
						.AddConsole()
						.AddGelf(options =>
						{
							options.Host = context.Configuration.GetSection("Logging").GetSection("GrayLog").GetSection("Hostname").Value;
							options.LogSource = context.Configuration.GetSection("Logging").GetSection("GrayLog").GetSection("LogSource").Value;
							options.Port = Int32.Parse(context.Configuration.GetSection("Logging").GetSection("GrayLog").GetSection("Port").Value);
							options.Protocol = GelfProtocol.Udp;
						});
				})
				.Build().Run();
		}

		public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseKestrel()
				.UseIISIntegration()
				.UseStartup<Startup>();
	}
}
