#pragma checksum "C:\Users\gabri\Desktop\PROJETOS\Tars\TARSGabrielMoraraRibeiro\TARSGabrielMoraraRibeiro\Views\Products\NewProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4fb88c5a6a1626c51a85459b04d04177ad18e06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_NewProduct), @"mvc.1.0.view", @"/Views/Products/NewProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4fb88c5a6a1626c51a85459b04d04177ad18e06", @"/Views/Products/NewProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d8855c4e635dd9293a6138c2425e00b6f79ead7", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_NewProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/colorlib-wizard-28/vendor/mdi-font/css/material-design-iconic-font.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("all"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/colorlib-wizard-28/vendor/font-awesome-4.7/css/font-awesome.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/colorlib-wizard-28/css/main.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/select2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/colorlib-wizard-28/vendor/bootstrap-wizard/jquery.bootstrap.wizard.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/colorlib-wizard-28/js/global.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/select2.full.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/colorlib-wizard-28/vendor/jquery-validate/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("wizard-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("js-wizard-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d4fb88c5a6a1626c51a85459b04d04177ad18e068650", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d4fb88c5a6a1626c51a85459b04d04177ad18e069848", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d4fb88c5a6a1626c51a85459b04d04177ad18e0611046", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d4fb88c5a6a1626c51a85459b04d04177ad18e0612245", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4fb88c5a6a1626c51a85459b04d04177ad18e0613444", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4fb88c5a6a1626c51a85459b04d04177ad18e0614484", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4fb88c5a6a1626c51a85459b04d04177ad18e0615524", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4fb88c5a6a1626c51a85459b04d04177ad18e0616564", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<style>
    .error {
        color: red;
    }

    label {
        font-weight: bold
    }

    #containerForm {
        margin-right: 0px
    }

    .center {
        display: flex;
        justify-content: center;
        align-items: center;
    }

    .progress-val {
        background-color: #36c240;
    }
</style>

