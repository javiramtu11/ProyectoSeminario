
function templateRow() {
    var template = "<tr>";
    template += ("<td>" + "123" + "</td>");
    template += ("<td>" + "222" + "</td>");
    template += ("<td>" + "333" + "</td>");
    template += ("<td>" + "444" + "</td>");
    return template;
}

function addRow() {
    var template = templateRow();
    for (var i = 0; i < 5; i++) {
        $("#tbl_body_table").append(template);
    }
}


addRow();

function addRowDT(data) {
    var tabla = $("#TblPaciente").DataTable();
    for (var i = 0; i < data.length; i++) {
        tabla.fnAddData([
            data[i].idPaciente,
            data[i].nombres,
            data[i].apellido,
            data[i].edad,
            data[i].sexo,
            data[i].nroDocumento,
            data[i].direccion,
            data[i].telefono,
            data[i].estado
        ]);
    }
}

function sendDataAjax() {
    $.ajax({
        type: "POST",
        url: "zPacientes.aspx/ListarPacientes",
        data: { },
        contentType: 'application/json; charset=utf-8',
        error: function (xhr, ajaxOptions, thrownError) {
            console.log(xhr.status + " \n" + xhr.responseText, "\n" + thrownError);
        },
        success: function (data) {
            addRowDT(data.d)
        }
    })
}

sendDataAjax();