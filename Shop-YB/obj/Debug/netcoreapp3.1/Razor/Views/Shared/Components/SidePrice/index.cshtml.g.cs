#pragma checksum "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Views\Shared\Components\SidePrice\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "223736a68ffaaa858b69772e4be7a11dd37ef2bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SidePrice_index), @"mvc.1.0.view", @"/Views/Shared/Components/SidePrice/index.cshtml")]
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
#line 5 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\_ViewImports.cshtml"
using ShopYB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"223736a68ffaaa858b69772e4be7a11dd37ef2bc", @"/Views/Shared/Components/SidePrice/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4154d81c4ef95649ca65e11b2835c27b5469a147", @"/_ViewImports.cshtml")]
    public class Views_Shared_Components_SidePrice_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Views\Shared\Components\SidePrice\index.cshtml"
   
    var totalPrice = ViewBag.TotalPrice;
    var quantity = ViewBag.Quantity;
    var shipping = ViewBag.Shipping;
    var totalPriceWithShipping = shipping + totalPrice;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row-fluid"">
  
        <div class=""panel panel-default panelPrice"">
            <div class=""panel-heading"">
                Price
            </div>
            <div class=""panel-body"">
                <div class=""row-fluid"">
                    <div class=""span6"">
                        Total Price(");
#nullable restore
#line 17 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Views\Shared\Components\SidePrice\index.cshtml"
                               Write(quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                    </div>\r\n                    <div class=\"span6\">\r\n                        $");
#nullable restore
#line 20 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Views\Shared\Components\SidePrice\index.cshtml"
                    Write(totalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <hr class=""soft"" />
                <div class=""row-fluid"">

                    <div class=""span6"">
                        Dicount
                    </div>
                    <div class=""span6"">
                        $0
                    </div>
                </div>
                <hr class=""soft"" />

                <div class=""row-fluid"">

                    <div class=""span6"">
                        Shipping Pay
                    </div>
                    <div class=""span6"">
");
#nullable restore
#line 41 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Views\Shared\Components\SidePrice\index.cshtml"
                         if (shipping == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>Free</span>\r\n");
#nullable restore
#line 44 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Views\Shared\Components\SidePrice\index.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>$");
#nullable restore
#line 48 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Views\Shared\Components\SidePrice\index.cshtml"
                              Write(shipping);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 49 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Views\Shared\Components\SidePrice\index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
                <hr class=""soft"" />

                <br />

                <div class=""row-fluid"">

                    <div class=""span12 "">
                        <center>
                            <input type=""hidden""");
            BeginWriteAttribute("value", " value=\"", 1810, "\"", 1841, 1);
#nullable restore
#line 60 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Views\Shared\Components\SidePrice\index.cshtml"
WriteAttributeValue("", 1818, totalPriceWithShipping, 1818, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <span");
            BeginWriteAttribute("class", " class=\"", 1880, "\"", 1888, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                Total Price:\r\n                            </span>\r\n                            <span id=\"total\" class=\"totalPrice\">");
#nullable restore
#line 64 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Views\Shared\Components\SidePrice\index.cshtml"
                                                           Write(totalPriceWithShipping);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </center>\r\n                    </div>\r\n");
            WriteLiteral("                </div>\r\n\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n    \r\n\r\n<script>\r\n\r\n  \r\n \r\n\r\n</script>");
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
