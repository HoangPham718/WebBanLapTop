#pragma checksum "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\HoaDonDaDuyet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d13e6698c475e36e1bf371c7c74deb410fc384c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_HoaDonDaDuyet), @"mvc.1.0.view", @"/Views/Admin/HoaDonDaDuyet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d13e6698c475e36e1bf371c7c74deb410fc384c", @"/Views/Admin/HoaDonDaDuyet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4759a366bcb97d677f53bfbebf25a1cc2a4b5274", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_HoaDonDaDuyet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebLapTop.Models.Hoadon>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DaGiaotHoaDon", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HuyHoaDon", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\HoaDonDaDuyet.cshtml"
  
    ViewData["Title"] = "HoaDonDaDuyet";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    var lstHD = ViewData["dsHD"] as List<Hoadon>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>HÓA ĐƠN ĐÃ DUYỆT</h3>\r\n\r\n");
            WriteLiteral("\r\n<style>\r\n    .table-bordered: {\r\n        padding: 10px;\r\n    }\r\n\r\n    .mau {\r\n        background-color: #66d9ff;\r\n    }\r\n</style>\r\n        \r\n\r\n");
            WriteLiteral("            <table class=\"table table-bordered\">\r\n                <thead>\r\n                    <tr class=\"mau\">\r\n                        <td>MÃ HÓA ĐƠN</td>\r\n");
            WriteLiteral(@"                        <td>MÃ KHÁCH HÀNG</td>
                        <td>NGÀY LẬP</td>
                        <td>NGÀY GIAO</td>
                        <td>TÊN NGƯỜI NHẬN</td>
                        <td>SĐT NGƯỜI NHẬN</td>
                        <td>ĐỊA CHỈ</td>
                        <td>GHI CHÚ</td>
                        <td>DUYỆT</td>
                        <td>HỦY</td>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 42 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\HoaDonDaDuyet.cshtml"
                     foreach (var item in lstHD)
                    {
                        if (item.shipping == 0 || item.shipping == 2)
                        {
                            if (item.shipping == 2)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr >\r\n                        <td>");
#nullable restore
#line 49 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\HoaDonDaDuyet.cshtml"
                       Write(item.MaHd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                        <td>");
#nullable restore
#line 51 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\HoaDonDaDuyet.cshtml"
                       Write(item.MaKh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 52 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\HoaDonDaDuyet.cshtml"
                       Write(item.NgayLap);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 53 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\HoaDonDaDuyet.cshtml"
                       Write(item.NgayGiao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 54 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\HoaDonDaDuyet.cshtml"
                       Write(item.TenNn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 55 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\HoaDonDaDuyet.cshtml"
                       Write(item.Sdtnn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 56 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\HoaDonDaDuyet.cshtml"
                       Write(item.DiaChi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 57 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\HoaDonDaDuyet.cshtml"
                       Write(item.shippingNote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                        <td><button>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d13e6698c475e36e1bf371c7c74deb410fc384c8300", async() => {
                WriteLiteral("Đang Giao");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\HoaDonDaDuyet.cshtml"
                                                                                                       WriteLiteral(item.MaHd);

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
            WriteLiteral("</button></td>\r\n                        <td><button>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d13e6698c475e36e1bf371c7c74deb410fc384c10970", async() => {
                WriteLiteral("Hủy");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\HoaDonDaDuyet.cshtml"
                                                                                                   WriteLiteral(item.MaHd);

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
            WriteLiteral("</button></td>\r\n                    </tr>\r\n");
#nullable restore
#line 63 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\HoaDonDaDuyet.cshtml"
                            }
                            if (item.shipping == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 67 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\HoaDonDaDuyet.cshtml"
                                   Write(item.MaHd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                                    <td>");
#nullable restore
#line 69 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\HoaDonDaDuyet.cshtml"
                                   Write(item.MaKh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 70 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\HoaDonDaDuyet.cshtml"
                                   Write(item.NgayLap);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 71 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\HoaDonDaDuyet.cshtml"
                                   Write(item.NgayGiao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 72 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\HoaDonDaDuyet.cshtml"
                                   Write(item.TenNn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 73 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\HoaDonDaDuyet.cshtml"
                                   Write(item.Sdtnn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 74 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\HoaDonDaDuyet.cshtml"
                                   Write(item.DiaChi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 75 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\HoaDonDaDuyet.cshtml"
                                   Write(item.shippingNote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                                    <td><button>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d13e6698c475e36e1bf371c7c74deb410fc384c16424", async() => {
                WriteLiteral("Đã Giao");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\HoaDonDaDuyet.cshtml"
                                                                                                                   WriteLiteral(item.MaHd);

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
            WriteLiteral("</button></td>\r\n                                    <td><button><a href=\"#\">Hủy </a></button></td>\r\n                                </tr>\r\n");
#nullable restore
#line 81 "E:\Github\WebBanLapTop\WebLapTop\WebLapTop\Views\Admin\HoaDonDaDuyet.cshtml"
                            }

                        }

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebLapTop.Models.Hoadon> Html { get; private set; }
    }
}
#pragma warning restore 1591