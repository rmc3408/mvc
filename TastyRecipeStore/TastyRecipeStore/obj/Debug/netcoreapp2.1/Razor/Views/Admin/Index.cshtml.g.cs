#pragma checksum "C:\Users\molin\OneDrive\Documents\MVC\TastyRecipeStore\TastyRecipeStore\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50421543104844dc6c901757ea800f1a4994ae2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
#line 4 "C:\Users\molin\OneDrive\Documents\MVC\TastyRecipeStore\TastyRecipeStore\Views\_ViewImports.cshtml"
using TastyRecipeStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50421543104844dc6c901757ea800f1a4994ae2b", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1303bf8fea6442c6d406e73a08c8eec4b1e4f849", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Recipe>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\molin\OneDrive\Documents\MVC\TastyRecipeStore\TastyRecipeStore\Views\Admin\Index.cshtml"
  
    ViewBag.Title = "Customize Recipes";
    Layout = "_AdminLayout";

#line default
#line hidden
            BeginContext(108, 277, true);
            WriteLiteral(@"

<table class=""table table-striped table-bordered table-sm"">
    <tr>
        <th class=""text-capitalize"">ID</th>
        <th class=""text-capitalize"">Name</th>
        <th class=""text-capitalize"">Chef</th>
        <th class=""text-capitalize"">Actions</th>
    </tr>

");
            EndContext();
#line 17 "C:\Users\molin\OneDrive\Documents\MVC\TastyRecipeStore\TastyRecipeStore\Views\Admin\Index.cshtml"
     foreach (var data in Model)
    {

#line default
#line hidden
            BeginContext(426, 52, true);
            WriteLiteral("        <tr>\r\n            <td class=\"text-sm-right\">");
            EndContext();
            BeginContext(479, 13, false);
#line 20 "C:\Users\molin\OneDrive\Documents\MVC\TastyRecipeStore\TastyRecipeStore\Views\Admin\Index.cshtml"
                                 Write(data.RecipeID);

#line default
#line hidden
            EndContext();
            BeginContext(492, 45, true);
            WriteLiteral("</td>\r\n            <td class=\"text-sm-right\">");
            EndContext();
            BeginContext(538, 9, false);
#line 21 "C:\Users\molin\OneDrive\Documents\MVC\TastyRecipeStore\TastyRecipeStore\Views\Admin\Index.cshtml"
                                 Write(data.Name);

#line default
#line hidden
            EndContext();
            BeginContext(547, 44, true);
            WriteLiteral("</td>\r\n            <td class=\"text-sm-left\">");
            EndContext();
            BeginContext(592, 9, false);
#line 22 "C:\Users\molin\OneDrive\Documents\MVC\TastyRecipeStore\TastyRecipeStore\Views\Admin\Index.cshtml"
                                Write(data.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(601, 90, true);
            WriteLiteral("</td>\r\n            <td class=\"align-content-center\">\r\n\r\n                \r\n                ");
            EndContext();
            BeginContext(691, 352, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e599481cb4147acbcd5ff48e9fab292", async() => {
                BeginContext(731, 60, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"toBeDelete\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 791, "\"", 813, 1);
#line 27 "C:\Users\molin\OneDrive\Documents\MVC\TastyRecipeStore\TastyRecipeStore\Views\Admin\Index.cshtml"
WriteAttributeValue("", 799, data.RecipeID, 799, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(814, 25, true);
                WriteLiteral(" />\r\n                    ");
                EndContext();
                BeginContext(839, 89, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99843fe28c9342bbb96721152b97f3c4", async() => {
                    BeginContext(920, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-selected", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 28 "C:\Users\molin\OneDrive\Documents\MVC\TastyRecipeStore\TastyRecipeStore\Views\Admin\Index.cshtml"
                                                                         WriteLiteral(data.RecipeID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["selected"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-selected", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["selected"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(928, 108, true);
                WriteLiteral("\r\n                    <button class=\"btn btn-outline-danger\" type=\"submit\">Delete</button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1043, 38, true);
            WriteLiteral("\r\n\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 34 "C:\Users\molin\OneDrive\Documents\MVC\TastyRecipeStore\TastyRecipeStore\Views\Admin\Index.cshtml"

    }

#line default
#line hidden
            BeginContext(1090, 14, true);
            WriteLiteral("\r\n\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Recipe>> Html { get; private set; }
    }
}
#pragma warning restore 1591
