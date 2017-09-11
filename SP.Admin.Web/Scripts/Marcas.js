var Marcas = {
    colMarcas: [],
    gridMarcas: {},
    inicial: function () {
        $.ajaxSetup({ cache: false });
        this.CargaGrid();
        this.eventos();
    },
    eventos: function () {
        
        
        $(document).on('click', '#btn-GuardarMarca', Marcas.ActualizaInfo);
        $(document).on('click', '.accrowEdit', function () {
            Marcas.Editar($(this).parent().parent().attr("data-modelId"));
        });
    },
    ActualizaInfo: function () {
        alert('Actualiza info.');
    },
    Editar: function (id) {
        var url = contextPath + "Marca/Editar?id=" + id;

        $.get(url, function (data) {

            $('#marcaEditar').html(data);

            $('#marcaEditar').modal({
                backdrop: 'static',
                keyboard: true
            }, 'show');

            SP.RedefinirValidaciones();
        });
    },
    CargaGrid: function () {
        var url = contextPath + "Marca/CargarMarcas",
            dataPost = null; // El url del controlador        
        $.post(url, dataPost, function (data) {
            $('.loading').show();
            if (data.Success !== true) { SP.DespliegaError(data.Messages); return; }
            Marcas.colMarcas = new Backbone.Collection(data.data);
            var bolFilter = Marcas.colMarcas.length > 0 ? true : false;
            if (bolFilter) {
                $('.bbGrid-Marcas')[0].innerHTML = "";
                Marcas.gridMarcas = new bbGrid.View({
                    container: $('.bbGrid-Marcas'),
                    rows: 20,
                    rowList: [15, 25, 50, 100],
                    enableSearch: false,
                    actionenable: true,
                    detalle: false,
                    collection: Marcas.colMarcas,
                    colModel: [{ title: 'id', name: 'id', filterType: 'input', width: '35px' },
                               { title: 'Nombre', name: 'nombre', filter: true, filterType: 'input' }
                    ]
                });

                $('.loading').hide();
            }
            else {
                SP.DespliegaInformacion("No se encontraron Marcas registradas");
                $('#bbGrid-Marcas')[0].innerHTML = "";
            }
            //getJSON fail
        }).fail(function () {
            SP.DespliegaError("No se pudo cargar la lista de frase");
        });
        

    }
}

$(function () {
    Marcas.inicial();
});