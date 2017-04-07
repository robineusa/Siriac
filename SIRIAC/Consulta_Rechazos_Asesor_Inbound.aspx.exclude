<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Perfil_Asesor.master" CodeFile="Consulta_Rechazos_Asesor_Inbound.aspx.cs" Inherits="Consulta_Rechazos_Asesor_Inbound" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script src="jquery/jquery.dropdownPlain.js?1.0.0"></script>
    <script src="javascript/Funciones.js?1.0.0"></script>
    <link href="Estilos/Style_Perfil_Asesor.css?1.0.0" rel="stylesheet" />
    <link href="Estilos/Style_Ingreso_Casos.css?1.0.0" rel="stylesheet" />
    <link href="Estilos/Menu.css?1.0.0" rel="stylesheet" />
    <script src="jquery/jquery.datetimepicker.js?1.0.0"></script>
    <link href="Estilos/jquery.datetimepicker.css?1.0.0" rel="stylesheet" />
   
    

    <script type="text/javascript">
        function editar(obj) {

            var imageID = document.getElementById('imagen' + obj);
            window.location.href = 'Actualizar_Casos.aspx?id=' + obj;

        };
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:Panel CssClass="panel" ID="Panel1" runat="server">
        <asp:UpdatePanel ID="UpdatePanel9" runat="server">
            <ContentTemplate>
                <div id="tab-container">
                    <ul class="tab-menu">
                        <li id="html" class="active" onclick="otorgar_permisos()">RECHAZOS</li>
                    </ul>
                    <div class="clear"></div>
                    <div class="tab-top-border"></div>
                    <div id="html-tab" class="tab-content active">

                        <h3 class="Titulos">FORMULARIO CONSULTA DE RECHAZOS</h3>

                        <asp:Panel ID="Panel2" runat="server" CssClass="panel_informativo" GroupingText="Datos de Consulta">
                            <asp:TextBox ID="TextBox1" runat="server" Style="display: none"></asp:TextBox>
                            <table class="tabla">
                                <tr>
                                    <td>
                                        <p class="texto_informativo">Seleccione fecha inicial</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Fecha_Inicial" runat="server" AutoPostBack="true" OnTextChanged="Fecha_Inicial_TextChanged"></asp:TextBox>
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
                                        <asp:TextBox CssClass="caja_de_texto" ID="Fecha_Final" runat="server" AutoPostBack="true" OnTextChanged="Fecha_Final_TextChanged"></asp:TextBox>
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

                        <asp:GridView CssClass="mGrid2" ID="RECHAZOS_ASESOR" runat="server" AutoGenerateColumns="False" AllowPaging="true" PageIndex="5" PageSize="5" OnRowDataBound="RECHAZOS_ASESOR_RowDataBound" OnPageIndexChanging="RECHAZOS_ASESOR_PageIndexChanging">
                            <Columns>
                                <asp:BoundField DataField="ID_INGRESO" HeaderText="ID INGRESO" />
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
                    </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </asp:Panel>
</asp:Content>
