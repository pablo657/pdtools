using System.Xml.Linq;

namespace DPCoreTools.SeedWork.Models
{
	public class OpStatus : DataPower
	{
		public string Name { get; set; }
		public string Class { get; set; }
		public string Status { get; set; }
		public bool AdminState { get; set; }
		public string EventCode { get; set; }
		public string ErrorCode { get; set; }
		public string ConfigState { get; set; }

		#region Constructor
		public OpStatus()
		{
		}

		public OpStatus(XElement xElement, string pEnvironment, string pHost, string pDomain)
		{
			Name = xElement.Element("Name")?.Value;
			Class= xElement.Element("Class")?.Value;
			Status = xElement.Element("OpState")?.Value;
			AdminState = xElement.Element("AdminState")?.Value == "enabled";
			EventCode = xElement.Element("EventCode")?.Value;
			ErrorCode = xElement.Element("ErrorCode")?.Value;
			ConfigState = xElement.Element("ConfigState")?.Value;
			Environment = pEnvironment;
			Host = pHost;
			Domain = pDomain;
		}
		#endregion
	}
}
