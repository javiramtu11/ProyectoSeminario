<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="PROYECTO_TURNOS.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title>Blue Hosting</title>
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <link rel="stylesheet" type="text/css" href="default.css" />
</head>
<body>
  <link rel="stylesheet" type="text/css" href="default.css" />
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
                    <asp:Label align="center" Font-Size="25px" ID="LblDocNameT1" runat="server" Text="Nombre Doctor" Font-Bold="True" Font-Names="Calibri" ForeColor="#000066"></asp:Label>
                </div>
                <hr style="margin-top: 3px; margin-bottom: 3px" />
                <div align="center" class="logo">
                    <asp:Label align="center" Font-Size="25px" ID="LblTurnoActualT1" runat="server" Text="TURNO ACTUAL" Font-Bold="True"></asp:Label>
                </div>
                <div align="center">
                    <asp:Label align="center" Font-Size="60px" ID="LblT1" runat="server" Text="22"></asp:Label>
                    <br />
                    <br />
                    <br />
                </div>
                <hr style="margin-top: 3px; margin-bottom: 3px" />
                <asp:Label align="center" Font-Size="25px" ID="LblNombreT1" runat="server" Text="Nombre del Paciente" Font-Bold="True" Font-Names="Calibri" ForeColor="#000066"></asp:Label>
            </li>
            <li class="two">
                <div align="center">
                    <asp:Label align="center" Font-Size="25px" ID="Label1" runat="server" Text="Nombre Doctor" Font-Bold="True" Font-Names="Calibri" ForeColor="#000066"></asp:Label>
                </div>
                <hr style="margin-top: 3px; margin-bottom: 3px" />
                <div align="center" class="logo">
                    <asp:Label align="center" Font-Size="25px" ID="Label2" runat="server" Text="TURNO ACTUAL" Font-Bold="True"></asp:Label>
                </div>
                <div align="center">
                    <asp:Label align="center" Font-Size="60px" ID="Label3" runat="server" Text="22"></asp:Label>
                    <br />
                    <br />
                    <br />
                </div>
                <hr style="margin-top: 3px; margin-bottom: 3px" />
                <asp:Label align="center" Font-Size="25px" ID="Label4" runat="server" Text="Nombre del Paciente" Font-Bold="True" Font-Names="Calibri" ForeColor="#000066"></asp:Label>
            </li>
            <li class="promobox">
                <div align="center">
                    <asp:Label align="center" Font-Size="25px" ID="Label5" runat="server" Text="Nombre Doctor" Font-Bold="True" Font-Names="Calibri" ForeColor="#000066"></asp:Label>
                </div>
                <hr style="margin-top: 3px; margin-bottom: 3px" />
                <div align="center" class="logo">
                    <asp:Label align="center" Font-Size="25px" ID="Label6" runat="server" Text="TURNO ACTUAL" Font-Bold="True"></asp:Label>
                </div>
                <div align="center">
                    <asp:Label align="center" Font-Size="60px" ID="Label7" runat="server" Text="22"></asp:Label>
                    <br />
                    <br />
                    <br />
                </div>
                <hr style="margin-top: 3px; margin-bottom: 3px" />
                <asp:Label align="center" Font-Size="25px" ID="Label8" runat="server" Text="Nombre del Paciente" Font-Bold="True" Font-Names="Calibri" ForeColor="#000066"></asp:Label>
            </li>
            <li class="three">
                <div align="center">
                    <asp:Label align="center" Font-Size="25px" ID="Label9" runat="server" Text="Nombre Doctor" Font-Bold="True" Font-Names="Calibri" ForeColor="#000066"></asp:Label>
                </div>
                <hr style="margin-top: 3px; margin-bottom: 3px" />
                <div align="center" class="logo">
                    <asp:Label align="center" Font-Size="25px" ID="Label10" runat="server" Text="TURNO ACTUAL" Font-Bold="True"></asp:Label>
                </div>
                <div align="center">
                    <asp:Label align="center" Font-Size="60px" ID="Label11" runat="server" Text="22"></asp:Label>
                    <br />
                    <br />
                    <br />
                </div>
                <hr style="margin-top: 3px; margin-bottom: 3px" />
                <asp:Label align="center" Font-Size="25px" ID="Label12" runat="server" Text="Nombre del Paciente" Font-Bold="True" Font-Names="Calibri" ForeColor="#000066"></asp:Label>
            </li>
        </ul>
        <br />
      
        <div style="width:  auto;  margin-left: 200px">
            <iframe  height="480" src="https://www.youtube.com/embed/4S_L23d7KxQ" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen style="width: 1101px"></iframe>
        </div>
    </div>
    </form>
</body>
</html>
