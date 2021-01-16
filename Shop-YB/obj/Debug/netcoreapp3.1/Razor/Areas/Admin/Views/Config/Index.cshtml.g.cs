#pragma checksum "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Config\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7182c758d818c76b9b45e66c6cba416863b3477"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Config_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Config/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7182c758d818c76b9b45e66c6cba416863b3477", @"/Areas/Admin/Views/Config/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4154d81c4ef95649ca65e11b2835c27b5469a147", @"/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Config_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Config>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "config", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary pull-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Config", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Config\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    var image = Model?.Logo ?? "no-image.png";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<section class=\"content-header\">\r\n    <h1>\r\n        Configuration Properties\r\n    </h1>\r\n</section>\r\n\r\n\r\n\r\n\r\n\r\n<section class=\"content\">\r\n\r\n");
#nullable restore
#line 21 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Config\Index.cshtml"
     if (TempData["Error"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-xs-12\">\r\n                <div class=\"alert alert-danger\">\r\n                    <h4><i class=\"icon fa fa-ban\">Failed</i></h4>\r\n                    ");
#nullable restore
#line 27 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Config\Index.cshtml"
               Write(TempData["Error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 31 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Config\Index.cshtml"


    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    \r\n\r\n");
#nullable restore
#line 37 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Config\Index.cshtml"
     if (Model != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""box"">
                    <div class=""box-header"">
                        <h3 class=""box-title"">Properties</h3>
                    </div>
                    <!-- /.box-header -->
                    <div class=""box-body"" style=""text-align:center;line-height:50px;font-size:x-large"">
                        <div style=""text-align:center"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b7182c758d818c76b9b45e66c6cba416863b34777827", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1170, "~/Logo/", 1170, 7, true);
#nullable restore
#line 48 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Config\Index.cshtml"
AddHtmlAttributeValue("", 1177, image, 1177, 6, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n\r\n\r\n                        <div>\r\n                            <span><b>نام فروشگاه</b> :</span>\r\n                            <span>");
#nullable restore
#line 54 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Config\Index.cshtml"
                             Write(Model?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n\r\n                        <div style=\"direction:rtl\">\r\n                            <span><b>ایمیل فروشگاه</b> :</span>\r\n                            <span>");
#nullable restore
#line 59 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Config\Index.cshtml"
                             Write(Model?.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n\r\n                        <div>\r\n                            <span><b>تلفن فروشگاه</b> :</span>\r\n                            <span>");
#nullable restore
#line 64 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Config\Index.cshtml"
                             Write(Model?.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n\r\n                        <div>\r\n                            <span><b>تلفن همراه فروشگاه</b> :</span>\r\n                            <span>");
#nullable restore
#line 69 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Config\Index.cshtml"
                             Write(Model?.Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n\r\n                        <div>\r\n                            <span><b>آدرس فروشگاه</b> :</span>\r\n                            <span>");
#nullable restore
#line 74 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Config\Index.cshtml"
                             Write(Model?.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n\r\n                        <div>\r\n                            <span><b>شماره ثبت فروشگاه</b> :</span>\r\n                            <span>");
#nullable restore
#line 79 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Config\Index.cshtml"
                             Write(Model?.RecordNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n\r\n                        <div>\r\n                            <span><b>توضیحات</b> :</span>\r\n                            ");
#nullable restore
#line 84 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Config\Index.cshtml"
                       Write(Html.Raw(Model?.Describe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7182c758d818c76b9b45e66c6cba416863b347712483", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Config\Index.cshtml"
                                                                       WriteLiteral(Model?.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <!-- /.box-body -->\r\n                    <!-- /.box -->\r\n               \r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 96 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Config\Index.cshtml"
    }

    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-lg-6 col-lg-offset-3"">
                <div class=""alert alert-info text-center"">
                    <h3> تنظیمات اعمال نشده است </h3>
                    <p>
                        لطفا برای ایجاد بخش تنظیمات دکمه ایجاد را کلیک کنید
                    </p>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7182c758d818c76b9b45e66c6cba416863b347715723", async() => {
                WriteLiteral(" ایجاد ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 111 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Config\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Config> Html { get; private set; }
    }
}
#pragma warning restore 1591