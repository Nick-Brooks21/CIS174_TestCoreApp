#pragma checksum "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6079fcc202120e55232a5080624dffdec70867a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Index.cshtml", typeof(AspNetCore.Views_Student_Index))]
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
#line 1 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\_ViewImports.cshtml"
using CIS174_TestCoreApp;

#line default
#line hidden
#line 2 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\_ViewImports.cshtml"
using CIS174_TestCoreApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6079fcc202120e55232a5080624dffdec70867a", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b0c89835ffd0a30fcde2417f863d02f1a9e8dc4", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Index.cshtml"
  
    ViewData["Title"] = "Student";

#line default
#line hidden
            BeginContext(73, 23, true);
            WriteLiteral("\r\n<h2>Students</h2>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Index.cshtml"
 if (Model.AccessLevel < 2)
{

#line default
#line hidden
            BeginContext(128, 33, true);
            WriteLiteral("<p>\"You do not have access\"</p>\r\n");
            EndContext();
#line 11 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Index.cshtml"
}

#line default
#line hidden
            BeginContext(165, 4, false);
#line 12 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Index.cshtml"
Write(else);

#line default
#line hidden
            EndContext();
            BeginContext(169, 36, true);
            WriteLiteral(" if (Model.AccessLevel < 8)\r\n{\r\n    ");
            EndContext();
            BeginContext(206, 61, false);
#line 14 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Index.cshtml"
Write(await Html.PartialAsync("../Views/Student/_accesslevel2plus"));

#line default
#line hidden
            EndContext();
            BeginContext(267, 14, true);
            WriteLiteral(";        \r\n}\r\n");
            EndContext();
            BeginContext(282, 4, false);
#line 16 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Index.cshtml"
Write(else);

#line default
#line hidden
            EndContext();
            BeginContext(286, 9, true);
            WriteLiteral("\r\n{\r\n    ");
            EndContext();
            BeginContext(296, 61, false);
#line 18 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Index.cshtml"
Write(await Html.PartialAsync("../Views/Student/_accesslevel8plus"));

#line default
#line hidden
            EndContext();
            BeginContext(357, 5, true);
            WriteLiteral("; \r\n}");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591