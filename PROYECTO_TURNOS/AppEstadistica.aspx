﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Graficas.Master" AutoEventWireup="true" CodeBehind="AppEstadistica.aspx.cs" Inherits="PG_CitasMedicas.AppEstadistica" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h3 style="color: midnightblue" align="center"><i class="fa fa-line-chart" aria-hidden="true"></i> CLASIFICACION DE GRAFICAS</h3>
    <link href="assets/css/estiloh.css" rel="stylesheet" />
    <script src="js/Confirmacion.js"></script>

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
        <a class="navbar-brand"><i id="fontcolor" class="fa fa-area-chart"></i></a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
            <div id="color" class="navbar-nav">

                <a id="color" class="nav-item nav-link active" href="AppEstadistica.aspx"> Generales <span class="sr-only">(current)</span></a>
                <a class="nav-item nav-link active" href="AppEstaPersonalizada.aspx"> Personalizadas  </a> 

            </div>
        </div>
    </nav>
    <!-- END MENU -->
    
    <h3 align="center" id="color">ESTADÍSTICAS</h3>
    <div style="margin-left: 10px; overflow-x: auto; width: auto;" id="color" class="row">
        <div class="container">
            <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
            <script type="text/javascript">
                google.charts.load('current', { 'packages': ['corechart'] });
                google.charts.setOnLoadCallback(drawChart);

                function drawChart() {

                    var data = google.visualization.arrayToDataTable(<%=ObtnerDatosPieGenero()%>);

                    var options = {
                        title: 'Personas atendidas según su genero',
                        legend: { position: 'labeled', textStyle: { color: 'blue', fontSize: 16 } },
                        colors: ['#e70ae7', '#0a3489']
                    }

                    var chart = new google.visualization.PieChart(document.getElementById('piechart'));

                    chart.draw(data, options);
                }
            </script>
            <div id="piechart" style="width: auto; height: 450px;"></div>
        </div>
    </div>


    <hr id="hr" />
    <div style="margin-left: 10px; overflow-x: auto; width: auto;" id="color" class="row">
        <div class="container">
            <script type="text/javascript">
                google.charts.load('current', { 'packages': ['corechart'] });
                google.charts.setOnLoadCallback(drawVisualization);

                function drawVisualization() {

                    var data = google.visualization.arrayToDataTable(<%=ObtnerDatosGeneroConRango()%>);

                    //var view = new google.visualization.DataView(data);
                    var options = {
                        title: 'Personas atendidas según su genero y rango de edad',
                        vAxis: { title: 'Rangos de Edad' },
                        hAxis: { title: 'Genero' },
                        seriesType: 'bars',
                        series: { 5: { type: 'line' } }
                    };

                    var chart = new google.visualization.ComboChart(document.getElementById('chart_div'));
                    chart.draw(data, options);

                    //var chart = new google.visualization.BarChart(document.getElementById("barchart_val"));
                    //chart.draw(view, options);
                }
            </script>
            <div id="chart_div" style="width: 900px; height: 500px;"></div>
        </div>
    </div>

    <hr id="hr" />
    <div style="margin-left: 10px; overflow-x: auto; width: auto;" id="color" class="row">
        <div class="container">
            <script type="text/javascript">
                google.charts.load("current", { packages: ["corechart"] });
                google.charts.setOnLoadCallback(drawChart);
                function drawChart() {
                    var data = google.visualization.arrayToDataTable(<%=ObtnerDatosNiñoAdulto() %>);
                    var view = new google.visualization.DataView(data);

                    var options = {
                        title: "Personas atendidas según su genero y rango de edad",
                        width: 900,
                        height: 300,
                        bar: { groupWidth: "95%" },
                        isStacked: 'percent',
                        height: 300,
                        legend: { position: 'top', maxLines: 3 },
                        hAxis: {
                            minValue: 0,
                            ticks: [0, .3, .6, .9, 1]
                        }
                    };

                    var chart = new google.visualization.BarChart(document.getElementById("barchart_val"));
                    chart.draw(view, options);
                }
            </script>
            <div id="barchart_val" style="width: 900px; height: 300px;"></div>
        </div>
    </div>

    <hr id="hr" />

    <div style="margin-left: 10px; overflow-x: auto; width: auto;" id="color" class="row">
        <div class="container">
            <script type="text/javascript">
                google.charts.load('current', { 'packages': ['corechart'] });
                google.charts.setOnLoadCallback(drawChart);

                function drawChart() {

                    var data = google.visualization.arrayToDataTable(<%=ObtnerDatosMunicipio()%>);

                    var options = {
                        title: 'Personas atendidas según su genero',
                        legend: { position: 'labeled', textStyle: { color: 'blue', fontSize: 16 } },
                        colors: ['#D10F21', '#D1B90F','#0FD169','#0FA4D1','#B40FD1','#F8FF01','#01F9FF','#3801FF']
                    }

                    var chart = new google.visualization.PieChart(document.getElementById('piechart1'));

                    chart.draw(data, options);
                }
            </script>
            <div id="piechart1" style="width: auto; height: 450px;"></div>
        </div>
    </div>

    <hr id="hr" />
    <div style="margin-left: 10px; overflow-x: auto; width: auto;" id="color" class="row">
        <div class="container">
            <script type="text/javascript">
                google.charts.load("current", { packages: ["corechart"] });
                google.charts.setOnLoadCallback(drawChart);
                function drawChart() {
                    var data = google.visualization.arrayToDataTable(<%=ObtnerDatosTurnosMedicos() %>);
                    var view = new google.visualization.DataView(data);

                    var options = {
                        title: "Personas Atendidas, Suspendidas y Canceladas",
                        vAxis: { title: 'Turnos' },
                        hAxis: { title: 'Medicos' },
                        seriesType: 'bars'
                    };

                    var chart = new google.visualization.ComboChart(document.getElementById('chart_div1'));
                    chart.draw(data, options);
                }
            </script>
            <div id="chart_div1" style="width: 900px; height: 500px;"></div>
        </div>
    </div>

</asp:Content>


