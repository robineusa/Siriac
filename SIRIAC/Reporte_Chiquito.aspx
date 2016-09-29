<%@ Page Title="" Language="C#" MasterPageFile="~/Perfil_Administrador.master" AutoEventWireup="true" CodeFile="Reporte_Chiquito.aspx.cs" Inherits="Reporte_Chiquito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <button type="button" id="btnGrafico">LLenar Gráfico</button>
    <div id="grafico"></div>
    <asp:Button ID="Graficar" runat="server" Text="Button" />
   <script src="/scripts/jquery.js"></script>
<script src="/scripts/highcharts.js"></script>
<script src="/scripts/exporting.js"></script>
    <script>
        $(document).ready(function () {
            $("#btnGrafico").click("click", function () {
                ListaPubli();
            });
        });

        function ListaPubli() {
            $.ajax({
                type: "POST",
                contentType: "application/json; charset=utf-8",
                url: "Reporte_Chiquito.aspx/prueba()",
                data: "{}",
                dataType: "json",
                success: function (Result) {
                    Result = Result.d;
                    var data = [];
                    for (var i in Result) {
                        var serie = new Array(Result[i].CIERRE, Result[i].CANTIDAD);
                        data.push(serie);
                    }
                    DibujaGrafico(data);
                    //DreawChartPubli(data, 'container2');
                },
                error: function (Result) {
                    alert("Error");
                }
            });
        }

        function DibujaGrafico(series) {
            $('#grafico').highcharts({
                chart: {
                    plotBackgroundColor: null,
                    plotBorderWidth: 1,//null,
                    plotShadow: false
                },
                title: {
                    text: 'Publicidad en mi web 2013 - 2014'
                },
                subtitle: {
                    text: 'mipagina.com'
                },
                tooltip: {
                    pointFormat: '{series.name}: {point.y} (<b>{point.percentage:.1f}%</b>)'
                },
                plotOptions: {
                    pie: {
                        allowPointSelect: true,
                        cursor: 'pointer',
                        dataLabels: {
                            enabled: true,
                            format: '<b>{point.name}</b>: {point.y}',
                            style: {
                                color: (Highcharts.theme && Highcharts.theme.contrastTextColor) || 'black'
                            }
                        }
                    }
                },
                series: [{
                    type: 'pie',
                    name: 'Publicidad',
                    data: series
                }]
            });
        }
    </script>
</asp:Content>

