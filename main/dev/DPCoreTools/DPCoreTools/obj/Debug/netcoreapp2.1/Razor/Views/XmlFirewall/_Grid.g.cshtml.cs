#pragma checksum "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\XmlFirewall\_Grid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94a87de87574c7bf2d144049b296b74ccf121f7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_XmlFirewall__Grid), @"mvc.1.0.view", @"/Views/XmlFirewall/_Grid.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/XmlFirewall/_Grid.cshtml", typeof(AspNetCore.Views_XmlFirewall__Grid))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94a87de87574c7bf2d144049b296b74ccf121f7e", @"/Views/XmlFirewall/_Grid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea42dfc19b500a4e56bde9cf8e2567a1fb2356fc", @"/Views/_ViewImports.cshtml")]
    public class Views_XmlFirewall__Grid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DPCoreTools.SeedWork.Models.XmlFirewall>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "XmlFirewall", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 198, true);
            WriteLiteral("<style>\r\n\tul {\r\n\t\tmargin: 0;\r\n\t\tpadding: 0;\r\n\t\tlist-style: none;\r\n\t}\r\n\r\n\t.no-data {\r\n\t\tcolor: rgba(128,128,128,1);\r\n\t\tfont-size: .9em;\r\n\t}\r\n</style>\r\n<div style=\"width: 100%; position: relative;\">\r\n");
            EndContext();
#line 15 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\XmlFirewall\_Grid.cshtml"
     if (Model.Any())
	{

#line default
#line hidden
            BeginContext(276, 157, true);
            WriteLiteral("\t\t<div style=\"position: relative; height: 2.5em; font-size: .9em;\">\r\n\t\t\t<span style=\"position: absolute; right: 1em; top: 5px;\">\r\n\t\t\t\t<small>Total : <strong>");
            EndContext();
            BeginContext(434, 11, false);
#line 19 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\XmlFirewall\_Grid.cshtml"
                                  Write(Model.Count);

#line default
#line hidden
            EndContext();
            BeginContext(445, 430, true);
            WriteLiteral(@"</strong></small>
			</span>
		</div>
		<table class=""DPCore-table"">
			<thead>
				<tr>
					<th>
						Name
					</th>
					<th>
						Op-State
					</th>
					<th>
						Request-Type
					</th>
					<th>
						Local Address
					</th>
					<th>
						Port
					</th>
					<th>
						Response-Type
					</th>
					<th>
						Probe
					</th>
					<th>Actions</th>
				</tr>
			</thead>
			<tbody>
");
            EndContext();
#line 50 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\XmlFirewall\_Grid.cshtml"
                 foreach (var item in Model)
				{

#line default
#line hidden
            BeginContext(916, 30, true);
            WriteLiteral("\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(947, 39, false);
#line 54 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\XmlFirewall\_Grid.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(986, 27, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td>\r\n");
            EndContext();
#line 57 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\XmlFirewall\_Grid.cshtml"
                             if (item.OpState.Status.ToLower() == "up")
							{

#line default
#line hidden
            BeginContext(1075, 68, true);
            WriteLiteral("\t\t\t\t\t\t\t\t<i class=\"fa fa-arrow-circle-up\" style=\"color: green\"></i>\r\n");
            EndContext();
#line 60 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\XmlFirewall\_Grid.cshtml"
							}
							else if (item.OpState.Status.ToLower() == "down")
							{

#line default
#line hidden
            BeginContext(1221, 67, true);
            WriteLiteral("\t\t\t\t\t\t\t\t<i class=\"fa fa-arrow-circle-down\" style=\"color:red\"></i>\r\n");
            EndContext();
#line 64 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\XmlFirewall\_Grid.cshtml"
							}
							else
							{

#line default
#line hidden
            BeginContext(1321, 76, true);
            WriteLiteral("\t\t\t\t\t\t\t\t<i class=\"fa fa-info-circle\" style=\"color:yellow\">No available</i>\r\n");
            EndContext();
#line 68 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\XmlFirewall\_Grid.cshtml"
							}

#line default
#line hidden
            BeginContext(1407, 32, true);
            WriteLiteral("\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1440, 46, false);
#line 71 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\XmlFirewall\_Grid.cshtml"
                       Write(Html.DisplayFor(modelItem => item.RequestType));

#line default
#line hidden
            EndContext();
            BeginContext(1486, 34, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1521, 47, false);
#line 74 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\XmlFirewall\_Grid.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LocalAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1568, 34, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1603, 44, false);
#line 77 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\XmlFirewall\_Grid.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LocalPort));

#line default
#line hidden
            EndContext();
            BeginContext(1647, 34, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1682, 47, false);
#line 80 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\XmlFirewall\_Grid.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ResponseType));

#line default
#line hidden
            EndContext();
            BeginContext(1729, 45, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td class=\"td-action\">\r\n");
            EndContext();
#line 83 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\XmlFirewall\_Grid.cshtml"
                             if (item.Probe == "off")
							{
								

#line default
#line hidden
            BeginContext(2033, 42, true);
            WriteLiteral("\t\t\t\t\t\t\t\t<i class=\"fa fa-toggle-off\"></i>\r\n");
            EndContext();
#line 87 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\XmlFirewall\_Grid.cshtml"
                                        
							}
							else
							{
								

#line default
#line hidden
            BeginContext(2342, 60, true);
            WriteLiteral("\t\t\t\t\t\t\t\t<i class=\"fa fa-toggle-on\" style=\"color:green\"></i> ");
            EndContext();
            BeginContext(2403, 40, false);
#line 92 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\XmlFirewall\_Grid.cshtml"
                                                                               Write(Html.DisplayFor(modelItem => item.Probe));

#line default
#line hidden
            EndContext();
#line 93 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\XmlFirewall\_Grid.cshtml"
                                        
							}

#line default
#line hidden
            BeginContext(2473, 50, true);
            WriteLiteral("\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td class=\"td-action\">\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(2523, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba59bc12d36d4718a52e0cb9db1240a3", async() => {
                BeginContext(2704, 29, true);
                WriteLiteral("<i class=\"fas fa-search\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 97 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\XmlFirewall\_Grid.cshtml"
                                                                                   WriteLiteral(item.Name);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 97 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\XmlFirewall\_Grid.cshtml"
                                                                                                                      WriteLiteral(item.Environment);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Environment"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Environment", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Environment"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 97 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\XmlFirewall\_Grid.cshtml"
                                                                                                                                                         WriteLiteral(item.Host);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Host"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Host", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Host"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 97 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\XmlFirewall\_Grid.cshtml"
                                                                                                                                                                                       WriteLiteral(item.Domain);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Domain"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Domain", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Domain"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2737, 27, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n");
            EndContext();
#line 100 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\XmlFirewall\_Grid.cshtml"
				}

#line default
#line hidden
            BeginContext(2771, 25, true);
            WriteLiteral("\t\t\t</tbody>\r\n\t\t</table>\r\n");
            EndContext();
#line 103 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\XmlFirewall\_Grid.cshtml"
	}
	else
	{

#line default
#line hidden
            BeginContext(2811, 107, true);
            WriteLiteral("\t\t<p class=\"no-data\" style=\"margin: 0; padding: 1em;\">No existen registros en el dominio seleccionado</p>\r\n");
            EndContext();
#line 107 "C:\PABLO\VisualStudio2017\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\XmlFirewall\_Grid.cshtml"
	}

#line default
#line hidden
            BeginContext(2922, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DPCoreTools.SeedWork.Models.XmlFirewall>> Html { get; private set; }
    }
}
#pragma warning restore 1591
