#pragma checksum "C:\Users\toufi\source\repos\Gravity\Gravity\Views\Login\Password_change.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3625baefcc0eecfc7f679720de690df65f4becc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Password_change), @"mvc.1.0.view", @"/Views/Login/Password_change.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Password_change.cshtml", typeof(AspNetCore.Views_Login_Password_change))]
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
#line 1 "C:\Users\toufi\source\repos\Gravity\Gravity\Views\_ViewImports.cshtml"
using Gravity;

#line default
#line hidden
#line 2 "C:\Users\toufi\source\repos\Gravity\Gravity\Views\_ViewImports.cshtml"
using Gravity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3625baefcc0eecfc7f679720de690df65f4becc", @"/Views/Login/Password_change.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07cf0a217bd801a86d29a3073d3b6b421cdc174d", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Password_change : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1585, true);
            WriteLiteral(@"<!-- BREADCRUMB-->
<section class=""au-breadcrumb m-t-75"">
    <div class=""section__content section__content--p30"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""au-breadcrumb-content"">
                        <div class=""au-breadcrumb-left"">
                            <span class=""au-breadcrumb-span"">You are here:</span>
                            <ul class=""list-unstyled list-inline au-breadcrumb__list"">
                                <li class=""list-inline-item active"">
                                    <a href=""#"">Wallet</a>
                                </li>
                                <li class=""list-inline-item seprate"">
                                    <span>/</span>
                                </li>
                                <li class=""list-inline-item"">Security</li>
                            </ul>
                        </div>

                    </div>
     ");
            WriteLiteral(@"           </div>
            </div>
        </div>
    </div>
</section>
<!-- END BREADCRUMB-->


<section>
    <div class=""section__content section__content--p30"">
        <div class=""container-fluid"">
            <div class=""row"">

                <div class=""col-lg-9"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <strong>Change Password</strong>
                        </div>
                        <div class=""card-body card-block"">
                            ");
            EndContext();
            BeginContext(1585, 2768, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3625baefcc0eecfc7f679720de690df65f4becc6369", async() => {
                BeginContext(1669, 2677, true);
                WriteLiteral(@"

                                <div class=""row form-group"">
                                    <div class=""col col-md-3"">
                                        <label for=""text-input"" class="" form-control-label"">Current Password</label>
                                    </div>
                                    <div class=""col-12 col-md-9"">
                                        <input type=""password"" id=""text-input"" name=""text-input"" placeholder=""Current Password"" class=""form-control"">
                                        <small class=""form-text text-muted"">Please enter your current password</small>
                                    </div>
                                </div>
                                <div class=""row form-group"">
                                    <div class=""col col-md-3"">
                                        <label for=""email-input"" class="" form-control-label"">New Password</label>
                                    </div>
                         ");
                WriteLiteral(@"           <div class=""col-12 col-md-9"">
                                        <input type=""password"" id=""email-input"" name=""email-input"" placeholder=""New Password"" class=""form-control"">
                                        <small class=""help-block form-text"">Please enter your new password</small>
                                    </div>
                                </div>
                                <div class=""row form-group"">
                                    <div class=""col col-md-3"">
                                        <label for=""password-input"" class="" form-control-label"">Confirm Password</label>
                                    </div>
                                    <div class=""col-12 col-md-9"">
                                        <input type=""password"" id=""password-input"" name=""password-input"" placeholder=""Confirm Password"" class=""form-control"">
                                        <small class=""help-block form-text"">Please enter a confirm password</small>");
                WriteLiteral(@"
                                    </div>
                                </div>

                                <div class=""row form-group"">
                                    <div class=""col col-md-3"">

                                    </div>
                                    <div class=""col-12 col-md-9"">
                                        <button type=""submit"" class=""btn btn-success"">
                                            <i class=""fa fa-save""></i> Save
                                        </button>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4353, 200, true);
            WriteLiteral("\r\n\r\n\r\n\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n</section>\r\n\r\n\r\n<!-- END PAGE CONTAINER-->\r\n        \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
