#pragma checksum "E:\Work\Github\Tugas_Akhir_MCC\CoreFEDesign-V2\Client\Views\Cars\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fa1f28d6ae8ce2d1e7f9e269611085dd2452829"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_Index), @"mvc.1.0.view", @"/Views/Cars/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cars/Index.cshtml", typeof(AspNetCore.Views_Cars_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fa1f28d6ae8ce2d1e7f9e269611085dd2452829", @"/Views/Cars/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-user btn-block float-left "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cars", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Excel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Automatic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Manual", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Scripts/CarScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\Work\Github\Tugas_Akhir_MCC\CoreFEDesign-V2\Client\Views\Cars\Index.cshtml"
  
    ViewData["Title"] = "Car";
    Layout = "~/Views/Layout/_Layout.cshtml";

#line default
#line hidden
            BeginContext(88, 56, true);
            WriteLiteral("\r\n<div class=\"page-header\">\r\n    <h4 class=\"page-title\">");
            EndContext();
            BeginContext(145, 17, false);
#line 8 "E:\Work\Github\Tugas_Akhir_MCC\CoreFEDesign-V2\Client\Views\Cars\Index.cshtml"
                      Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(162, 1286, true);
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
            <a href=""#"">Car</a>
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
                        <button class=""btn btn-secondary btn-border btn-round"" data-toggle=""tooltip"" data-placem");
            WriteLiteral(@"ent=""top"" data-animation=""false"" title=""Add"">
                            <i class=""fa fa-plus""></i>
                        </button>
                    </div>
                </div>
                <div class="""" style=""width: 70px"">
                    ");
            EndContext();
            BeginContext(1448, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c9addc7c7e3475db3cf6d828752ce62", async() => {
                BeginContext(1559, 5, true);
                WriteLiteral("Excel");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1568, 931, true);
            WriteLiteral(@"
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
                            <div class=""modal-body"">
                                ");
            EndContext();
            BeginContext(2499, 3109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62e92464126a43a5902310e00301b4ea", async() => {
                BeginContext(2505, 2166, true);
                WriteLiteral(@"
                                    <div class=""row"">
                                        <div class=""col-lg-12"">
                                            <div class=""form-group"">
                                                <input type=""text"" id=""Id"" name=""Id"" class=""form-control"" hidden>
                                            </div>
                                        </div>
                                        <div class=""col-sm-12"">
                                            <div class=""form-group form-group-default"">
                                                <label>Car Name</label>
                                                <input type=""text"" id=""Name"" name=""Name"" class=""form-control"" placeholder=""fill name"">
                                            </div>
                                        </div>

                                        <div class=""col-sm-12"">
                                            <div class=""form-group form-group-default"">");
                WriteLiteral(@"
                                                <label>Car Merk</label>
                                                <select class=""form-control"" id=""MerkOption"" name=""MerkOption""></select>
                                            </div>
                                        </div>

                                        <div class=""col-lg-4"">
                                            <div class=""form-group form-group-default"">
                                                <label>Tahun Produksi</label>
                                                <input type=""number"" id=""Year"" name=""Year"" class=""form-control"" placeholder=""fill name"">
                                            </div>
                                        </div>
                                        <div class=""col-lg-4"">
                                            <div class=""form-group form-group-default"">
                                                <label>Transmisi</label>
                            ");
                WriteLiteral("                    <select class=\"form-control\" id=\"Transmisi\">\r\n                                                    ");
                EndContext();
                BeginContext(4671, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "975175deb250482f9855c19a7ac7e0f2", async() => {
                    BeginContext(4688, 13, true);
                    WriteLiteral("Select Status");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4710, 54, true);
                WriteLiteral("\r\n                                                    ");
                EndContext();
                BeginContext(4764, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "729f7284778f426c83a2956d1c30581a", async() => {
                    BeginContext(4790, 9, true);
                    WriteLiteral("Automatic");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4808, 54, true);
                WriteLiteral("\r\n                                                    ");
                EndContext();
                BeginContext(4862, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b5653385dd343ceb3980c9ba0fc4b94", async() => {
                    BeginContext(4885, 6, true);
                    WriteLiteral("Manual");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4900, 701, true);
                WriteLiteral(@"
                                                </select>
                                            </div>
                                        </div>
                                        <div class=""col-lg-4"">
                                            <div class=""form-group form-group-default"">
                                                <label>Harga</label>
                                                <input type=""number"" id=""Price"" name=""Price"" class=""form-control"" placeholder=""fill Price"">
                                            </div>
                                        </div>
                                    </div>
                                ");
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
            BeginContext(5608, 1468, true);
            WriteLiteral(@"
                            </div>
                            <div class=""modal-footer no-bd"">
                                <button type=""button"" id=""add"" class=""btn btn-outline-success"" data-dismiss=""modal"" onclick=""Save();"">Insert</button>
                                <button type=""button"" id=""update"" class=""btn btn-outline-warning"" data-dismiss=""modal"" onclick=""Update();"">Update</button>
                                <button type=""button"" class=""btn btn-outline-danger"" data-dismiss=""modal"">Close</button>
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
                                    <s");
            WriteLiteral(@"mall>Merk</small>
                                </th>
                                <th>Tahun</th>
                                <th>Transmition</th>
                                <th>Price</th>
                                <th>Action</th>
                            </tr>
                        </thead>

                    </table>
                </div>
            </div>
        </div>
    </div>
</div>



");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7093, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7099, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c41b9ab5e9b34e03866d6216813f074f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7148, 2, true);
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
