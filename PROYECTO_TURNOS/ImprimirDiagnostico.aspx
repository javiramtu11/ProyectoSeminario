<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImprimirDiagnostico.aspx.cs" Inherits="PG_CitasMedicas.ImprimirDiagnostico" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>


<!DOCTYPE html>
<!-- CSS
    ================================================== -->
<!-- Bootstrap css file-->
<link href="css/bootstrap.min.css" rel="stylesheet">
<!-- Font awesome css file-->
<link href="css/font-awesome.min.css" rel="stylesheet">
<!-- Default Theme css file -->
<link id="switcher" href="css/themes/blue-theme.css" rel="stylesheet">
<!-- Slick slider css file -->
<link href="css/slick.css" rel="stylesheet">
<!-- Photo Swipe Image Gallery -->
<link rel='stylesheet prefetch' href='css/photoswipe.css'>
<link rel='stylesheet prefetch' href='css/default-skin.css'>

<!-- Main structure css file -->
<link href="style.css" rel="stylesheet">

<!-- Google fonts -->
<a href="ImprimirDiagnostico.aspx">ImprimirDiagnostico.aspx</a>
<link href='http://fonts.googleapis.com/css?family=Raleway' rel='stylesheet' type='text/css'>
<link href='http://fonts.googleapis.com/css?family=Habibi' rel='stylesheet' type='text/css'>
<link href='http://fonts.googleapis.com/css?family=Cinzel+Decorative:900' rel='stylesheet' type='text/css'>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>CAP SAN MIGUEL</title>

</head>
<body>
    <form id="form1" runat="server">
        <div>

            <style>
                #fontcolor {
                    color: midnightblue;
                    font-size: 30px;
                }

                #color {
                    color: midnightblue;
                }

                #hr {
                    height: 3px;
                    background-color: midnightblue;
                }
            </style>


            <div style="font-size: 18px" id="navbar" class="navbar-collapse collapse">
                <ul id="top-menu" class="nav navbar-nav navbar-right main-nav">
                    <li ><a  <i style="color:midnightblue" class="fa fa-book" aria-hidden="true"> Reportes</i> </a></li>                    
                    <li><a  href="AppPrincipal.aspx">Inicio</a></li>
                    <li><a id="color" href="ImprimirDiagnostico.aspx">Diagnostico Receta</a></li>
                    <li><a href="ImprimirRegCitas.aspx">Pacientes Atendidos</a></li>
                    <li><a href="ImprimirEmpleados.aspx">Usuarios</a></li>
                    <li><a href="ImprimirPacientes.aspx">Pacientes</a></li>
                    <li><a href="ImprimirHistorial.aspx">Historial Citas</a></li>
                    <%--<li><a href="ReporteEstadisticas.aspx">Estadísticas</a></li>--%>
                </ul>
            </div>

            <hr id="hr"/>
            <h3 style="color: midnightblue" align="center">DIAGNOSTICO RECETA</h3>
            <hr id="hr" />
            <div style="font-size: 18px; margin-left: 12px; margin-right: 12px">
                <asp:Label style="color:midnightblue" ID="Label1" runat="server" Text="Ingrese Codigo de Cita "></asp:Label>
                <asp:TextBox ID="TxtIdcita" runat="server"></asp:TextBox>
                <asp:LinkButton ID="VerDiagnostico"  runat="server"> Ver Diagnostico</asp:LinkButton>
            </div>
            <br />
            <br />
            <div align="center" style="margin-left: 12px;">
                <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="True" GroupTreeImagesFolderUrl="" Height="1202px" OnInit="CrystalReportViewer1_Init" ReportSourceID="CrystalReportSource1" ReuseParameterValuesOnRefresh="True" ToolbarImagesFolderUrl="" ToolPanelView="None" ToolPanelWidth="200px" Width="1104px" />
                <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
                    <Report FileName="RptPacientesAtendidosDoc.rpt">
                    </Report>
                </CR:CrystalReportSource>
            </div>
        </div>
        <hr id="hr" />
    </form>
</body>
</html>
