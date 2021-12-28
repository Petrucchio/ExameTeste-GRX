#pragma checksum "C:\Users\Farias\Documents\GitHub\ExameTeste-GRX\ExameTeste\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c4d0d838d364e64cea874ad5d96b56c82414a1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\Farias\Documents\GitHub\ExameTeste-GRX\ExameTeste\Views\_ViewImports.cshtml"
using ExameTeste;

#line default
#line hidden
#line 2 "C:\Users\Farias\Documents\GitHub\ExameTeste-GRX\ExameTeste\Views\_ViewImports.cshtml"
using ExameTeste.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c4d0d838d364e64cea874ad5d96b56c82414a1c", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3442106fc004dbacfc723d4b994019f8aab4e413", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Farias\Documents\GitHub\ExameTeste-GRX\ExameTeste\Views\Home\About.cshtml"
  
    ViewData["Title"] = "Sobre A Aplicação";

#line default
#line hidden
            BeginContext(53, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(58, 17, false);
#line 4 "C:\Users\Farias\Documents\GitHub\ExameTeste-GRX\ExameTeste\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(75, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(87, 19, false);
#line 5 "C:\Users\Farias\Documents\GitHub\ExameTeste-GRX\ExameTeste\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(106, 2382, true);
            WriteLiteral(@"</h3>

<p>Essa aplicação foi desenvolvida utilizando .Net core (versão 2.1),jQuery 3.6.0 , banco de dados SQLServer e bootstrap 3</p>
<hr />
<p>A Aplicação organiza as pessoas pelo seu setor de faixa etaria pré deifinido durante o cadastro</p>
<p>A validação dos dados cadastrados é realizada tanto pelo JavaScript quanto pelo Controller da Aplicação, assim 
    prevenindo o cadastro de dados inválidos mesmo quando quando o JavaScript do Usuário estiver desabilitado
</p>
<p>O controller conversa com a camada de Services</p>
<p>Exceptions do nivel de acesso a dado são capturados pelo Service e relançadas na forma de ServicesExceptions para o Controller</p>
<p>Localização padrão da Aplicação definida como Estados Unidos(América do Norte)</p>
<p>Em caso do banco de Dados definido não conter dados pré cadastrados o SeedingService Proverá dados e realizará o cadastro automático para a execução</p> 
<p>Para definir as configurações do Banco de dados, atualize o arquivo appsettings.json</p>
<p>Operações c");
            WriteLiteral(@"om o banco de dados funcionam de forma Assíncrona para otimização de tempo da aplicação</p>
<p>Utiliza AntiForgeryToken para impedir falsificação de solicitação entre sites (XSRF/CSRF)</p>
<p>A ação de Deletar implementada em pessoa é meramente lógica, assim considerando uma variavel booleana que quando desativada impede que a pessoa seja chamada na lista</p>
<p>A Organização da lista é Descrescente por idade, mostrando assim o mais velho até o mais novo</p> 
<p>Realiza Pesquisas por Data de Nascimento mantendo na barra de pesquisa os valores pesquisados anteriormente, caso nenhum valor seja inserido, a data mínima será o inicio do ano atual e a máxima será a data atual, dados são mostrados em ordem decrescente de acordo com a idade</p>
<p>Realiza Pesquisas por Idade mantendo na barra de pesquisa os valores pesquisados anteriormente, caso nenhum valor seja indicado, todas as idades serão mostradas em ordem descrescente</p>
<p>Realiza Pesquisas por Nome mantendo na barra de pesquisa o valor pesquisado an");
            WriteLiteral(@"teriormente, caso nenhum valor seja indicado, todas as pessoas serão mostradas em ordem descrescente de acordo com a idade</p>
<p>Realiza Pesquisas por Faixa Etaria não permitindo campo vazio e ordenando pela idade de modo descrescente</p>
<p>Em todas as pesquisas somente serão mostradas as pessoas ativas no banco de dados</p>

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
