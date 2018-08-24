using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace DPCoreTools.SeedWork.Models
{
  public class MultiProtocolGateway : DataPower
  {
    public string Name { get; set; }
    public bool AdminState { get; set; }
    public string Summary { get; set; }
    public string Priority { get; set; }
    public int TransactionTimeout { get; set; }
    public string BackHttpVersion { get; set; }
    public string SslClientConfigType { get; set; }
    public string SslClient { get; set; }
    public string StylePolicy { get; set; }
    public string PolicyAttachments { get; set; }
    public string RequestType { get; set; }
    public string ResponseType { get; set; }
    public List<FrontSideHandler> FrontProtocol { get; set; }
    public string AllowCompression { get; set; }
    public string XmlManager { get; set; }
    public int FrontTimeout { get; set; }
    public int BackTimeout { get; set; }
    public int FrontPersistentTimeout { get; set; }
    public int BackPersistentTimeout { get; set; }
    public string BackendUrl { get; set; }
    public string Probe { get; set; }
    public string ProbeHistory { get; set; }
    public OpStatus OpState { get; set; }
    

    #region Properties
    #region Mapped
    /*
					<mAdminState>enabled</mAdminState>
					<Priority>normal</Priority>
					<TransactionTimeout>0</TransactionTimeout>
					<BackHTTPVersion>HTTP/1.1</BackHTTPVersion>
					<SSLClientConfigType>proxy</SSLClientConfigType>
					<StylePolicy class="StylePolicy">API-DummyCache-Proxy-MPGW</StylePolicy>
					<PolicyAttachments class="PolicyAttachments">API-DummyCache-MPGW</PolicyAttachments>
					<RequestType>preprocessed</RequestType>
					<ResponseType>preprocessed</ResponseType>
					<FrontProtocol class="HTTPSourceProtocolHandler">API-DummyCache-FSH-MPGW</FrontProtocol>
					<AllowCompression>off</AllowCompression>
					<XMLManager class="XMLManager">Balancer-XMLManager</XMLManager>
					<FrontTimeout>120</FrontTimeout>
					<BackTimeout>120</BackTimeout>
					<FrontPersistentTimeout>180</FrontPersistentTimeout>
					<BackPersistentTimeout>180</BackPersistentTimeout>
					<DebugMode persisted="false">off</DebugMode>
					<DebugHistory>25</DebugHistory>
		*/
    #endregion
    /*
					<Type>dynamic-backend</Type>
					<DefaultParamNamespace>http://www.datapower.com/param/config</DefaultParamNamespace>
					<QueryParamNamespace>http://www.datapower.com/param/query</QueryParamNamespace>
					<PropagateURI>on</PropagateURI>
					<MonitorProcessingPolicy>terminate-at-first-throttle</MonitorProcessingPolicy>
					<RequestAttachments>strip</RequestAttachments>
					<ResponseAttachments>strip</ResponseAttachments>
					<RequestAttachmentsFlowControl>off</RequestAttachmentsFlowControl>
					<ResponseAttachmentsFlowControl>off</ResponseAttachmentsFlowControl>
					<RootPartNotFirstAction>process-in-order</RootPartNotFirstAction>
					<FrontAttachmentFormat>dynamic</FrontAttachmentFormat>
					<BackAttachmentFormat>dynamic</BackAttachmentFormat>
					<MIMEFrontHeaders>on</MIMEFrontHeaders>
					<MIMEBackHeaders>on</MIMEBackHeaders>
					<StreamOutputToBack>buffer-until-verification</StreamOutputToBack>
					<StreamOutputToFront>buffer-until-verification</StreamOutputToFront>
					<MaxMessageSize>0</MaxMessageSize>
					<GatewayParserLimits>off</GatewayParserLimits>
					<ParserLimitsElementDepth>512</ParserLimitsElementDepth>
					<ParserLimitsAttributeCount>128</ParserLimitsAttributeCount>
					<ParserLimitsMaxNodeSize>33554432</ParserLimitsMaxNodeSize>
					<ParserLimitsForbidExternalReferences>on</ParserLimitsForbidExternalReferences>
					<ParserLimitsExternalReferences>forbid</ParserLimitsExternalReferences>
					<ParserLimitsMaxPrefixes>1024</ParserLimitsMaxPrefixes>
					<ParserLimitsMaxNamespaces>1024</ParserLimitsMaxNamespaces>
					<ParserLimitsMaxLocalNames>60000</ParserLimitsMaxLocalNames>
					<ParserLimitsAttachmentByteCount>2000000000</ParserLimitsAttachmentByteCount>
					<ParserLimitsAttachmentPackageByteCount>0</ParserLimitsAttachmentPackageByteCount>
					<FlowControl>off</FlowControl>
					<SOAPSchemaURL>store:///schemas/soap-envelope.xsd</SOAPSchemaURL>
					<IncludeResponseTypeEncoding>off</IncludeResponseTypeEncoding>
					<PersistentConnections>on</PersistentConnections>
					<LoopDetection>off</LoopDetection>
					<DoHostRewriting>on</DoHostRewriting>
					<DoChunkedUpload>off</DoChunkedUpload>
					<ProcessHTTPErrors>on</ProcessHTTPErrors>
					<HTTPClientIPLabel>X-Client-IP</HTTPClientIPLabel>
					<HTTPLogCorIDLabel>X-Global-Transaction-ID</HTTPLogCorIDLabel>
					<InOrderMode>
						<Request>off</Request>
						<Backend>off</Backend>
						<Response>off</Response>
					</InOrderMode>
					<WSAMode>sync2sync</WSAMode>
					<WSARequireAAA>on</WSARequireAAA>
					<WSAStrip>on</WSAStrip>
					<WSADefaultReplyTo>http://schemas.xmlsoap.org/ws/2004/08/addressing/role/anonymous</WSADefaultReplyTo>
					<WSADefaultFaultTo>http://schemas.xmlsoap.org/ws/2004/08/addressing/role/anonymous</WSADefaultFaultTo>
					<WSAForce>off</WSAForce>
					<WSAGenStyle>sync</WSAGenStyle>
					<WSAHTTPAsyncResponseCode>204</WSAHTTPAsyncResponseCode>
					<WSATimeout>120</WSATimeout>
					<WSRMEnabled>off</WSRMEnabled>
					<WSRMSequenceExpiration>3600</WSRMSequenceExpiration>
					<WSRMDestinationAcceptCreateSequence>on</WSRMDestinationAcceptCreateSequence>
					<WSRMDestinationMaximumSequences>400</WSRMDestinationMaximumSequences>
					<WSRMDestinationInOrder>off</WSRMDestinationInOrder>
					<WSRMDestinationMaximumInOrderQueueLength>10</WSRMDestinationMaximumInOrderQueueLength>
					<WSRMDestinationAcceptOffers>off</WSRMDestinationAcceptOffers>
					<WSRMFrontForce>off</WSRMFrontForce>
					<WSRMBackForce>off</WSRMBackForce>
					<WSRMBackCreateSequence>off</WSRMBackCreateSequence>
					<WSRMFrontCreateSequence>off</WSRMFrontCreateSequence>
					<WSRMSourceMakeOffer>off</WSRMSourceMakeOffer>
					<WSRMUsesSequenceSSL>off</WSRMUsesSequenceSSL>
					<WSRMSourceMaximumSequences>400</WSRMSourceMaximumSequences>
					<WSRMSourceRetransmissionInterval>10</WSRMSourceRetransmissionInterval>
					<WSRMSourceExponentialBackoff>on</WSRMSourceExponentialBackoff>
					<WSRMSourceMaximumRetransmissions>4</WSRMSourceMaximumRetransmissions>
					<WSRMSourceMaximumQueueLength>30</WSRMSourceMaximumQueueLength>
					<WSRMSourceRequestAckCount>1</WSRMSourceRequestAckCount>
					<WSRMSourceInactivityClose>360</WSRMSourceInactivityClose>
					<ForcePolicyExec>off</ForcePolicyExec>
					<RewriteErrors>on</RewriteErrors>
					<DelayErrors>on</DelayErrors>
					<DelayErrorsDuration>1000</DelayErrorsDuration>
					<FollowRedirects>on</FollowRedirects>
					<RewriteLocationHeader>off</RewriteLocationHeader>
					<AllowCacheControlHeader>off</AllowCacheControlHeader>
					<WSMAgentMonitor>off</WSMAgentMonitor>
					<WSMAgentMonitorPCM>all-messages</WSMAgentMonitorPCM>
					<ProxyHTTPResponse>off</ProxyHTTPResponse>
		 */
    #endregion

    #region Constructor
    public MultiProtocolGateway()
    {
    }

    public MultiProtocolGateway(XElement xElement, string pEnvironment, string pHost, string pDomain)
    {
      Name = xElement.Attribute("name")?.Value;
      AdminState = xElement.Element("mAdminState")?.Value == "enabled";
      Summary = xElement.Element("UserSummary")?.Value;
      Priority = xElement.Element("Priority")?.Value;
      BackHttpVersion = xElement.Element("BackHTTPVersion")?.Value;
      SslClientConfigType = xElement.Element("SSLClientConfigType")?.Value;
      SslClient = xElement.Element("SSLClient")?.Value;
      StylePolicy = xElement.Element("StylePolicy")?.Value;
      PolicyAttachments = xElement.Element("PolicyAttachments")?.Value;
      RequestType = xElement.Element("RequestType")?.Value;
      ResponseType = xElement.Element("ResponseType")?.Value;
      BackendUrl = xElement.Element("BackendUrl")?.Value;
      XmlManager = xElement.Element("XMLManager")?.Value;
      Probe = xElement.Element("DebugMode")?.Value;
      ProbeHistory = xElement.Element("DebugHistory")?.Value;
      AllowCompression = xElement.Element("AllowCompression")?.Value;
      TransactionTimeout = Convert.ToInt32(xElement.Element("TransactionTimeout")?.Value);
      FrontPersistentTimeout = Convert.ToInt32(xElement.Element("FrontPersistentTimeout")?.Value);
      FrontTimeout = Convert.ToInt32(xElement.Element("FrontTimeout")?.Value);
      BackTimeout = Convert.ToInt32(xElement.Element("BackTimeout")?.Value);
      BackPersistentTimeout = Convert.ToInt32(xElement.Element("BackPersistentTimeout")?.Value);
      FrontProtocol = xElement.Elements("FrontProtocol").Select(phn => new FrontSideHandler
      {
        Class = phn.Attribute("class")?.Value,
        Name = phn.Value,
        Environment = pEnvironment,
        Host = pHost,
        Domain = pDomain
        
    }).ToList();
      OpState = new OpStatus();
      Environment = pEnvironment;
      Host = pHost;
      Domain = pDomain;
    }
    #endregion
  }
}
