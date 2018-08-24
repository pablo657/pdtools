using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace DPCoreTools.SeedWork.Models
{
    public class AllowedFeatures : DataPower
    {
    public bool Http_10 { get; set; }
    public bool Http_11 { get; set; }
    public bool Http_20 { get; set; }
    public bool Post { get; set; }
    public bool Get { get; set; }
    public bool Put { get; set; }
    public bool Head { get; set; }
    public bool Options { get; set; }
    public bool Trace { get; set; }
    public bool Delete { get; set; }
    public bool Connect { get; set; }
    public bool CmdExe { get; set; }
    public bool QueryString { get; set; }



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


    #region Constructor
    public AllowedFeatures()
    {
    }

    #endregion
  }
}
