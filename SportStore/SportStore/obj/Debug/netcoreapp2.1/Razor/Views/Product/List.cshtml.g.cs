#pragma checksum "C:\Users\molin\Documents\WebApplic\Projects\SportStore\SportStore\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ed0c6c4050b7329889b718bc2045623359c3561"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/List.cshtml", typeof(AspNetCore.Views_Product_List))]
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
#line 1 "C:\Users\molin\Documents\WebApplic\Projects\SportStore\SportStore\Views\_ViewImports.cshtml"
using SportStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ed0c6c4050b7329889b718bc2045623359c3561", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98bdc15ce1348498b5c45cdfe176175bee8fe4ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\molin\Documents\WebApplic\Projects\SportStore\SportStore\Views\Product\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(70, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\molin\Documents\WebApplic\Projects\SportStore\SportStore\Views\Product\List.cshtml"
 foreach (Product pt in Model)
{

#line default
#line hidden
            BeginContext(107, 8, true);
            WriteLiteral("    <h2>");
            EndContext();
            BeginContext(116, 7, false);
#line 9 "C:\Users\molin\Documents\WebApplic\Projects\SportStore\SportStore\Views\Product\List.cshtml"
   Write(pt.Name);

#line default
#line hidden
            EndContext();
            BeginContext(123, 16, true);
            WriteLiteral(" </h2>\r\n    <h4>");
            EndContext();
            BeginContext(140, 22, false);
#line 10 "C:\Users\molin\Documents\WebApplic\Projects\SportStore\SportStore\Views\Product\List.cshtml"
   Write(pt.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(162, 8, true);
            WriteLiteral(" </h4>\r\n");
            EndContext();
#line 11 "C:\Users\molin\Documents\WebApplic\Projects\SportStore\SportStore\Views\Product\List.cshtml"
}

#line default
#line hidden
            BeginContext(173, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
