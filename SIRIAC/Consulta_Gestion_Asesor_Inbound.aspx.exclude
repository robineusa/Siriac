<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Perfil_Asesor.master" CodeFile="Consulta_Gestion_Asesor_Inbound.aspx.cs" Inherits="Consulta_Gestion_Asesor_Inbound" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script src="jquery/jquery.dropdownPlain.js?1.0.0"></script>
    <script src="javascript/Funciones.js?1.0.0"></script>
    <link href="Estilos/Style_Perfil_Asesor.css?1.0.0" rel="stylesheet" />
    <link href="Estilos/Style_Ingreso_Casos.css?1.0.0" rel="stylesheet" />
    <link href="Estilos/Menu.css?1.0.0" rel="stylesheet" />
    <link href="Estilos/jquery.datetimepicker.css?1.0.0" rel="stylesheet" />
   


    <script type="text/javascript">
        function editar(obj) {

            var imageID = document.getElementById('imagen' + obj);
            window.location.href = 'Actualizar_Casos.aspx?id=' + obj;

        };
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <asp:Panel CssClass="panel4" ID="Panel1" runat="server">

        <div id="tab-container2">
            <ul class="tab-menu2">
                <li id="html" class="active" onclick="otorgar_permisos()">CASOS GESTIONADOS</li>
            </ul>
            <div class="clear"></div>
            <div class="tab-top-border"></div>
            <div id="html-tab" class="tab-content active">

                <h3 class="Titulos">FORMULARIO CONSULTA DE CASOS GESTIONADOS</h3>

                <asp:Panel ID="Panel2" runat="server" CssClass="panel_informativo" GroupingText="Datos de Consulta">
                    <asp:TextBox ID="TextBox1" runat="server" Style="display: none"></asp:TextBox>
                    <table class="tabla">
                        <tr>
                            <td>
                                <p class="texto_informativo">Seleccione fecha inicial</p>
                                <asp:TextBox CssClass="caja_de_texto" ID="Fecha_Inicial" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Button CssClass="bt_calendario" ID="Abrir_Cal_1" runat="server" Text="" OnClick="Abrir_Cal_1_Click" />
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
                                <p class="texto_informativo">Seleccione fecha final</p>
                                <asp:TextBox CssClass="caja_de_texto" ID="Fecha_Final" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Button CssClass="bt_calendario" ID="Abrir_Cal_2" runat="server" Text="" OnClick="Abrir_Cal_2_Click" />
                                <asp:Calendar CssClass="calendario_fecha" ID="Calendar2" runat="server" OnSelectionChanged="Calendar2_SelectionChanged" Visible="false">
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
                        </tr>
                    </table>
                </asp:Panel>
                <asp:GridView CssClass="mGrid" ID="CASOS_GESTIONADOS" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="CASOS_GESTIONADOS_PageIndexChanging">
                    <Columns>
                        <asp:TemplateField ShowHeader="False" HeaderText="EDITAR">
                            <ItemTemplate>
                                <a href='javascript:editar("<%# Eval("ID_INGRESO") %>");'>
                                    <img class="c1" id='imageningreso_<%# Eval("ID_INGRESO") %>' alt="Clic para mostrar u ocultar" src="Estilos/Imagenes/edita.png" />
                                </a>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="ID_INGRESO" HeaderText="ID DE INGRESO" />
                        <asp:BoundField DataField="CUENTA_CLIENTE" HeaderText="CUENTA DEL CLIENTE" />
                        <asp:BoundField DataField="TICKET" HeaderText="TICKET" />
                        <asp:BoundField DataField="NOMBRE_LINEA_INGRESO" HeaderText="NOMBRE LINEA INGRESO" />
                        <asp:BoundField DataField="NOMBRE_LINEA_ESCALADO" HeaderText="NOMBRE LINEA ESCALADO" />
                        <asp:BoundField DataField="ALIADO_APERTURA" HeaderText="ALIADO APERTURA" />
                        <asp:BoundField DataField="FECHA_INTERACCION" HeaderText="FECHA INTERACCION" />
                        <asp:BoundField DataField="FECHA_APERTURA" HeaderText="FECHA APERTURA" />
                        <asp:BoundField DataField="HORA_APERTURA" HeaderText="HORA APERTURA" />
                        <asp:BoundField DataField="FECHA_CIERRE" HeaderText="FECHA CIERRE" />
                        <asp:BoundField DataField="USUARIO_INTERACCION" HeaderText="USUARIO INTERACCION" />
                        <asp:BoundField DataField="USUARIO_APERTURA" HeaderText="USUARIO APERTURA" />
                        <asp:BoundField DataField="USUARIO_CIERRE" HeaderText="USUARIO CIERRE" />
                        <asp:BoundField DataField="FECHA_ULTIMA_ACTUALIZACION" HeaderText="FECHA ULTIMA ACTUALIZACION" />
                        <asp:BoundField DataField="USUARIO_ULTIMA_ACTUALIZACION" HeaderText="USUARIO ULTIMA ACTUALIZACION" />
                        <asp:BoundField DataField="HORA_ULTIMA_ACTUALIZACION" HeaderText="HORA ULTIMA ACTUALIZACION" />
                        <asp:BoundField DataField="MACROPROCESO" HeaderText="MACROPROCESO" />
                        <asp:BoundField DataField="PROCESO" HeaderText="PROCESO" />
                        <asp:BoundField DataField="SUBPROCESO" HeaderText="SUBPROCESO" />
                        <asp:BoundField DataField="MARCACION" HeaderText="MARCACION" />
                        <asp:BoundField DataField="NOTA" HeaderText="NOTA" />
                        <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" />
                    </Columns>
                </asp:GridView>
                <asp:Button CssClass="button" ID="Button1" runat="server" Text="Exportar a Excel" OnClick="Button1_Click" />
            </div>
        </div>

    </asp:Panel>
</asp:Content>
