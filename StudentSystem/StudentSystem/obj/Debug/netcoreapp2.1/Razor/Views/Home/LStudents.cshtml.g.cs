#pragma checksum "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\Home\LStudents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92661d4e8ca401615610e78ccc80d266edbd8bae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LStudents), @"mvc.1.0.view", @"/Views/Home/LStudents.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/LStudents.cshtml", typeof(AspNetCore.Views_Home_LStudents))]
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
#line 4 "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\_ViewImports.cshtml"
using StudentSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92661d4e8ca401615610e78ccc80d266edbd8bae", @"/Views/Home/LStudents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f888562078eaadf123ea9ca1b1d111ddc0f411e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_LStudents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\Home\LStudents.cshtml"
  
    Layout = "_BasicLayout";

#line default
#line hidden
            BeginContext(59, 304, true);
            WriteLiteral(@"
    <table class=""table table-primary"">
        
        <tr>
            <th> Firstname</th>
            <th> LastName</th>
            <th> Email</th>
            <th> Gpa</th>
            <th> FullTime</th>
            <th> CourseCode</th>
            <th> StudentID</th>
        </tr>

");
            EndContext();
#line 18 "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\Home\LStudents.cshtml"
         foreach (Student st in Model)
        {

#line default
#line hidden
            BeginContext(414, 36, true);
            WriteLiteral("         <tr>\r\n                <td> ");
            EndContext();
            BeginContext(451, 12, false);
#line 21 "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\Home\LStudents.cshtml"
                Write(st.Firstname);

#line default
#line hidden
            EndContext();
            BeginContext(463, 28, true);
            WriteLiteral("</td>\r\n                <td> ");
            EndContext();
            BeginContext(492, 11, false);
#line 22 "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\Home\LStudents.cshtml"
                Write(st.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(503, 28, true);
            WriteLiteral("</td>\r\n                <td> ");
            EndContext();
            BeginContext(532, 8, false);
#line 23 "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\Home\LStudents.cshtml"
                Write(st.Email);

#line default
#line hidden
            EndContext();
            BeginContext(540, 28, true);
            WriteLiteral("</td>\r\n                <td> ");
            EndContext();
            BeginContext(569, 6, false);
#line 24 "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\Home\LStudents.cshtml"
                Write(st.Gpa);

#line default
#line hidden
            EndContext();
            BeginContext(575, 28, true);
            WriteLiteral("</td>\r\n                <td> ");
            EndContext();
            BeginContext(604, 11, false);
#line 25 "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\Home\LStudents.cshtml"
                Write(st.FullTime);

#line default
#line hidden
            EndContext();
            BeginContext(615, 28, true);
            WriteLiteral("</td>\r\n                <td> ");
            EndContext();
            BeginContext(644, 13, false);
#line 26 "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\Home\LStudents.cshtml"
                Write(st.CourseCode);

#line default
#line hidden
            EndContext();
            BeginContext(657, 28, true);
            WriteLiteral("</td>\r\n                <td> ");
            EndContext();
            BeginContext(686, 12, false);
#line 27 "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\Home\LStudents.cshtml"
                Write(st.StudentID);

#line default
#line hidden
            EndContext();
            BeginContext(698, 23, true);
            WriteLiteral("</td>\r\n         </tr>\r\n");
            EndContext();
#line 29 "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\Home\LStudents.cshtml"
        
        }

#line default
#line hidden
            BeginContext(742, 30, true);
            WriteLiteral("        \r\n\r\n    </table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591