#pragma checksum "C:\Users\gabri\Desktop\PROJETOS\Tars\TARSGabrielMoraraRibeiro\TARSGabrielMoraraRibeiro\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61fd6c80670a23ea1f6a5c10c269eb02a3daa67e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61fd6c80670a23ea1f6a5c10c269eb02a3daa67e", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d8855c4e635dd9293a6138c2425e00b6f79ead7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>

    /* BASIC */
    html {
        background-color: #f2fff6;
    }

    /* STRUCTURE */
    .wrapper {
        display: flex;
        align-items: center;
        flex-direction: column;
        justify-content: center;
        width: 100%;
        min-height: 100%;
        padding: 20px;
    }

    #formContent {
        -webkit-border-radius: 10px 10px 10px 10px;
        border-radius: 10px 10px 10px 10px;
        background: #fff;
        padding: 30px;
        width: 90%;
        max-width: 450px;
        position: relative;
        padding: 0px;
        -webkit-box-shadow: 0 30px 60px 0 rgba(0,0,0,0.3);
        box-shadow: 0 30px 60px 0 rgba(0,0,0,0.3);
        text-align: center;
    }

    #formFooter {
        background-color: #f6f6f6;
        border-top: 1px solid #dce8f1;
        padding: 25px;
        text-align: center;
        -webkit-border-radius: 0 0 10px 10px;
        border-radius: 0 0 10px 10px;
    }

    /* ANIMATIONS */

    /* Simple");
            WriteLiteral(@" CSS3 Fade-in-down Animation */
    .fadeInDown {
        -webkit-animation-name: fadeInDown;
        animation-name: fadeInDown;
        -webkit-animation-duration: 1s;
        animation-duration: 1s;
        -webkit-animation-fill-mode: both;
        animation-fill-mode: both;
    }

    ");
            WriteLiteral(@"@-webkit-keyframes fadeInDown {
        0% {
            opacity: 0;
            -webkit-transform: translate3d(0, -100%, 0);
            transform: translate3d(0, -100%, 0);
        }

        100% {
            opacity: 1;
            -webkit-transform: none;
            transform: none;
        }
    }

    ");
            WriteLiteral(@"@keyframes fadeInDown {
        0% {
            opacity: 0;
            -webkit-transform: translate3d(0, -100%, 0);
            transform: translate3d(0, -100%, 0);
        }

        100% {
            opacity: 1;
            -webkit-transform: none;
            transform: none;
        }
    }

    /* Simple CSS3 Fade-in Animation */
    ");
            WriteLiteral("@-webkit-keyframes fadeIn {\r\n        from {\r\n            opacity: 0;\r\n        }\r\n\r\n        to {\r\n            opacity: 1;\r\n        }\r\n    }\r\n\r\n    ");
            WriteLiteral("@-moz-keyframes fadeIn {\r\n        from {\r\n            opacity: 0;\r\n        }\r\n\r\n        to {\r\n            opacity: 1;\r\n        }\r\n    }\r\n\r\n    ");
            WriteLiteral(@"@keyframes fadeIn {
        from {
            opacity: 0;
        }

        to {
            opacity: 1;
        }
    }

    .fadeIn {
        opacity: 0;
        -webkit-animation: fadeIn ease-in 1;
        -moz-animation: fadeIn ease-in 1;
        animation: fadeIn ease-in 1;
        -webkit-animation-fill-mode: forwards;
        -moz-animation-fill-mode: forwards;
        animation-fill-mode: forwards;
        -webkit-animation-duration: 1s;
        -moz-animation-duration: 1s;
        animation-duration: 1s;
    }

        .fadeIn.first {
            -webkit-animation-delay: 0.4s;
            -moz-animation-delay: 0.4s;
            animation-delay: 0.4s;
        }

        .fadeIn.second {
            -webkit-animation-delay: 0.6s;
            -moz-animation-delay: 0.6s;
            animation-delay: 0.6s;
        }

        .fadeIn.third {
            -webkit-animation-delay: 0.8s;
            -moz-animation-delay: 0.8s;
            animation-delay: 0.8s;
        ");
            WriteLiteral(@"}

        .fadeIn.fourth {
            -webkit-animation-delay: 1s;
            -moz-animation-delay: 1s;
            animation-delay: 1s;
        }

    /* Simple CSS3 Fade-in Animation */
    .underlineHover:after {
        display: block;
        left: 0;
        bottom: -10px;
        width: 0;
        height: 2px;
        background-color: #56baed;
        content: """";
        transition: width 0.2s;
    }

    .underlineHover:hover {
        color: #0d0d0d;
    }

        .underlineHover:hover:after {
            width: 100%;
        }


    /* OTHERS */

    *:focus {
        outline: none;
    }

    #icon {
        width: 60%;
        width: 40%;
        padding: 10px;
    }

    ::-webkit-input-placeholder {
        text-align: center;
    }

    .center {
        display: inline;
    }
</style>

<div class=""wrapper fadeInDown"">
    <div id=""formContent"">

        <!-- Icon -->
        <div class=""fadeIn first"">
            <img src=""https://bu");
            WriteLiteral("cket-tarsresources.s3-sa-east-1.amazonaws.com/images/sobre-a-tars-1585858150.jpg\" id=\"icon\" alt=\"Icon\" />\r\n        </div>\r\n\r\n        <!-- Login Form -->\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61fd6c80670a23ea1f6a5c10c269eb02a3daa67e8159", async() => {
                WriteLiteral(@"

            <br />
            <div class=""form-group"">
                <input style=""width: 50%"" type=""text"" id=""cpf"" name=""cpf"" class=""form-control center"" placeholder=""CPF"" data-bind=""value: cpf"" onkeydown=""javascript: fMasc( this, mCPF );"">
            </div>

            <div class=""form-group"">
                <input style=""width: 50%"" type=""password"" class=""form-control center"" placeholder=""Senha"" data-bind=""value: password"">
            </div>

            <span id=""error"" class=""error"" style=""color: red;"" data-bind=""text: errorMsg""></span>

            <br />
            <br />

            <div class=""center"">
                <button style=""width: 50%"" type=""button"" class=""btn btn-success"" data-bind=""click: authenticateUser"">
                    <span class=""glyphicon glyphicon glyphicon-floppy-disk"" aria-hidden=""true""><b>Entrar</b></span>
                </button>
            </div>
            <br />

        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        <br />\r\n\r\n        <!-- Registrar -->\r\n        <div id=\"formFooter\">\r\n            <a class=\"underlineHover\" href=\"home/register\">Criar uma conta?</a>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
            WriteLiteral(@"
<script type=""text/javascript"">

    function ViewModel() {
        try {

            var self = this;

            self.cpf = ko.observable("""");
            self.password = ko.observable("""");
            self.errorMsg = ko.observable("""");

            self.authenticateUser = () => {
                $.ajax({
                    type: ""POST"",
                    url: '/Users/AuthenticateUser',
                    data: {
                        cpf: self.cpf(),
                        password: self.password()
                    },
                    success: function (response) {
                        console.log(response);
                        setCookie('UserCPF', self.cpf());
                        setCookie('UserToken', response);
                        window.location.href = '/Home/Index';
                    },
                    error: function (xhr, ajaxOptions, thrownError) {
                        self.errorMsg(JSON.parse(xhr.responseText));
                  ");
            WriteLiteral("  }\r\n                });\r\n            }\r\n        } catch (e) {\r\n            console.log(e);\r\n        }\r\n    }\r\n\r\n    var vm = new ViewModel();\r\n\r\n    // ativa knockout.js\r\n    ko.applyBindings(vm);\r\n\r\n</script>\r\n");
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
