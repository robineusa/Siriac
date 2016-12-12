<%@ Page Language="C#" MasterPageFile="~/Perfil_Asesor.master" AutoEventWireup="true" CodeFile="Formulario_Inbound.aspx.cs" Inherits="Formulario_Inbound" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="Estilos/Style_Perfil_Asesor.css?1.1.1" rel="stylesheet" />
    <link href="Estilos/Style_Ingreso_Casos.css?1.0.9" rel="stylesheet" />
    <link href="Estilos/Menu.css?1.0.6" rel="stylesheet" />
    <link href="Estilos/Banner_Alertas_Asesor_In.css?1.0.1" rel="stylesheet" />
    <script src="jquery/jquery.datetimepicker.js?1.0.9"></script>
    <link href="Estilos/jquery.datetimepicker.css?1.0.9" rel="stylesheet" />
    <script src="Js/jquery.datetimepicker.full.js?1.0.9"></script>
    <%--<script src="javascript/Funciones.js?1.0.6"></script>--%>
    <script src="jquery/jquery.dropdownPlain.js?1.0.6"></script>



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        function Cargar_Datos_SMO() {
            document.getElementById('Iframe_SMO').style.display = 'block';
            document.getElementById('<%=SMO_Radio_1.ClientID%>').checked = false;
            document.getElementById('<%=SMO_Radio_2.ClientID%>').checked = false;
            document.getElementById('<%=SMO_Radio_3.ClientID%>').checked = false;
            document.getElementById('<%=SMO_Radio_4.ClientID%>').checked = false;
            document.getElementById('<%=SMO_Radio_5.ClientID%>').checked = false;
            document.getElementById('<%=SMO_Radio_6.ClientID%>').checked = false;
        }
    </script>
    <script lang="ja">

        $(document).ready(function () {


            if ('<%=Session["Acceso_4"]%>' == "1") {

            } else {
                $("#Primer_div").hide();
                $("#css").hide();
            }

            if ('<%=Session["Acceso_5"]%>' == "1") {

            } else {
                $("#Segundo_div").hide();
                $("#javascript").hide();
            }

            if ('<%=Session["Acceso_6"]%>' == "1") {

            } else {
                $("#Tercer_div").hide();
                $("#Li1").hide();
            }

            if ('<%=Session["Acceso_7"]%>' == "1") {
                if ('<%=Session["Acceso_6"]%>' == "1") {

                } else {
                    $("#Li2").addClass("active");
                    $("#Li2-tab").addClass("tab-content active");
                }
            } else {
                $("#Cuarto_div").hide();
                $("#Li2").hide();
            }

            if ('<%=Session["Acceso_8"]%>' == "1") {
                if ('<%=Session["Acceso_6"]%>' == "1" || '<%=Session["Acceso_7"]%>' == "1") {

                } else {
                    $("#Li3").addClass("active");
                    $("#Li3-tab").addClass("tab-content active");
                }
            } else {
                $("#Quinto_div").hide();
                $("#Li3").hide();
            }
            <%--if ('<%=Session["Acceso_3"]%>' == "1") {
                if ('<%=Session["Acceso_1"]%>' == "1" || '<%=Session["Acceso_2"]%>' == "1") {

                } else {
                    $("#javascript").addClass("active");
                    $("#javascript-tab").addClass("tab-content active");
                }
            } else {
                $("#Tercer_div").hide();
                $("#javascript").hide();
            }--%>
        });
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
                return false;
            });
        }
    </script>

    <script lang="ja">
        function otorgar_permisos2() {

            var activeTabIndex = -1;
            var tabNames = ["Li1", "Li2", "Li3"];

            $(".tab-menu1 > li").click(function (e) {
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
                return false;

            });

        }
    </script>
    <script type="text/javascript">
        function mensaje1() {

            alert('Número de cuenta no existe');
        }
    </script>
    <script type="text/javascript">
        function mensaje2() {

            alert('Existen campos vacios');
        }
    </script>
    <script type="text/javascript">
        function mensaje3() {

            alert('Registro Almacenado');
        }
    </script>
    <script type="text/javascript">
        function mensaje4() {

            alert('Esta cuenta ya tiene la marcacion creada, por favor agregue notas');
        }
    </script>
    <script type="text/javascript">
        function mensaje5() {

            alert('No puedes guardar una cuenta nula');
        }
    </script>
    <script type="text/javascript">
        function mensaje6() {

            alert('No se pudo guardar el registro, verifique la información e intentelo nuevamente');
        }
    </script>
    <script type="text/javascript">
        function mensaje7() {

            alert('El ofrecimiento aplicado al cliente fue almacenado!');
        }
    </script>
    <script type="text/javascript">
        function mensaje8() {

            alert('Número de cedula no existe, o ya fue desasociada en el sistema');
        }
    </script>
    <script type="text/javascript">
        function mensaje11() {

            alert('Debe seleccionar una Marcación');
        }
    </script>
    <script type="text/javascript">
        function mensaje12() {

            alert('Debe seleccionar Estado del caso y Área escalar');
        }
    </script>
    <script type="text/javascript">
        function mensaje9() {
            window.location.href = '#';
        }
    </script>
    <script type="text/javascript">
        function mensaje10() {
            confirm('Actualmente no posee acceso a esta gestión');
        }
    </script>
    <script type="text/javascript">
        function Banner_Alertas_Inicio() {

            document.getElementById('Menu_Opciones').style.display = 'none';
            document.getElementById('Icono_1').style.display = 'none';
            document.getElementById('Icono_2').style.display = 'none';
            document.getElementById('Icono_3').style.display = 'none';
            document.getElementById('Icono_4').style.display = 'none';
            document.getElementById('Icono_5').style.display = 'none';
            document.getElementById('SMO_Ofrecimiento_2').style.display = 'none';
            document.getElementById('SMO_Ofrecimiento_3').style.display = 'none';
            document.getElementById('SMO_Paleta_de_Servicios').style.display = 'none';
        }
    </script>
    <script type="text/javascript">
        function Activar_Conveio() {
            document.getElementById('Menu_Opciones').style.display = 'block';
            document.getElementById('Icono_1').style.display = 'block';
        }
    </script>
    <script type="text/javascript">
        function No_Activar_Conveio() {
            document.getElementById('Icono_1').style.display = 'none';
        }
    </script>
    <script type="text/javascript">
        function SMO_Activar() {
            document.getElementById('Menu_Opciones').style.display = 'block';
            document.getElementById('Icono_4').style.display = 'block';
        }
    </script>
    <script type="text/javascript">
        function SMO_Desactivar() {
            document.getElementById('Icono_4').style.display = 'none';
        }
    </script>
    <script type="text/javascript">
        function CV_Activar() {
            document.getElementById('Menu_Opciones').style.display = 'block';
            document.getElementById('Icono_3').style.display = 'block';
        }
    </script>
    <script type="text/javascript">
        function CV_Desactivar() {
            document.getElementById('Icono_3').style.display = 'none';
        }
    </script>
    <script type="text/javascript">
        function HD_Activar() {
            document.getElementById('Menu_Opciones').style.display = 'block';
            document.getElementById('Icono_5').style.display = 'block';
        }
    </script>
    <script type="text/javascript">
        function HD_Desactivar() {
            document.getElementById('Icono_5').style.display = 'none';
        }
    </script>

    <script type="text/javascript">
        function SMO_Guardado() {
            document.getElementById('Iframe_SMO').style.display = 'none';
            Banner_Alertas_Inicio();
            alert('¡Ofrecimiento Almacenado!');

        }
    </script>
    <script type="text/javascript">
        function SMO_No_Guardado() {
            document.getElementById('Iframe_SMO').style.display = 'none';
            alert('¡Ofrecimiento No Almacenado!');
        }
    </script>
    <script type="text/javascript">
        function SMO_Actualizado() {
            document.getElementById('Iframe_SMO').style.display = 'none';
            Banner_Alertas_Inicio();
            alert('¡Ofrecimiento Actualizado!');
        }
    </script>
    <script type="text/javascript">
        function SMO_No_Actualizado() {
            document.getElementById('Iframe_SMO').style.display = 'none';
            alert('¡Ofrecimiento No Actualizado!');
        }
    </script>
    <script type="text/javascript">
        function CV_Guardado() {
            document.getElementById('Iframe_CV_Cerrar').click();
            alert('¡Activacion Almacenada!');

        }
    </script>
    <script type="text/javascript">
        function CV_Actualizado() {
            document.getElementById('Iframe_CV_Cerrar').click();
            alert('¡Ya se habia guardado una activacion. Se generó una nueva interacción!');
        }
    </script>
    <script type="text/javascript">
        function SHD_Guardado() {
            document.getElementById('Iframe_HD_Cerrar').click();
            HD_Desactivar();
            alert('¡Registro Almacenado!');

        }
    </script>
    <script type="text/javascript">
        function SHD_Actualizado() {
            document.getElementById('Iframe_HD_Cerrar').click();
            HD_Desactivar();
            alert('¡Ya se habia guardado una activacion. Se generó una nueva interacción!');
        }
    </script>
    <%--<script type="text/javascript">
        $(function Enviar_MEC() {
            var chat2 = $.connection.chatHub;
            $.connection.hub.start().done(function () {
                Registra_Eventos2(chat2);
            });
        });

        function Registra_Eventos2(chat2) {
            $('#Envia_MEC').click(function () {
                var Usuario = '<%= Session["Nombre_Usuario"] %>';
                var Cedula = '<%= Session["Cedula"] %>';
                chat2.server.mec(Usuario, Cedula, $(<%=Cuenta_Cliente.ClientID%>).val());
            });
        }
        function Activar_Envia_MEC() {
            var x = document.getElementById("Envia_MEC");
            x.click();
        }
    </script>--%>
    <input type="button" id="Envia_MEC" style="display: none" />
    <div id="footer" onmouseover="document.getElementById('carrete_de_iconos').style.display = 'block';" onmouseout="document.getElementById('carrete_de_iconos').style.display = 'none';">
        <div id="carrete_de_iconos" class="carrete_de_iconos">
            <a href="#Campanas" onclick="return Cargar_Datos_APC()">
                <div id="Calculadora1" class="icono_carrete_5"></div>
            </a>
            <a href="#Compensacion" onclick="return Abrir_Ventana_Compensacion()">
                <div id="Calculadora2" class="icono_carrete_6"></div>
            </a>
            <a href="#Diferencia_Tarifas" onclick="return Cargar_Datos_ADT()">
                <div id="Calculadora3" class="icono_carrete_7"></div>
            </a>
            <a href="#Prorrateos" onclick="return Cargar_Datos_AP()">
                <div id="Calculadora4" class="icono_carrete_8"></div>
            </a>
            <a href="http://comunidadvirtual.claro.com.co" target="_blank">
                <div class="icono_carrete_2" id="Div2"></div>
            </a>
            <a href="Notificaciones_Inbound.aspx">
                <div class="icono_carrete_3" id="Div3"></div>
            </a>
            <div class="inbenta-banner">
                <a class="openAssistant" href="#">
                    <div class="icono_carrete_4" id="Div4"></div>
                </a>
            </div>
            <a href="#Iframe_Back_Elite" onclick="return Abrir_Ventana_BackElite()">
                <div id="BackElite" class="icono_carrete_9"></div>
            </a>
            <a href="#Iframe_T_Crear_Direccion" onclick="return Abrir_Ventana_T_Crear_Direccion()">
                <div id="T_Crear_Direccion" class="icono_carrete_10"></div>
            </a>

        </div>
    </div>
    <script type="text/javascript">
        function Cargar_Iframe() {
            document.getElementById('Iframe_CV').style.display = 'block';
            var ruta = "https://comunidadvirtual.claro.com.co/www/lms/Biblioteca/Documentos/others/M_Servicio/Residencial/Boletines/Comunicados%20-%202016/c1136/index.html";
            var iframe = document.getElementById('ContentPlaceHolder1_Iframe1');
            iframe.setAttribute("src", ruta);
        }
        function Quitar_Iframe() {
            var ruta = "";
            var iframe = document.getElementById('ContentPlaceHolder1_Iframe1');
            iframe.setAttribute("src", ruta);
        }
    </script>


    <div id="Menu_Opciones" style="display: none">
        <div id="Latido" class="latir">
            <a href="#Iframe_Paradigma" onclick="document.getElementById('Iframe_Paradigma').style.display = 'block';">
                <div id="Icono_1" style="display: none"></div>
            </a>
            <div id="Icono_2" style="display: none"></div>
            <a href="#Iframe_CV" onclick="return Cargar_Iframe();">
                <div id="Icono_3" style="display: none"></div>
            </a>
            <a href="#Iframe_SMO" onclick="return Cargar_Datos_SMO()">
                <div id="Icono_4" style="display: none"></div>
            </a>
            <a href="#Iframe_HD" onclick="document.getElementById('Iframe_HD').style.display = 'block';">
                <div id="Icono_5" style="display: none"></div>
            </a>
        </div>
    </div>

    <div id="Contenedor_Paneles">
        <asp:Panel CssClass="panel" ID="Panel1" runat="server">
            <div id="tab-container">
                <ul class="tab-menu">
                    <li id="html" class="active" onclick="otorgar_permisos()">TIPIFICADOR</li>
                    <li id="css" onclick="otorgar_permisos()">INCREMENTO DE TARIFA</li>
                    <li id="javascript" onclick="otorgar_permisos()">AYUDA VENTAS</li>
                </ul>
                <div class="clear"></div>
                <div class="tab-top-border"></div>
                <div id="html-tab" class="tab-content active">
                    <h3 class="Titulos">FORMULARIO PARA LA TIPIFICACIÓN DE LLAMADAS</h3>

                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:Panel CssClass="panel_informativo" ID="Panel3" runat="server" GroupingText="Datos del Cliente">
                                <table class="tabla">
                                    <tr>
                                        <td>

                                            <asp:Label CssClass="texto_informativo" ID="Label1" runat="server" Text="Número de Cuenta:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Cuenta_Cliente" runat="server" OnTextChanged="Cuenta_Cliente_TextChanged" AutoPostBack="true" Placeholder="Ingrese la Cuenta"></asp:TextBox>

                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label2" runat="server" Text="Nombre del Cliente:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Nombre_Cliente" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label3" runat="server" Text="Apellido del Cliente:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Apellido_Cliente" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label4" runat="server" Text="Documento de Identidad:"></asp:Label><br />
                                            <a href="#Consulta_Cliente" class="popup-link">
                                                <asp:TextBox CssClass="caja_de_texto" ID="Cedula_Cliente" runat="server" OnTextChanged="Cedula_Cliente_TextChanged" AutoPostBack="true" Placeholder="Ingrese el Documento"></asp:TextBox></a>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label6" runat="server" Text="Teléfono Telmex:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Telefono_Telmex" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label7" runat="server" Text="Teléfono 1:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Telefono_1" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label8" runat="server" Text="Teléfono 2:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Telefono_2" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label9" runat="server" Text="Teléfono 3:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Telefono_3" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label10" runat="server" Text="Teléfono Personal:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Telefono_Personal" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label11" runat="server" Text="Dirección de Instalación:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Direccion_Instalacion" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label12" runat="server" Text="Correspondencia:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Direccion_Correspondencia" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label13" runat="server" Text="Correo Electrónico:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Correo_Electronico" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label14" runat="server" Text="Nodo:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Nodo" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label15" runat="server" Text="Red:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Red" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label16" runat="server" Text="División:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Division" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label17" runat="server" Text="Área"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Area" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label18" runat="server" Text="Zona:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Zona" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label19" runat="server" Text="Distrito:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Distrito" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label20" runat="server" Text="Nombre Comunidad:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Nombre_Comunidad" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label21" runat="server" Text="Estrato:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Estrato" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label22" runat="server" Text="Tipo de Cliente:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Tipo_Cliente" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label23" runat="server" Text="Descripción:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Descripcion" runat="server"></asp:TextBox>
                                        </td>
                                        <td colspan="2">
                                            <asp:Label CssClass="texto_informativo" ID="Label24" runat="server" Text="Fecha de Compleaños:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Fecha_Cumpleaños" runat="server"></asp:TextBox>
                                            <asp:Button CssClass="bt_calendario" ID="Boton_Calendario" runat="server" OnClick="Boton_Calendario_Click" />
                                            <asp:Calendar CssClass="calendario_fecha" ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" Visible="false">
                                                <DayHeaderStyle CssClass="DayHeaderStyle" />
                                                <DayStyle CssClass="DayStyle" ForeColor="White" Font-Names="verdana" />
                                                <NextPrevStyle CssClass="NextPrevStyle" ForeColor="White" Font-Bold="true" Font-Underline="false" />
                                                <OtherMonthDayStyle CssClass="OtherMonthDayStyle" ForeColor="#663300" Font-Names="Verdana" />
                                                <WeekendDayStyle CssClass="WeekendDayStyle" ForeColor="White" Font-Names="arial" Font-Underline="false" Font-Overline="false" />
                                                <SelectedDayStyle CssClass="SelectedDayStyle" BackColor="#990000" />
                                                <SelectorStyle CssClass="SelectorStyle" />
                                                <TitleStyle CssClass="TitleStyle" ForeColor="white" Font-Bold="true" Font-Names="sans-serif" />
                                                <TodayDayStyle CssClass="TodayDayStyle" />
                                            </asp:Calendar>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label25" runat="server" Text="Rango de Edad:"></asp:Label><br />
                                            <asp:DropDownList CssClass="dropdown1" ID="Rango_Edad" runat="server">
                                                <asp:ListItem>00-05</asp:ListItem>
                                                <asp:ListItem>06-10</asp:ListItem>
                                                <asp:ListItem>11-15</asp:ListItem>
                                                <asp:ListItem>16-20</asp:ListItem>
                                                <asp:ListItem>21-25</asp:ListItem>
                                                <asp:ListItem>26-30</asp:ListItem>
                                                <asp:ListItem>31-35</asp:ListItem>
                                                <asp:ListItem>36-40</asp:ListItem>
                                                <asp:ListItem>41-45</asp:ListItem>
                                                <asp:ListItem>46-50</asp:ListItem>
                                                <asp:ListItem>51-55</asp:ListItem>
                                                <asp:ListItem>56-60</asp:ListItem>
                                                <asp:ListItem>61-65</asp:ListItem>
                                                <asp:ListItem>66-70</asp:ListItem>
                                                <asp:ListItem>71-75</asp:ListItem>
                                                <asp:ListItem>76-80</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label26" runat="server" Text="Hobby:"></asp:Label><br />
                                            <asp:DropDownList CssClass="dropdown1" ID="Hobby" runat="server"></asp:DropDownList>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label27" runat="server" Text="Twitter:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Twitter" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label28" runat="server" Text="Facebook:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Facebook" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label29" runat="server" Text="Instagram:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Instagram" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label30" runat="server" Text="Otro:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Otro" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label31" runat="server" Text="Número de Hijos:"></asp:Label><br />
                                            <asp:DropDownList CssClass="dropdown1" ID="Numero_de_Hijos" runat="server">
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
                                            <asp:Label CssClass="texto_informativo" ID="Label32" runat="server" Text="Rango Edad Hijos:"></asp:Label><br />
                                            <asp:DropDownList CssClass="dropdown1" ID="Edad_Hijos" runat="server">
                                                <asp:ListItem>00-05</asp:ListItem>
                                                <asp:ListItem>06-10</asp:ListItem>
                                                <asp:ListItem>11-15</asp:ListItem>
                                                <asp:ListItem>16-20</asp:ListItem>
                                                <asp:ListItem>21-25</asp:ListItem>
                                                <asp:ListItem>26-30</asp:ListItem>
                                                <asp:ListItem>31-35</asp:ListItem>
                                                <asp:ListItem>36-40</asp:ListItem>
                                                <asp:ListItem>41-45</asp:ListItem>
                                                <asp:ListItem>46-50</asp:ListItem>
                                                <asp:ListItem>51-55</asp:ListItem>
                                                <asp:ListItem>56-60</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label33" runat="server" Text="Nivel de Estudios:"></asp:Label><br />
                                            <asp:DropDownList CssClass="dropdown1" ID="Nivel_de_Estudios" runat="server">
                                                <asp:ListItem>PRIMARIA</asp:ListItem>
                                                <asp:ListItem>SECUNDARIA</asp:ListItem>
                                                <asp:ListItem>BACHILLER</asp:ListItem>
                                                <asp:ListItem>TECNICO</asp:ListItem>
                                                <asp:ListItem>TECNOLOGO</asp:ListItem>
                                                <asp:ListItem>PROFESIONAL</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>

                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <asp:Panel CssClass="panel_informativo" ID="Panel4" runat="server" GroupingText="Mapa de Marcaciones">
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                                <table class="tabla">
                                    <tr>
                                        <td colspan="6">
                                            <asp:Label CssClass="texto_informativo" ID="Label5" runat="server" Text="Ingrese datos para consultar:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto_consulta" ID="Caja_consulta" runat="server" OnTextChanged="Caja_consulta_TextChanged" AutoPostBack="true"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="7">
                                            <div class="base_marcacion">
                                                <asp:RadioButtonList ID="Lista_Marcaciones" runat="server" OnSelectedIndexChanged="Lista_Marcaciones_SelectedIndexChanged" AutoPostBack="true">
                                                </asp:RadioButtonList>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                                <table class="tabla">

                                    <tr>
                                        <td colspan="2">
                                            <asp:Label CssClass="texto_informativo" ID="Label34" runat="server" Text="Servicio:"></asp:Label><br />
                                            <asp:DropDownList CssClass="dropdown1" ID="Servicios" runat="server"></asp:DropDownList>
                                        </td>
                                        <td colspan="2">
                                            <asp:Label CssClass="texto_informativo" ID="Label35" runat="server" Text="Macroproceso:"></asp:Label><br />
                                            <asp:DropDownList CssClass="dropdown2" ID="Macroproceso" runat="server">
                                            </asp:DropDownList>
                                        </td>
                                        <td colspan="3">
                                            <asp:Label CssClass="texto_informativo" ID="Label36" runat="server" Text="Proceso:"></asp:Label><br />
                                            <asp:DropDownList CssClass="dropdown3" ID="Proceso" runat="server">
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label37" runat="server" Text="Subproceso:"></asp:Label><br />
                                            <asp:DropDownList CssClass="dropdown3" ID="Subproceso" runat="server">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                </table>
                                <table class="tabla">
                                    <tr>
                                        <td colspan="6">
                                            <h4 class="Titulo_Informativo2">POSIBLE CAUSA:</h4>
                                            <div class="marcacion">
                                                <asp:Label ID="Posible_Causa" runat="server" Text=""></asp:Label>
                                            </div>
                                            <br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="7">
                                            <h4 class="Titulo_Informativo2">QUE HACER:</h4>
                                            <div class="marcacion">
                                                <asp:Label ID="Que_Hacer" runat="server" Text=""></asp:Label>
                                            </div>
                                            <br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="7">
                                            <h4 class="Titulo_Informativo2">CÓDIGOS DE CIERRE:</h4>
                                            <div class="marcacion">
                                                <asp:Label ID="Codigos_de_Cierre" runat="server" Text=""></asp:Label>
                                            </div>
                                            <br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="7">
                                            <h4 class="Titulo_Informativo2">ÁREA USUARIO A ESCALAR:</h4>
                                            <div class="marcacion">
                                                <asp:Label ID="Area_Usuario_Escalar" runat="server" Text=""></asp:Label>
                                            </div>
                                            <br />
                                        </td>
                                    </tr>
                                </table>
                                <table class="tabla">
                                    <tr>
                                        <td>
                                            <h4 class="Titulo_Informativo2">MARCACIÓN:</h4>
                                            <asp:DropDownList CssClass="dropdown1" ID="Marcacion" runat="server">
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            <h4 class="Titulo_Informativo2">TIPO DE ATENCIÓN:</h4>
                                            <asp:DropDownList CssClass="dropdown1" ID="Tipo_Atencion" runat="server">
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            <h4 class="Titulo_Informativo2">PRODUCTO ASOCIADO:</h4>
                                            <asp:DropDownList CssClass="dropdown1" ID="Producto_Asociado" runat="server">
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            <h4 class="Titulo_Informativo2">SPC:</h4>
                                            <asp:DropDownList CssClass="dropdown1" ID="Solucion" runat="server">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                </table>
                                <table class="tabla">
                                    <tr>
                                        <td colspan="7">
                                            <h4 class="Titulo_Informativo2">NOTAS:</h4>
                                            <asp:TextBox CssClass="notas_casos" ID="Notas" runat="server" TextMode="MultiLine"></asp:TextBox>
                                            <br />
                                        </td>
                                    </tr>
                                </table>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </asp:Panel>
                    <asp:Panel CssClass="panel_informativo" ID="Panel5" runat="server" GroupingText="Estado de la Interacción">
                        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                            <ContentTemplate>
                                <table class="tabla">
                                    <tr>
                                        <td>
                                            <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                                <ContentTemplate>
                                                    <h4 class="Titulo_Informativo2">ESTADO CASO:</h4>
                                                    <asp:DropDownList CssClass="dropdown1" ID="Estado_Caso" runat="server" AutoPostBack="true" OnTextChanged="Estado_Caso_TextChanged">
                                                    </asp:DropDownList>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </td>
                                        <td colspan="1">
                                            <h4 class="Titulo_Informativo2">AREA A ESCALAR:</h4>
                                            <asp:DropDownList CssClass="dropdown2" ID="Area_Escalar" runat="server"></asp:DropDownList>
                                        </td>
                                        <td>
                                            <h4 class="Titulo_Informativo2">NÚMERO DE PQRÑ RR:</h4>
                                            <asp:TextBox CssClass="caja_de_texto" ID="Pqr" runat="server" Text="0"></asp:TextBox>
                                            <asp:Label ID="Label38" runat="server" Text="" Style="display: none"></asp:Label>
                                            <asp:Label ID="Label39" runat="server" Text="" Style="display: none"></asp:Label>
                                            <asp:Label ID="Label40" runat="server" Text="" Style="display: none"></asp:Label>
                                        </td>
                                    </tr>
                                </table>

                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </asp:Panel>

                    <asp:Button CssClass="button" ID="Guardar_Caso" runat="server" Text="Guardar" OnClick="Guardar_Caso_Click" />
                </div>
                <div id="css-tab" class="tab-content">
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
                        function Ofrecimiento_SMO_1_SI() {
                            document.getElementById('SMO_Ofrecimiento_2').style.display = 'none';
                            document.getElementById('SMO_Ofrecimiento_3').style.display = 'none';
                            document.getElementById('SMO_Paleta_de_Servicios').style.display = 'none';

                            var RadioButton2 = '<%=SMO_Radio_2.ClientID%>';
                            document.getElementById(RadioButton2).setSelected(false);
                            var RadioButton3 = '<%=SMO_Radio_3.ClientID%>';
                            document.getElementById(RadioButton3).setSelected(false);
                            var RadioButton4 = '<%=SMO_Radio_4.ClientID%>';
                            document.getElementById(RadioButton4).setSelected(false);
                            var RadioButton5 = '<%=SMO_Radio_5.ClientID%>';
                            document.getElementById(RadioButton5).setSelected(false);
                            var RadioButton6 = '<%=SMO_Radio_6.ClientID%>';
                            document.getElementById(RadioButton6).setSelected(false);

                        }
                    </script>
                    <script type="text/javascript">
                        function Ofrecimiento_SMO_1_NO() {
                            document.getElementById('SMO_Ofrecimiento_2').style.display = 'block';
                            document.getElementById('SMO_Ofrecimiento_3').style.display = 'none';
                            document.getElementById('SMO_Paleta_de_Servicios').style.display = 'none';

                            var RadioButton3 = '<%=SMO_Radio_3.ClientID%>';
                            document.getElementById(RadioButton3).setSelected(false);
                            var RadioButton4 = '<%=SMO_Radio_4.ClientID%>';
                            document.getElementById(RadioButton4).setSelected(false);
                            var RadioButton5 = '<%=SMO_Radio_5.ClientID%>';
                            document.getElementById(RadioButton5).setSelected(false);
                            var RadioButton6 = '<%=SMO_Radio_6.ClientID%>';
                            document.getElementById(RadioButton6).setSelected(false);
                        }
                    </script>
                    <script type="text/javascript">
                        function Ofrecimiento_SMO_2_SI() {
                            document.getElementById('SMO_Ofrecimiento_3').style.display = 'none';
                            document.getElementById('SMO_Paleta_de_Servicios').style.display = 'none';

                            var RadioButton5 = '<%=SMO_Radio_5.ClientID%>';
                            document.getElementById(RadioButton5).setSelected(false);
                            var RadioButton6 = '<%=SMO_Radio_6.ClientID%>';
                            document.getElementById(RadioButton6).setSelected(false);
                        }
                    </script>
                    <script type="text/javascript">
                        function Ofrecimiento_SMO_2_NO() {
                            document.getElementById('SMO_Ofrecimiento_3').style.display = 'block';
                            document.getElementById('SMO_Paleta_de_Servicios').style.display = 'none';

                            var RadioButton5 = '<%=SMO_Radio_5.ClientID%>';
                            document.getElementById(RadioButton5).setSelected(false);
                            var RadioButton6 = '<%=SMO_Radio_6.ClientID%>';
                            document.getElementById(RadioButton6).setSelected(false);
                        }
                    </script>
                    <script type="text/javascript">
                        function Ofrecimiento_SMO_3_SI() {

                            document.getElementById('SMO_Paleta_de_Servicios').style.display = 'none';
                        }
                    </script>

                    <script type="text/javascript">
                        function Ofrecimiento_SMO_3_NO() {
                            document.getElementById('SMO_Paleta_de_Servicios').style.display = 'block';
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

                            var RadioButton3 = '<%=RadioButton3.ClientID%>';
                            document.getElementById(RadioButton3).setSelected(false);
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
                        }
                    </script>
                    <script type="text/javascript">
                        function Ofrecimiento4SI() {
                            document.getElementById('5').style.display = 'none';
                            document.getElementById('51').style.display = 'none';
                            document.getElementById('6').style.display = 'none';
                            document.getElementById('61').style.display = 'none';
                        }
                    </script>
                    <script type="text/javascript">
                        function Ofrecimiento5SI() {
                            document.getElementById('6').style.display = 'none';
                            document.getElementById('61').style.display = 'none';
                        }
                    </script>
                    <script type="text/javascript">
                        function Ofrecimiento6SI() {

                        }
                    </script>
                    <script type="text/javascript">
                        function Ofrecimiento1NO() {
                            document.getElementById('2').style.display = 'block';
                            document.getElementById('21').style.display = 'block';
                            var RadioButton3 = '<%=RadioButton3.ClientID%>';
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

                        }
                    </script>

                    <!-------------- A PARTIR DE ESTE MOMENTO INICIA EL SEGUNDO PANEL--------------------------------------------------------------------------------------------->
                    <div id="Primer_div">
                        <h3 class="Titulos">FORMULARIO DETALLE INCREMENTO DE TARIFA</h3>

                        <asp:Panel CssClass="panel_informativo" ID="Panel6" runat="server" GroupingText="Información del Cliente">
                            <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                <ContentTemplate>
                                    <table class="tabla">
                                        <tr>
                                            <td>
                                                <p class="texto_informativo">Número de Cuenta</p>
                                                <asp:TextBox CssClass="caja_de_texto" ID="Incremento_Cuenta_Cliente" runat="server" Enabled="false"></asp:TextBox>
                                            </td>
                                            <td>
                                                <p class="texto_informativo">Categoría Comercial:</p>
                                                <asp:TextBox CssClass="caja_de_texto" ID="Incremento_Categoria_Comercial" runat="server"></asp:TextBox>
                                            </td>

                                            <td>

                                                <p class="texto_informativo">Nombre del Cliente:</p>
                                                <asp:TextBox CssClass="caja_de_texto" ID="Incremento_Nombre_Cliente" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                <p class="texto_informativo">Apellido del Cliente:</p>
                                                <asp:TextBox CssClass="caja_de_texto" ID="Incremento_Apellido_Cliente" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                <p class="texto_informativo">Ciudad de Residencia:</p>
                                                <asp:TextBox CssClass="caja_de_texto" ID="Incremento_Ciudad_Residencia" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                <p class="texto_informativo">Estrato:</p>
                                                <asp:TextBox CssClass="caja_de_texto" ID="Incremento_Estrato" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                <p class="texto_informativo">Tipo de Cliente:</p>
                                                <asp:TextBox CssClass="caja_de_texto" ID="Incremento_Tipo_Cliente" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </ContentTemplate>
                            </asp:UpdatePanel>

                        </asp:Panel>
                        <asp:Panel CssClass="panel_informativo" ID="Panel7" runat="server" GroupingText="Detalle del Incremento">
                            <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                <ContentTemplate>

                                    <table class="tabla">
                                        <tr>
                                            <td>
                                                <p class="texto_informativo">Tarifa Anterior:</p>
                                                <asp:TextBox CssClass="caja_de_texto" ID="Incremento_Tarifa_Anterior" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                <p class="texto_informativo">Tarifa Nueva:</p>
                                                <asp:TextBox CssClass="caja_de_texto" ID="Incremento_Tarifa_Nueva" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                <p class="texto_informativo">Incremento Real:</p>
                                                <asp:TextBox CssClass="caja_de_texto" ID="Incremento_Incrmento_Real" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                <p class="texto_informativo">Renta sin Incremento:</p>
                                                <asp:TextBox CssClass="caja_de_texto" ID="Incremento_Renta_Sin_Incrmento" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                <p class="texto_informativo">Nueva Renta:</p>
                                                <asp:TextBox CssClass="caja_de_texto" ID="Incremento_Nueva_Renta" runat="server"></asp:TextBox>
                                            </td>
                                            <td></td>
                                            <td>
                                                <p class="texto_informativo">Diferencia:</p>
                                                <asp:TextBox CssClass="caja_de_texto" ID="Incremento_Direfencia" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </ContentTemplate>
                            </asp:UpdatePanel>

                        </asp:Panel>
                        <asp:Panel CssClass="panel_informativo" ID="Panel8" runat="server" GroupingText="Productos Asociados">
                            <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                                <ContentTemplate>
                                    <table class="tabla">
                                        <tr>
                                            <td>
                                                <p class="texto_informativo">Paquete Actual:</p>
                                                <asp:TextBox CssClass="caja_de_texto" ID="Incremento_Paquete_Actual" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                <p class="texto_informativo">Velocidad del Internet:</p>
                                                <asp:TextBox CssClass="caja_de_texto" ID="Incremento_Velocidad_Internet" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                <p class="texto_informativo">Tipo Televisión:</p>
                                                <asp:TextBox CssClass="caja_de_texto" ID="Incremento_Tipo_Television" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                <p class="texto_informativo">Servicio HD:</p>
                                                <asp:TextBox CssClass="caja_de_texto" ID="Incremento_Servicio_Hd" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                <p class="texto_informativo">Elegido Fijo Móvil:</p>
                                                <asp:TextBox CssClass="caja_de_texto" ID="Incremento_Elegido_Movil" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                <p class="texto_informativo">Claro Video:</p>
                                                <asp:TextBox CssClass="caja_de_texto" ID="Incremento_Claro_Video" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                <p class="texto_informativo">Postpago Móvil:</p>
                                                <asp:TextBox CssClass="caja_de_texto" ID="Incremento_Postpago_Movil" runat="server"></asp:TextBox>
                                            </td>

                                        </tr>
                                        <tr>
                                            <td>
                                                <p class="texto_informativo">Plan LD30:</p>
                                                <asp:TextBox CssClass="caja_de_texto" ID="Incremento_Plan_Ld30" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                <p class="texto_informativo">Apto Venta Tecnología:</p>
                                                <asp:TextBox CssClass="caja_de_texto" ID="Incremento_Apto_Tecnologia" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:Label ID="Incremento_Periodo_Ofrecimiento" runat="server" Text="0" Style="display: none"></asp:Label></td>
                                        </tr>
                                    </table>
                                </ContentTemplate>
                            </asp:UpdatePanel>

                        </asp:Panel>
                        <asp:Panel CssClass="panel_informativo" ID="Panel9" runat="server" GroupingText="Consumos del Cliente">
                            <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                                <ContentTemplate>
                                    <table class="tabla">
                                        <tr>
                                            <td>
                                                <p class="texto_informativo">Llamadas Móviles Claro:</p>
                                                <asp:TextBox CssClass="caja_de_texto" ID="Incremento_Llamadas_Moviles" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                <p class="texto_informativo">LD Otros Operadores:</p>
                                                <asp:TextBox CssClass="caja_de_texto" ID="Incremento_Otros_Operadores" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </ContentTemplate>
                            </asp:UpdatePanel>

                        </asp:Panel>
                        <asp:Panel CssClass="panel_informativo" ID="Panel10" runat="server" GroupingText="Ofrecimientos">
                            <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                                <ContentTemplate>
                                    <table class="tabla">
                                        <tr>
                                            <td colspan="6">
                                                <div class="Titulo_Ofrecimientos" id="1">
                                                    <p class="etiquetas5">Primer Ofrecimiento:</p>
                                                </div>
                                                <asp:TextBox CssClass="ofrecimientos" ID="Incremento_Primer_Oprecimiento" runat="server" TextMode="MultiLine"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="6">
                                                <p class="etiquetas_Ofrecimiento8">
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
                                                        <p class="etiquetas5">Segundo Ofrecimiento:</p>
                                                    </div>
                                                    <asp:TextBox CssClass="ofrecimientos" ID="Incremento_Segundo_Ofrecimiento" runat="server" TextMode="MultiLine"></asp:TextBox>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="6">
                                                <div id="21" style="display: none">
                                                    <asp:Label CssClass="etiquetas_Ofrecimiento8" ID="Label41" runat="server" Text="El cliente acepto este ofrecimiento?"></asp:Label><br />
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
                                                        <p class="etiquetas5">Tercer Ofrecimiento:</p>
                                                    </div>
                                                    <asp:TextBox CssClass="ofrecimientos" ID="Incremento_Tercer_Ofrecimiento" runat="server" TextMode="MultiLine"></asp:TextBox>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="6">
                                                <div id="31" style="display: none">
                                                    <asp:Label CssClass="etiquetas_Ofrecimiento8" ID="Label42" runat="server" Text="El cliente acepto este ofrecimiento?"></asp:Label><br />
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
                                                        <p class="etiquetas5">Cuarto Ofrecimiento:</p>
                                                    </div>
                                                    <asp:TextBox CssClass="ofrecimientos" ID="Incremento_Cuarto_Ofrecimiento" runat="server" TextMode="MultiLine"></asp:TextBox>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="6">
                                                <div id="41" style="display: none">
                                                    <asp:Label CssClass="etiquetas_Ofrecimiento8" ID="Label43" runat="server" Text="El cliente acepto este ofrecimiento?"></asp:Label><br />
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
                                                        <p class="etiquetas5">Quinto Ofrecimiento:</p>
                                                    </div>
                                                    <asp:TextBox CssClass="ofrecimientos" ID="Incremento_Quinto_Ofrecimiento" runat="server" TextMode="MultiLine"></asp:TextBox>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="6">
                                                <div id="51" style="display: none">
                                                    <asp:Label CssClass="etiquetas_Ofrecimiento8" ID="Label44" runat="server" Text="El cliente acepto este ofrecimiento?"></asp:Label><br />
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
                                                        <p class="etiquetas5">Sexto Ofrecimiento:</p>
                                                    </div>
                                                    <asp:TextBox CssClass="ofrecimientos" ID="Incremento_Sexto_Ofrecimiento" runat="server" TextMode="MultiLine"></asp:TextBox>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="6">
                                                <div id="61" style="display: none">
                                                    <asp:Label CssClass="etiquetas_Ofrecimiento8" ID="Label45" runat="server" Text="El cliente acepto este ofrecimiento?"></asp:Label><br />
                                                    &nbsp;<asp:RadioButton ID="RadioButton11" runat="server" GroupName="6" Text="SI" Font-Names="Century Gothic" Font-Size="Small" />
                                                    &nbsp; &nbsp; 
        <asp:RadioButton ID="RadioButton12" runat="server" GroupName="6" Text="NO" Font-Names="Century Gothic" Font-Size="Small" />
                                                </div>
                                            </td>
                                        </tr>
                                    </table>
                                </ContentTemplate>
                            </asp:UpdatePanel>

                        </asp:Panel>
                        <table class="tabla">
                            <tr>
                                <asp:Button CssClass="button" ID="Guardar_Ofrecimiento" runat="server" Text="Guardar Ofrecimiento" OnClick="Guardar_Ofrecimiento_Click" />
                            </tr>
                        </table>

                    </div>
                </div>
                <!-------------- A PARTIR DE ESTE MOMENTO INICIA EL TERCER PANEL--------------------------------------------------------------------------------------------->
                <div id="Segundo_div">
                    <div id="javascript-tab" class="tab-content">
                        <div style="display: none">
                            <h3 class="Titulos">REGLETA COMERCIAL VIGENTE</h3>
                            <asp:UpdatePanel runat="server">
                                <ContentTemplate>
                                    <asp:Panel CssClass="panel_informativo" ID="Panel12" runat="server" GroupingText="Variables de Busqueda">

                                        <table class="tabla">
                                            <tr>
                                                <td>
                                                    <asp:Label CssClass="texto_informativo" ID="Label46" runat="server" Text="Ciudad Cliente"></asp:Label>
                                                    <br />
                                                    <asp:DropDownList CssClass="dropdown1" ID="R_Ciudad_Cliente" runat="server" OnSelectedIndexChanged="R_Ciudad_Cliente_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                                                </td>
                                                <td>
                                                    <asp:Label CssClass="texto_informativo" ID="Label47" runat="server" Text="Estrato Cliente"></asp:Label>
                                                    <br />
                                                    <asp:DropDownList CssClass="dropdown1" ID="R_Estrato_Cliente" runat="server" OnSelectedIndexChanged="R_Estrato_Cliente_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                                                </td>
                                                <td>
                                                    <asp:Label CssClass="texto_informativo" ID="Label48" runat="server" Text="Tipo de Regleta"></asp:Label><br />
                                                    <asp:DropDownList CssClass="dropdown2" ID="R_Tipo_Regleta" runat="server" OnSelectedIndexChanged="R_Tipo_Regleta_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                                                    <br />
                                                </td>
                                                <asp:UpdatePanel ID="UpdatePanel12" runat="server">
                                                    <ContentTemplate>
                                                        <td>
                                                            <asp:Button CssClass="button" ID="R_Limpiar" runat="server" Text="Limpiar" OnClick="R_Limpiar_Click" />
                                                        </td>
                                                    </ContentTemplate>
                                                </asp:UpdatePanel>
                                            </tr>

                                        </table>


                                    </asp:Panel>


                                    <asp:Panel CssClass="panel_informativo" ID="Panel11" runat="server" GroupingText="Tarifas Disponibles">

                                        <div class="note">
                                            <p class="paquete">PAQUETES TRIPLES</p>
                                            <asp:RadioButtonList ID="Lista_Paquetes_Triples" runat="server" OnSelectedIndexChanged="Lista_Paquetes_Triples_SelectedIndexChanged" AutoPostBack="true"></asp:RadioButtonList>

                                        </div>
                                        <div class="note2">
                                            <p class="paquete">PAQUETES DOBLES</p>
                                            <asp:RadioButtonList ID="Lista_Paquetes_Dobles" runat="server" OnSelectedIndexChanged="Lista_Paquetes_Dobles_SelectedIndexChanged" AutoPostBack="true"></asp:RadioButtonList>
                                        </div>
                                        <div class="note3">
                                            <p class="paquete">PAQUETES SENCILLOS</p>
                                            <asp:RadioButtonList ID="Lista_Paquetes_Sencillos" runat="server" OnSelectedIndexChanged="Lista_Paquetes_Sencillos_SelectedIndexChanged" AutoPostBack="true"></asp:RadioButtonList>

                                        </div>
                                        <div class="talkbubble">
                                            <p class="paquete">VALOR DEL PAQUETE</p>
                                            <asp:Label CssClass="Valor_Tarifa" ID="Valor_Paquete" runat="server" Text=""></asp:Label>
                                        </div>

                                    </asp:Panel>
                                    <asp:Panel CssClass="panel_informativo" ID="Panel13" runat="server" GroupingText="Detalle Tarifa Seleccionada">
                                        <table class="tabla">
                                            <tr>
                                                <td>
                                                    <asp:GridView CssClass="mGrid2" ID="DETALLE_TARIFA_1" runat="server" AutoGenerateColumns="False">
                                                        <Columns>
                                                            <asp:BoundField DataField="CODIGO_TARIFA_RESIDENCIAL" HeaderText="CODIGO TARIFA RESIDENCIAL" />
                                                            <asp:BoundField DataField="CODIGO_TARIFA_SOHO" HeaderText="CODIGO TARIFA SOHO" />
                                                            <asp:BoundField DataField="TIPO_TV" HeaderText="TIPO TV" />
                                                            <asp:BoundField DataField="INTERNET" HeaderText="INTERNET" />
                                                            <asp:BoundField DataField="VOZ" HeaderText="VOZ" />
                                                            <asp:BoundField DataField="TARIFA_TV" HeaderText="TARIFA TV" />
                                                            <asp:BoundField DataField="TARIFA_CLARO_VIDEO" HeaderText="TARIFA CLARO VIDEO" />
                                                            <asp:BoundField DataField="TARIFA_INTERNET" HeaderText="TARIFA INTERNET" />
                                                            <asp:BoundField DataField="TARIFA_VOZ" HeaderText="TARIFA VOZ" />
                                                            <asp:BoundField DataField="TOTAL_TARIFA" HeaderText="TOTAL TARIFA" />
                                                            <asp:BoundField DataField="TARIFA_PROMO" HeaderText="TARIFA PROMO" />
                                                            <asp:BoundField DataField="CAMPANA" HeaderText="CAMPANA" />
                                                        </Columns>
                                                    </asp:GridView>
                                                    <asp:GridView CssClass="mGrid2" ID="DETALLE_TARIFA_2" runat="server" AutoGenerateColumns="False">
                                                        <Columns>
                                                            <asp:BoundField DataField="HD" HeaderText="HD" />
                                                            <asp:BoundField DataField="PVR" HeaderText="PVR" />
                                                            <asp:BoundField DataField="CLARO_VIDEO" HeaderText="CLARO VIDEO" />
                                                            <asp:BoundField DataField="TV_PLAYER" HeaderText="TV PLAYER" />
                                                            <asp:BoundField DataField="DECOS" HeaderText="DECOS" />
                                                            <asp:BoundField DataField="DETALLE_DECOS" HeaderText="DETALLE DECOS" />
                                                            <asp:BoundField DataField="DESCUENTO_HD" HeaderText="DESCUENTO HD" />
                                                            <asp:BoundField DataField="DESCUENTO_PVR" HeaderText="DESCUENTO PVR" />
                                                            <asp:BoundField DataField="TARIFA_HD" HeaderText="TARIFA HD" />
                                                            <asp:BoundField DataField="TARIFA_PVR" HeaderText="TARIFA PVR" />
                                                            <asp:BoundField DataField="TARIFA_HBO_FOX" HeaderText="TARIFA HBO FOX" />
                                                            <asp:BoundField DataField="SEGUNDA_LINEA" HeaderText="SEGUNDA LINEA" />
                                                        </Columns>
                                                    </asp:GridView>
                                                </td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                    <asp:Panel CssClass="panel_informativo" ID="Panel14" runat="server" GroupingText="Servicios Adicionales">
                                        <table class="tabla">
                                            <tr>
                                                <td>
                                                    <asp:GridView CssClass="mGrid2" ID="DETALLE_REGLETA_AD" runat="server" AutoGenerateColumns="False">

                                                        <Columns>
                                                            <asp:BoundField DataField="NOMBRE_TARIFA" HeaderText="NOMBRE TARIFA" />
                                                            <asp:BoundField DataField="RENTA_TOTAL" HeaderText="RENTA TOTAL" />
                                                        </Columns>

                                                    </asp:GridView>
                                                </td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>
                    </div>
                </div>
            </div>
        </asp:Panel>
    </div>
    <div id="Contenedor_Paneles2">
        <asp:Panel CssClass="panel2" ID="Panel2" runat="server">
            <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                <ContentTemplate>
                    <!--A PARTIR DE AQUI INICIA EL HISTORICO DE CASOS -->


                    <script type="text/javascript">
                        function editar(obj) {

                            var imageID = document.getElementById('imagen' + obj);
                            window.location.href = 'Actualizar_Casos.aspx?id=' + obj;

                        };
                    </script>
                    <div id="tab-container1">
                        <asp:Panel CssClass="panel2" ID="Panel15" runat="server">
                            <ul class="tab-menu1">

                                <li id="Li1" class="active" onclick="otorgar_permisos2()">HISTÓRICO DE CASOS</li>
                                <%--<li id="Li2" onclick="otorgar_permisos2()">ULTIMAS MARCACIONES-PQRS</li>
                            <li id="Li3" onclick="otorgar_permisos2()">ORDENES DE TRABAJO ABIERTAS</li>--%>
                            </ul>

                            <div class="clear"></div>
                            <div class="tab-top-border"></div>
                            <div id="Tercer_div">

                                <div id="Li1-tab" class="tab-content1 active">

                                    <table class="tabla">
                                        <tr>
                                            <td>
                                                <div class="Titulo_Usuarios5">
                                                    <p class="etiquetas5">Casos Abiertos:</p>
                                                </div>
                                            </td>
                                        </tr>
                                    </table>
                                    <asp:GridView CssClass="mGrid" ID="GVINGRESOS" runat="server" DataKeyNames="ID INGRESO" AutoGenerateColumns="False" Width="50%" AllowPaging="True" PageSize="5" OnPageIndexChanging="GVINGRESOS_PageIndexChanging">
                                        <Columns>
                                            <asp:TemplateField ShowHeader="False" HeaderText="EDITAR">
                                                <ItemTemplate>
                                                    <a href='javascript:editar("<%# Eval("ID INGRESO") %>");'>
                                                        <img class="c1" id='imageningreso_<%# Eval("ID INGRESO") %>' alt="Clic para mostrar u ocultar" src="Estilos/Imagenes/edita.png" />
                                                    </a>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:BoundField DataField="ID INGRESO" HeaderText="ID INGRESO" />
                                            <asp:BoundField DataField="TICKET" HeaderText="TICKET" />
                                            <asp:BoundField DataField="FECHA APERTURA" HeaderText="FECHA APERTURA" />
                                            <asp:BoundField DataField="HORA APERTURA" HeaderText="HORA APERTURA" />
                                            <asp:BoundField DataField="USUARIO APERTURA" HeaderText="USUARIO APERTURA" />
                                            <asp:BoundField DataField="FECHA ULTIMA ACTUALIZACION" HeaderText="FECHA ULTIMA ACTUALIZACION" />
                                            <asp:BoundField DataField="HORA ULTIMA ACTUALIZACION" HeaderText="HORA ULTIMA ACTUALIZACION" />
                                            <asp:BoundField DataField="USUARIO ULTIMA ACTUALIZACION" HeaderText="USUARIO ULTIMA ACTUALIZACION" />
                                            <asp:BoundField DataField="MACROPROCESO" HeaderText="MACROPROCESO" />
                                            <asp:BoundField DataField="MARCACION" HeaderText="MARCACION" />
                                            <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" />
                                            <asp:TemplateField Visible="False"></asp:TemplateField>
                                            <asp:ImageField DataImageUrlField="SEMAFORO" DataImageUrlFormatString="~/Estilos/Imagenes/{0}" HeaderText="SEMAFORO" ItemStyle-HorizontalAlign="Center" ControlStyle-Width="20px">
                                                <ControlStyle Width="20px"></ControlStyle>

                                                <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                            </asp:ImageField>

                                        </Columns>

                                    </asp:GridView>
                                    <table class="tabla">
                                        <tr>
                                            <td>
                                                <div class="Titulo_Usuarios5">
                                                    <p class="etiquetas5">Casos Cerrados:</p>
                                                </div>
                                            </td>
                                        </tr>
                                    </table>

                                    <asp:GridView CssClass="mGrid" ID="GVINGRESOS2" runat="server" AutoGenerateColumns="False" DataKeyNames="ID INGRESO" Width="50%" AllowPaging="True" PageSize="5" OnPageIndexChanging="GVINGRESOS2_PageIndexChanging">
                                        <Columns>
                                            <asp:TemplateField ShowHeader="False" HeaderText="EDITAR">
                                                <ItemTemplate>
                                                    <a href='javascript:editar("<%# Eval("ID INGRESO") %>");'>
                                                        <img class="c1" id='imageningreso_<%# Eval("ID INGRESO") %>' alt="Clic para mostrar u ocultar" src="Estilos/Imagenes/edita.png" />
                                                    </a>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:BoundField DataField="ID INGRESO" HeaderText="ID INGRESO" />
                                            <asp:BoundField DataField="TICKET" HeaderText="TICKET" />
                                            <asp:BoundField DataField="FECHA APERTURA" HeaderText="FECHA APERTURA" />
                                            <asp:BoundField DataField="HORA APERTURA" HeaderText="HORA APERTURA" />
                                            <asp:BoundField DataField="USUARIO APERTURA" HeaderText="USUARIO APERTURA" />
                                            <asp:BoundField DataField="FECHA ULTIMA ACTUALIZACION" HeaderText="FECHA ULTIMA ACTUALIZACION" />
                                            <asp:BoundField DataField="HORA ULTIMA ACTUALIZACION" HeaderText="HORA ULTIMA ACTUALIZACION" />
                                            <asp:BoundField DataField="USUARIO ULTIMA ACTUALIZACION" HeaderText="USUARIO ULTIMA ACTUALIZACION" />
                                            <asp:BoundField DataField="MACROPROCESO" HeaderText="MACROPROCESO" />
                                            <asp:BoundField DataField="MARCACION" HeaderText="MARCACION" />
                                            <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" />
                                            <asp:TemplateField Visible="False"></asp:TemplateField>
                                            <asp:ImageField DataImageUrlField="SEMAFORO" DataImageUrlFormatString="~/Estilos/Imagenes/{0}" HeaderText="SEMAFORO" ItemStyle-HorizontalAlign="Center" ControlStyle-Width="20px">
                                                <ControlStyle Width="20px"></ControlStyle>

                                                <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                            </asp:ImageField>

                                        </Columns>

                                    </asp:GridView>

                                </div>

                            </div>
                            <%--<div id="Cuarto_div">
                        <div id="Li2-tab" class="tab-content1">
                            ...
                        </div>
                        </div>

                        <div id="Quinto_div">
                        <div id="Li3-tab" class="tab-content1">
                            ....
                        </div>--%>
                        </asp:Panel>
                    </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>

        </asp:Panel>
    </div>
    <div class="modal-wrapper" id="Consulta_Cliente">
        <div class="Consulta_Cliente-contenedor">
            <a class="Consulta_Cliente-cerrar" href="#">X</a>
            <h2>Consulta de Clientes</h2>
            <hr />
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <p class="etiquetas">Identificación Cliente:</p>
                    <asp:TextBox CssClass="caja_de_texto" ID="Cedula_Consulta" runat="server" AutoPostBack="true" OnTextChanged="Cedula_Consulta_TextChanged"></asp:TextBox>
                    <hr />
                    <asp:GridView CssClass="mGrid2" ID="Resultado_Consulta_Cliente" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="Resultado_Consulta_Cliente_SelectedIndexChanged" DataKeyNames="CUENTA">
                        <Columns>
                            <asp:CommandField HeaderText="SELECCIONE" ShowSelectButton="True" />
                            <asp:BoundField DataField="CUENTA" HeaderText="CUENTA" />
                            <asp:BoundField DataField="NOMBRE_CLIENTE" HeaderText="NOMBRE DEL CLIENTE" />
                            <asp:BoundField DataField="CEDULA" HeaderText="CEDULA" />
                            <asp:BoundField DataField="TELEFONO_1" HeaderText="TELEFONO " />
                            <asp:BoundField DataField="DIR_INSTALACION" HeaderText="DIRECCION INSTALACION" />
                        </Columns>
                    </asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>

    <!-- A PARTIR DE AQUI INICIA EL TEMA DE AJUSTES-->

    <div class="modal-wrapper" id="Compensacion" style="display: none">
        <div class="Compensacion-contenedor">
            <a class="Compensacion-cerrar" href="#" onclick="return Cerrar_Ventana_Compensacion()">X</a>
            <h2>CALCULADORA DE AJUSTES - COMPENSACIÓN</h2>
            <hr />
            <div class="Texto_Informativo">Este ajuste por compensación únicamente se realiza en el momento en el que el cliente lo solicite, de lo contrario proceda a realizar un ajuste normal:</div>
            <hr />
            <asp:UpdatePanel runat="server">
                <ContentTemplate>

                    <asp:Button CssClass="button" ID="AC_Limpiar_Controles" runat="server" Text="Reiniciar Calculos" OnClick="AC_Limpiar_Controles_Click" />
                    <asp:Button ID="AC_Ejecutar_Aclculos" runat="server" Text="Button" OnClick="AC_Ejecutar_Aclculos_Click" Style="display: none" />
                    <a href="https://comunidadvirtual.claro.com.co/www/lms/Biblioteca/Documentos/others/M_Servicio/Residencial/Boletines/Comunicados%20-%202016/c905/index.html" target="_blank">
                        <div class="politicas"></div>
                    </a>
                </ContentTemplate>
            </asp:UpdatePanel>
            <hr />
            <div id="AC_Panel_1">
                <div class="Texto_Informativo2">¿La cuenta fue desconectada injustificadamente?</div>
                <table class="tabla2">
                    <tr>
                        <td>
                            <asp:RadioButton CssClass="radiobutton" ID="AC_Radio_1" runat="server" GroupName="1" Text="  SI" />
                        </td>
                        <td>
                            <asp:RadioButton CssClass="radiobutton" ID="AC_Radio_2" runat="server" Text="  NO" GroupName="1" />
                        </td>
                    </tr>
                </table>
            </div>

            <div id="AC_Panel_2" style="display: none">
                <div class="Texto_Informativo2">¿La cuenta presento fallas tecnicas?</div>
                <table class="tabla2">
                    <tr>
                        <td>
                            <asp:RadioButton CssClass="radiobutton" ID="AC_Radio_3" runat="server" GroupName="2" Text="  SI" />
                        </td>
                        <td>
                            <asp:RadioButton CssClass="radiobutton" ID="AC_Radio_4" runat="server" Text="  NO" GroupName="2" />
                        </td>
                    </tr>
                </table>
                <hr />
            </div>

            <div id="AC_Panel_3" style="display: none">
                <div class="Texto_Informativo2">¿El equipo terminal presento fallas?</div>
                <table class="tabla2">
                    <tr>
                        <td>
                            <asp:RadioButton CssClass="radiobutton" ID="AC_Radio_5" runat="server" GroupName="3" Text="  SI" />
                        </td>
                        <td>
                            <asp:RadioButton CssClass="radiobutton" ID="AC_Radio_6" runat="server" Text="  NO" GroupName="3" />
                        </td>
                    </tr>
                </table>
                <hr />
            </div>

            <div id="AC_Panel_Calculos" style="display: none">
                <hr />
                <div class="numeros">1</div>
                <hr />
                <div class="Texto_Informativo">Inicialmente debes ingresar las fechas y horas de la afectacion:</div>
                <table>
                    <tr>
                        <td>
                            <asp:Label CssClass="Motivo_Ajuste" ID="Label60" runat="server" Text="Fecha y Hora Inicial:"></asp:Label><br />
                            <asp:TextBox ID="AC_C1_Fecha_Inicial" runat="server" Style="display: none" Enabled="false"></asp:TextBox>
                            <input class="caja_de_texto" type="text" value="" id="AC_Fecha_CI1_Inicial" autocomplete="off" onchange="return AC_C1_Traer_Fecha_Inicial()" placeholder="Select date" />

                        </td>
                        <td>

                            <asp:Label CssClass="Motivo_Ajuste" ID="Label61" runat="server" Text="Fecha y Hora Final:"></asp:Label><br />
                            <asp:TextBox ID="AC_C1_Fecha_Final" runat="server" Style="display: none" Enabled="false"></asp:TextBox>
                            <input class="caja_de_texto" type="text" value="" id="AC_Fecha_CI1_Final" autocomplete="off" onchange="return AC_C1_Traer_Fecha_Final()" placeholder="Select date" />

                        </td>

                    </tr>
                </table>
                <asp:UpdatePanel ID="AC_Update_2" runat="server">
                    <ContentTemplate>

                        <table>
                            <tr>
                                <td>
                                    <asp:Label CssClass="Motivo_Ajuste" ID="Label71" runat="server" Text="Cantidad de Horas:"></asp:Label><br />
                                    <asp:TextBox CssClass="caja_de_texto" ID="AC_C1_Cantidad_Horas" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label CssClass="Motivo_Ajuste" ID="Label72" runat="server" Text="Cantidad de Días:"></asp:Label><br />
                                    <asp:TextBox CssClass="caja_de_texto" ID="AC_C1_Cantidad_Das" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <hr />
                <div id="AC_Calculos" style="display: none">
                    <div class="numeros">2</div>
                    <hr />
                    <div class="Texto_Informativo">Seleccione los servicios afectados:</div>
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                            <table class="tabla2">
                                <tr>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="AC_Internet" runat="server" AutoPostBack="true" OnCheckedChanged="AC_Internet_CheckedChanged" />
                                            <asp:Label ID="Label73" AssociatedControlID="AC_Internet" runat="server"
                                                Text="INTERNET" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="AC_Telefonia" runat="server" AutoPostBack="true" OnCheckedChanged="AC_Telefonia_CheckedChanged" />
                                            <asp:Label ID="Label74" AssociatedControlID="AC_Telefonia" runat="server"
                                                Text="TELEFONIA" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                            </table>
                            <hr />
                            <div class="numeros">3</div>
                            <hr />
                            <div class="Texto_Informativo">Ingrese la renta de los servicios afectados:</div>
                            <table class="tabla">
                                <tr>
                                    <td>
                                        <asp:Label CssClass="Motivo_Ajuste" ID="Label75" runat="server" Text="Renta Internet:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="AC_Renta_Internet" runat="server" Enabled="false" Text="0" OnTextChanged="AC_Renta_Internet_TextChanged" onBlur="AC_Renta_Internet_TextChanged" AutoPostBack="true"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="Motivo_Ajuste" ID="Label76" runat="server" Text="Renta Telefonía:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="AC_Renta_Telefonia" runat="server" Enabled="false" Text="0" OnTextChanged="AC_Renta_Telefonia_TextChanged" onBlur="AC_Renta_Telefonia_TextChanged" AutoPostBack="true"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>

                            <hr />
                            <div class="numeros">4</div>
                            <hr />
                            <div class="Texto_Informativo">A continuación se muestra el resumen del calculo de los ajustes:</div>
                            <table class="tabla2">
                                <tr>
                                    <td colspan="5">
                                        <p class="Motivo_Ajuste2">EL AJUSTE POR COMPENSACION DE INTERNET ES:</p>
                                    </td>
                                    <td>
                                        <div class="Caja_de_Texto_Ajustes_Disputa_Compensacion">
                                            <asp:Label CssClass="Valor_Ajuste_Compensacion" ID="AC_APCI" runat="server" Text="0" ForeColor="White"></asp:Label>
                                        </div>
                                    </td>
                                    <td colspan="5">
                                        <p class="Motivo_Ajuste2">&larr; VALOR A COMPENSAR - NO GENERA DISPUTA</p>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="5">
                                        <p class="Motivo_Ajuste2">EL AJUSTE POR COMPENSACION DE TELEFONIA ES:</p>
                                    </td>
                                    <td>
                                        <div class="Caja_de_Texto_Ajustes_Disputa_Compensacion">
                                            <asp:Label CssClass="Valor_Ajuste_Compensacion" ID="AC_APCV" runat="server" Text="0" ForeColor="White"></asp:Label>
                                        </div>
                                    </td>
                                    <td colspan="5">
                                        <p class="Motivo_Ajuste2">&larr; VALOR A COMPENSAR - NO GENERA DISPUTA</p>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="5">
                                        <p class="Motivo_Ajuste2">EL AJUSTE POR FALLAS EN EL SERVICIO DE INTERNET ES DE:</p>
                                    </td>
                                    <td>
                                        <div class="Caja_de_Texto_Ajustes_Disputa_Compensacion">
                                            <asp:Label CssClass="Valor_Ajuste_Compensacion" ID="AC_APFI" runat="server" Text="0" ForeColor="White"></asp:Label>
                                        </div>
                                    </td>
                                    <td colspan="5">
                                        <p class="Motivo_Ajuste2">&larr; VALOR A AJUSTAR - GENERA DISPUTA</p>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="5">
                                        <p class="Motivo_Ajuste2">EL AJUSTE POR FALLAS EN EL SERVICIO DE TELEFONIA ES DE:</p>
                                    </td>
                                    <td>
                                        <div class="Caja_de_Texto_Ajustes_Disputa_Compensacion">
                                            <asp:Label CssClass="Valor_Ajuste_Compensacion" ID="AC_APFV" runat="server" Text="0" ForeColor="White"></asp:Label>
                                        </div>
                                    </td>
                                    <td colspan="5">
                                        <p class="Motivo_Ajuste2">&larr; VALOR A AJUSTAR - GENERA DISPUTA</p>
                                    </td>
                                </tr>
                            </table>
                            <hr />
                            <div class="numeros">5</div>
                            <hr />
                            <div class="Texto_Informativo">La siguiente es la nota que debes copiar y pegar en la herramienta RR (AS400) en las notas F7 dentro de la carpeta de Ajustes, si no existe la carpeta debes crearla:</div>
                            <asp:TextBox CssClass="AC_Notas" ID="AC_Notas" runat="server" TextMode="MultiLine"></asp:TextBox>

                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>

            </div>
            <div id="AC_Aviso_1" class="Texto_Informativo3" style="display: none">Esta solicitud no aplica para ajuste por compensacion, ya que debe superar las 7 horas de afectacion, porfavor continue con la siguiente condicion</div>
            <div id="AC_Aviso_2" class="Texto_Informativo3" style="display: none">Esta solicitud no aplica para ajuste por compensacion, ya que debe superar las 48 horas de afectacion, porfavor continue con la siguiente condicion</div>
            <div id="AC_Aviso_3" class="Texto_Informativo3" style="display: none">Esta solicitud no aplica para ajuste por compensacion, ya que debe superar las 48 horas de afectacion, porfavor valide y escale ajuste simple</div>
            <div id="AC_Aviso_4" class="Texto_Informativo3" style="display: none">No aplica compensacion, por favor valide y segun proceso escale ajuste simple</div>
            <script>
                $('#AC_Fecha_CI1_Inicial').datetimepicker({
                    dateformat: 'd/m/Y 00:00',
                    maxDate: '+0d',
                    timepicker: true,
                    step: 1
                });

                $('#AC_Fecha_CI1_Final').datetimepicker({
                    dateformat: 'd/m/Y 00:00',
                    onShow: function (ct) {
                        this.setOptions({
                            minDate: $('#AC_Fecha_CI1_Inicial').val() ? $('#AC_Fecha_CI1_Inicial').val() : false
                        })
                    },
                    maxDate: '+0d',
                    timepicker: true,
                    step: 1
                });
            </script>
            <script>
                function AC_C1_Traer_Fecha_Inicial() {
                    var fecha = document.getElementById('AC_Fecha_CI1_Inicial').value;
                    document.getElementById("<%= AC_C1_Fecha_Inicial.ClientID %>").value = fecha;
                }
            </script>
            <script>
                function AC_C1_Traer_Fecha_Final() {
                    var fecha = document.getElementById('AC_Fecha_CI1_Final').value;
                    document.getElementById("<%= AC_C1_Fecha_Final.ClientID %>").value = fecha;

                    var bt1 = document.getElementById("<%= AC_Ejecutar_Aclculos.ClientID %>");
                    bt1.click();
                }
            </script>
            <script type="text/javascript">
                function Mostrar_Aviso_Rechazo_1() {
                    document.getElementById('AC_Aviso_1').style.display = 'block';
                    document.getElementById('AC_Aviso_2').style.display = 'none';
                    document.getElementById('AC_Aviso_3').style.display = 'none';
                    document.getElementById('AC_Aviso_4').style.display = 'none';
                    document.getElementById('AC_Calculos').style.display = 'none';

                }
            </script>
            <script type="text/javascript">
                function Mostrar_Aviso_Rechazo_2() {
                    document.getElementById('AC_Aviso_1').style.display = 'none';
                    document.getElementById('AC_Aviso_2').style.display = 'none';
                    document.getElementById('AC_Aviso_3').style.display = 'none';
                    document.getElementById('AC_Aviso_4').style.display = 'none';
                    document.getElementById('AC_Calculos').style.display = 'block';
                }
            </script>
            <script type="text/javascript">
                function Mostrar_Aviso_Rechazo_3() {
                    document.getElementById('AC_Aviso_2').style.display = 'block';
                    document.getElementById('AC_Aviso_1').style.display = 'none';
                    document.getElementById('AC_Aviso_3').style.display = 'none';
                    document.getElementById('AC_Aviso_4').style.display = 'none';
                    document.getElementById('AC_Calculos').style.display = 'none';

                }
            </script>
            <script type="text/javascript">
                function Mostrar_Aviso_Rechazo_4() {
                    document.getElementById('AC_Aviso_2').style.display = 'none';
                    document.getElementById('AC_Aviso_1').style.display = 'none';
                    document.getElementById('AC_Aviso_3').style.display = 'none';
                    document.getElementById('AC_Aviso_4').style.display = 'none';
                    document.getElementById('AC_Calculos').style.display = 'block';
                }
            </script>
            <script type="text/javascript">
                function Mostrar_Aviso_Rechazo_5() {
                    document.getElementById('AC_Aviso_3').style.display = 'block';
                    document.getElementById('AC_Aviso_2').style.display = 'none';
                    document.getElementById('AC_Aviso_1').style.display = 'none';
                    document.getElementById('AC_Aviso_4').style.display = 'none';
                    document.getElementById('AC_Calculos').style.display = 'none';

                }
            </script>
            <script type="text/javascript">
                function Mostrar_Aviso_Rechazo_6() {
                    document.getElementById('AC_Aviso_3').style.display = 'none';
                    document.getElementById('AC_Aviso_2').style.display = 'none';
                    document.getElementById('AC_Aviso_1').style.display = 'none';
                    document.getElementById('AC_Aviso_4').style.display = 'none';
                    document.getElementById('AC_Calculos').style.display = 'block';

                }
            </script>
            <script type="text/javascript">
                function AC_Limpiar_Controles() {
                    document.getElementById('AC_Panel_1').style.display = 'block';
                    document.getElementById('AC_Panel_2').style.display = 'none';
                    document.getElementById('AC_Panel_3').style.display = 'none';
                    document.getElementById('AC_Panel_Calculos').style.display = 'none';
                    document.getElementById('AC_Aviso_1').style.display = 'none';
                    document.getElementById('AC_Aviso_2').style.display = 'none';
                    document.getElementById('AC_Aviso_3').style.display = 'none';
                    document.getElementById('AC_Aviso_4').style.display = 'none';
                    document.getElementById('AC_Calculos').style.display = 'none';

                    document.getElementById('<%=AC_Radio_1.ClientID%>').checked = false;
                    document.getElementById('<%=AC_Radio_2.ClientID%>').checked = false;
                    document.getElementById('<%=AC_Radio_3.ClientID%>').checked = false;
                    document.getElementById('<%=AC_Radio_4.ClientID%>').checked = false;
                    document.getElementById('<%=AC_Radio_5.ClientID%>').checked = false;
                    document.getElementById('<%=AC_Radio_6.ClientID%>').checked = false;

                    document.getElementById('AC_Fecha_CI1_Inicial').value = "";
                    document.getElementById('AC_Fecha_CI1_Final').value = "";
                }
            </script>
            <script type="text/javascript">
                function Abrir_Ventana_Compensacion() {
                    document.getElementById('Compensacion').style.display = 'block';

                }
            </script>
            <script type="text/javascript">
                function Cerrar_Ventana_Compensacion() {
                    document.getElementById('Compensacion').style.display = 'block';

                }
            </script>
            <script type="text/javascript">
                function AC_Abrir_Primer_Calculo() {
                    document.getElementById('AC_Panel_Calculos').style.display = 'block';

                }
            </script>

            <script type="text/javascript">
                function AC_Cerrar_Primer_Calculo() {
                    document.getElementById('AC_Panel_1').style.display = 'none';
                    document.getElementById('AC_Panel_Calculos').style.display = 'none';
                    document.getElementById('AC_Panel_2').style.display = 'block';
                    document.getElementById('AC_Calculos').style.display = 'none';
                    document.getElementById('AC_Aviso_1').style.display = 'none';
                    document.getElementById('AC_Aviso_2').style.display = 'none';
                    document.getElementById('AC_Aviso_3').style.display = 'none';

                    document.getElementById('<%=AC_Radio_3.ClientID%>').checked = false;
                    document.getElementById('<%=AC_Radio_4.ClientID%>').checked = false;
                    document.getElementById('<%=AC_Radio_5.ClientID%>').checked = false;
                    document.getElementById('<%=AC_Radio_6.ClientID%>').checked = false;
                }
            </script>
            <script type="text/javascript">
                function AC_Abrir_Segundo_Calculo() {
                    document.getElementById('AC_Panel_1').style.display = 'none';
                    document.getElementById('AC_Panel_Calculos').style.display = 'block';
                    document.getElementById('AC_Calculos').style.display = 'none';
                    document.getElementById('<%=AC_Radio_1.ClientID%>').checked = false;
                    document.getElementById('<%=AC_Radio_2.ClientID%>').checked = false;
                    document.getElementById('<%=AC_Radio_5.ClientID%>').checked = false;
                    document.getElementById('<%=AC_Radio_6.ClientID%>').checked = false;
                }
            </script>
            <script type="text/javascript">
                function AC_Cerrar_Segundo_Calculo() {
                    document.getElementById('AC_Panel_2').style.display = 'none';
                    document.getElementById('AC_Panel_1').style.display = 'none';
                    document.getElementById('AC_Panel_Calculos').style.display = 'none';
                    document.getElementById('AC_Panel_3').style.display = 'block';
                    document.getElementById('AC_Calculos').style.display = 'none';
                    document.getElementById('AC_Aviso_1').style.display = 'none';
                    document.getElementById('AC_Aviso_2').style.display = 'none';
                    document.getElementById('AC_Aviso_3').style.display = 'none';

                    document.getElementById('<%=AC_Radio_1.ClientID%>').checked = false;
                    document.getElementById('<%=AC_Radio_2.ClientID%>').checked = false;
                    document.getElementById('<%=AC_Radio_3.ClientID%>').checked = false;
                    document.getElementById('<%=AC_Radio_4.ClientID%>').checked = false;
                }
            </script>
            <script type="text/javascript">
                function AC_Abrir_Tercer_Calculo() {
                    document.getElementById('AC_Panel_1').style.display = 'none';
                    document.getElementById('AC_Panel_2').style.display = 'none';
                    document.getElementById('AC_Panel_Calculos').style.display = 'block';
                    document.getElementById('AC_Calculos').style.display = 'none';

                    document.getElementById('<%=AC_Radio_1.ClientID%>').checked = false;
                    document.getElementById('<%=AC_Radio_2.ClientID%>').checked = false;
                    document.getElementById('<%=AC_Radio_3.ClientID%>').checked = false;
                    document.getElementById('<%=AC_Radio_4.ClientID%>').checked = false;
                }
            </script>
            <script type="text/javascript">
                function AC_Cerrar_Tercer_Calculo() {
                    document.getElementById('AC_Panel_1').style.display = 'none';
                    document.getElementById('AC_Panel_2').style.display = 'none';
                    document.getElementById('AC_Panel_3').style.display = 'none';
                    document.getElementById('AC_Panel_Calculos').style.display = 'none';
                    document.getElementById('AC_Aviso_4').style.display = 'block';
                    document.getElementById('AC_Calculos').style.display = 'none';
                    document.getElementById('AC_Aviso_1').style.display = 'none';
                    document.getElementById('AC_Aviso_2').style.display = 'none';
                    document.getElementById('AC_Aviso_3').style.display = 'none';

                    document.getElementById('<%=AC_Radio_1.ClientID%>').checked = false;
                    document.getElementById('<%=AC_Radio_2.ClientID%>').checked = false;
                    document.getElementById('<%=AC_Radio_3.ClientID%>').checked = false;
                    document.getElementById('<%=AC_Radio_4.ClientID%>').checked = false;
                    document.getElementById('<%=AC_Radio_5.ClientID%>').checked = false;
                    document.getElementById('<%=AC_Radio_6.ClientID%>').checked = false;
                }
            </script>

        </div>

    </div>

    <!--A PARTIR DE AQUI ES EL SIGUIENTE CALCULO -->

    <div class="modal-wrapper" id="Diferencia_Tarifas" style="display: none">
        <div class="Diferencia_Tarifas-contenedor">
            <a class="Diferencia_Tarifas-cerrar" href="#" onclick="return Cerrar_Ventana_Diferencia_Tarifas()">X</a>
            <h2>CALCULADORA DE AJUSTES - DIFERENCIA DE TARIFAS</h2>
            <hr />
            <asp:Button CssClass="button" ID="Button1" runat="server" Text="Limpiar" OnClick="Button1_Click" />
            <a href="https://comunidadvirtual.claro.com.co/www/lms/Biblioteca/Documentos/others/M_Servicio/Residencial/Boletines/Comunicados%20-%202016/c905/index.html" target="_blank">
                <div class="politicas"></div>
            </a>
            <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                <ContentTemplate>
                    <asp:Button CssClass="button" ID="ADT_Cargar_Datos" runat="server" Text="Cargar_Datos" OnClick="ADT_Cargar_Datos_Click" Style="display: none" />
                    <asp:Table runat="server">
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="1">
                                <asp:Label CssClass="Motivo_Ajuste" ID="Label50" runat="server" Text="Nombre del Cliente:"></asp:Label><br />
                                <asp:TextBox ID="ADT_Nombre_Cliente" runat="server" Enabled="false"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell ColumnSpan="1">
                                <asp:Label CssClass="Motivo_Ajuste" ID="Label51" runat="server" Text="Apellido del Cliente:"></asp:Label><br />
                                <asp:TextBox ID="ADT_Apellido_Cliente" runat="server" Enabled="false"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>

                    </asp:Table>

                    <hr />
                    <div class="numeros">1</div>
                    <hr />
                    <div class="Texto_Informativo">Inicialmente debemos ingresar los valores que el cliente factura en RR sin IVA, por cada uno de los servicios de acuerdo a la siguiente tabla:</div>
                    <table class="Tabla_Ajuste">
                        <tr>
                            <th>Servicio</th>
                            <th>Valor Sin Iva</th>
                            <th>Iva del Servicio</th>
                            <th>Valor con Iva</th>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">TELEVISION</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="ADT_VT_SI" runat="server" AutoCompleteType="None" OnTextChanged="ADT_VT_SI_TextChanged" AutoPostBack="true" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VT_I" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VT_VT" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">INTERNET</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="ADT_VI_SI" runat="server" AutoCompleteType="None" OnTextChanged="ADT_VI_SI_TextChanged" AutoPostBack="true" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VI_I" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VI_VT" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">TELEFONIA</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="ADT_VV__SI" runat="server" AutoCompleteType="None" OnTextChanged="ADT_VV__SI_TextChanged" AutoPostBack="true" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VV_I" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VV_VT" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">FUNCIONALIDADES</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="ADT_VF_SI" runat="server" AutoCompleteType="None" OnTextChanged="ADT_VF_SI_TextChanged" AutoPostBack="true" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VF_I" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VF_VT" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">LD 30</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="ADT_VLD_SI" runat="server" AutoCompleteType="None" OnTextChanged="ADT_VLD_SI_TextChanged" AutoPostBack="true" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VLD_I" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VLD_VT" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">REVISTA</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="ADT_VR_SI" runat="server" AutoCompleteType="None" OnTextChanged="ADT_VR_SI_TextChanged" AutoPostBack="true" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VR_I" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VR_VT" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">HBO</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="ADT_VHB_SI" runat="server" AutoCompleteType="None" OnTextChanged="ADT_VHB_SI_TextChanged" AutoPostBack="true" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VHB_I" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VHB_VT" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">MOVIE PACK</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="ADT_VMP_SI" runat="server" AutoCompleteType="None" OnTextChanged="ADT_VMP_SI_TextChanged" AutoPostBack="true" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VMP_I" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VMP_VT" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">TELEVISION HD</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="ADT_VTHD_SI" runat="server" AutoCompleteType="None" OnTextChanged="ADT_VTHD_SI_TextChanged" AutoPostBack="true" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VTHD_I" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VTHD_VT" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">SPICE TV</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="ADT_VSP_SI" runat="server" AutoCompleteType="None" OnTextChanged="ADT_VSP_SI_TextChanged" AutoPostBack="true" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VSP_I" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VSP_VT" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">VENUS</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="ADT_VVNS_SI" runat="server" AutoCompleteType="None" OnTextChanged="ADT_VVNS_SI_TextChanged" AutoPostBack="true" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VVNS_I" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VVNS_VT" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">PVR - DECOS</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="ADT_VPVR_SI" runat="server" AutoCompleteType="None" OnTextChanged="ADT_VPVR_SI_TextChanged" AutoPostBack="true" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VPVR_I" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VPVR_VT" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">WIFI</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="ADT_VWIFI_SI" runat="server" AutoCompleteType="None" OnTextChanged="ADT_VWIFI_SI_TextChanged" AutoPostBack="true" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VWIFI_I" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VWIFI_VT" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">CLARO VIDEO</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="ADT_CLAROVIDEO_SI" runat="server" AutoCompleteType="None" OnTextChanged="ADT_CLAROVIDEO_SI_TextChanged" AutoPostBack="true" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_CLAROVIDEO_I" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_CLAROVIDEO_VT" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                    </table>
                    <asp:Label CssClass="Motivo_Ajuste" ID="Label49" runat="server" Text="Valor Facturado:"></asp:Label><br />
                    <asp:TextBox ID="ADT_Valor_Total_Facturado" runat="server" Text="0" AutoPostBack="true" OnTextChanged="ADT_Valor_Total_Facturado_TextChanged" Enabled="false"></asp:TextBox>
                    <br />
                    <div class="numeros">2</div>
                    <hr />
                    <div class="Texto_Informativo">Verifique por favor que el estrato del Home Pass coincida con el que se muestra a continuacion, de lo contrario modifiquelo.</div>

                    <asp:Label CssClass="Motivo_Ajuste" ID="Label52" runat="server" Text="Estrato:"></asp:Label><br />
                    <asp:TextBox ID="ADT_Estrato_Cliente" runat="server" OnTextChanged="ADT_Estrato_Cliente_TextChanged" AutoPostBack="true"></asp:TextBox>
                    <hr />

                    <div class="numeros">3</div>
                    <hr />
                    <div class="Texto_Informativo">A continuación ingrese el valor contratado por el cliente con IVA incluido:</div>

                    <asp:Label CssClass="Motivo_Ajuste" ID="Label53" runat="server" Text="Valor Contratado:"></asp:Label><br />
                    <asp:TextBox ID="ADT_Valor_Contratado" runat="server" OnTextChanged="ADT_Valor_Contratado_TextChanged" AutoPostBack="true" Text="0"></asp:TextBox>
                    <hr />
                    <div class="numeros">4</div>
                    <hr />
                    <div class="Texto_Informativo">Ingrese los valores del subsidio otorgado:</div>
                    <table>
                        <tr>
                            <td>
                                <asp:Label CssClass="Motivo_Ajuste" ID="Label54" runat="server" Text="Valor Subsidio @:"></asp:Label><br />
                                <asp:TextBox ID="ADT_Subcidio_Internet" runat="server" OnTextChanged="ADT_Subcidio_Internet_TextChanged" AutoPostBack="true" Text="0"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label CssClass="Motivo_Ajuste" ID="Label55" runat="server" Text="Valor Subsidio Voz:"></asp:Label><br />
                                <asp:TextBox ID="ADT_Subcidio_Voz" runat="server" OnTextChanged="ADT_Subcidio_Voz_TextChanged" AutoPostBack="true" Text="0"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                    <hr />
                    <div class="numeros2">!</div>
                    <hr />
                    <div class="Texto_Informativo">La diferencia de tarifa es:</div>

                    <asp:Label CssClass="Motivo_Ajuste" ID="Label56" runat="server" Text="Valor Diferencia:"></asp:Label><br />
                    <asp:TextBox ID="ADT_Valor_Diferencia" runat="server" Enabled="false"></asp:TextBox>
                </ContentTemplate>
            </asp:UpdatePanel>
            <hr />
            <script type="text/javascript">
                function Abrir_Periodo() {
                    document.getElementById('ADT_Tabla_Periodo_2').style.display = 'block';
                    document.getElementById('ADT_BT_Abrir_Perioto').style.display = 'none';
                    document.getElementById('ADT_BT_Cerrar_Periodo').style.display = 'block';
                    document.getElementById('ADT_Hr2').style.display = 'block';
                }
            </script>
            <script type="text/javascript">
                function Cerrar_Periodo() {
                    document.getElementById('ADT_Tabla_Periodo_2').style.display = 'none';
                    document.getElementById('ADT_BT_Abrir_Perioto').style.display = 'block';
                    document.getElementById('ADT_BT_Cerrar_Periodo').style.display = 'none';
                    document.getElementById('ADT_Hr2').style.display = 'none';
                }
            </script>
            <div class="numeros">5</div>
            <hr />
            <div class="Texto_Informativo">Ingrese las fechas segun corresponda, si el periodo es completo por favor seleccionelo del desplegable y agregue días del calendario de ser necesario, si el ajuste es entre dos meses, favor realizarlo agregando un nuevo periodo para hacer calculos independientes para cada mes:</div>
            <table>
                <tr>
                    <td>
                        <asp:Label CssClass="Motivo_Ajuste" ID="Label57" runat="server" Text="Fecha Inicial:"></asp:Label><br />
                        <asp:TextBox ID="CE_Fecha_Inicial" runat="server" Style="display: none"></asp:TextBox>
                        <input class="caja_de_texto" type="text" value="" id="CEH_Fecha_Inicial" autocomplete="off" onchange="return Traer_Fecha()" placeholder="Select date" />

                    </td>
                    <td class="auto-style21">
                        <asp:Label CssClass="Motivo_Ajuste" ID="Label58" runat="server" Text="Fecha Final:"></asp:Label><br />
                        <asp:TextBox ID="CE_Fecha_Final" runat="server" Style="display: none"></asp:TextBox>
                        <input class="caja_de_texto" type="text" value="" id="CEH_Fecha_Final" autocomplete="off" onchange="return Traer_Fecha_Final()" placeholder="Select date" />

                    </td>
                    <td>
                        <div id="ADT_BT_Abrir_Perioto">
                            <a onclick="return Abrir_Periodo()">
                                <div class="Imagen_Periodo"></div>
                            </a>
                        </div>
                        <div id="ADT_BT_Cerrar_Periodo" style="display: none">
                            <a onclick="return Cerrar_Periodo()">
                                <div class="Imagen_Periodo2"></div>
                            </a>
                        </div>
                    </td>
                </tr>
            </table>
            <hr />
            <div id="ADT_Tabla_Periodo_2" style="display: none">
                <table>
                    <tr>
                        <td>
                            <asp:Label CssClass="Motivo_Ajuste" ID="Label65" runat="server" Text="Fecha Inicial 2° Periodo:"></asp:Label><br />
                            <asp:TextBox ID="ADT_Fecha_Inicial" runat="server" Style="display: none"></asp:TextBox>
                            <input class="caja_de_texto" type="text" value="" id="ADT_Fecha_Inicial_Im" autocomplete="off" onchange="return Traer_Fecha_Inicial_2_Periodo()" placeholder="Select date" />

                        </td>
                        <td class="auto-style21">
                            <asp:Label CssClass="Motivo_Ajuste" ID="Label66" runat="server" Text="Fecha Final 2° Periodo:"></asp:Label><br />
                            <asp:TextBox ID="ADT_Fecha_Final" runat="server" Style="display: none"></asp:TextBox>
                            <input class="caja_de_texto" type="text" value="" id="ADT_Fecha_Final_Im" autocomplete="off" onchange="return Traer_Fecha_Final_2_Periodo()" placeholder="Select date" />

                        </td>
                    </tr>
                </table>
            </div>
            <hr id="ADT_Hr2" style="display: none" />
            <asp:UpdatePanel ID="UpdatePanel14" runat="server">
                <ContentTemplate>
                    <asp:Button ID="ADT_Calculo_Fechas" runat="server" Text="Button" Style="display: none" OnClick="ADT_Calculo_Fechas_Click" />
                    <table>
                        <tr>
                            <td class="auto-style21">

                                <asp:Label CssClass="Motivo_Ajuste" ID="Label59" runat="server" Text="Periodos Completos:"></asp:Label><br />
                                <asp:DropDownList CssClass="dropdown1" ID="ADT_Periodos" runat="server" OnSelectedIndexChanged="ADT_Periodos_SelectedIndexChanged" AutoPostBack="true">
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
                                    <asp:ListItem>11</asp:ListItem>
                                    <asp:ListItem>12</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="auto-style21">
                                <asp:Label CssClass="Motivo_Ajuste" ID="Label64" runat="server" Text="Días Primer Periodo:"></asp:Label><br />
                                <asp:TextBox ID="ADT_Cantidad_de_Dias" runat="server" Text="0" Enabled="false"></asp:TextBox>
                            </td>
                            <td class="auto-style21">
                                <asp:Button ID="ADT_Calculo_Fechas_2" runat="server" Text="Button" Style="display: none" OnClick="ADT_Calculo_Fechas_2_Click" />
                                <asp:Label CssClass="Motivo_Ajuste" ID="Label67" runat="server" Text="Días Segundo Periodo:"></asp:Label><br />
                                <asp:TextBox ID="ADT_Cantidad_de_Dias_Segundo_Periodo" runat="server" Text="0" Enabled="false"></asp:TextBox>
                            </td>
                            <td class="auto-style21">
                                <asp:Label CssClass="Motivo_Ajuste" ID="Label62" runat="server" Text="Valor Fechas 1er Periodo:"></asp:Label><br />
                                <asp:TextBox ID="ADT_Valor_por_fechas" runat="server" Text="0" Enabled="false"></asp:TextBox>
                            </td>
                            <td class="auto-style21">
                                <asp:Label CssClass="Motivo_Ajuste" ID="Label68" runat="server" Text="Valor Fechas 2° Periodo:"></asp:Label><br />
                                <asp:TextBox ID="ADT_Valor_por_fechas_2" runat="server" Text="0" Enabled="false"></asp:TextBox>
                            </td>
                            <td class="auto-style21">
                                <asp:Label CssClass="Motivo_Ajuste" ID="Label63" runat="server" Text="Valor Por Periodos:"></asp:Label><br />
                                <asp:TextBox ID="ADT_Valor_por_periodos" runat="server" Text="0" Enabled="false"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style21">
                                <asp:Label CssClass="Motivo_Ajuste" ID="Label69" runat="server" Text="Valor Total a Ajustar:"></asp:Label><br />
                                <asp:TextBox ID="ADT_Total_A_Ajustar" runat="server" Text="0" Enabled="false"></asp:TextBox>
                            </td>

                        </tr>
                    </table>


                    <hr />
                    <div class="numeros">6</div>
                    <hr />
                    <div class="Texto_Informativo">Ingrese el numero de contrato del cliente:</div>
                    <table>
                        <tr>
                            <td class="auto-style21">
                                <asp:Label CssClass="Motivo_Ajuste" ID="Label70" runat="server" Text="Ingrese Contrato Cliente:"></asp:Label><br />
                                <asp:TextBox ID="ADT_Contrato_Cliente" runat="server" Text="0" AutoPostBack="true" OnTextChanged="ADT_Contrato_Cliente_TextChanged"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                    <hr />
                </ContentTemplate>
            </asp:UpdatePanel>
            <div class="numeros">7</div>
            <hr />
            <div class="Texto_Informativo">A continuación se muestra el resultaco con el resumen de las disputas por producto, de acuerdo a la diferencia de tarifas ingresada:</div>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:Button CssClass="button" ID="ADT_Ejecuta_Disputa_Final" runat="server" Text="Generar Disputa" OnClick="ADT_Ejecuta_Disputa_Final_Click" Style="display: none" />

                    <table class="Tabla_Ajuste">
                        <tr>
                            <th>Servicio</th>
                            <th>Neto</th>
                            <th>Iva</th>
                            <th>Valor a Disputar</th>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">TELEFONIA</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_NV_F" runat="server" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_IV_F" runat="server" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Disputa">
                                    <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VDV_F" runat="server" Text="0" Enabled="false" ForeColor="White"></asp:TextBox>
                                </div>
                            </td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">FUNCIONALIDADES</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_NF_F" runat="server" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_IF_F" runat="server" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Disputa">
                                    <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VDF_F" runat="server" Text="0" Enabled="false" ForeColor="White"></asp:TextBox>
                                </div>
                            </td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">INTERNET</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_NI_F" runat="server" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_II_F" runat="server" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Disputa">
                                    <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VDI_F" runat="server" Text="0" Enabled="false" ForeColor="White"></asp:TextBox>
                                </div>

                            </td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">TELEVISION</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_NTV_F" runat="server" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_ITV_F" runat="server" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Disputa">
                                    <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VDTV_F" runat="server" Text="0" Enabled="false" ForeColor="White"></asp:TextBox>
                                </div>

                            </td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">ARRIENDOS</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_NA_F" runat="server" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_IA_F" runat="server" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Disputa">
                                    <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VDA_F" runat="server" Text="0" Enabled="false" ForeColor="White"></asp:TextBox>
                                </div>
                            </td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">CLARO VIDEO</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_NCLAROVIDEO_F" runat="server" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_ICLAROVIDEO_F" runat="server" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Disputa">
                                    <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="ADT_VDCLAROVIDEO_F" runat="server" Text="0" Enabled="false" ForeColor="White"></asp:TextBox>
                                </div>
                            </td>

                        </tr>
                    </table>
                    <hr />
                    <div class="numeros">8</div>
                    <hr />
                    <div class="Texto_Informativo">La siguiente es la nota que debes copiar y pegar en la herramienta RR (AS400) en las notas F7 dentro de la carpeta de Ajustes, si no existe la carpeta debes crearla:</div>
                    <asp:TextBox CssClass="ADT_Notas" ID="ADT_Notas" runat="server" TextMode="MultiLine"></asp:TextBox>
                </ContentTemplate>
            </asp:UpdatePanel>

            <br />



            <script>
                $('#CEH_Fecha_Inicial').datetimepicker({
                    format: 'Y/m/d',
                    maxDate: '+0d',
                    timepicker: false
                });

                $('#CEH_Fecha_Final').datetimepicker({
                    format: 'Y/m/d',
                    onShow: function (ct) {
                        this.setOptions({
                            minDate: $('#CEH_Fecha_Inicial').val() ? $('#CEH_Fecha_Inicial').val() : false
                        })
                    },
                    maxDate: '+0d',
                    timepicker: false
                });
            </script>
            <script>
                $('#ADT_Fecha_Inicial_Im').datetimepicker({
                    format: 'Y/m/d',
                    maxDate: '+0d',
                    timepicker: false
                });

                $('#ADT_Fecha_Final_Im').datetimepicker({
                    format: 'Y/m/d',
                    onShow: function (ct) {
                        this.setOptions({
                            minDate: $('#ADT_Fecha_Inicial_Im').val() ? $('#ADT_Fecha_Inicial_Im').val() : false
                        })
                    },
                    maxDate: '+0d',
                    timepicker: false
                });
            </script>
            <script>
                function Traer_Fecha_Final() {
                    var fecha = document.getElementById('CEH_Fecha_Final').value;
                    document.getElementById("<%= CE_Fecha_Final.ClientID %>").value = fecha;

                    Traer_Fecha_Inicial_2_Periodo();
                    Traer_Fecha_Final_2_Periodo();

                    var bt1 = document.getElementById("<%= ADT_Calculo_Fechas.ClientID %>");
                    bt1.click();

                }
            </script>
            <script>
                function Traer_Fecha() {
                    var fecha = document.getElementById('CEH_Fecha_Inicial').value;
                    document.getElementById("<%= CE_Fecha_Inicial.ClientID %>").value = fecha;
                }
            </script>

            <script>
                function Traer_Fecha_Inicial_2_Periodo() {
                    var fecha = document.getElementById('ADT_Fecha_Inicial_Im').value;
                    document.getElementById("<%= ADT_Fecha_Inicial.ClientID %>").value = fecha;
                }
            </script>

            <script>
                function Traer_Fecha_Final_2_Periodo() {
                    var fecha = document.getElementById('ADT_Fecha_Final_Im').value;
                    document.getElementById("<%= ADT_Fecha_Final.ClientID %>").value = fecha;

                    var bt1 = document.getElementById("<%= ADT_Calculo_Fechas_2.ClientID %>");
                    bt1.click();


                }
            </script>

            <hr />
            <script>
                function Cargar_Datos_ADT() {
                    var bt1 = document.getElementById("<%= ADT_Cargar_Datos.ClientID %>");
                    document.getElementById('Diferencia_Tarifas').style.display = 'block';
                    bt1.click();

                }
            </script>
            <script>
                function Cerrar_Ventana_Diferencia_Tarifas() {

                    document.getElementById('Diferencia_Tarifas').style.display = 'none';


                }
            </script>
        </div>
    </div>
    <div class="modal-wrapper" id="Prorrateos" style="display: none">
        <div class="Prorrateos-contenedor">
            <a class="Prorrateos-cerrar" href="#" onclick="return Cerrar_Ventana_Prorrateos()">X</a>
            <h2>CALCULADORA DE AJUSTES - PRORRATEOS</h2>
            <hr />
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:Button CssClass="button" ID="AP_Limpiar" runat="server" Text="Limpiar" OnClick="AP_Limpiar_Click" />
                    <a href="https://comunidadvirtual.claro.com.co/www/lms/Biblioteca/Documentos/others/M_Servicio/Residencial/Boletines/Comunicados%20-%202016/c905/index.html" target="_blank">
                        <div class="politicas"></div>
                    </a>
                </ContentTemplate>
            </asp:UpdatePanel>
            <hr />
            <div class="numeros">1</div>
            <hr />
            <div class="Texto_Informativo">Esta es la información basica del cliente que se cargara automaticamente luego de haber ingresado el número de cuenta del cliente en el formulario de tipificación inbound, verifique por favor que el estrato que se muestra aqui coincida con el de RR, de lo contrario modifiquelo:</div>

            <asp:UpdatePanel ID="UpdatePanel13" runat="server">
                <ContentTemplate>
                    <asp:Button CssClass="button" ID="AP_cargar_Datos" runat="server" Text="Cargar_Datos" Style="display: none" OnClick="AP_cargar_Datos_Click" />
                    <asp:Table ID="Table1" runat="server">
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="1">
                                <asp:Label CssClass="Motivo_Ajuste" ID="Label77" runat="server" Text="Nombre del Cliente:"></asp:Label><br />
                                <asp:TextBox CssClass="caja_de_texto" ID="AP_Nombre_Cliente" runat="server" Enabled="false"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell ColumnSpan="1">
                                <asp:Label CssClass="Motivo_Ajuste" ID="Label78" runat="server" Text="Apellido del Cliente:"></asp:Label><br />
                                <asp:TextBox CssClass="caja_de_texto" ID="AP_Apellido_Cliente" runat="server" Enabled="false"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell ColumnSpan="1">
                                <asp:Label CssClass="Motivo_Ajuste" ID="Label79" runat="server" Text="Estrato del Home Pass:"></asp:Label><br />
                                <asp:TextBox CssClass="caja_de_texto" ID="AP_Estrato_Cliente" runat="server" AutoPostBack="true" OnTextChanged="AP_Estrato_Cliente_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>

                    </asp:Table>
                </ContentTemplate>
            </asp:UpdatePanel>
            <div class="numeros">2</div>
            <hr />
            <div class="Texto_Informativo">A continuación debes seleccionar las fechas correspondientes:</div>

            <table>
                <tr>
                    <td>
                        <asp:Label CssClass="Motivo_Ajuste" ID="Label80" runat="server" Text="Fecha Inicial:"></asp:Label><br />
                        <asp:TextBox ID="AP_Fecha_Inicial" runat="server" Style="display: none"></asp:TextBox>
                        <input class="caja_de_texto" type="text" value="" id="AP_Fecha_CI1_Inicial" autocomplete="off" onchange="return AP_Traer_Fecha_Inicial()" placeholder="Select date" />

                    </td>
                    <td class="auto-style21">
                        <asp:Label CssClass="Motivo_Ajuste" ID="Label82" runat="server" Text="Fecha Proximo Corte:"></asp:Label><br />
                        <asp:TextBox ID="AP_Fecha_Corte" runat="server" Style="display: none"></asp:TextBox>
                        <input class="caja_de_texto" type="text" value="" id="AP_Fecha_CI1_Corte" autocomplete="off" onchange="return AP_Traer_Fecha_Corte()" placeholder="Select date" />

                    </td>
                    <td class="auto-style21">
                        <asp:Label CssClass="Motivo_Ajuste" ID="Label81" runat="server" Text="Fecha Final:"></asp:Label><br />
                        <asp:TextBox ID="AP_Fecha_Final" runat="server" Style="display: none"></asp:TextBox>
                        <input class="caja_de_texto" type="text" value="" id="AP_Fecha_CI1_Final" autocomplete="off" onchange="return AP_Traer_Fecha_Final()" placeholder="Select date" />

                    </td>
                </tr>
            </table>
            <asp:UpdatePanel ID="UpdatePanel15" runat="server">
                <ContentTemplate>
                    <table>
                        <tr>
                            <td>
                                <asp:Label CssClass="Motivo_Ajuste" ID="Label83" runat="server" Text="Días 1er Periodo:"></asp:Label><br />
                                <asp:TextBox CssClass="caja_de_texto" ID="AP_Dias_Primer_Periodo" runat="server" Enabled="false"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label CssClass="Motivo_Ajuste" ID="Label84" runat="server" Text="Días 2do Periodo:"></asp:Label><br />
                                <asp:TextBox CssClass="caja_de_texto" ID="AP_Dias_Segundo_Periodo" runat="server" Enabled="false"></asp:TextBox>
                            </td>

                        </tr>
                    </table>
                    <hr />

                    <asp:Button ID="AP_Calculo_Fechas" runat="server" Text="Button" OnClick="AP_Calculo_Fechas_Click" Style="display: none" />
                </ContentTemplate>
            </asp:UpdatePanel>
            <div class="numeros">3</div>
            <hr />
            <div class="Texto_Informativo">Ingrese los valores por servicio que factura el cliente en RR:</div>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <table class="Tabla_Ajuste">
                        <tr>
                            <th>Servicio</th>
                            <th>Valor Sin Iva</th>
                            <th>Iva del Servicio</th>
                            <th>Valor con Iva</th>
                            <th>Valor Proporcional 1er Mes</th>
                            <th>Valor Proporcional 2do Mes</th>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">TELEVISION</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="AP_TV_RR" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="AP_TV_RR_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_TV_IVA" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_TV_TOTAL" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_TV_1P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_TV_2P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">INTERNET</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="AP_IN_RR" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="AP_IN_RR_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_IN_IVA" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_IN_TOTAL" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_IN_1P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_IN_2P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">TELEFONIA</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="AP_VOZ_RR" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="AP_VOZ_RR_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_VOZ_IVA" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_VOZ_TOTAL" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_VOZ_1P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_VOZ_2P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">FUNCIONALIDADES</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="AP_FUN_RR" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="AP_FUN_RR_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_FUN_IVA" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_FUN_TOTAL" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_FUN_1P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_FUN_2P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">LD 30</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="AP_LD_RR" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="AP_LD_RR_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_LD_IVA" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_LD_TOTAL" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_LD_1P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_LD_2P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">REVISTA</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="AP_RV_RR" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="AP_RV_RR_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_RV_IVA" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_RV_TOTAL" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_RV_1P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_RV_2P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">HBO</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="AP_HBO_RR" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="AP_HBO_RR_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_HBO_IVA" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_HBO_TOTAL" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_HBO_1P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_HBO_2P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">MOVIE PACK</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="AP_MPK_RR" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="AP_MPK_RR_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_MPK_IVA" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_MPK_TOTAL" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_MPK_1P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_MPK_2P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">TELEVISION HD</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="AP_TVHD_RR" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="AP_TVHD_RR_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_TVHD_IVA" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_TVHD_TOTAL" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_TVHD_1P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_TVHD_2P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">SPICE TV</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="AP_SP_RR" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="AP_SP_RR_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_SP_IVA" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_SP_TOTAL" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_SP_1P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_SP_2P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">VENUS</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="AP_VENUS_RR" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="AP_VENUS_RR_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_VENUS_IVA" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_VENUS_TOTAL" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_VENUS_1P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_VENUS_2P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">PVR</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="AP_PVR_RR" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="AP_PVR_RR_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_PVR_IVA" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_PVR_TOTAL" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_PVR_1P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_PVR_2P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">WIFI</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="AP_WIFI_RR" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="AP_WIFI_RR_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_WIFI_IVA" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_WIFI_TOTAL" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_WIFI_1P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_WIFI_2P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">CLARO VIDEO</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="AP_CLAROVIDEO_RR" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="AP_CLAROVIDEO_RR_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_CLAROVIDEO_IVA" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_CLAROVIDEO_TOTAL" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_CLAROVIDEO_1P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_CLAROVIDEO_2P" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>

                        </tr>
                    </table>
                    <hr />
                    <div class="numeros">4</div>
                    <hr />
                    <div class="Texto_Informativo">A continuación se muestra los valores para disputas a favor o en contra de acuerdo a los calculos realizados:</div>

                    <table class="Tabla_Ajuste">
                        <tr>
                            <th>Servicio</th>
                            <th>Neto</th>
                            <th>Iva del Servicio</th>
                            <th>Valor a Disputar</th>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">TELEVISION</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_TV_NETO" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_TV_NETO_IVA" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Disputa">
                                    <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_TV_NETO_DP" runat="server" AutoCompleteType="None" Text="0" Enabled="false" ForeColor="White"></asp:TextBox>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">INTERNET</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_IN_NETO" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_IN_NETO_IVA" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Disputa">
                                    <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_IN_NETO_DP" runat="server" AutoCompleteType="None" Text="0" Enabled="false" ForeColor="White"></asp:TextBox>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">TELEFONIA</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_VOZ_NETO" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_VOZ_NETO_IVA" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Disputa">
                                    <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_VOZ_NETO_DP" runat="server" AutoCompleteType="None" Text="0" Enabled="false" ForeColor="White"></asp:TextBox>
                                </div>
                            </td>


                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">HBO</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_HBO_NETO" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_HBO_NETO_IVA" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Disputa">
                                    <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_HBO_NETO_DP" runat="server" AutoCompleteType="None" Text="0" Enabled="false" ForeColor="White"></asp:TextBox>
                                </div>
                            </td>


                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">MOVIE PACK</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_MPK_NETO" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_MPK_NETO_IVA" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Disputa">
                                    <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_MPK_NETO_DP" runat="server" AutoCompleteType="None" Text="0" Enabled="false" ForeColor="White"></asp:TextBox>
                                </div>
                            </td>


                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">TELEVISION HD</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_TVHD_NETO" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_TVHD_NETO_IVA" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Disputa">
                                    <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_TVHD_NETO_DP" runat="server" AutoCompleteType="None" Text="0" Enabled="false" ForeColor="White"></asp:TextBox>
                                </div>
                            </td>


                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">SPICE TV</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_SP_NETO" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_SP_NETO_IVA" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Disputa">
                                    <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_SP_NETO_DP" runat="server" AutoCompleteType="None" Text="0" Enabled="false" ForeColor="White"></asp:TextBox>
                                </div>
                            </td>


                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">VENUS</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_VENUS_NETO" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_VENUS_NETO_IVA" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Disputa">
                                    <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_VENUS_NETO_DP" runat="server" AutoCompleteType="None" Text="0" Enabled="false" ForeColor="White"></asp:TextBox>
                                </div>
                            </td>


                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">PVR</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_PVR_NETO" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_PVR_NETO_IVA" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Disputa">
                                    <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_PVR_NETO_DP" runat="server" AutoCompleteType="None" Text="0" Enabled="false" ForeColor="White"></asp:TextBox>
                                </div>
                            </td>


                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">WIFI</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_WIFI_NETO" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_WIFI_NETO_IVA" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Disputa">
                                    <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_WIFI_NETO_DP" runat="server" AutoCompleteType="None" Text="0" Enabled="false" ForeColor="White"></asp:TextBox>
                                </div>
                            </td>


                        </tr>
                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">CLARO VIDEO</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_CLAROVIDEO_NETO" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_CLAROVIDEO_NETO_IVA" runat="server" AutoCompleteType="None" Text="0" Enabled="false"></asp:TextBox></td>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Disputa">
                                    <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="AP_CLAROVIDEO_NETO_DP" runat="server" AutoCompleteType="None" Text="0" Enabled="false" ForeColor="White"></asp:TextBox>
                                </div>
                            </td>


                        </tr>
                    </table>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <script>
            function AP_Traer_Fecha_Inicial() {
                var fecha = document.getElementById('AP_Fecha_CI1_Inicial').value;
                document.getElementById("<%= AP_Fecha_Inicial.ClientID %>").value = fecha;

                var bt1 = document.getElementById("<%= AP_Calculo_Fechas.ClientID %>");
                bt1.click();
            }
        </script>
        <script>
            function AP_Traer_Fecha_Corte() {
                var fecha = document.getElementById('AP_Fecha_CI1_Corte').value;
                document.getElementById("<%= AP_Fecha_Corte.ClientID %>").value = fecha;

                var bt1 = document.getElementById("<%= AP_Calculo_Fechas.ClientID %>");
                bt1.click();
            }
        </script>
        <script>
            function AP_Traer_Fecha_Final() {
                var fecha = document.getElementById('AP_Fecha_CI1_Final').value;
                document.getElementById("<%= AP_Fecha_Final.ClientID %>").value = fecha;

                var bt1 = document.getElementById("<%= AP_Calculo_Fechas.ClientID %>");
                bt1.click();

            }
        </script>
        <script>
            function Cargar_Datos_AP() {
                var bt1 = document.getElementById("<%= AP_cargar_Datos.ClientID %>");
                document.getElementById('Prorrateos').style.display = 'block';
                bt1.click();

            }
        </script>
         <script>
            function Abrir_Ventana_BackElite() {
                document.getElementById('Iframe_Back_Elite').style.display = 'block';
                var bt1 = document.getElementById("<%= BE_Cargar_Datos.ClientID %>");
                bt1.click();
            }
        </script>
        <script>
            function Cerrar_Ventana_BackElite() {
                document.getElementById('Iframe_Back_Elite').style.display = 'none';
               

            }
        </script>
         <script>
            function Abrir_Ventana_T_Crear_Direccion() {
                document.getElementById('Iframe_T_Crear_Direccion').style.display = 'block';
                
            }
        </script>
        <script>
            function Cerrar_Ventana_T_Crear_Direccion() {
                document.getElementById('Iframe_T_Crear_Direccion').style.display = 'none';
               

            }
        </script>
        <script>
            function Cerrar_Ventana_Prorrateos() {

                document.getElementById('Prorrateos').style.display = 'none';


            }
        </script>

        <script type="text/javascript">

            function AP_Limpiar_Controles() {

                document.getElementById('AP_Fecha_CI1_Inicial').value = "";
                document.getElementById('AP_Fecha_CI1_Corte').value = "";
                document.getElementById('AP_Fecha_CI1_Final').value = "";
            }
        </script>
        <script>
            $('#AP_Fecha_CI1_Inicial').datetimepicker({
                format: 'Y/m/d',
                maxDate: '+0d',
                timepicker: false
            });

            $('#AP_Fecha_CI1_Corte').datetimepicker({
                format: 'Y/m/d',
                maxDate: '+0d',
                timepicker: false
            });

            $('#AP_Fecha_CI1_Final').datetimepicker({
                format: 'Y/m/d',
                onShow: function (ct) {
                    this.setOptions({
                        minDate: $('#AP_Fecha_CI1_Inicial').val() ? $('#AP_Fecha_CI1_Inicial').val() : false
                    })
                },
                maxDate: '+0d',
                timepicker: false
            });
        </script>
    </div>
    <div class="modal-wrapper" id="Contenedor_Reconexion" style="display: none">
        <div class="Compensacion-contenedor">
            <a class="Compensacion-cerrar" href="#">X</a>
            <h2>CALCULADORA DE AJUSTES - RECONEXION</h2>
            <hr />
            <an href="#"> <div class="politicas"></div></an>
            <asp:UpdatePanel ID="Panel_Reconexion" runat="server">
                <ContentTemplate>
                    <table class="Tabla_Ajuste">
                        <tr>
                            <th>Servicio</th>
                            <th>Valor Sin Iva</th>
                            <th>Iva del Servicio</th>
                            <th>Valor con Iva</th>
                            <th>Valor a Ajustar</th>
                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">TELEVISION</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="V_SI_T" runat="server" AutoCompleteType="None" OnTextChanged="V_SI_T_TextChanged" AutoPostBack="true"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="V_I_T" runat="server" AutoCompleteType="None"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="V_CI_T" runat="server" AutoCompleteType="None"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="V_TA_T" runat="server" AutoCompleteType="None"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">INTERNET</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="V_SI_I" runat="server" AutoCompleteType="None" OnTextChanged="V_SI_I_TextChanged" AutoPostBack="true"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="V_I_I" runat="server" AutoCompleteType="None"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="V_CI_I" runat="server" AutoCompleteType="None"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="V_TA_I" runat="server" AutoCompleteType="None"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">TELEFONIA</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="V_SI_V" runat="server" AutoCompleteType="None" OnTextChanged="V_SI_V_TextChanged" AutoPostBack="true"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="V_I_V" runat="server" AutoCompleteType="None"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="V_CI_V" runat="server" AutoCompleteType="None"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="V_TA_V" runat="server" AutoCompleteType="None"></asp:TextBox></td>
                        </tr>
                    </table>

                </ContentTemplate>
            </asp:UpdatePanel>
        </div>

    </div>
    <div class="modal-wrapper" id="Campanas" style="display: none">
        <div class="Campanas-contenedor">
            <a class="Campanas-cerrar" href="#" onclick="return Cerrar_Ventana_APC()">X</a>
            <h2>CALCULADORA DE AJUSTES - CAMPAÑAS</h2>
            <hr />

            <asp:UpdatePanel ID="UpdatePanel18" runat="server">
                <ContentTemplate>
                    <asp:Button CssClass="button" ID="APC_Limpiar" runat="server" Text="Reiniciar Calculos" OnClick="APC_Limpiar_Click" />
                    <a href="https://comunidadvirtual.claro.com.co/www/lms/Biblioteca/Documentos/others/M_Servicio/Residencial/Boletines/Comunicados%20-%202016/c905/index.html" target="_blank">
                        <div class="politicas"></div>
                    </a>
                </ContentTemplate>
            </asp:UpdatePanel>
            <hr />
            <asp:UpdatePanel ID="UpdatePanel16" runat="server">
                <ContentTemplate>
                    <div class="Texto_Informativo">Estos son los datos basicos del cliente, por favor verifique que el estrato del Home Pass coincida con el que registra en RR (AS400), de lo contrario modifiquelo:</div>
                    <asp:Button CssClass="button" ID="APC_Cargar_Datos" runat="server" Text="Cargar_Datos" OnClick="APC_Cargar_Datos_Click" Style="display: none" />
                    <asp:Table ID="Table2" runat="server">
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="1">
                                <asp:Label CssClass="Motivo_Ajuste" ID="Label85" runat="server" Text="Nombre del Cliente:"></asp:Label><br />
                                <asp:TextBox CssClass="caja_de_texto" ID="APC_Nombre_Cliente" runat="server" Enabled="false"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell ColumnSpan="1">
                                <asp:Label CssClass="Motivo_Ajuste" ID="Label86" runat="server" Text="Apellido del Cliente:"></asp:Label><br />
                                <asp:TextBox CssClass="caja_de_texto" ID="APC_Apellido_Cliente" runat="server" Enabled="false"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell ColumnSpan="1">
                                <asp:Label CssClass="Motivo_Ajuste" ID="Label87" runat="server" Text="Estrato:"></asp:Label><br />
                                <asp:TextBox CssClass="caja_de_texto" ID="APC_Estrato_Cliente" runat="server" AutoPostBack="true" OnTextChanged="APC_Estrato_Cliente_TextChanged" OnBlur="APC_Estrato_Cliente_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>

                    </asp:Table>
                </ContentTemplate>
            </asp:UpdatePanel>
            <hr />
            <div class="numeros">1</div>
            <hr />
            <div class="Texto_Informativo">A continuación ingrese el porcentaje de descuento que genera la campaña por la que se va a realizar el calculo ente 1% y 100%, solo ingrese números:</div>
            <table>
                <tr>
                    <td>
                        <asp:UpdatePanel runat="server">
                            <ContentTemplate>
                                <asp:Label CssClass="Motivo_Ajuste" ID="Label88" runat="server" Text="% de Descuento:"></asp:Label><br />
                                <asp:TextBox CssClass="caja_de_texto" ID="APC_Prcentaje_Descuento" runat="server" AutoPostBack="true" OnTextChanged="APC_Prcentaje_Descuento_TextChanged" MaxLength="3"></asp:TextBox>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                    <td>
                        <asp:Label CssClass="Motivo_Ajuste" ID="Label140" runat="server" Text="Área del Ofrecimiento:"></asp:Label><br />
                        <asp:DropDownList CssClass="dropdown2" ID="APC_Area_Ofrecimiento" runat="server">
                            <asp:ListItem>-SELECCIONE-</asp:ListItem>
                            <asp:ListItem>COMERCIAL</asp:ListItem>
                            <asp:ListItem>FIDELIZACION</asp:ListItem>
                            <asp:ListItem>SERVICIOS ESPECIALES</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Label CssClass="Motivo_Ajuste" ID="Label145" runat="server" Text="Fecha del Ofrecimiento:"></asp:Label><br />
                        <asp:TextBox ID="APC_Fecha_Ofrecimiento" runat="server" Style="display: none"></asp:TextBox>
                        <input class="caja_de_texto" type="text" value="" id="APC_Fecha_Ofrecimiento_i" autocomplete="off" onchange="return APC_Traer_Fecha_Ofrecimiento()" placeholder="Select date" />

                    </td>
                </tr>
            </table>
            <hr />

            <div class="numeros">2</div>
            <hr />
            <div class="Texto_Informativo">Ingrese las fechas segun corresponda, primero la fecha de inicio, luego la fecha fecha del siguiente ciclo de facturación, o fecha de desconexión de la cuenta.:</div>

            <table>
                <tr>
                    <td>
                        <asp:Label CssClass="Motivo_Ajuste" ID="Label89" runat="server" Text="Fecha Inicial:"></asp:Label><br />
                        <asp:TextBox ID="APC_Fecha_Inicial_T" runat="server" Style="display: none"></asp:TextBox>
                        <input class="caja_de_texto" type="text" value="" id="APC_Fecha_Inicial" autocomplete="off" onchange="return APC_Traer_Fecha_Inicial()" placeholder="Select date" />

                    </td>
                    <td class="auto-style21">
                        <asp:Label CssClass="Motivo_Ajuste" ID="Label90" runat="server" Text="Fecha Final:"></asp:Label><br />
                        <asp:TextBox ID="APC_Fecha_Final_T" runat="server" Style="display: none"></asp:TextBox>
                        <input class="caja_de_texto" type="text" value="" id="APC_Fecha_Final" autocomplete="off" onchange="return APC_Traer_Fecha_Final()" placeholder="Select date" />

                    </td>
                </tr>
            </table>
            <asp:UpdatePanel ID="UpdatePanel17" runat="server">
                <ContentTemplate>
                    <asp:Button ID="APC_Calculo_Fechas" runat="server" Text="Button" Style="display: none" OnClick="APC_Calculo_Fechas_Click" />
                    <table>
                        <tr>
                            <td class="auto-style21">

                                <asp:Label CssClass="Motivo_Ajuste" ID="Label91" runat="server" Text="Periodos Completos:"></asp:Label><br />
                                <asp:DropDownList CssClass="dropdown1" ID="APC_Periodos" runat="server" OnSelectedIndexChanged="APC_Periodos_SelectedIndexChanged" AutoPostBack="true">
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
                                    <asp:ListItem>11</asp:ListItem>
                                    <asp:ListItem>12</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="auto-style21">
                                <asp:Label CssClass="Motivo_Ajuste" ID="Label92" runat="server" Text="Cantidad de Días:"></asp:Label><br />
                                <asp:TextBox ID="APC_Cantidad_de_Dias" runat="server" Text="0" Enabled="false"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                    <hr />
                    <div class="numeros">3</div>
                    <hr />
                    <div class="Texto_Informativo">A continuacion ingrese los valores que el cliente factura en RR (AS400) sin  Iva, de acuerdo a los servicios sobre los cuales se le aplica el calculo del descuento de la campaña:</div>
                    <table class="Tabla_Ajuste">
                        <tr>
                            <th>Servicio</th>
                            <th>Valor Sin Iva</th>
                            <th>Iva del Servicio</th>
                            <th>Valor con Iva</th>
                            <th>Diferencia Según Campaña</th>
                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">TELEVISION</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="APC_TV_SI" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="APC_TV_SI_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_TV_CI" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_TV_TOTAL" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_TV_DIFERENCIA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">INTERNET</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="APC_IN_SI" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="APC_IN_SI_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_IN_CI" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_IN_TOTAL" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_IN_DIFERENCIA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">TELEFONIA</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="APC_VOZ_SI" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="APC_VOZ_SI_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_VOZ_CI" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_VOZ_TOTAL" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_VOZ_DIFERENCIA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">FUNCIONALIDADES</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="APC_FUN_SI" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="APC_FUN_SI_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_FUN_CI" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_FUN_TOTAL" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_FUN_DIFERENCIA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">LD 30</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="APC_LD_SI" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="APC_LD_SI_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_LD_CI" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_LD_TOTAL" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_LD_DIFERENCIA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                        </tr>
                        <tr style="display: none">
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">REVISTA</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="APC_RV_SI" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="APC_RV_SI_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_RV_CI" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_RV_TOTAL" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_RV_DIFERENCIA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">HBO</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="APC_HBO_SI" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="APC_HBO_SI_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_HBO_CI" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_HBO_TOTAL" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_HBO_DIFERENCIA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">MOVIE PACK</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="APC_MPK_SI" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="APC_MPK_SI_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_MPK_CI" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_MPK_TOTAL" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_MPK_DIFERENCIA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">TELEVISION HD</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="APC_TVHD_SI" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="APC_TVHD_SI_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_TVHD_CI" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_TVHD_TOTAL" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_TVHD_DIFERENCIA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">SPICE TV</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="APC_SP_SI" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="APC_SP_SI_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_SP_CI" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_SP_TOTAL" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_SP_DIFERENCIA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">VENUS</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="APC_VENUS_SI" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="APC_VENUS_SI_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_VENUS_CI" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_VENUS_TOTAL" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_VENUS_DIFERENCIA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">PVR - DECOS</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="APC_PVR_SI" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="APC_PVR_SI_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_PVR_CI" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_PVR_TOTAL" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_PVR_DIFERENCIA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">WIFI</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="APC_WIFI_SI" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="APC_WIFI_SI_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_WIFI_CI" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_WIFI_TOTAL" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_WIFI_DIFERENCIA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">CLARO VIDEO</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Ingreso" ID="APC_CLAROVIDEO_SI" runat="server" AutoCompleteType="None" AutoPostBack="true" Text="0" OnTextChanged="APC_CLAROVIDEO_SI_TextChanged"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_CLAROVIDEO_CI" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_CLAROVIDEO_TOTAL" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_CLAROVIDEO_DIFERENCIA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                        </tr>
                    </table>
                    <hr />
                    <div class="numeros">4</div>
                    <hr />
                    <div class="Texto_Informativo">El siguiente es el resumen de disputas a generar por cada uno de los servicios de acuerdo a los calculos realizados:</div>
                    <table class="Tabla_Ajuste">
                        <tr>
                            <th>Servicio</th>
                            <th>Neto</th>
                            <th>Iva del Servicio</th>
                            <th>Valor a Disputar</th>

                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">TELEFONIA</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_VOZ_NETO" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_VOZ_NETO_IVA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Disputa" ID="APC_VOZ_NETO_DISPUTA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">FUNCIONALIDADES</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_FUN_NETO" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_FUN_NETO_IVA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Disputa" ID="APC_FUN_NETO_DISPUTA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">LD 30</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_LD_NETO" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_LD_NETO_IVA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Disputa" ID="APC_LD_NETO_DISPUTA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">INTERNET</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_IN_NETO" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_IN_NETO_IVA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Disputa" ID="APC_IN_NETO_DISPUTA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">TELEVISION</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_TV_NETO" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_TV_NETO_IVA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Disputa" ID="APC_TV_NETO_DISPUTA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>


                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">HBO</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_HBO_NETO" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_HBO_NETO_IVA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Disputa" ID="APC_HBO_NETO_DISPUTA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>


                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">MOVIE PACK</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_MPK_NETO" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_MPK_NETO_IVA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Disputa" ID="APC_MPK_NETO_DISPUTA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>


                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">TELEVISION HD</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_TVHD_NETO" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_TVHD_NETO_IVA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Disputa" ID="APC_TVHD_NETO_DISPUTA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>


                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">SPICE TV</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_SP_NETO" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_SP_NETO_IVA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Disputa" ID="APC_SP_NETO_DISPUTA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>


                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">VENUS</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_VENUS_NETO" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_VENUS_NETO_IVA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Disputa" ID="APC_VENUS_NETO_DISPUTA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>


                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">PVR - DECOS</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_PVR_NETO" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_PVR_NETO_IVA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Disputa" ID="APC_PVR_NETO_DISPUTA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>


                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">WIFI</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_WIFI_NETO" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_WIFI_NETO_IVA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Disputa" ID="APC_WIFI_NETO_DISPUTA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <div class="Caja_de_Texto_Ajustes_Titulo">CLARO VIDEO</div>
                            </td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_CLAROVIDEO_NETO" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes" ID="APC_CLAROVIDEO_NETO_IVA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                            <td>
                                <asp:TextBox CssClass="Caja_de_Texto_Ajustes_Disputa" ID="APC_CLAROVIDEO_NETO_DISPUTA" runat="server" AutoCompleteType="None" Text="0"></asp:TextBox></td>
                        </tr>
                    </table>
                    <hr />
                    <div class="numeros">4</div>
                    <hr />
                    <div class="Texto_Informativo">La siguiente es la nota que debes copiar y pegar en la herramienta RR (AS400) en las notas F7 dentro de la carpeta de Ajustes, si no existe la carpeta debes crearla:</div>
                    <asp:TextBox CssClass="ADT_Notas" ID="APC_NOTAS_RR" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <hr />
                </ContentTemplate>
            </asp:UpdatePanel>

        </div>
        <script>
            function Cargar_Datos_APC() {
                var bt1 = document.getElementById("<%= APC_Cargar_Datos.ClientID %>");
                document.getElementById('Campanas').style.display = 'block';
                bt1.click();

            }
        </script>

        <script>
            function Cerrar_Ventana_APC() {

                document.getElementById('Campanas').style.display = 'none';


            }
        </script>
        <script>
            $('#APC_Fecha_Inicial').datetimepicker({
                format: 'Y/m/d',
                maxDate: '+0d',
                timepicker: false
            });

            $('#APC_Fecha_Ofrecimiento_i').datetimepicker({
                format: 'Y/m/d',
                maxDate: '+0d',
                timepicker: false
            });

            $('#APC_Fecha_Final').datetimepicker({
                format: 'Y/m/d',
                onShow: function (ct) {
                    this.setOptions({
                        minDate: $('#APC_Fecha_Inicial').val() ? $('#APC_Fecha_Inicial').val() : false
                    })
                },
                maxDate: '+0d',
                timepicker: false
            });
        </script>
        <script>
            function APC_Traer_Fecha_Inicial() {
                var fecha = document.getElementById('APC_Fecha_Inicial').value;
                document.getElementById("<%= APC_Fecha_Inicial_T.ClientID %>").value = fecha;

                var bt1 = document.getElementById("<%= APC_Calculo_Fechas.ClientID %>");
                bt1.click();
            }
        </script>
        <script>
            function APC_Traer_Fecha_Ofrecimiento() {
                var fecha = document.getElementById('APC_Fecha_Ofrecimiento_i').value;
                document.getElementById("<%= APC_Fecha_Ofrecimiento.ClientID %>").value = fecha;
            }
        </script>
        <script>
            function APC_Traer_Fecha_Final() {
                var fecha = document.getElementById('APC_Fecha_Final').value;
                document.getElementById("<%= APC_Fecha_Final_T.ClientID %>").value = fecha;

                var bt1 = document.getElementById("<%= APC_Calculo_Fechas.ClientID %>");
                bt1.click();

            }
        </script>

        <script type="text/javascript">
            function Mostrar_Aviso_Porcentaje_Descuento() {
                alert('El valor ingresado de descuento por campaña no es valido');

            }
        </script>
        <script type="text/javascript">
            function APC_Limpiar_Controles() {

                document.getElementById('APC_Fecha_Inicial').value = "";
                document.getElementById('APC_Fecha_Final').value = "";
                document.getElementById('APC_Fecha_Ofrecimiento_i').value = "";
            }
        </script>
    </div>
    <!-- ESTA PARTE ES PARA MOSTRAR EL IFRAME DE FACTURACION Y CONVENIO ELECTRONICO-->
    <div class="modal-wrapper" id="Iframe_Paradigma" style="display: none">
        <div id="Notificacion_Contene" class="Iframe_Paradigma-contenedor">
            <a class="Iframe_Paradigma-cerrar" href="#">X</a>

            <div id="Facturacion1">
                <iframe class="iframe" id="paradigma" runat="server" src="http://facturasclaro.paradigma.com.co/ebpTelmex/Login.aspx"></iframe>
            </div>
            <br />


        </div>
    </div>
    <!-- ESTA PARTE ES PARA MOSTRAR EL IFRAME DE CLARO VIDEO-->
    <div class="modal-wrapper" id="Iframe_CV" style="display: none">
        <div class="Iframe_CV-contenedor">
            <a id="Iframe_CV_Cerrar" class="Iframe_CV-cerrar" href="#" onclick="return Quitar_Iframe();">X</a>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <h2>FORMULARIO ACTIVACIÓN CLARO VIDEO</h2>
                    <hr />
                    <div class="Texto_Informativo_SMO">Beneficios:</div>
                    <div class="SMO_Contenedor">
                        <table class="tabla_pdf_inbound">
                            <tr>
                                <td>
                                    <iframe class="iframe" id="Iframe1" style="background-size: 100%; width: 100%;" src="#" runat="server"></iframe>
                                </td>

                            </tr>
                        </table>
                    </div>
                    <hr />
                    <div class="Texto_Informativo_SMO">Servicio:</div>
                    <div class="SMO_Contenedor">
                        <table class="tabla">
                            <tr>
                                <td colspan="6">
                                    <p class="etiquetas_Ofrecimiento2">
                                        El cliente acepto?
                                    </p>
                                    &nbsp;<asp:RadioButton ID="RadioButton13" runat="server" GroupName="1" Text="SI" Font-Names="Century Gothic" Font-Size="Small" />
                                    &nbsp; &nbsp; 
                                <asp:RadioButton ID="RadioButton14" runat="server" GroupName="1" Text="NO" Font-Names="Century Gothic" Font-Size="Small" />
                                </td>

                            </tr>
                        </table>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
            <hr />
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:Button CssClass="button" ID="CV_Guarda" runat="server" OnClick="CV_Guarda_Click" Text="Guardar" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
    <!-- ESTA PARTE ES PARA MOSTRAR EL IFRAME DE SIGUIENTE MEJOR OFERTA-->
    <div class="modal-wrapper" id="Iframe_SMO" style="display: none">
        <div class="Iframe_SMO-contenedor">
            <a class="Iframe_SMO-cerrar" href="#">X</a>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>

                    <h2>FORMULARIO SIGUIENTE MEJOR OFERTA</h2>
                    <hr />


                    <div class="Texto_Informativo_SMO">Información Básica del Cliente:</div>
                    <div class="SMO_Contenedor">
                        <table>
                            <tr>
                                <td>
                                    <asp:Label CssClass="etiquetas" ID="Label93" runat="server" Text="Cuenta Cliente:"></asp:Label><br />
                                    <asp:TextBox CssClass="caja_de_texto" ID="SMO_Cuenta_Cliente" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label CssClass="etiquetas" ID="Label94" runat="server" Text="Nombre del Cliente:"></asp:Label><br />
                                    <asp:TextBox CssClass="caja_de_texto" ID="SMO_Nombre_Cliente" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label CssClass="etiquetas" ID="Label95" runat="server" Text="Apellido Cliente:"></asp:Label><br />
                                    <asp:TextBox CssClass="caja_de_texto" ID="SMO_Apellido_Cliente" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label CssClass="etiquetas" ID="Label96" runat="server" Text="Documento de Identidad:"></asp:Label><br />
                                    <asp:TextBox CssClass="caja_de_texto" ID="SMO_Doc_Identidad" runat="server"></asp:TextBox>
                                </td>

                            </tr>
                        </table>

                    </div>

                    <hr />
                    <div class="Texto_Informativo_SMO">Información Actual de Servicios:</div>
                    <div class="SMO_Contenedor">
                        <div class="Texto_Informativo_SMO_2">Mix Básico:</div>
                        <div>
                            <table>
                                <tr>
                                    <td>
                                        <asp:Label CssClass="etiquetas" ID="Label100" runat="server" Text="Paquete Actual:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="SMO_Mix_Basico" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <div class="Texto_Informativo_SMO_2">Servicios Principales:</div>
                        <div>
                            <table>
                                <tr>
                                    <td>
                                        <asp:Label CssClass="etiquetas" ID="Label97" runat="server" Text="Televisión:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="SMO_Television" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="etiquetas" ID="Label98" runat="server" Text="Internet:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="SMO_Internet" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="etiquetas" ID="Label99" runat="server" Text="Telefonía:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="SMO_Telefonia" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <div class="Texto_Informativo_SMO_2">Servicios Adicionales:</div>
                        <div>
                            <table>
                                <tr>
                                    <td>
                                        <asp:Label CssClass="etiquetas" ID="Label101" runat="server" Text="Servicio HD:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="SMO_HD" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="etiquetas" ID="Label102" runat="server" Text="Servicio HBO:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="SMO_HBO" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="etiquetas" ID="Label103" runat="server" Text="Servicio FOX:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="SMO_Fox" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="etiquetas" ID="Label104" runat="server" Text="Servicio Adulto:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="SMO_Servicio_Adulto" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="etiquetas" ID="Label105" runat="server" Text="Servicio Claro Video:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="SMO_Servicio_Claro_Video" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="etiquetas" ID="Label106" runat="server" Text="Número Decos:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="SMO_Num_Decos" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label CssClass="etiquetas" ID="Label107" runat="server" Text="Revista:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="SMO_Revista" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="etiquetas" ID="Label108" runat="server" Text="Elegido Fijo Móvil:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="SMO_Elegido_Fijo_Movil" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="etiquetas" ID="Label109" runat="server" Text="Siembra HD:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="SMO_Siembra_HD" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="etiquetas" ID="Label112" runat="server" Text="Blindaje Internet:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="SMO_Blindaje_Internet" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="etiquetas" ID="Label110" runat="server" Text="Siembra VOZ:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="SMO_Siembra_Voz" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="etiquetas" ID="Label111" runat="server" Text="Activación Claro Video:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="SMO_Activacion_Claro_Video" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                    <hr />
                    <div class="Texto_Informativo_SMO">Ofrecimientos:</div>

                </ContentTemplate>
            </asp:UpdatePanel>

            <div id="SMO_Ofrecimiento_1">
                <div class="SMO_Contenedor">
                    <table class="tabla">
                        <tr>
                            <td colspan="6">
                                <div class="Titulo_Ofrecimientos">
                                    <p class="etiquetas_Ofrecimiento">Primer Ofrecimiento:</p>
                                </div>
                                <asp:UpdatePanel runat="server">
                                    <ContentTemplate>
                                        <asp:TextBox CssClass="ofrecimientos" ID="SMO_T_Ofrecimiento_1" runat="server" TextMode="MultiLine"></asp:TextBox>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="6">
                                <p class="etiquetas_Ofrecimiento2">
                                    El cliente acepto este ofrecimiento?
                                </p>
                                &nbsp;<asp:RadioButton ID="SMO_Radio_1" runat="server" GroupName="1" Text="SI" Font-Names="Century Gothic" Font-Size="Small" />
                                &nbsp; &nbsp; 
                         <asp:RadioButton ID="SMO_Radio_2" runat="server" GroupName="1" Text="NO" Font-Names="Century Gothic" Font-Size="Small" />
                            </td>

                        </tr>
                    </table>
                </div>
            </div>

            <div id="SMO_Ofrecimiento_2" style="display: none">
                <hr />
                <div class="SMO_Contenedor">
                    <table class="tabla">
                        <tr>
                            <td colspan="6">
                                <div class="Titulo_Ofrecimientos">
                                    <p class="etiquetas_Ofrecimiento">Segundo Ofrecimiento:</p>
                                </div>
                                <asp:UpdatePanel runat="server">
                                    <ContentTemplate>
                                        <asp:TextBox CssClass="ofrecimientos" ID="SMO_T_Ofrecimiento_2" runat="server" TextMode="MultiLine"></asp:TextBox>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="6">
                                <p class="etiquetas_Ofrecimiento2">
                                    El cliente acepto este ofrecimiento?
                                </p>
                                &nbsp;<asp:RadioButton ID="SMO_Radio_3" runat="server" GroupName="1" Text="SI" Font-Names="Century Gothic" Font-Size="Small" />
                                &nbsp; &nbsp; 
                         <asp:RadioButton ID="SMO_Radio_4" runat="server" GroupName="1" Text="NO" Font-Names="Century Gothic" Font-Size="Small" />
                            </td>

                        </tr>
                    </table>
                </div>
            </div>

            <div id="SMO_Ofrecimiento_3" style="display: none">
                <hr />
                <div class="SMO_Contenedor">
                    <table class="tabla">
                        <tr>
                            <td colspan="6">
                                <div class="Titulo_Ofrecimientos">
                                    <p class="etiquetas_Ofrecimiento">Tercer Ofrecimiento:</p>
                                </div>
                                <asp:UpdatePanel runat="server">
                                    <ContentTemplate>
                                        <asp:TextBox CssClass="ofrecimientos" ID="SMO_T_Ofrecimiento_3" runat="server" TextMode="MultiLine"></asp:TextBox>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="6">
                                <p class="etiquetas_Ofrecimiento2">
                                    El cliente acepto este ofrecimiento?
                                </p>
                                &nbsp;<asp:RadioButton ID="SMO_Radio_5" runat="server" GroupName="1" Text="SI" Font-Names="Century Gothic" Font-Size="Small" />
                                &nbsp; &nbsp; 
                         <asp:RadioButton ID="SMO_Radio_6" runat="server" GroupName="1" Text="NO" Font-Names="Century Gothic" Font-Size="Small" />
                            </td>

                        </tr>
                    </table>
                </div>
            </div>

            <div id="SMO_Paleta_de_Servicios" style="display: none">
                <hr />
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <div class="Texto_Informativo_SMO">Paleta de Servicios:</div>
                        <div class="SMO_Contenedor">
                            <div class="Texto_Informativo_SMO_2">Servicios Principales</div>
                            <table class="tabla2">
                                <tr>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_VOZ" runat="server" />
                                            <asp:Label ID="Label123" AssociatedControlID="SMO_S_VOZ" runat="server"
                                                Text="Telefonía" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                            </table>
                            <table class="tabla2">
                                <tr>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_ANALOGA" runat="server" />
                                            <asp:Label ID="Label113" AssociatedControlID="SMO_S_ANALOGA" runat="server"
                                                Text="Televisión Análoga" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_AVANZADA" runat="server" />
                                            <asp:Label ID="Label114" AssociatedControlID="SMO_S_AVANZADA" runat="server"
                                                Text="Televisión Avanzada" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_BASICA" runat="server" />
                                            <asp:Label ID="Label115" AssociatedControlID="SMO_S_BASICA" runat="server"
                                                Text="Televisión Básica" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_SATELITAL" runat="server" />
                                            <asp:Label ID="Label116" AssociatedControlID="SMO_S_SATELITAL" runat="server"
                                                Text="Televisión Satelital" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                            </table>
                            <table class="tabla2">
                                <tr>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_INTERNET_3M" runat="server" />
                                            <asp:Label ID="Label117" AssociatedControlID="SMO_S_INTERNET_3M" runat="server"
                                                Text="Internet 3 Megas" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_INTERNET_5M" runat="server" />
                                            <asp:Label ID="Label118" AssociatedControlID="SMO_S_INTERNET_5M" runat="server"
                                                Text="Internet 5 Megas" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_INTERNET_10M" runat="server" />
                                            <asp:Label ID="Label119" AssociatedControlID="SMO_S_INTERNET_10M" runat="server"
                                                Text="Internet 10 Megas" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_INTERNET_20M" runat="server" />
                                            <asp:Label ID="Label120" AssociatedControlID="SMO_S_INTERNET_20M" runat="server"
                                                Text="Internet 20 Megas" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_INTERNET_50M" runat="server" />
                                            <asp:Label ID="Label121" AssociatedControlID="SMO_S_INTERNET_50M" runat="server"
                                                Text="Internet 50 Megas" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_INTERNET_100M" runat="server" />
                                            <asp:Label ID="Label122" AssociatedControlID="SMO_S_INTERNET_100M" runat="server"
                                                Text="Internet 100 Megas" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <br />
                        <div class="SMO_Contenedor">
                            <div class="Texto_Informativo_SMO_2">Servicios Adicionales</div>
                            <table class="tabla2">
                                <tr>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_CLARO_VIDEO" runat="server" />
                                            <asp:Label ID="Label124" AssociatedControlID="SMO_S_CLARO_VIDEO" runat="server"
                                                Text="Claro Video" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_FOX" runat="server" />
                                            <asp:Label ID="Label125" AssociatedControlID="SMO_S_FOX" runat="server"
                                                Text="Fox +" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_GOLDEN_PREMIER_HD" runat="server" />
                                            <asp:Label ID="Label126" AssociatedControlID="SMO_S_GOLDEN_PREMIER_HD" runat="server"
                                                Text="Golden Premier HD" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_HBO" runat="server" />
                                            <asp:Label ID="Label127" AssociatedControlID="SMO_S_HBO" runat="server"
                                                Text="HBO" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_HD" runat="server" />
                                            <asp:Label ID="Label128" AssociatedControlID="SMO_S_HD" runat="server"
                                                Text="HD" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_HOTPACK" runat="server" />
                                            <asp:Label ID="Label129" AssociatedControlID="SMO_S_HOTPACK" runat="server"
                                                Text="Hot Pack" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_INTERNET_MOVIL_1_5" runat="server" />
                                            <asp:Label ID="Label130" AssociatedControlID="SMO_S_INTERNET_MOVIL_1_5" runat="server"
                                                Text="Internet Móvil 1.5" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_INTERNET_MOVIL_750" runat="server" />
                                            <asp:Label ID="Label144" AssociatedControlID="SMO_S_INTERNET_MOVIL_750" runat="server"
                                                Text="Internet Móvil 750" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_IP_FIJA" runat="server" />
                                            <asp:Label ID="Label131" AssociatedControlID="SMO_S_IP_FIJA" runat="server"
                                                Text="IP Fija" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_LOCAL_EXTENDIDA" runat="server" />
                                            <asp:Label ID="Label132" AssociatedControlID="SMO_S_LOCAL_EXTENDIDA" runat="server"
                                                Text="Local extendida" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_MACAFEE" runat="server" />
                                            <asp:Label ID="Label133" AssociatedControlID="SMO_S_MACAFEE" runat="server"
                                                Text="Macafee" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_MINI_FOX" runat="server" />
                                            <asp:Label ID="Label134" AssociatedControlID="SMO_S_MINI_FOX" runat="server"
                                                Text="Mini Fox" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_MINI_HBO" runat="server" />
                                            <asp:Label ID="Label135" AssociatedControlID="SMO_S_MINI_HBO" runat="server"
                                                Text="Mini HBO" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_MODEM_ADICIONAL" runat="server" />
                                            <asp:Label ID="Label136" AssociatedControlID="SMO_S_MODEM_ADICIONAL" runat="server"
                                                Text="Modem Adicional" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>

                                </tr>
                                <tr>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_PVR" runat="server" />
                                            <asp:Label ID="Label137" AssociatedControlID="SMO_S_PVR" runat="server"
                                                Text="PVR" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_PVR_HD" runat="server" />
                                            <asp:Label ID="Label138" AssociatedControlID="SMO_S_PVR_HD" runat="server"
                                                Text="PVR + HD" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_REVISTA" runat="server" />
                                            <asp:Label ID="Label139" AssociatedControlID="SMO_S_REVISTA" runat="server"
                                                Text="Revista 15 Min" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_SEGUNDO_MODEM" runat="server" />
                                            <asp:Label ID="Label141" AssociatedControlID="SMO_S_SEGUNDO_MODEM" runat="server"
                                                Text="Segundo Modem" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_UFC" runat="server" />
                                            <asp:Label ID="Label142" AssociatedControlID="SMO_S_UFC" runat="server"
                                                Text="UFC Network" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="SingleCheckbox">
                                            <asp:CheckBox ID="SMO_S_VOD" runat="server" />
                                            <asp:Label ID="Label143" AssociatedControlID="SMO_S_VOD" runat="server"
                                                Text="VOD" CssClass="CheckBoxLabel"></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>

            <hr />
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <div id="SMO_Arbol_de_Tipificacion">
                        <div class="Texto_Informativo_SMO">Árbol de Tipificación:</div>
                        <div class="SMO_Contenedor">
                            <table>
                                <tr>
                                    <td>
                                        <asp:DropDownList CssClass="dropdown1" ID="SMO_TIPO_CONTACTO" OnSelectedIndexChanged="SMO_TIPO_CONTACTO_SelectedIndexChanged" runat="server" AutoPostBack="true"></asp:DropDownList>
                                    </td>
                                    <td>
                                        <asp:DropDownList CssClass="dropdown2" ID="SMO_GESTION" OnSelectedIndexChanged="SMO_GESTION_SelectedIndexChanged" runat="server" AutoPostBack="true"></asp:DropDownList>
                                    </td>
                                    <td>
                                        <asp:DropDownList CssClass="dropdown3" ID="SMO_CIERRE" OnSelectedIndexChanged="SMO_CIERRE_SelectedIndexChanged" runat="server" AutoPostBack="true"></asp:DropDownList>
                                    </td>
                                    <td>
                                        <asp:DropDownList CssClass="dropdown3" ID="SMO_RAZON" runat="server"></asp:DropDownList>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>

                    <hr />
                    <div id="SMO_Observaciones">
                        <div class="Texto_Informativo_SMO">Observaciones:</div>
                        <div class="SMO_Contenedor">
                            <asp:TextBox CssClass="ofrecimientos" ID="SMO_Notas" runat="server" TextMode="MultiLine" autocomplete="off"></asp:TextBox>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
            <hr />
            <div id="SMO_Guardar">
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <asp:Button CssClass="button" ID="SMO_Guardar_Datos" runat="server" Text="Guardar" OnClick="SMO_Guardar_Datos_Click" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>

        </div>
    </div>
    <!-- ESTA PARTE ES PARA MOSTRAR EL IFRAME DE SIEMBRA HD-->
    <div class="modal-wrapper" id="Iframe_HD" style="display: none">
        <div class="Iframe_HD-contenedor">
            <a id="Iframe_HD_Cerrar" class="Iframe_HD-cerrar" href="#">X</a>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <h2>FORMULARIO SIEMBRA HD</h2>
                    <hr />
                    <div class="Texto_Informativo_SMO">Ofrecimiento</div>

                    <div class="SMO_Contenedor" onmouseover="this.style.background-color=red;" >
                        <table class="tabla">
                            <tr>
                                <td colspan="6">
                                    
                                    <asp:UpdatePanel runat="server">
                                        <ContentTemplate>
                                            <asp:TextBox CssClass="ofrecimientos" ID="S_HD_OFRECIMIENTO" runat="server" TextMode="MultiLine"></asp:TextBox>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="6">
                                    <p class="etiquetas_Ofrecimiento2">
                                        El cliente acepto?
                                    </p>
                                    &nbsp;<asp:RadioButton ID="RadioButton15" runat="server" GroupName="1" Text="SI" Font-Names="Century Gothic" Font-Size="Small" />
                                    &nbsp; &nbsp; 
                         <asp:RadioButton ID="RadioButton16" runat="server" GroupName="1" Text="NO" Font-Names="Century Gothic" Font-Size="Small" />
                                </td>

                            </tr>
                        </table>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
            <hr />
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:Button CssClass="button" ID="SHD_Guardar" runat="server" Text="Guardar" OnClick="SHD_Guardar_Click"/>
                </ContentTemplate>
            </asp:UpdatePanel>

        </div>
    </div>
    <!-- ESTA PARTE ES PARA MOSTRAR EL IFRAME DE ESCALAMIENTOS AL BACK ELITE-->
    <div class="modal-wrapper" id="Iframe_Back_Elite" style="display: none">
        <div class="Iframe_Back_Elite-contenedor">
            <a id="Iframe_Back_Elite_Cerrar" class="Iframe_Back_Elite-cerrar" href="#" onclick="return Cerrar_Ventana_BackElite()">X</a>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <h2>FORMULARIO PARA ESCALAMIENTOS AL BACK ELITE</h2>
                    <hr />
                    <div class="contenido">
                        <asp:Button CssClass="button" ID="BE_Cargar_Datos" runat="server" Text="Cargar_Datos" Style="display: none" OnClick="BE_Cargar_Datos_Click" />
                        <table>
                            <tr>
                                <td>
                                    <p class="etiquetas_Ofrecimiento2">Cuenta Cliente:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="BE_Cuenta" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                                 <td>
                                    <p class="etiquetas_Ofrecimiento2">Lls/Ots:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="BE_LlsOt" runat="server" Placeholder="Ingre Lls/Ots"></asp:TextBox>
                                </td>
                                 <td>
                                    <p class="etiquetas_Ofrecimiento2">Tipo de Escalamiento:</p>
                                        <asp:DropDownList CssClass="dropdown2" ID="BE_Tipo_Escalamiento"  runat="server" AutoPostBack="true"></asp:DropDownList>
                                </td>
                                 <td>
                                    <p class="etiquetas_Ofrecimiento2">Detalle Escalamiento:</p>
                                        <asp:DropDownList CssClass="dropdown3" ID="BE_Detalle_Escalamiento" runat="server" AutoPostBack="true"></asp:DropDownList>
                                </td>
                                 <td>
                                    <p class="etiquetas_Ofrecimiento2">Nodo:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="BE_Nodo" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                 <td colspan="5">
                                    <p class="etiquetas_Ofrecimiento2">Observaciones:</p>
                                       <asp:TextBox CssClass="ofrecimientos" ID="BE_Observaciones" runat="server" TextMode="MultiLine" autocomplete="off"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                        <hr />
                         <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:Button CssClass="button" ID="Button2" runat="server" Text="Guardar"/>
                </ContentTemplate>
            </asp:UpdatePanel>
                    </div>
                        </ContentTemplate>
            </asp:UpdatePanel>

        </div>
    </div>
    <!-- ESTA PARTE ES PARA MOSTRAR EL IFRAME DE ESCALAMIENTOS A TRASLADOS PARA CREAR DIRECCION-->
    <div class="modal-wrapper" id="Iframe_T_Crear_Direccion" style="display: none">
        <div class="Iframe_T_Crear_Direccion-contenedor">
            <a id="Iframe_T_Crear_Direccion_Cerrar" class="Iframe_T_Crear_Direccion-cerrar" href="#" onclick="return Cerrar_Ventana_T_Crear_Direccion()">X</a>
            
                    <h2>ESCALAMIENTO A TRASLADOS - SOLICITUD DE CREACION DE DIRECCION</h2>
                    <hr />
                   <asp:UpdatePanel runat="server"><ContentTemplate>
                            <table><tr>
                                <td>
                                        <p class="etiquetas_Ofrecimiento2">Tipo de Dirección:</p>
                                        <asp:DropDownList CssClass="dropdown1" ID="TCD_Tipo_de_Direccion" runat="server" AutoPostBack="true" OnSelectedIndexChanged="TCD_Tipo_de_Direccion_SelectedIndexChanged" style="width:180px;">
                                           <asp:ListItem Text="--SELECCIONE--" Value="SELECCIONE"></asp:ListItem>
                                             <asp:ListItem Text="Basica" Value="Basica"></asp:ListItem>
                                            <asp:ListItem Text="Barrio Manzana" Value="Barrio Manzana"></asp:ListItem>
                                            <asp:ListItem Text="Intraducible" Value="Intraducible"></asp:ListItem>
                                            <asp:ListItem Text="Multiorigen" Value="Multiorigen"></asp:ListItem>
                                        </asp:DropDownList>
                                </td>

                                   </tr></table>
                        </ContentTemplate></asp:UpdatePanel>
                    <div id="Dir_Basica" style="display:none">
                        <asp:UpdatePanel runat="server"><ContentTemplate>
                        <table>
                            <tr>
                                <td>
                                    <p class="etiquetas_Ofrecimiento2">Tipo de Vía:</p>
                                        <asp:DropDownList CssClass="dropdown1" ID="TCDB_Tipo_de_Via" runat="server" style="width:180px;">
                                            <asp:ListItem>--SELECCIONE--</asp:ListItem>
                                            <asp:ListItem>ANILLO</asp:ListItem>
                                            <asp:ListItem>AUTOPISTA</asp:ListItem>
                                            <asp:ListItem>AV</asp:ListItem>
                                            <asp:ListItem>AVCL</asp:ListItem>
                                            <asp:ListItem>AVCR</asp:ListItem>
                                            <asp:ListItem>BARIO</asp:ListItem>
                                            <asp:ListItem>CARRETERA</asp:ListItem>
                                            <asp:ListItem>CIR</asp:ListItem>
                                            <asp:ListItem>CIRCUNVALAR</asp:ListItem>
                                            <asp:ListItem>CL</asp:ListItem>
                                            <asp:ListItem>CR</asp:ListItem>
                                            <asp:ListItem>DG</asp:ListItem>
                                            <asp:ListItem>TR</asp:ListItem>
                                        </asp:DropDownList>
                                </td>
                                <td>
                                    <p class="etiquetas_Ofrecimiento2">Vía Principal:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCDB_Via_Principal" runat="server" Placeholder="Ingrese via" style="width:180px;" AutoPostBack="true" OnTextChanged="TCDB_Via_Principal_TextChanged"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas_Ofrecimiento2">Cuadrante:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCDB_Cuadrante" runat="server" Placeholder="Ingrese cuadrante" style="width:180px;" AutoPostBack="true" OnTextChanged="TCDB_Cuadrante_TextChanged"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas_Ofrecimiento2">Placa:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCDB_Placa" runat="server" Placeholder="Ingrese Placa" style="width:180px;" AutoPostBack="true" OnTextChanged="TCDB_Placa_TextChanged"></asp:TextBox>
                                </td>
                                 <td>
                                    <p class="etiquetas_Ofrecimiento2">Complemento:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCDB_Complemento" runat="server" Placeholder="Ingrese complemento" style="width:180px;" AutoPostBack="true" OnTextChanged="TCDB_Complemento_TextChanged"></asp:TextBox>
                                </td>
                                </tr>
                            <tr>
                                <td colspan="5">
                                 <p class="etiquetas_Ofrecimiento2">Dirección Final:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCDB_Direccion" runat="server" style="width:580px;" Enabled="false"></asp:TextBox>
                            </td>
                                    </tr>
                            <tr>
                                 <td colspan="5">
                                    <p class="etiquetas_Ofrecimiento2">Observaciones:</p>
                                    <asp:TextBox CssClass="notas_casos" ID="TCDB_Observaciones" runat="server" Placeholder="Ingrese una observacion"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                            </ContentTemplate></asp:UpdatePanel>
                    </div>
                                 <div id="Dir_Multiorigen" style="display:none">
                                      <asp:UpdatePanel runat="server"><ContentTemplate>
                        <table>
                            <tr>
                                <td>
                                    <p class="etiquetas_Ofrecimiento2">Tipo de Vía:</p>
                                        <asp:DropDownList CssClass="dropdown1" ID="TCDM_Tipo_de_via" runat="server" style="width:150px;">
                                            <asp:ListItem>--SELECCIONE--</asp:ListItem>
                                            <asp:ListItem>ANILLO</asp:ListItem>
                                            <asp:ListItem>AUTOPISTA</asp:ListItem>
                                            <asp:ListItem>AV</asp:ListItem>
                                            <asp:ListItem>AVCL</asp:ListItem>
                                            <asp:ListItem>AVCR</asp:ListItem>
                                            <asp:ListItem>BARIO</asp:ListItem>
                                            <asp:ListItem>CARRETERA</asp:ListItem>
                                            <asp:ListItem>CIR</asp:ListItem>
                                            <asp:ListItem>CIRCUNVALAR</asp:ListItem>
                                            <asp:ListItem>CL</asp:ListItem>
                                            <asp:ListItem>CR</asp:ListItem>
                                            <asp:ListItem>DG</asp:ListItem>
                                            <asp:ListItem>TR</asp:ListItem>
                                        </asp:DropDownList>
                                </td>
                                <td>
                                    <p class="etiquetas_Ofrecimiento2">Vía Principal:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCDM_Via_Principal" runat="server" Placeholder="Ingrese via" style="width:150px;" AutoPostBack="true" OnTextChanged="TCDM_Via_Principal_TextChanged"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas_Ofrecimiento2">Cuadrante:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCDM_Cuadrante" runat="server" Placeholder="Ingrese cuadrante" style="width:150px;" AutoPostBack="true" OnTextChanged="TCDM_Cuadrante_TextChanged"></asp:TextBox>
                                </td>
                                 <td>
                                    <p class="etiquetas_Ofrecimiento2">Barrio:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCDM_Barrio" runat="server" Placeholder="Ingrese Barrio" style="width:150px;" AutoPostBack="true" OnTextChanged="TCDM_Barrio_TextChanged"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas_Ofrecimiento2">Placa:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCDM_Placa" runat="server" Placeholder="Ingrese Placa" style="width:150px;" AutoPostBack="true" OnTextChanged="TCDM_Placa_TextChanged"></asp:TextBox>
                                </td>
                                 <td>
                                    <p class="etiquetas_Ofrecimiento2">Complemento:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCDM_Complemento" runat="server" Placeholder="Ingrese complemento" style="width:150px;" AutoPostBack="true" OnTextChanged="TCDM_Complemento_TextChanged"></asp:TextBox>
                                </td>
                                </tr>
                             <tr><td colspan="6">
                                 <p class="etiquetas_Ofrecimiento2">Dirección Final:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCDM_Direccion_Final" runat="server" style="width:580px;" Enabled="false"></asp:TextBox>
                            </td>
                                 </tr>
                            <tr>
                                 <td colspan="6">
                                    <p class="etiquetas_Ofrecimiento2">Observaciones:</p>
                                    <asp:TextBox CssClass="notas_casos" ID="TCDM_Observaciones" runat="server" Placeholder="Ingrese una observacion"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                                          </ContentTemplate></asp:UpdatePanel>
                    </div>
                      <div id="Dir_Barrio_Manzana" style="display:none">
                           <asp:UpdatePanel runat="server"><ContentTemplate>
                        <table>
                            <tr>
                                <td>
                                    <p class="etiquetas_Ofrecimiento2">Barrio:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCDBM_Barrio" runat="server" Placeholder="Ingrese Barrio" style="width:180px;" AutoPostBack="true" OnTextChanged="TCDBM_Barrio_TextChanged"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas_Ofrecimiento2">Placa:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCDBM_Placa" runat="server" Placeholder="Ingrese Placa" style="width:180px;" AutoPostBack="true" OnTextChanged="TCDBM_Placa_TextChanged"></asp:TextBox>
                                </td>
                                 <td>
                                    <p class="etiquetas_Ofrecimiento2">Complemento:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCDBM_Complemento" runat="server" Placeholder="Ingrese complemento" style="width:180px;" AutoPostBack="true" OnTextChanged="TCDBM_Complemento_TextChanged"></asp:TextBox>
                                </td>
                                </tr>
                            </table>
                             <table>
                            <tr>
                                <td>
                                 <p class="etiquetas_Ofrecimiento2">Dirección Final:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCDBM_Direccion_Final" runat="server" style="width:580px;" Enabled="false"></asp:TextBox>
                            </td>
                                </tr>
                           
                                </table>
                                <table>
                                    <tr>
                                 <td>
                                    <p class="etiquetas_Ofrecimiento2">Observaciones:</p>
                                    <asp:TextBox CssClass="notas_casos" ID="TCDBM_Observaciones" runat="server" Placeholder="Ingrese una observacion"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                               </ContentTemplate></asp:UpdatePanel>
                    </div>
                     <div id="Dir_Intraducible" style="display:none">
                          <asp:UpdatePanel runat="server"><ContentTemplate>
                        <table>
                            <tr>
                                <td>
                                    <p class="etiquetas_Ofrecimiento2">Vía o Vereda:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCDI_Via_Vereda" runat="server" Placeholder="Ingrese via o vereda" style="width:150px;" AutoPostBack="true" OnTextChanged="TCDI_Via_Vereda_TextChanged"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas_Ofrecimiento2">Nombre Vereda o Via:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCDI_Nombre_Via" runat="server" Placeholder="Ingrese nombre via" style="width:150px;" AutoPostBack="true" OnTextChanged="TCDI_Nombre_Via_TextChanged"></asp:TextBox>
                                </td>
                                 <td>
                                    <p class="etiquetas_Ofrecimiento2">KM:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCDI_Kilometro" runat="server" Placeholder="Ingrese kilometro" style="width:150px;" AutoPostBack="true" OnTextChanged="TCDI_Kilometro_TextChanged"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas_Ofrecimiento2">Sector:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCDI_Sector" runat="server" Placeholder="Ingrese sector" style="width:150px;" AutoPostBack="true" OnTextChanged="TCDI_Sector_TextChanged"></asp:TextBox>
                                </td>
                                 <td>
                                    <p class="etiquetas_Ofrecimiento2">Nombre del Sector:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCDI_Nombre_Sector" runat="server" Placeholder="Ingrese nombre sector" style="width:150px;" AutoPostBack="true" OnTextChanged="TCDI_Nombre_Sector_TextChanged"></asp:TextBox>
                                </td>
                                
                                 <td>
                                    <p class="etiquetas_Ofrecimiento2">Urb o Finca:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCDI_Urb_O_Finca" runat="server" Placeholder="Ingrese urb o finca" style="width:150px;" AutoPostBack="true" OnTextChanged="TCDI_Urb_O_Finca_TextChanged"></asp:TextBox>
                                </td>
                                </tr>
                            <tr>
                                 <td>
                                    <p class="etiquetas_Ofrecimiento2">Placa:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCDI_Placa" runat="server" Placeholder="Ingrese placa" style="width:150px;" AutoPostBack="true" OnTextChanged="TCDI_Placa_TextChanged"></asp:TextBox>
                                </td>
                                
                                 <td>
                                    <p class="etiquetas_Ofrecimiento2">Complemento:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCDI_Complemento" runat="server" Placeholder="Ingrese complemento" style="width:150px;" AutoPostBack="true" OnTextChanged="TCDI_Complemento_TextChanged"></asp:TextBox>
                                </td>
                            </tr>
                             <tr><td colspan="6">
                                 <p class="etiquetas_Ofrecimiento2">Dirección Final:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCDI_Direccion_Final" runat="server" style="width:580px;" Enabled="false"></asp:TextBox>
                            </td>
                                 </tr>
                            <tr>
                                 <td colspan="6">
                                    <p class="etiquetas_Ofrecimiento2">Observaciones:</p>
                                    <asp:TextBox CssClass="notas_casos" ID="TCDI_Observaciones" runat="server" Placeholder="Ingrese una observacion"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                              </ContentTemplate></asp:UpdatePanel>
                    </div>
                      
                    <div id="Datos_Adicionales_de_Captura">
                        <table>
                            <tr>
                                  <td>
                                    <p class="etiquetas_Ofrecimiento2">Estrato:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCD_Estrato" runat="server" Placeholder="Ingrese el estrato" style="width:150px;"></asp:TextBox>
                                </td>
                                  <td>
                                    <p class="etiquetas_Ofrecimiento2">Cuenta:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCD_Cuenta" runat="server" Placeholder="Ingrese la cuenta" style="width:150px;"></asp:TextBox>
                                </td>
                                  <td>
                                    <p class="etiquetas_Ofrecimiento2">Nodo:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCD_Nodo" runat="server" Placeholder="Ingrese el nodo" style="width:150px;"></asp:TextBox>
                                </td>
                                  <td>
                                    <p class="etiquetas_Ofrecimiento2">Red:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCD_Red" runat="server" Placeholder="Ingrese el tipo de red" style="width:150px;"></asp:TextBox>
                                </td>
                                  <td>
                                    <p class="etiquetas_Ofrecimiento2">Teléfono Fijo:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCD_Telefono_Fijo" runat="server" Placeholder="Ingrese telefono" style="width:150px;"></asp:TextBox>
                                </td>
                                  <td>
                                    <p class="etiquetas_Ofrecimiento2">Teléfono Celular:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="TCD_Telefono_Celular" runat="server" Placeholder="Ingrese celular" style="width:150px;"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </div>
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                             <asp:Button CssClass="button" ID="TCD_Guardar" runat="server" Text="Guardar" OnClick="TCD_Guardar_Click"/>
                        </ContentTemplate>
                    </asp:UpdatePanel>

                      
            <script type="text/javascript">
                function Reset_valores() {
                    Validar_Seleccion();
                }
                function Validar_Seleccion() {
                    var Seleccion = document.getElementById('<%=TCD_Tipo_de_Direccion.ClientID%>');
                    
                    if (Seleccion.value == 'Basica') {
                        Ocultar_Div();
                        document.getElementById('Dir_Basica').style.display = 'block';
                    }
                    else 
                        if (Seleccion.value == 'Barrio Manzana') {
                            Ocultar_Div();
                            document.getElementById('Dir_Barrio_Manzana').style.display = 'block';
                        }
                        else 
                            if (Seleccion.value == 'Multiorigen') {
                                Ocultar_Div();
                                document.getElementById('Dir_Multiorigen').style.display = 'block';
                            }
                            else
                                if (Seleccion.value == 'Intraducible') {
                                    Ocultar_Div();
                                    document.getElementById('Dir_Intraducible').style.display = 'block';
                                }
                }
                function Ocultar_Div() {
                   
                    document.getElementById('Dir_Basica').style.display = 'none';
                    document.getElementById('Dir_Multiorigen').style.display = 'none';
                    document.getElementById('Dir_Barrio_Manzana').style.display = 'none';
                    document.getElementById('Dir_Intraducible').style.display = 'none';
                    
                }
                
                function Registro_CD_NO_Almacenado() {
                    alert('Escalamiento no realizado, revisa la informacion suministrada y guarda el registro nuevamente');
                }
            </script>
        </div>
    </div>
</asp:Content>
