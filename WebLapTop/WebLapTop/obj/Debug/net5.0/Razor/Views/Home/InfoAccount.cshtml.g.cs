#pragma checksum "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\InfoAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa055cc61eb1626e0561657fceefd8186bbd1507"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_InfoAccount), @"mvc.1.0.view", @"/Views/Home/InfoAccount.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa055cc61eb1626e0561657fceefd8186bbd1507", @"/Views/Home/InfoAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4759a366bcb97d677f53bfbebf25a1cc2a4b5274", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_InfoAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebLapTop.Models.Khachhang>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("register-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("register-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveReadonly", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-style:solid; background-color:blue; font-size: 20px; color: white; display: block; text-align: center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("change-user-image-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangePassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" border-style: solid; background-color: blue; font-size: 20px; color: white; display: block; text-align: center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("change-pass-image-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\InfoAccount.cshtml"
  
    ViewData["Title"] = "InfoAccount";
    Layout = "~/Views/Shared/_LoginLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main"">

    <!-- Sign up form -->
    <section class=""signup"">
        <h2 class=""form-title"">THÔNG TIN TÀI KHOẢN</h2>
        <div class=""container-1"">
            <div class=""signup-content"">
                <div class=""signup-form"" style=""width: -webkit-fill-available;"">
");
#nullable restore
#line 15 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\InfoAccount.cshtml"
                     using (Html.BeginForm("UpdateUser", "Home", FormMethod.Post))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa055cc61eb1626e0561657fceefd8186bbd15078068", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 18 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\InfoAccount.cshtml"
                             if (ViewData["RemoveReadonly"] != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\InfoAccount.cshtml"
                                 if (ViewData["ValidPhone"] != null)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <p style=\"font-size:18px;color:red;\"> Sai định dạng số điện thoại</p>\r\n");
#nullable restore
#line 23 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\InfoAccount.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <div class=""form-group"">
                                    Họ vả tên :
                                    <label for=""name""><i class=""zmdi zmdi-accounts-outline""></i></label>
                                    <input name=""TenKh"" id=""TenKh"" required=""required""");
                BeginWriteAttribute("value", " value=\"", 1272, "\"", 1292, 1);
#nullable restore
#line 27 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\InfoAccount.cshtml"
WriteAttributeValue("", 1280, Model.TenKh, 1280, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                </div>
                                <div class=""form-group"">
                                    Email :
                                    <label for=""email""><i class=""zmdi zmdi-email""></i></label>
                                    <input type=""email"" name=""Email"" required=""required"" id=""Email""");
                BeginWriteAttribute("value", " value=\"", 1636, "\"", 1656, 1);
#nullable restore
#line 32 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\InfoAccount.cshtml"
WriteAttributeValue("", 1644, Model.Email, 1644, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                </div>
                                <div class=""form-group"">
                                    Địa chỉ :
                                    <label for=""address""><i class=""zmdi zmdi-my-location""></i></label>
                                    <input name=""DiaChi"" id=""DiaChi"" required=""required""");
                BeginWriteAttribute("value", " value=\"", 1999, "\"", 2020, 1);
#nullable restore
#line 37 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\InfoAccount.cshtml"
WriteAttributeValue("", 2007, Model.DiaChi, 2007, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                </div>
                                <div class=""form-group"">
                                    Số diện thoại :
                                    <label for=""phone""><i class=""zmdi zmdi-account-box-phone""></i></label>
                                    <input type=""number"" name=""Sdt"" id=""Sdt"" required=""required""");
                BeginWriteAttribute("value", " value=\"", 2381, "\"", 2399, 1);
#nullable restore
#line 42 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\InfoAccount.cshtml"
WriteAttributeValue("", 2389, Model.Sdt, 2389, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                </div>\r\n");
#nullable restore
#line 44 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\InfoAccount.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <div class=""form-group"">
                                    Họ vả tên :
                                    <label for=""name""><i class=""zmdi zmdi-accounts-outline""></i></label>
                                    <input name=""TenKh"" id=""TenKh""");
                BeginWriteAttribute("value", " value=\"", 2820, "\"", 2840, 1);
#nullable restore
#line 50 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\InfoAccount.cshtml"
WriteAttributeValue("", 2828, Model.TenKh, 2828, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly=""readonly"" />
                                </div>
                                <div class=""form-group"">
                                    Email :
                                    <label for=""email""><i class=""zmdi zmdi-email""></i></label>
                                    <input name=""Email"" id=""Email""");
                BeginWriteAttribute("value", " value=\"", 3171, "\"", 3191, 1);
#nullable restore
#line 55 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\InfoAccount.cshtml"
WriteAttributeValue("", 3179, Model.Email, 3179, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly=""readonly"" />
                                </div>
                                <div class=""form-group"">
                                    Địa chỉ :
                                    <label for=""address""><i class=""zmdi zmdi-my-location""></i></label>
                                    <input name=""DiaChi"" id=""DiaChi""");
                BeginWriteAttribute("value", " value=\"", 3534, "\"", 3555, 1);
#nullable restore
#line 60 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\InfoAccount.cshtml"
WriteAttributeValue("", 3542, Model.DiaChi, 3542, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly=""readonly"" />
                                </div>
                                <div class=""form-group"">
                                    Số diện thoại :
                                    <label for=""phone""><i class=""zmdi zmdi-account-box-phone""></i></label>
                                    <input name=""Sdt"" id=""Sdt""");
                BeginWriteAttribute("value", " value=\"", 3902, "\"", 3920, 1);
#nullable restore
#line 65 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\InfoAccount.cshtml"
WriteAttributeValue("", 3910, Model.Sdt, 3910, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly=\"readonly\" />\r\n                                </div>\r\n");
#nullable restore
#line 67 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\InfoAccount.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <div class=""form-group"">
                                Mã khuyến mãi của bạn :
                                <label for=""pass""><i class=""zmdi zmdi-lock""></i></label>
                                <input name=""MaKm"" id=""MaKM""");
                BeginWriteAttribute("value", " value=\"", 4278, "\"", 4297, 1);
#nullable restore
#line 71 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\InfoAccount.cshtml"
WriteAttributeValue("", 4286, Model.MaKm, 4286, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly=\"readonly\" />\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                Thông tin mã khuyến mãi :\r\n                                <br />\r\n                                ");
#nullable restore
#line 76 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\InfoAccount.cshtml"
                           Write(ViewData["mota"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            </div>\r\n                            <div class=\"form-group form-button\">\r\n");
#nullable restore
#line 80 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\InfoAccount.cshtml"
                                 if (ViewData["RemoveReadonly"] != null)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <input type=\"submit\" name=\"signup\" id=\"signup\" class=\"form-submit\" value=\"Cập nhật\" />\r\n");
#nullable restore
#line 83 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\InfoAccount.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n                        ");
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
#line 86 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\InfoAccount.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"signup-image\">\r\n");
#nullable restore
#line 89 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\InfoAccount.cshtml"
                     if (ViewData["RemoveReadonly"] == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa055cc61eb1626e0561657fceefd8186bbd150719468", async() => {
                WriteLiteral("Sửa thông tin");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 92 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Home\InfoAccount.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa055cc61eb1626e0561657fceefd8186bbd150721431", async() => {
                WriteLiteral("Đổi mật khẩu");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebLapTop.Models.Khachhang> Html { get; private set; }
    }
}
#pragma warning restore 1591
