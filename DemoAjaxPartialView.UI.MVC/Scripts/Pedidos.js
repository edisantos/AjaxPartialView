﻿function SalvarPedidos() {

     debugger
    //Pedidos
    var produto = $("#Produto").val();
    var valor = $("#ValorUnit").val();
    var date = $("#Data").val();

    var token = $('input[name=__RequestVerificationToken]').val();
    var tokenadr = $('form[action="/Pedidos/RegistrarPedidos"]input[name="__RequestVerificationToken"]').val();
    var headers = {};
    var headersadr = {};
    headers['__RequestVerificationToken'] = token;
    headersadr['__RequestVerificationToken'] = tokenadr;

    //Gravar dados
     debugger
    var url = "/Pedidos/RegistrarPedidos";
    $.ajax({
        url: url,
        type: "POST",
        datatype: "json",
        headers: headersadr,
        data: { Id: 0, Produto: produto, ValorUnit: valor, Data: date, __RequestVerificationToken: token },
        success: function (data) {
            if (data.Resultado > 0) {

                ListaDados(data.Resultado);
                produto = "";
                date = "";
                valor = "";
            }
        }
       

    });
}
debugger
function ListaDados(Id) {
    var url = "/Pedidos/ListaDados";
    $.aja({
        url: url
        , type: "GET"
        , data: { id: Id }
        , datatype: "html"
        , success: function (data) {
            var divItens = $("#DivMagazine");
            divItens.empty;
            divItens.show();
            divItens.html(data);
        }
    });
}