#pragma checksum "C:\Users\Farias\source\repos\ExameTeste\ExameTeste\Views\Pessoas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "449b4b21150d5c7c8d8bc6a58c934244a8ef2d7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoas_Index), @"mvc.1.0.view", @"/Views/Pessoas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pessoas/Index.cshtml", typeof(AspNetCore.Views_Pessoas_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"449b4b21150d5c7c8d8bc6a58c934244a8ef2d7c", @"/Views/Pessoas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3442106fc004dbacfc723d4b994019f8aab4e413", @"/Views/_ViewImports.cshtml")]
    public class Views_Pessoas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ExameTeste.Models.Pessoa>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Farias\source\repos\ExameTeste\ExameTeste\Views\Pessoas\Index.cshtml"
  
    ViewData["title"] = "Pessoas";

#line default
#line hidden
            BeginContext(89, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(94, 17, false);
#line 5 "C:\Users\Farias\source\repos\ExameTeste\ExameTeste\Views\Pessoas\Index.cshtml"
Write(ViewData["title"]);

#line default
#line hidden
            EndContext();
            BeginContext(111, 118, true);
            WriteLiteral(" </h2>\r\n<table class=\"table table-striped table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(230, 40, false);
#line 10 "C:\Users\Farias\source\repos\ExameTeste\ExameTeste\Views\Pessoas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(270, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(326, 39, false);
#line 13 "C:\Users\Farias\source\repos\ExameTeste\ExameTeste\Views\Pessoas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(365, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(421, 45, false);
#line 16 "C:\Users\Farias\source\repos\ExameTeste\ExameTeste\Views\Pessoas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(466, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(522, 42, false);
#line 19 "C:\Users\Farias\source\repos\ExameTeste\ExameTeste\Views\Pessoas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Active));

#line default
#line hidden
            EndContext();
            BeginContext(564, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(620, 47, false);
#line 22 "C:\Users\Farias\source\repos\ExameTeste\ExameTeste\Views\Pessoas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FaixaEtaria));

#line default
#line hidden
            EndContext();
            BeginContext(667, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 27 "C:\Users\Farias\source\repos\ExameTeste\ExameTeste\Views\Pessoas\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(779, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(840, 39, false);
#line 31 "C:\Users\Farias\source\repos\ExameTeste\ExameTeste\Views\Pessoas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(879, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(947, 38, false);
#line 34 "C:\Users\Farias\source\repos\ExameTeste\ExameTeste\Views\Pessoas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
            EndContext();
            BeginContext(985, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1053, 44, false);
#line 37 "C:\Users\Farias\source\repos\ExameTeste\ExameTeste\Views\Pessoas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1165, 41, false);
#line 40 "C:\Users\Farias\source\repos\ExameTeste\ExameTeste\Views\Pessoas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Active));

#line default
#line hidden
            EndContext();
            BeginContext(1206, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1274, 46, false);
#line 43 "C:\Users\Farias\source\repos\ExameTeste\ExameTeste\Views\Pessoas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FaixaEtaria));

#line default
#line hidden
            EndContext();
            BeginContext(1320, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 46 "C:\Users\Farias\source\repos\ExameTeste\ExameTeste\Views\Pessoas\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1375, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ExameTeste.Models.Pessoa>> Html { get; private set; }
    }
}
#pragma warning restore 1591