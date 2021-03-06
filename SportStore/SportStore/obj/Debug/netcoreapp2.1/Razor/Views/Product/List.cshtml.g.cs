#pragma checksum "C:\Users\molin\OneDrive\Documents\MVC\SportStore\SportStore\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "389cd670b373ed49c545219f030c62191540bd58"
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
#line 1 "C:\Users\molin\OneDrive\Documents\MVC\SportStore\SportStore\Views\_ViewImports.cshtml"
using SportStore.Models;

#line default
#line hidden
#line 2 "C:\Users\molin\OneDrive\Documents\MVC\SportStore\SportStore\Views\_ViewImports.cshtml"
using SportStore.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"389cd670b373ed49c545219f030c62191540bd58", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d10ead875077408a4e15766bc19e974b89f1aab", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-classes-enabled", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", new global::Microsoft.AspNetCore.Html.HtmlString("btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", new global::Microsoft.AspNetCore.Html.HtmlString("btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::SportStore.Infrastruture.PageLinkTagHelper __SportStore_Infrastruture_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\molin\OneDrive\Documents\MVC\SportStore\SportStore\Views\Product\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\molin\OneDrive\Documents\MVC\SportStore\SportStore\Views\Product\List.cshtml"
 foreach (Product pt in Model.PackProducts)
{
    

#line default
#line hidden
            BeginContext(122, 80, true);
            WriteLiteral("    <div class=\"card media card-deck-outline\" >\r\n        <h2 class=\"card-title\">");
            EndContext();
            BeginContext(203, 7, false);
#line 10 "C:\Users\molin\OneDrive\Documents\MVC\SportStore\SportStore\Views\Product\List.cshtml"
                          Write(pt.Name);

#line default
#line hidden
            EndContext();
            BeginContext(210, 38, true);
            WriteLiteral(" </h2>\r\n        <h6 class=\"card-text\">");
            EndContext();
            BeginContext(249, 14, false);
#line 11 "C:\Users\molin\OneDrive\Documents\MVC\SportStore\SportStore\Views\Product\List.cshtml"
                         Write(pt.Description);

#line default
#line hidden
            EndContext();
            BeginContext(263, 70, true);
            WriteLiteral(" </h6>\r\n        <h4 class=\"mx-auto btn-warning\" style=\"width: 100px;\">");
            EndContext();
            BeginContext(334, 22, false);
#line 12 "C:\Users\molin\OneDrive\Documents\MVC\SportStore\SportStore\Views\Product\List.cshtml"
                                                         Write(pt.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(356, 46, true);
            WriteLiteral(" </h4>\r\n        <h4 class=\"page-item-warning\">");
            EndContext();
            BeginContext(403, 11, false);
#line 13 "C:\Users\molin\OneDrive\Documents\MVC\SportStore\SportStore\Views\Product\List.cshtml"
                                 Write(pt.Category);

#line default
#line hidden
            EndContext();
            BeginContext(414, 20, true);
            WriteLiteral(" </h4>\r\n    </div>\r\n");
            EndContext();
#line 15 "C:\Users\molin\OneDrive\Documents\MVC\SportStore\SportStore\Views\Product\List.cshtml"
    


}

#line default
#line hidden
            BeginContext(447, 203, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce7aadabe5b84e4bae8538d0a985b58c", async() => {
            }
            );
            __SportStore_Infrastruture_PageLinkTagHelper = CreateTagHelper<global::SportStore.Infrastruture.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__SportStore_Infrastruture_PageLinkTagHelper);
#line 19 "C:\Users\molin\OneDrive\Documents\MVC\SportStore\SportStore\Views\Product\List.cshtml"
__SportStore_Infrastruture_PageLinkTagHelper.PageModel = Model.PageInfo;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __SportStore_Infrastruture_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __SportStore_Infrastruture_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(650, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
