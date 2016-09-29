<%@ Page Title="" Language="C#" MasterPageFile="~/Perfil_Administrador.master" AutoEventWireup="true" CodeFile="Reporte_Ventas.aspx.cs" Inherits="Reporte_Ventas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script src="Js/amcharts.js"></script>
    <script src="Js/serial.js"></script>
    <script src="Js/pie.js"></script>
    <link href="Estilos/Reporteadores.css" rel="stylesheet" />
    <script src="Estilos/light.js"></script>
    <script src="Estilos/Amarillo.js"></script>
    <script src="Estilos/lightt.js"></script>
    <script src="Estilos/black.js"></script>
    <script type="text/javascript">
 
        var chartData = <%=Session["Datos_Contacto_V"] %>;
        var chart = AmCharts.makeChart( "Grafico1", {
            "type": "pie",
            "theme": "lightt",
            "titles": [ {
                "text": "Porcentaje de Contactabilidad",
                "fontFamily": "Arial",
                "size": 15
            } ],
            "dataProvider":chartData ,
            "valueField": "CANTIDAD",
            "fontSize": 10,
            "titleField": "TIPO_CONTACTO",
            "startEffect": "elastic",
            "startDuration": 2,
            "labelRadius":1,
            "innerRadius": "20%",
            "depth3D": 10,
            "balloonText": "[[title]]<br><span style='font-size:14px'><b>[[value]]</b> ([[percents]]%)</span>",
            "angle": 5,
            "maxLabelWidth": 110,
            "radius": "38%",
            "export": {
                "enabled": true
            }
        } );
        
    </script>
    <script type="text/javascript">
 
        var chartData = <%=Session["Datos_Cierre_V"] %>;
        var chart = AmCharts.makeChart("Grafico2", {
            "type": "serial",
            "theme": "Amarillo",
            "color": "#2e2e2e",
            "fontSize": 12,
            "startEffect": "elastic",
            "fontFamily": "Arial",
            "columnWidth": 0.5,
            "plotAreaFillAlphas": 0.1,
            "plotAreaFillColors": "rgba(0, 0, 0, 0)",
            
            "dataProvider": chartData,
            "valueAxes": [{
                "axisAlpha": 1,
                "axisColor": "white",
                "axisAlpha":1,
                "gridColor": "white",
                "gridAlpha":1,
                "dashLength": 0,
                "title": "Cantidad",
                
                
            }],
            "startDuration": 2,
            "graphs": [{
                "balloonText": "[[category]]: <b>[[value]]</b>",
                //"fillColorsField": "#000000",
                "fillAlphas": 0.4,
                "lineAlpha": 0.4,
                "type": "column",
                "valueField": "CANTIDAD"
            }],
            
            "categoryField": "CIERRE",
            "categoryAxis": {
                "gridPosition": "start",
                "labelRotation": 0,
                "gridColor": " none",
                "tickLength": 10,
                "title": "Cierre",
                "fontSize": 8.5,
                "axisAlpha": 1,
                "axisColor": "white"
            },
             
            "titles": [
            {
                "size": 17,
                "fontFamily": "sans-serif",
                "text": "Tipo de Cierre"
            }],
            "balloon": {
                "animationDuration": 0.4,
                "color": "black",
                "fixedPosition": false,
                "borderColor": "#8b6e01",
                "fillColor": "#ffffff",
                "fillAlpha": 1,
                "fontSize": 12,
                "borderThickness": 4,
                "shadowAlpha": 1,
                "shadowColor": "#8b6e01",
                "borderAlpha": 0 ,
                "fadeOutDuration": 1,
            },

        });

    </script>
    <script type="text/javascript">
 
        var chartData = <%=Session["Datos_Razon_V"] %>;
        var chart = AmCharts.makeChart( "Grafico3", {
            "type": "pie",
            "theme": "none",
            "titles": [ {
                "text": "Top 10 - Tipo de Razón",
                "size": 14
            } ],
            "dataProvider":chartData ,
            "valueField": "CANTIDAD",
            "fontSize": 8,
            "titleField": "RAZON",
            "startEffect": "elastic",
            "startDuration": 2,
            "labelRadius":1,
            "innerRadius": "20%",
            "depth3D": 10,
            "balloonText": "[[title]]<br><span style='font-size:14px'><b>[[value]]</b> ([[percents]]%)</span>",
            "angle": 5,
            "maxLabelWidth": 100,
            "radius": "38%",
            "export": {
                "enabled": true
            }
        } );
        
    </script>
    <script type="text/javascript">
        var chartData = <%=Session["Datos_Transacciones_Dia_V"] %>;
        var chart = AmCharts.makeChart("Grafico4", {
            "type": "serial",
            "theme": "none",
            "dataDateFormat": "YYYY-MM-DD",
            "addClassNames": true,
            "startDuration": 1,
            "startEffect": "easeOutSine",
            "titles": [ {
                "text": "Transacciones por Día",
                "size": 14
            } ],
            "dataProvider": chartData,
            "valueAxes": [{
                "axisAlpha": 0.2,
                "dashLength": 1,
                "position": "left"
            }],
            "mouseWheelZoomEnabled": true,
            "graphs": [{
                "id": "g1",
                "lineThickness":1,
                "balloonText": "[[CANTIDAD]]",
                "bullet": "round",
                "bulletBorderAlpha": 1,
                "bulletColor": "#FFFFFF",
                "hideBulletsCount": 50,
                "valueField": "CANTIDAD",
                "useLineColorForBulletBorder": true,
                "type": "smoothedLine",
                "balloon":{
                    "drop":true
                }
            }],
            "chartScrollbar": {
                "autoGridCount": true,
                "graph": "g1",
                "scrollbarHeight": 40
            },
            "chartCursor": {
                "limitToGraph":"g1"
            },
            "categoryField": "FECHA_GESTION",
            "categoryAxis": {
                "parseDates": true,
                "axisColor": "#DADADA",
                "dashLength": 1,
                "minorGridEnabled": true
            },
            "export": {
                "enabled": true
            }
        });

        //chart.addListener("rendered", zoomChart);
        //zoomChart();

        //// this method is called when chart is first inited as we listen for "rendered" event
        //function zoomChart() {
        //    // different zoom methods can be used - zoomToIndexes, zoomToDates, zoomToCategoryValues
        //    chart.zoomToIndexes(chartData.length - 40, chartData.length -1);
        //}
    </script>
    <script type="text/javascript">
        var chartData = <%=Session["Datos_Transacciones_Dia_Aliado_"] %>;
        var chart = AmCharts.makeChart("Grafico5", {
            "type": "serial",
            "theme": "light",
            "dataDateFormat": "YYYY-MM-DD",
            "addClassNames": true,
            "startDuration": 1,
            "titles": [ {
                "text": "Transacciones por Aliados",
                "size": 14
            } ],
            "dataProvider": chartData,
            "valueAxes": [{
                "axisAlpha": 0.2,
                "dashLength": 1,
                "position": "left"
            }],
            "mouseWheelZoomEnabled": true,
            "graphs": [{
                "id": "g1",
                "lineThickness":1.1,
                "balloonText": "<b>[[ATENTO_COLOMBIA]]</b>",
                "bullet": "round",
                "bulletBorderAlpha": 1,
                "bulletColor": "#FFFFFF",
                "title": "ATENTO COLOMBIA",
                "valueField": "ATENTO_COLOMBIA",
                "useLineColorForBulletBorder": true,
                "type": "smoothedLine",
                "balloon":{
                    "drop":true,
                    "fontSize": 9,
                    "maxWidth": 1000,
                    "borderThickness": 1,
                    "horizontalPadding": 5,
                }
            },
            {
                "id": "g2",
                "lineThickness":1.1,
                "balloonText": "<b>[[BRM]]</b>",
                "bullet": "round",
                "bulletBorderAlpha": 1,
                "bulletColor": "#FFFFFF",
                "title": "BRM",
                "valueField": "BRM",
                "useLineColorForBulletBorder": true,
                "type": "smoothedLine",
                "balloon":{
                    "drop":true,
                    "fontSize": 9,
                    "maxWidth": 1000,
                    "borderThickness": 1,
                    "horizontalPadding": 5,
                }
            },
            {
                "id": "g3",
                "lineThickness":1.1,
                "balloonText": "<b>[[OUTSOURCING_PEREIRA]]</b>",
                "bullet": "round",
                "bulletBorderAlpha": 1,
                "bulletColor": "#FFFFFF",
                "valueField": "OUTSOURCING_PEREIRA",
                "title": "OUTSOURCING PEREIRA",
                "useLineColorForBulletBorder": true,
                "type": "smoothedLine",
                "balloon":{
                    "drop":true,
                    "fontSize": 9,
                    "maxWidth": 1000,
                    "borderThickness": 1,
                    "horizontalPadding": 5,
                }
            },
            {
                "id": "g4",
                "lineThickness":1.1,
                "balloonText": "<b>[[ATENTO_COLOMBIA_PEREIRA]]</b>",
                "bullet": "round",
                "bulletBorderAlpha": 1,
                "bulletColor": "#FFFFFF",
                "hideBulletsCount": 50,
                "valueField": "ATENTO_COLOMBIA_PEREIRA",
                "title": "ATENTO COLOMBIA PEREIRA",
                "useLineColorForBulletBorder": true,
                "type": "smoothedLine",
                "balloon":{
                    "drop":true,
                    "fontSize": 9,
                    "maxWidth": 1000,
                    "borderThickness": 1,
                    "horizontalPadding": 5,
                }
            }],
            "chartScrollbar": {
                "autoGridCount": true,
                "hideResizeGrips": false,
                "graph": "g4",
                "scrollbarHeight": 40
            },
            "chartCursor": {
                "limitToGraph":"g1",
                "limitToGraph":"g2",
                "limitToGraph":"g3",
                "limitToGraph":"g4"
            },
            "categoryField": "FECHA_GESTION",
            "categoryAxis": {
                "parseDates": true,
                "axisColor": "#DADADA",
                "dashLength": 1,
                "minorGridEnabled": true
            },
            "legend": {
                "enabled": true,
                "useGraphSettings": true,
                "fontSize": 8,
                "maxColumns": 4,
                "equalWidths": false,

            },
            "export": {
                "enabled": true
            }
        });
    </script>

    <script type="text/javascript"> 
        var chartData =<%=Session["Datos_Transacciones_Dia_Aliado_U"] %>;
        var chart = AmCharts.makeChart("Grafico6", {
            "type": "serial",
            "theme": "light",
            "dataDateFormat": "YYYY-MM-DD",
            "addClassNames": true,
            "legend": {
                "equalWidths": true,
                "useGraphSettings": true,
                "valueAlign": "left",
                "maxColumns": 4,
                "valueWidth": 120
            },
            "titles": [ {
                "text": "Acomulado por dia Aliados Vs. Usuarios",
                "size": 14
            } ],
            "dataProvider": chartData,
            "valueAxes": [{
                "id": "Transacciones",
                "axisAlpha": 0,
                "gridAlpha": 0,
                "position": "left",
                "title": "Transacciones"
            },
            {
                "id": "Usuarios",
                "axisAlpha": 0,
                "gridAlpha": 0,
                "inside": true,
                "position": "right",
                "title": "Usuarios"
            }],
            "graphs": [{
                "alphaField": "alpha",
                "balloonText": "<b>[[ATENTO_COLOMBIA]]</b> Transacciones",
                "dashLengthField": "dashLength",
                "fillAlphas": 0.7,
                "legendPeriodValueText": "[[ATENTO_COLOMBIA]] ",
                "legendValueText": "[[ATENTO_COLOMBIA]] ",
                "title": "Atento Colombia",
                "type": "column",
                "valueField": "ATENTO_COLOMBIA",
                "valueAxis": "Transacciones",
                
            },
            {
                "alphaField": "alpha",
                "balloonText": "<b>[[BRM]]</b> Transacciones",
                "dashLengthField": "dashLength",
                "fillAlphas": 0.7,
                "legendPeriodValueText": "[[BRM]] ",
                "legendValueText": "[[BRM]] ",
                "title": "BRM",
                "type": "column",
                "valueField": "BRM",
                "valueAxis": "Transacciones"
            },
            {
                "alphaField": "alpha",
                "balloonText": "<b>[[OUTSOURCING_PEREIRA]]</b> Transacciones",
                "dashLengthField": "dashLength",
                "fillAlphas": 0.7,
                "legendPeriodValueText": "[[OUTSOURCING_PEREIRA]] ",
                "legendValueText": "[[OUTSOURCING_PEREIRA]] ",
                "title": "OutSourcing Pereira",
                "type": "column",
                "valueField": "OUTSOURCING_PEREIRA",
                "valueAxis": "Transacciones"
            },
            {
                "alphaField": "alpha",
                "balloonText": "<b>[[ATENTO_COLOMBIA_PEREIRA]]</b> Transacciones",
                "dashLengthField": "dashLength",
                "fillAlphas": 0.7,
                "legendPeriodValueText": "[[ATENTO_COLOMBIA_PEREIRA]] ",
                "legendValueText": "[[ATENTO_COLOMBIA_PEREIRA]] ",
                "title": "Atento Colombia Pereira",
                "type": "column",
                "valueField": "ATENTO_COLOMBIA_PEREIRA",
                "valueAxis": "Transacciones"
            },
            //{
            //    "balloonText": "latitude:[[value]]",
            //    "bullet": "round",
            //    "bulletBorderAlpha": 1,
            //    "useLineColorForBulletBorder": true,
            //    "bulletColor": "#FFFFFF",
            //    "bulletSizeField": "townSize",
            //    "dashLengthField": "dashLength",
            //    //"descriptionField": "townName",
            //    //"labelPosition": "right",
            //    //"labelText": "[[townName2]]",
            //    //"legendValueText": "[[description]]/[[value]]",
            //    "title": "latitude/city",
            //    "fillAlphas": 0,
            //    "valueField": "CANT_ATENTO_COLOMBIA",
            //    "valueAxis": "Usuarios"
            //},
            {
                id: "g1",
                classNameField: "bulletClass",
                "bullet": "round",
                "bulletBorderAlpha": 1,
                "useLineColorForBulletBorder": true,
                "bulletBorderColor": "#79CDF3",
                lineColor: "#79CDF3",
                "lineThickness":1.5,
                "bulletBorderThickness": 3,
                "bulletColor": "#FFFFFF",
                "bulletSize": 9,
                "dashLengthField": "dashLength",
                "balloonText": "<b>[[CANT_ATENTO_COLOMBIA]]</b> Usuarios",
                "title": "Usuarios",
                "type": "smoothedLine",
                "fillAlphas": 0,
                "valueField": "CANT_ATENTO_COLOMBIA",
                "valueAxis": "Usuarios"
            },
            {
                id: "g2",
                "bullet": "round",
                "bulletBorderAlpha":1,
                "bulletBorderColor": "#F6D944",
                "bulletBorderThickness": 3,
                "bulletColor": "#FFFFFF",
                "bulletSize": 9,
                lineColor: "#F6D944",
                "lineThickness":1.5,
                "dashLengthField": "dashLength",
                "balloonText": "<b>[[CANT_BRM]]</b> Usuarios",
                "title": "Usuarios",
                "fillAlphas": 0,
                "type": "smoothedLine",
                "valueField": "CANT_BRM",
                "valueAxis": "Usuarios",
                animationPlayed: false,
            },
            {
                "id": "g3",
                bullet: "round",
                "bulletBorderAlpha": 1,
                "bulletBorderColor": "#A1C588",
                "bulletBorderThickness": 3,
                "bulletColor": "#FFFFFF",
                "bulletSize": 9,
                lineColor: "#A1C588",
                "lineThickness":1.5,
                "dashLengthField": "dashLength",
                "balloonText": "<b>[[CANT_OUTSOURCING_PEREIRA]]</b> Usuarios",
                "title": "Usuarios",
                "fillAlphas": 0,
                "type": "smoothedLine",
                "valueField": "CANT_OUTSOURCING_PEREIRA",
                "valueAxis": "Usuarios"
            },
            {
                id: "g4",
                "bullet": "round",
                "bulletBorderAlpha": 1,
                "bulletBorderColor": "#D27575",
                "bulletBorderThickness": 3,
                "bulletColor": "#FFFFFF",
                "bulletSize": 9,
                lineColor: "#D27575",
                "lineThickness":1.5,
                "dashLengthField": "dashLength",
                "balloonText": "<b>[[CANT_ATENTO_COLOMBIA_PEREIRA]]</b> Usuarios",
                "title": "Usuarios",
                "fillAlphas": 0,
                "type": "smoothedLine",
                "valueField": "CANT_ATENTO_COLOMBIA_PEREIRA",
                "valueAxis": "Usuarios"
            },
            ],
            "chartCursor": {
                "categoryBalloonDateFormat": "DD",
                "cursorAlpha": 0.1,
                "cursorColor":"#000000",
                "fullWidth":true,
                "valueBalloonsEnabled": false,
                "zoomable": false
            },
            //"dataDateFormat": "YYYY-MM-DD",
            "categoryField": "FECHA_GESTION",
            "categoryAxis": {
                //"dateFormats": [{
                //    "period": "DD",
                //    "format": "DD"
                //}, {
                //    "period": "WW",
                //    "format": "MMM DD"
                //}, {
                //    "period": "MM",
                //    "format": "MMM"
                //}, {
                //    "period": "YYYY",
                //    "format": "YYYY"
                //}],
                "parseDates": true,
                "autoGridCount": false,
                "axisColor": "#555555",
                "gridAlpha": 0.1,
                "gridColor": "#FFFFFF",
                "gridCount": 50
            },
            "export": {
                "enabled": true
            }
        });
    </script>

    <script type="text/javascript">
        var chartData = <%=Session["Datos_Pronostico_V"] %>;
        var chart = AmCharts.makeChart("Grafico7", {
            "type": "serial",
            "theme": "light",
            "addClassNames": true,
            "startDuration": 1,
            "startEffect": "elastic",
            "titles": [ {
                "text": "Pronósticos a Cierre de Mes",
                "size": 14
            } ],
            "dataProvider": chartData,
            "valueAxes": [{
                "axisAlpha": 0.2,
                "dashLength": 1,
                "position": "left",
                title: "Cantidades"
            }],
            "mouseWheelZoomEnabled": true,
            "graphs": [{
                "id": "g1",
                "fillAlphas": 0.6,
                "fillColors": "#4ac2f9",
                lineColor: "#005c87",
                "lineThickness":1,
                "balloonText": "[[CANTIDAD]]",
                "bullet": "round",
                "bulletBorderAlpha": 1,
                "bulletColor": "#FFFFFF",
                "hideBulletsCount": 50,
                "valueField": "CANTIDAD",
                "useLineColorForBulletBorder": true,
                "type": "smoothedLine",
                "balloon":{
                    "drop":true
                }
            }],
            "chartScrollbar": {
                "autoGridCount": true,
                "graph": "g1",
                "scrollbarHeight": 40
            },
            "chartCursor": {
                "limitToGraph":"g1"
            },
            "categoryField": "FECHA",
            "categoryAxis": {
                "parseDates": true,
                "axisColor": "#DADADA",
                "dashLength": 1,
                "minorGridEnabled": true
            },
            "export": {
                "enabled": true
            }
        });
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2 class="Titulo_Reporte">REPORTEADOR DE VENTAS</h2>
    <hr />
    <div id="Grafico4" class="Reporte_Fechas">
    </div>
    <div id="Grafico5" class="Reporte_Fechas">
    </div>
    <div id="Grafico6" class="Reporte_Fechas_U">
    </div>
    <div id="Grafico1" class="Reporte_Cierre">
    </div>
    <div id="Grafico2" class="Reporte_Cierre">
    </div>
    <div id="Grafico3" class="Reporte_Cierre">
    </div>
    <div id="Grafico7" class="Reporte_Fechas_U">
    </div>
</asp:Content>

