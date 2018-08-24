using System;
using System.IO.Compression;
using DpCoreTools.Service;
using DpCoreTools.Service.Main;
using DPCoreTools.SeedWork;
using DPCoreTools.SeedWork.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DPCoreTools
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		//This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();
			services.AddSingleton(Configuration);
			//Register Our Services
			services.AddTransient<IDomainService, DomainService>();
			services.AddTransient<IFrontSideHandlerService, FrontSideHandlerService>();
			services.AddTransient<IMultiProtocolGatewayService, MultiProtocolGatewayService>();
			services.AddTransient<ITroubleshootingService, TroubleshootingService>();
			services.AddTransient<IXmlFirewallService, XmlFirewallService>();

			services.Configure<GzipCompressionProviderOptions>(options => options.Level = CompressionLevel.Optimal);
			services.AddResponseCompression(options => { options.EnableForHttps = Boolean.Parse(Configuration.GetSection("Compression").GetSection("EnableForHttps").Value); });
		}

		//This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseBrowserLink();
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}
			app.UseHttpsRedirection();
			app.UseResponseCompression();
			app.UseStaticFiles(new StaticFileOptions
			{
				OnPrepareResponse = context =>
				{
					if (string.IsNullOrEmpty(context.Context.Request.Query["v"])) return;
					context.Context.Response.Headers.Add("cache-control", new[] { "public, max-age=64869000" });
					context.Context.Response.Headers.Add("Expires", new[] { DateTime.UtcNow.AddYears(1).ToString("R") });
				}
			});
			app.UseCookiePolicy();
			app.UseAuthentication();
			app.UseMvc(routes =>
			{
				routes.MapRoute("home", "home/{*index}",
					defaults: new { controller = "Home", action = "Index" });
				routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
