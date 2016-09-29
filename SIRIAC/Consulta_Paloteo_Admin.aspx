<%@ Page Title="" Language="C#" MasterPageFile="~/Perfil_Administrador.master" AutoEventWireup="true" CodeFile="Consulta_Paloteo_Admin.aspx.cs" Inherits="Consulta_Paloteo_Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <link href="Estilos/Style_Perfil_Asesor.css?1.0.0" rel="stylesheet" />
    <link href="Estilos/Style_Ingreso_Casos.css?1.0.0" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:Panel CssClass="panel4" ID="Panel1" runat="server">

        <div id="tab-container2">
            <ul class="tab-menu2">
                <li id="html" class="active" onclick="otorgar_permisos()">PALOTEO OPERACIONAL</li>
            </ul>
            <div class="clear"></div>
            <div class="tab-top-border"></div>
            <div id="html-tab" class="tab-content active">
                <asp:Label ID="Label2" runat="server" Text="Label" Style="display: none"></asp:Label>
                <asp:Label ID="Label3" runat="server" Text="Label" Style="display: none"></asp:Label>
                <asp:Label ID="Label4" runat="server" Text="Label" Style="display: none"></asp:Label>
                <h3 class="Titulos">CONSULTA PALOTEO OPERACIONAL</h3>


                <asp:Panel CssClass="panel_informativo" ID="Panel3" runat="server" GroupingText="Ventana de tiempo para la consulta">
                    <table class="tabla">
                        <tr>
                            <td>
                                <asp:Label CssClass="texto_informativo" ID="Label5" runat="server" Text="Seleccione la fecha inicial:"></asp:Label><br />
                                <asp:TextBox CssClass="caja_de_texto" ID="TextBox3" runat="server" AutoPostBack="true"></asp:TextBox>
                            </td>
                            <td>
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
                            <td class="auto-style21">
                                <p class="texto_informativo">Seleccione fecha final</p>
                                <asp:TextBox CssClass="caja_de_texto" ID="TextBox4" runat="server" AutoPostBack="true"></asp:TextBox>
                            </td>
                            <td>
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

                            <asp:Label ID="Label1" runat="server" Text="Label" Style="display: none"></asp:Label>

                        </tr>

                    </table>
                </asp:Panel>
                <asp:GridView CssClass="mGrid2" ID="PALOTEO" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="PALOTEO_PageIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="ID_INGRESO" HeaderText="ID DE INGRESO" />
                        <asp:BoundField DataField="CUENTA_CLIENTE" HeaderText="CUENTA DEL CLIENTE" />
                        <asp:BoundField DataField="TICKET" HeaderText="TICKET" />
                        <asp:BoundField DataField="USUARIO" HeaderText="USUARIO" />
                        <asp:BoundField DataField="NOMBRE_USUARIO" HeaderText="NOMBRE DE USUARIO" />
                        <asp:BoundField DataField="PERFIL_USUARIO" HeaderText="PERFIL USUARIO" />
                        <asp:BoundField DataField="NOMBRE_LINEA_NOTA" HeaderText="NOMBRE LINEA NOTA" />
                        <asp:BoundField DataField="ALIADO_APERTURA" HeaderText="ALIADO DE APERTURA" />
                        <asp:BoundField DataField="FECHA_INTERACCION" HeaderText="FECHA DE INTERACCION" />
                        <asp:BoundField DataField="HORA_INTERACCION" HeaderText="HORA DE INTERACCION" />
                        <asp:BoundField DataField="CONTACTO_CLIENTE" HeaderText="CONTACTO CLIENTE" />
                        <asp:BoundField DataField="MACROPROCESO" HeaderText="MACROPROCESO" />
                        <asp:BoundField DataField="PROCESO" HeaderText="PROCESO" />
                        <asp:BoundField DataField="SUBPROCESO" HeaderText="SUBPROCESO" />
                        <asp:BoundField DataField="MARCACION" HeaderText="MARCACION" />
                        <asp:BoundField DataField="DIVISION" HeaderText="DIVISION" />
                        <asp:BoundField DataField="AREA" HeaderText="AREA" />
                        <asp:BoundField DataField="ZONA" HeaderText="ZONA" />
                        <asp:BoundField DataField="DISTRITO" HeaderText="DISTRITO" />
                        <asp:BoundField DataField="NOMBRE_COMUNIDAD" HeaderText="NOMBRE COMUNIDAD" />
                        <asp:BoundField DataField="NODO" HeaderText="NODO" />
                        <asp:BoundField DataField="NOTA" HeaderText="NOTA" />
                        <asp:BoundField DataField="ESTADO_CASO" HeaderText="ESTADO CASO" />
                    </Columns>
                    <PagerStyle CssClass="paginador" Font-Names="Arial Unicode MS" Font-Size="X-Large" />
                </asp:GridView>

                <table>
                    <tr>
                        <td class="auto-style25">
                            <asp:Button CssClass="button" ID="Button4" runat="server" Text="Exportar a Excel" OnClick="Button4_Click" />
                        </td>
                    </tr>
                </table>
                <br />

            </div>
        </div>
    </asp:Panel>
</asp:Content>

