#pragma checksum "C:\Users\50473694808\Desktop\C#\Projetos.Web\Senai.Finacas.Web.Mvc\Views\Usuario\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a5e0ccc67415337c4b5d51b511269725274b4c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Listar), @"mvc.1.0.view", @"/Views/Usuario/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Listar.cshtml", typeof(AspNetCore.Views_Usuario_Listar))]
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
#line 1 "C:\Users\50473694808\Desktop\C#\Projetos.Web\Senai.Finacas.Web.Mvc\Views\Usuario\Listar.cshtml"
using Senai.Finacas.Web.Mvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a5e0ccc67415337c4b5d51b511269725274b4c8", @"/Views/Usuario/Listar.cshtml")]
    public class Views_Usuario_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 163, true);
            WriteLiteral("<h3>Listagem de Usuários</h3>\r\n\r\n<table>\r\n    <thead>\r\n        <th>Nome</th>\r\n        <th>Email</th>\r\n        <th>Data Nascimento</th>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 11 "C:\Users\50473694808\Desktop\C#\Projetos.Web\Senai.Finacas.Web.Mvc\Views\Usuario\Listar.cshtml"
        foreach (var item in ViewData["Usuarios"] as List<UsuarioModel>)
       {

#line default
#line hidden
            BeginContext(285, 59, true);
            WriteLiteral("           <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(345, 9, false);
#line 15 "C:\Users\50473694808\Desktop\C#\Projetos.Web\Senai.Finacas.Web.Mvc\Views\Usuario\Listar.cshtml"
               Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(354, 66, true);
            WriteLiteral("\r\n                <td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(421, 10, false);
#line 18 "C:\Users\50473694808\Desktop\C#\Projetos.Web\Senai.Finacas.Web.Mvc\Views\Usuario\Listar.cshtml"
               Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(431, 66, true);
            WriteLiteral("\r\n                <td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(498, 39, false);
#line 21 "C:\Users\50473694808\Desktop\C#\Projetos.Web\Senai.Finacas.Web.Mvc\Views\Usuario\Listar.cshtml"
               Write(item.DataNascimento.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(537, 42, true);
            WriteLiteral("\r\n                <td>\r\n           </tr>\r\n");
            EndContext();
#line 24 "C:\Users\50473694808\Desktop\C#\Projetos.Web\Senai.Finacas.Web.Mvc\Views\Usuario\Listar.cshtml"
       } 

#line default
#line hidden
            BeginContext(590, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
