#pragma checksum "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f25e233c3a7ac2143d3a7e3e1f3f84a6cebdcaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_NhaCungCap), @"mvc.1.0.view", @"/Views/Admin/NhaCungCap.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f25e233c3a7ac2143d3a7e3e1f3f84a6cebdcaf", @"/Views/Admin/NhaCungCap.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4759a366bcb97d677f53bfbebf25a1cc2a4b5274", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_NhaCungCap : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebLapTop.Models.Nhacungcap>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("register-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("register-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "load_DataNCC", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NhaCungCap_xoa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
  
    ViewData["Title"] = "NhaCungCap";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    var lstCC = ViewData["dsNCC"] as List<Nhacungcap>;

    var update = ViewData["employee"] as Nhacungcap;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>DANH SÁCH NHÀ CUNG CẤP</h3>\r\n");
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f25e233c3a7ac2143d3a7e3e1f3f84a6cebdcaf6335", async() => {
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
        .cs {
            width: 176px;
            height: 34px;
            padding: 0px;
            margin: 10px 10px 20px 10px;
            border-top-left-radius: 20px;
            border-top-right-radius: 20px;
            border-bottom-left-radius: 20px;
            border-bottom-right-radius: 20px;
            background-color: chartreuse;
        }
/* Modal Content */
.modal-content {
  position");
                WriteLiteral(@": relative;
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

.modal-body {
    padding: 2px 16px;

}

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f25e233c3a7ac2143d3a7e3e1f3f84a6cebdcaf9312", async() => {
                WriteLiteral("\r\n\r\n");
                WriteLiteral(@"
    <!-- Trigger/Open The Modal -->
    <button id=""myBtn"" class=""cs"">Thêm Nhà Cung Cấp</button>

    <!-- The Modal -->

    <div id=""myModal"" class=""modal"">

        <!-- Modal content -->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <span class=""close"">&times;</span>
                <h2>THÊM NHÀ CUNG CẤP</h2>
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
#line 131 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
                                     using (Html.BeginForm("NhaCungCap", "Admin", FormMethod.Post))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
                                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 134 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
                                   Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f25e233c3a7ac2143d3a7e3e1f3f84a6cebdcaf11264", async() => {
                    WriteLiteral("\r\n");
                    WriteLiteral(@"                                            <div class=""form-group"">
                                                <label for=""email""><i class=""zmdi zmdi-email""></i></label>
                                                <label for=""fname"" style=""padding-right:36px"">Tên nhà cung cấp: </label>
                                                ");
#nullable restore
#line 144 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
                                           Write(Html.TextBoxFor(a => a.TenNcc, new { @name = "name", @id = "name", @type = "text", @placeholder = "Tên nhà cung cấp" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                            </div>
                                            <div class=""form-group"">
                                                <label for=""pass""><i class=""zmdi zmdi-lock""></i></label>
                                                <label for=""fname"" style=""padding-right:116px"">Địa chỉ: </label>
                                                ");
#nullable restore
#line 149 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
                                           Write(Html.PasswordFor(a => a.DiaChi, new { @name = "address", @id = "address", @type = "text", @placeholder = "Địa chỉ" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                            </div>
                                            <div class=""form-group"">
                                                <label for=""phone""><i class=""zmdi zmdi-account-box-phone""></i></label>
                                                <label for=""fname"" style=""padding-right:72px"">Số điện thoại: </label>
                                                ");
#nullable restore
#line 154 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
                                           Write(Html.TextBoxFor(a => a.Sdt, new { @name = "phone", @id = "phone", @type = "number", @placeholder = "Số điện thoại" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                            </div>
                                            <div class=""form-group"">
                                                <label for=""address""><i class=""zmdi zmdi-my-location""></i></label>
                                                <label for=""fname"" style=""padding-right:124px"">Email: </label>
                                                ");
#nullable restore
#line 159 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
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
#line 165 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </section>\r\n");
                WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 176 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
     if (update != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("<div id=\"updateModal\" class=\"modal\" style=\"display:block\">\r\n\r\n            <!-- Modal content -->\r\n            <div class=\"modal-content\">\r\n                <div class=\"modal-header\">\r\n                    <span class=\"closeu\">&times;</span>\r\n");
                WriteLiteral("                    <h2>SỬA NHÀ CUNG CẤP</h2>\r\n                </div>\r\n                <div class=\"modal-body\">\r\n");
                WriteLiteral(@"                    <div class=""main"">

                        <!-- Add nhân viên form -->
                        <section class=""signup"">
                            <div class=""container-1"">
                                <div class=""signup-content"">
                                    <div class=""signup-form"">
");
#nullable restore
#line 197 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
                                         using (Html.BeginForm("NhaCungCap_sua", "Admin", FormMethod.Post))
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 199 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
                                       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 200 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
                                       Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f25e233c3a7ac2143d3a7e3e1f3f84a6cebdcaf18793", async() => {
                    WriteLiteral(@"
                                                <div class=""form-group"">
                                                    <label for=""email""><i class=""zmdi zmdi-email""></i></label>
                                                    <label for=""fname"" style=""padding-right:36px"">Mã nhà cung cấp: </label>
                                                    <input name=""MaNcc"" id=""MaNcc"" type=""text""");
                    BeginWriteAttribute("value", " value=\"", 8734, "\"", 8755, 1);
#nullable restore
#line 205 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
WriteAttributeValue("", 8742, update.MaNcc, 8742, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" disabled />
                                                </div>
                                                <div class=""form-group"">
                                                    <label for=""email""><i class=""zmdi zmdi-email""></i></label>
                                                    <label for=""fname"" style=""padding-right:36px"">Tên nhà cung cấp: </label>
                                                    <input name=""TenNcc"" id=""TenNcc"" type=""text""");
                    BeginWriteAttribute("value", " value=\"", 9234, "\"", 9256, 1);
#nullable restore
#line 210 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
WriteAttributeValue("", 9242, update.TenNcc, 9242, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" />
                                                </div>
                                                <div class=""form-group"">
                                                    <label for=""pass""><i class=""zmdi zmdi-lock""></i></label>
                                                    <label for=""fname"" style=""padding-right:116px"">Địa chỉ: </label>
                                                    <input name=""DiaChi"" id=""DiaChi"" type=""text""");
                    BeginWriteAttribute("value", " value=\"", 9716, "\"", 9738, 1);
#nullable restore
#line 215 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
WriteAttributeValue("", 9724, update.DiaChi, 9724, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" />
                                                </div>
                                                <div class=""form-group"">
                                                    <label for=""phone""><i class=""zmdi zmdi-account-box-phone""></i></label>
                                                    <label for=""fname"" style=""padding-right:72px"">Số điện thoại: </label>
                                                    <input name=""Sdt"" id=""Sdt"" type=""number""");
                    BeginWriteAttribute("value", " value=\"", 10213, "\"", 10232, 1);
#nullable restore
#line 220 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
WriteAttributeValue("", 10221, update.Sdt, 10221, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" />
                                                </div>
                                                <div class=""form-group"">
                                                    <label for=""address""><i class=""zmdi zmdi-my-location""></i></label>
                                                    <label for=""fname"" style=""padding-right:124px"">Email: </label>
                                                    <input name=""Email"" id=""Email"" type=""text""");
                    BeginWriteAttribute("value", " value=\"", 10698, "\"", 10719, 1);
#nullable restore
#line 225 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
WriteAttributeValue("", 10706, update.Email, 10706, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                                                </div>\r\n\r\n                                                <input type=\"text\" name=\"MaNcc\" style=\"display:none\"");
                    BeginWriteAttribute("value", " value=\"", 10883, "\"", 10904, 1);
#nullable restore
#line 228 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
WriteAttributeValue("", 10891, update.MaNcc, 10891, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" />
                                                <div class=""form-group form-button"">
                                                    <input type=""submit"" name=""signup"" id=""signup"" class=""form-submit"" value=""Cập nhật"" />
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
#line 233 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </section>\r\n");
                WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 243 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <script>
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
    <script>
        // Get the modal
        var modal_sua = document.getElementById(""updateModal"");

        var btn_sua = document.");
                WriteLiteral(@"getElementById(""btn_sua"");

        btn_sua.onclick = function () {
            modal_sua.style.display = ""block"";
        }
        //Get the <span> element that closes the modal
        var span_x = document.getElementsByClassName(""closeu"")[0];


        //// When the user clicks on <span> (x), close the modal
        span_x.onclick = function () {
            modal_sua.style.display = ""none"";
            //}

            // When the user clicks anywhere outside of the modal, close it
            window.onclick = function (event) {
                if (event.target == modal_sua) {
                    modal_sua.style.display = ""none"";
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
            WriteLiteral(@"
<style>
    .table-bordered: {
        padding: 10px;
    }

    .mau {
        background-color: #66d9ff;
    }
</style>
<table class=""table table-bordered"">
    <thead>
        <tr class=""mau"">
            <td>MÃ NHÀ CUNG CẤP</td>
            <td>TÊN NHÀ CUNG CẤP</td>
            <td>ĐỊA CHỈ</td>
            <td>SĐT</td>
            <td>EMAIL</td>
");
            WriteLiteral("            <td>SỬA</td>\r\n            <td>XÓA</td>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 325 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
         foreach (var item in lstCC)
        {
            if (item.TrangThai == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 330 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
                   Write(item.MaNcc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 331 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
                   Write(item.TenNcc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 332 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
                   Write(item.DiaChi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 333 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
                   Write(item.Sdt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 334 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                    <td><button>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f25e233c3a7ac2143d3a7e3e1f3f84a6cebdcaf31154", async() => {
                WriteLiteral("Sửa");
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
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 337 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
                                                                                                  WriteLiteral(item.MaNcc);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</button></td>\r\n                    <td><button>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f25e233c3a7ac2143d3a7e3e1f3f84a6cebdcaf33809", async() => {
                WriteLiteral("Xóa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 338 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
                                                                                                    WriteLiteral(item.MaNcc);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</button></td>\r\n                </tr>\r\n");
#nullable restore
#line 340 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\NhaCungCap.cshtml"
            }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebLapTop.Models.Nhacungcap> Html { get; private set; }
    }
}
#pragma warning restore 1591
