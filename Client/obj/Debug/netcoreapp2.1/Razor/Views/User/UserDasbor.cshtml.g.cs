#pragma checksum "D:\MII\MCCOC\#9-Last_Project\CoreFEDesign\Client\Views\User\UserDasbor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfe5bd4ed37eb30bba0137230c3a95c71073ae39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserDasbor), @"mvc.1.0.view", @"/Views/User/UserDasbor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/UserDasbor.cshtml", typeof(AspNetCore.Views_User_UserDasbor))]
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
#line 1 "D:\MII\MCCOC\#9-Last_Project\CoreFEDesign\Client\Views\_ViewImports.cshtml"
using Client;

#line default
#line hidden
#line 2 "D:\MII\MCCOC\#9-Last_Project\CoreFEDesign\Client\Views\_ViewImports.cshtml"
using Client.Models;

#line default
#line hidden
#line 1 "D:\MII\MCCOC\#9-Last_Project\CoreFEDesign\Client\Views\User\UserDasbor.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfe5bd4ed37eb30bba0137230c3a95c71073ae39", @"/Views/User/UserDasbor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    public class Views_User_UserDasbor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Sudah", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Belum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Scripts/UserScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\MII\MCCOC\#9-Last_Project\CoreFEDesign\Client\Views\User\UserDasbor.cshtml"
  
    ViewData["Title"] = "Reserve";
    Layout = "~/Views/Layout/_Layout.cshtml";

#line default
#line hidden
            BeginContext(124, 56, true);
            WriteLiteral("\r\n<div class=\"page-header\">\r\n    <h4 class=\"page-title\">");
            EndContext();
            BeginContext(181, 17, false);
