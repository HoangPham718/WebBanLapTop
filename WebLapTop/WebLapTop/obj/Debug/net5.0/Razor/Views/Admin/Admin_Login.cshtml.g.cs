#pragma checksum "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\Admin_Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66873c83d6fd60a040ba98d09b7b91802a0d8e1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Admin_Login), @"mvc.1.0.view", @"/Views/Admin/Admin_Login.cshtml")]
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
#nullable restore
#line 1 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\_ViewImports.cshtml"
using WebLapTop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\_ViewImports.cshtml"
using WebLapTop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66873c83d6fd60a040ba98d09b7b91802a0d8e1e", @"/Views/Admin/Admin_Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4759a366bcb97d677f53bfbebf25a1cc2a4b5274", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Admin_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebLapTop.Models.AccountLogin>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/signin-image.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("sing up image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("register-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("login-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\Admin_Login.cshtml"
  
    ViewData["Title"] = "Admin_Login";
    Layout = "~/Views/Shared/_LoginLayout.cshtml";
    var account = ViewData["Account"] as AccountLogin;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"main\">\r\n\r\n    <!-- Sing in  Form -->\r\n    <section class=\"sign-in\">\r\n        <div class=\"container-1\">\r\n            <div class=\"signin-content\">\r\n                <div class=\"signin-image\">\r\n                    <figure>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "66873c83d6fd60a040ba98d09b7b91802a0d8e1e5688", async() => {
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
            WriteLiteral("</figure>\r\n\r\n                </div>\r\n\r\n                <div class=\"signin-form\">\r\n                    <h2 class=\"form-title\">TRANG CHO ADMIN</h2>\r\n");
#nullable restore
#line 21 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\Admin_Login.cshtml"
                     using (Html.BeginForm("Admin_Login", "Admin", FormMethod.Post))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\Admin_Login.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\Admin_Login.cshtml"
                   Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66873c83d6fd60a040ba98d09b7b91802a0d8e1e7721", async() => {
                WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                <label for=\"your_name\"><i class=\"zmdi zmdi-account material-icons-name\"></i></label>\r\n");
#nullable restore
#line 28 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\Admin_Login.cshtml"
                                 if (String.IsNullOrEmpty(account.Email))
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <input type=\"text\" name=\"Email\" id=\"your_name\"");
                BeginWriteAttribute("value", " value=\"", 1284, "\"", 1292, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Email\" />\r\n");
#nullable restore
#line 31 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\Admin_Login.cshtml"
                                                                                                                                              
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <input type=\"text\" name=\"Email\" id=\"your_name\"");
                BeginWriteAttribute("value", " value=\"", 1652, "\"", 1674, 1);
#nullable restore
#line 35 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\Admin_Login.cshtml"
WriteAttributeValue("", 1660, account.Email, 1660, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Email\" />\r\n");
#nullable restore
#line 36 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\Admin_Login.cshtml"
                                                                                                                                              
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label for=\"your_pass\"><i class=\"zmdi zmdi-lock\"></i></label>\r\n");
#nullable restore
#line 41 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\Admin_Login.cshtml"
                                 if (String.IsNullOrEmpty(account.MatKhau))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\Admin_Login.cshtml"
                               Write(Html.PasswordFor(a => a.MatKhau, new { @name = "your_pass", @id = "your_pass", @placeholder = "Mật khẩu" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\Admin_Login.cshtml"
                                                                                                                                                
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\Admin_Login.cshtml"
                               Write(Html.PasswordFor(a => a.MatKhau, new { @name = "your_pass", @id = "your_pass", @value = account.MatKhau }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\Admin_Login.cshtml"
                                                                                                                                               
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </div>
                            <div class=""form-group form-button"">
                                <input type=""submit"" name=""signin"" id=""signin"" class=""form-submit"" value=""Đăng nhập"" />
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 54 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\Admin_Login.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebLapTop.Models.AccountLogin> Html { get; private set; }
    }
}
#pragma warning restore 1591
