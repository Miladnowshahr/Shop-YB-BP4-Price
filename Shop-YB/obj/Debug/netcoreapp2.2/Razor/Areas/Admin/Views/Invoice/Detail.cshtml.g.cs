#pragma checksum "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Invoice\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2775d2531c3c28227a82b124b248643adb96963"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Invoice_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Invoice/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Invoice/Detail.cshtml", typeof(AspNetCore.Areas_Admin_Views_Invoice_Detail))]
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
#line 5 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\_ViewImports.cshtml"
using ShopYB.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2775d2531c3c28227a82b124b248643adb96963", @"/Areas/Admin/Views/Invoice/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4154d81c4ef95649ca65e11b2835c27b5469a147", @"/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Invoice_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Invoice>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "invoice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "process", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "InvoicePdf", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Invoice\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    int TotalPrice = 0;

#line default
#line hidden
            BeginContext(147, 94, true);
            WriteLiteral("\r\n    <section class=\"content-header\">\r\n        <h1>\r\n            فاکتور\r\n            <small>#");
            EndContext();
            BeginContext(242, 8, false);
#line 11 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Invoice\Detail.cshtml"
               Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(250, 511, true);
            WriteLiteral(@"</small>
        </h1>
        <ol class=""breadcrumb"">
            <li><a href=""#""><i class=""fa fa-dashboard""></i> Home</a></li>
            <li><a href=""#"">Examples</a></li>
            <li class=""active"">Invoice</li>
        </ol>
    </section>
<section class=""invoice"">
    <!-- title row -->
    <div class=""row"">
        <div class=""col-xs-12"">
            <h2 class=""page-header"">
                <i class=""fa fa-globe""></i> فروشگاه گیل شرق.
                <small class=""pull-right"">Date: ");
            EndContext();
            BeginContext(762, 13, false);
#line 25 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Invoice\Detail.cshtml"
                                           Write(Model.Created);

#line default
#line hidden
            EndContext();
            BeginContext(775, 630, true);
            WriteLiteral(@"</small>
            </h2>
        </div>
        <!-- /.col -->
    </div>
    <!-- info row -->
    <div class=""row invoice-info"">
        <div class=""col-sm-4 invoice-col"">
            From
            <address>
                <strong>Admin, Inc.</strong><br>
                795 Folsom Ave, Suite 600<br>
                San Francisco, CA 94107<br>
                Phone: (804) 123-5432<br>
                Email: info@almasaeedstudio.com
            </address>
        </div>
        <!-- /.col -->
        <div class=""col-sm-4 invoice-col"">
            To
            <address>
                <strong>");
            EndContext();
            BeginContext(1406, 22, false);
#line 46 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Invoice\Detail.cshtml"
                   Write(Model.Account.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1428, 31, true);
            WriteLiteral("</strong><br>\r\n                ");
            EndContext();
            BeginContext(1460, 27, false);
#line 47 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Invoice\Detail.cshtml"
           Write(Model.Ships.Address.Zipcode);

#line default
#line hidden
            EndContext();
            BeginContext(1487, 6, true);
            WriteLiteral(" ,  , ");
            EndContext();
            BeginContext(1494, 28, false);
#line 47 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Invoice\Detail.cshtml"
                                             Write(Model.Ships.Address.Address1);

#line default
#line hidden
            EndContext();
            BeginContext(1522, 22, true);
            WriteLiteral("<br>\r\n                ");
            EndContext();
            BeginContext(1545, 24, false);
#line 48 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Invoice\Detail.cshtml"
           Write(Model.Ships.Address.City);

#line default
#line hidden
            EndContext();
            BeginContext(1569, 29, true);
            WriteLiteral("<br>\r\n                Phone: ");
            EndContext();
            BeginContext(1599, 25, false);
#line 49 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Invoice\Detail.cshtml"
                  Write(Model.Ships.Address.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1624, 29, true);
            WriteLiteral("<br>\r\n                Email: ");
            EndContext();
            BeginContext(1654, 30, false);
#line 50 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Invoice\Detail.cshtml"
                  Write(ViewBag.Invoices.Account.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1684, 134, true);
            WriteLiteral("\r\n            </address>\r\n        </div>\r\n        <!-- /.col -->\r\n        <div class=\"col-sm-4 invoice-col\">\r\n            <b>Invoice #");
            EndContext();
            BeginContext(1819, 19, false);
#line 55 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Invoice\Detail.cshtml"
                   Write(ViewBag.Invoices.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1838, 758, true);
            WriteLiteral(@"</b><br>
            <br>
            <b>Order ID:</b> 4F3S8J<br>
            <b>Payment Due:</b> 2/22/2014<br>
            <b>Account:</b> 968-34567
        </div>
        <!-- /.col -->
    </div>
    <!-- /.row -->
    <!-- Table row -->
    <div class=""row"">
        <div class=""col-xs-12 table-responsive"">
            <table class=""table table-striped"">
                <thead>
                    <tr>

                        <th>Product</th>
                        <th>Serial #</th>
                        <th>Qty</th>
                        <th>Price</th>

                        <th>Description</th>
                        <th>Subtotal</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 81 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Invoice\Detail.cshtml"
                     foreach (var item in Model.InvoiceDetails)
                    {
                        TotalPrice += item.Price * item.Quantity;

#line default
#line hidden
            BeginContext(2751, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(2814, 17, false);
#line 85 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Invoice\Detail.cshtml"
                           Write(item.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2831, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2871, 15, false);
#line 86 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Invoice\Detail.cshtml"
                           Write(item.Product.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2886, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2926, 13, false);
#line 87 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Invoice\Detail.cshtml"
                           Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(2939, 40, true);
            WriteLiteral("</td>\r\n                            <td>$");
            EndContext();
            BeginContext(2980, 10, false);
#line 88 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Invoice\Detail.cshtml"
                            Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2990, 95, true);
            WriteLiteral("</td>\r\n                            <td>Description ....</td>\r\n                            <td>$");
            EndContext();
            BeginContext(3087, 26, false);
#line 90 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Invoice\Detail.cshtml"
                             Write(item.Quantity * item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(3114, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 92 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Invoice\Detail.cshtml"

                    }

#line default
#line hidden
            BeginContext(3177, 224, true);
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n        <!-- /.col -->\r\n    </div>\r\n    <!-- /.row -->\r\n\r\n    <div class=\"row\">\r\n        <!-- accepted payments column -->\r\n        <div class=\"col-xs-6\">\r\n\r\n");
            EndContext();
#line 106 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Invoice\Detail.cshtml"
              
                var payment = (PayMethod)ViewBag.Payment;


            

#line default
#line hidden
            BeginContext(3495, 50, true);
            WriteLiteral("            <p class=\"lead\">Payment Methods:<span>");
            EndContext();
            BeginContext(3546, 14, false);
#line 111 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Invoice\Detail.cshtml"
                                             Write(payment.Method);

#line default
#line hidden
            EndContext();
            BeginContext(3560, 13, true);
            WriteLiteral("</span></p>\r\n");
            EndContext();
            BeginContext(3874, 419, true);
            WriteLiteral(@"
            <p class=""text-muted well well-sm no-shadow"" style=""margin-top: 10px;"">
                Etsy doostang zoodles disqus groupon greplin oooj voxy zoodles, weebly ning heekya handango imeem plugg
                dopplr jibjab, movity jajah plickers sifteo edmodo ifttt zimbra.
            </p>
        </div>
        <!-- /.col -->
        <div class=""col-xs-6"">
            <p class=""lead"">Amount Due ");
            EndContext();
            BeginContext(4294, 19, false);
#line 124 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Invoice\Detail.cshtml"
                                  Write(Model.Payments.Date);

#line default
#line hidden
            EndContext();
            BeginContext(4313, 249, true);
            WriteLiteral("</p>\r\n\r\n            <div class=\"table-responsive\">\r\n                <table class=\"table\">\r\n                    <tbody>\r\n                        <tr>\r\n                            <th style=\"width:50%\">Subtotal:</th>\r\n                            <td>$");
            EndContext();
            BeginContext(4563, 10, false);
#line 131 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Invoice\Detail.cshtml"
                            Write(TotalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(4573, 302, true);
            WriteLiteral(@"</td>
                        </tr>

                        <tr>
                            <th>Shipping:</th>
                            <td>$ Free</td>
                        </tr>
                        <tr>
                            <th>Total:</th>
                            <td>$");
            EndContext();
            BeginContext(4876, 10, false);
#line 140 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Invoice\Detail.cshtml"
                            Write(TotalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(4886, 409, true);
            WriteLiteral(@"</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
       
    </div>
    <!-- /.row -->
    <!-- this row will not appear when printing -->
    <div class=""row no-print"">
        <div class=""col-xs-12"">
            <a href=""invoice-print.html"" target=""_blank"" class=""btn btn-default""><i class=""fa fa-print""></i> Print</a>
");
            EndContext();
#line 153 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Invoice\Detail.cshtml"
             if (ViewBag.Invoices.Status == 1)
            {



#line default
#line hidden
            BeginContext(5362, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(5370, 352, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2775d2531c3c28227a82b124b248643adb9696317283", async() => {
                BeginContext(5453, 48, true);
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5501, "\"", 5529, 1);
#line 158 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Invoice\Detail.cshtml"
WriteAttributeValue("", 5509, ViewBag.Invoices.Id, 5509, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5530, 185, true);
                WriteLiteral(">\r\n\r\n                <button type=\"submit\" class=\"btn btn-success pull-right\">\r\n                    <i class=\"fa fa-credit-card\"></i> Submit Payment\r\n                </button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5722, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 164 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Invoice\Detail.cshtml"
            }

#line default
#line hidden
            BeginContext(5739, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(5751, 254, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2775d2531c3c28227a82b124b248643adb9696320476", async() => {
                BeginContext(5856, 145, true);
                WriteLiteral(" <button type=\"button\" class=\"btn btn-primary pull-right\" style=\"margin-right: 5px;\">\r\n    <i class=\"fa fa-download\"></i> Generate PDF\r\n</button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 165 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Invoice\Detail.cshtml"
                                                                                   WriteLiteral(ViewBag.Invoices.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(6005, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(6193, 38, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Invoice> Html { get; private set; }
    }
}
#pragma warning restore 1591
