#pragma checksum "C:\Users\molin\Documents\WebApplic\Projects\TastyRecipeStore\TastyRecipeStore\Views\Home\ViewRecipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cea3658554248aabaec970afb24d3824729a290"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewRecipe), @"mvc.1.0.view", @"/Views/Home/ViewRecipe.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewRecipe.cshtml", typeof(AspNetCore.Views_Home_ViewRecipe))]
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
#line 4 "C:\Users\molin\Documents\WebApplic\Projects\TastyRecipeStore\TastyRecipeStore\Views\_ViewImports.cshtml"
using TastyRecipeStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cea3658554248aabaec970afb24d3824729a290", @"/Views/Home/ViewRecipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1303bf8fea6442c6d406e73a08c8eec4b1e4f849", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewRecipe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Recipe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\molin\Documents\WebApplic\Projects\TastyRecipeStore\TastyRecipeStore\Views\Home\ViewRecipe.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "View Selected Recipe";

#line default
#line hidden
            BeginContext(92, 66, true);
            WriteLiteral("\r\n\r\n<h2 class=\"jumbotron justify-content-md-center title-primary\">");
            EndContext();
            BeginContext(159, 10, false);
#line 8 "C:\Users\molin\Documents\WebApplic\Projects\TastyRecipeStore\TastyRecipeStore\Views\Home\ViewRecipe.cshtml"
                                                         Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(169, 248, true);
            WriteLiteral(" recipe\'s detail</h2>\r\n<br />\r\n<div class=\"container \">\r\n    <div class=\"card mycard\">        \r\n            <div class=\"details\">\r\n\r\n\r\n                <label class=\"lbl lbl-primary lbl-block\"><span>Chef\'s Author</span></label>\r\n                <p> ");
            EndContext();
            BeginContext(418, 10, false);
#line 16 "C:\Users\molin\Documents\WebApplic\Projects\TastyRecipeStore\TastyRecipeStore\Views\Home\ViewRecipe.cshtml"
               Write(Model.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(428, 118, true);
            WriteLiteral("</p>\r\n\r\n                <label class=\"lbl lbl-primary lbl-block\"><span>Description</span></label>\r\n                <p>");
            EndContext();
            BeginContext(547, 17, false);
#line 19 "C:\Users\molin\Documents\WebApplic\Projects\TastyRecipeStore\TastyRecipeStore\Views\Home\ViewRecipe.cshtml"
              Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(564, 123, true);
            WriteLiteral("</p>\r\n\r\n                <label class=\"lbl lbl-primary lbl-block\"><span>Preparation Time</span></label>\r\n                <p>");
            EndContext();
            BeginContext(688, 21, false);
#line 22 "C:\Users\molin\Documents\WebApplic\Projects\TastyRecipeStore\TastyRecipeStore\Views\Home\ViewRecipe.cshtml"
              Write(Model.PreparationTime);

#line default
#line hidden
            EndContext();
            BeginContext(709, 122, true);
            WriteLiteral(" min</p>\r\n\r\n                <label class=\"lbl lbl-primary lbl-block\"><span>Ingredients</span></label>\r\n                <p>");
            EndContext();
            BeginContext(832, 16, false);
#line 25 "C:\Users\molin\Documents\WebApplic\Projects\TastyRecipeStore\TastyRecipeStore\Views\Home\ViewRecipe.cshtml"
              Write(Model.Ingredient);

#line default
#line hidden
            EndContext();
            BeginContext(848, 60, true);
            WriteLiteral("</p>\r\n\r\n\r\n            \r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Recipe> Html { get; private set; }
    }
}
#pragma warning restore 1591
