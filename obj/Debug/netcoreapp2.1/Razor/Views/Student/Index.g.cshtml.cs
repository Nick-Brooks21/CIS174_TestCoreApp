#pragma checksum "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5f935129394b720f96f5b6ebb5d1f005f5c16c5"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5f935129394b720f96f5b6ebb5d1f005f5c16c5", @"/Views/Student/Index.cshtml")]
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
            BeginContext(74, 19, false);
#line 5 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Index.cshtml"
Write(ViewBag.AccessLevel);

#line default
#line hidden
            EndContext();
            BeginContext(93, 25, true);
            WriteLiteral("\r\n\r\n<h2>Students</h2>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Index.cshtml"
 if (Model.AccessLevel < 2)
{

#line default
#line hidden
            BeginContext(150, 33, true);
            WriteLiteral("<p>\"You do not have access\"</p>\r\n");
            EndContext();
#line 12 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Index.cshtml"
}
else if (Model.AccessLevel < 8)
{
    

#line default
#line hidden
            BeginContext(227, 60, false);
#line 15 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Index.cshtml"
Write(await Html.PartialAsync("_accesslevel2plus", Model.Students));

#line default
#line hidden
            EndContext();
#line 15 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Index.cshtml"
                                                                 ;        
}
else
{
    

#line default
#line hidden
            BeginContext(315, 60, false);
#line 19 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Index.cshtml"
Write(await Html.PartialAsync("_accesslevel8plus", Model.Students));

#line default
#line hidden
            EndContext();
#line 19 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Index.cshtml"
                                                                 ; 
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
