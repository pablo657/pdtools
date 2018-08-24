using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


namespace DPCoreTools.SeedWork.Models
{
	public class FrontSideHandler : DataPower
	{
		public string Class { get; set; }
		public string Name { get; set; }
		public OpStatus OpState { get; set; }
		public bool AdminState { get; set; }
		public string LocalAddress { get; set; }
		public int LocalPort { get; set; }
		public string HTTPVersion { get; set; }
		public bool AllowCompression { get; set; }
		public int MaxURLLen { get; set; }
		public string AccessControlList { get; set; }
		public string SSLServerConfigType { get; set; }
		public string SSLServerProfile { get; set; }
		public List<AllowedFeatures> AllowedFeatures { get; set; }
		public DnsStaticHostStatus Dns { get; set; }

		//HTTS 

		//<mAdminState>enabled</mAdminState>*
		//<LocalAddress>API_PRE_DESA</LocalAddress>*
		//<LocalPort>3457</LocalPort>*
		//<HTTPVersion>HTTP/1.1</HTTPVersion>*
		//<AllowedFeatures>*all
		//    <HTTP-1.0>on</HTTP-1.0>
		//    <HTTP-1.1>on</HTTP-1.1>
		//    <HTTP-2.0>off</HTTP-2.0>
		//    <POST>off</POST>
		//    <GET>on</GET>
		//    <PUT>off</PUT>
		//    <HEAD>off</HEAD>
		//    <OPTIONS>off</OPTIONS>
		//    <TRACE>off</TRACE>
		//    <DELETE>off</DELETE>
		//    <CONNECT>off</CONNECT>
		//    <CustomMethods>off</CustomMethods>--
		//    <QueryString>on</QueryString>
		//    <FragmentIdentifiers>on</FragmentIdentifiers>--
		//    <DotDot>off</DotDot>--
		//    <CmdExe>off</CmdExe>
		//</AllowedFeatures>
		//<PersistentConnections>on</PersistentConnections>
		//<MaxPersistentConnectionsReuse>0</MaxPersistentConnectionsReuse>
		//<AllowCompression>off</AllowCompression>*
		//<AllowWebSocketUpgrade>off</AllowWebSocketUpgrade>
		//<WebSocketIdleTimeout>0</WebSocketIdleTimeout>
		//<MaxURLLen>16384</MaxURLLen>*
		//<MaxTotalHdrLen>128000</MaxTotalHdrLen>
		//<MaxHdrCount>0</MaxHdrCount>
		//<MaxNameHdrLen>0</MaxNameHdrLen>
		//<MaxValueHdrLen>0</MaxValueHdrLen>
		//<MaxQueryStringLen>0</MaxQueryStringLen>
		//<ACL class="AccessControlList">API-MPGW-ACL</ACL>*
		//<CredentialCharset>protocol</CredentialCharset>
		//<HTTP2MaxStreams>100</HTTP2MaxStreams>
		//<HTTP2MaxFrameSize>16384</HTTP2MaxFrameSize>
		//<HTTP2StreamHeader>off</HTTP2StreamHeader>

		//HTTPS

		//<mAdminState> enabled</mAdminState>
		//       <LocalAddress>API_PRE_DESA</LocalAddress>
		//       <LocalPort>3434</LocalPort>
		//       <HTTPVersion>HTTP/1.1</HTTPVersion>
		//       <AllowedFeatures>
		//           <HTTP-1.0>on</HTTP-1.0>
		//           <HTTP-1.1>on</HTTP-1.1>
		//           <HTTP-2.0>off</HTTP-2.0>
		//           <POST>on</POST>
		//           <GET>on</GET>
		//           <PUT>on</PUT>
		//           <HEAD>off</HEAD>
		//           <OPTIONS>on</OPTIONS>
		//           <TRACE>off</TRACE>
		//           <DELETE>on</DELETE>
		//           <CONNECT>off</CONNECT>
		//           <CustomMethods>off</CustomMethods>
		//           <QueryString>on</QueryString>
		//           <FragmentIdentifiers>on</FragmentIdentifiers>
		//           <DotDot>off</DotDot>
		//           <CmdExe>off</CmdExe>
		//       </AllowedFeatures>
		//       <PersistentConnections>on</PersistentConnections>
		//       <MaxPersistentConnectionsReuse>0</MaxPersistentConnectionsReuse>
		//       <AllowCompression>off</AllowCompression>
		//       <AllowWebSocketUpgrade>off</AllowWebSocketUpgrade>
		//       <WebSocketIdleTimeout>0</WebSocketIdleTimeout>
		//       <MaxURLLen>16384</MaxURLLen>
		//       <MaxTotalHdrLen>128000</MaxTotalHdrLen>
		//       <MaxHdrCount>0</MaxHdrCount>
		//       <MaxNameHdrLen>0</MaxNameHdrLen>
		//       <MaxValueHdrLen>0</MaxValueHdrLen>
		//       <MaxQueryStringLen>0</MaxQueryStringLen>
		//       <CredentialCharset>protocol</CredentialCharset>
		//       <SSLServerConfigType>server</SSLServerConfigType>*
		//       <SSLServer class="SSLServerProfile">API-SSLServerProfile</SSLServer>*
		//       <HTTP2MaxStreams>100</HTTP2MaxStreams>
		//       <HTTP2MaxFrameSize>16384</HTTP2MaxFrameSize>
		//       <HTTP2StreamHeader>off</HTTP2StreamHeader>

		#region Constructor
		public FrontSideHandler()
		{
		}

		public FrontSideHandler(XElement xElement, string pEnvironment, string pHost, string pDomain, string protocol)
		{
			Name = xElement.Attribute("name")?.Value;
			Class = protocol;
			AdminState = xElement.Element("mAdminState")?.Value == "enabled";
			LocalAddress = xElement.Element("LocalAddress")?.Value;
			LocalPort = Convert.ToInt32(xElement.Element("LocalPort")?.Value);
			HTTPVersion = xElement.Element("HTTPVersion")?.Value;
			AllowCompression = xElement.Element("AllowCompression")?.Value == "on";
			MaxURLLen = Convert.ToInt32(xElement.Element("MaxURLLen")?.Value);
			AccessControlList = xElement.Element("ACL")?.Value;
			SSLServerConfigType = xElement.Element("SSLServerConfigType")?.Value;
			SSLServerProfile = xElement.Element("SSLServer")?.Value;
			AllowedFeatures = xElement.Elements("AllowedFeatures").Select(features => new AllowedFeatures
			{
				Http_10 = features.Element("HTTP-1.0")?.Value == "on",
				Http_11 = features.Element("HTTP-1.1")?.Value == "on",
				Http_20 = features.Element("HTTP-2.0")?.Value == "on",
				Post = features.Element("POST")?.Value == "on",
				Get = features.Element("GET")?.Value == "on",
				Put = features.Element("PUT")?.Value == "on",
				Head = features.Element("HEAD")?.Value == "on",
				Options = features.Element("OPTIONS")?.Value == "on",
				Trace = features.Element("TRACE")?.Value == "on",
				Delete = features.Element("DELETE")?.Value == "on",
				Connect = features.Element("CONNECT")?.Value == "on",
				QueryString = features.Element("QueryString")?.Value == "on",
				CmdExe = features.Element("CmdExe")?.Value == "on",
			}).ToList();
			OpState = new OpStatus();
			Environment = pEnvironment;
			Host = pHost;
			Domain = pDomain;
			Dns = new DnsStaticHostStatus();
		}
		#endregion
	}
}
