#pragma checksum "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf6cd18ba29aaece74c0fc5c91cfb7159586ec0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FshDetails), @"mvc.1.0.view", @"/Views/Shared/_FshDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_FshDetails.cshtml", typeof(AspNetCore.Views_Shared__FshDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf6cd18ba29aaece74c0fc5c91cfb7159586ec0b", @"/Views/Shared/_FshDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea42dfc19b500a4e56bde9cf8e2567a1fb2356fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FshDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DPCoreTools.SeedWork.Models.FrontSideHandler>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/gif/loading.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 74, true);
            WriteLiteral("\r\n\r\n\r\n<header class=\"DPCore-header-main\">\r\n  <h2 style=\"padding: .5em 0;\">");
            EndContext();
            BeginContext(128, 36, false);
#line 6 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(164, 226, true);
            WriteLiteral("</h2>\r\n</header>\r\n\r\n<div data-control-container=\"Handler\">\r\n  <section class=\"DPCore-section-main\">\r\n    <div class=\"row\">\r\n      <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n          <b>Ambiente:</b>\r\n          ");
            EndContext();
            BeginContext(391, 43, false);
#line 15 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
     Write(Html.DisplayFor(model => model.Environment));

#line default
#line hidden
            EndContext();
            BeginContext(434, 130, true);
            WriteLiteral("\r\n        </div>\r\n      </div>\r\n      <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n          <b>Host:</b>\r\n          ");
            EndContext();
            BeginContext(565, 36, false);
#line 21 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
     Write(Html.DisplayFor(model => model.Host));

#line default
#line hidden
            EndContext();
            BeginContext(601, 133, true);
            WriteLiteral("\r\n        </div>\r\n      </div>\r\n      <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n          <b>Dominio:</b>\r\n          ");
            EndContext();
            BeginContext(735, 38, false);
#line 27 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
     Write(Html.DisplayFor(model => model.Domain));

#line default
#line hidden
            EndContext();
            BeginContext(773, 159, true);
            WriteLiteral("\r\n        </div>\r\n      </div>\r\n\r\n    </div>\r\n    <div class=\"row\">\r\n      <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n          <b>Status:</b>\r\n");
            EndContext();
#line 36 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
           if (Model.OpState.Status.ToLower() == "up")
          {

#line default
#line hidden
            BeginContext(1001, 72, true);
            WriteLiteral("            <i class=\"fa fa-arrow-circle-up\" style=\"color: green\"></i>\r\n");
            EndContext();
#line 39 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
          }
          else if (Model.OpState.Status.ToLower() == "down")
          {

#line default
#line hidden
            BeginContext(1161, 71, true);
            WriteLiteral("            <i class=\"fa fa-arrow-circle-down\" style=\"color:red\"></i>\r\n");
            EndContext();
#line 43 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
          }
          else
          {

#line default
#line hidden
            BeginContext(1274, 80, true);
            WriteLiteral("            <i class=\"fa fa-info-circle\" style=\"color:yellow\">No available</i>\r\n");
            EndContext();
#line 47 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
          }

#line default
#line hidden
            BeginContext(1367, 60, true);
            WriteLiteral("        </div>\r\n        <div class=\"form-group\">\r\n          ");
            EndContext();
            BeginContext(1428, 46, false);
