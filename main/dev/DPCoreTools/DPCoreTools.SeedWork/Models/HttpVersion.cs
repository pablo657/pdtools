using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace DPCoreTools.SeedWork.Models
{
  public class HttpVersion : DataPower
  {
    public string Front { get; set; }
    public string Back { get; set; }

    #region Constructor
    public HttpVersion()
    {
    }

    #endregion

    //<HTTPVersion>*
    //  <Front>HTTP/1.1</Front>*
    //  <Back>HTTP/1.1</Back>*
    //</HTTPVersion>
  }
}
