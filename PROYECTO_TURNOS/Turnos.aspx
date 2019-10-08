<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Turnos.aspx.cs" Inherits="PROYECTO_TURNOS.Turnos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0, shrink-to-fit=no' name='viewport' />
    <!--     Fonts and icons     -->
    <link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Roboto+Slab:400,700|Material+Icons" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css">
    <!-- CSS Files -->
    <link href="assets/css/material-dashboard.css?v=2.1.1" rel="stylesheet" />
    <!-- CSS Just for demo purpose, don't include it in your project -->
    <link href="assets/demo/demo.css" rel="stylesheet" />


    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <title>Blue Hosting</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="default.css" />
</head>



<body>
    <form id="form1" runat="server">
        <div>
            <!-- START PAGE SOURCE -->
            <div id="container">
                <div>
                </div>
            </div>
            
            <ul id="promobox">
                <li>
                    <div align="center">
                        <asp:Label align="center" Font-Size="25px" ID="LblDocNameT1" runat="server" Text="Nombre Doctor"></asp:Label>
                    </div>
                    <hr style="margin-top: 3px; margin-bottom: 3px" />
                    <div align="center" class="logo">
                        <asp:Label align="center" Font-Size="25px" ID="LblTurnoActualT1" runat="server" Text="TURNO ACTUAL"></asp:Label>
                    </div>
                    <div align="center">
                        <asp:Label align="center" Font-Size="60px" ID="LblT1" runat="server" Text="22"></asp:Label>
                    </div>
                    <hr style="margin-top: 3px; margin-bottom: 3px" />
                    <asp:Label align="center" Font-Size="25px" ID="LblNombreT1" runat="server" Text="Nombre del Paciente"></asp:Label>
                </li>
                <li class="two">
                    <div align="center">
                        <asp:Label align="center" Font-Size="25px" ID="Label1" runat="server" Text="Nombre Doctor"></asp:Label>
                    </div>
                    <hr style="margin-top: 3px; margin-bottom: 3px" />
                    <div align="center" class="logo">
                        <asp:Label align="center" Font-Size="25px" ID="Label2" runat="server" Text="TURNO ACTUAL"></asp:Label>
                    </div>
                    <div align="center">
                        <asp:Label align="center" Font-Size="60px" ID="Label3" runat="server" Text="22"></asp:Label>
                    </div>
                    <hr style="margin-top: 3px; margin-bottom: 3px" />
                    <asp:Label align="center" Font-Size="25px" ID="Label4" runat="server" Text="Nombre del Paciente"></asp:Label>
                </li>
              
                    <li class="promobox">
                        <div align="center">
                            <asp:Label align="center" Font-Size="25px" ID="Label5" runat="server" Text="Nombre Doctor"></asp:Label>
                        </div>
                        <hr style="margin-top: 3px; margin-bottom: 3px" />
                        <div align="center" class="logo">
                            <asp:Label align="center" Font-Size="25px" ID="Label6" runat="server" Text="TURNO ACTUAL"></asp:Label>
                        </div>
                        <div align="center">
                            <asp:Label align="center" Font-Size="60px" ID="Label7" runat="server" Text="22"></asp:Label>
                        </div>
                        <hr style="margin-top: 3px; margin-bottom: 3px" />
                        <asp:Label align="center" Font-Size="25px" ID="Label8" runat="server" Text="Nombre del Paciente"></asp:Label>
                    </li>
                
                <!-- div> -->
                <li class="three">
                    <div align="center">
                        <asp:Label align="center" Font-Size="25px" ID="Label9" runat="server" Text="Nombre Doctor"></asp:Label>
                    </div>
                    <hr style="margin-top: 3px; margin-bottom: 3px" />
                    <div align="center" class="logo">
                        <asp:Label align="center" Font-Size="25px" ID="Label10" runat="server" Text="TURNO ACTUAL"></asp:Label>
                    </div>
                    <div align="center">
                        <asp:Label align="center" Font-Size="60px" ID="Label11" runat="server" Text="22"></asp:Label>
                    </div>
                    <hr style="margin-top: 3px; margin-bottom: 3px" />
                    <asp:Label align="center" Font-Size="25px" ID="Label12" runat="server" Text="Nombre del Paciente"></asp:Label>
                </li>
            </ul>
            </div>
            <br />
            <hr />
        <

            <div style="width: auto; margin-left: 10px">
                <iframe class="centrado" height="480" src="https://www.youtube.com/embed/4S_L23d7KxQ" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen style="width: 1101px"></iframe>
            </div>
       

        
        <!--   Core JS Files   -->
        <script src="assets/js/core/jquery.min.js"></script>
        <script src="assets/js/core/popper.min.js"></script>
        <script src="assets/js/core/bootstrap-material-design.min.js"></script>
        <script src="assets/js/plugins/perfect-scrollbar.jquery.min.js"></script>
        <!-- Plugin for the momentJs  -->
        <script src="assets/js/plugins/moment.min.js"></script>
        <!--  Plugin for Sweet Alert -->
        <script src="assets/js/plugins/sweetalert2.js"></script>
        <!-- Forms Validations Plugin -->
        <script src="assets/js/plugins/jquery.validate.min.js"></script>
        <!-- Plugin for the Wizard, full documentation here: https://github.com/VinceG/twitter-bootstrap-wizard -->
        <script src="assets/js/plugins/jquery.bootstrap-wizard.js"></script>
        <!--	Plugin for Select, full documentation here: http://silviomoreto.github.io/bootstrap-select -->
        <script src="assets/js/plugins/bootstrap-selectpicker.js"></script>
        <!--  Plugin for the DateTimePicker, full documentation here: https://eonasdan.github.io/bootstrap-datetimepicker/ -->
        <script src="assets/js/plugins/bootstrap-datetimepicker.min.js"></script>
        <!--  DataTables.net Plugin, full documentation here: https://datatables.net/  -->
        <script src="assets/js/plugins/jquery.dataTables.min.js"></script>
        <!--	Plugin for Tags, full documentation here: https://github.com/bootstrap-tagsinput/bootstrap-tagsinputs  -->
        <script src="assets/js/plugins/bootstrap-tagsinput.js"></script>
        <!-- Plugin for Fileupload, full documentation here: http://www.jasny.net/bootstrap/javascript/#fileinput -->
        <script src="assets/js/plugins/jasny-bootstrap.min.js"></script>
        <!--  Full Calendar Plugin, full documentation here: https://github.com/fullcalendar/fullcalendar    -->
        <script src="assets/js/plugins/fullcalendar.min.js"></script>
        <!-- Vector Map plugin, full documentation here: http://jvectormap.com/documentation/ -->
        <script src="assets/js/plugins/jquery-jvectormap.js"></script>
        <!--  Plugin for the Sliders, full documentation here: http://refreshless.com/nouislider/ -->
        <script src="assets/js/plugins/nouislider.min.js"></script>
        <!-- Include a polyfill for ES6 Promises (optional) for IE11, UC Browser and Android browser support SweetAlert -->
        <script src="https://cdnjs.cloudflare.com/ajax/libs/core-js/2.4.1/core.js"></script>
        <!-- Library for adding dinamically elements -->
        <script src="assets/js/plugins/arrive.min.js"></script>
        <!--  Google Maps Plugin    -->
        <script src="https://maps.googleapis.com/maps/api/js?key=YOUR_KEY_HERE"></script>
        <!-- Chartist JS -->
        <script src="assets/js/plugins/chartist.min.js"></script>
        <!--  Notifications Plugin    -->
        <script src="assets/js/plugins/bootstrap-notify.js"></script>
        <!-- Control Center for Material Dashboard: parallax effects, scripts for the example pages etc -->
        <script src="assets/js/material-dashboard.js?v=2.1.1" type="text/javascript"></script>
        <!-- Material Dashboard DEMO methods, don't include it in your project! -->
    </form>
</body>
</html>
