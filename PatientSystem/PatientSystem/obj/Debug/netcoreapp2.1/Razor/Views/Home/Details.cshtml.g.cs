#pragma checksum "C:\Users\molin\Documents\WebApplic\Projects\PatientSystem\PatientSystem\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d9d323c6634500e810731cd227cc443b6aa3826"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 1 "C:\Users\molin\Documents\WebApplic\Projects\PatientSystem\PatientSystem\Views\_ViewImports.cshtml"
using PatientSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d9d323c6634500e810731cd227cc443b6aa3826", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729d54ae23f11dfe0934925ea1a76ed3624c9113", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Patient>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\molin\Documents\WebApplic\Projects\PatientSystem\PatientSystem\Views\Home\Details.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Details";

#line default
#line hidden
            BeginContext(95, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 10 "C:\Users\molin\Documents\WebApplic\Projects\PatientSystem\PatientSystem\Views\Home\Details.cshtml"
 foreach (Patient item in Model)
{

#line default
#line hidden
            BeginContext(138, 113, true);
            WriteLiteral("    <div class=\"jumbotron text-center\">\r\n        <h3> Detail of the Patient</h3>\r\n        <h1 class=\"text-info\"> ");
            EndContext();
            BeginContext(252, 9, false);
#line 14 "C:\Users\molin\Documents\WebApplic\Projects\PatientSystem\PatientSystem\Views\Home\Details.cshtml"
                          Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(261, 94, true);
            WriteLiteral(" </h1>\r\n\r\n    </div>\r\n    <div class=\"card-body\" style=\"margin-left:80px\">\r\n        <p> Name: ");
            EndContext();
            BeginContext(356, 9, false);
#line 18 "C:\Users\molin\Documents\WebApplic\Projects\PatientSystem\PatientSystem\Views\Home\Details.cshtml"
             Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(365, 36, true);
            WriteLiteral(" </p>\r\n        <p> Registered time: ");
            EndContext();
            BeginContext(402, 23, false);
#line 19 "C:\Users\molin\Documents\WebApplic\Projects\PatientSystem\PatientSystem\Views\Home\Details.cshtml"
                        Write(item.CurrentDateAndTime);

#line default
#line hidden
            EndContext();
            BeginContext(425, 24, true);
            WriteLiteral(" </p>\r\n        <p> Age: ");
            EndContext();
            BeginContext(450, 8, false);
#line 20 "C:\Users\molin\Documents\WebApplic\Projects\PatientSystem\PatientSystem\Views\Home\Details.cshtml"
            Write(item.Age);

#line default
#line hidden
            EndContext();
            BeginContext(458, 28, true);
            WriteLiteral(" </p>\r\n        <p> Address: ");
            EndContext();
            BeginContext(487, 12, false);
#line 21 "C:\Users\molin\Documents\WebApplic\Projects\PatientSystem\PatientSystem\Views\Home\Details.cshtml"
                Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(499, 31, true);
            WriteLiteral(" </p>\r\n        <p> Occupation: ");
            EndContext();
            BeginContext(531, 15, false);
#line 22 "C:\Users\molin\Documents\WebApplic\Projects\PatientSystem\PatientSystem\Views\Home\Details.cshtml"
                   Write(item.Occupation);

#line default
#line hidden
            EndContext();
            BeginContext(546, 34, true);
            WriteLiteral(" </p>\r\n        <p> Has insurance: ");
            EndContext();
            BeginContext(582, 29, false);
#line 23 "C:\Users\molin\Documents\WebApplic\Projects\PatientSystem\PatientSystem\Views\Home\Details.cshtml"
                       Write(item.Insurance ? "Yes" : "No");

#line default
#line hidden
            EndContext();
            BeginContext(612, 36, true);
            WriteLiteral(" </p>\r\n        <p> Operated Before: ");
            EndContext();
            BeginContext(650, 29, false);
#line 24 "C:\Users\molin\Documents\WebApplic\Projects\PatientSystem\PatientSystem\Views\Home\Details.cshtml"
                         Write(item.Operation ? "Yes" : "No");

#line default
#line hidden
            EndContext();
            BeginContext(680, 35, true);
            WriteLiteral(" </p>\r\n        <p> Marital Status: ");
            EndContext();
            BeginContext(716, 12, false);
#line 25 "C:\Users\molin\Documents\WebApplic\Projects\PatientSystem\PatientSystem\Views\Home\Details.cshtml"
                       Write(item.Marital);

#line default
#line hidden
            EndContext();
            BeginContext(728, 19, true);
            WriteLiteral(" </p>\r\n    </div>\r\n");
            EndContext();
#line 27 "C:\Users\molin\Documents\WebApplic\Projects\PatientSystem\PatientSystem\Views\Home\Details.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Patient>> Html { get; private set; }
    }
}
#pragma warning restore 1591
