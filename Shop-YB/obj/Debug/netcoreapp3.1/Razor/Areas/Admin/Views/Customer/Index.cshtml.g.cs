#pragma checksum "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecf01f4640629cba689092815772c4cc8dfefe06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Customer_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Customer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecf01f4640629cba689092815772c4cc8dfefe06", @"/Areas/Admin/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4154d81c4ef95649ca65e11b2835c27b5469a147", @"/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Customer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<section class=\"content-header\">\r\n    <h1>\r\n       Customer\r\n    </h1>\r\n</section>\r\n\r\n\r\n\r\n\r\n\r\n<section class=\"content\">\r\n\r\n");
#nullable restore
#line 21 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Customer\Index.cshtml"
     if (TempData["Error"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-xs-12\">\r\n                <div class=\"alert alert-danger\">\r\n                    <h4><i class=\"icon fa fa-ban\">Failed</i></h4>\r\n                    ");
#nullable restore
#line 27 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Customer\Index.cshtml"
               Write(TempData["Error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 31 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Customer\Index.cshtml"


    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box"">
                <div class=""box-header"">
                    <h3 class=""box-title"">Customer List</h3>
                </div>
                <!-- /.box-header -->
                <div class=""box-body"">
                    <table id=""customerListTable"" class=""table table-bordered table-hover"">
                        <thead>
                            <tr>
                                <th>Id</th>
                                <th>Username</th>
                                <th>Full Name</th>
                                <th>Email</th>

                                <th>Status</th>

                                <th>Action</th>
                            </tr>
                        </thead>
                        <tbody>

");
#nullable restore
#line 59 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Customer\Index.cshtml"
                             foreach (var customer in (IEnumerable<ShopYB.Models.Account>)ViewBag.Customer)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 62 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Customer\Index.cshtml"
                               Write(customer.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 63 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Customer\Index.cshtml"
                               Write(customer.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 64 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Customer\Index.cshtml"
                               Write(customer.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 65 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Customer\Index.cshtml"
                               Write(customer.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                <td>");
#nullable restore
#line 67 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Customer\Index.cshtml"
                                Write(customer.Status ? "Active" : "Inactive");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                <td>\r\n                                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecf01f4640629cba689092815772c4cc8dfefe068118", async() => {
                WriteLiteral(" Edit");
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
#line 71 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Customer\Index.cshtml"
                                           WriteLiteral(customer.Id);

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
            WriteLiteral("\r\n\r\n                                </td>\r\n\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 77 "G:\Project\ASPCore\Shop-YB-BP4-Price\Shop-YB\Areas\Admin\Views\Customer\Index.cshtml"


                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </tbody>
                        <tfoot>
                            <tr>
                                <th>Id</th>
                                <th>Name</th>

                                <th>Photo</th>

                                <th>Action</th>
                            </tr>
                        </tfoot>
                    </table>
                </div>
                <!-- /.box-body -->
                <!-- /.box -->
            </div>
        </div>
    </div>

</section>

");
            DefineSection("script", async() => {
                WriteLiteral(@"
    <script>
    $(function () {

        $('#customerListTable').DataTable({
            'paging': true,
            'lengthChange': false,
            'searching': false,
            'ordering': true,
            'info': true,
            'autoWidth': false
        })
    })
    </script>



");
            }
            );
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
