#pragma checksum "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_LocalAddressIP.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4703f757fbcf331be10bd90b0a2574c0dc91caf3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LocalAddressIP), @"mvc.1.0.view", @"/Views/Shared/_LocalAddressIP.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_LocalAddressIP.cshtml", typeof(AspNetCore.Views_Shared__LocalAddressIP))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\_ViewImports.cshtml"
using DPCoreTools;

#line default
#line hidden
#line 2 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\_ViewImports.cshtml"
using DPCoreTools.Models;

#line default
#line hidden
#line 1 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_LocalAddressIP.cshtml"
using DPCoreTools.SeedWork.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4703f757fbcf331be10bd90b0a2574c0dc91caf3", @"/Views/Shared/_LocalAddressIP.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea42dfc19b500a4e56bde9cf8e2567a1fb2356fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LocalAddressIP : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DnsStaticHostStatus>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 131, true);
            WriteLiteral("<div class=\"row\">\r\n\t<div class=\"col-md-6\">\r\n\t\t<div class=\"form-group\">\r\n\t\t\t<b>Alias:</b>\r\n\t\t</div>\r\n\t\t<div class=\"form-group\">\r\n\t\t\t");
            EndContext();
            BeginContext(196, 37, false);
#line 9 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_LocalAddressIP.cshtml"
       Write(Html.DisplayFor(model => model.Alias));

#line default
#line hidden
            EndContext();
            BeginContext(233, 138, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"col-md-6\">\r\n\t\t<div class=\"form-group\">\r\n\t\t\t<b>IP Address:</b>\r\n\t\t</div>\r\n\t\t<div class=\"form-group\">\r\n\t\t\t");
            EndContext();
            BeginContext(372, 34, false);
#line 17 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_LocalAddressIP.cshtml"
       Write(Html.DisplayFor(model => model.Ip));

#line default
#line hidden
            EndContext();
            BeginContext(406, 27, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DnsStaticHostStatus> Html { get; private set; }
    }
}
#pragma warning restore 1591
