<%@ Page Title="" Language="C#" MasterPageFile="~/Perfil_Celula.master" AutoEventWireup="true" CodeFile="Consulta_Gestion_Celula.aspx.cs" Inherits="Consulta_Gestion_Celula" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="jquery/jquery.dropdownPlain.js?1.0.0"></script>
    <script src="javascript/Funciones.js?1.0.0"></script>
    <script src="jquery/jquery.datetimepicker.js?1.0.0"></script>
    <link href="Estilos/jquery.datetimepicker.css?1.0.0" rel="stylesheet" />
    <link href="Estilos/Style_Ingreso_Casos.css?1.0.0" rel="stylesheet" />
 

    <script type="text/javascript">
        function editar(obj) {

            var imageID = document.getElementById('imagen' + obj);
            window.location.href = 'Depuracion_de_Casos.aspx?id=' + obj;
        };
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:Panel CssClass="panel4" ID="Panel1" runat="server">
        <div id="tab-container2">
            <ul class="tab-menu2">
                <li id="html" class="active" onclick="otorgar_permisos()">INTERACCIONES REALIZADAS</li>
            </ul>
            <div class="clear"></div>
            <div class="tab-top-border"></div>
            <div id="html-tab" class="tab-content active">
                <h3 class="Titulos">CONSULTA DE INTERACCIONES EFECTUADAS POR LA CÉLULA O BACK</h3>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Panel CssClass="panel_informativo" ID="Panel6" runat="server" GroupingText="Seleccione el Rango de la Consulta">
                            <table class="tabla">
                                <tr>
                                    <td>
                                        <p class="texto_informativo">Seleccione fecha inicial</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Fecha_Inicial" runat="server" AutoPostBack="true"></asp:TextBox>
                                    </td>
                                    <td class="auto-style24">
                                        <asp:Button CssClass="bt_calendario" ID="Button2" runat="server" Text="" OnClick="Button2_Click" />
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
                                        <asp:TextBox CssClass="caja_de_texto" ID="Fecha_Final" runat="server" AutoPostBack="true"></asp:TextBox>
                                    </td>
                                    <td class="auto-style24">
                                        <asp:Button CssClass="bt_calendario" ID="Button3" runat="server" Text="" OnClick="Button3_Click" />
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
                        <asp:Panel CssClass="panel_informativo" ID="Panel2" runat="server" GroupingText="Resultado de la Consulta">
                            <asp:GridView CssClass="mGrid2" ID="GVINGRESOS" runat="server" AutoGenerateColumns="False" OnPageIndexChanging="GVINGRESOS_PageIndexChanging">
                                <Columns>
                                    <asp:TemplateField ShowHeader="False" HeaderText="EDITAR">
                                        <ItemTemplate>
                                            <a href='javascript:editar("<%# Eval("ID_INGRESO") %>");'>
                                                <img class="c1" id='imageningreso_<%# Eval("ID_INGRESO") %>' alt="Clic para mostrar u ocultar" src="Estilos/Imagenes/edita.png" />
                                            </a>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="ID_INTERACCION" HeaderText="ID DE INTERACCION" />
                                    <asp:BoundField DataField="ID_INGRESO" HeaderText="ID DE INGRESO" />
                                    <asp:BoundField DataField="FECHA_INTERACCION" HeaderText="FECHA DE INTERACCION" />
                                    <asp:BoundField DataField="HORA_INTERACCION" HeaderText="HORA DE INTERACCION" />
                                    <asp:BoundField DataField="USUARIO_INTERACCION" HeaderText="USUARIO DE INTERACCION" />
                                    <asp:BoundField DataField="NOTA" HeaderText="NOTA" />
                                    <asp:BoundField DataField="CUENTA_CLIENTE" HeaderText="CUENTA CLIENTE" />
                                    <asp:BoundField DataField="FECHA_APERTURA" HeaderText="FECHA DE APERTURA" />
                                    <asp:BoundField DataField="USUARIO_APERTURA" HeaderText="USUARIO DE APERTURA" />
                                    <asp:BoundField DataField="MACROPROCESO" HeaderText="MACROPROCESO" />
                                    <asp:BoundField DataField="PROCESO" HeaderText="PROCESO" />
                                    <asp:BoundField DataField="SUBPROCESO" HeaderText="SUBPROCESO" />
                                    <asp:BoundField DataField="MARCACION" HeaderText="MARCACION" />
                                    <asp:BoundField DataField="NOMBRE_LINEA_INGRESO" HeaderText="NOMBRE LINEA DE INGRESO" />
                                    <asp:BoundField DataField="NOMBRE_LINEA_ESCALADO" HeaderText="NOMBRE LINEA ESCALADO" />
                                    <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" />
                                    <asp:TemplateField Visible="False"></asp:TemplateField>
                                    <asp:ImageField DataImageUrlField="SEMAFORO" DataImageUrlFormatString="~/Estilos/Imagenes/{0}" HeaderText="SEMAFORO" ItemStyle-HorizontalAlign="Center" ControlStyle-Width="20px">
                                        <ControlStyle Width="20px"></ControlStyle>
                                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                    </asp:ImageField>
                                </Columns>
                            </asp:GridView>
                        </asp:Panel>
                        <asp:Label ID="Label1" runat="server" Text="Label" Style="display: none"></asp:Label>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <asp:Button CssClass="button" ID="Exportar" runat="server" Text="Exportar" OnClick="Exportar_Click" />
            </div>
        </div>
    </asp:Panel>
</asp:Content>

