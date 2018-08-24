using System.Collections.Generic;
using System.IO;
using System.Linq;
using DPCoreTools.Controllers;
using Microsoft.Extensions.Configuration;


namespace DPCoreTools.UI.Extensions
{
    public static class EntitiesExtensions
    {
        public static List<string> GetHostsList(string pEnvironment = null)
        {
            var hosts = new List<string>();

            if (string.IsNullOrEmpty(pEnvironment))
                return hosts;
            switch (pEnvironment.ToUpper().Trim())
            {

                case "DESARROLLO":
                    hosts.Add("dpconsoledesa.telecom.com.ar");
                    break;
                case "TESTING":
                    hosts.Add("dpconsoletest.telecom.com.ar");
                    break;
                case "UAT":
                    hosts.Add("dpconsoleuat.telecom.com.ar");
                    break;
                case "PRODUCCION":
                    hosts.Add("dpconsole1.personal.com.ar");
                    hosts.Add("dpconsole2.personal.com.ar");
                    hosts.Add("dpconsole3.telecom.com.ar");
                    hosts.Add("dpconsole4.telecom.com.ar");
                    hosts.Add("dpconsole5.telecom.com.ar");
                    hosts.Add("dpconsole5.telecom.com.ar");
                    break;
            }
            return hosts;
        }

        public static List<string> GetEnvironmentsList()
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);
            var root = configurationBuilder.Build();
            List<string> environments = root.GetSection("Environments").GetSection("Allowed").Value.Split(';').ToList();
            return environments;
        }
        public static List<string> GetProtocolsList()
        {
            var protocols = new List<string>()
            {
                "HTTP Handler",
                "HTTPS Handler",
                "Todos"
            };
            return protocols;
        }

        public static DropDownItems GetDropDownItems(List<string> pList = null)
        {
            var oRtn = new DropDownItems
      {
        DropDownBase.GetEmptyItem(DropDownBase.EmptyItem.Select_String)
      };
            if (pList != null)
                oRtn.AddRange(pList.Select((t, i) => new DropDownItem((i + 1).ToString(), t)));
            return oRtn;
        }
    }
}
