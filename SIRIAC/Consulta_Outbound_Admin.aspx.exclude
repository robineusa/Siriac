<%@ Page Title="" Language="C#" MasterPageFile="~/Perfil_Administrador.master" AutoEventWireup="true" CodeFile="Consulta_Outbound_Admin.aspx.cs" Inherits="Consulta_Outbound_Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <link href="Estilos/Style_Perfil_Asesor.css?1.0.0" rel="stylesheet" />
    <link href="Estilos/Style_Ingreso_Casos.css?1.0.0" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel CssClass="panel4" ID="Panel1" runat="server">

        <div id="tab-container2">
            <ul class="tab-menu2">
                <li id="html" class="active" onclick="otorgar_permisos()">CONSULTA DE GESTION OUTBOUND</li>
            </ul>
            <div class="clear"></div>
            <div class="tab-top-border"></div>
            <div id="html-tab" class="tab-content active">
                <asp:Label ID="Label2" runat="server" Text="Label" Style="display: none"></asp:Label>
                <asp:Label ID="Label3" runat="server" Text="Label" Style="display: none"></asp:Label>
                <asp:Label ID="Label4" runat="server" Text="Label" Style="display: none"></asp:Label>
                <h3 class="Titulos">CONSULTA DE GESTION OUTBOUND</h3>


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
                <asp:GridView CssClass="mGrid" ID="GVINGRESOS" runat="server" AutoGenerateColumns="False" OnRowDataBound="GINGRESOS_RowDataBound" AllowPaging="True" OnPageIndexChanging="GVINGRESOS_PageIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="FECHA_DE_GESTION" HeaderText="FECHA_DE_GESTION" />
                        <asp:BoundField DataField="HORA_GESTION" HeaderText="HORA_GESTION" />
                        <asp:BoundField DataField="USUARIO_GESTION" HeaderText="USUARIO_GESTION" />
                        <asp:BoundField DataField="ALIADO_GESTION" HeaderText="ALIADO_GESTION" />
                        <asp:BoundField DataField="CIUDAD" HeaderText="CIUDAD" />
                        <asp:BoundField DataField="NODO" HeaderText="NODO" />
                        <asp:BoundField DataField="MIX_BASICO" HeaderText="MIX_BASICO" />
                        <asp:BoundField DataField="TIPO_SERVICIO" HeaderText="TIPO_SERVICIO" />
                        <asp:BoundField DataField="CICLO_FACTURACION" HeaderText="CICLO_FACTURACION" />
                        <asp:BoundField DataField="RENTA" HeaderText="RENTA" />
                        <asp:BoundField DataField="TIPO_TV" HeaderText="TIPO_TV" />
                        <asp:BoundField DataField="VELOCIDAD_INTERNET" HeaderText="VELOCIDAD_INTERNET" />
                        <asp:BoundField DataField="CUENTA_CLIENTE" HeaderText="CUENTA_CLIENTE" />
                        <asp:BoundField DataField="ESTADO_CUENTA" HeaderText="ESTADO_CUENTA" />
                        <asp:BoundField DataField="MOTIVO_DESCONEXION" HeaderText="MOTIVO_DESCONEXION" />
                        <%--<asp:BoundField DataField="NOMBRE_CLIENTE" HeaderText="NOMBRE_CLIENTE" />
                        <asp:BoundField DataField="APELLIDO_1" HeaderText="APELLIDO_1" />
                        <asp:BoundField DataField="APELLIDO_2" HeaderText="APELLIDO_2" />
                        <asp:BoundField DataField="CONTRATO" HeaderText="CONTRATO" />
                        <asp:BoundField DataField="TELEFONO_1" HeaderText="TELEFONO_1" />
                        <asp:BoundField DataField="TELEFONO_2" HeaderText="TELEFONO_2" />
                        <asp:BoundField DataField="TELEFONO_3" HeaderText="TELEFONO_3" />
                        <asp:BoundField DataField="MOVIL_1" HeaderText="MOVIL_1" />
                        <asp:BoundField DataField="MOVIL_2" HeaderText="MOVIL_2" />
                        <asp:BoundField DataField="MOVIL_3" HeaderText="MOVIL_3" />
                        <asp:BoundField DataField="ESTRATO" HeaderText="ESTRATO" />--%>
                        <asp:BoundField DataField="HISTORICO" HeaderText="HISTORICO" />
                        <asp:BoundField DataField="TIPO_HIPOTESIS" HeaderText="TIPO_HIPOTESIS" />
                        <asp:BoundField DataField="TIPO_CONTACTO" HeaderText="TIPO_CONTACTO" />
                        <asp:BoundField DataField="GESTION" HeaderText="GESTION" />
                        <asp:BoundField DataField="CIERRE" HeaderText="CIERRE" />
                        <asp:BoundField DataField="RAZON" HeaderText="RAZON" />
                        <asp:BoundField DataField="CAUSA" HeaderText="CAUSA" />
                        <asp:BoundField DataField="ID_ESTADO" HeaderText="ID_ESTADO" />
                        <asp:BoundField DataField="NPS" HeaderText="NPS" />
                        <asp:BoundField DataField="CAMPANA" HeaderText="CAMPANA" />
                        <asp:BoundField DataField="ESTADO_CAMPANA" HeaderText="ESTADO_CAMPANA" />
                        <asp:BoundField DataField="SATISFACCION" HeaderText="SATISFACCION" />
                        <asp:BoundField DataField="ATRIBUTO_1" HeaderText="ATRIBUTO_1" />
                        <asp:BoundField DataField="ATRIBUTO_2" HeaderText="ATRIBUTO_2" />
                        <asp:BoundField DataField="ATRIBUTO_3" HeaderText="ATRIBUTO_3" />
                        <asp:BoundField DataField="ATRIBUTO_4" HeaderText="ATRIBUTO_4" />
                        <asp:BoundField DataField="ATRIBUTO_5" HeaderText="ATRIBUTO_5" />
                        <asp:BoundField DataField="ATRIBUTO_6" HeaderText="ATRIBUTO_6" />
                        <asp:BoundField DataField="ATRIBUTO_7" HeaderText="ATRIBUTO_7" />
                        <asp:BoundField DataField="ATRIBUTO_8" HeaderText="ATRIBUTO_8" />
                        <asp:BoundField DataField="ATRIBUTO_9" HeaderText="ATRIBUTO_9" />
                        <asp:BoundField DataField="ATRIBUTO_10" HeaderText="ATRIBUTO_10" />
                        <asp:BoundField DataField="OFRECIMIENTO_1" HeaderText="OFRECIMIENTO_1" />
                        <asp:BoundField DataField="OFRECIMIENTO_2" HeaderText="OFRECIMIENTO_2" />
                        <asp:BoundField DataField="OFRECIMIENTO_3" HeaderText="OFRECIMIENTO_3" />
                        <asp:BoundField DataField="OFRECIMIENTO_4" HeaderText="OFRECIMIENTO_4" />
                        <asp:BoundField DataField="OFRECIMIENTO_5" HeaderText="OFRECIMIENTO_5" />
                        <asp:BoundField DataField="OFRECIMIENTO_6" HeaderText="OFRECIMIENTO_6" />
                        <asp:BoundField DataField="OFRECIMIENTO_7" HeaderText="OFRECIMIENTO_7" />
                        <asp:BoundField DataField="OFRECIMIENTO_8" HeaderText="OFRECIMIENTO_8" />
                        <asp:BoundField DataField="OFRECIMIENTO_9" HeaderText="OFRECIMIENTO_9" />
                        <asp:BoundField DataField="OFRECIMIENTO_10" HeaderText="OFRECIMIENTO_10" />
                    </Columns>

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

