#pragma checksum "C:\Users\gabri\Desktop\PROJETOS\Tars\TARSGabrielMoraraRibeiro\TARSGabrielMoraraRibeiro\Views\Home\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43859eff92efb08d295e2fced4ecbd99b58316a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43859eff92efb08d295e2fced4ecbd99b58316a7", @"/Views/Home/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d8855c4e635dd9293a6138c2425e00b6f79ead7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/seta-voltar.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Voltar para o Login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("registration"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("registration"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>

    .error {
        color: red;
        font-weight: bold;
    }

    label {
        font-weight: bold
    }

    input,
    button {
        border: 0;
        margin-bottom: 3px;
        display: block;
        width: 100%;
    }

    .common_box_body {
        padding: 15px;
        border: 12px solid #3ca85c;
        border-color: #28BAA2;
        border-radius: 15px;
        margin-top: 10px;
        background: #f2fff6;
    }

    .container {
        display: flex;
        align-items: center;
        flex-direction: column;
        justify-content: center;
        width: 100%;
        min-height: 100%;
        padding: 20px;
    }

    .center {
        display: flex;
        justify-content: center;
        align-items: center;
    }
</style>

<div>
    <a href=""javascript:history.back()"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "43859eff92efb08d295e2fced4ecbd99b58316a76154", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" Login
    </a>
</div>

<div class=""container"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""panel panel-default"">
                <div class=""common_box_body panel-body"">
                    <div class=""center"">
                        <h1 style=""font-weight: bold"">Cadastro de Usu??rio</h1>
                    </div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43859eff92efb08d295e2fced4ecbd99b58316a77663", async() => {
                WriteLiteral(@"

                        <div class=""form-group"">
                            <label for=""name"">Nome Completo</label>
                            <p data-bind=""css: { error: name.hasError }"">
                                <input type=""text"" id=""name"" name=""name"" class=""form-control"" data-bind='value: name, valueUpdate: ""afterkeydown""' />
                                <span data-bind='visible: name.hasError, text: name.validationMessage'> </span>
                            </p>
                        </div>

                        <div class=""form-group"">
                            <label for=""cpf"">CPF</label>
                            <input type=""text"" id=""cpf"" name=""cpf"" class=""form-control"" data-bind='value: cpf' maxlength=""14"" onkeydown=""javascript: fMasc( this, mCPF );"" onchange=""validCpf()"">
                            <span id=""cpfError"" class=""error"" style=""display: none;"">O CPF informado ?? invalido</span>
                        </div>

                        <div class=""f");
                WriteLiteral(@"orm-group"">
                            <label for=""email"">Email</label>
                            <input type=""text"" id=""email"" name=""email"" class=""form-control"" data-bind=""value:email"" />
                        </div>

                        <div class=""form-group"">
                            <label for=""password"">Senha</label>
                            <input type=""password"" id=""password"" name=""password"" class=""form-control"" data-bind=""value:password"" />
                        </div>

                        <div class=""form-group"">
                            <label for=""confirmPassword"">Confirmar Senha</label>
                            <input type=""password"" id=""confirmPassword"" name=""confirmPassword"" class=""form-control"" data-bind=""value:confirmPassword"" />
                        </div>

                        <div class=""center"">
                            <button style=""width: 50%"" type=""button"" class=""btn btn-success"" data-bind=""click:createUser, enable:isValiForm()"">
  ");
                WriteLiteral(@"                              <span class=""glyphicon glyphicon glyphicon-floppy-disk"" aria-hidden=""true""><b>Cadastrar</b></span>
                            </button>
                        </div>

                        <div class=""alert alert-success"" role=""alert"" style=""display:none; margin-top: 10px;""> <span class=""glyphicon  glyphicon glyphicon-ok-circle"" aria-hidden=""true""></span> Form has submitted with successful </div>
                        <div class=""alert alert-danger"" role=""alert"" style=""display:none; margin-top: 10px;""> <span class=""glyphicon  glyphicon glyphicon-remove-circle"" aria-hidden=""true""></span> Please check your submission </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" <!-- END FORM-->
                </div> <!-- END BODY-->
            </div> <!-- END PANEL-->
        </div> <!-- END COL-MD-8-->
    </div> <!-- END ROW-->
</div> <!-- END CONTAINER-->

<script type=""text/javascript"">

    $(document).ready(function () {
        $(""#registration"").validate({
            // Specify validation rules
            rules: {
                name: { required: true, minlength: 3 },
                email: {
                    required: true,
                    email: true
                },
                password: {
                    required: true,
                    minlength: 5,
                },
                confirmPassword: {
                    required: true,
                    minlength: 5,
                    equalTo: ""#password""
                }
            },
            messages: {
                name: {
                    required: ""Por favor informe seu nome"",
                    minlength: ""Por favor informe pelo menos 3 ca");
            WriteLiteral(@"racteres""
                },
                email: {
                    required: ""Por favor informe seu email"",
                    email: ""Email invalido"",
                },
                password: {
                    required: ""Informe uma senha"",
                    minlength: ""Senha muito fraca, informe 6 ou mais caracteres""
                },
                confirmPassword: {
                    required: ""Confirme a senha"",
                    minlength: ""Senha muito fraca, informe 6 ou mais caracteres"",
                    equalTo: ""Senha diferente, favor informe a mesma senha""
                }
            },
        });
    });

    function validCpf() {
        var strCPF = $(""#cpf"").val();
        var isErro = isValidCpf(strCPF);
        if (isErro) {
            $(""#cpfError"").css(""display"", ""none"");
        } else {
            $(""#cpfError"").css(""display"", ""block"");
        }
    }

    function isValidCpf(strCPF) {
        var cpf = strCPF;
        cpf = ");
            WriteLiteral(@"cpf.replace(/\D/g, '');
        if (cpf.toString().length != 11 || /^(\d)\1{10}$/.test(cpf)) return false;
        var result = true;
        [9, 10].forEach(function (j) {
            var soma = 0, r;
            cpf.split(/(?=)/).splice(0, j).forEach(function (e, i) {
                soma += parseInt(e) * ((j + 2) - (i + 1));
            });
            r = soma % 11;
            r = (r < 2) ? 0 : 11 - r;
            if (r != cpf.substring(j, j + 1)) result = false;
        });
        return result;
    }

    function ViewModel() {
        try {

            var self = this;

            self.name = ko.observable("""");
            self.email = ko.observable("""");
            self.cpf = ko.observable("""");
            self.password = ko.observable("""");
            self.confirmPassword = ko.observable("""");

            self.isValiForm = ko.computed(() => {
                return self.name() &&
                    self.email() &&
                    self.cpf &&
                    ");
            WriteLiteral(@"self.password &&
                    self.confirmPassword() &&
                    $('.form-control.error').length == 0 &&
                    isValidCpf(self.cpf());
            });

            self.createUser = () => {
                $.ajax({
                    type: ""POST"",
                    url: '/Users/RegisterUser',
                    data: {
                        name: self.name(),
                        email: self.email(),
                        cpf: self.cpf(),
                        password: self.password()
                    },
                    success: function (response) {
                        Swal.fire({
                            icon: 'success',
                            title: 'OK',
                            text: 'Cadastrado com sucesso!'
                        });

                        setTimeout(function () {
                            window.location.href = '/Home/login';
                        }, 1500);
                    },
    ");
            WriteLiteral(@"                error: function (xhr, ajaxOptions, thrownError) {
                        Swal.fire({
                            icon: 'error',
                            title: 'Oops..',
                            text: JSON.parse(xhr.responseText)
                        });
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

</script>");
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
