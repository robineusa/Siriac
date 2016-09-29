<%@ Page Title="" Language="C#" MasterPageFile="~/Perfil_Administrador.master" AutoEventWireup="true" CodeFile="Reporte_Convenio_Electronico.aspx.cs" Inherits="Reporte_Convenio_Electronico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
     <script src="Js/amcharts.js"></script>
    <script src="Js/serial.js"></script>
    <script src="Estilos/black.js"></script>
    <script src="Estilos/Orange.js"></script>
    <script src="Estilos/Azul.js"></script>
    <script src="Estilos/Rojo.js"></script>
    <script src="Js/pie.js"></script>
    <script src="Estilos/light.js"></script>
    <script src="Js/none.js"></script>
    <link href="Estilos/Style_Ingreso_Casos.css" rel="stylesheet" />
    <link href="Estilos/Reporteadores.css" rel="stylesheet" />
    <script type="text/javascript">
 
        var chartData = <%=Session["Datos_Contacto"] %>;
        var chart = AmCharts.makeChart("Grafico1", {
            "type": "serial",
            "theme": "Azul",
            "color": "#2e2e2e",
            "fontSize": 12,
            "startEffect": "easeOutSine",
            "fontFamily": "Arial",
            "columnWidth": 0.5,
            "plotAreaFillAlphas": 0.1,
            "plotAreaFillColors": "rgba(255, 255, 255, 0.5)",
            
            "dataProvider": chartData,
            "valueAxes": [{
                "axisAlpha": 1,
                "gridAlpha": 0.8,
                "gridColor": "white",
                "dashLength": 0,
                "title": "Cantidad",
                
                
            }],
            "startDuration": 1,
            "graphs": [{
                "balloonText": "[[category]]: <b>[[value]]</b>",
                //"fillColorsField": "#000000",
                "fillAlphas": 0.8,
                "lineAlpha": 1,
                "type": "column",
                "valueField": "CANTIDAD"
            }],
            
            "categoryField": "TIPO_CONTACTO",
            "categoryAxis": {
                "gridPosition": "start",
                "labelRotation": 0,
                "gridColor": " none",
                "tickLength": 10,
                "title": "Tipo de Contacto",
                "fontSize": 8.5,
            },
             
            "titles": [
		    {
		        "size": 17,
		        "fontFamily": "sans-serif",
		        "text": "Tipo de Contacto"
		    }],
            "balloon": {
                "animationDuration": 0.4,
                "color": "black",
                "fixedPosition": false,
                "borderColor": "rgba(83, 144, 177, 1)",
                "fillColor": "#ffffff",
                "fillAlpha": 1,
                "fontSize": 12,
                "borderThickness": 4,
                "shadowAlpha": 1,
                "shadowColor": "rgba(83, 144, 177, 1)",
                "borderAlpha": 0 ,
                "fadeOutDuration": 1,
            },

        });

</script>
     <script type="text/javascript">
 
         var chartData = <%=Session["Datos_Cierre"] %>;
         var chart = AmCharts.makeChart("Grafico2", {
             "type": "serial",
             "theme": "Orange",
             "color": "#2e2e2e",
             "fontSize": 12,
             "startEffect": "elastic",
             "fontFamily": "Arial",
             "columnWidth": 0.5,
             "plotAreaFillAlphas": 0.1,
             "plotAreaFillColors": "rgba(0, 0, 0, 0)",
            
             "dataProvider": chartData,
             "valueAxes": [{
                 "axisAlpha": 0.5,
                 "gridColor": "black",
                 "dashLength": 0,
                 "title": "Cantidad",
                
                
             }],
             "startDuration": 2,
             "graphs": [{
                 "balloonText": "[[category]]: <b>[[value]]</b>",
                 //"fillColorsField": "#000000",
                 "fillAlphas": 1,
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
                 "borderColor": "rgba(255, 149, 44, 1)",
                 "fillColor": "#ffffff",
                 "fillAlpha": 1,
                 "fontSize": 12,
                 "borderThickness": 4,
                 "shadowAlpha": 1,
                 "shadowColor": "rgba(255, 149, 44, 1)",
                 "borderAlpha": 0 ,
                 "fadeOutDuration": 1,
             },

         });

</script>
    <script type="text/javascript">
 
        var chartData = <%=Session["Datos_Razon"] %>;
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
        var chartData = <%=Session["Datos_Transacciones_Dia"] %>;
        var chart = AmCharts.makeChart("Grafico4", {
            "type": "serial",
            "theme": "none",
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
                "balloonText": "[[CANTIDAD]]",
                "bullet": "round",
                "bulletBorderAlpha": 1,
                "bulletColor": "#FFFFFF",
                "hideBulletsCount": 50,
                "title": "red line",
                "valueField": "CANTIDAD",
                "useLineColorForBulletBorder": true,
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

        chart.addListener("rendered", zoomChart);
        zoomChart();

        // this method is called when chart is first inited as we listen for "rendered" event
        function zoomChart() {
            // different zoom methods can be used - zoomToIndexes, zoomToDates, zoomToCategoryValues
            chart.zoomToIndexes(chartData.length - 40, chartData.length -1);
        }


        // generate some random data, quite different range
        //function generateChartData() {
        //    var chartData = [];
        //    var firstDate = new Date();
        //    firstDate.setDate(firstDate.getDate() - 5);

        //    for (var i = 0; i < 1000; i++) {
        //        // we create date objects here. In your data, you can have date strings
        //        // and then set format of your dates using chart.dataDateFormat property,
        //        // however when possible, use date objects, as this will speed up chart rendering.
        //        var newDate = new Date(firstDate);
        //        newDate.setDate(newDate.getDate() + i);

        //        var visits = Math.round(Math.random() * (40 + i / 5)) + 20 + i;

        //        chartData.push({
        //            date: newDate,
        //            visits: visits
        //        });
        //    }
        //    return chartData;
        //}
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
   <h2 class="Titulo_Reporte">REPORTEADOR CONVENIO ELECTRONICO</h2>
    <hr />
    
     <div id="Grafico1" class="Reporte_Cierre">
        
    </div>
    <div id="Grafico2" class="Reporte_Cierre">
        
    </div>
    <div id="Grafico3" class="Reporte_Cierre">
        
    </div>
    <div id="Grafico4" class="Reporte_Fechas">
        
    </div>
</asp:Content>

