#pragma checksum "E:\Works\ATOS\Projects\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Troubleshooting\GetPing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee98feceb5b28e1dfa4f92a6a652a7ca9ca035dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Troubleshooting_GetPing), @"mvc.1.0.view", @"/Views/Troubleshooting/GetPing.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Troubleshooting/GetPing.cshtml", typeof(AspNetCore.Views_Troubleshooting_GetPing))]
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
#line 1 "E:\Works\ATOS\Projects\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\_ViewImports.cshtml"
using DPCoreTools;

#line default
#line hidden
#line 2 "E:\Works\ATOS\Projects\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\_ViewImports.cshtml"
using DPCoreTools.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee98feceb5b28e1dfa4f92a6a652a7ca9ca035dc", @"/Views/Troubleshooting/GetPing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea42dfc19b500a4e56bde9cf8e2567a1fb2356fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Troubleshooting_GetPing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/gif/loading.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\Works\ATOS\Projects\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Troubleshooting\GetPing.cshtml"
  
	ViewData["Title"] = "Realizar Ping";

#line default
#line hidden
            BeginContext(46, 28, true);
            WriteLiteral("\r\n<h2>Realizar Ping</h2>\r\n\r\n");
            EndContext();
            BeginContext(75, 56, false);
#line 7 "E:\Works\ATOS\Projects\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Troubleshooting\GetPing.cshtml"
Write(HtmlHelperPartialExtensions.Partial(Html, "_DPComplete"));

