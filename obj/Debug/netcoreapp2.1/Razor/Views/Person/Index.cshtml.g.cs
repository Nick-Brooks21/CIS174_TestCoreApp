#pragma checksum "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Person\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3ba5e5d03bd6c9509177c47379296643f3b42b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Index), @"mvc.1.0.view", @"/Views/Person/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Person/Index.cshtml", typeof(AspNetCore.Views_Person_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3ba5e5d03bd6c9509177c47379296643f3b42b9", @"/Views/Person/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b0c89835ffd0a30fcde2417f863d02f1a9e8dc4", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CIS174_TestCoreApp.Models.CreatePersonViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 26, true);
            WriteLiteral("\r\n<h2>Create Person</h2>\r\n");
            EndContext();
            BeginContext(82, 3289, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccfc750a8a564d5f80b0f3e47329e5d4", async() => {
                BeginContext(102, 148, true);
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    ");
                EndContext();
                BeginContext(251, 31, false);
#line 9 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.LabelFor(m => m.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(282, 86, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    ");
                EndContext();
                BeginContext(369, 32, false);
#line 12 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.EditorFor(m => m.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(401, 109, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"pull-right col-md-8 text-danger\">\r\n                    ");
                EndContext();
                BeginContext(511, 43, false);
#line 15 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(554, 139, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    ");
                EndContext();
                BeginContext(694, 30, false);
#line 21 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.LabelFor(m => m.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(724, 86, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    ");
                EndContext();
                BeginContext(811, 31, false);
#line 24 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.EditorFor(m => m.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(842, 109, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"pull-right col-md-8 text-danger\">\r\n                    ");
                EndContext();
                BeginContext(952, 42, false);
#line 27 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(994, 139, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    ");
                EndContext();
                BeginContext(1134, 25, false);
#line 33 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.LabelFor(m => m.Age));

#line default
#line hidden
                EndContext();
                BeginContext(1159, 86, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    ");
                EndContext();
                BeginContext(1246, 26, false);
#line 36 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.EditorFor(m => m.Age));

#line default
#line hidden
                EndContext();
                BeginContext(1272, 109, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"pull-right col-md-8 text-danger\">\r\n                    ");
                EndContext();
                BeginContext(1382, 37, false);
#line 39 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.Age));

#line default
#line hidden
                EndContext();
                BeginContext(1419, 187, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col-md-6\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    ");
                EndContext();
                BeginContext(1607, 27, false);
#line 47 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
                EndContext();
                BeginContext(1634, 86, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    ");
                EndContext();
                BeginContext(1721, 28, false);
#line 50 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.EditorFor(m => m.Email));

#line default
#line hidden
                EndContext();
                BeginContext(1749, 109, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"pull-right col-md-8 text-danger\">\r\n                    ");
                EndContext();
                BeginContext(1859, 39, false);
#line 53 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.Email));

#line default
#line hidden
                EndContext();
                BeginContext(1898, 139, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    ");
                EndContext();
                BeginContext(2038, 34, false);
#line 59 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.LabelFor(m => m.ConfirmEmail));

#line default
#line hidden
                EndContext();
                BeginContext(2072, 86, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    ");
                EndContext();
                BeginContext(2159, 35, false);
#line 62 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.EditorFor(m => m.ConfirmEmail));

#line default
#line hidden
                EndContext();
                BeginContext(2194, 109, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"pull-right col-md-8 text-danger\">\r\n                    ");
                EndContext();
                BeginContext(2304, 46, false);
#line 65 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.ConfirmEmail));

#line default
#line hidden
                EndContext();
                BeginContext(2350, 139, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    ");
                EndContext();
                BeginContext(2490, 29, false);
#line 71 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.LabelFor(m => m.Website));

#line default
#line hidden
                EndContext();
                BeginContext(2519, 86, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    ");
                EndContext();
                BeginContext(2606, 30, false);
#line 74 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.EditorFor(m => m.Website));

#line default
#line hidden
                EndContext();
                BeginContext(2636, 109, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"pull-right col-md-8 text-danger\">\r\n                    ");
                EndContext();
                BeginContext(2746, 41, false);
#line 77 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.Website));

#line default
#line hidden
                EndContext();
                BeginContext(2787, 139, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    ");
                EndContext();
                BeginContext(2927, 28, false);
#line 83 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.LabelFor(m => m.School));

#line default
#line hidden
                EndContext();
                BeginContext(2955, 86, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    ");
                EndContext();
                BeginContext(3042, 29, false);
#line 86 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.EditorFor(m => m.School));

#line default
#line hidden
                EndContext();
                BeginContext(3071, 109, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"pull-right col-md-8 text-danger\">\r\n                    ");
                EndContext();
                BeginContext(3181, 40, false);
#line 89 "C:\Users\ntbro\OneDrive\Desktop\Advanced C#\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.School));

#line default
#line hidden
                EndContext();
                BeginContext(3221, 143, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <button class=\"btn btn-primary\" type=\"submit\">Create</button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3371, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CIS174_TestCoreApp.Models.CreatePersonViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
