<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion.Master" AutoEventWireup="true" CodeBehind="AgendaTurnos.aspx.cs" Inherits="PROYECTO_TURNOS.AgendaTurnos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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
    <br />
    <br />
    <h3 align="center" id="color">AGENDA DE TURNOS </h3>
    <br />
    <h3 id="color2"><i class="fa fa-bullhorn" aria-hidden="true"></i> Atención de Turnos </h3>

    <div style="margin-left: 10px; overflow-x: auto; width: auto;" id="color" class="row">
    
        <div style="margin-left: 10px; overflow:auto;" id="color" class="row">
            <h5><i class="fa fa-user-md" aria-hidden="true"></i> Doctor</h5>
            <br />
            <br />
            <input disabled runat="server" type="text" id="doctormodal" name="doctormodal">
            <br />

        </div>
      </div>
    <div style="margin-left: 10px; width:900px; overflow:auto;" id="color" class="row">
        <div class="col-xl-auto">
            <div class="box box-primary">
                <div class="box-header">
                    <h3 align="center" class="box-title">Listado de Turnos</h3>
                </div>
                <div class="box-body table-responsive">
                    <div id="tamano" style="color: black;">
                        <asp:GridView 
                            DataKeyNames ="ID_TURNO"
                            ID="Grid"                            
                            AllowPaging="True"
                            CssClass="table"
                            class="table table-gray text-bold table-bordered table-hover"
                            method="post" 
                            runat="server"                            
                            AutoGenerateColumns="false">
                            <Columns>
                                <asp:TemplateField HeaderText="#TURNO">
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<% # Bind("TURNO_DIARIO") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox1" runat="server" Text='<% # Bind("TURNO_DIARIO") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="PACIENTE">
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<% # Bind("PERSONA") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextNombres" runat="server" Text='<% # Bind("PERSONA") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="MOTIVO">
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<% # Bind("MOTIVO") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextDPI" runat="server" Text='<% # Bind("MOTIVO") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>

                              <asp:TemplateField HeaderText="OPCIONES">
                                    <ItemTemplate>
                                        <asp:Button ID="btnSelect" runat="server" class="btn btn-info btn-block" Text="LLAMAR"  CommandName='<%# Eval("TURNO_DIARIO") %>' CommandArgument='<%# Eval("PERSONA") %>' />
                                         <asp:Button ID="btnAtender" runat="server" class="btn btn-success btn-block" Text="ATENDER"  CommandName='<%# Eval("TURNO_DIARIO") %>' CommandArgument='<%# Eval("PERSONA") %>' />
                                       <asp:Button ID="btnSuspender" runat="server" class="btn btn-warning btn-block" Text="SUSPENDER"  CommandName='<%# Eval("TURNO_DIARIO") %>' CommandArgument='<%# Eval("PERSONA") %>' />
                                         <asp:Button ID="btnCancelar" runat="server" class="btn btn-danger btn-block" Text="CANCELAR"  CommandName='<%# Eval("TURNO_DIARIO") %>' CommandArgument='<%# Eval("PERSONA") %>' />
                                        
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



