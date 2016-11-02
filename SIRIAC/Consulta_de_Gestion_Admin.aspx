<%@ Page Title="" Language="C#" MasterPageFile="~/Perfil_Administrador.master" AutoEventWireup="true" CodeFile="Consulta_de_Gestion_Admin.aspx.cs" Inherits="Consulta_de_Gestion_Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="Estilos/Style_Perfil_Asesor.css?1.0.0" rel="stylesheet" />
    <link href="Estilos/Style_Ingreso_Casos.css?1.0.0" rel="stylesheet" />
    <script src="jquery/jquery-1.11.1.js"></script>
    <script src="jquery/jquery.datetimepicker.full.js"></script>
    <link href="Estilos/jquery.datetimepicker.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel CssClass="panel4" ID="Panel1" runat="server">
        <asp:ScriptManager runat="server"></asp:ScriptManager>
        <div id="tab-container2">
            <ul class="tab-menu2">
                <li id="html" class="active" onclick="otorgar_permisos()">CONSULTA DE GESTION</li>
            </ul>
            <div class="clear"></div>
            <div class="tab-top-border"></div>
            <div id="html-tab" class="tab-content active">
                <asp:Label ID="Label2" runat="server" Text="Label" Style="display: none"></asp:Label>
                <asp:Label ID="Label3" runat="server" Text="Label" Style="display: none"></asp:Label>
                <asp:Label ID="Label4" runat="server" Text="Label" Style="display: none"></asp:Label>
                <h3 class="Titulos">CONSULTA GLOBAL DE GESTION</h3>


                <asp:Panel CssClass="panel_informativo" ID="Panel3" runat="server" GroupingText="Ventana de tiempo para la consulta">
                    <%--<asp:UpdatePanel runat="server"><ContentTemplate> 
                    <table class="tabla">
                        <tr>
                             
                            <td>
                                <asp:Label CssClass="texto_informativo" ID="Label282" runat="server" Text="Seleccione aliado:"></asp:Label><br />
                                <asp:DropDownList CssClass="dropdown2" ID="Aliado_CG" runat="server" ></asp:DropDownList>
                            </td>
                            
                            <td>

                                <asp:Label CssClass="texto_informativo" ID="Label5" runat="server" Text="Seleccione la fecha inicial:" Style="margin-left:10px;"></asp:Label><br />
                                <asp:TextBox CssClass="caja_de_texto" ID="TextBox3" runat="server" AutoPostBack="true" Style="margin-left:10px;"></asp:TextBox>
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
                                <p class="texto_informativo" Style="margin-left:10px;">Seleccione fecha final</p>
                                <asp:TextBox CssClass="caja_de_texto" ID="TextBox4" runat="server" AutoPostBack="true" Style="margin-left:10px;"></asp:TextBox>
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
                    </ContentTemplate></asp:UpdatePanel>--%>

                    <table class="tabla">
                        <tr>
                            <td>
                                <asp:Label CssClass="texto_informativo" ID="Label282" runat="server" Text="Seleccione aliado:"></asp:Label><br />
                                <asp:DropDownList CssClass="dropdown2" ID="Aliado_CG" runat="server" ></asp:DropDownList>
                            </td>
                            <td>
                                <p class="etiquetas">Fecha Inicial:</p>
                                <asp:TextBox ID="CG_Fecha_Inicial" runat="server" Text="2016-01-01 00:00" Style="display: none"></asp:TextBox>
                                <input class="caja_de_texto" type="text" value="" id="CGH_Fecha_Inicial" autocomplete="off" onchange="return Traer_Fecha()" placeholder="Select date" />
                            </td>
                            <td class="auto-style21">
                                <p class="etiquetas">Fecha Final:</p>
                                <asp:TextBox ID="CG_Fecha_Final" runat="server" Text="2016-01-01 00:00" Style="display: none"></asp:TextBox>
                                <input class="caja_de_texto" type="text" value="" id="CGH_Fecha_Final" autocomplete="off" onchange="return Traer_Fecha_Final()" placeholder="Select date" />
                            </td>
                        </tr>
                    </table>
                    <asp:TextBox runat="server" ID="CG_Aliado_Oculto"  Style="display: none"></asp:TextBox>
                    <asp:Button ID="CG_Consulta" runat="server" OnClick="CG_Consulta_Click" Style="display: none" />

                    <script>
                        $('#CGH_Fecha_Inicial').datetimepicker({
                            format: 'Y-m-d',
                            //minDate: '2016-09/01',
                            maxDate: '+0d',
                            timepicker: false
                        });

                        $('#CGH_Fecha_Final').datetimepicker({
                            format: 'Y-m-d',
                            onShow: function (ct) {
                                this.setOptions({
                                    minDate: $('#CGH_Fecha_Inicial').val() ? $('#CGH_Fecha_Inicial').val() : false
                                })
                            },
                            maxDate: '+0d',
                            
                            timepicker: false
                        });
                    </script>
                    <script>
                        function Traer_Fecha_Final() {
                            var fecha = document.getElementById('CGH_Fecha_Final').value;
                            document.getElementById("<%= CG_Fecha_Final.ClientID %>").value = fecha;
                            var Aliado = document.getElementById("<%=Aliado_CG.ClientID%>").value;
                            document.getElementById("<%= CG_Aliado_Oculto.ClientID %>").value = Aliado;
                            var click = document.getElementById("<%=CG_Consulta.ClientID %>");
                            click.click();
                        }
                    </script>
                    <script>
                        function Traer_Fecha() {
                            var fecha = document.getElementById('CGH_Fecha_Inicial').value;
                            document.getElementById("<%= CG_Fecha_Inicial.ClientID %>").value = fecha;
                        }
                    </script>
                </asp:Panel>
                <asp:GridView CssClass="mGrid" ID="GVINGRESOS" runat="server" AutoGenerateColumns="False" OnRowDataBound="GINGRESOS_RowDataBound" AllowPaging="True">
                    <Columns>
                        <asp:BoundField DataField="ID_INGRESO" HeaderText="ID DE INGRESO" />
                        <asp:BoundField DataField="CUENTA_CLIENTE" HeaderText="CUENTA CLIENTE" />
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

