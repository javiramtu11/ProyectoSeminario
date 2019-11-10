<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PROYECTO_TURNOS.Login" %>

<!DOCTYPE html>

<html class="bg-black" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Inicio de Sesión CAP San Miguel Chicaj.</title>
    <link rel="icon" type="image/png" href="assets/img/windicon.png">
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="//cdnjs.cloudflare.com/ajax/libs/font-awesome/4.1.0/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href="estilos/css/AdminLTE.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous" />
</head>
<style>
    #color {
        background-color: midnightblue;
    }
    #font {
        font-size: 12px;
    }
</style>

<body class="bg-black">
    <div class="form-box" style="width:450px" id="login-box">
        <div id="color" class="header">Iniciar Sesión</div>
        <form  id="form1" runat="server">
            <div  class="body bg-gray">
                <div class="form-group">
                    <asp:TextBox style="font-size:28px; height:45px" ID="txtUsuario" runat="server" CssClass="form-control" placeholder="Ingrese usuario"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox style="font-size:28px; height:45px" ID="txtPassword" runat="server" CssClass="form-control" type="password" placeholder="Ingrese contraseña"></asp:TextBox>
                </div>
            </div>
            <div class="footer">
                <asp:Button style="font-size:28px;" ID="BtnIngresar" runat="server" Text="Iniciar Sesión" CssClass="btn bg-blue-gradient btn-block" OnClick="BtnIngresar_Click" />
            </div>
        </form>
    </div>

    <br />
    <br />
    <br />
    <br />
    <br />
    <br />


    <div id="font" align="center">
        <div class="footer-copyright">
            <p>
                &copy; Copyright 
                                <script> document.write(new Date().getFullYear())</script>
                <a href="index.aspx">CAP SAN MIGUEL CHICAJ B.V.</a>
            </p>
        </div>

        <div class="col-md-12">
            <p>Desarrollo: INATEC S. A.</p>
        </div>
    </div>

    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
</body>
</html>

