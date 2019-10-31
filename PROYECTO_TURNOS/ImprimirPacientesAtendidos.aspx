<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImprimirPacientesAtendidos.aspx.cs" Inherits="PROYECTO_TURNOS.ImprimirPacientesAtendidos" %>

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
<link href='http://fonts.googleapis.com/css?family=Raleway' rel='stylesheet' type='text/css'>
<link href='http://fonts.googleapis.com/css?family=Habibi' rel='stylesheet' type='text/css'>
<link href='http://fonts.googleapis.com/css?family=Cinzel+Decorative:900' rel='stylesheet' type='text/css'>

<script type = "text / javascript" src = "crystalreportviewers13/js/crviewer/crv.js"> </script> 
<script type = "text / javascript" src = "crystalreportviewers13/js/crviewer/bobjcallback.js"> </script> 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Dr. Fernando P.</title>
</head>
<body>
<form id="form1" runat="server">
        <div>
            <style>
                #fontcolor {
                    color: purple;
                    font-size: 30px;
                }

                #color {
                    color: purple;
                }

                #hr {
                    height: 3px;
                    background-color: purple;
                }
            </style>


            <div style="font-size: 18px" id="navbar" class="navbar-collapse collapse">
                <ul id="top-menu" class="nav navbar-nav navbar-right main-nav">
                    <li ><a  <i style="color:midnightblue" class="fa fa-book" aria-hidden="true"> Reportes</i> </a></li>                    
                    <li><a href="AppPrincipal.aspx">Inicio</a></li>
                    <li><a href="ImprimirDiagnostico.aspx">Diagnostico Receta</a></li>
                    <li><a href="ImprimirRegCitas.aspx">Pacientes Atendidos</a></li>
                    <li><a href="ImprimirEmpleados.aspx">Usuarios</a></li>
                    <li><a id="color" href="ImprimirPacientes.aspx">Pacientes</a></li>
                    <li><a href="ImprimirHistorial.aspx">Historial Citas</a></li>
                    <%--<li><a href="ReporteEstadisticas.aspx">Estadísticas</a></li>--%>
                </ul>
            </div>

            <hr id="hr" />
            <h3 style="color: purple" align="center">REGISTRO DE PACIENTES</h3>
            <hr id="hr" />
            <br />
            <br />
            <div align="center" style="margin-left: 12px;">     
                <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="True" GroupTreeImagesFolderUrl="" Height="1202px" ReportSourceID="Pacientes" ToolbarImagesFolderUrl="" ToolPanelView="None" ToolPanelWidth="200px" Width="903px" />
                <CR:CrystalReportSource ID="Pacientes" runat="server">
                    <report filename="RptPacientesAtendidos.rpt">
                    </report>
                </CR:CrystalReportSource>
            </div>
        </div>
        <hr id="hr" />
        <!-- Start Footer Middle -->
        <div class="footer-middle">
            <div class="container">
                <div class="row">
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <div class="footer-copyright">
                            <p style="color: blue">
                                &copy; Copyright 
                                <script> document.write(new Date().getFullYear())</script>
                                <a style="color: purple;" href="AppPrincipal.aspx">Dr. Fenando Alberto Pineda Peñate </a>
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Start Footer Bottom -->
        <div class="footer-bottom">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <p>Desarrollo: COINFER S. A.</p>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>


