#pragma checksum "/Users/radwanatassi/Downloads/Lesson02_MbmStore_startup/MbmStore/Views/Invoice/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c381565dc1ffd25b46f7d84c32c268af5f1e113c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_Index), @"mvc.1.0.view", @"/Views/Invoice/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c381565dc1ffd25b46f7d84c32c268af5f1e113c", @"/Views/Invoice/Index.cshtml")]
    public class Views_Invoice_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/radwanatassi/Downloads/Lesson02_MbmStore_startup/MbmStore/Views/Invoice/Index.cshtml"
   ViewData["Title"] = "Invoices";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c381565dc1ffd25b46f7d84c32c268af5f1e113c3487", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c381565dc1ffd25b46f7d84c32c268af5f1e113c4828", async() => {
                WriteLiteral("\n    <style>\n        table, th, td {\n            border: 1px solid black;\n        }\n    </style>\n");
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
            WriteLiteral(@"

<div class=""container"">
<div class=""row"">

    <div style=""width: 1000px; height:auto; float:left; margin:10px"">

        <h2>Invoices</h2>

        <table style=""width:100%"">
            <tr>
                <th width=""100px"">Invoice No.</th>
                <th width=""150px"">Customer</th>
                <th width=""150"">No Of Items</th>
                <th width=""400"">Products</th>
                <th width=""100"">Price</th>
                <th width=""100"">Total</th>

            </tr>

");
#nullable restore
#line 34 "/Users/radwanatassi/Downloads/Lesson02_MbmStore_startup/MbmStore/Views/Invoice/Index.cshtml"
             foreach (var i in @ViewBag.Invoices)
            { 


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td width=\"100px\">");
#nullable restore
#line 38 "/Users/radwanatassi/Downloads/Lesson02_MbmStore_startup/MbmStore/Views/Invoice/Index.cshtml"
                         Write(i.InvoiceId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td width=\"200px\">");
#nullable restore
#line 39 "/Users/radwanatassi/Downloads/Lesson02_MbmStore_startup/MbmStore/Views/Invoice/Index.cshtml"
                         Write(i.Customer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 39 "/Users/radwanatassi/Downloads/Lesson02_MbmStore_startup/MbmStore/Views/Invoice/Index.cshtml"
                                               Write(i.Customer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td width=\"100px\">");
#nullable restore
#line 40 "/Users/radwanatassi/Downloads/Lesson02_MbmStore_startup/MbmStore/Views/Invoice/Index.cshtml"
                         Write(i.OrderItems.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n            <td width=\"500\">\n");
#nullable restore
#line 43 "/Users/radwanatassi/Downloads/Lesson02_MbmStore_startup/MbmStore/Views/Invoice/Index.cshtml"
                 foreach (var oi in @i.OrderItems)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\n                        ");
#nullable restore
#line 47 "/Users/radwanatassi/Downloads/Lesson02_MbmStore_startup/MbmStore/Views/Invoice/Index.cshtml"
                   Write(oi.Product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </li>\n");
#nullable restore
#line 49 "/Users/radwanatassi/Downloads/Lesson02_MbmStore_startup/MbmStore/Views/Invoice/Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\n            <td width=\"100\">\n");
#nullable restore
#line 53 "/Users/radwanatassi/Downloads/Lesson02_MbmStore_startup/MbmStore/Views/Invoice/Index.cshtml"
                 foreach (var orderItem in @i.OrderItems)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label>\n                        ");
#nullable restore
#line 56 "/Users/radwanatassi/Downloads/Lesson02_MbmStore_startup/MbmStore/Views/Invoice/Index.cshtml"
                   Write(orderItem.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </label>\n");
#nullable restore
#line 58 "/Users/radwanatassi/Downloads/Lesson02_MbmStore_startup/MbmStore/Views/Invoice/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n            <td width=\"100\">");
#nullable restore
#line 61 "/Users/radwanatassi/Downloads/Lesson02_MbmStore_startup/MbmStore/Views/Invoice/Index.cshtml"
                       Write(i.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n\n\n\n        </tr>\n");
#nullable restore
#line 67 "/Users/radwanatassi/Downloads/Lesson02_MbmStore_startup/MbmStore/Views/Invoice/Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table> \n        </div>\n</div>\n</div>");
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
