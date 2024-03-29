﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="PROYECTO_TURNOS.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CAP SAN MIGUEL CHICAJ B. V.</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="default.css" />
    <script src="http://code.jquery.com/jquery-latest.js"></script>


</head>
<body style="background-color: darkslateblue">
    <link rel="stylesheet" type="text/css" href="default.css" />
    <form id="form1" runat="server">

        <div>


            <!-- START PAGE SOURCE -->
            <div id="container">
                <div>
                </div>
            </div>
            <div id="turnero">
                <ul style="margin: 18px" id="promobox">
                    <li>
                        <div align="center">
                            <asp:Label align="center" Font-Size="25px" ID="Lbldocclinica4" runat="server" Text="Nombre Doctor" Font-Bold="True" Font-Names="Calibri" ForeColor="White"></asp:Label>
                        </div>
                        <hr style="margin-top: 3px; margin-bottom: 3px; color: deepskyblue" />
                        <br />
                        <div style="margin-left: auto; margin-right: auto; text-align: center;">

                            <asp:Label align="center" Font-Size="25px" ID="Lblt22" runat="server" Text="TURNO ACTUAL" Font-Bold="True" ForeColor="#3399ff"></asp:Label>

                        </div>
                        <br />
                        <div align="center">
                            <asp:Label align="center" Font-Size="60px" ID="Lblcontclinica4" runat="server" Text="22" ForeColor="#3399ff"></asp:Label>
                            <br />
                            <br />
                        </div>
                        <hr style="margin-top: 3px; margin-bottom: 3px; color: deepskyblue" />
                        <div style="margin-left: auto; margin-right: auto; text-align: center;">
                            <asp:Label align="center" Font-Size="25px" ID="Lblpaclinica4" runat="server" Text="Nombre del Paciente" Font-Bold="True" Font-Names="Calibri" ForeColor="White"></asp:Label>
                        </div>
                    </li>
                    <li class="two">
                        <div align="center">
                            <asp:Label align="center" Font-Size="25px" ID="lbldocclinica1" runat="server" Text="Nombre Doctor" Font-Bold="True" Font-Names="Calibri" ForeColor="Black"></asp:Label>
                        </div>
                        <hr style="margin-top: 3px; margin-bottom: 3px; color: deepskyblue" />
                        <br />
                        <div style="margin-left: auto; margin-right: auto; text-align: center;">
                            <asp:Label align="center" Font-Size="25px" ID="Label2" runat="server" Text="TURNO ACTUAL" Font-Bold="True" ForeColor="#09C1FF"></asp:Label>

                        </div>
                        <br />
                        <div align="center">
                            <asp:Label align="center" Font-Size="60px" ID="Lblcontclinica1" runat="server" Text="22" ForeColor="#09C1FF"></asp:Label>
                            <br />
                            <br />
                        </div>
                        <hr style="margin-top: 3px; margin-bottom: 3px; color: deepskyblue" />
                        <div style="margin-left: auto; margin-right: auto; text-align: center;">
                            <asp:Label align="center" Font-Size="25px" ID="lblpaclinica1" runat="server" Text="Nombre del Paciente" Font-Bold="True" Font-Names="Calibri" ForeColor="Black"></asp:Label>
                        </div>
                    </li>
                    <li class="two">
                        <div align="center">
                            <asp:Label align="center" Font-Size="25px" ID="lbldocclinica2" runat="server" Text="Nombre Doctor" Font-Bold="True" Font-Names="Calibri" ForeColor="Black"></asp:Label>
                        </div>
                        <hr style="margin-top: 3px; margin-bottom: 3px; color: deepskyblue" />
                        <br />
                        <div style="margin-left: auto; margin-right: auto; text-align: center;">

                            <asp:Label align="center" Font-Size="25px" ID="Label6" runat="server" Text="TURNO ACTUAL" Font-Bold="True" ForeColor="#09C1FF"></asp:Label>

                        </div>
                        <br />
                        <div align="center">
                            <asp:Label align="center" Font-Size="60px" ID="lblcontclinica2" runat="server" Text="22" ForeColor="#09C1FF"></asp:Label>
                            <br />
                            <br />
                        </div>
                        <hr style="margin-top: 3px; margin-bottom: 3px; color: deepskyblue" />
                        <div style="margin-left: auto; margin-right: auto; text-align: center;">
                            <asp:Label align="center" Font-Size="25px" ID="lblpaclinica2" runat="server" Text="Nombre del Paciente" Font-Bold="True" Font-Names="Calibri" ForeColor="Black"></asp:Label>
                        </div>
                    </li>
                    <li class="two">
                        <div align="center">
                            <asp:Label align="center" Font-Size="25px" ID="lbldocclinica3" runat="server" Text="Nombre Doctor" Font-Bold="True" Font-Names="Calibri" ForeColor="Black"></asp:Label>
                        </div>
                        <hr style="margin-top: 3px; margin-bottom: 3px; color: deepskyblue" />
                        <br />
                        <div style="margin-left: auto; margin-right: auto; text-align: center;">

                            <asp:Label align="center" Font-Size="25px" ID="Label10" runat="server" Text="TURNO ACTUAL" Font-Bold="True" ForeColor="#09C1FF"></asp:Label>

                        </div>
                        <br />
                        <div align="center">
                            <asp:Label align="center" Font-Size="60px" ID="lblcontclinica3" runat="server" Text="22" ForeColor="#09C1FF"></asp:Label>
                            <br />
                            <br />
                        </div>
                        <hr style="margin-top: 3px; margin-bottom: 3px; color: deepskyblue" />
                        <div style="margin-left: auto; margin-right: auto; text-align: center;">
                            <asp:Label align="center" Font-Size="25px" ID="lblpaclinica3" runat="server" Text="Nombre del Paciente" Font-Bold="True" Font-Names="Calibri" ForeColor="Black"></asp:Label>
                        </div>
                    </li>
                    <li style="margin-left: .1px" class="promobox">
                        <div align="center">
                            <asp:Label align="center" Font-Size="25px" ID="Lbldocclinica5" runat="server" Text="Nombre Doctor" Font-Bold="True" Font-Names="Calibri" ForeColor="White"></asp:Label>
                        </div>
                        <hr style="margin-top: 3px; margin-bottom: 3px; color: deepskyblue" />
                        <br />
                        <div style="margin-left: auto; margin-right: auto; text-align: center;">

                            <asp:Label align="center" Font-Size="25px" ID="lbltext22" runat="server" Text="TURNO ACTUAL" Font-Bold="True" ForeColor="#3399ff"></asp:Label>

                        </div>
                        <br />
                        <div align="center">
                            <asp:Label align="center" Font-Size="60px" ID="Lblcontclinica5" runat="server" Text="22" ForeColor="#3399ff"></asp:Label>
                            <br />
                            <br />
                        </div>
                        <hr style="margin-top: 3px; margin-bottom: 3px; color: deepskyblue" />
                        <div style="margin-left: auto; margin-right: auto; text-align: center;">
                            <asp:Label Style="text-align: center" Font-Size="25px" ID="Lblpaclinica5" runat="server" Text="Nombre del Paciente" Font-Bold="True" Font-Names="Calibri" ForeColor="White"></asp:Label>
                        </div>
                    </li>
                </ul>
            </div>
            <br />

            <div id="videosyt" style="margin-left: 18px width: 1398px; margin-left: 200px; width: 1536px;">
                <iframe height="480" src="https://www.youtube.com/embed/4S_L23d7KxQ" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen style="width: 1167px"></iframe>
            </div>
        </div>

        <script>

            $(document).ready(function () {
                var refreshId = setInterval(function () {
                    $('#turnero').load('Dashboard.aspx #turnero');//actualizas el div
                }, 20000);
            });
        </script>

    </form>
</body>
</html>
