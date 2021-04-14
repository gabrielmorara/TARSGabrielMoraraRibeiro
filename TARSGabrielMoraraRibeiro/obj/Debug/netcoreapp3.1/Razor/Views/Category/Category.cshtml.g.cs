#pragma checksum "C:\Users\gabri\Desktop\PROJETOS\Tars\TARSGabrielMoraraRibeiro\TARSGabrielMoraraRibeiro\Views\Category\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9c6f4e9a6c4db1d2de7d985a89762286534ae8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Category), @"mvc.1.0.view", @"/Views/Category/Category.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c6f4e9a6c4db1d2de7d985a89762286534ae8b", @"/Views/Category/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d8855c4e635dd9293a6138c2425e00b6f79ead7", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Navigation -->\r\n");
#nullable restore
#line 2 "C:\Users\gabri\Desktop\PROJETOS\Tars\TARSGabrielMoraraRibeiro\TARSGabrielMoraraRibeiro\Views\Category\Category.cshtml"
Write(Html.Partial("_Navigation"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Cadastro Categoria -->
<div class=""row"">
    <div class=""col-4"">
        <label for=""title"">Nome: </label>
        <input type=""text"" id=""title"" name=""name"" class=""form-control"" data-bind=""value: name"" />
        <span data-bind='visible: name.hasError, text: name.validationMessage'> </span>
    </div>

    <div class=""col-md"" style=""margin-top: 25px"">
        <button type=""button"" class=""btn btn-info"" data-bind=""click: createdCategory""><i class=""fa fa-plus""></i> Adicionar</button>
    </div>
</div>

<br />

<!-- Tabela Categoria -->
<table id=""table-categorys"" cellspacing=""0"" class=""table table-striped table-bordered table-condensed"" style=""margin-block-end: 50px"">
    <thead>
        <tr>
            <th scope=""col"" hidden></th>
            <th scope=""col"">Nome</th>
            <th scope=""col"">Quantidade de Produtos</th>
            <th scope=""col"">Opções</th>
        </tr>
    </thead>
    <tbody data-bind=""foreach: features"">
        <tr>
            <td data-bind=""text");
            WriteLiteral(@": categoryID"" hidden></td>
            <td>
                <input type=""text"" name=""nameInput"" class=""form-control"" data-bind=""attr: { id: 'nameInput_' + categoryID() }, value: name"" disabled />
            </td>
            <td data-bind=""text: qtdProducts""></td>
            <td>
                <div class=""row justify-content-between"">
                    <button title=""Salvar"" data-toggle=""tooltip"" data-bind=""click: $root.saveEditCategory, attr: { id: 'save_' + categoryID() }"" style='visibility:hidden'><i class=""material-icons"">&#xE876;</i></button>

                    <button class=""edit"" title=""Editar"" data-toggle=""tooltip"" data-bind=""click: $root.editCategory, attr: { id: 'edit_' + categoryID() }"" style='visibility:visible'><i class=""material-icons"">&#xE254;</i></button>

                    <button class=""delete"" title=""Deletar"" data-toggle=""tooltip"" data-bind=""click: $root.deleteCategory""><i class=""material-icons"">&#xE872;</i></button>
                </div>
            </td>
        <");
            WriteLiteral(@"/tr>
    </tbody>
</table>

<script type=""text/javascript"">

    function FeatureRequest(data) {
        if (data != null) {
            this.categoryID = ko.observable(data.categoryID);
            this.name = ko.observable(data.name);
            this.qtdProducts = ko.observable(data.qtdProducts ? data.qtdProducts : 0);
        }
    }

    function ViewModel() {
        try {

            var self = this;

            self.features = ko.observableArray([]);
            self.name = ko.observable("""");
            self.nameInput = ko.observable("""");

            // Cadastrar Categoria
            self.createdCategory = () => {
                $.ajax({
                    type: ""POST"",
                    url: '/Category/CreatedCategory',
                    data: {
                        name: self.name()
                    },
                    success: function (response) {
                        console.log(response);
                        self.features.unshift(new Fe");
            WriteLiteral(@"atureRequest(response));
                        Swal.fire('Categoria cadastrada com sucesso', '', 'success');
                    },
                    error: function (xhr, ajaxOptions, thrownError) {
                        Swal.fire({
                            icon: 'error',
                            title: 'Oops..',
                            text: JSON.parse(xhr.responseText)
                        });
                    }
                });
            };

            // exibi input para editar
            self.editCategory = (value) => {
                console.log(value);
                $('#nameInput_' + value.categoryID()).removeAttr('disabled');
                $('#save_' + value.categoryID()).css('visibility', 'visible');
                $('#edit_' + value.categoryID()).css('visibility', 'hidden');
            };

            // salva edicao
            self.saveEditCategory = (value) => {
                console.log(value);
                $('#nameInput_' + value");
            WriteLiteral(@".categoryID()).attr('disabled', true);
                $('#edit_' + value.categoryID()).css('visibility', 'visible');
                $('#save_' + value.categoryID()).css('visibility', 'hidden');

                $.ajax({
                    type: ""PUT"",
                    url: '/Category/UpdateCategory',
                    data: {
                        categoryID: value.categoryID(),
                        name: value.name()
                    },
                    success: function (response) {
                        console.log(response);
                        Swal.fire('Categoria alterada com sucesso.', '', 'success');
                    },
                    error: function (xhr, ajaxOptions, thrownError) {
                        Swal.fire({
                            icon: 'error',
                            title: 'Oops..',
                            text: JSON.parse(xhr.responseText)
                        });
                    }
                });
          ");
            WriteLiteral(@"  };

            // Deletar Categoria
            self.deleteCategory = (value) => {
                console.log(value);
                console.log(value.qtdProducts());
                if (value.qtdProducts() >= 1) {
                    Swal.fire({
                        icon: 'error',
                        title: 'Oops..',
                        text: 'Não é possível remover a categoria, pois possui produtos vinculados, delete os produtos primeiro.'
                    });
                } else {
                    Swal.fire({
                        title: 'Tem certeza que quer excluir a categoria ' + value.name() + '?',
                        showCancelButton: true,
                        confirmButtonText: `Excluir`,
                        confirmButtonColor: '#d33',
                    }).then((result) => {
                        if (result.isConfirmed) {
                            $.ajax({
                                type: ""DELETE"",
                               ");
            WriteLiteral(@" url: '/Category/DeleteCategory',
                                data: {
                                    categoryID: value.categoryID()
                                },
                                success: function (response) {
                                    console.log(response);

                                    $(""#nameInput_"" + value.categoryID()).parent().parent().remove()

                                    Swal.fire('Categoria excluida com sucesso', '', 'success');
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
                    })");
            WriteLiteral(@"
                }
            };

            // Config DataTable
            const listCategorys = () => {

                self.features = ko.observableArray([]);

                $.ajax({
                    type: ""GET"",
                    url: '/Category/ListCategorys',
                    success: function (response) {
                        var mappedFeatures = $.map(response, function (item) {
                            return new FeatureRequest(item)
                        });

                        self.features(mappedFeatures);

                        $(""#table-categorys"").DataTable({
                            order: [[0, ""desc""]],
                            select: true,
                            searching: true,
                            pageLength: 25,
                            language: {
                                ""sProcessing"": ""Carregando..."",
                                ""sLengthMenu"": ""Mostrar _MENU_ registros"",
                            ");
            WriteLiteral(@"    ""sZeroRecords"": ""Não foram encontrados registros"",
                                ""sInfo"": ""Mostrando de _START_ até _END_ de _TOTAL_ registros"",
                                ""sInfoEmpty"": ""Mostrando de 0 até 0 de 0 registros"",
                                ""sInfoFiltered"": ""(filtrado de _MAX_ registros no total)"",
                                ""sInfoPostFix"": """",
                                ""sSearch"": ""Buscar:"",
                                ""sUrl"": """",
                                ""oPaginate"": {
                                    ""sFirst"": ""Primeiro"",
                                    ""sPrevious"": ""Anterior"",
                                    ""sNext"": ""Seguinte"",
                                    ""sLast"": ""Último""
                                }
                            },
                            ""bDestroy"": true,
                            dom: '<""html5buttons""B>lTfgitp',
                            buttons: [
                                { extend: ");
            WriteLiteral(@"'copy' },
                                { extend: 'csv' },
                                { extend: 'excel', title: 'Relatorio_Categorias' },
                                { extend: 'pdf', title: 'Relatorio_Categorias' },
                                {
                                    extend: 'print',
                                    customize: function (win) {
                                        $(win.document.body).addClass('white-bg');
                                        $(win.document.body).css('font-size', '10px');
                                        $(win.document.body).find('table')
                                            .addClass('compact')
                                            .css('font-size', 'inherit');
                                    }
                                }
                            ]
                        });
                    },
                    error: function (response) {
                        console.log('Erro'");
            WriteLiteral(@" + response);
                    }
                });
            }

            listCategorys();

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
