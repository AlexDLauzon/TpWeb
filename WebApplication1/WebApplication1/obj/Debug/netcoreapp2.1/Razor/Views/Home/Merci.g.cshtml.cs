#pragma checksum "D:\Informatique Session 5\Développement d'application web\Cours 17\WebApplication1\WebApplication1\Views\Home\Merci.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e7169b721d9413ecd06f5afbecdf0b4fac3e1fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Merci), @"mvc.1.0.view", @"/Views/Home/Merci.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Merci.cshtml", typeof(AspNetCore.Views_Home_Merci))]
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
#line 1 "D:\Informatique Session 5\Développement d'application web\Cours 17\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using BonAnniversaireToto;

#line default
#line hidden
#line 2 "D:\Informatique Session 5\Développement d'application web\Cours 17\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using BonAnniversaireToto.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e7169b721d9413ecd06f5afbecdf0b4fac3e1fe", @"/Views/Home/Merci.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01c34e28955f792b862d7f8eb2d042fd3af58b8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Merci : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BonAnniversaireToto.Models.Invitation>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Informatique Session 5\Développement d'application web\Cours 17\WebApplication1\WebApplication1\Views\Home\Merci.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(75, 22, true);
            WriteLiteral("\r\n<!DOCTYPE>\r\n<html>\r\n");
            EndContext();
            BeginContext(97, 324, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63b8cf87550d48a4ad03ff57079497e5", async() => {
                BeginContext(103, 311, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <link rel=""stylesheet"" href=""/css/styles.css"" />
    <link rel=""stylesheet"" href=""/lib/bootstrap/dist/css/bootstrap.css"" />
    <title>Merci</title>
    <style>
        body {
            background-color: #f1f1f1;
        }
    </style>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(421, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(423, 541, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3290f525d02469293675dfcf629723a", async() => {
                BeginContext(429, 51, true);
                WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h1>Merci ");
                EndContext();
                BeginContext(481, 9, false);
#line 22 "D:\Informatique Session 5\Développement d'application web\Cours 17\WebApplication1\WebApplication1\Views\Home\Merci.cshtml"
             Write(Model.Nom);

#line default
#line hidden
                EndContext();
                BeginContext(490, 37, true);
                WriteLiteral(" !</h1>\r\n        <div class=\"lead\">\r\n");
                EndContext();
#line 24 "D:\Informatique Session 5\Développement d'application web\Cours 17\WebApplication1\WebApplication1\Views\Home\Merci.cshtml"
             if (Model.SeraPrésent == true)
            {

#line default
#line hidden
                BeginContext(587, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(605, 69, true);
                WriteLiteral("C\'est cool que vous puissiez venir, il y a du drinks dans le frigo.\r\n");
                EndContext();
#line 27 "D:\Informatique Session 5\Développement d'application web\Cours 17\WebApplication1\WebApplication1\Views\Home\Merci.cshtml"
            }
            else
            {

#line default
#line hidden
                BeginContext(722, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(740, 33, true);
                WriteLiteral("Dommage, merci de m\'en avertir.\r\n");
                EndContext();
#line 31 "D:\Informatique Session 5\Développement d'application web\Cours 17\WebApplication1\WebApplication1\Views\Home\Merci.cshtml"
            }

#line default
#line hidden
                BeginContext(788, 35, true);
                WriteLiteral("            <p>\r\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 823, "\"", 865, 1);
#line 33 "D:\Informatique Session 5\Développement d'application web\Cours 17\WebApplication1\WebApplication1\Views\Home\Merci.cshtml"
WriteAttributeValue("", 830, Url.Action("AfficherRSVP", "Home"), 830, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(866, 91, true);
                WriteLiteral(">Voir</a> les frippons qui seront présents.\r\n            </p>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(964, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BonAnniversaireToto.Models.Invitation> Html { get; private set; }
    }
}
#pragma warning restore 1591
