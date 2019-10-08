<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion.Master" AutoEventWireup="true" CodeBehind="AppEstadistica.aspx.cs" Inherits="PG_CitasMedicas.AppEstadistica" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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
    <br />
    <br />
    <h3 align="center" id="color">ESTADÍSTICAS</h3>
    <div style="margin-left: 10px; overflow-x: auto; width: auto;" id="color" class="row">
        <div class="container">
            <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
            <script type="text/javascript">
                google.charts.load('current', { 'packages': ['corechart'] });
                google.charts.setOnLoadCallback(drawChart);

                function drawChart() {

                    

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
                google.charts.load("current", { packages: ["corechart"] });
                google.charts.setOnLoadCallback(drawChart);
                function drawChart() {
                    
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
    <h2 align="center" id="color">ESTADÍSTICA DE SERVICIO</h2>

    <div style="margin-left: 10px; overflow-x: auto; width: auto;" id="color" class="row">
        <div class="card card-chart">
            <div class="card-header card-text">
                <div class="container">
                    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
                    <script type="text/javascript">
                        google.charts.load('current', { 'packages': ['corechart'] });
                        google.charts.setOnLoadCallback(drawChart);

                        function drawChart() {
                            

                            var options = {
                                //title: 'Company Performance',                                            
                                curveType: 'function',
                                legend: { position: 'top' }


                            };

                            var chart = new google.visualization.LineChart(document.getElementById('curve_chart'));

                            chart.draw(data, options);
                        }
                    </script>
                    <div id="curve_chart" style="width: auto; height: 500px"></div>
                </div>
            </div>
            <div class="card-footer">
                <div class="stats">
                    <asp:Label Font-Size="15px" ForeColor="midnightblue" ID="LblPreguntaUno" runat="server" Text="Pregunta 1"></asp:Label>
                </div>
            </div>
        </div>
    </div>
    <div style="margin-left: 10px; overflow-x: auto; width: auto;" id="color" class="row">
        <div class="card card-chart">
            <div class="card-header card-text">
                <div class="container">
                    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
                    <script type="text/javascript">
                        google.charts.load('current', { 'packages': ['corechart'] });
                        google.charts.setOnLoadCallback(drawChart);

                        function drawChart() {


                            var options = {
                                //title: 'Company Performance',
                                legend: { position: 'top', maxLines: 6, textStyle: { color: 'blue', fontSize: 12 } },
                                curveType: 'function',
                                legend: { position: 'top' }
                            };

                            var chart = new google.visualization.LineChart(document.getElementById('piechasrt'));

                            chart.draw(data, options);
                        }
                    </script>
                    <div id="piechasrt" style="width: auto; height: 500px"></div>
                </div>
            </div>
            <div class="card-footer">
                <div class="stats">
                    <asp:Label Font-Size="15px" ForeColor="midnightblue" ID="LblPreguntaDos" runat="server" Text="Pregunta 2"></asp:Label>
                </div>
            </div>
        </div>
    </div>
    <div style="margin-left: 10px; overflow-x: auto; width: auto;" id="color" class="row">
        <div class="card card-chart">
            <div class="card-header card-text">
                <div class="container">
                    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
                    <script type="text/javascript">
                        google.charts.load('current', { 'packages': ['corechart'] });
                        google.charts.setOnLoadCallback(drawChart);

                        function drawChart() {
                            

                            var options = {
                                //title: 'Company Performance',
                                curveType: 'function',
                                legend: { position: 'top' }
                            };

                            var chart = new google.visualization.LineChart(document.getElementById('piechasrts'));

                            chart.draw(data, options);
                        }
                    </script>
                    <div id="piechasrts" style="width: auto; height: 500px"></div>
                </div>
            </div>
            <div class="card-footer">
                <div class="stats">
                    <asp:Label Font-Size="15px" ForeColor="midnightblue" ID="LblPreguntaTres" runat="server" Text="Pregunta 3"></asp:Label>
                </div>
            </div>
        </div>
    </div>
    <div style="margin-left: 10px; overflow-x: auto; width: auto;" id="color" class="row">
        <div class="card card-chart">
            <div class="card-header card-text">
                <div class="container">
                    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
                    <script type="text/javascript">
                        google.charts.load('current', { 'packages': ['corechart'] });
                        google.charts.setOnLoadCallback(drawChart);

                        function drawChart() {
                            

                            var options = {
                                //title: 'Company Performance',
                                curveType: 'function',
                                legend: { position: 'top' }

                            };

                            var chart = new google.visualization.LineChart(document.getElementById('piechasrtsss'));

                            chart.draw(data, options);
                        }
                    </script>
                    <div id="piechasrtsss" style="width: auto; height: 500px"></div>
                </div>
            </div>
            <div class="card-footer">
                <div class="stats">
                    <asp:Label Font-Size="15px" ForeColor="midnightblue" ID="LblPreguntaCuatro" runat="server" Text="Pregunta 4"></asp:Label>
                </div>
            </div>
        </div>
    </div>
    <hr id="hr" />
</asp:Content>


