#pragma checksum "E:\Work\CoreFEDesign-V2\Client\Views\Accounts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "becffc13c1971dfe5e895736cea3d5fe5777af8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Index), @"mvc.1.0.view", @"/Views/Accounts/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Accounts/Index.cshtml", typeof(AspNetCore.Views_Accounts_Index))]
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
#line 1 "E:\Work\CoreFEDesign-V2\Client\Views\_ViewImports.cshtml"
using Client;

#line default
#line hidden
#line 2 "E:\Work\CoreFEDesign-V2\Client\Views\_ViewImports.cshtml"
using Client.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"becffc13c1971dfe5e895736cea3d5fe5777af8a", @"/Views/Accounts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Scripts/AccountScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\Work\CoreFEDesign-V2\Client\Views\Accounts\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Layout/_Layout.cshtml";

#line default
#line hidden
            BeginContext(90, 56, true);
            WriteLiteral("\r\n<div class=\"page-header\">\r\n    <h4 class=\"page-title\">");
            EndContext();
            BeginContext(147, 17, false);
#line 8 "E:\Work\CoreFEDesign-V2\Client\Views\Accounts\Index.cshtml"
                      Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(164, 2123, true);
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
            <a href=""#"">Account</a>
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
            BeginContext(2287, 4039, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61ab918345304e2683cbb3ca93bd74d5", async() => {
                BeginContext(2293, 3577, true);
                WriteLiteral(@"
                                    <div class=""row"">
                                        <div class=""col-lg-12"">
                                            <div class=""form-group"">
                                                <input type=""text"" id=""Id"" name=""Id"" class=""form-control"" hidden>
                                            </div>
                                        </div>
                                        <div class=""col-lg-6"">
                                            <div class=""form-group form-group-default"">
                                                <label>Name</label>
                                                <input type=""text"" id=""Name"" name=""Name"" class=""form-control"" placeholder=""fill name"">
                                            </div>
                                        </div>

                                        <div class=""col-lg-6"">
                                            <div class=""form-group form-group-default"">
    ");
                WriteLiteral(@"                                            <label>Username</label>
                                                <input type=""text"" id=""Uname"" name=""Uname"" class=""form-control"" placeholder=""fill Username"">
                                            </div>
                                        </div>

                                        <div class=""col-lg-6"">
                                            <div class=""form-group form-group-default"">
                                                <label>Email</label>
                                                <input type=""email"" id=""Email"" name=""Email"" class=""form-control"" placeholder=""fill Email"">
                                            </div>
                                        </div>

                                        <div class=""col-lg-6"">
                                            <div class=""form-group form-group-default"">
                                                <label>Password</label>
                    ");
                WriteLiteral(@"                            <input type=""password"" id=""Pass"" name=""Pass"" class=""form-control"" placeholder=""fill Password"">
                                            </div>
                                        </div>

                                        <div class=""col-lg-4"">
                                            <div class=""form-group form-group-default"">
                                                <label>Address</label>
                                                <input type=""text"" id=""Addr"" name=""Addr"" class=""form-control"" placeholder=""fill Address"">
                                            </div>
                                        </div>

                                        <div class=""col-lg-4"">
                                            <div class=""form-group form-group-default"">
                                                <label>Phone</label>
                                                <input type=""text"" id=""Phone"" name=""Phone"" class=""form-contro");
                WriteLiteral(@"l"" placeholder=""fill Phone"">
                                            </div>
                                        </div>

                                        <div class=""col-lg-4"">
                                            <div class=""form-group form-group-default"">
                                                <label>Access Level</label>
                                                <select class=""form-control"" id=""Access"">
                                                    ");
                EndContext();
                BeginContext(5870, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b420f2afcf64db2bb34c64ccaa9451f", async() => {
                    BeginContext(5887, 6, true);
                    WriteLiteral("Select");
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
                BeginContext(5902, 54, true);
                WriteLiteral("\r\n                                                    ");
                EndContext();
                BeginContext(5956, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8594a1e3f3d4f4ca690eecad8ba1537", async() => {
                    BeginContext(5978, 5, true);
                    WriteLiteral("Admin");
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
                BeginContext(5992, 54, true);
                WriteLiteral("\r\n                                                    ");
                EndContext();
                BeginContext(6046, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "217a229033a44555a2894e24e8f05c3a", async() => {
                    BeginContext(6067, 4, true);
                    WriteLiteral("User");
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
                BeginContext(6080, 239, true);
                WriteLiteral("\r\n                                                </select>\r\n                                            </div>\r\n                                        </div>\r\n\r\n                                    </div>\r\n                                ");
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
            BeginContext(6326, 1422, true);
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
                                    Name <br />
                                    <");
            WriteLiteral(@"small>Username</small>
                                </th>
                                <th>email</th>
                                <th>access_level</th>
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
                BeginContext(7765, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7771, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b49580f45784920aa11d3eda2caa2d1", async() => {
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
                BeginContext(7824, 2, true);
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
