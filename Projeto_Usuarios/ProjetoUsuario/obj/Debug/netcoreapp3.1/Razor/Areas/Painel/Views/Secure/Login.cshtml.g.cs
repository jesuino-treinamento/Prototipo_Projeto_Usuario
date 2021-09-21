#pragma checksum "D:\Projeto_Usuarios\ProjetoUsuario\Areas\Painel\Views\Secure\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "791b35092609db45fc285ed6c20131c00fe65af1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Painel_Views_Secure_Login), @"mvc.1.0.view", @"/Areas/Painel/Views/Secure/Login.cshtml")]
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
#nullable restore
#line 1 "D:\Projeto_Usuarios\ProjetoUsuario\Areas\Painel\Views\_ViewImports.cshtml"
using ProjetoUsuario.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projeto_Usuarios\ProjetoUsuario\Areas\Painel\Views\_ViewImports.cshtml"
using ProjetoUsuario.WebApp.Areas.Painel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"791b35092609db45fc285ed6c20131c00fe65af1", @"/Areas/Painel/Views/Secure/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"475a9f5cc28235e6e07e42cd82c825c888c4faaa", @"/Areas/Painel/Views/_ViewImports.cshtml")]
    public class Areas_Painel_Views_Secure_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoUsuario.Models.Dtos.LoginDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projeto_Usuarios\ProjetoUsuario\Areas\Painel\Views\Secure\Login.cshtml"
  
    Layout = "_LayoutLogin";
    ViewBag.Title = "Painel Administrativo v1.0";

    var tempData = TempData["ErroAutenticacao"];
    var erroAutenticacao = tempData != null ? tempData.ToString() : string.Empty;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-4 offset-4"">
        <div class=""login-panel panel panel-default"">
            <div class=""panel-heading"">
                <h3 class=""panel-title"">Autenticar</h3>
            </div>
            <div class=""panel-body"">
");
#nullable restore
#line 17 "D:\Projeto_Usuarios\ProjetoUsuario\Areas\Painel\Views\Secure\Login.cshtml"
                 using (Html.BeginForm("Login", "Secure", new { ReturnUrl = ViewBag.ReturnUrl }, FormMethod.Post, true, new { @class = "col-xs-12", role = "form" }))
                {

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Projeto_Usuarios\ProjetoUsuario\Areas\Painel\Views\Secure\Login.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <fieldset>\n                        <div class=\"form-group\">\n                            ");
#nullable restore
#line 24 "D:\Projeto_Usuarios\ProjetoUsuario\Areas\Painel\Views\Secure\Login.cshtml"
                       Write(Html.TextBoxFor(model => model.Usuario, new { @class = "form-control", placeholder = "Usuário" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 25 "D:\Projeto_Usuarios\ProjetoUsuario\Areas\Painel\Views\Secure\Login.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Usuario, string.Empty, htmlAttributes: new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                        <div class=\"form-group\">\n                            ");
#nullable restore
#line 28 "D:\Projeto_Usuarios\ProjetoUsuario\Areas\Painel\Views\Secure\Login.cshtml"
                       Write(Html.PasswordFor(model => model.Senha, new { @class = "form-control", placeholder = "Senha" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 29 "D:\Projeto_Usuarios\ProjetoUsuario\Areas\Painel\Views\Secure\Login.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Senha, string.Empty, htmlAttributes: new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n");
#nullable restore
#line 31 "D:\Projeto_Usuarios\ProjetoUsuario\Areas\Painel\Views\Secure\Login.cshtml"
                         if (!string.IsNullOrEmpty(erroAutenticacao))
	                    {
		                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            <span class=\"text-danger\">");
#nullable restore
#line 34 "D:\Projeto_Usuarios\ProjetoUsuario\Areas\Painel\Views\Secure\Login.cshtml"
                                                 Write(erroAutenticacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                            ");
#nullable restore
#line 35 "D:\Projeto_Usuarios\ProjetoUsuario\Areas\Painel\Views\Secure\Login.cshtml"
                                   
	                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button type=\"submit\" class=\"btn btn-lg btn-primary btn-block\">Entrar</button>\n                    </fieldset>\n");
#nullable restore
#line 39 "D:\Projeto_Usuarios\ProjetoUsuario\Areas\Painel\Views\Secure\Login.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoUsuario.Models.Dtos.LoginDto> Html { get; private set; }
    }
}
#pragma warning restore 1591