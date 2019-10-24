<%@ Page Title="" Language="C#" MasterPageFile="~/Configuracion.master" AutoEventWireup="true" CodeBehind="ConfigMedico.aspx.cs" Inherits="PROYECTO_TURNOS.ConfigMedico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h3 style="color: midnightblue" align="center"><i class="fa fa-cog" aria-hidden="true"></i>CONFIGURACIONES</h3>
    <link href="assets/css/estiloh.css" rel="stylesheet" />
    <style>
        #menu {
            padding: 0;
        }

            #menu li {
                display: inline;
                float: left;
            }

                #menu li a {
                    align-items: center;
                    align-content: center;
                    font-family: 'Times New Roman';
                    font-size: 16px;
                    text-decoration: none;
                    float: left;
                    padding: 15px 25px;
                    color: midnightblue;
                }

            #menu ul li a:hover {
                background-color: blue;
            }

        ul.menu li {
            float: left;
        }

        #color {
            color: midnightblue;
        }

        #fontcolor {
            color: midnightblue;
            font-size: 30px;
        }

        #colorback {
            background-color: midnightblue;
        }
    </style>
    <style style="overflow: hidden">
        #colorx {
            align-items: center;
            align-content: center;
            background: border-box;
            overflow-x: auto;
            overflow-y: auto;
        }

        .contenedor {
            width: 300px;
            height: 300px;
            background-color: #ccc;
            overflow: auto;
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

    <!--=========== INICIO DE SECCIÓN ENCABEZADO ================-->
    <!-- MENÚ -->
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
        <a class="navbar-brand"><i id="fontcolor" class="fa fa-heartbeat"></i></a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
            <div id="color" class="navbar-nav">
                
                <a id="color" class="nav-item nav-link active" href="ConfigMedico.aspx">Usuarios <span class="sr-only">(current)</span></a>
                <a  class="nav-item nav-link active" href="ConfigClinica.aspx">Clinicas </a>
                
            </div>
        </div>
    </nav>
    <!-- END MENU -->

    <h4 style="margin-left: 25px">
        <a id="color" data-toggle="modal" data-target="#exampleModal" href="#exampleModal"><i class="fa fa-user-md" aria-hidden="true"></i> AGREGAR MEDICO</a>
    </h4>

    <script>
        $(document).ready(function () {
            $('[data-toggle="tooltip"]').tooltip();
        });
    </script>

    <br />
    <div class="col-lg-10">
        <div class="input-group">
            <div class="input-group no-border col-xl-12">
                <input required  runat="server" data-toggle="tooltip" title="Ingrese el Nombre del Medico" id="txtbuscar" type="text" class="form-control" placeholder="Buscar...">
            </div>
            <span class="input-group-btn align-items-center">
                <asp:LinkButton Font-Size="X-Large" method="post"  ID="BtnBuscarMedico" runat="server" OnClick="BtnBuscarMedico_Click"><i class="fa fa-search" aria-hidden="true"></i> Buscar Medico</asp:LinkButton>
                <%--<button id="colorback" class="btn btn-default" type="button"><i class="fa fa-search" aria-hidden="true"></i>Buscar</button>--%>
            </span>
        </div>
    </div>



    <div class="modal fade bd-example-modal-lg" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="contenedor">
            <div style="background-color: rgba(255,255,255, 0.93); position: fixed; overflow-x: auto; overflow-y: scroll; bottom: 0; left: 0; right: 0; top: 0; z-index: 9999;">
                <div class="modal-dialog modal-lg" role="document">

                    <style>
                        label {
                            color: midnightblue;
                        }

                        #color {
                            color: midnightblue;
                        }
                    </style>


                    <div class="modal-content">
                        <div class="modal-body">
                            <h3 id="color" align="center">REGISTRO DE NUEVO MEDICO</h3>

                            <div id="colorx" method="post">
                                <div>
                                    <fieldset>
                                        <label for="clinica">Clinica:</label>
                                        <select runat="server" id="clinica" name="clinica">
                                           
                                        </select>

                                       <label for="codigo">DPI:</label>
                                       <input runat="server" type="text" id="codigo" name="codigo">

                                        <label for="nombre">Nombre:</label>
                                        <input runat="server" type="text" id="nombre" name="nombre">

                                        <label for="apellido">Apellido:</label>
                                        <input runat="server" type="text" id="apellido" name="nombre">

                                         <label for="dire">Dirección:</label>
                                        <input runat="server" type="text" id="dire" name="dire">

                                        <label for="fechanac">Fecha de Nacimiento:</label>
                                        <input runat="server" id="fechanac" type="date">

                                        <label for="telefono">Telefono:</label>
                                        <input runat="server" type="text" id="telefono" name="telefono">

                                        <label for="username">Usuario:</label>
                                        <input runat="server" type="text" id="username" name="username">

                                        <label for="clave">Contraseña:</label>
                                        <input runat="server" type="password" id="clave" name="clave">

                                         <label for="tipo">Tipo de usuario:</label>
                                        <select runat="server" id="tipo" name="tipo">
                                            <option value="Administrador">Administrador</option>
                                            <option value="Doctor">Doctor</option>
                                            <option value="Secretaria">Secretaria</option>
                                        </select>

                                    </fieldset>
                                </div>

                                <div class="modal-footer">
                                    <asp:LinkButton Font-Size="X-Large" method="post" ID="InsertarMedico"  runat="server" OnClick="InsertarMedico_Click"><i class="fa fa-save" aria-hidden="true"></i> Guardar Medico</asp:LinkButton>
                                    <asp:LinkButton Font-Size="X-Large" data-dismiss="modal" aria-label="Close" ID="Cancelar" runat="server"><i class="fa fa-times" aria-hidden="true"></i> Cancelar</asp:LinkButton>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <hr />

    <div style="margin-left: 5px; width: 900px; overflow: auto;" id="color" class="row">
        <div class="col-xl-auto">
            <div class="box box-primary">
                <div class="box-header">
                    <h3 align="center" class="box-title">Lista de Medicos</h3>
                </div>
                <div class="box-body table-responsive">
                    <div id="tamano" style="color: black;">
                        <asp:GridView
                            DataKeyNames ="ID_MEDICO"
                            ID="Grid"
                            AllowPaging="True"
                            CssClass="table"
                            class="table table-gray text-bold table-bordered table-hover"
                            runat="server"
                            AutoGenerateColumns="false"
               >
                            <Columns>
                                <asp:TemplateField HeaderText="#">
                                    <ItemTemplate>
                                        <asp:Label ID="LblCodigo" runat="server" Text='<% # Bind("ID_MEDICO") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox1" runat="server" Text='<% # Bind("ID_MEDICO") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="CLINICA">
                                    <ItemTemplate>
                                        <asp:Label ID="LblClinica" runat="server" Text='<% # Bind("CLINICA") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextClinica" runat="server" Text='<% # Bind("CLINICA") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="NOMBRE">
                                    <ItemTemplate>
                                        <asp:Label ID="LblNombres" runat="server" Text='<% # Bind("NOMBRE") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextNombres" runat="server" Text='<% # Bind("NOMBRE") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="DIRECCION">
                                    <ItemTemplate>
                                        <asp:Label ID="LblDireccion" runat="server" Text='<% # Bind("DIRECCION") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextTelefono" runat="server" Text='<% # Bind("DIRECCION") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="FECHA">
                                    <ItemTemplate>
                                        <asp:Label ID="LblFecha" runat="server" Text='<% # Bind("FECHA") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextFecha" runat="server" Text='<% # Bind("FECHA") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>


                                <asp:TemplateField HeaderText="TELEFONO">
                                    <ItemTemplate>
                                        <asp:Label ID="LblTelefono" runat="server" Text='<% # Bind("TELEFONO") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextTelefono" runat="server" Text='<% # Bind("TELEFONO") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="TIPO">
                                    <ItemTemplate>
                                        <asp:Label ID="Lbltipo" runat="server" Text='<% # Bind("TIPO_USUARIO") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextTipo" runat="server" Text='<% # Bind("TIPO_USUARIO") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="USUARIO">
                                    <ItemTemplate>
                                        <asp:Label ID="LblUsuario" runat="server" Text='<% # Bind("USERNAME") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextUsuario" runat="server" Text='<% # Bind("USERNAME") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="CLAVE">
                                    <ItemTemplate>
                                        <asp:Label ID="Lblclave" runat="server" Text='<% # Bind("CLAVE") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextClave" runat="server" Text='<% # Bind("CLAVE") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>

                                <asp:CommandField ShowDeleteButton="True" ShowEditButton="true" />
                            </Columns>
                            <HeaderStyle CssClass="thead-dark" />
                            <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="350px" />
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>

    
</asp:Content>
