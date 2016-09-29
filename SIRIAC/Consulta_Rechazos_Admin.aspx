<%@ Page Title="" Language="C#" MasterPageFile="~/Perfil_Administrador.master" AutoEventWireup="true" CodeFile="Consulta_Rechazos_Admin.aspx.cs" Inherits="Consulta_Rechazos_Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script src="jquery/jquery-1.11.1.js"></script>
    <script src="jquery/jquery.dropdownPlain.js"></script>
    <script src="javascript/Funciones.js"></script>
    <link href="Estilos/Style_Perfil_Asesor.css" rel="stylesheet" />
    <link href="Estilos/Style_Ingreso_Casos.css" rel="stylesheet" />
    <script src="jquery/jquery.datetimepicker.js"></script>
    <link href="Estilos/jquery.datetimepicker.css" rel="stylesheet" />



    <script type="text/javascript">
        function editar(obj) {

            var imageID = document.getElementById('imagen' + obj);
            window.location.href = 'Actualizar_Casos.aspx?id=' + obj;

        };
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:Panel CssClass="panel4" ID="Panel1" runat="server">


        <div id="tab-container2">
            <ul class="tab-menu2">
                <li id="html" class="active" onclick="otorgar_permisos()">RECHAZOS</li>
            </ul>
            <div class="clear"></div>
            <div class="tab-top-border"></div>
            <div id="html-tab" class="tab-content active">

                <h3 class="Titulos">FORMULARIO CONSULTA DE RECHAZOS</h3>

                <asp:Panel ID="Panel2" runat="server" CssClass="panel_informativo" GroupingText="Ventana de tiempo para la consulta">
                    <asp:TextBox ID="TextBox1" runat="server" Style="display: none"></asp:TextBox>
                    <table class="tabla">
                        <tr>
                            <td>
                                <p class="texto_informativo">Seleccione fecha inicial</p>
                                <asp:TextBox CssClass="caja_de_texto" ID="TextBox3" runat="server" AutoPostBack="true" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
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
                            <td>
                                <p class="texto_informativo">Seleccione fecha final</p>
                                <asp:TextBox CssClass="caja_de_texto" ID="TextBox4" runat="server" AutoPostBack="true" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
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
                        </tr>
                    </table>
                </asp:Panel>

                <asp:GridView CssClass="mGrid" ID="GVINGRESOS" runat="server" AutoGenerateColumns="False" OnRowDataBound="GINGRESOS_RowDataBound" AllowPaging="True" PageIndex="10" PageSize="10" OnPageIndexChanging="GVINGRESOS_PageIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="ID_INGRESO" HeaderText="ID DE INGRESO" />
                        <asp:BoundField DataField="FECHA_CREACION_CASO" HeaderText="FECHA CREACION CASO" />
                        <asp:BoundField DataField="HORA_CREACION_CASO" HeaderText="HORA CREACION CASO" />
                        <asp:BoundField DataField="USUARIO_CREACION_CASO" HeaderText="USUARIO CREACION CASO" />
                        <asp:BoundField DataField="NOMBRE_USUARIO_CREACION" HeaderText="NOMBRE USUARIO CREACION" />
                        <asp:BoundField DataField="USUARIO_RECHAZA" HeaderText="USUARIO RECHAZA" />
                        <asp:BoundField DataField="NOMBRE_USUARIO_RECHAZA" HeaderText="NOMBRE USUARIO RECHAZA" />
                        <asp:BoundField DataField="NOMBRE_LINEA_USUARIO_RECHAZA" HeaderText="NOMBRE LINEA USUARIO RECHAZA" />
                        <asp:BoundField DataField="ALIADO_USUARIO_RECHAZA" HeaderText="ALIADO USUARIO RECHAZA" />
                        <asp:BoundField DataField="FECHA_DEL_RECHAZO" HeaderText="FECHA DEL RECHAZO" />
                        <asp:BoundField DataField="HORA_DEL_RECHAZO" HeaderText="HORA DEL RECHAZO" />
                        <asp:BoundField DataField="NOTAS_RECHAZO" HeaderText="NOTAS RECHAZO" />
                    </Columns>

                </asp:GridView>

                <table>
                    <tr>
                        <td class="auto-style25">
                            <asp:Button CssClass="button" ID="Button4" runat="server" Text="Exportar a Excel" OnClick="Button4_Click" />
                        </td>
                    </tr>
                </table>

                <asp:Label ID="Label1" runat="server" Text="Label" Style="display: none"></asp:Label>
                <br />
            </div>


        </div>
    </asp:Panel>
</asp:Content>