<!-- Navigation -->
");
#nullable restore
#line 35 "C:\Users\gabri\Desktop\PROJETOS\Tars\TARSGabrielMoraraRibeiro\TARSGabrielMoraraRibeiro\Views\Products\NewProduct.cshtml"
Write(Html.Partial("_Navigation"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""page-wrapper"" style=""border-color: #28BAA2;
        padding-bottom: 100px;"">
    <div class=""wrapper wrapper"">
        <div class=""card card-1"">
            <div class=""card-body"">
                <h1 class=""center"">Cadastro de produto</h1>
                <br />
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4fb88c5a6a1626c51a85459b04d04177ad18e0618559", async() => {
                WriteLiteral(@"
                    <div class=""progress"" id=""js-progress"">
                        <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""0"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 50%;"">
                            <span class=""progress-val"">40%</span>
                        </div>
                    </div>

                    <ul class=""nav nav-tab"">
                        <li class=""active"">
                            <a href=""#tab1"" data-toggle=""tab"">1</a>
                        </li>
                        <li>
                            <a href=""#tab2"" data-toggle=""tab"">1</a>
                        </li>
                        <li>
                            <a href=""#tab3"" data-toggle=""tab"">1</a>
                        </li>
                    </ul>

                    <div class=""tab-content"">
                        <div class=""tab-pane active"" id=""tab1"">

                            <h3 class=""font-bold p-h-xs m-b-md m-t-lg"" style=""border-bottom");
                WriteLiteral(@":1px #d0d0d0 solid;"">Informações gerais</h3>
                            <br />

                            <div class=""form-group"">
                                <label for=""title"">Titulo</label>
                                <input type=""text"" id=""title"" name=""title"" class=""form-control"" data-bind=""value: title"" />
                                <span data-bind='visible: title.hasError, text: title.validationMessage'> </span>
                            </div>

                            <br />

                            <div class=""form-group"">
                                <label for=""brand"">Marca</label>
                                <input type=""text"" id=""brand"" name=""brand"" class=""form-control"" data-bind=""value: brand"" />
                                <span data-bind='visible: brand.hasError, text: brand.validationMessage'> </span>
                            </div>

                            <br />

                            <div class=""form-group"">
             ");
                WriteLiteral(@"                   <label for=""category"">Categoria </label>
                                <select id=""category"" name=""category""
                                        data-bind=""options: category,
                                        optionsText: 'name',
                                        optionsValue: 'id',
                                        optionsCaption: 'Selecione uma categoria...',
                                        value: selectedCategory"" style=""width: 50%""></select>
                            </div>

                            <br />

                            <div class=""row align-content-between"">
                                <div class=""col-md-2 p-xss"">
                                    <label for=""priceDefault"">Preço DE</label>
                                    <input type=""text"" id=""priceDefault"" name=""priceDefault"" class=""form-control dinheiro"" data-bind=""value:priceDefault"" />
                                </div>

                             ");
                WriteLiteral(@"   <div class=""col-md-2 p-xss"">
                                    <label for=""priceOffer"">Preço POR</label>
                                    <input type=""text"" id=""priceOffer"" name=""priceOffer"" class=""form-control dinheiro"" data-bind=""value:priceOffer"" />
                                </div>

                                <div class=""col-md-2 p-xss"">
                                    <label for=""stock"">Estoque</label>
                                    <input type=""number"" id=""stock"" name=""stock"" class=""form-control"" data-bind=""value:stock"" />
                                </div>
                            </div>

                            <br />

                            <div class=""form-group"">
                                <label for=""description"">Descricao</label>
                                <textarea type=""text"" id=""description"" name=""description"" class=""form-control"" data-bind=""value:description""></textarea>
                            </div>

                ");
                WriteLiteral(@"            <div class=""btn-next-con"">
                                <a class=""btn-next"" href=""#"">Próximo</a>
                            </div>

                        </div>
                        <div class=""tab-pane"" id=""tab2"">
                            <h3 class=""font-bold p-h-xs m-b-md m-t-lg"" style=""border-bottom:1px #d0d0d0 solid;"">Informações fiscais</h3>
                            <br />

                            <div class=""form-group"">
                                <label for=""ean"">EAN</label>
                                <input type=""number"" id=""ean"" name=""ean"" class=""form-control"" data-bind=""value:ean"" />
                            </div>

                            <div class=""form-group"">
                                <label for=""ncm"">NCM</label>
                                <input type=""number"" id=""ncm"" name=""ncm"" class=""form-control"" data-bind=""value:ncm"" />
                            </div>

                            <div class=""form-group"">
    ");
                WriteLiteral(@"                            <label for=""warranty"">Garantia</label>
                                <input type=""number"" id=""warranty"" name=""warranty"" class=""form-control"" data-bind=""value:warranty"" />
                            </div>

                            <div class=""btn-next-con"">
                                <a class=""btn-back"" href=""#"">Voltar</a>
                                <a class=""btn-next"" href=""#"">Próximo</a>
                            </div>

                        </div>
                        <div class=""tab-pane"" id=""tab3"">
                            <h3 class=""font-bold p-h-xs m-b-md m-t-lg"" style=""border-bottom:1px #d0d0d0 solid;"">Medidas</h3>
                            <br />

                            <div class=""form-group"">
                                <label for=""height"">Altura</label>
                                <input type=""number"" id=""height"" name=""height"" class=""form-control"" data-bind=""value:height"" />
                            </div>
");
                WriteLiteral(@"
                            <div class=""form-group"">
                                <label for=""lenght"">Comprimento</label>
                                <input type=""number"" id=""lenght"" name=""lenght"" class=""form-control"" data-bind=""value:lenght"" />
                            </div>

                            <div class=""form-group"">
                                <label for=""width"">Largura</label>
                                <input type=""number"" id=""width"" name=""width"" class=""form-control"" data-bind=""value:width"" />
                            </div>

                            <div class=""form-group"">
                                <label for=""weight"">Peso</label>
                                <input type=""number"" id=""weight"" name=""weight"" class=""form-control"" data-bind=""value:weight"" />
                            </div>

                            <div class=""btn-next-con"">
                                <a class=""btn-back"" href=""#"">Voltar</a>
                           ");
                WriteLiteral("     <a class=\"btn-last\" href=\"#\" data-bind=\"click:createProduct\">Cadastrar</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
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

<script type=""text/javascript"">

    $('.dinheiro').maskMoney({
        prefix: ""R$ "",
        decimal: "","",
        thousands: "".""
    });

    $('#category').select2({
        theme: ""classic"",
        placeholder: 'Selecione uma categoria...',
        allowClear: false
    });

    //Controla Progress Bar
    $(""#js-wizard-form"").bootstrapWizard({
        'tabClass': 'nav-tab',
        'nextSelector': '.btn-next',
        'previousSelector': '.btn-back',
        'lastSelector': '.btn-last',
        'onNext': function (tab, navigation, index) {
            var progressBar = $('#js-progress').find('.progress-bar');
            var progressVal = $('#js-progress').find('.progress-val');
            var current = index + 1;
            if (current > 1) {
                var val = parseInt(progressBar.text());
                val += 30;
                progressBar.css('width', val + '%');
                progressVal.text(val ");
            WriteLiteral(@"+ '%');
            }

        },
        'onPrevious': function (tab, navigation, index) {
            var progressBar = $('#js-progress').find('.progress-bar');
            var progressVal = $('#js-progress').find('.progress-val');
            var current = index - 1;
            if (current !== 1) {
                var val = parseInt(progressBar.text());
                val -= 30;
                progressBar.css('width', val + '%');
                progressVal.text(val + '%');
            }
        }
    });

    $(document).ready(function () {
        $(""#js-wizard-form"").validate({
            // Specify validation rules
            rules: {
                title: { required: true, minlength: 3 },
                brand: {
                    required: true
                },
                category: {
                    required: true
                },
                stock: {
                    required: true,
                },
                priceDefault: {
       ");
            WriteLiteral(@"             required: true,
                },
                priceOffer: {
                    required: true,
                },
                description: {
                    required: true,
                },
                ean: {
                    required: true,
                },
                ncm: {
                    required: true,
                },
                warranty: {
                    required: true,
                }
            },
            messages: {
                title: {
                    required: ""Por favor informe o titulo"",
                    minlength: ""Por favor informe pelo menos 3 caracteres""
                },
                brand: {
                    required: ""Por favor informe a marca"",
                },
                category: {
                    required: ""Por favor informe a categoria"",
                },
                stock: {
                    required: ""Por favor informe a quatidade disponivel"",
      ");
            WriteLiteral(@"          },
                priceDefault: {
                    required: ""Por favor informe o preço De"",
                },
                priceOffer: {
                    required: ""Por favor informe o preço Por"",
                },
                description: {
                    required: ""Por favor informe a descrição"",
                },
                ean: {
                    required: ""Por favor informe o EAN"",
                },
                ncm: {
                    required: ""Por favor informe o NCM"",
                },
                warranty: {
                    required: ""Por favor informe a tempo de garantia em messes"",
                }
            },
        });
    });

    function CategoryType(item) {
        this.id = ko.observable(item.categoryID);
        this.name = ko.observable(item.name);
    };


    function ViewModel() {
        try {

            var self = this;

            self.title = ko.observable("""");
            self.brand");
            WriteLiteral(@" = ko.observable("""");

            self.category = ko.observableArray([]);
            self.selectedCategory = ko.observable("""");

            self.stock = ko.observable([]);

            self.priceDefault = ko.observable("""");
            self.priceOffer = ko.observable("""");
            self.description = ko.observable("""");

            self.ean = ko.observable("""");
            self.ncm = ko.observable("""");
            self.warranty = ko.observable("""");

            self.height = ko.observable("""");
            self.lenght = ko.observable("""");
            self.width = ko.observable("""");
            self.weight = ko.observable("""");

            $.ajax({
                type: ""GET"",
                url: '/Category/ListCategorys',
                success: function (response) {
                    console.log(response);
                    $.map(response, function (item) {
                        self.category.push(new CategoryType(item));
                        console.log(self.categor");
            WriteLiteral(@"y());
                    });
                },
                error: function (response) {
                    console.log('Erro' + response);
                }
            });

            self.createProduct = () => {
                const _priceDefault = self.priceDefault().replace(/[^0-9,]/g, '').replace(',', '.');
                const _priceOffer = self.priceOffer().replace(/[^0-9,]/g, '').replace(',', '.');

                var data = {
                    Title: self.title(),
                    Brand: self.brand(),
                    CategoryID: self.selectedCategory(),
                    Stock: self.stock(),
                    PriceDefault: _priceDefault,
                    PriceOffer: _priceOffer,
                    Description: self.description(),
                    EAN: self.ean(),
                    NCM: self.ncm(),
                    Warranty: self.warranty(),
                    Height: self.height(),
                    Lenght: self.lenght(),
               ");
            WriteLiteral(@"     Width: self.width(),
                    Weight: self.weight(),
                };

                console.log(data);

                $.ajax({
                    type: ""POST"",
                    url: '/Products/CreatedProduct',
                    data: {
                        data: JSON.stringify(data)
                    },
                    success: function (response) {
                        console.log(response);
                        alert(""Produto cadastrado com sucesso!"");

                    },
                    error: function (response) {
                        console.log('Erro' + response);
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
