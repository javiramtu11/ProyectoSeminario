<%@ Page Title="" Language="C#" MasterPageFile="~/Agenda.master" AutoEventWireup="true" CodeBehind="AgendaTurnosSuspendidos.aspx.cs" Inherits="PROYECTO_TURNOS.AgendaTurnosSuspendidos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 style="color: midnightblue" align="center"><i class="fa fa-cog" aria-hidden="true"></i>CONFIGURACION DE TURNOS</h3>
    <link href="assets/css/estiloh.css" rel="stylesheet" />
    <script src="js/Confirmacion.js"></script>


    <link href="assets/css/estiloh.css" rel="stylesheet" />

    <style>
        #hr {
            height: 3px;
            background-color: midnightblue;
        }

        #color {
            align-items: center;
            align-content: center;
            color: midnightblue;
        }

        #color2 {
            align-items: flex-start;
            align-content: flex-start;
            color: teal;
        }

        .contenedor {
            width: auto;
            height: auto;
            background-color: #ccc;
            overflow-x: auto;
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

                <a id="color" class="nav-item nav-link active" href="AgendaTurnos.aspx">Turnos Diarios </a>
                <a class="nav-item nav-link active" href="AgendaTurnosSuspendidos.aspx">Turnos Suspendidos <span class="sr-only">(current)</span> </a> 

            </div>
        </div>
    </nav>
    <!-- END MENU -->
 
    <h3 align="center" id="color">AGENDA DE TURNOS SUSPENDIDOS </h3>
    <br />
    <h3 id="color2"><i class="fa fa-bullhorn" aria-hidden="true"></i>Atención de Turnos Suspendidos </h3>

    <div style="margin-left: 10px; overflow-x: auto; width: auto;" id="color" class="row">

        <div style="margin-left: 10px; overflow: auto;" id="color" class="row">
            <h5><i class="fa fa-user-md" aria-hidden="true"></i>Doctor</h5>
            <br />
            <br />
            <input disabled runat="server" type="text" id="doctormodal" name="doctormodal">
            <br />

        </div>
    </div>
    <div style="margin-left: 10px; width: 900px; overflow: auto;" id="color" class="row">
        <div class="col-xl-auto">
            <div class="box box-primary">
                <div class="box-header">
                    <h3 align="center" class="box-title">Listado de Turnos</h3>
                </div>
                <div class="box-body table-responsive">
                    <div id="tamano" style="color: black;">
                        <asp:GridView
                            ID="Grid"
                            DataKeyNames="ID_TURNO"
                            CssClass="table"
                            class="table table-gray text-bold table-bordered table-hover"
                            runat="server"
                            AutoGenerateColumns="false"
                            OnPageIndexChanging="Grid_PageIndexChanging"
                            AllowPaging="True"
                            Height="122px" Width="875px">


                            <Columns>
                                <asp:TemplateField Visible ="false" HeaderText="#TURNO">
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<% # Bind("ID_TURNO") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="textid" runat="server" Text='<% # Bind("ID_TURNO") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>


                                <asp:TemplateField HeaderText="#TURNO">
                                    <ItemTemplate>
                                        <asp:Label ID="Label1x" runat="server" Text='<% # Bind("TURNO_DIARIO") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox1" runat="server" Text='<% # Bind("TURNO_DIARIO") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="PACIENTE">
                                    <ItemTemplate>
                                        <asp:Label ID="Label1xx" runat="server" Text='<% # Bind("PERSONA") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextNombres" runat="server" Text='<% # Bind("PERSONA") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="MOTIVO">
                                    <ItemTemplate>
                                        <asp:Label ID="Label1xxx" runat="server" Text='<% # Bind("MOTIVO") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextDPI" runat="server" Text='<% # Bind("MOTIVO") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="OPCIONES">
                                    <ItemTemplate>
                                        <asp:Button ID="btnSelect" OnClick="btnSelect_Click" runat="server" class="btn btn-info btn-block" Text="LLAMAR" CommandName='<%# Eval("ID_TURNO") %>' CommandArgument='<%# Eval("PERSONA") %>' />
                                        <asp:Button ID="btnAtender" OnClick="btnAtender_Click" runat="server" class="btn btn-success btn-block" Text="ATENDER" CommandName='<%# Eval("ID_TURNO") %>' CommandArgument='<%# Eval("PERSONA") %>' />
                                        <asp:Button ID="btnCancelar" OnClick="btnCancelar_Click" runat="server" class="btn btn-danger btn-block" Text="CANCELAR" CommandName='<%# Eval("ID_TURNO") %>' CommandArgument='<%# Eval("PERSONA") %>' />

                                    </ItemTemplate>
                                </asp:TemplateField>

                            </Columns>
                            <HeaderStyle CssClass="thead-dark" />
                            <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="350px" />
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>



    <div>
    </div>

</asp:Content>




