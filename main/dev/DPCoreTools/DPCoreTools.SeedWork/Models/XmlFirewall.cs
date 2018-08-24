using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace DPCoreTools.SeedWork.Models
{
	public class XmlFirewall : DataPower
	{

		public string Name { get; set; }
		public OpStatus OpState { get; set; }
		public bool AdminState { get; set; }
		public string LocalAddress { get; set; }
		public string Summary { get; set; }
		public string Priority { get; set; }
		public int LocalPort { get; set; }
		public int HTTPTimeout { get; set; }
		public int HTTPPersistTimeout { get; set; }
		public bool DoHostRewrite { get; set; }
		public bool HTTPCompression { get; set; }
		public bool HTTPPersistentConnections { get; set; }
		public string Probe { get; set; }
		public string Type { get; set; }
		public string XMLManager { get; set; }
		public string StylePolicy { get; set; }
		public string RequestType { get; set; }
		public string ResponseType { get; set; }
		public string CredentialCharset { get; set; }
		public string SSLConfigType { get; set; }
		public string SSLServer { get; set; }
		public string SSLClient { get; set; }
		public List<HttpVersion> HTTPVersion { get; set; }
		public DnsStaticHostStatus Dns { get; set; }

		#region Mapped
		//            <XMLFirewallService xmlns:env="http://www.w3.org/2003/05/soap-envelope" name="API-DP-Transactions">
		//                -<mAdminState>enabled</mAdminState>*
		//                -<LocalAddress>API_PRE_DESA</LocalAddress>*
		//                -<UserSummary>an example XML Firewall Service</UserSummary>*
		//                -<Priority>normal</Priority>*
		//                -<LocalPort>2061</LocalPort>*
		//                -<HTTPTimeout>120</HTTPTimeout>*
		//                <HTTPPersistTimeout>180</HTTPPersistTimeout>
		//                -<DoHostRewrite>on</DoHostRewrite>*
		//                <SuppressHTTPWarnings>off</SuppressHTTPWarnings>
		//                -<HTTPCompression>off</HTTPCompression>*
		//                <HTTPIncludeResponseTypeEncoding>off</HTTPIncludeResponseTypeEncoding>
		//                <AlwaysShowErrors>off</AlwaysShowErrors>
		//                <DisallowGet>on</DisallowGet>
		//                <DisallowEmptyResponse>off</DisallowEmptyResponse>
		//                -<HTTPPersistentConnections>on</HTTPPersistentConnections>*
		//                <HTTPClientIPLabel>X-Client-IP</HTTPClientIPLabel>
		//                <HTTPLogCorIDLabel>X-Global-Transaction-ID</HTTPLogCorIDLabel>
		//                <HTTPProxyPort>800</HTTPProxyPort>
		//                <HTTPVersion>*
		//                    <Front>HTTP/1.1</Front>*
		//                    <Back>HTTP/1.1</Back>*
		//                </HTTPVersion>
		//                <DoChunkedUpload>off</DoChunkedUpload>
		//                <DefaultParamNamespace>http://www.datapower.com/param/config</DefaultParamNamespace>
		//                <QueryParamNamespace>http://www.datapower.com/param/query</QueryParamNamespace>
		//                <ForcePolicyExec>off</ForcePolicyExec>
		//                <MonitorProcessingPolicy>terminate-at-first-throttle</MonitorProcessingPolicy>
		//                -<DebugMode persisted = "false" > off </ DebugMode >*
		//                < DebugHistory > 25 </ DebugHistory >
		//                -< Type > loopback - proxy </ Type >*
		//                -< XMLManager class="XMLManager">API-XMLManager</XMLManager>*
		//                -<StylePolicy class="StylePolicy">API-DP-Transactions</StylePolicy>*
		//                <MaxMessageSize>0</MaxMessageSize>
		//                -<RequestType>preprocessed</RequestType>*
		//                -<ResponseType>preprocessed</ResponseType>*
		//                <RequestAttachments>strip</RequestAttachments>
		//                <ResponseAttachments>strip</ResponseAttachments>
		//                <RootPartNotFirstAction>process-in-order</RootPartNotFirstAction>
		//                <FrontAttachmentFormat>dynamic</FrontAttachmentFormat>
		//                <BackAttachmentFormat>dynamic</BackAttachmentFormat>
		//                <MIMEHeaders>on</MIMEHeaders>
		//                <RewriteErrors>on</RewriteErrors>
		//                <DelayErrors>on</DelayErrors>
		//                <DelayErrorsDuration>1000</DelayErrorsDuration>
		//                <SOAPSchemaURL>store:///schemas/soap-envelope.xsd</SOAPSchemaURL>
		//                <WSDLResponsePolicy>off</WSDLResponsePolicy>
		//                <FirewallParserLimits>off</FirewallParserLimits>
		//                <ParserLimitsBytesScanned>4194304</ParserLimitsBytesScanned>
		//                <ParserLimitsElementDepth>512</ParserLimitsElementDepth>
		//                <ParserLimitsAttributeCount>128</ParserLimitsAttributeCount>
		//                <ParserLimitsMaxNodeSize>33554432</ParserLimitsMaxNodeSize>
		//                <ParserLimitsForbidExternalReferences>on</ParserLimitsForbidExternalReferences>
		//                <ParserLimitsMaxPrefixes>1024</ParserLimitsMaxPrefixes>
		//                <ParserLimitsMaxNamespaces>1024</ParserLimitsMaxNamespaces>
		//                <ParserLimitsMaxLocalNames>60000</ParserLimitsMaxLocalNames>
		//                <ParserLimitsAttachmentByteCount>2000000000</ParserLimitsAttachmentByteCount>
		//                <ParserLimitsAttachmentPackageByteCount>0</ParserLimitsAttachmentPackageByteCount>
		//                <ParserLimitsExternalReferences>forbid</ParserLimitsExternalReferences>
		//                -<CredentialCharset>protocol</CredentialCharset>*
		//								<SSLServer class="SSLServerProfile">API-Telecom-SSLProfile</SSLServer>*
		//								<SSLClient class="SSLClientProfile">API-Proxy-SSL-ClientProfile</SSLClient>*
		//                <SSLConfigType>server</SSLConfigType>*
		//            </XMLFirewallService>
		#endregion

		#region Constructor
		public XmlFirewall()
		{

		}
		public XmlFirewall(XElement xElement, string pEnvironment, string pHost, string pDomain)
		{
			Name = xElement.Attribute("name")?.Value;
			AdminState = xElement.Element("mAdminState")?.Value == "enabled";
			LocalAddress = xElement.Element("LocalAddress")?.Value;
			Summary = xElement.Element("UserSummary")?.Value;
			Priority = xElement.Element("Priority")?.Value;
			LocalPort = Convert.ToInt32(xElement.Element("LocalPort")?.Value);
			HTTPTimeout = Convert.ToInt32(xElement.Element("HTTPTimeout")?.Value);
			DoHostRewrite = xElement.Element("DoHostRewrite")?.Value == "on";
			HTTPCompression = xElement.Element("HTTPCompression")?.Value == "on";
			HTTPPersistentConnections = xElement.Element("HTTPPersistentConnections")?.Value == "on";
			HTTPPersistTimeout = Convert.ToInt32(xElement.Element("HTTPPersistTimeout")?.Value);
			Probe = xElement.Element("DebugMode")?.Value;
			Type = xElement.Element("Type")?.Value;
			XMLManager = xElement.Element("XMLManager")?.Value;
			StylePolicy = xElement.Element("StylePolicy")?.Value;
			RequestType = xElement.Element("RequestType")?.Value;
			ResponseType = xElement.Element("ResponseType")?.Value;
			CredentialCharset = xElement.Element("CredentialCharset")?.Value;
			SSLConfigType = xElement.Element("SSLConfigType")?.Value;
			OpState = new OpStatus();
			Dns = new DnsStaticHostStatus();
			Environment = pEnvironment;
			Host = pHost;
			Domain = pDomain;
			SSLServer = xElement.Element("SSLServer")?.Value;
			SSLClient = xElement.Element("SSLClient")?.Value;
			HTTPVersion = xElement.Elements("HTTPVersion").Select(version => new HttpVersion
			{
				Front = version.Element("Front").Value,
				Back = version.Element("Back").Value,
			}).ToList();
		}
		#endregion
	}
}
