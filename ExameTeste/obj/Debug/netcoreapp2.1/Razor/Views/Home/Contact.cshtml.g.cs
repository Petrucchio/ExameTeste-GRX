#pragma checksum "C:\Users\Farias\source\repos\ExameTeste\ExameTeste\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d030e6d070945e39635b13ba987d3a533ddfe097"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
#line 1 "C:\Users\Farias\source\repos\ExameTeste\ExameTeste\Views\_ViewImports.cshtml"
using ExameTeste;

#line default
#line hidden
#line 2 "C:\Users\Farias\source\repos\ExameTeste\ExameTeste\Views\_ViewImports.cshtml"
using ExameTeste.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d030e6d070945e39635b13ba987d3a533ddfe097", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3442106fc004dbacfc723d4b994019f8aab4e413", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Farias\source\repos\ExameTeste\ExameTeste\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contatos do desenvolvedor";

#line default
#line hidden
            BeginContext(61, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(66, 17, false);
#line 4 "C:\Users\Farias\source\repos\ExameTeste\ExameTeste\Views\Home\Contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(83, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(95, 19, false);
#line 5 "C:\Users\Farias\source\repos\ExameTeste\ExameTeste\Views\Home\Contact.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(114, 565, true);
            WriteLiteral(@"</h3>

<p>Essa aplicação foi desenvolvida utilizando .Net core (versão 2.1), banco de dados MySQL e bootstrap 3</p>
<address>
    <abbr title=""Phone"">Número de contato:</abbr>
    (79)99108-8459
</address>

<address>
    <strong>Email:</strong> <a href=""victor.farias.profile@gmail.com"">victor.farias.profile@gmail.com</a><br />
    <strong>Linkedin:</strong> <a href=""https://www.linkedin.com/in/victorjosecostafarias/"">Victor José Costa Farias</a><br />
    <strong>GitHub:</strong> <a href=""https://github.com/Petrucchio""> Git.Victor</a>
</address>
");
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
