#pragma checksum "E:\Work\Github\Tugas_Akhir_MCC\CoreFEDesign-V2\Client\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "434786f6dbbeacf1c09814a168b5ea53fcb94820"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "E:\Work\Github\Tugas_Akhir_MCC\CoreFEDesign-V2\Client\Views\_ViewImports.cshtml"
using Client;

#line default
#line hidden
#line 2 "E:\Work\Github\Tugas_Akhir_MCC\CoreFEDesign-V2\Client\Views\_ViewImports.cshtml"
using Client.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"434786f6dbbeacf1c09814a168b5ea53fcb94820", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Scripts/HomeScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\Work\Github\Tugas_Akhir_MCC\CoreFEDesign-V2\Client\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/Layout/_Layout.cshtml";

#line default
#line hidden
            BeginContext(94, 56, true);
            WriteLiteral("\r\n<div class=\"page-header\">\r\n    <h4 class=\"page-title\">");
            EndContext();
            BeginContext(151, 17, false);
#line 8 "E:\Work\Github\Tugas_Akhir_MCC\CoreFEDesign-V2\Client\Views\Home\Index.cshtml"
                      Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(168, 3290, true);
            WriteLiteral(@"</h4>
</div>
<div class=""row"">
    <div class=""col-sm-6 col-md-3"">
        <div class=""card card-stats card-round"">
            <div class=""card-body "">
                <div class=""row align-items-center"">
                    <div class=""col-icon"">
                        <div class=""icon-big text-center icon-primary bubble-shadow-small"">
                            <i class=""fas fa-users""></i>
                        </div>
                    </div>
                    <div class=""col col-stats ml-3 ml-sm-0"">
                        <div class=""numbers"">
                            <p class=""card-category"">Visitors</p>
                            <h4 class=""card-title"">1,294</h4>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-sm-6 col-md-3"">
        <div class=""card card-stats card-round"">
            <div class=""card-body"">
                <div class=""row align-items-center"">
       ");
            WriteLiteral(@"             <div class=""col-icon"">
                        <div class=""icon-big text-center icon-info bubble-shadow-small"">
                            <i class=""far fa-newspaper""></i>
                        </div>
                    </div>
                    <div class=""col col-stats ml-3 ml-sm-0"">
                        <div class=""numbers"">
                            <p class=""card-category"">Subscribers</p>
                            <h4 class=""card-title"">1303</h4>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-sm-6 col-md-3"">
        <div class=""card card-stats card-round"">
            <div class=""card-body"">
                <div class=""row align-items-center"">
                    <div class=""col-icon"">
                        <div class=""icon-big text-center icon-success bubble-shadow-small"">
                            <i class=""far fa-chart-bar""></i>
                        <");
            WriteLiteral(@"/div>
                    </div>
                    <div class=""col col-stats ml-3 ml-sm-0"">
                        <div class=""numbers"">
                            <p class=""card-category"">Sales</p>
                            <h4 class=""card-title"">$ 1,345</h4>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-sm-6 col-md-3"">
        <div class=""card card-stats card-round"">
            <div class=""card-body"">
                <div class=""row align-items-center"">
                    <div class=""col-icon"">
                        <div class=""icon-big text-center icon-secondary bubble-shadow-small"">
                            <i class=""far fa-check-circle""></i>
                        </div>
                    </div>
                    <div class=""col col-stats ml-3 ml-sm-0"">
                        <div class=""numbers"">
                            <p class=""card-category"">Order</p>
    ");
            WriteLiteral("                        <h4 class=\"card-title\">576</h4>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n");
            EndContext();
            BeginContext(4872, 1486, true);
            WriteLiteral(@"
    <div class=""col-lg-12"">
        <div class=""card"">
            <div class=""card-header"">
                <div class=""card-head-row"">
                    <div class=""card-title"">Jumlah Mobil yang telah dipinjam</div>
                    <div class=""card-tools"">
                        <button class=""btn btn-info btn-border btn-round btn-sm mr-2"" onclick=""exportXLS();"">
                            <span class=""btn-label"">
                                <i class=""fa fa-pencil-alt""></i>
                            </span>
                            XLSX
                        </button>
                        <button class=""btn btn-info btn-border btn-round btn-sm mr-2"" onclick=""exportPDF();"">
                            <span class=""btn-label"">
                                <i class=""fa fa-print""></i>
                            </span>
                            PDF
                        </button>
                    </div>
                </div>
            </div>
           ");
            WriteLiteral(@" <div class=""card-body"">
                <div class=""amChart"" id=""pieChart""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-12"">
        <div class=""card"">
            <div class=""card-header"">
                <div class=""card-title"">Car Used</div>
            </div>
            <div class=""card-body"">
                <div class=""amChart"" id=""lineChart""></div>
            </div>
        </div>
    </div>

</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6375, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(6381, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0281604b2bc4cf4ae158112ad32e7f0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6431, 2, true);
                WriteLiteral("\r\n");
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
