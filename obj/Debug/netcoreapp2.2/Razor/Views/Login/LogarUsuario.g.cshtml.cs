#pragma checksum "D:\pen drive\PontoDigitalFinal\Views\Login\LogarUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33f491a9ffb813c6895e45142beb9a401293268b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_LogarUsuario), @"mvc.1.0.view", @"/Views/Login/LogarUsuario.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/LogarUsuario.cshtml", typeof(AspNetCore.Views_Login_LogarUsuario))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33f491a9ffb813c6895e45142beb9a401293268b", @"/Views/Login/LogarUsuario.cshtml")]
    public class Views_Login_LogarUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 12, true);
            WriteLiteral("\r\n\r\n<h2>Olá ");
            EndContext();
            BeginContext(13, 20, false);
#line 3 "D:\pen drive\PontoDigitalFinal\Views\Login\LogarUsuario.cshtml"
   Write(ViewData["NomeView"]);

#line default
#line hidden
            EndContext();
            BeginContext(33, 45, true);
            WriteLiteral("</h2>\r\n<h2>Cadastro de duvida</h2>\r\n    <form");
            EndContext();
            BeginWriteAttribute("action", " action=\'", 78, "\'", 128, 1);
#line 5 "D:\pen drive\PontoDigitalFinal\Views\Login\LogarUsuario.cshtml"
WriteAttributeValue("", 87, Url.Action("CadastroDeDuvida","Duvidas"), 87, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(129, 166, true);
            WriteLiteral(" method=\"POST\">\r\n        <br>\r\n        <label for=\"nome\">Digite o seu nome</label>\r\n        <br>\r\n        <input type=\"text\" placeholder=\"Nome do Usuario\" name=\"nome\"");
            EndContext();
            BeginWriteAttribute("value", " value=\'", 295, "\'", 324, 1);
#line 9 "D:\pen drive\PontoDigitalFinal\Views\Login\LogarUsuario.cshtml"
WriteAttributeValue("", 303, ViewData["NomeView"], 303, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(325, 412, true);
            WriteLiteral(@">
        <br>

        
        <label for=""titulo"">Digite o Titulo</label>
        <br>
        <input type=""text"" placeholder=""Titulo da duvida"" name=""titulo"">
        <br>


        <label for=""texto"">Ditige o Texto</label>
        <br>
        <input type=""text"" placeholder=""Texto"" maxlength=""100"" name=""texto"">
        <br>
        
        <input type=""submit"" value=""enviar"">
    </form>");
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