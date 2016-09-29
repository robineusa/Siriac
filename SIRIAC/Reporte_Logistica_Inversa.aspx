<%@ Page Title="" Language="C#" MasterPageFile="~/Perfil_Administrador.master" AutoEventWireup="true" CodeFile="Reporte_Logistica_Inversa.aspx.cs" Inherits="Reportes_Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="jquery/jquery-1.11.1.js"></script>
    <script src="Js/jquery.datetimepicker.full.js"></script>
    <link href="Estilos/jquery.datetimepicker.css?1.0.0" rel="stylesheet" />
    <script src="Js/amcharts.js"></script>
    <script src="Js/serial.js"></script>
    <script src="Estilos/Rojo.js"></script>
    <script src="Estilos/Green.js"></script>
    <link href="Estilos/Style_Ingreso_Casos.css" rel="stylesheet" />
    <link href="Estilos/Reporteadores.css" rel="stylesheet" />
    <script src="Estilos/Azul.js"></script>
    <script src="Estilos/Amarillo.js"></script>
    <script src="Estilos/Orange.js"></script>

    <script type="text/javascript">
 
        var chartData = <%=Session["Datos_Contacto"] %>;
        var chart = AmCharts.makeChart("Grafico1", {
            "type": "serial",
            "theme": "Green",
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
                "fillAlphas": 0.5,
                "lineAlpha": 0.5,
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
		        "text": "Reporte de Contactos"
		    }],
            "balloon": {
                "animationDuration": 0.4,
                "color": "black",
                "fixedPosition": false,
                "borderColor": "#04b300",
                "fillColor": "#ffffff",
                "fillAlpha": 1,
                "fontSize": 12,
                "borderThickness": 4,
                "shadowAlpha": 1,
                "shadowColor": "#04b300",
                "borderAlpha": 0 ,
                "fadeOutDuration": 1,
            },

        });

</script>
    <script type="text/javascript">
 
        var chartData = <%=Session["Datos_Contacto_Fecha"] %>;
        var chart = AmCharts.makeChart("Grafico1", {
            "type": "serial",
            "theme": "Orange",
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
                "fillAlphas": 1,
                "lineAlpha": 0.5,
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
		        "text": "Tipo de Contacto por Fechas"
		    }],
            "balloon": {
                "animationDuration": 0.4,
                "color": "black",
                "fixedPosition": false,
                "borderColor": "rgba(255, 156, 0, 1)",
                "fillColor": "#ffffff",
                "fillAlpha": 1,
                "fontSize": 12,
                "borderThickness": 4,
                "shadowAlpha": 1,
                "shadowColor": "rgba(255, 156, 0, 1)",
                "borderAlpha": 0 ,
                "fadeOutDuration": 1,
            },

        });

