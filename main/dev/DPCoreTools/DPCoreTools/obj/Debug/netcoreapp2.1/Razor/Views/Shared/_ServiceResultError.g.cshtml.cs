#pragma checksum "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_ServiceResultError.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6f2920724ddb0e182942e18b8e1bf7f67712356"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ServiceResultError), @"mvc.1.0.view", @"/Views/Shared/_ServiceResultError.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ServiceResultError.cshtml", typeof(AspNetCore.Views_Shared__ServiceResultError))]
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
#line 1 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_ServiceResultError.cshtml"
using DPCoreTools.SeedWork.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6f2920724ddb0e182942e18b8e1bf7f67712356", @"/Views/Shared/_ServiceResultError.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea42dfc19b500a4e56bde9cf8e2567a1fb2356fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ServiceResultError : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServiceResponse>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(62, 28, true);
            WriteLiteral("\r\n<div class=\"col-md-12\">\r\n\t");
            EndContext();
            BeginContext(91, 12, false);
#line 6 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_ServiceResultError.cshtml"
Write(Model.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(103, 55, true);
            WriteLiteral("\r\n</div>\r\n<div id=\"dvMessage\" class=\"alert-warning\">\r\n\t");
            EndContext();
            BeginContext(159, 13, false);
#line 9 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_ServiceResultError.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(172, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591