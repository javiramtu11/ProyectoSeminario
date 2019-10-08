<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion.Master" AutoEventWireup="true" CodeBehind="AppPaciente.aspx.cs" Inherits="PG_CitasMedicas.AppPaciente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href='https://fonts.googleapis.com/css?family=Nunito:400,300' rel='stylesheet' type='text/css'>
    <link href="assets/css/estiloh.css" rel="stylesheet" />
    <%--<link href="estilos/css/AdminLTE.css" rel="stylesheet" />--%>

    <h3 align="center" id="color">PACIENTES</h3>
    <style>
        #color {
            color: midnightblue;
        }

        #colorback {
            background-color: midnightblue;
            color: white;
        }

        #border {
            border: none;
        }

        #pading {
            padding: 3px;
            line-height: 20px;
        }
    </style>


    <br />

    <h4 style="margin-left: 30px">
        <a id="color" data-toggle="modal" data-target="#exampleModal" href="#exampleModal"><i class="fa fa-user-circle-o" aria-hidden="true"></i>AGREGAR PACIENTE</a>
    </h4>

    <script>
        $(document).ready(function () {
            $('[data-toggle="tooltip"]').tooltip();
        });
    </script>

    <br />
    <div class="col-lg-12">
        <div class="input-group">
            <div>
                <h3>
                    <span>
                        <asp:TextBox Font-Size="X-Large" placeholder="Buscar..." ID="TxtBuscar" runat="server"></asp:TextBox>
                        <asp:LinkButton ToolTip="Ingrese DPI o Nombre del paciente" ID="Lbtn_Buscar" runat="server" Width="500px" OnClick="Lbtn_Buscar_Click" ><i class="fa fa-search" aria-hidden="true"></i>  Buscar Paciente</asp:LinkButton>
                    </span>
                </h3>
            </div>
        </div>
    </div>
    <br />
    <br />




    <div style="margin-left: 10px; width:900px; overflow:auto;" id="color" class="row">
        <div class="col-xl-auto">
            <div class="box box-primary">
                <div class="box-header">
                    <h3 align="center" class="box-title">Lista de Pacientes</h3>
                </div>
                <div class="box-body table-responsive">
                    <div id="tamano" style="color: black;">
                        <asp:GridView 
                            ID="Grid"                            
                            AllowPaging="True"
                            CssClass="table"
                            class="table table-gray text-bold table-bordered table-hover"
                            method="post" 
                            runat="server"                            
                            AutoGenerateColumns="false">
                            <Columns>
                                <asp:TemplateField HeaderText="#">
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<% # Bind("ID_PACIENTE") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox1" runat="server" Text='<% # Bind("ID_PACIENTE") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="DPI">
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<% # Bind("DPI") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="Textdpi" runat="server" Text='<% # Bind("DPI") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="NOMBRE">
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<% # Bind("NOMBRE") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="Textnombre" runat="server" Text='<% # Bind("NOMBRE") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="GENERO">
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<% # Bind("GENERO") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextGenero" runat="server" Text='<% # Bind("GENERO") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>

                                 <asp:TemplateField HeaderText="DIRECCION">
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<% # Bind("DIRECCION") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextDireccion" runat="server" Text='<% # Bind("DIRECCION") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>
                                 <asp:TemplateField HeaderText="NACIMIENTO">
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<% # Bind("FECHA_NAC") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="Textfechanac" runat="server" Text='<% # Bind("FECHA_NAC") %>'></asp:TextBox>
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

    <div class="modal fade bd-example-modal-lg" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="contenedor">
            <div style="background-color: rgba(255,255,255, 0.93); position: fixed; overflow-x: auto; overflow-y: scroll; bottom: 0; left: 0; right: 0; top: 0; z-index: 9999;">
                <div class="modal-dialog modal-lg" role="document">

                    <div class="modal-content">
                        <div class="modal-body">
                            <h3 id="color" align="center">REGISTRO DE NUEVO PACIENTE</h3>

                            <div id="colorx">
                                <div>
                                    <fieldset>
                                        <label for="dpi">DPI:</label>
                                        <input runat="server" type="text" id="dpi" name="dpi">

                                        <label for="nombre">Nombre:</label>
                                        <input runat="server" type="text" id="nombre" name="nombre">

                                        <label for="apellido">Apellido:</label>
                                        <input runat="server" type="text" id="apellidox" name="apellidox">

                                        <label>Genero:</label>
                                        <select runat="server" id="genero" name="generomodel">
                                            <option value="Masculino">Masculino</option>
                                            <option value="Femenino">Femenino</option>
                                        </select>

                                        <label for="dirección">Direccion:</label>
                                        <input runat="server" type="text" id="direccionx" name="direccionx">

                                         <label for="fechanac">Fecha de Nacimiento:</label>
                                        <input runat="server" id="fechanac" type="date">

                                    </fieldset>
                                </div>

                                <div class="modal-footer">
                                    <asp:LinkButton method="post" ID="InsertarPaciente"  runat="server" OnClick="InsertarPaciente_Click" ><i class="fa fa-save" aria-hidden="true"></i> Guardar Paciente</asp:LinkButton>
                                    <asp:LinkButton data-dismiss="modal" aria-label="Close" ID="Cancelar" runat="server"><i class="fa fa-times" aria-hidden="true"></i> Cancelar</asp:LinkButton>
                                
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