</script>
    <script type="text/javascript">
 
        var chartData = <%=Session["Datos_Cierre"] %>;
        var chart = AmCharts.makeChart("Grafico2", {
            "type": "serial",
            "theme": "Rojo",
            "color": "#2e2e2e",
            "fontSize": 12,
            "startEffect": "elastic",
            "fontFamily": "Arial",
            "columnWidth": 0.5,
            "plotAreaFillAlphas": 0.1,
            "plotAreaFillColors": "rgba(0, 0, 0, 0)",
            
            "dataProvider": chartData,
            "valueAxes": [{
                "axisAlpha": 0,
                "gridColor": "red ",
                "dashLength": 0,
                "title": "Cantidad",
                "gridAlpha":1,
                "gridColor": "white",
                
            }],
            "startDuration": 2,
            "graphs": [{
                "balloonText": "[[category]]: <b>[[value]]</b>",
                //"fillColorsField": "#000000",
                "fillAlphas": 1,
                "lineAlpha": 0.5,
                "type": "column",
                "valueField": "CANTIDAD"
            }],
            
            "categoryField": "CIERRE",
            "categoryAxis": {
                "gridPosition": "start",
                "labelRotation": 0,
                "tickLength": 0,
                "title": "Tipo de Cierre",
                "fontSize": 8.5,
            },
             
            "titles": [
		    {
		        "size": 17,
		        "text": "Reporte de Cierres"
		    }],
            "balloon": {
                "animationDuration": 0.4,
                "color": "black",
                "fixedPosition": false,
                "borderColor": "rgba(252, 0, 0, 1)",
                "fillColor": "#ffffff",
                "fillAlpha": 1,
                "fontSize": 12,
                "borderThickness": 4,
                "shadowAlpha": 1,
                "shadowColor": "rgba(252, 0, 0, 1)",
                "borderAlpha": 0 ,
                "fadeOutDuration": 1,
            },

        });
    </script>

    <script type="text/javascript">

        var chartData = <%=Session["Datos_Cierre_Fecha"] %>;
       
        var chart = AmCharts.makeChart("Grafico2", {
            "type": "serial",
            "theme": "Azul",
            "color": "#2e2e2e",
            "fontSize": 12,
            "startEffect": "elastic",
            "fontFamily": "Arial",
            "columnWidth": 0.5,
            "plotAreaFillAlphas": 0.1,
            "plotAreaFillColors": "rgba(0, 0, 0, 0)",
            
            "dataProvider": chartData,
            "valueAxes": [{
                "axisAlpha": 0,
                "dashLength": 0,
                "title": "Cantidad",
                "gridAlpha":1,
                "gridColor": "white",
                
            }],
            "startDuration": 2,
            "graphs": [{
                "balloonText": "[[category]]: <b>[[value]]</b>",
                //"fillColorsField": "#000000",
                "fillAlphas": 0.7,
                "lineAlpha": 0.5,
                "type": "column",
                "valueField": "CANTIDAD"
            }],
            
            "categoryField": "CIERRE",
            "categoryAxis": {
                "gridPosition": "start",
                "labelRotation": 0,
                "tickLength": 0,
                "title": "Tipo de Cierre",
                "fontSize": 8.5,
                "maxLabelWidth": 10,
            },
             
            "titles": [
		    {
		        "size": 17,
		        "text": "Reporte de Cierres por Fechas  ",
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

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2 class="Titulo_Reporte">REPORTEADOR LOGÍSTICA INVERSA</h2>
    <hr />
    <div id="tab-container2">
        <div id="html-tab" class="tab-content active">
            <asp:Panel CssClass="panel_informativo" ID="Panel3" runat="server" GroupingText="Ventana de tiempo para la consulta">
                <table class="tabla">
                    <tr>
                        <td>
                            <p class="etiquetas">Fecha Inicial:</p>
                            <asp:TextBox ID="LI_Fecha_Inicial" runat="server" Text="2016-01-01 00:00" Style="display: none"></asp:TextBox>
                            <input class="caja_de_texto" type="text" value="" id="LIH_Fecha_Inicial" onchange="Traer_Fecha()" autocomplete="off" placeholder="Select date" />

                        </td>
                        <td class="auto-style21">
                            <p class="etiquetas">Fecha Final:</p>
                            <asp:TextBox ID="LI_Fecha_Final" runat="server" Text="2016-01-01 00:00" Style="display: none"></asp:TextBox>
                            <input class="caja_de_texto" type="text" value="" id="LIH_Fecha_Final" autocomplete="off" onchange="Traer_Fecha_Final()" placeholder="Select date" />

                        </td>
                    </tr>
                </table>

                
                <script>
                    $('#LIH_Fecha_Inicial').datetimepicker({
                        format: 'Y-m-d',
                        maxDate: '+0d',
                        timepicker: false
                    });

                    $('#LIH_Fecha_Final').datetimepicker({
                        format: 'Y-m-d',
                        onShow: function (ct) {
                            this.setOptions({
                                minDate: $('#LIH_Fecha_Inicial').val() ? $('#LIH_Fecha_Inicial').val() : false
                            })
                        },
                        maxDate: '+0d',
                        timepicker: false
                    });
                </script>
                <script>
                    function Traer_Fecha_Final() {
                        var fecha = document.getElementById('LIH_Fecha_Final').value;
                        document.getElementById("<%= Fecha_Final.ClientID %>").value = fecha;
                        
                    }
                </script>
                <script>
                    function Traer_Fecha() {
                        var fecha = document.getElementById('LIH_Fecha_Inicial').value;
                        document.getElementById("<%= Fecha_Inicial.ClientID %>").value = fecha;
                    }
                </script>
                <asp:TextBox ID="Fecha_Inicial" runat="server" Style="display: none"></asp:TextBox>
                <asp:TextBox ID="Fecha_Final" runat="server" Style="display: none"></asp:TextBox>

            </asp:Panel>
            <asp:Button CssClass="button" ID="Button1" runat="server" Text="Generar" OnClick="Reportes" />
        </div>
    </div>
    <div id="Grafico1" class="Reporte_Cierre">
    </div>
    <div id="Grafico2" class="Reporte_Cierre">
    </div>
</asp:Content>

