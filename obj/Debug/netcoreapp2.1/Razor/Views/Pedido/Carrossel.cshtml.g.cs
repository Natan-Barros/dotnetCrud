#pragma checksum "C:\Projetos\dotnetCrud\Views\Pedido\Carrossel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3fd1dfa1d77a1550a0a045a1060c346cd3724f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Carrossel), @"mvc.1.0.view", @"/Views/Pedido/Carrossel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedido/Carrossel.cshtml", typeof(AspNetCore.Views_Pedido_Carrossel))]
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
#line 1 "C:\Projetos\dotnetCrud\Views\_ViewImports.cshtml"
using dotnet;

#line default
#line hidden
#line 2 "C:\Projetos\dotnetCrud\Views\_ViewImports.cshtml"
using dotnet.Models;

#line default
#line hidden
#line 3 "C:\Projetos\dotnetCrud\Views\_ViewImports.cshtml"
using dotnetCrud.Models.ViewModels;

#line default
#line hidden
#line 4 "C:\Projetos\dotnetCrud\Views\Pedido\Carrossel.cshtml"
using CasaDoCodigo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3fd1dfa1d77a1550a0a045a1060c346cd3724f4", @"/Views/Pedido/Carrossel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3968702ab3ab5b2715552315786d52b23be13b92", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Carrossel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Produto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "carrinho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Projetos\dotnetCrud\Views\Pedido\Carrossel.cshtml"
  
    ViewData["Title"] = "Carrossel";

#line default
#line hidden
            BeginContext(92, 171, true);
            WriteLiteral("    \n<h3>Catálogo</h3>\n\n<div id=\"my-carousel\" class=\"carousel slide\" data-ride=\"carousel\">\n    <!-- Wrapper for slides -->\n    <div class=\"carousel-inner\" role=\"listbox\">\n");
            EndContext();
#line 12 "C:\Projetos\dotnetCrud\Views\Pedido\Carrossel.cshtml"
          
            const int TAMANHO_PAGINA = 4;
            int paginas = (int) Math.Ceiling((double) Model.Count / TAMANHO_PAGINA);
        

#line default
#line hidden
            BeginContext(411, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 16 "C:\Projetos\dotnetCrud\Views\Pedido\Carrossel.cshtml"
         for(int i = 0; i < paginas; i++){

#line default
#line hidden
            BeginContext(454, 14, true);
            WriteLiteral("          <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 468, "\"", 506, 2);
            WriteAttributeValue("", 476, "item", 476, 4, true);
#line 17 "C:\Projetos\dotnetCrud\Views\Pedido\Carrossel.cshtml"
WriteAttributeValue(" ", 480, i == 0 ? "active" : "", 481, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(507, 33, true);
            WriteLiteral(">\n             <div class=\"row\">\n");
            EndContext();
#line 19 "C:\Projetos\dotnetCrud\Views\Pedido\Carrossel.cshtml"
                   
                     var produtosDaPagina = Model.Skip(i * TAMANHO_PAGINA).Take(TAMANHO_PAGINA);
                 

#line default
#line hidden
            BeginContext(676, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 23 "C:\Projetos\dotnetCrud\Views\Pedido\Carrossel.cshtml"
                  foreach (var produto in produtosDaPagina)
                 {
                        

#line default
#line hidden
            BeginContext(781, 242, true);
            WriteLiteral("                     <div class=\"col-md-3 col-sm-3 col-lg-3\">\n                         <div class=\"panel panel-default\">\n                             <div class=\"panel-body\">\n                                 <img class=\"img-produto-carrossel\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1023, "\"", 1073, 3);
            WriteAttributeValue("", 1029, "/images/produtos/large_", 1029, 23, true);
#line 29 "C:\Projetos\dotnetCrud\Views\Pedido\Carrossel.cshtml"
WriteAttributeValue("", 1052, produto.Codigo, 1052, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 1069, ".jpg", 1069, 4, true);
            EndWriteAttribute();
            BeginContext(1074, 170, true);
            WriteLiteral(" />\n                             </div>\n                             <div class=\"panel-footer produto-footer\">\n                                 <div class=\"produto-nome\">");
            EndContext();
            BeginContext(1245, 12, false);
#line 32 "C:\Projetos\dotnetCrud\Views\Pedido\Carrossel.cshtml"
                                                      Write(produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1257, 60, true);
            WriteLiteral("</div>\n                                 <div><h4><strong>R$ ");
            EndContext();
            BeginContext(1318, 13, false);
#line 33 "C:\Projetos\dotnetCrud\Views\Pedido\Carrossel.cshtml"
                                                Write(produto.Preco);

#line default
#line hidden
            EndContext();
            BeginContext(1331, 117, true);
            WriteLiteral("</strong></h4></div>\n                                 <div class=\"text-center\">\n                                     ");
            EndContext();
            BeginContext(1448, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f45ba546587f4b9ab31a74e452bb5066", async() => {
                BeginContext(1534, 9, true);
                WriteLiteral("Adicionar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-codigo", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "C:\Projetos\dotnetCrud\Views\Pedido\Carrossel.cshtml"
                                                                     WriteLiteral(produto.Codigo);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["codigo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-codigo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["codigo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1547, 137, true);
            WriteLiteral("\n                                 </div>\n                             </div>\n                         </div>\n                     </div>\n");
            EndContext();
#line 40 "C:\Projetos\dotnetCrud\Views\Pedido\Carrossel.cshtml"
                 }

#line default
#line hidden
            BeginContext(1703, 38, true);
            WriteLiteral("            </div>\n\n\n          </div>\n");
            EndContext();
#line 45 "C:\Projetos\dotnetCrud\Views\Pedido\Carrossel.cshtml"
        }

#line default
#line hidden
            BeginContext(1751, 492, true);
            WriteLiteral(@"    </div>

    <!-- Controls -->
    <a class=""left carousel-control"" href=""#my-carousel"" role=""button"" data-slide=""prev"">
        <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""right carousel-control"" href=""#my-carousel"" role=""button"" data-slide=""next"">
        <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
