#pragma checksum "D:\MII\MCCOC\#9-Last_Project\CoreFEDesign\Client\Views\Accounts\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b14e79fdaebe6da10e45314b5509df745d9c957d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Register), @"mvc.1.0.view", @"/Views/Accounts/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Accounts/Register.cshtml", typeof(AspNetCore.Views_Accounts_Register))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b14e79fdaebe6da10e45314b5509df745d9c957d", @"/Views/Accounts/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Scripts/AuthScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\MII\MCCOC\#9-Last_Project\CoreFEDesign\Client\Views\Accounts\Register.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = "~/Views/Layout/_LayoutHandler.cshtml";

#line default
#line hidden
            BeginContext(95, 1972, true);
            WriteLiteral(@"
<div class=""login"">
    <div class=""wrapper wrapper-login"">
        <div class=""container container-signup animated fadeIn"">
            <h3 class=""text-center"">Sign Up</h3>
            <div class=""login-form"">
                <div class=""form-group form-floating-label"">
                    <input id=""Name"" name=""Name"" type=""text"" class=""form-control input-border-bottom"" required>
                    <label for=""fullname"" class=""placeholder"">Fullname</label>
                </div>
                <div class=""form-group form-floating-label"">
                    <input id=""Uname"" name=""Uname"" type=""text"" class=""form-control input-border-bottom"" required>
                    <label for=""fullname"" class=""placeholder"">Username</label>
                </div>
                <div class=""form-group form-floating-label"">
                    <input id=""Email"" name=""Email"" type=""email"" class=""form-control input-border-bottom"" required>
                    <label for=""email"" class=""placeholder"">Email</la");
            WriteLiteral(@"bel>
                </div>
                <div class=""form-group form-floating-label"">
                    <input id=""Pass"" name=""Pass"" type=""password"" class=""form-control input-border-bottom"" required>
                    <label for=""passwordsignin"" class=""placeholder"">Password</label>
                    <div class=""show-password"">
                        <i class=""flaticon-interface""></i>
                    </div>
                </div>
                <div class=""form-group form-floating-label"">
                    <input id=""confirmPass"" name=""confirmPass"" type=""password"" class=""form-control input-border-bottom"" required>
                    <label for=""confirmpassword"" class=""placeholder"">Confirm Password</label>
                    <div class=""show-password"">
                        <i class=""flaticon-interface""></i>
                    </div>
                </div>
                <div class=""form-action"">
");
            EndContext();
            BeginContext(2182, 401, true);
            WriteLiteral(@"                    <a href=""#"" id=""regis"" class=""btn btn-primary btn-rounded btn-login"" onclick=""Register();"">Sign Up</a>
                </div>
                <div class=""login-account"">
                    <span class=""msg"">Have an account yet ?</span>
                    <a href=""/"" class=""link"">Sign In</a>
                </div>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2600, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2606, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9897dc7197364d018d7fa5fdb2c514dd", async() => {
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
                BeginContext(2656, 2, true);
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
