#pragma checksum "C:\Users\Herbert\Documents\GitHub\ExameTeste-GRX\ExameTeste\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18d1e195b67532813a3c33dd84fa15ffe2d9bb07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Herbert\Documents\GitHub\ExameTeste-GRX\ExameTeste\Views\_ViewImports.cshtml"
using ExameTeste;

#line default
#line hidden
#line 2 "C:\Users\Herbert\Documents\GitHub\ExameTeste-GRX\ExameTeste\Views\_ViewImports.cshtml"
using ExameTeste.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18d1e195b67532813a3c33dd84fa15ffe2d9bb07", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3442106fc004dbacfc723d4b994019f8aab4e413", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Herbert\Documents\GitHub\ExameTeste-GRX\ExameTeste\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Apresentação";

#line default
#line hidden
            BeginContext(48, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(55, 17, false);
#line 5 "C:\Users\Herbert\Documents\GitHub\ExameTeste-GRX\ExameTeste\Views\Home\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(72, 141, true);
            WriteLiteral("</h2>\r\n<p>Essa AplicaçãoWeb foi criada com o intuito de cumprir os requisitos dos testes 1 e 2 em uma unica aplicação para a GRX soluções</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
