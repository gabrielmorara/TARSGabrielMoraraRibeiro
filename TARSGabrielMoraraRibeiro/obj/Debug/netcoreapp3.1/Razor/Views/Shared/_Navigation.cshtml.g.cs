#pragma checksum "C:\Users\gabri\Desktop\PROJETOS\Tars\TARSGabrielMoraraRibeiro\TARSGabrielMoraraRibeiro\Views\Shared\_Navigation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "315e7310eaf51d05e1b046f983133bd606a06d98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Navigation), @"mvc.1.0.view", @"/Views/Shared/_Navigation.cshtml")]
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
#line 1 "C:\Users\gabri\Desktop\PROJETOS\Tars\TARSGabrielMoraraRibeiro\TARSGabrielMoraraRibeiro\Views\_ViewImports.cshtml"
using TARSGabrielMoraraRibeiro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gabri\Desktop\PROJETOS\Tars\TARSGabrielMoraraRibeiro\TARSGabrielMoraraRibeiro\Views\_ViewImports.cshtml"
using TARSGabrielMoraraRibeiro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"315e7310eaf51d05e1b046f983133bd606a06d98", @"/Views/Shared/_Navigation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d8855c4e635dd9293a6138c2425e00b6f79ead7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Navigation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Products/ListProducts"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Products/NewProduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Category/Category"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Perfil"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Logout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- bootstrap 3.0 -->
<!-- template: https://bootsnipp.com/snippets/Qb83E -->
<link href=""//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js""></script>

