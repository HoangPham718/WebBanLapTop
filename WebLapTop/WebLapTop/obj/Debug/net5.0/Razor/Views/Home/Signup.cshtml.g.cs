#pragma checksum "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\Signup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d78a5372bb2a4f9b5bc821b54658733065eaa74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Signup), @"mvc.1.0.view", @"/Views/Home/Signup.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d78a5372bb2a4f9b5bc821b54658733065eaa74", @"/Views/Home/Signup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4759a366bcb97d677f53bfbebf25a1cc2a4b5274", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Signup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebLapTop.Models.KhachHangValid>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("register-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("register-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/signup-image.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("sing up image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("signup-image-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\Signup.cshtml"
  
    ViewData["Title"] = "Signup";
    Layout = "~/Views/Shared/_LoginLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""main"">

    <!-- Sign up form -->
    <section class=""signup"">
        <div class=""container-1"">
            <div class=""signup-content"" style=""display:-webkit-box"">
                <div class=""signup-form"">
                    <h2 class=""form-title"">Đăng kí</h2>
");
#nullable restore
#line 14 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\Signup.cshtml"
                     using (Html.BeginForm("Signup", "Home", FormMethod.Post))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\Signup.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\Signup.cshtml"
                   Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d78a5372bb2a4f9b5bc821b54658733065eaa747719", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <p style=\"font-size:20px;color:white\"> Họ và tên<sup>*</sup></p>\r\n                        ");
#nullable restore
#line 21 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\Signup.cshtml"
                   Write(Html.TextBoxFor(a => a.TenKh, new { @name = "name", @id = "name", @placeholder = "Họ và tên" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <p style=\"font-size:20px;color:white\">Email<sup>*</sup></p>\r\n                        ");
#nullable restore
#line 25 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\Signup.cshtml"
                   Write(Html.TextBoxFor(a => a.Email, new { @name = "email", @id = "email", @placeholder = "Email" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <p style=\"font-size:20px;color:white\">Số nhà, đường<sup>*</sup></p>\r\n                        ");
#nullable restore
#line 29 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\Signup.cshtml"
                   Write(Html.TextBoxFor(a => a.soNha, new { @name = "address", @id = "address", @placeholder = "Số nhà, đường" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <p style=\"font-size:20px;color:white\"> Xã/ Phường<sup>*</sup></p>\r\n                        ");
#nullable restore
#line 33 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\Signup.cshtml"
                   Write(Html.TextBoxFor(a => a.xaP, new { @name = "address", @id = "address", @placeholder = "Xã/ Phường" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <p style=\"font-size:20px;color:white\"> Quận/ Huyện<sup>*</sup></p>\r\n                        ");
#nullable restore
#line 37 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\Signup.cshtml"
                   Write(Html.TextBoxFor(a => a.quanH, new { @name = "address", @id = "address", @placeholder = "Quận/ Huyện" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <p style=\"font-size:20px;color:white\">Tỉnh/ Thành phố<sup>*</sup></p>\r\n                        ");
#nullable restore
#line 41 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\Signup.cshtml"
                   Write(Html.TextBoxFor(a => a.tinhTP, new { @name = "address", @id = "address", @placeholder = "Tỉnh/ Thành phố" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <p style=\"font-size:20px;color:white\">Số điện thoại<sup>*</sup></p>\r\n                        ");
#nullable restore
#line 45 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\Signup.cshtml"
                   Write(Html.TextBoxFor(a => a.Sdt, new { @name = "address", @id = "address", @placeholder = "Số điện thoại" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <p style=\"font-size:20px;color:white\"> Mật khẩu<sup>*</sup></p>\r\n                        ");
#nullable restore
#line 49 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\Signup.cshtml"
                   Write(Html.PasswordFor(a => a.MatKhau, new { @name = "phone", @id = "phone", @placeholder = "Mật khẩu" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <p style=\"font-size:20px;color:white\"> Nhập lại mật khẩu<sup>*</sup></p>\r\n                        ");
#nullable restore
#line 53 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\Signup.cshtml"
                   Write(Html.PasswordFor(a => a.reMatKhau, new { @name = "re-pass", @id = "re-pass", @placeholder = "Nhập lại mật khẩu" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 57 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\Signup.cshtml"
                   Write(Html.CheckBoxFor(a => a.Check, new { @name = "agree-term", @id = "agree-term" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        <label for=""agree-term"" class=""label-agree-term""><span><span></span></span><sup>*</sup>Tôi đồng ý với các <a href=""#"" class=""term-service"">điều khoản của nhóm phát triển</a></label>
                    </div>
                    <div class=""form-group form-button"">
                        <input type=""submit"" name=""signup"" id=""signup"" class=""form-submit"" value=""Đăng kí"" />
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 64 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\Signup.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"signup-image\">\r\n                    <figure>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7d78a5372bb2a4f9b5bc821b54658733065eaa7415134", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</figure>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d78a5372bb2a4f9b5bc821b54658733065eaa7416278", async() => {
                WriteLiteral("Tôi đã có tài khoản");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebLapTop.Models.KhachHangValid> Html { get; private set; }
    }
}
#pragma warning restore 1591
