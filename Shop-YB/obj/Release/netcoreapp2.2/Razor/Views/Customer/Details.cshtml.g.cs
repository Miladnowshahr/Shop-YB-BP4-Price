#pragma checksum "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Views\Customer\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9044c689baf1a2017b38cbe5028b79fd4256d47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Details), @"mvc.1.0.view", @"/Views/Customer/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Details.cshtml", typeof(AspNetCore.Views_Customer_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9044c689baf1a2017b38cbe5028b79fd4256d47", @"/Views/Customer/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4154d81c4ef95649ca65e11b2835c27b5469a147", @"/_ViewImports.cshtml")]
    public class Views_Customer_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Views\Customer\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
            BeginContext(96, 649, true);
            WriteLiteral(@"
<div class="""" style=""background-color:white;text-align:justify;padding:10px 20px"">

    <div class=""box"" style=""box-shadow:0px 0px"">
        <div class=""row"">
            <div class=""box-header"">
                <h3> جزییات سفارش</h3>
            </div>

        </div>
    </div>
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th scope=""col"">نام محصول</th>
                <th scope=""col"">قیمت</th>
                <th scope=""col"">تعداد</th>
                <th scope=""col"">جمع</th>
                <th scope=""col"">آدرس</th>



            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 31 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Views\Customer\Details.cshtml"
             foreach (var item in (IEnumerable<ShopYB.Models.InvoiceDetails>)ViewBag.InvoiceDetails)
            {


#line default
#line hidden
            BeginContext(864, 60, true);
            WriteLiteral("                <tr>\r\n\r\n                    <th scope=\"row\">");
            EndContext();
            BeginContext(925, 17, false);
#line 36 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Views\Customer\Details.cshtml"
                               Write(item.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(942, 31, true);
            WriteLiteral("</th>\r\n                    <td>");
            EndContext();
            BeginContext(974, 10, false);
#line 37 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Views\Customer\Details.cshtml"
                   Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(984, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1016, 13, false);
#line 38 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Views\Customer\Details.cshtml"
                   Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1029, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1062, 27, false);
#line 39 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Views\Customer\Details.cshtml"
                    Write(item.Quantity * @item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1090, 68, true);
            WriteLiteral("</td>\r\n                    <td>Address</td>\r\n                </tr>\r\n");
            EndContext();
#line 42 "E:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Views\Customer\Details.cshtml"

            }

#line default
#line hidden
            BeginContext(1175, 40, true);
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>");
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
