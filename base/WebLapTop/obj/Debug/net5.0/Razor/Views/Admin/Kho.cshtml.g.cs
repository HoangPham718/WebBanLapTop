#pragma checksum "C:\Users\WIN\Desktop\WebBanLapTop\base\WebLapTop\Views\Admin\Kho.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83ed6c119acebf2c12b317ba35a79ee7e237d36e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Kho), @"mvc.1.0.view", @"/Views/Admin/Kho.cshtml")]
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
#line 1 "C:\Users\WIN\Desktop\WebBanLapTop\base\WebLapTop\Views\_ViewImports.cshtml"
using WebLapTop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\WIN\Desktop\WebBanLapTop\base\WebLapTop\Views\_ViewImports.cshtml"
using WebLapTop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83ed6c119acebf2c12b317ba35a79ee7e237d36e", @"/Views/Admin/Kho.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4759a366bcb97d677f53bfbebf25a1cc2a4b5274", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Kho : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebLapTop.Models.Kho>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("register-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("register-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\WIN\Desktop\WebBanLapTop\base\WebLapTop\Views\Admin\Kho.cshtml"
  
    ViewData["Title"] = "Kho";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    var lstK = ViewData["dsKho"] as List<Kho>;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>DANH SÁCH KHO</h3>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83ed6c119acebf2c12b317ba35a79ee7e237d36e5078", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <style>
body {font-family: Arial, Helvetica, sans-serif;}

/* The Modal (background) */
.modal {
  display: none; /* Hidden by default */
  position: fixed; /* Stay in place */
  z-index: 1; /* Sit on top */
  padding-top: 100px; /* Location of the box */
  left: 0;
  top: 0;
  width: 100%; /* Full width */
  height: 100%; /* Full height */
  overflow: auto; /* Enable scroll if needed */
  background-color: rgb(0,0,0); /* Fallback color */
  background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
}

/* Modal Content */
.modal-content {
  position: relative;
  background-color: #fefefe;
  margin: auto;
  padding: 0;
  border: 1px solid #888;
  width: 80%;
  box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2),0 6px 20px 0 rgba(0,0,0,0.19);
  -webkit-animation-name: animatetop;
  -webkit-animation-duration: 0.4s;
  animation-name: animatetop;
  animation-duration: 0.4s
}

        /* Add Animation */
