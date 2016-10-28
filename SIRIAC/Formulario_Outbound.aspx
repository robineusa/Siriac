<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Perfil_Asesor.master" CodeFile="Formulario_Outbound.aspx.cs" Inherits="Formulario_Outbound" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script src="jquery/jquery.datetimepicker.js?1.0.0"></script>
    <link href="Estilos/jquery.datetimepicker.css?1.0.0" rel="stylesheet" />
    <link href="Estilos/Style_Ingreso_Casos.css?1.0.0" rel="stylesheet" />
    <script src="javascript/Funciones.js?1.0.0"></script>
    <script src="Js/jquery.datetimepicker.js?1.0.0"></script>
    <link href="Estilos/Style_Perfil_Asesor.css?1.0.2" rel="stylesheet" />

    <script type="text/javascript">
        $(document).ready(function () { Cargar_Datos_CC(); });
        function otorgar_permisos() {

            var activeTabIndex = -1;
            var tabNames = ["html", "javascript", "css"];
            $(".tab-menu > li").click(function (e) {
                for (var i = 0; i < tabNames.length; i++) {
                    if (e.target.id == tabNames[i]) {
                        activeTabIndex = i;
                    } else {
                        $("#" + tabNames[i]).removeClass("active");
                        $("#" + tabNames[i] + "-tab").css("display", "none");
                    }
                }
                $("#" + tabNames[activeTabIndex] + "-tab").fadeIn();
                $("#" + tabNames[activeTabIndex]).addClass("active");
                Cargar_Datos_CC();
                return false;
            });
        }
    </script>
    <script type="text/javascript">
        function Ofrecimiento1SI() {
            document.getElementById('2').style.display = 'none';
            document.getElementById('21').style.display = 'none';
            document.getElementById('3').style.display = 'none';
            document.getElementById('31').style.display = 'none';
            document.getElementById('4').style.display = 'none';
            document.getElementById('41').style.display = 'none';
            document.getElementById('5').style.display = 'none';
            document.getElementById('51').style.display = 'none';
            document.getElementById('6').style.display = 'none';
            document.getElementById('61').style.display = 'none';
            document.getElementById('7').style.display = 'none';
            document.getElementById('71').style.display = 'none';
            document.getElementById('8').style.display = 'none';
            document.getElementById('81').style.display = 'none';
            document.getElementById('9').style.display = 'none';
            document.getElementById('91').style.display = 'none';
            document.getElementById('10').style.display = 'none';
            document.getElementById('101').style.display = 'none';
            <%--document.getElementById('<%=RadioButton2.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton3.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton4.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton5.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton6.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton7.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton8.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton9.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton10.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton11.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton12.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton13.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton14.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton15.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton16.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton17.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton18.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton19.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton20.ClientID%>').checked = false;--%>

        }
    </script>
    <script type="text/javascript">
        function Ofrecimiento2SI() {
            document.getElementById('3').style.display = 'none';
            document.getElementById('31').style.display = 'none';
            document.getElementById('4').style.display = 'none';
            document.getElementById('41').style.display = 'none';
            document.getElementById('5').style.display = 'none';
            document.getElementById('51').style.display = 'none';
            document.getElementById('6').style.display = 'none';
            document.getElementById('61').style.display = 'none';
            document.getElementById('7').style.display = 'none';
            document.getElementById('71').style.display = 'none';
            document.getElementById('8').style.display = 'none';
            document.getElementById('81').style.display = 'none';
            document.getElementById('9').style.display = 'none';
            document.getElementById('91').style.display = 'none';
            document.getElementById('10').style.display = 'none';
            document.getElementById('101').style.display = 'none';
            <%--document.getElementById('<%=RadioButton4.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton5.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton6.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton7.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton8.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton9.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton10.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton11.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton12.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton13.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton14.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton15.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton16.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton17.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton18.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton19.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton20.ClientID%>').checked = false;--%>
        }
    </script>
    <script type="text/javascript">
        function Ofrecimiento3SI() {
            document.getElementById('4').style.display = 'none';
            document.getElementById('41').style.display = 'none';
            document.getElementById('5').style.display = 'none';
            document.getElementById('51').style.display = 'none';
            document.getElementById('6').style.display = 'none';
            document.getElementById('61').style.display = 'none';
            document.getElementById('7').style.display = 'none';
            document.getElementById('71').style.display = 'none';
            document.getElementById('8').style.display = 'none';
            document.getElementById('81').style.display = 'none';
            document.getElementById('9').style.display = 'none';
            document.getElementById('91').style.display = 'none';
            document.getElementById('10').style.display = 'none';
            document.getElementById('101').style.display = 'none';

           <%-- document.getElementById('<%=RadioButton6.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton7.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton8.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton9.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton10.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton11.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton12.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton13.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton14.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton15.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton16.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton17.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton18.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton19.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton20.ClientID%>').checked = false;--%>
        }
    </script>
    <script type="text/javascript">
        function Ofrecimiento4SI() {
            document.getElementById('5').style.display = 'none';
            document.getElementById('51').style.display = 'none';
            document.getElementById('6').style.display = 'none';
            document.getElementById('61').style.display = 'none';
            document.getElementById('7').style.display = 'none';
            document.getElementById('71').style.display = 'none';
            document.getElementById('8').style.display = 'none';
            document.getElementById('81').style.display = 'none';
            document.getElementById('9').style.display = 'none';
            document.getElementById('91').style.display = 'none';
            document.getElementById('10').style.display = 'none';
            document.getElementById('101').style.display = 'none';

            <%--document.getElementById('<%=RadioButton8.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton9.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton10.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton11.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton12.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton13.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton14.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton15.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton16.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton17.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton18.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton19.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton20.ClientID%>').checked = false;--%>

        }
    </script>
    <script type="text/javascript">
        function Ofrecimiento5SI() {
            document.getElementById('6').style.display = 'none';
            document.getElementById('61').style.display = 'none';
            document.getElementById('7').style.display = 'none';
            document.getElementById('71').style.display = 'none';
            document.getElementById('8').style.display = 'none';
            document.getElementById('81').style.display = 'none';
            document.getElementById('9').style.display = 'none';
            document.getElementById('91').style.display = 'none';
            document.getElementById('10').style.display = 'none';
            document.getElementById('101').style.display = 'none';

            <%--document.getElementById('<%=RadioButton10.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton11.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton12.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton13.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton14.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton15.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton16.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton17.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton18.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton19.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton20.ClientID%>').checked = false;--%>
        }
    </script>
    <script type="text/javascript">
        function Ofrecimiento6SI() {
            document.getElementById('7').style.display = 'none';
            document.getElementById('71').style.display = 'none';
            document.getElementById('8').style.display = 'none';
            document.getElementById('81').style.display = 'none';
            document.getElementById('9').style.display = 'none';
            document.getElementById('91').style.display = 'none';
            document.getElementById('10').style.display = 'none';
            document.getElementById('101').style.display = 'none';

            <%--document.getElementById('<%=RadioButton12.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton13.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton14.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton15.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton16.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton17.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton18.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton19.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton20.ClientID%>').checked = false;--%>
        }
    </script>
    <script type="text/javascript">
        function Ofrecimiento7SI() {
            document.getElementById('8').style.display = 'none';
            document.getElementById('81').style.display = 'none';
            document.getElementById('9').style.display = 'none';
            document.getElementById('91').style.display = 'none';
            document.getElementById('10').style.display = 'none';
            document.getElementById('101').style.display = 'none';

            <%--document.getElementById('<%=RadioButton14.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton15.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton16.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton17.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton18.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton19.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton20.ClientID%>').checked = false;--%>
        }
    </script>
    <script type="text/javascript">
        function Ofrecimiento8SI() {

            document.getElementById('9').style.display = 'none';
            document.getElementById('91').style.display = 'none';
            document.getElementById('10').style.display = 'none';
            document.getElementById('101').style.display = 'none';

            <%--document.getElementById('<%=RadioButton16.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton17.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton18.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton19.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton20.ClientID%>').checked = false;--%>
        }
    </script>
    <script type="text/javascript">
        function Ofrecimiento9SI() {

            document.getElementById('10').style.display = 'none';
            document.getElementById('101').style.display = 'none';

           <%-- document.getElementById('<%=RadioButton18.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton19.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton20.ClientID%>').checked = false;--%>
        }
    </script>
    <script type="text/javascript">
        function Ofrecimiento10SI() {

            <%--document.getElementById('<%=RadioButton20.ClientID%>').checked = false;--%>
        }
    </script>
    <script type="text/javascript">
        function Ofrecimiento1NO() {
            document.getElementById('2').style.display = 'block';
            document.getElementById('21').style.display = 'block';
            <%--var RadioButton3 = '<%=RadioButton3.ClientID%>';--%>
            document.getElementById(RadioButton3).setSelected(false);
        }
    </script>
    <script type="text/javascript">
        function Ofrecimiento2NO() {
            document.getElementById('3').style.display = 'block';
            document.getElementById('31').style.display = 'block';
        }
    </script>
    <script type="text/javascript">
        function Ofrecimiento3NO() {
            document.getElementById('4').style.display = 'block';
            document.getElementById('41').style.display = 'block';
        }
    </script>
    <script type="text/javascript">
        function Ofrecimiento4NO() {
            document.getElementById('5').style.display = 'block';
            document.getElementById('51').style.display = 'block';
        }
    </script>
    <script type="text/javascript">
        function Ofrecimiento5NO() {
            document.getElementById('6').style.display = 'block';
            document.getElementById('61').style.display = 'block';
        }
    </script>
    <script type="text/javascript">
        function Ofrecimiento6NO() {
            document.getElementById('7').style.display = 'block';
            document.getElementById('71').style.display = 'block';
        }
    </script>
    <script type="text/javascript">
        function Ofrecimiento7NO() {
            document.getElementById('8').style.display = 'block';
            document.getElementById('81').style.display = 'block';
        }
    </script>
    <script type="text/javascript">
        function Ofrecimiento8NO() {
            document.getElementById('9').style.display = 'block';
            document.getElementById('91').style.display = 'block';
        }
    </script>
    <script type="text/javascript">
        function Ofrecimiento9NO() {
            document.getElementById('10').style.display = 'block';
            document.getElementById('101').style.display = 'block';
        }
    </script>
    <script type="text/javascript">
        function Ofrecimiento10NO() {

        }
    </script>
    <script type="text/javascript">
        function Ofrecimiento_CC_1_SI() {
            document.getElementById('CC_Ofrecimiento_2').style.display = 'none';
            document.getElementById('CC_Ofrecimiento_3').style.display = 'none';
           // document.getElementById('<%=CC_Paleta_Servicios.ClientID%>').style.display = 'none';

            var RadioButton2 = '<%=RadioButton22.ClientID%>';
            document.getElementById(RadioButton2).checked = false;
            var RadioButton3 = '<%=RadioButton23.ClientID%>';
            document.getElementById(RadioButton3).checked = false;
            var RadioButton4 = '<%=RadioButton24.ClientID%>';
            document.getElementById(RadioButton4).checked = false;
            var RadioButton5 = '<%=RadioButton25.ClientID%>';
            document.getElementById(RadioButton5).checked = false;
            var RadioButton6 = '<%=RadioButton26.ClientID%>';
            document.getElementById(RadioButton6).checked = false;
                        }
    </script>
    <script type="text/javascript">
        function Ofrecimiento_CC_1_NO() {
            document.getElementById('CC_Ofrecimiento_2').style.display = 'block';
            document.getElementById('CC_Ofrecimiento_3').style.display = 'none';
            //document.getElementById('<%=CC_Paleta_Servicios.ClientID%>').style.display = 'none';

            var RadioButton3 = '<%=RadioButton23.ClientID%>';
            document.getElementById(RadioButton3).checked = false;
            var RadioButton4 = '<%=RadioButton24.ClientID%>';
            document.getElementById(RadioButton4).checked = false;
            var RadioButton5 = '<%=RadioButton25.ClientID%>';
            document.getElementById(RadioButton5).checked = false;
            var RadioButton6 = '<%=RadioButton26.ClientID%>';
            document.getElementById(RadioButton6).checked = false;
                        }
    </script>
    <script type="text/javascript">
        function Ofrecimiento_CC_2_SI() {
            document.getElementById('CC_Ofrecimiento_3').style.display = 'none';
            //document.getElementById('<%=CC_Paleta_Servicios.ClientID%>').style.display = 'none';

            var RadioButton5 = '<%=RadioButton25.ClientID%>';
            document.getElementById(RadioButton5).checked = false;
            var RadioButton6 = '<%=RadioButton26.ClientID%>';
            document.getElementById(RadioButton6).checked = false;
                        }
    </script>
    <script type="text/javascript">
        function Ofrecimiento_CC_2_NO() {
            document.getElementById('CC_Ofrecimiento_3').style.display = 'block';
            //document.getElementById('<%=CC_Paleta_Servicios.ClientID%>').style.display = 'none';

            var RadioButton5 = '<%=RadioButton25.ClientID%>';
            document.getElementById(RadioButton5).checked = false;
            var RadioButton6 = '<%=RadioButton26.ClientID%>';
            document.getElementById(RadioButton6).checked = false;
                        }
    </script>
    <script type="text/javascript">
        function Ofrecimiento_CC_3_SI() {

            //document.getElementById('<%=CC_Paleta_Servicios.ClientID%>').style.display = 'none';
        }
    </script>

    <script type="text/javascript">
        function Ofrecimiento_CC_3_NO() {
            //document.getElementById('<%=CC_Paleta_Servicios.ClientID%>').style.display = 'block';
        }

        function Cargar_Datos_CC() {
            //document.getElementById('Iframe_SMO').style.display = 'block';
            document.getElementById('CC_Ofrecimiento_2').style.display = 'none';
            document.getElementById('CC_Ofrecimiento_3').style.display = 'none';
            //document.getElementById('<%=CC_Paleta_Servicios.ClientID%>').style.display = 'none';
            document.getElementById('<%=RadioButton21.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton22.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton23.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton24.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton25.ClientID%>').checked = false;
            document.getElementById('<%=RadioButton26.ClientID%>').checked = false;
        }
    </script>
    <script type="text/javascript">
        function numbersonly(e) {
            var unicode = e.charCode ? e.charCode : e.keyCode
            if (unicode != 8 && unicode != 44) {
                if (unicode < 48 || unicode > 57) //if not a number
                { return false } //disable key press    
            }
        }
    </script>
    <script type="text/javascript">
        function mensaje1() {

            alert('Debe seleccionar un atributo en la solución');
        }
    </script>
    <script type="text/javascript">
        function mensaje2() {

            alert('Registro Almacenado');
        }
    </script>
    <script type="text/javascript">
        function mensaje3() {

            alert(' El número de cuenta ingresado no existe en la base de datos');
        }
    </script>
    <script type="text/javascript">
        function mensaje4() {

            alert('Registro Almacenado');
        }
    </script>
    <script type="text/javascript">
        function mensaje5() {

            alert('Registro Actulizado');
        }
    </script>
    <script type="text/javascript">
        function mensaje6() {

            alert('No se pudo realizar el proceso, intenta nuevamente');
        }
    </script>
    <script type="text/javascript">
        function mensaje7() {

            alert('Registro no almacenado');
        }
    </script>
    <script type="text/javascript">
        function mensaje8() {

            alert('Ingrese un numero de Cuenta');
        }
    </script>
    <script type="text/javascript">
        function mensaje9() {

            alert('Debe Seleccionar el árbol de Tipificación');
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Panel CssClass="panel" ID="Panel1" runat="server">

        <div id="tab-container">
            <ul class="tab-menu">
                <%--<li id="html" class="active" onclick="otorgar_permisos()">MIDAS - ACTIVACIÓN</li>--%>
                <li id="css" class="active" onclick="otorgar_permisos()">CIERRE DE CICLO</li>
            </ul>
            <div class="clear"></div>
            <div class="tab-top-border"></div>
            <%--<div id="html-tab" class="tab-content active">
                <h3 class="Titulos">FORMULARIO MIDAS - ACTIVACIÓN</h3>

                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <asp:Panel CssClass="panel_informativo" ID="Panel3" runat="server" GroupingText="Datos del Cliente">
                            <table class="tabla">
                                <tr>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label3" runat="server" Text="Número de Cuenta:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Cuenta_Cliente" runat="server" OnTextChanged="Cuenta_Cliente_TextChanged" AutoPostBack="true" Placeholder="Ingrese la cuenta" OnUnload="Cuenta_Cliente_Unload"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label4" runat="server" Text="Nombre del Cliente:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Nombre_Cliente" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label5" runat="server" Text="Apellido 1:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Apellido_Cliente_1" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label6" runat="server" Text="Apellido 2:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Apellido_Cliente_2" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label7" runat="server" Text="Ciudad:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Ciudad" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label8" runat="server" Text="Nodo:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Nodo" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label9" runat="server" Text="Mix Básico:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Mix_Basico" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                            <table class="tabla">
                                <tr>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label10" runat="server" Text="Tipo de Servicio:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Tipo_de_Servicio" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label11" runat="server" Text="Ciclo de Facturacion:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Ciclo_de_Facturacion" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label12" runat="server" Text="Renta:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Renta" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label13" runat="server" Text="Tipo de Television:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Tipo_de_Television" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label14" runat="server" Text="Velocidad del Internet:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Velocidad_Del_Internet" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label15" runat="server" Text="Estado de la Cuenta:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Estado_Cuenta" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label16" runat="server" Text="Motivo de Desconexión:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Motivo_Desconexion" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                            <table class="tabla">
                                <tr>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label17" runat="server" Text="Contrato:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Contrato" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label18" runat="server" Text="Teléfono 1:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Telefono_1" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label19" runat="server" Text="Teléfono 2:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Telefono_2" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label20" runat="server" Text="Teléfono 3:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Telefono_3" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label21" runat="server" Text="Estrato:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Estrato" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label22" runat="server" Text="Tipo de Hipótesis:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Tipo_Hipotesis" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label23" runat="server" Text="Teléfono Móvil 1:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Telefono_Movil_1" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                            <table class="tabla">
                                <tr>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label29" runat="server" Text="Teléfono Móvil 2:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Telefono_Movil_2" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label30" runat="server" Text="Teléfono Móvil 3:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Telefono_Movil_3" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label31" runat="server" Text="Campaña Actual:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Campana_Actual" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label32" runat="server" Text="Estado Campaña:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Estado_Campana" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                            <table class="tabla">
                                <tr>
                                    <td colspan="5">
                                        <div class="Titulo_Usuarios5">
                                            <p class="etiquetas5">Histórico:</p>
                                        </div>
                                        <asp:TextBox CssClass="ofrecimientos" ID="Historico" runat="server" TextMode="MultiLine" Enabled="false"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>

                        <asp:Panel CssClass="panel_informativo" ID="Panel2" runat="server" GroupingText="Atributos por Servicio">
                            <table class="tabla">
                                <tr>
                                    <td colspan="5">
                                        <p class="texto_informativo">Seleccione el Servicio:</p>
                                        <asp:DropDownList CssClass="dropdown1" ID="Servicios" runat="server" AutoPostBack="True" OnSelectedIndexChanged="Servicios_SelectedIndexChanged"></asp:DropDownList>

                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="5">
                                        <div class="Titulo_Usuarios5">
                                            <p class="etiquetas5">Atributos:</p>
                                        </div>
                                        <asp:TextBox CssClass="ofrecimientos" ID="Atributos_Servicio" runat="server" TextMode="MultiLine" Enabled="false"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <asp:Panel CssClass="panel_informativo" ID="Panel4" runat="server" GroupingText="Árbol de Tipificación">
                            <table class="tabla">
                                <tr>
                                    <td>
                                        <p class="texto_informativo">Tipo de Contacto:</p>
                                        <asp:DropDownList CssClass="dropdown2" ID="Tipo_de_Contacto" runat="server" AutoPostBack="True" OnSelectedIndexChanged="Tipo_de_Contacto_SelectedIndexChanged"></asp:DropDownList>

                                    </td>
                                    <td>
                                        <p class="texto_informativo">Gestión:</p>
                                        <asp:DropDownList CssClass="dropdown2" ID="Gestion_Cliente" runat="server" AutoPostBack="True" OnSelectedIndexChanged="Gestion_Cliente_SelectedIndexChanged"></asp:DropDownList>

                                    </td>
                                    <td>
                                        <p class="texto_informativo">Cierre:</p>
                                        <asp:DropDownList CssClass="dropdown2" ID="Cierre_Cliente" runat="server" AutoPostBack="True" OnSelectedIndexChanged="Cierre_Cliente_SelectedIndexChanged"></asp:DropDownList>

                                    </td>
                                    <td colspan="3">
                                        <p class="texto_informativo">Razón:</p>
                                        <asp:DropDownList CssClass="dropdown3" ID="Razon_Cliente" runat="server"></asp:DropDownList>

                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <asp:Panel CssClass="panel_informativo" ID="Panel7" runat="server" GroupingText="Seleccione la causa">
                            <table class="tabla">
                                <tr>
                                    <td colspan="2">
                                        <div class="Titulo_Usuarios5">
                                            <p class="etiquetas5">Causa:</p>
                                        </div>
                                        <asp:DropDownList CssClass="ddl2" ID="Causa_Hipotesis" runat="server"></asp:DropDownList>

                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <asp:Panel CssClass="panel_informativo" ID="Panel6" runat="server" GroupingText="Atributos de Solución">
                            <table class="tabla">
                                <tr>
                                    <td colspan="2">
                                        <div class="Titulo_Usuarios5">
                                            <p class="etiquetas5">Solución:</p>
                                        </div>
                                        <div class="soluciones">
                                            <asp:CheckBox CssClass="etiquetas" ID="CheckBox1" runat="server" Text=" Ajuste" />
                                        </div>
                                        <div class="soluciones">
                                            <asp:CheckBox CssClass="etiquetas" ID="CheckBox2" runat="server" Text=" Atributos de Marca" />
                                        </div>
                                        <div class="soluciones">
                                            <asp:CheckBox CssClass="etiquetas" ID="CheckBox3" runat="server" Text=" Atributos de Servicio" />
                                        </div>
                                        <div class="soluciones">
                                            <asp:CheckBox CssClass="etiquetas" ID="CheckBox4" runat="server" Text=" Soporte en Linea" />
                                        </div>
                                        <div class="soluciones">
                                            <asp:CheckBox CssClass="etiquetas" ID="CheckBox5" runat="server" Text=" Ofrecimientos" OnCheckedChanged="CheckBox5_CheckedChanged" AutoPostBack="true" />
                                        </div>
                                        <div class="soluciones">
                                            <asp:CheckBox CssClass="etiquetas" ID="CheckBox6" runat="server" Text=" Visita Interventor" />
                                        </div>
                                        <div class="soluciones">
                                            <asp:CheckBox CssClass="etiquetas" ID="CheckBox7" runat="server" Text=" Visita Técnica" />
                                        </div>

                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>

                        <asp:Panel ID="Panel5" runat="server" Visible="false">

                            <asp:Panel CssClass="panel_informativo" ID="Panel8" runat="server" GroupingText="Ofrecimientos">
                                <table class="tabla">
                                    <tr>
                                        <td colspan="6">
                                            <div class="Titulo_Ofrecimientos" id="1">
                                                <p class="etiquetas_Ofrecimiento">Primer Ofrecimiento:</p>
                                            </div>
                                            <asp:TextBox CssClass="ofrecimientos" ID="Ofrecimiento_1" runat="server" TextMode="MultiLine"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="6">
                                            <p class="etiquetas_Ofrecimiento2">
                                                El cliente acepto este ofrecimiento?
                                            </p>
                                            &nbsp;<asp:RadioButton ID="RadioButton1" runat="server" GroupName="1" Text="SI" Font-Names="Century Gothic" Font-Size="Small" />
                                            &nbsp; &nbsp; 
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="1" Text="NO" Font-Names="Century Gothic" Font-Size="Small" />
                                        </td>

                                    </tr>
                                    <tr>
                                        <td colspan="6">
                                            <div id="2" style="display: none">
                                                <div class="Titulo_Ofrecimientos">
                                                    <p class="etiquetas_Ofrecimiento">Segundo Ofrecimientos:</p>
                                                </div>
                                                <asp:TextBox CssClass="ofrecimientos" ID="Ofrecimiento_2" runat="server" TextMode="MultiLine"></asp:TextBox>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="6">
                                            <div id="21" style="display: none">
                                                <asp:Label CssClass="etiquetas_Ofrecimiento2" ID="Label1" runat="server" Text="El cliente acepto este ofrecimiento?"></asp:Label><br />
                                                &nbsp;<asp:RadioButton ID="RadioButton3" runat="server" GroupName="2" Text="SI" Font-Names="Century Gothic" Font-Size="Small" />
                                                &nbsp; &nbsp; 
        <asp:RadioButton ID="RadioButton4" runat="server" GroupName="2" Text="NO" Font-Names="Century Gothic" Font-Size="Small" />
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="6">
                                            <div id="3" style="display: none">
                                                <div class="Titulo_Ofrecimientos">
                                                    <p class="etiquetas_Ofrecimiento">Tercer Ofrecimiento:</p>
                                                </div>
                                                <asp:TextBox CssClass="ofrecimientos" ID="Ofrecimiento_3" runat="server" TextMode="MultiLine"></asp:TextBox>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="6">
                                            <div id="31" style="display: none">
                                                <asp:Label CssClass="etiquetas_Ofrecimiento2" ID="Label2" runat="server" Text="El cliente acepto este ofrecimiento?"></asp:Label><br />
                                                &nbsp;<asp:RadioButton ID="RadioButton5" runat="server" GroupName="3" Text="SI" Font-Names="Century Gothic" Font-Size="Small" />
                                                &nbsp; &nbsp; 
        <asp:RadioButton ID="RadioButton6" runat="server" GroupName="3" Text="NO" Font-Names="Century Gothic" Font-Size="Small" />
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="6">
                                            <div id="4" style="display: none">
                                                <div class="Titulo_Ofrecimientos">
                                                    <p class="etiquetas_Ofrecimiento">Cuarto Ofrecimiento:</p>
                                                </div>
                                                <asp:TextBox CssClass="ofrecimientos" ID="Ofrecimiento_4" runat="server" TextMode="MultiLine"></asp:TextBox>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="6">
                                            <div id="41" style="display: none">
                                                <asp:Label CssClass="etiquetas_Ofrecimiento2" ID="Label24" runat="server" Text="El cliente acepto este ofrecimiento?"></asp:Label><br />
                                                &nbsp;<asp:RadioButton ID="RadioButton7" runat="server" GroupName="4" Text="SI" Font-Names="Century Gothic" Font-Size="Small" />
                                                &nbsp; &nbsp; 
        <asp:RadioButton ID="RadioButton8" runat="server" GroupName="4" Text="NO" Font-Names="Century Gothic" Font-Size="Small" />
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="6">
                                            <div id="5" style="display: none">
                                                <div class="Titulo_Ofrecimientos">
                                                    <p class="etiquetas_Ofrecimiento">Quinto Ofrecimiento:</p>
                                                </div>
                                                <asp:TextBox CssClass="ofrecimientos" ID="Ofrecimiento_5" runat="server" TextMode="MultiLine"></asp:TextBox>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="6">
                                            <div id="51" style="display: none">
                                                <asp:Label CssClass="etiquetas_Ofrecimiento2" ID="Label25" runat="server" Text="El cliente acepto este ofrecimiento?"></asp:Label><br />
                                                &nbsp;<asp:RadioButton ID="RadioButton9" runat="server" GroupName="5" Text="SI" Font-Names="Century Gothic" Font-Size="Small" />
                                                &nbsp; &nbsp; 
        <asp:RadioButton ID="RadioButton10" runat="server" GroupName="5" Text="NO" Font-Names="Century Gothic" Font-Size="Small" />
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="6">
                                            <div id="6" style="display: none">
                                                <div class="Titulo_Ofrecimientos">
                                                    <p class="etiquetas_Ofrecimiento">Sexto Ofrecimiento:</p>
                                                </div>
                                                <asp:TextBox CssClass="ofrecimientos" ID="Ofrecimiento_6" runat="server" TextMode="MultiLine"></asp:TextBox>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="6">
                                            <div id="61" style="display: none">
                                                <asp:Label CssClass="etiquetas_Ofrecimiento2" ID="Label26" runat="server" Text="El cliente acepto este ofrecimiento?"></asp:Label><br />
                                                &nbsp;<asp:RadioButton ID="RadioButton11" runat="server" GroupName="6" Text="SI" Font-Names="Century Gothic" Font-Size="Small" />
                                                &nbsp; &nbsp; 
        <asp:RadioButton ID="RadioButton12" runat="server" GroupName="6" Text="NO" Font-Names="Century Gothic" Font-Size="Small" />
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="6">
                                            <div id="7" style="display: none">
                                                <div class="Titulo_Ofrecimientos">
                                                    <p class="etiquetas_Ofrecimiento">Septimo Ofrecimiento:</p>
                                                </div>
                                                <asp:TextBox CssClass="ofrecimientos" ID="Ofrecimiento_7" runat="server" TextMode="MultiLine"></asp:TextBox>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="6">
                                            <div id="71" style="display: none">
                                                <asp:Label CssClass="etiquetas_Ofrecimiento2" ID="Label28" runat="server" Text="El cliente acepto este ofrecimiento?"></asp:Label><br />
                                                &nbsp;<asp:RadioButton ID="RadioButton13" runat="server" GroupName="7" Text="SI" Font-Names="Century Gothic" Font-Size="Small" />
                                                &nbsp; &nbsp; 
        <asp:RadioButton ID="RadioButton14" runat="server" GroupName="7" Text="NO" Font-Names="Century Gothic" Font-Size="Small" />
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="6">
                                            <div id="8" style="display: none">
                                                <div class="Titulo_Ofrecimientos">
                                                    <p class="etiquetas_Ofrecimiento">Octavo Ofrecimiento:</p>
                                                </div>
                                                <asp:TextBox CssClass="ofrecimientos" ID="Ofrecimiento_8" runat="server" TextMode="MultiLine"></asp:TextBox>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="6">
                                            <div id="81" style="display: none">
                                                <asp:Label CssClass="etiquetas_Ofrecimiento2" ID="Label33" runat="server" Text="El cliente acepto este ofrecimiento?"></asp:Label><br />
                                                &nbsp;<asp:RadioButton ID="RadioButton15" runat="server" GroupName="8" Text="SI" Font-Names="Century Gothic" Font-Size="Small" />
                                                &nbsp; &nbsp; 
        <asp:RadioButton ID="RadioButton16" runat="server" GroupName="8" Text="NO" Font-Names="Century Gothic" Font-Size="Small" />
                                            </div>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td colspan="6">
                                            <div id="9" style="display: none">
                                                <div class="Titulo_Ofrecimientos">
                                                    <p class="etiquetas_Ofrecimiento">Noveno Ofrecimiento:</p>
                                                </div>
                                                <asp:TextBox CssClass="ofrecimientos" ID="Ofrecimiento_9" runat="server" TextMode="MultiLine"></asp:TextBox>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="6">
                                            <div id="91" style="display: none">
                                                <asp:Label CssClass="etiquetas_Ofrecimiento2" ID="Label34" runat="server" Text="El cliente acepto este ofrecimiento?"></asp:Label><br />
                                                &nbsp;<asp:RadioButton ID="RadioButton17" runat="server" GroupName="9" Text="SI" Font-Names="Century Gothic" Font-Size="Small" />
                                                &nbsp; &nbsp; 
        <asp:RadioButton ID="RadioButton18" runat="server" GroupName="9" Text="NO" Font-Names="Century Gothic" Font-Size="Small" />
                                            </div>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td colspan="6">
                                            <div id="10" style="display: none">
                                                <div class="Titulo_Ofrecimientos">
                                                    <p class="etiquetas_Ofrecimiento">Decimo Ofrecimiento:</p>
                                                </div>
                                                <asp:TextBox CssClass="ofrecimientos" ID="Ofrecimiento_10" runat="server" TextMode="MultiLine"></asp:TextBox>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="6">
                                            <div id="101" style="display: none">
                                                <asp:Label CssClass="etiquetas_Ofrecimiento2" ID="Label35" runat="server" Text="El cliente acepto este ofrecimiento?"></asp:Label><br />
                                                &nbsp;<asp:RadioButton ID="RadioButton19" runat="server" GroupName="10" Text="SI" Font-Names="Century Gothic" Font-Size="Small" />
                                                &nbsp; &nbsp; 
        <asp:RadioButton ID="RadioButton20" runat="server" GroupName="10" Text="NO" Font-Names="Century Gothic" Font-Size="Small" />
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </asp:Panel>

                        <asp:Panel CssClass="panel_informativo" ID="Panel9" runat="server" GroupingText="Gestión Agente">
                            <table class="tabla">
                                <tr>
                                    <td colspan="3">
                                        <div class="Encuesta">
                                            <p class="etiquetas_encuesta">De1 a 10 ¿Cuanto recomienda a claro a un familiar o un amigo?:</p>
                                        </div>
                                        <asp:DropDownList CssClass="dropdown3" ID="Nps" runat="server">
                                            <asp:ListItem>0</asp:ListItem>
                                            <asp:ListItem>1</asp:ListItem>
                                            <asp:ListItem>2</asp:ListItem>
                                            <asp:ListItem>3</asp:ListItem>
                                            <asp:ListItem>4</asp:ListItem>
                                            <asp:ListItem>5</asp:ListItem>
                                            <asp:ListItem>6</asp:ListItem>
                                            <asp:ListItem>7</asp:ListItem>
                                            <asp:ListItem>8</asp:ListItem>
                                            <asp:ListItem>9</asp:ListItem>
                                            <asp:ListItem>10</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td>
                                        <div class="Titulo_Usuarios5">
                                            <p class="etiquetas5">¿Cliente Satisfecho?:</p>
                                        </div>
                                        <asp:DropDownList CssClass="dropdown1" ID="Satisfaccion" runat="server">
                                            <asp:ListItem>SI</asp:ListItem>
                                            <asp:ListItem>NO</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>

                                    <td colspan="2">
                                        <div class="Titulo_Usuarios5">
                                            <p class="etiquetas5">Estado Caso:</p>
                                        </div>
                                        <asp:DropDownList CssClass="dropdown1" ID="Estado_Caso" runat="server" OnSelectedIndexChanged="Estado_Caso_SelectedIndexChanged"></asp:DropDownList>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>

                    </ContentTemplate>
                </asp:UpdatePanel>


                <asp:Panel CssClass="panel_informativo" ID="Panel10" runat="server" GroupingText="Información del Seguimiento">
                    <table>
                        <tr>
                            <td>
                                <asp:Label CssClass="etiquetas" ID="Label36" runat="server" Text="Motivo del Seguimiento"></asp:Label>
                                <br />
                                <asp:DropDownList CssClass="dropdown2" ID="Motivo_Seguimiento" runat="server">
                                    <asp:ListItem>AJUSTE</asp:ListItem>
                                    <asp:ListItem>APLICACION CAMPANA</asp:ListItem>
                                    <asp:ListItem>VISITA INTERVENTOR</asp:ListItem>
                                    <asp:ListItem>VISITA TECNICA</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label CssClass="etiquetas" ID="Label37" runat="server" Text="Fecha del Seguimiento">
                                    <asp:TextBox ID="datetimepicker1" runat="server" Text="2016-01-01 00:00" Style="display: none"></asp:TextBox></asp:Label>
                                <br />
                                <input class="caja_de_texto" type="text" value="" id="datetimepicker" onchange="return Traer_Fecha()" placeholder="Seleccione fecha" />

                            </td>
                        </tr>
                    </table>



                </asp:Panel>

                <asp:Button CssClass="button" ID="Guardar" runat="server" Text="Guardar" OnClick="Guardar_Click" />
                <asp:Label ID="Label27" runat="server" Text="Label" Style="display: none"></asp:Label>
            </div>--%>
            <div id="css-tab" class="tab-content active">
                <h3 class="Titulos">FORMULARIO CIERRE DE CICLO</h3>

                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <asp:Panel CssClass="panel_informativo" ID="Panel11" runat="server" GroupingText="Datos del Cliente">
                            <table class="tabla">
                                <tr>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label54" runat="server" Text="Cuenta del Cliente:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Cuenta_Cliente" runat="server" OnTextChanged="CC_Cuenta_Cliente_TextChanged" AutoPostBack="true" onkeypress="return justNumbers(event);" Placeholder="Ingrese la Cuenta"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label39" runat="server" Text="Nombre Cliente:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Nombre_Cliente" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label40" runat="server" Text="Apellido Cliente:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Apellido_Cliente" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label41" runat="server" Text="Dir. Instalación:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Direccion_de_Instalacion" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label42" runat="server" Text="Dir. Correspondencia:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Direccion_de_Correspondencia" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label43" runat="server" Text="Teléfono 1:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Telefono_1" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label44" runat="server" Text="Teléfono 2:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Telefono_2" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label45" runat="server" Text="Teléfono 3:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Telefono_3" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label46" runat="server" Text=" Móvil 1:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Movil_1" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label47" runat="server" Text="Móvil 2:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Movil_2" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label48" runat="server" Text="Nombre Comunidad:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Nombre_Comunidad" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label49" runat="server" Text="Correo Actual:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Correo_Electronico" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label50" runat="server" Text="Estrato:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Estrato" runat="server" Enabled="false"></asp:TextBox>
                                    </td>

                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label51" runat="server" Text="Tipo de Cliente:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Tipo_Cliente" runat="server" Enabled="false"></asp:TextBox>
                                    </td>

                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label52" runat="server" Text="Paquete Actual:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Paquete_Actual" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label53" runat="server" Text="Móvil Postpago:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Movil_Portpago" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                            <table class="tabla">
                                <tr>
                                    <td colspan="10">
                                        <div class="Titulo_Usuarios5" style="width: 200px;">
                                            <p class="etiquetas5" style="width: 200px;">Ultima Interacción del cliente:</p>
                                        </div>
                                    </td>
                                </tr>
                            </table>
                            <table class="tabla">
                                <tr>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label79" runat="server" Text="Fecha Marcacion:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Fecha_Marcacion" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label80" runat="server" Text="Marcacion:" ></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Marcacion" runat="server" Enabled="false" style="width: 350px;"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                            <table class="tabla">
                                <tr>
                                    <td colspan="2">
                                        <asp:Label CssClass="texto_informativo" ID="Label81" runat="server" Text="Notas Marcación:"></asp:Label><br />
                                        <asp:TextBox CssClass="ofrecimientos" ID="CC_Notas_Marcacion" runat="server" Enabled="false"  TextMode="MultiLine"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                            <table class="tabla">
                                <tr>
                                    <td colspan="10">
                                        <div class="Titulo_Usuarios5" style="width: 200px;">
                                            <p class="etiquetas5" style="width: 200px;">Informacion Actual de Servicios:</p>
                                        </div>

                                    </td>
                                </tr>
                            </table>
                            <table class="tabla">
                                <tr>
                                    <div class="Texto_Informativo_CC">Mix Básico:</div>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label100" runat="server" Text="Paquete Actual:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Mix_Basico" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                            <table class="tabla">
                                <tr>
                                    <div class="Texto_Informativo_CC">Servicios Principales:</div>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label38" runat="server" Text="Television:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Television" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label55" runat="server" Text="Internet:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Internet" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label56" runat="server" Text="Telefonia:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Telefonia" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                            <table class="tabla">
                                <tr>
                                    <div class="Texto_Informativo_CC">Servicios Adicionales:</div>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label57" runat="server" Text="Servico HD:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_HD" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label58" runat="server" Text="Servicio HBO:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_HBO" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label59" runat="server" Text="Servicio FOX:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_FOX" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label60" runat="server" Text="Servicio Adulto:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Adulto" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label62" runat="server" Text="Numero Decos:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Num_Decos" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label63" runat="server" Text="Revista:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Revista" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label65" runat="server" Text="Siembra HD:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Siembra_HD" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label66" runat="server" Text="Blindaje Internet:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Blindaje_Internet" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label67" runat="server" Text="Siembra Voz:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Siembra_Voz" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label61" runat="server" Text="Servicio Claro Video:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Claro_Video" runat="server" Enabled="false" style="border-color: burlywood; background-color:burlywood;"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label68" runat="server" Text="Activacion Claro Video:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Activacion_Claro_Video" runat="server" Enabled="false" style="border-color: burlywood; background-color:burlywood;"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label82" runat="server" Text="Convenio Electrónico:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Convenio_Electronico" runat="server" Enabled="false" style="border-color: burlywood; background-color:burlywood;"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label64" runat="server" Text="Elegido Fijo Móvil:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="CC_Elegido_Fijo_Movil" runat="server" Enabled="false" style="border-color: burlywood; background-color:burlywood;"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </ContentTemplate>
                </asp:UpdatePanel>
                        <asp:Panel CssClass="panel_informativo" ID="Panel12" runat="server" GroupingText="Ofrecimientos">
                            <table class="tabla">
                                <tr>
                                    <td colspan="6">
                                        <div class="Titulo_Ofrecimientos" id="CC_1">
                                            <p class="etiquetas5">Primer Ofrecimiento:</p>
                                        </div>
                                        <asp:UpdatePanel runat="server"><ContentTemplate>
                                        <asp:TextBox CssClass="ofrecimientos" ID="CC_Primer_Ofrecimiento" runat="server" TextMode="MultiLine"></asp:TextBox>
                                        </ContentTemplate></asp:UpdatePanel>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="6">
                                        <p class="etiquetas_Ofrecimiento8">
                                            El cliente acepto este ofrecimiento?
                                        </p>
                                        &nbsp;<asp:RadioButton ID="RadioButton21" runat="server" GroupName="1" Text="SI" Font-Names="Century Gothic" Font-Size="Small" />
                                        &nbsp; &nbsp; 
                                        <asp:RadioButton ID="RadioButton22" runat="server" GroupName="1" Text="NO" Font-Names="Century Gothic" Font-Size="Small" />
                                    </td>

                                </tr>
                            </table>
                            <div id="CC_Ofrecimiento_2" style="display: none">
                                <table class="tabla">
                                    <tr>
                                        <td colspan="6">
                                            <div class="Titulo_Ofrecimientos" id="CC_2">
                                                <p class="etiquetas5">Segundo Ofrecimiento:</p>
                                            </div>
                                            <asp:UpdatePanel runat="server"><ContentTemplate>
                                            <asp:TextBox CssClass="ofrecimientos" ID="CC_Segundo_Ofrecimiento" runat="server" TextMode="MultiLine"></asp:TextBox>
                                            </ContentTemplate></asp:UpdatePanel>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="6">
                                            <p class="etiquetas_Ofrecimiento8">
                                                El cliente acepto este ofrecimiento?
                                            </p>
                                            &nbsp;<asp:RadioButton ID="RadioButton23" runat="server" GroupName="2" Text="SI" Font-Names="Century Gothic" Font-Size="Small" />
                                            &nbsp; &nbsp; 
                                        <asp:RadioButton ID="RadioButton24" runat="server" GroupName="2" Text="NO" Font-Names="Century Gothic" Font-Size="Small" />
                                        </td>

                                    </tr>
                                </table>
                            </div>
                            <div id="CC_Ofrecimiento_3" style="display: none">
                                hola 2
                                    <table class="tabla">
                                        <tr>
                                            <td colspan="6">
                                                <div class="Titulo_Ofrecimientos" id="CC_3">
                                                    <p class="etiquetas5">Tercer Ofrecimiento:</p>
                                                </div>
                                                <asp:UpdatePanel runat="server"><ContentTemplate>
                                                <asp:TextBox CssClass="ofrecimientos" ID="CC_Tercer_Ofrecimiento" runat="server" TextMode="MultiLine"></asp:TextBox>
                                                </ContentTemplate> </asp:UpdatePanel>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="6">
                                                <p class="etiquetas_Ofrecimiento8">
                                                    El cliente acepto este ofrecimiento?
                                                </p>
                                                &nbsp;<asp:RadioButton ID="RadioButton25" runat="server" GroupName="3" Text="SI" Font-Names="Century Gothic" Font-Size="Small" />
                                                &nbsp; &nbsp; 
                                        <asp:RadioButton ID="RadioButton26" runat="server" GroupName="3" Text="NO" Font-Names="Century Gothic" Font-Size="Small" />
                                            </td>

                                        </tr>
                                    </table>
                            </div>
                        </asp:Panel>
                
                        <asp:Panel CssClass="panel_informativo" ID="CC_Paleta_Servicios" runat="server" GroupingText="Paleta de Servicios" >
                            <asp:UpdatePanel runat="server"><ContentTemplate>
                            <br />
                            <table class="tabla2">
                                <div class="Texto_Informativo_CC">Servicios Principales</div>
                                <tr>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_S_VOZ" runat="server" />
                                            <asp:Label ID="Label111" AssociatedControlID="CC_S_VOZ" runat="server"
                                                Text="Telefonía" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                            </table>
                            <table class="tabla2">
                                <tr>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_ANALOGA" runat="server" />
                                            <asp:Label ID="Label113" AssociatedControlID="CC_ANALOGA" runat="server"
                                                Text="Televisión Análoga" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_AVANZADA" runat="server" />
                                            <asp:Label ID="Label114" AssociatedControlID="CC_AVANZADA" runat="server"
                                                Text="Televisión Avanzada" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_BASICA" runat="server" />
                                            <asp:Label ID="Label115" AssociatedControlID="CC_BASICA" runat="server"
                                                Text="Televisión Básica" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_SATELITAL" runat="server" />
                                            <asp:Label ID="Label116" AssociatedControlID="CC_SATELITAL" runat="server"
                                                Text="Televisión Satelital" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_UPGRADE_TV" runat="server" />
                                            <asp:Label ID="Label72" AssociatedControlID="CC_UPGRADE_TV" runat="server"
                                                Text="Upgrade Television" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_UPGRADE_INTERNET" runat="server" />
                                            <asp:Label ID="Label73" AssociatedControlID="CC_UPGRADE_INTERNET" runat="server"
                                                Text="Upgrade Internet" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                            </table>
                            <table class="tabla2">
                                <tr>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_INTERNET_3M" runat="server" />
                                            <asp:Label ID="Label117" AssociatedControlID="CC_INTERNET_3M" runat="server"
                                                Text="Internet 3 Megas" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_INTERNET_5M" runat="server" />
                                            <asp:Label ID="Label118" AssociatedControlID="CC_INTERNET_5M" runat="server"
                                                Text="Internet 5 Megas" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_INTERNET_10M" runat="server" />
                                            <asp:Label ID="Label119" AssociatedControlID="CC_INTERNET_10M" runat="server"
                                                Text="Internet 10 Megas" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_INTERNET_20M" runat="server" />
                                            <asp:Label ID="Label120" AssociatedControlID="CC_INTERNET_20M" runat="server"
                                                Text="Internet 20 Megas" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_INTERNET_50M" runat="server" />
                                            <asp:Label ID="Label121" AssociatedControlID="CC_INTERNET_50M" runat="server"
                                                Text="Internet 50 Megas" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_INTERNET_100M" runat="server" />
                                            <asp:Label ID="Label122" AssociatedControlID="CC_INTERNET_100M" runat="server"
                                                Text="Internet 100 Megas" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                            </table>
                            <br />
                            <table class="tabla2">
                                <tr>
                                    <div class="Texto_Informativo_CC">Servicios Adicionales</div>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_CHECK_CLARO_VIDEO" runat="server" />
                                            <asp:Label ID="Label124" AssociatedControlID="CC_CHECK_CLARO_VIDEO" runat="server"
                                                Text="Claro Video" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_CHECK_FOX" runat="server" />
                                            <asp:Label ID="Label125" AssociatedControlID="CC_CHECK_FOX" runat="server"
                                                Text="Fox +" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_GOLDEN_PREMIER_HD" runat="server" />
                                            <asp:Label ID="Label126" AssociatedControlID="CC_GOLDEN_PREMIER_HD" runat="server"
                                                Text="Golden Premier HD" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_CHECK_HBO" runat="server" />
                                            <asp:Label ID="Label127" AssociatedControlID="CC_CHECK_HBO" runat="server"
                                                Text="HBO" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_CHECK_HD" runat="server" />
                                            <asp:Label ID="Label128" AssociatedControlID="CC_CHECK_HD" runat="server"
                                                Text="HD" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_HOTPACK" runat="server" />
                                            <asp:Label ID="Label129" AssociatedControlID="CC_HOTPACK" runat="server"
                                                Text="Hot Pack" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_INTERNET_MOVIL_1_5" runat="server" />
                                            <asp:Label ID="Label130" AssociatedControlID="CC_INTERNET_MOVIL_1_5" runat="server"
                                                Text="Internet Móvil 1.5" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_INTERNET_MOVIL_750" runat="server" />
                                            <asp:Label ID="Label144" AssociatedControlID="CC_INTERNET_MOVIL_750" runat="server"
                                                Text="Internet Móvil 750" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_IP_FIJA" runat="server" />
                                            <asp:Label ID="Label131" AssociatedControlID="CC_IP_FIJA" runat="server"
                                                Text="IP Fija" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_LOCAL_EXTENDIDA" runat="server" />
                                            <asp:Label ID="Label132" AssociatedControlID="CC_LOCAL_EXTENDIDA" runat="server"
                                                Text="Local extendida" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_MACAFEE" runat="server" />
                                            <asp:Label ID="Label133" AssociatedControlID="CC_MACAFEE" runat="server"
                                                Text="Macafee" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_MINI_FOX" runat="server" />
                                            <asp:Label ID="Label134" AssociatedControlID="CC_MINI_FOX" runat="server"
                                                Text="Mini Fox" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_MINI_HBO" runat="server" />
                                            <asp:Label ID="Label135" AssociatedControlID="CC_MINI_HBO" runat="server"
                                                Text="Mini HBO" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_MODEM_ADICIONAL" runat="server" />
                                            <asp:Label ID="Label136" AssociatedControlID="CC_MODEM_ADICIONAL" runat="server"
                                                Text="Modem Adicional" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>

                                </tr>
                                <tr>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_PVR" runat="server" />
                                            <asp:Label ID="Label137" AssociatedControlID="CC_PVR" runat="server"
                                                Text="PVR" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_PVR_HD" runat="server" />
                                            <asp:Label ID="Label138" AssociatedControlID="CC_PVR_HD" runat="server"
                                                Text="PVR + HD" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_CHECK_REVISTA" runat="server" />
                                            <asp:Label ID="Label139" AssociatedControlID="CC_CHECK_REVISTA" runat="server"
                                                Text="Revista 15 Min" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_SEGUNDO_MODEM" runat="server" />
                                            <asp:Label ID="Label141" AssociatedControlID="CC_SEGUNDO_MODEM" runat="server"
                                                Text="Segundo Modem" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_UFC" runat="server" />
                                            <asp:Label ID="Label142" AssociatedControlID="CC_UFC" runat="server"
                                                Text="UFC Network" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_VOD" runat="server" />
                                            <asp:Label ID="Label143" AssociatedControlID="CC_VOD" runat="server"
                                                Text="VOD" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                            </table>
                            <br />
                            <table class="tabla2">
                                <tr>
                                    <div class="Texto_Informativo_CC">Beneficios</div>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_2CHECK_ELEGIDO_FIJO_MOVIL" runat="server" />
                                            <asp:Label ID="Label69" AssociatedControlID="CC_2CHECK_ELEGIDO_FIJO_MOVIL" runat="server"
                                                Text="Elegido Fijo Movil" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_2CHECK_CLARO_VIDEO" runat="server" />
                                            <asp:Label ID="Label70" AssociatedControlID="CC_2CHECK_CLARO_VIDEO" runat="server"
                                                Text="Claro Video" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="CC_CONVENIO" runat="server" />
                                            <asp:Label ID="Label71" AssociatedControlID="CC_CONVENIO" runat="server"
                                                Text="Convenio Electronico" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                            </table>
                            </ContentTemplate></asp:UpdatePanel>
                        </asp:Panel>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <asp:Panel CssClass="panel_informativo" ID="Panel19" runat="server" GroupingText="Árbol de Tipificación">
                            <table>
                                <tr>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label74" runat="server" Text="Tipo de Contacto:"></asp:Label><br />
                                        <asp:DropDownList CssClass="dropdown1" ID="CC_TIPO_CONTACTO" DataTextField="vacio" OnSelectedIndexChanged="CC_TIPO_CONTACTO_SelectedIndexChanged" runat="server" AutoPostBack="true"></asp:DropDownList>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label75" runat="server" Text="Gestión:"></asp:Label><br />
                                        <asp:DropDownList CssClass="dropdown2" ID="CC_GESTION" OnSelectedIndexChanged="CC_GESTION_SelectedIndexChanged" runat="server" AutoPostBack="true"></asp:DropDownList>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label76" runat="server" Text="Cierre:"></asp:Label><br />
                                        <asp:DropDownList CssClass="dropdown3" ID="CC_CIERRE" OnSelectedIndexChanged="CC_CIERRE_SelectedIndexChanged" runat="server" AutoPostBack="true" style="width:200px;"></asp:DropDownList>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label77" runat="server" Text="Razón:"></asp:Label><br />
                                        <asp:DropDownList CssClass="dropdown3" ID="CC_RAZON" runat="server" OnSelectedIndexChanged="CC_RAZON_SelectedIndexChanged" AutoPostBack="true" style="width:200px;"></asp:DropDownList>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label1" runat="server" Text="Motivo:"></asp:Label><br />
                                        <asp:DropDownList CssClass="dropdown3" ID="CC_MOTIVO" runat="server" style="width:200px;"></asp:DropDownList>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <asp:Panel CssClass="panel_informativo" ID="Panel14" runat="server" GroupingText="Datos Actualizables">
                            <table class="tabla">
                                <tr>
                                    <td colspan="4">
                                        <asp:Label CssClass="texto_informativo" ID="Label78" runat="server" Text="Observaciones:"></asp:Label><br />
                                        <asp:TextBox CssClass="notas_casos" ID="CC_Observaciones" runat="server" autocomplete="off"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        </ContentTemplate>
                </asp:UpdatePanel>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                    <asp:Button CssClass="button" ID="CC_Guardar_Datos" runat="server" Text="Guardar" OnClick="CC_Guardar_Datos_Click"/>
                        <asp:Label id="Base" runat="server" Style="display:none"></asp:Label>
                        <asp:Label id="Operacion" runat="server" Style="display:none"></asp:Label>
                        </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    </asp:Panel>
   <%-- <script>

        $('#datetimepicker').datetimepicker({
            dayOfWeekStart: 1,
            lang: 'es',
            disabledDates: ['1986/01/08', '1986/01/09', '1986/01/10'],
            startDate: '1986/01/05', dateformat: 'Y-m-d 00:00'
        });
        //$('#datetimepicker').datetimepicker({ value: '2015-04-15 05:03', step: 10 });
        $('.some_class').datetimepicker();

    </script>
    <script>
        function Traer_Fecha() {
            var fecha = document.getElementById('datetimepicker').value;
            document.getElementById("<%= datetimepicker1.ClientID %>").value = fecha;
        }
    </script>--%>
</asp:Content>
