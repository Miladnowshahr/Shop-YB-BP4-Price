#pragma checksum "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Views\Shared\Components\SlideShow\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9ec05a525dc46f8b4f1cab17c13abbef9e17da4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SlideShow_index), @"mvc.1.0.view", @"/Views/Shared/Components/SlideShow/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9ec05a525dc46f8b4f1cab17c13abbef9e17da4", @"/Views/Shared/Components/SlideShow/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4154d81c4ef95649ca65e11b2835c27b5469a147", @"/_ViewImports.cshtml")]
    public class Views_Shared_Components_SlideShow_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div id=\"slideShowCarousel\" class=\"carousel slide carousel-fade boxShadow\" data-ride=\"carousel\" >\r\n    <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 5 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Views\Shared\Components\SlideShow\index.cshtml"
          
            var index = 0;

            foreach (var slide in (IEnumerable<SlideShow>)Model)
            {



#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 284, "\"", 353, 4);
            WriteAttributeValue("", 292, "carousel-item", 292, 13, true);
#nullable restore
#line 12 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Views\Shared\Components\SlideShow\index.cshtml"
WriteAttributeValue(" ", 305, index == 0 ? "active" : "", 306, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 335, "hero__item", 336, 11, true);
            WriteAttributeValue(" ", 346, "set-bg", 347, 7, true);
            EndWriteAttribute();
            WriteLiteral(" data-setbg=\"SlideShows/");
#nullable restore
#line 12 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Views\Shared\Components\SlideShow\index.cshtml"
                                                                                                             Write(slide.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    <div class=\"hero__text\">\r\n                        <span>خرید بی واسطه</span>\r\n\r\n");
            WriteLiteral("                        <h2>طبیعی %100</h2>\r\n                        <p>ارسال به سراسر ایران</p>\r\n                        <a href=\"#\" class=\"primary-btn\">همین الان خرید کنید</a>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 29 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Views\Shared\Components\SlideShow\index.cshtml"
                        
                index++;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <a class=""carousel-control-prev"" href=""#slideShowCarousel"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next "" href=""#slideShowCarousel"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>
           
");
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