");
                WriteLiteral(@"
/* The Close Button */
.close {
  color: white;
  float: right;
  font-size: 28px;
  font-weight: bold;
}

.close:hover,
.close:focus {
  color: #000;
  text-decoration: none;
  cursor: pointer;
}

        .modal-header {
            padding: 2px 20px;
            background-color: #5cb85c;
            color: white;
            text-align: left;
        }

.modal-body {padding: 2px 16px;}

.modal-footer {
  padding: 2px 16px;
  background-color: #5cb85c;
  color: white;
  padding-top: 20px;
}
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83ed6c119acebf2c12b317ba35a79ee7e237d36e7639", async() => {
                WriteLiteral("\r\n\r\n");
                WriteLiteral(@"
    <!-- Trigger/Open The Modal -->
    <button id=""myBtn"">Thêm Nhân Viên</button>

    <!-- The Modal -->

    <div id=""myModal"" class=""modal"">

        <!-- Modal content -->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <span class=""close"">&times;</span>
                <h2>THÊM KHO CHỨA</h2>
            </div>
            <div class=""modal-body"">
");
                WriteLiteral(@"                <div class=""main"">

                    <!-- Add nhân viên form -->
                    <section class=""signup"">
                        <div class=""container-1"">
                            <div class=""signup-content"">
                                <div class=""signup-form"">
");
#nullable restore
#line 117 "C:\Users\WIN\Desktop\WebBanLapTop\base\WebLapTop\Views\Admin\Kho.cshtml"
                                     using (Html.BeginForm("Kho", "Admin", FormMethod.Post))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "C:\Users\WIN\Desktop\WebBanLapTop\base\WebLapTop\Views\Admin\Kho.cshtml"
                                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "C:\Users\WIN\Desktop\WebBanLapTop\base\WebLapTop\Views\Admin\Kho.cshtml"
                                   Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83ed6c119acebf2c12b317ba35a79ee7e237d36e9557", async() => {
                    WriteLiteral("\r\n");
                    WriteLiteral(@"                                        <div class=""form-group"">
                                            <label for=""email""><i class=""zmdi zmdi-email""></i></label>
                                            <label for=""fname"" style=""padding-right:70px"">Tên kho: </label>
                                            ");
#nullable restore
#line 130 "C:\Users\WIN\Desktop\WebBanLapTop\base\WebLapTop\Views\Admin\Kho.cshtml"
                                       Write(Html.TextBoxFor(a => a.TenKho, new { @name = "name", @id = "name", @type = "text", @placeholder = "Tên kho" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </div>
                                        <div class=""form-group"">
                                            <label for=""pass""><i class=""zmdi zmdi-lock""></i></label>
                                            <label for=""fname"" style=""padding-right:79px"">Địa chỉ: </label>
                                            ");
#nullable restore
#line 135 "C:\Users\WIN\Desktop\WebBanLapTop\base\WebLapTop\Views\Admin\Kho.cshtml"
                                       Write(Html.PasswordFor(a => a.DiaChi, new { @name = "address", @id = "address", @type = "text", @placeholder = "Địa chỉ" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </div>
                                        <div class=""form-group"">
                                            <label for=""phone""><i class=""zmdi zmdi-account-box-phone""></i></label>
                                            <label for=""fname"" style=""padding-right:34px"">Số điện thoại: </label>
                                            ");
#nullable restore
#line 140 "C:\Users\WIN\Desktop\WebBanLapTop\base\WebLapTop\Views\Admin\Kho.cshtml"
                                       Write(Html.TextBoxFor(a => a.Sdt, new { @name = "phone", @id = "phone", @type = "number", @placeholder = "Số điện thoại" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </div>
                                        <div class=""form-group"">
                                            <label for=""address""><i class=""zmdi zmdi-my-location""></i></label>
                                            <label for=""fname"" style=""padding-right:87px"">Email: </label>
                                            ");
#nullable restore
#line 145 "C:\Users\WIN\Desktop\WebBanLapTop\base\WebLapTop\Views\Admin\Kho.cshtml"
                                       Write(Html.TextBoxFor(a => a.Email, new { @name = "email", @id = "email", @type = "email", @placeholder = "Email" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </div>                                      
                                        <div class=""form-group form-button"">
                                            <input type=""submit"" name=""signup"" id=""signup"" class=""form-submit"" value=""THÊM"" />
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
#line 151 "C:\Users\WIN\Desktop\WebBanLapTop\base\WebLapTop\Views\Admin\Kho.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </section>\r\n");
                WriteLiteral(@"                </div>
            </div>
        </div>
    </div>

    <script>
        // Get the modal
        var modal = document.getElementById(""myModal"");

        // Get the button that opens the modal
        var btn = document.getElementById(""myBtn"");

        // Get the <span> element that closes the modal
        var span = document.getElementsByClassName(""close"")[0];

        // When the user clicks the button, open the modal
        btn.onclick = function () {
            modal.style.display = ""block"";
        }

        // When the user clicks on <span> (x), close the modal
        span.onclick = function () {
            modal.style.display = ""none"";
        }

        // When the user clicks anywhere outside of the modal, close it
        window.onclick = function (event) {
            if (event.target == modal) {
                modal.style.display = ""none"";
            }
        }
    </script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <td>Mã Kho</td>\r\n            <td>Tên kho</td>\r\n            <td>Địa chỉ</td>\r\n            <td>SĐT</td>            \r\n            <td>Email</td>\r\n");
            WriteLiteral("            <td>Xóa</td>\r\n            <td>Sửa</td>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 209 "C:\Users\WIN\Desktop\WebBanLapTop\base\WebLapTop\Views\Admin\Kho.cshtml"
         foreach (var item in lstK)
        {            

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 212 "C:\Users\WIN\Desktop\WebBanLapTop\base\WebLapTop\Views\Admin\Kho.cshtml"
                   Write(item.MaKho);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 213 "C:\Users\WIN\Desktop\WebBanLapTop\base\WebLapTop\Views\Admin\Kho.cshtml"
                   Write(item.TenKho);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 214 "C:\Users\WIN\Desktop\WebBanLapTop\base\WebLapTop\Views\Admin\Kho.cshtml"
                   Write(item.DiaChi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 215 "C:\Users\WIN\Desktop\WebBanLapTop\base\WebLapTop\Views\Admin\Kho.cshtml"
                   Write(item.Sdt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 216 "C:\Users\WIN\Desktop\WebBanLapTop\base\WebLapTop\Views\Admin\Kho.cshtml"
                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83ed6c119acebf2c12b317ba35a79ee7e237d36e18747", async() => {
                WriteLiteral("Sửa");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8140, "~/Admin_layout/", 8140, 15, true);
#nullable restore
#line 219 "C:\Users\WIN\Desktop\WebBanLapTop\base\WebLapTop\Views\Admin\Kho.cshtml"
AddHtmlAttributeValue("", 8155, item.MaKho, 8155, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83ed6c119acebf2c12b317ba35a79ee7e237d36e20299", async() => {
                WriteLiteral("Xóa");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8215, "~/Admin_layout/", 8215, 15, true);
#nullable restore
#line 220 "C:\Users\WIN\Desktop\WebBanLapTop\base\WebLapTop\Views\Admin\Kho.cshtml"
AddHtmlAttributeValue("", 8230, item.MaKho, 8230, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 222 "C:\Users\WIN\Desktop\WebBanLapTop\base\WebLapTop\Views\Admin\Kho.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebLapTop.Models.Kho> Html { get; private set; }
    }
}
#pragma warning restore 1591