#line 8 "D:\MII\MCCOC\#9-Last_Project\CoreFEDesign\Client\Views\User\UserDasbor.cshtml"
                      Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(198, 2123, true);
            WriteLiteral(@"</h4>
    <ul class=""breadcrumbs"">
        <li class=""nav-home"">
            <a href=""/home"">
                <i class=""flaticon-home""></i>
            </a>
        </li>
        <li class=""separator"">
            <i class=""flaticon-right-arrow""></i>
        </li>
        <li class=""nav-item"">
            <a href=""#"">Reserve</a>
        </li>
        <li class=""separator"">
            <i class=""flaticon-right-arrow""></i>
        </li>
        <li class=""nav-item"">
            <a href=""#"">List</a>
        </li>
    </ul>
</div>
<div class=""row"">

    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-header"">
                <div class=""d-flex flex-row align-content-between justify-content-between"">
                    <h4 class=""card-title"">Add Row</h4>
                    <div data-toggle=""modal"" data-target=""#myModal"" onclick=""ClearScreen();"">
                        <button class=""btn btn-secondary btn-border btn-round"" data-toggle=""tooltip"" data-pl");
            WriteLiteral(@"acement=""top"" data-animation=""false"" title=""Add"">
                            <i class=""fa fa-plus""></i>
                        </button>
                    </div>
                </div>
            </div>
            <div class=""card-body"">
                <!-- Modal -->
                <div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
                    <div class=""modal-dialog modal-lg"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myLargeModalLabel"" aria-hidden=""true"">
                        <div class=""modal-content"">
                            <div class=""modal-header no-bd"">
                                <h5 class=""modal-title""><span class=""fw-mediumbold"">Form Data</span></h5>
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                    <span aria-hidden=""true"">&times;</span>
                                </button>
                            </div>
           ");
            WriteLiteral("                 <div class=\"modal-body\">\r\n                                ");
            EndContext();
            BeginContext(2321, 3731, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84c519e21d1c44698ed1a36f0324a1a8", async() => {
                BeginContext(2327, 3262, true);
                WriteLiteral(@"
                                    <div class=""row"">
                                        <div class=""col-lg-12"">
                                            <div class=""form-group"">
                                                <input type=""text"" id=""UserID"" name=""UserID"" class=""form-control"" hidden>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-sm-4"">
                                            <div class=""form-group form-group-default"">
                                                <label>Start Date</label>
                                                <input type=""date"" id=""Start"" name=""Start"" class=""form-control"">
                                            </div>
                                        </div>

                                        <div class=""col-lg-4"" id=""");
                WriteLiteral(@"endCol"">
                                            <div class=""form-group form-group-default"">
                                                <label>End Date</label>
                                                <input type=""date"" id=""End"" name=""End"" class=""form-control"">
                                            </div>
                                        </div>
                                        <div class=""col-sm-4"" id=""carCol"">
                                            <div class=""form-group form-group-default"">
                                                <label>Car</label>
                                                <select class=""form-control"" id=""CarOption"" name=""CarOption""></select>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-sm-4"" id=""totalCol"">
            ");
                WriteLiteral(@"                                <div class=""form-group"">
                                                <label>Total</label>
                                                <input type=""number"" id=""Total"" name=""Total"" class=""form-control"" placeholder=""Total"" readonly>
                                            </div>
                                        </div>
                                        <div class=""col-lg-4"" id=""bayarCol"">
                                            <div class=""form-group form-group-default"">
                                                <label>Tanggal Bayar</label>
                                                <input type=""date"" id=""Bayar"" name=""Bayar"" class=""form-control"">
                                            </div>
                                        </div>
                                        <div class=""col-sm-4"" id=""statusCol"">
                                            <div class=""form-group form-group-default"">
                        ");
                WriteLiteral("                        <label>Status</label>\r\n                                                <select class=\"form-control\" id=\"Status\">\r\n                                                    ");
                EndContext();
                BeginContext(5589, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1f68d7e49a0448184c9afe82dd76ea8", async() => {
                    BeginContext(5606, 13, true);
                    WriteLiteral("Select Status");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5628, 54, true);
                WriteLiteral("\r\n                                                    ");
                EndContext();
                BeginContext(5682, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d8e9531f867447eb36eb3175370c430", async() => {
                    BeginContext(5704, 5, true);
                    WriteLiteral("Sudah");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5718, 54, true);
                WriteLiteral("\r\n                                                    ");
                EndContext();
                BeginContext(5772, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad207c67a41a4151bf23908aab3b271e", async() => {
                    BeginContext(5794, 5, true);
                    WriteLiteral("Belum");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5808, 237, true);
                WriteLiteral("\r\n                                                </select>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6052, 215, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"modal-footer no-bd\">\r\n                                <button type=\"button\" id=\"add\" class=\"btn btn-outline-success\" data-dismiss=\"modal\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 6267, "\"", 6315, 3);
            WriteAttributeValue("", 6277, "Save(", 6277, 5, true);
#line 111 "D:\MII\MCCOC\#9-Last_Project\CoreFEDesign\Client\Views\User\UserDasbor.cshtml"
WriteAttributeValue("", 6282, Context.Session.GetInt32("id"), 6282, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 6313, ");", 6313, 2, true);
            EndWriteAttribute();
            BeginContext(6316, 18, true);
            WriteLiteral(">Insert</button>\r\n");
            EndContext();
            BeginContext(6494, 1104, true);
            WriteLiteral(@"                                <button type=""button"" class=""btn btn-outline-danger"" data-dismiss=""modal"">Close</button>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""table-responsive"">
                    <table id=""myTable"" class=""display table table-striped table-hover"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>
                                    Car <br />
                                    Merk
                                </th>
                                <th>Start Date</th>
                                <th>End Date</th>
                                <th>Total</th>
                                <th>Tanggal Bayar</th>
                                <th>Status</th>
                            </tr>
                        </thead>

                    </table>
      ");
            WriteLiteral("          </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7615, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7621, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eec0842346cc48a4ba395011fb0826b7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7671, 2, true);
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
