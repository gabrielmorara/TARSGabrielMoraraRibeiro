#pragma checksum "C:\Users\gabri\Desktop\PROJETOS\Tars\TARSGabrielMoraraRibeiro\TARSGabrielMoraraRibeiro\Views\Home\Perfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddb4955e670ec39a55871aea1bc2a71bd89ab6dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Perfil), @"mvc.1.0.view", @"/Views/Home/Perfil.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddb4955e670ec39a55871aea1bc2a71bd89ab6dd", @"/Views/Home/Perfil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d8855c4e635dd9293a6138c2425e00b6f79ead7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Perfil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("registration"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("registration"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        background: #f2fff6;
    }

    .container {
        display: flex;
        align-items: center;
        flex-direction: column;
        justify-content: center;
        padding: 20px;
        margin-block-end: 10px;
    }

    .center {
        display: flex;
        justify-content: center;
        align-items: center;
    }
</style>

<!-- Navigation -->
");
#nullable restore
#line 45 "C:\Users\gabri\Desktop\PROJETOS\Tars\TARSGabrielMoraraRibeiro\TARSGabrielMoraraRibeiro\Views\Home\Perfil.cshtml"
Write(Html.Partial("_Navigation"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""panel panel-default"" style=""border-radius: 15px;"">
                <div class=""common_box_body panel-body"">
                    <div class=""center"">
                        <h1 style=""font-weight: bold"">Perfil do Usuário</h1>
                    </div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddb4955e670ec39a55871aea1bc2a71bd89ab6dd5844", async() => {
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
                            <input type=""text"" id=""cpf"" name=""cpf"" class=""form-control"" data-bind='value: cpf' disabled>
                            <span id=""cpfError"" class=""error"" style=""display: none;"">O CPF informado é invalido</span>
                        </div>

                        <div class=""form-group"">
                            <label for=""email"">Email</label>");
                WriteLiteral(@"
                            <input type=""text"" id=""email"" name=""email"" class=""form-control"" data-bind=""value:email"" />
                        </div>

                        <div class=""form-group"">
                            <label for=""oldPassword"">Senha atual</label>
                            <input type=""password"" id=""oldPassword"" name=""oldPassword"" class=""form-control"" data-bind=""value:oldPassword"" />
                        </div>

                        <div class=""form-group"">
                            <label for=""newPassword"">Nova Senha</label>
                            <input type=""password"" id=""newPassword"" name=""newPassword"" class=""form-control"" data-bind=""value:newPassword"" />
                        </div>

                        <div class=""form-group"">
                            <label for=""newConfirmPassword"">Confirmar Nova Senha</label>
                            <input type=""password"" id=""newConfirmPassword"" name=""newConfirmPassword"" class=""form-control"" data-bi");
                WriteLiteral(@"nd=""value:newConfirmPassword"" />
                        </div>

                        <div class=""center"">
                            <button style=""width: 50%"" type=""button"" class=""btn btn-success"" data-bind=""click:updateUser, enable:isValiForm()"">
                                <span aria-hidden=""true""><b>Salvar</b></span>
                            </button>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
</div>

<script type=""text/javascript"">

    // específica regras de validação do formulario
    $(document).ready(function () {
        $(""#registration"").validate({
            rules: {
                name: { required: true, minlength: 3 },
                email: {
                    required: true,
                    email: true
                },
                oldPassword: {
                    required: true,
                    minlength: 5,
                },
                newPassword: {
                    required: true,
                    minlength: 5,
                },
                newConfirmPassword: {
                    required: true,
                    minlength: 5,
                    equalTo: ""#newPassword""
                }
            },
            messages: {
                name: {
                    required: ""Por favor informe seu nome"",
                    minlength: ");
            WriteLiteral(@"""Por favor informe pelo menos 3 caracteres""
                },
                email: {
                    required: ""Por favor informe seu email"",
                    email: ""Email invalido"",
                },
                oldPassword: {
                    required: ""Informe sua senha atual"",
                    minlength: ""Senha muito fraca, informe 6 ou mais caracteres""
                },
                newPassword: {
                    required: ""Informe sua nova senha"",
                    minlength: ""Senha muito fraca, informe 6 ou mais caracteres""
                },
                newConfirmPassword: {
                    required: ""Confirme a senha"",
                    minlength: ""Senha muito fraca, informe 6 ou mais caracteres"",
                    equalTo: ""Senha diferente, favor informe a mesma senha""
                }
            },
        });
    });

    // busca informações do usuário
    $(document).ready(function () {
        $.getJSON('/Users/GetUser', fun");
            WriteLiteral(@"ction (data) {
            var vm = new ViewModel(data);

            // ativa knockout.js
            ko.applyBindings(vm);
        });
    });


    function ViewModel(data) {
        try {

            var self = this;

            self.name = ko.observable(data.name);
            self.cpf = ko.observable(mCPF(data.cpf));
            self.email = ko.observable(data.email);

            self.oldPassword = ko.observable("""");
            self.newPassword = ko.observable("""");
            self.newConfirmPassword = ko.observable("""");

            self.isValiForm = ko.computed(() => {
                return self.name() &&
                    self.email() &&
                    self.cpf &&
                    self.oldPassword &&
                    self.newPassword() &&
                    self.newConfirmPassword() &&
                    $('.form-control.error').length == 0;
            });

            self.updateUser = () => {
                $.ajax({
                    type: """);
            WriteLiteral(@"PUT"",
                    url: '/Users/UpdateUser',
                    data: {
                        name: self.name(),
                        email: self.email(),
                        oldPassword: self.oldPassword(),
                        newPassword: self.newPassword()
                    },
                    success: function (response) {
                        Swal.fire({
                            icon: 'success',
                            title: 'OK',
                            text: 'Alterado com sucesso!'
                        });
                        window.location.href = '/Home/Login';
                    },
                    error: function (xhr, ajaxOptions, thrownError) {
                        Swal.fire({
                            icon: 'error',
                            title: 'Oops..',
                            text: JSON.parse(xhr.responseText)
                        });
                    }
                });
            }
        } ");
            WriteLiteral("catch (e) {\r\n            console.log(e);\r\n        }\r\n    }\r\n\r\n</script>");
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