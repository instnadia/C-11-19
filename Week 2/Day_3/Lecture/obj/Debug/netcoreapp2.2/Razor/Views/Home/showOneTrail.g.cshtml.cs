#pragma checksum "C:\Users\naadi\Documents\C-11-19\Week 2\Day_3\Lecture\Views\Home\showOneTrail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af6b4d600de99e2963d876ee1b0c892e217d2fd6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_showOneTrail), @"mvc.1.0.view", @"/Views/Home/showOneTrail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/showOneTrail.cshtml", typeof(AspNetCore.Views_Home_showOneTrail))]
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
#line 1 "C:\Users\naadi\Documents\C-11-19\Week 2\Day_3\Lecture\Views\_ViewImports.cshtml"
using Lecture;

#line default
#line hidden
#line 2 "C:\Users\naadi\Documents\C-11-19\Week 2\Day_3\Lecture\Views\_ViewImports.cshtml"
using Lecture.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af6b4d600de99e2963d876ee1b0c892e217d2fd6", @"/Views/Home/showOneTrail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0db0d87f27675381b31528781b611e9b99c0698a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_showOneTrail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Trail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(20, 10, false);
#line 3 "C:\Users\naadi\Documents\C-11-19\Week 2\Day_3\Lecture\Views\Home\showOneTrail.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(30, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(40, 17, false);
#line 4 "C:\Users\naadi\Documents\C-11-19\Week 2\Day_3\Lecture\Views\Home\showOneTrail.cshtml"
Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(57, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(67, 12, false);
#line 5 "C:\Users\naadi\Documents\C-11-19\Week 2\Day_3\Lecture\Views\Home\showOneTrail.cshtml"
Write(Model.length);

#line default
#line hidden
            EndContext();
            BeginContext(79, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Trail> Html { get; private set; }
    }
}
#pragma warning restore 1591
