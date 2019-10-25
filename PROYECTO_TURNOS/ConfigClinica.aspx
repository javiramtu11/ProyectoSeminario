<%@ Page Title="" Language="C#" MasterPageFile="~/Configuracion.master" AutoEventWireup="true" CodeBehind="ConfigClinica.aspx.cs" Inherits="PROYECTO_TURNOS.ConfigClinica" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 style="color: midnightblue" align="center"><i class="fa fa-cog" aria-hidden="true"></i>CONFIGURACIONES</h3>
    <link href="assets/css/estiloh.css" rel="stylesheet" />
    <script src="js/Confirmacion.js"></script>

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

                <a class="nav-item nav-link active" href="ConfigMedico.aspx">Usuarios </a>
                <a id="color" class="nav-item nav-link active" href="ConfigClinica.aspx">Clinicas <span class="sr-only">(current)</span></a>

            </div>
        </div>
    </nav>
    <!-- END MENU -->

    <h4 style="margin-left: 25px">
        <a id="color" data-toggle="modal" data-target="#exampleModal" href="#exampleModal"><i class="fa fa-hospital-o" aria-hidden="true"></i>AGREGAR Clinica</a>
    </h4>

    <script>
        $(document).ready(function () {
            $('[data-toggle="tooltip"]').tooltip();
        });
    </script>

    <script type="text/javascript" language="javascript">
        function ValidarCampos() {
            <div class="alert alert-warning alert-dismissible fade show" role="alert">
                <strong>Error de campos vacios!</strong> Por Favor verifique los campos antes de continuar...
                    <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
            </div>
        }
    </script>

    <br />
    <div class="col-lg-10">
        <div class="input-group">
            <div class="input-group no-border col-xl-12">
                <input required runat="server" data-toggle="tooltip" title=" Nombre de la clinica" id="txtbuscar" type="text" class="form-control" placeholder="Buscar...">
            </div>
            <span class="input-group-btn align-items-center">
                <asp:LinkButton Font-Size="X-Large" method="post" ID="BtnBuscarClinica" runat="server" OnClick="BtnBuscarClinica_Click"><i class="fa fa-search" aria-hidden="true"></i> Buscar Clinica</asp:LinkButton>
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

                            <form id="ClinicaNew" method="post" class="form-horizontal">

                                <h3 id="color" align="center">REGISTRO DE NUEVA CLINICA</h3>

                                <div id="colorx" method="post">
                                    <div>
                                        <fieldset>
                                            <label for="clinica">Clinica:</label>
                                            <input required runat="server" type="text" id="clinica" name="clinica">
                                            <label for="descripcion">Descripción:</label>
                                            <input required runat="server" type="text" id="Descripcion" name="descripcion">
                                        </fieldset>
                                    </div>

                                    <div class="modal-footer">
                                        <asp:LinkButton Font-Size="X-Large" method="post" ID="InsertarClinica" runat="server" OnClick="InsertarClinica_Click"><i class="fa fa-save" aria-hidden="true"  ></i> Guardar Clinica</asp:LinkButton>
                                        <asp:LinkButton Font-Size="X-Large" data-dismiss="modal" aria-label="Close" ID="Cancelar" runat="server"><i class="fa fa-times" aria-hidden="true"></i> Cancelar</asp:LinkButton>
                                    </div>
                                </div>
                            </form>
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
                    <h3 align="center" class="box-title">Lista de Clinicas</h3>
                </div>
                <div class="box-body table-responsive">
                    <div id="tamano" style="color: black;">
                        <asp:GridView
                            DataKeyNames="ID_CLINICA"
                            ID="Grid"
                            AllowPaging="True"
                            CssClass="table"
                            class="table table-gray text-bold table-bordered table-hover"
                            runat="server"
                            AutoGenerateColumns="false"
                            AutoGenerateEditButton="True"
                            DataSourceID="SqlDataSource2">
                            <%--<Columns>
                                <asp:TemplateField HeaderText="#">
                                    <ItemTemplate>
                                        <asp:Label ID="LblCodigo" runat="server" Text='<% # Bind("ID_CLINICA") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextCodigo" runat="server" Text='<% # Bind("ID_CLINICA") %>'></asp:TextBox>
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

                                <asp:TemplateField HeaderText="DESCRIPCION">
                                    <ItemTemplate>
                                        <asp:Label ID="LblDescripcion" runat="server" Text='<% # Bind("DESCRIPCION") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextDescripcion" runat="server" Text='<% # Bind("DESCRIPCION") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>

                                <asp:CommandField ShowDeleteButton="True" ShowEditButton="true" />
                            </Columns>--%>
                            <Columns>
                            <asp:BoundField HeaderText="CLINICA" DataField="CLINICA" />
                            <asp:BoundField HeaderText="DESCRIPCION" DataField="DESCRIPCION" />
                        </Columns>
                            <HeaderStyle CssClass="thead-dark" />
                            <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="350px" />

                        </asp:GridView>
                        
                    </div>
                    <asp:SqlDataSource
                        ID="SqlDataSource2"
                        runat="server"
                        DataSourceMode="DataSet"
                        ConnectionString="<%$ ConnectionStrings:HospitalAdonaiConnectionString %>"
                        SelectCommand="SELECT [ID_CLINICA], [CLINICA], [DESCRIPCION], [ESTADO] FROM [CLINICAS] WHERE ([ESTADO] = @ESTADO)"
                        UpdateCommand="UPDATE CLINICAS SET CLINICA = @CLINICA, DESCRIPCION = @DESCRIPCION WHERE ID_CLINICA = @ID_CLINICA">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="true" Name="estado" Type="Boolean" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <%--<asp:GridView
                        ID="GridView1"
                        runat="server"
                        AutoGenerateColumns="False"
                        DataKeyNames="ID_CLINICA"
                        AutoGenerateEditButton="True"
                        DataSourceID="SqlDataSource2">
                        <Columns>
                            <asp:BoundField HeaderText="Clinica" DataField="CLINICA" />
                            <asp:BoundField HeaderText="Descripcion" DataField="DESCRIPCION" />
                        </Columns>

                    </asp:GridView>--%>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