<style>
    .nav .open > a,
    .nav .open > a:hover,
    .nav .open > a:focus {
        background-color: transparent;
    }

    /*-------------------------------*/
    /*           Wrappers            */
    /*-------------------------------*/

    #wrapper {
        padding-left: 0;
        -webkit-transition: all 0.5s ease;
        -moz-transition: all 0.5s ease;
        -o-transition: all 0.5s ease;
        transition: all 0.5s ease;
    }

        #wrapper.toggled {
            padding-left: 220px;
        }

    #sidebar-wrapper {
        z-index: 1000;
        left: 220px;
        width: 0;
        height: 100%;
        margin-left: -220px;
        overflow-y: auto;
        overflow-x: hidden;
        background: #1a1a1a;
   ");
            WriteLiteral(@"     -webkit-transition: all 0.5s ease;
        -moz-transition: all 0.5s ease;
        -o-transition: all 0.5s ease;
        transition: all 0.5s ease;
    }

        #sidebar-wrapper::-webkit-scrollbar {
            display: none;
        }

    #wrapper.toggled #sidebar-wrapper {
        width: 220px;
    }

    #page-content-wrapper {
        width: 100%;
        padding-top: 70px;
    }

    #wrapper.toggled #page-content-wrapper {
        margin-right: -220px;
    }

    /*-------------------------------*/
    /*     Sidebar nav styles        */
    /*-------------------------------*/

    .sidebar-nav {
        position: absolute;
        top: 0;
        width: 220px;
        margin: 0;
        padding: 0;
        list-style: none;
    }

        .sidebar-nav li {
            position: relative;
            line-height: 20px;
            display: inline-block;
            width: 100%;
        }

            .sidebar-nav li:before {
                content: '';
                position: absolute;
      ");
            WriteLiteral(@"          top: 0;
                left: 0;
                z-index: -1;
                height: 100%;
                width: 3px;
                background-color: #1c1c1c;
                -webkit-transition: width .2s ease-in;
                -moz-transition: width .2s ease-in;
                -ms-transition: width .2s ease-in;
                transition: width .2s ease-in;
            }

            .sidebar-nav li:first-child a {
                color: #fff;
                background-color: #1a1a1a;
            }

            .sidebar-nav li:nth-child(2):before {
                background-color: #ec1b5a;
            }

            .sidebar-nav li:nth-child(3):before {
                background-color: #79aefe;
            }

            .sidebar-nav li:nth-child(4):before {
                background-color: #314190;
            }

            .sidebar-nav li:nth-child(5):before {
                background-color: #279636;
            }

            .sidebar-nav li:nth-child(6):before {
                ba");
            WriteLiteral(@"ckground-color: #7d5d81;
            }

            .sidebar-nav li:nth-child(7):before {
                background-color: #ead24c;
            }

            .sidebar-nav li:nth-child(8):before {
                background-color: #2d2366;
            }

            .sidebar-nav li:nth-child(9):before {
                background-color: #35acdf;
            }

            .sidebar-nav li:hover:before,
            .sidebar-nav li.open:hover:before {
                width: 100%;
                -webkit-transition: width .2s ease-in;
                -moz-transition: width .2s ease-in;
                -ms-transition: width .2s ease-in;
                transition: width .2s ease-in;
            }

            .sidebar-nav li a {
                display: block;
                color: #ddd;
                text-decoration: none;
                padding: 10px 15px 10px 30px;
            }

                .sidebar-nav li a:hover,
                .sidebar-nav li a:active,
                .sidebar-nav li a:focus,
    ");
            WriteLiteral(@"            .sidebar-nav li.open a:hover,
                .sidebar-nav li.open a:active,
                .sidebar-nav li.open a:focus {
                    color: #fff;
                    text-decoration: none;
                    background-color: transparent;
                }

        .sidebar-nav > .sidebar-brand {
            height: 65px;
            font-size: 20px;
            line-height: 44px;
        }

        .sidebar-nav .dropdown-menu {
            position: relative;
            width: 100%;
            padding: 0;
            margin: 0;
            border-radius: 0;
            border: none;
            background-color: #222;
            box-shadow: none;
        }

    /*-------------------------------*/
    /*       Hamburger-Cross         */
    /*-------------------------------*/

    .hamburger {
        position: absolute;
        top: 20px;
        z-index: 999;
        display: block;
        width: 32px;
        height: 32px;
        margin-left: -100px;
        background: transpa");
            WriteLiteral(@"rent;
        border: none;
    }

        .hamburger:hover,
        .hamburger:focus,
        .hamburger:active {
            outline: none;
        }

        .hamburger.is-closed:before {
            content: '';
            display: block;
            width: 100px;
            font-size: 14px;
            color: #fff;
            line-height: 32px;
            text-align: center;
            opacity: 0;
            -webkit-transform: translate3d(0,0,0);
            -webkit-transition: all .35s ease-in-out;
        }

        .hamburger.is-closed:hover:before {
            opacity: 1;
            display: block;
            -webkit-transform: translate3d(-100px,0,0);
            -webkit-transition: all .35s ease-in-out;
        }

        .hamburger.is-closed .hamb-top,
        .hamburger.is-closed .hamb-middle,
        .hamburger.is-closed .hamb-bottom,
        .hamburger.is-open .hamb-top,
        .hamburger.is-open .hamb-middle,
        .hamburger.is-open .hamb-bottom {
            position: absolute;
 ");
            WriteLiteral(@"           left: 0;
            height: 4px;
            width: 100%;
        }

        .hamburger.is-closed .hamb-top,
        .hamburger.is-closed .hamb-middle,
        .hamburger.is-closed .hamb-bottom {
            background-color: #1a1a1a;
        }

        .hamburger.is-closed .hamb-top {
            top: 5px;
            -webkit-transition: all .35s ease-in-out;
        }

        .hamburger.is-closed .hamb-middle {
            top: 50%;
            margin-top: -2px;
        }

        .hamburger.is-closed .hamb-bottom {
            bottom: 5px;
            -webkit-transition: all .35s ease-in-out;
        }

        .hamburger.is-closed:hover .hamb-top {
            top: 0;
            -webkit-transition: all .35s ease-in-out;
        }

        .hamburger.is-closed:hover .hamb-bottom {
            bottom: 0;
            -webkit-transition: all .35s ease-in-out;
        }

        .hamburger.is-open .hamb-top,
        .hamburger.is-open .hamb-middle,
        .hamburger.is-open .hamb-bottom {
      ");
            WriteLiteral(@"      background-color: #1a1a1a;
        }

        .hamburger.is-open .hamb-top,
        .hamburger.is-open .hamb-bottom {
            top: 50%;
            margin-top: -2px;
        }

        .hamburger.is-open .hamb-top {
            -webkit-transform: rotate(45deg);
            -webkit-transition: -webkit-transform .2s cubic-bezier(.73,1,.28,.08);
        }

        .hamburger.is-open .hamb-middle {
            display: none;
        }

        .hamburger.is-open .hamb-bottom {
            -webkit-transform: rotate(-45deg);
            -webkit-transition: -webkit-transform .2s cubic-bezier(.73,1,.28,.08);
        }

        .hamburger.is-open:before {
            content: '';
            display: block;
            width: 100px;
            font-size: 14px;
            color: #fff;
            line-height: 32px;
            text-align: center;
            opacity: 0;
            -webkit-transform: translate3d(0,0,0);
            -webkit-transition: all .35s ease-in-out;
        }

        .hamburger.is-o");
            WriteLiteral(@"pen:hover:before {
            opacity: 1;
            display: block;
            -webkit-transform: translate3d(-100px,0,0);
            -webkit-transition: all .35s ease-in-out;
        }

    /*-------------------------------*/
    /*            Overlay            */
    /*-------------------------------*/

    .overlay {
        position: fixed;
        display: none;
        width: 100%;
        height: 100%;
        top: 0;
        left: 0;
        right: 0;
        bottom: 0;
        background-color: rgba(250,250,250,.8);
        z-index: 1;
    }

    #menu-products {
        padding-left: 30px;
    }
</style>

<div id=""wrapper"">
    <div class=""overlay""></div>

    <!-- Sidebar -->
    <nav class=""navbar navbar-inverse navbar-fixed-top"" id=""sidebar-wrapper"" role=""navigation"">
        <ul class=""nav sidebar-nav"">
            <li class=""sidebar-brand"">
                <a href=""#"">
                    Menu
                </a>
            </li>
            <li class=""dropdown"">
                <a href");
            WriteLiteral("=\"#\" class=\"dropdown-toggle\" data-toggle=\"dropdown\">Produtos </a>\n                <ul role=\"menu\" id=\"menu-products\">\n                    <li style=\" all: unset;\"><a href=\"#\"></a></li>\n                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "315e7310eaf51d05e1b046f983133bd606a06d9814790", async() => {
                WriteLiteral("Listar Produtos");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "315e7310eaf51d05e1b046f983133bd606a06d9815902", async() => {
                WriteLiteral("Novo Produto");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n                </ul>\n            </li>\n            <li class=\"dropdown\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "315e7310eaf51d05e1b046f983133bd606a06d9817082", async() => {
                WriteLiteral("Categorias ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </li>\n            <li>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "315e7310eaf51d05e1b046f983133bd606a06d9818214", async() => {
                WriteLiteral("Perfil");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </li>\n            <li>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "315e7310eaf51d05e1b046f983133bd606a06d9819341", async() => {
                WriteLiteral("<i class=\"fa fa-sign-out fa-lg\" style=\"color:white;\"></i> Sair");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </li>
        </ul>
    </nav>

    <div id=""page-content-wrapper"">
        <button type=""button"" class=""hamburger is-closed"" data-toggle=""offcanvas"">
            <span class=""hamb-top""></span>
            <span class=""hamb-middle""></span>
            <span class=""hamb-bottom""></span>
        </button>
    </div>
</div>

<script>
    $(document).ready(function () {
        var trigger = $('.hamburger'),
            overlay = $('.overlay'),
            isClosed = false;

        trigger.click(function () {
            hamburger_cross();
        });

        function hamburger_cross() {

            if (isClosed == true) {
                overlay.hide();
                trigger.removeClass('is-open');
                trigger.addClass('is-closed');
                isClosed = false;
            } else {
                overlay.show();
                trigger.removeClass('is-closed');
                trigger.addClass('is-open');
                isClosed = true;
            }
        }

        $('[dat");
            WriteLiteral("a-toggle=\"offcanvas\"]\').click(function () {\n            $(\'#wrapper\').toggleClass(\'toggled\');\n        });\n    });\n</script>\n");
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
