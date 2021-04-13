#pragma checksum "C:\Users\gabri\Desktop\PROJETOS\Tars\TARSGabrielMoraraRibeiro\TARSGabrielMoraraRibeiro\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "927e0c578ce5065e2cab78de7e8f8e961b8c7e94"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"927e0c578ce5065e2cab78de7e8f8e961b8c7e94", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d8855c4e635dd9293a6138c2425e00b6f79ead7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\gabri\Desktop\PROJETOS\Tars\TARSGabrielMoraraRibeiro\TARSGabrielMoraraRibeiro\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>

    label {
        font-weight: bold
    }

    .container {
        width: 100%
    }

    .common_box_body {
        padding: 15px;
        border: 12px solid #3ca85c;
        border-color: #28BAA2;
        border-radius: 15px;
        margin-top: 10px;
        background: #f2fff6;
    }
</style>

<div class=""container"">
    <div class=""panel panel-default"">
        <div class=""common_box_body panel-body"">
            <div class=""col-md-6"">
                <span class=""login100-form-logo"">
                    <i class=""zmdi zmdi-landscape""></i>
                </span>
                <h1>Bem-vindo</h1>
                <p>Faça seu login para continuar.</p>
                <div class=""ibox-content"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "927e0c578ce5065e2cab78de7e8f8e961b8c7e944692", async() => {
                WriteLiteral(@"
                        <div class=""form-group"">
                            <span>CPF: </span>
                            <input type=""text"" id=""cpf"" name=""cpf"" class=""form-control"" data-bind=""value: cpf"" onkeydown=""javascript: fMasc( this, mCPF );"">
                        </div>
                        <div class=""form-group"">
                            <span>Senha: </span>
                            <input type=""password"" class=""form-control"" data-bind=""value: password"">
                        </div>

                        <span id=""error"" class=""error"" style=""color: red;"" data-bind=""text: errorMsg""></span>

                        <br />

                        <div class=""form-group"">
                            <div class=""center"">
                                <button style=""width: 50%"" type=""button"" class=""btn btn-success"" data-bind=""click: authenticateUser"">
                                    <span class=""glyphicon glyphicon glyphicon-floppy-disk"" aria-hidden=""true""><b>En");
                WriteLiteral(@"trar</b></span>
                                </button>
                            </div>
                            <br />
                            <div>
                                <p>ou</p>
                            </div>
                            <div>
                                <a class=""btn btn-sm btn-blue "" href=""register"">Criar uma conta.</a>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
    <hr>
</div>

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
                    error: function (xhr, ajaxOptions, thrownError)");
            WriteLiteral(@" {
                        self.errorMsg(JSON.parse(xhr.responseText));
                    }
                });
            }
        } catch (e) {
            console.log(e);
        }
    }

    var vm = new ViewModel();

    // ativa knockout.js
    ko.applyBindings(vm);

</script>
");
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
