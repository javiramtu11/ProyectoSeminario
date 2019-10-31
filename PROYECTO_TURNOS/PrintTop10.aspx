<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrintTop10.aspx.cs" Inherits="PROYECTO_TURNOS.PrintTop10" %>

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
<%--<a href="ImprimirDiagnostico.aspx">ImprimirDiagnostico.aspx</a>--%>
<link href='http://fonts.googleapis.com/css?family=Raleway' rel='stylesheet' type='text/css'>
<link href='http://fonts.googleapis.com/css?family=Habibi' rel='stylesheet' type='text/css'>
<link href='http://fonts.googleapis.com/css?family=Cinzel+Decorative:900' rel='stylesheet' type='text/css'>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
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
                    <li><a href="PrintPacientesAtendidos.aspx">Pacientes Atendidos</a></li>
                    <li><a  href="PrintPacientes.aspx">Pacientes</a></li>
                    <li><a id="color" href="PrintTop10.aspx">Top10 Pacientes Frecuentes</a></li>
                    <li><a href="PrintPersonal.aspx">Usuarios</a></li>
                </ul>
            </div>

            <hr id="hr"/>
            <h3 style="color: midnightblue" align="center">TOP 10 - PACIENTES FRECUENTES</h3>
            <hr id="hr" />
            <br />
            <br />
            <div align="center" style="margin-left: 12px;">
                <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="True" GroupTreeImagesFolderUrl="" Height="1202px" ReportSourceID="CrystalReportSource1" ToolbarImagesFolderUrl="" ToolPanelView="None" ToolPanelWidth="200px" Width="1104px" />
                <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
                    <Report FileName="RptPacientesFrecuentes.rpt">
                    </Report>
                </CR:CrystalReportSource>
            </div>
        </div>
        <hr id="hr" />
    </form>
</body>

</html>