#line default
#line hidden
            EndContext();
            BeginContext(131, 491, true);
            WriteLiteral(@"
<div class=""row"">
	<div class=""col-md-6"">
		<div class=""form-group"">
			<label class=""control-label"">Destino</label>
			<input type=""text"" id=""Uri"" class=""form-control"" placeholder=""Ej: salesforce.com"" />
		</div>
	</div>
</div>
<div class=""row"">
	<div class=""col-md-6"">
		<div class=""form-group"" id=""dvResult"">
			<label id=""resultCommand"" class=""alert"" role=""alert""></label>
		</div>
	</div>
</div>
<div class=""modal-Ajax"" style=""display: none"">
	<div class=""center"">
		");
            EndContext();
            BeginContext(622, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "36f48ca1cfc84b20bb538adf7f63cc71", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(666, 57, true);
            WriteLiteral("\r\n\t</div>\r\n</div>\r\n<footer class=\"DPCore-footer-main\">\r\n\t");
            EndContext();
            BeginContext(723, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "948b71db1ee84aad9759103752ccf423", async() => {
                BeginContext(767, 40, true);
                WriteLiteral("<i class=\"fas fa-caret-left\"></i> Volver");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(811, 158, true);
            WriteLiteral("\r\n\t<button id=\"btnSave\" class=\"DPCore-button\" style=\"position: absolute; right: 1em; top: -5px;\"><i class=\"fas fa-check\"></i> Ejecutar</button>\r\n</footer>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(987, 383, true);
                WriteLiteral(@"
	<script>
		(function() {
			var $container = {
				btnConfirm: $('#btnSave'), section: {
					btnNew: $('.btnAddItem', '[data-control-container]')
				}
			}

			var sel1 = $('#drpEnvironments'), sel2 = $('#drpHosts'), sel3 = $('#drpDomains');
			sel1.on('change', function() {
				var valSelected = $(this).find('option:selected').text();
				var ajax = {
					url: '");
                EndContext();
                BeginContext(1371, 34, false);
#line 46 "E:\Works\ATOS\Projects\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Troubleshooting\GetPing.cshtml"
                     Write(Url.Action("GetHostsList", "Base"));

#line default
#line hidden
                EndContext();
                BeginContext(1405, 821, true);
                WriteLiteral(@"',
					data: { pEnvironment: valSelected }
				}
				$.ajax({
					url: ajax.url,
					type: ""POST"",
					data: ajax.data,
					dataType: ""json"",
					success: function(result) {
						sel2.empty();
						sel3.empty();
						$.each(result, function(i, v) {
							sel2.append($('<option />', {
								value: i,
								text: v
							}));
						});
					},
					error: function(xhr, ajaxOptions, thrownError) {
						console.log('ERR', xhr.status, thrownError);
						ALERT.SHOW_ERROR(PROP.MGE.ERROR_COMMAND_FAIL);
					},
					complete: function() {
					}
				});
			});

			sel2.on('change', function() {
				var dp = {
					Environment: $('#drpEnvironments').find('option:selected').text(),
					Host: $('#drpHosts').find('option:selected').text()
				}
				var ajax = {
					url: '");
                EndContext();
                BeginContext(2227, 34, false);
#line 79 "E:\Works\ATOS\Projects\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Troubleshooting\GetPing.cshtml"
                     Write(Url.Action("GetDomains", "Domain"));

#line default
#line hidden
                EndContext();
                BeginContext(2261, 1203, true);
                WriteLiteral(@"',
					data: { model: dp },
					beforeSend: function () {
						$("".modal-Ajax"").show();
					}
				}
				$.ajax({
					url: ajax.url,
					type: ""POST"",
					data: ajax.data,
					dataType: ""json"",
					success: function(result) {
						sel3.empty();
						$.each(result.entity, function(i, v) {
							sel3.append($('<option />', {
								value: i,
								text: v.name
							}));
						});
					},
					error: function(xhr, ajaxOptions, thrownError) {
						console.log('ERR', xhr.status, thrownError);
						ALERT.SHOW_ERROR(PROP.MGE.ERROR_COMMAND_FAIL);
					},
					complete: function() {
						$("".modal-Ajax"").hide();
					}
				});
			});

			function executePing() {
				var model = {
					Environment: $('#drpEnvironments').find('option:selected').text(),
					Host: $('#drpHosts').find('option:selected').text(),
					Domain: $('#drpDomains').find('option:selected').text(),
					Uri: $('#Uri').val()
				}
				if (!model.Environment.trim() || !model.Host.trim() || !mode");
                WriteLiteral("l.Domain.trim() || !model.Uri.trim()) {\r\n\t\t\t\t\tALERT.SHOW_WARNING(PROP.MGE.ERROR_REQUIRED, 2000);\r\n\t\t\t\t\treturn;\r\n\t\t\t\t}\r\n\t\t\t\t$(\'#resultCommand\').html(\'\');\r\n\t\t\t\t$.ajax({\r\n\t\t\t\t\turl: \'");
                EndContext();
                BeginContext(3465, 40, false);
#line 122 "E:\Works\ATOS\Projects\dtp_dpcoretools-apl_datapower\main\dev\DPCoreTools\DPCoreTools\Views\Troubleshooting\GetPing.cshtml"
                     Write(Url.Action("GetPing", "Troubleshooting"));

#line default
#line hidden
                EndContext();
                BeginContext(3505, 877, true);
                WriteLiteral(@"',
					type: ""POST"",
					data: model,
					beforeSend: function () {
						$("".modal-Ajax"").show();
					},
					dataType: ""json"",
					success: function (resu) {
						if (resu.code == 0) {
							$('#resultCommand').removeClass(""alert-danger"");
							$('#resultCommand').addClass(""alert-success"");
						} else {
							$('#resultCommand').removeClass(""alert-success"");
							$('#resultCommand').addClass(""alert-danger"");
						}
						$('#resultCommand').html(resu.message);
					},
					error: function(xhr, ajaxOptions, thrownError) {
						console.log('ERR', xhr.status, thrownError);
						ALERT.SHOW_ERROR(PROP.MGE.ERROR_COMMAND_FAIL);
					},
					complete: function() {
						$("".modal-Ajax"").hide();
					}
				});
			};

			window.onload = function() {
				$container.btnConfirm.on('click', executePing);
			}
		})();
	</script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
