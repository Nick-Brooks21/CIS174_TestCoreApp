#pragma checksum "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\_accesslevel2plus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "608220e22d89e120e09d2092281e306e7cd60fb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student__accesslevel2plus), @"mvc.1.0.view", @"/Views/Student/_accesslevel2plus.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/_accesslevel2plus.cshtml", typeof(AspNetCore.Views_Student__accesslevel2plus))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"608220e22d89e120e09d2092281e306e7cd60fb4", @"/Views/Student/_accesslevel2plus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b0c89835ffd0a30fcde2417f863d02f1a9e8dc4", @"/Views/_ViewImports.cshtml")]
    public class Views_Student__accesslevel2plus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<StudentViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(155, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\_accesslevel2plus.cshtml"
 foreach(var s in Model)
{

#line default
#line hidden
            BeginContext(186, 9, true);
            WriteLiteral("    <div>");
            EndContext();
            BeginContext(196, 11, false);
#line 9 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\_accesslevel2plus.cshtml"
    Write(s.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(207, 17, true);
            WriteLiteral("</div>\r\n    <div>");
            EndContext();
            BeginContext(225, 10, false);
#line 10 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\_accesslevel2plus.cshtml"
    Write(s.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(235, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 11 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\_accesslevel2plus.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<StudentViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
