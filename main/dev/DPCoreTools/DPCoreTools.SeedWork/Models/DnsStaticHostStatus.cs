using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace DPCoreTools.SeedWork.Models
{
	public class DnsStaticHostStatus : DataPower
	{
		public string Alias { get; set; }
		public string Ip { get; set; }
		public string Type { get; set; }

		#region Constructor
		public DnsStaticHostStatus()
		{
		}

		public DnsStaticHostStatus(XElement xElement, string pEnvironment, string pHost, string pDomain)
		{
			Alias = xElement.Element("Hostname")?.Value;
			Ip = xElement.Element("IPAddress")?.Value;
			Type = xElement.Element("Type")?.Value;
			Environment = pEnvironment;
			Host = pHost;
			Domain = pDomain;
		}
		#endregion
	}
}