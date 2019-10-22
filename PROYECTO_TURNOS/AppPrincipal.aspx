<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion.Master" AutoEventWireup="true" CodeBehind="AppPrincipal.aspx.cs" Inherits="PG_CitasMedicas.AppPrincipal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href='https://fonts.googleapis.com/css?family=Nunito:400,300' rel='stylesheet' type='text/css'>
    <link href="assets/css/estiloh.css" rel="stylesheet" />


    <style>
        #color {
            align-items: center;
            align-content: center;
            color: midnightblue;
        }

        input[type=checkbox] {
        -ms-transform: scale(1.5); /* IE 9 */
        -webkit-transform: scale(1.5); /* Chrome, Safari, Opera */
        transform: scale(1.5);
    }
    </style>

    <h3 align="center" id="color">NUEVA CITA</h3>

    <div>
        <br />
        <div style="margin-right: 18px">
            <button type="button" data-toggle="modal" data-target="#exampleModal">
                <i class="fa fa-user-circle-o" aria-hidden="true"></i>NUEVO PACIENTE
            </button>
        </div>


        <div>
            

            <fieldset style="margin-right: 18px">
                <legend><span class="number">1</span>Paciente</legend>
                <label for="dpi">Ingrese Nombre o DPI:</label>
                <input runat="server" type="text" id="dpimodal" name="dpimodal">
                <div style="text-align: right">
                <asp:LinkButton  Font-Size="X-Large"  ID="LinkButton1" Width="500px" runat="server" OnClick="LinkButton1_Click"><i class="fa fa-search" aria-hidden="true"></i>  Buscar Paciente</asp:LinkButton>                 
                </div>
                <br />
                <legend><span class="number"><i class="fa fa-info-circle" aria-hidden="true"></i></span>Información del Paciente</legend>
                <br />
                <br />

                <label for="nombre">Nombre:</label>
                <input disabled runat="server" type="text" id="nombremodal" name="nombremodal">

                <label for="apellido">Apellido:</label>
                <input disabled runat="server" type="text" id="apellidomodal" name="apellidomodal">

                <label for="direccion">Dirección:</label>
                <input disabled runat="server" type="text" id="direccionmodal" name="direccionmodal">

                <label for="fechanac">Fecha Nacimiento:</label>
                <input disabled runat="server" type="text" id="fechamodal" name="fechamodal">
            </fieldset>

            <fieldset>
                <legend><span class="number">2</span>Cita</legend>
            </fieldset>

            <fieldset style="margin-right: 18px">
                <label for="doctor">Doctor:</label>
                <select runat="server" id="doctor" name="doctor">
                </select>

                <br />
                <br />

                <label for="motivo">Motivo de la cita:</label>
                <textarea runat="server" id="motivomodal" name="motivomodal"></textarea>

                <br />
                <br />

                <label for="fechacita">Fecha de la cita:</label>
                <input runat="server" id="datecita" type="date">
            </fieldset>

            <asp:LinkButton Font-Size="X-Large" ID="BtnGenerarCita"  runat="server" OnClick="BtnGenerarCita_Click"><i class="fa fa-save" aria-hidden="true"></i> Generar Cita</asp:LinkButton>
            <%--<button runat="server" onclick="BtnCita_Click" type="submit"><i class="fa fa-address-book-o" aria-hidden="true"></i>GUARDAR NUEVA CITA</button>--%>
        </div>
    </div>

    <!-- Modal -->
    <style>
        #colorx {
            align-items: center;
            align-content: center;
            background: border-box;
        }

        .contenedor {
            width: 300px;
            height: 300px;
            background-color: #ccc;
        }

          ::-webkit-scrollbar {
            width: 15px;
        }

        ::-webkit-scrollbar-track {
            background-color: darkgrey;
        }

        ::-webkit-scrollbar-thumb {
            background-color: midnightblue;
        }
    </style>
    <div class="modal fade bd-example-modal-lg" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="contenedor">
            <div style="background-color: rgba(255,255,255, 0.93);  position: fixed; overflow-x: auto; overflow-y: scroll; bottom: 0; left: 0; right: 0; top: 0; z-index: 9999;">
                <div class="modal-dialog modal-lg" role="document">

                    <div class="modal-content">
                        <div class="modal-body">
                            <h3 id="color">REGISTRO DE NUEVO PACIENTE</h3>

                            <div id="colorx">
                                <div>
                                    <fieldset>
                                        <label for="dpi">DPI:</label>
                                        <input runat="server" type="text" id="dpi" name="dpi">

                                        <label for="nombre">Nombre:</label>
                                        <input runat="server" type="text" id="nombre" name="nombre">

                                        <label for="apellido">Apellido:</label>
                                        <input runat="server" type="text" id="apellidox" name="nombrex">

                                        <label>Genero:</label>
                                        <select runat="server" id="genero" name="generomodel">
                                            <option value="Masculino">Masculino</option>
                                            <option value="Femenino">Femenino</option>
                                        </select>

                                        <label for="dirección">Direccion:</label>
                                        <input runat="server" type="text" id="direccionx" name="direccionx">
                                    
                                         <label for="municipio">Municipio:</label>
                                        <input runat="server" type="text" id="municipiox" name="municipiox">

                                        <label for="depto">Departamento:</label>
                                        <input runat="server" type="text" id="deptox" name="deptox">

                                         <label for="fechanac">Fecha Nacimiento:</label>
                                         <input runat="server" id="fechanac" type="date">
                                    </fieldset>
                                </div>

                                <div style="font-size: 22px" class="modal-footer">
                                    <asp:LinkButton ID="InsertarPaciente"  runat="server" OnClick="InsertarPaciente_Click"><i class="fa fa-save" aria-hidden="true"></i> Guardar Paciente</asp:LinkButton>
                                    <asp:LinkButton data-dismiss="modal" aria-label="Close" ID="Cancelar" runat="server"><i class="fa fa-times" aria-hidden="true"></i> Cancelar</asp:LinkButton>
                                    <%--<button type="button" OnClick="" runat="server"  class="btn btn-primary"><i class="fa fa-user-circle-o" aria-hidden="true"></i>GUARDAR PACIENTE</button>
                                    <button type="button" class="btn btn-danger" data-dismiss="modal" aria-label="Close"><i class="fa fa-times" aria-hidden="true"></i>CANCELAR</button>--%>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