#line 50 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
     Write(Html.DisplayFor(model => model.OpState.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1474, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 51 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
           if (Model.OpState.Status.ToLower() != "up")
          {

#line default
#line hidden
            BeginContext(1545, 130, true);
            WriteLiteral("            <i id=\"imgOpStatus\" class=\"fa fa-search-plus\" data-toggle=\"modal\" data-target=\"#dvOpStatus\" style=\"color:brown\"></i>\r\n");
            EndContext();
#line 54 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
          }

#line default
#line hidden
            BeginContext(1688, 313, true);
            WriteLiteral(@"        </div>
      </div>
    </div>
  </section>

  <section class=""DPCore-section-main"">
    <h5>General Configuration</h5>
    <div class=""row"">
      <div class=""col-md-4"">
        <div class=""form-group"">
          <b>Admin State:</b>
        </div>
        <div class=""form-group"">
          ");
            EndContext();
            BeginContext(2002, 42, false);
#line 68 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
     Write(Html.DisplayFor(model => model.AdminState));

#line default
#line hidden
            EndContext();
            BeginContext(2044, 192, true);
            WriteLiteral("\r\n        </div>\r\n      </div>\r\n      <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n          <b>Local IP address:</b>\r\n        </div>\r\n        <div class=\"form-group\">\r\n          ");
            EndContext();
            BeginContext(2237, 44, false);
#line 76 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
     Write(Html.DisplayFor(model => model.LocalAddress));

#line default
#line hidden
            EndContext();
            BeginContext(2281, 180, true);
            WriteLiteral("\r\n        </div>\r\n      </div>\r\n      <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n          <b>Port:</b>\r\n        </div>\r\n        <div class=\"form-group\">\r\n          ");
            EndContext();
            BeginContext(2462, 41, false);
#line 84 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
     Write(Html.DisplayFor(model => model.LocalPort));

#line default
#line hidden
            EndContext();
            BeginContext(2503, 233, true);
            WriteLiteral("\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <div class=\"row\">\r\n      <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n          <b>HTTP version to client:</b>\r\n        </div>\r\n        <div class=\"form-group\">\r\n          ");
            EndContext();
            BeginContext(2737, 43, false);
#line 94 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
     Write(Html.DisplayFor(model => model.HTTPVersion));

#line default
#line hidden
            EndContext();
            BeginContext(2780, 194, true);
            WriteLiteral("\r\n        </div>\r\n      </div>\r\n      <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n          <b>Enable compression:</b>\r\n        </div>\r\n        <div class=\"form-group\">\r\n          ");
            EndContext();
            BeginContext(2975, 48, false);
#line 102 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
     Write(Html.DisplayFor(model => model.AllowCompression));

#line default
#line hidden
            EndContext();
            BeginContext(3023, 194, true);
            WriteLiteral("\r\n        </div>\r\n      </div>\r\n      <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n          <b>Maximum URL length:</b>\r\n        </div>\r\n        <div class=\"form-group\">\r\n          ");
            EndContext();
            BeginContext(3218, 41, false);
#line 110 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
     Write(Html.DisplayFor(model => model.MaxURLLen));

#line default
#line hidden
            EndContext();
            BeginContext(3259, 230, true);
            WriteLiteral("\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <div class=\"row\">\r\n      <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n          <b>Access control list:</b>\r\n        </div>\r\n        <div class=\"form-group\">\r\n          ");
            EndContext();
            BeginContext(3490, 49, false);
#line 120 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
     Write(Html.DisplayFor(model => model.AccessControlList));

#line default
#line hidden
            EndContext();
            BeginContext(3539, 191, true);
            WriteLiteral("\r\n        </div>\r\n      </div>\r\n      <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n          <b>SSL server type:</b>\r\n        </div>\r\n        <div class=\"form-group\">\r\n          ");
            EndContext();
            BeginContext(3731, 51, false);
#line 128 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
     Write(Html.DisplayFor(model => model.SSLServerConfigType));

#line default
#line hidden
            EndContext();
            BeginContext(3782, 194, true);
            WriteLiteral("\r\n        </div>\r\n      </div>\r\n      <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n          <b>SSL server profile:</b>\r\n        </div>\r\n        <div class=\"form-group\">\r\n          ");
            EndContext();
            BeginContext(3977, 48, false);
#line 136 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
     Write(Html.DisplayFor(model => model.SSLServerProfile));

#line default
#line hidden
            EndContext();
            BeginContext(4025, 309, true);
            WriteLiteral(@"
        </div>
      </div>
    </div>
  </section>

  <section class=""DPCore-section-main"">
    <h5>Allowed methods and versions</h5>
    <div class=""row"">
      <div class=""col-md-4"">
        <div class=""form-group"">
          <b>HTTP 1.0:</b>
        </div>
        <div class=""form-group"">
");
            EndContext();
#line 150 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
           foreach (var item in Model.AllowedFeatures)
          {
            

#line default
#line hidden
            BeginContext(4416, 38, false);
#line 152 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
       Write(Html.DisplayFor(model => item.Http_10));

#line default
#line hidden
            EndContext();
#line 152 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
                                                   
          }

#line default
#line hidden
            BeginContext(4469, 172, true);
            WriteLiteral("        </div>\r\n      </div>\r\n      <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n          <b>HTTP 1.1:</b>\r\n        </div>\r\n        <div class=\"form-group\">\r\n");
            EndContext();
#line 161 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
           foreach (var item in Model.AllowedFeatures)
          {
            

#line default
#line hidden
            BeginContext(4723, 38, false);
#line 163 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
       Write(Html.DisplayFor(model => item.Http_10));

#line default
#line hidden
            EndContext();
#line 163 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
                                                   
          }

#line default
#line hidden
            BeginContext(4776, 170, true);
            WriteLiteral("        </div>\r\n      </div>\r\n      <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n          <b>HTTP/2:</b>\r\n        </div>\r\n        <div class=\"form-group\">\r\n");
            EndContext();
#line 172 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
           foreach (var item in Model.AllowedFeatures)
          {
            

#line default
#line hidden
            BeginContext(5028, 38, false);
#line 174 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
       Write(Html.DisplayFor(model => item.Http_20));

#line default
#line hidden
            EndContext();
#line 174 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
                                                   
          }

#line default
#line hidden
            BeginContext(5081, 212, true);
            WriteLiteral("        </div>\r\n      </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n      <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n          <b>POST method:</b>\r\n        </div>\r\n        <div class=\"form-group\">\r\n");
            EndContext();
#line 186 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
           foreach (var item in Model.AllowedFeatures)
          {
            

#line default
#line hidden
            BeginContext(5375, 35, false);
#line 188 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
       Write(Html.DisplayFor(model => item.Post));

#line default
#line hidden
            EndContext();
#line 188 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
                                                
          }

#line default
#line hidden
            BeginContext(5425, 174, true);
            WriteLiteral("        </div>\r\n      </div>\r\n      <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n          <b>GET method:</b>\r\n        </div>\r\n        <div class=\"form-group\">\r\n");
            EndContext();
#line 197 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
           foreach (var item in Model.AllowedFeatures)
          {
            

#line default
#line hidden
            BeginContext(5681, 34, false);
#line 199 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
       Write(Html.DisplayFor(model => item.Get));

#line default
#line hidden
            EndContext();
#line 199 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
                                               
          }

#line default
#line hidden
            BeginContext(5730, 174, true);
            WriteLiteral("        </div>\r\n      </div>\r\n      <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n          <b>PUT method:</b>\r\n        </div>\r\n        <div class=\"form-group\">\r\n");
            EndContext();
#line 208 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
           foreach (var item in Model.AllowedFeatures)
          {
            

#line default
#line hidden
            BeginContext(5986, 34, false);
#line 210 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
       Write(Html.DisplayFor(model => item.Put));

#line default
#line hidden
            EndContext();
#line 210 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
                                               
          }

#line default
#line hidden
            BeginContext(6035, 214, true);
            WriteLiteral("        </div>\r\n      </div>\r\n    </div>\r\n\r\n\r\n    <div class=\"row\">\r\n      <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n          <b>HEAD method:</b>\r\n        </div>\r\n        <div class=\"form-group\">\r\n");
            EndContext();
#line 223 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
           foreach (var item in Model.AllowedFeatures)
          {
            

#line default
#line hidden
            BeginContext(6331, 35, false);
#line 225 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
       Write(Html.DisplayFor(model => item.Head));

#line default
#line hidden
            EndContext();
#line 225 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
                                                
          }

#line default
#line hidden
            BeginContext(6381, 171, true);
            WriteLiteral("        </div>\r\n      </div>\r\n      <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n          <b>OPTIONS:</b>\r\n        </div>\r\n        <div class=\"form-group\">\r\n");
            EndContext();
#line 234 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
           foreach (var item in Model.AllowedFeatures)
          {
            

#line default
#line hidden
            BeginContext(6634, 38, false);
#line 236 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
       Write(Html.DisplayFor(model => item.Options));

#line default
#line hidden
            EndContext();
#line 236 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
                                                   
          }

#line default
#line hidden
            BeginContext(6687, 176, true);
            WriteLiteral("        </div>\r\n      </div>\r\n      <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n          <b>TRACE method:</b>\r\n        </div>\r\n        <div class=\"form-group\">\r\n");
            EndContext();
#line 245 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
           foreach (var item in Model.AllowedFeatures)
          {
            

#line default
#line hidden
            BeginContext(6945, 36, false);
#line 247 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
       Write(Html.DisplayFor(model => item.Trace));

#line default
#line hidden
            EndContext();
#line 247 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
                                                 
          }

#line default
#line hidden
            BeginContext(6996, 216, true);
            WriteLiteral("        </div>\r\n      </div>\r\n    </div>\r\n\r\n\r\n    <div class=\"row\">\r\n      <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n          <b>DELETE method:</b>\r\n        </div>\r\n        <div class=\"form-group\">\r\n");
            EndContext();
#line 260 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
           foreach (var item in Model.AllowedFeatures)
          {
            

#line default
#line hidden
            BeginContext(7294, 37, false);
#line 262 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
       Write(Html.DisplayFor(model => item.Delete));

#line default
#line hidden
            EndContext();
#line 262 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
                                                  
          }

#line default
#line hidden
            BeginContext(7346, 180, true);
            WriteLiteral("        </div>\r\n      </div>\r\n      <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n          <b>URL with cmd.exe:</b>\r\n        </div>\r\n        <div class=\"form-group\">\r\n");
            EndContext();
#line 271 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
           foreach (var item in Model.AllowedFeatures)
          {
            

#line default
#line hidden
            BeginContext(7608, 37, false);
#line 273 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
       Write(Html.DisplayFor(model => item.CmdExe));

#line default
#line hidden
            EndContext();
#line 273 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
                                                  
          }

#line default
#line hidden
            BeginContext(7660, 171, true);
            WriteLiteral("        </div>\r\n      </div>\r\n      <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n          <b>Connect:</b>\r\n        </div>\r\n        <div class=\"form-group\">\r\n");
            EndContext();
#line 282 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
           foreach (var item in Model.AllowedFeatures)
          {
            

#line default
#line hidden
            BeginContext(7913, 38, false);
#line 284 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
       Write(Html.DisplayFor(model => item.Connect));

#line default
#line hidden
            EndContext();
#line 284 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
                                                   
          }

#line default
#line hidden
            BeginContext(7966, 109, true);
            WriteLiteral("        </div>\r\n      </div>\r\n    </div>\r\n\r\n  </section>\r\n\r\n\r\n\r\n\r\n  <footer class=\"DPCore-footer-main\">\r\n    ");
            EndContext();
            BeginContext(8075, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "215bb10e04744ce3942d15064da7b49a", async() => {
                BeginContext(8097, 40, true);
                WriteLiteral("<i class=\"fas fa-caret-left\"></i> Volver");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8141, 116, true);
            WriteLiteral("\r\n  </footer>\r\n</div>\r\n\r\n<div id=\"dvloading\" class=\"modal-Ajax\" style=\"display: none\">\r\n  <div class=\"center\">\r\n    ");
            EndContext();
            BeginContext(8257, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a2f95fd1fab84661b16bae07a10d2447", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8302, 596, true);
            WriteLiteral(@"
  </div>
</div>

<div class=""modal fade"" id=""dvOpStatus"" tabindex=""-1"" role=""dialog"" aria-labelledby=""lblOpStatus"" aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h4 class=""modal-title"" id=""lblOpStatus""><i class=""fa fa-info-circle"" style=""color: orangered""></i> - Detalle Estado:</h4>
        <button type=""button"" class=""close"" data-dismiss=""modal"" data-backdrop=""false"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
      </div>
      <div class=""modal-body"">
        ");
            EndContext();
            BeginContext(8899, 69, false);
#line 314 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Shared\_FshDetails.cshtml"
   Write(HtmlHelperPartialExtensions.Partial(Html, "_OpStatus", Model.OpState));

#line default
#line hidden
            EndContext();
            BeginContext(8968, 292, true);
            WriteLiteral(@"
      </div>
      <div class=""modal-footer"">
        <button type=""button"" id=""btnCloseModal"" class=""btn btn-secondary"" data-backdrop=""false"" data-dismiss=""modal"">Cerrar</button>
      </div>
    </div><!-- /.modal-content -->
  </div><!-- /.modal-dialog -->
</div><!-- /.modal -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DPCoreTools.SeedWork.Models.FrontSideHandler> Html { get; private set; }
    }
}
#pragma warning restore 1591