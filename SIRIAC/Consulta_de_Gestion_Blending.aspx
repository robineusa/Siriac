<%@ Page Title="" Language="C#" MasterPageFile="~/Perfil_Administrador.master" AutoEventWireup="true" CodeFile="Consulta_de_Gestion_Blending.aspx.cs" Inherits="Consulta_de_Gestion_Blending" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="jquery/jquery-1.11.1.js"></script>
    <link href="Estilos/Style_Perfil_Asesor.css?1.0.0" rel="stylesheet" />
    <link href="Estilos/Style_Ingreso_Casos.css?1.0.0" rel="stylesheet" />
    <script src="Js/jquery.datetimepicker.full.js?1.0.0"></script>
    <link href="Estilos/jquery.datetimepicker.css?1.0.0" rel="stylesheet" />
    <link href="Estilos/Blending.css" rel="stylesheet" />

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel CssClass="panel4" ID="Panel1" runat="server">
        <div id="tab-container2">
            <ul class="tab-menu2">
                <li id="html" class="active" onclick="otorgar_permisos()">GESTION BLENDING</li>
            </ul>
            <div class="clear"></div>
            <div class="tab-top-border"></div>
            <div id="html-tab" class="tab-content active">
                <h3 class="Titulos">CONSULTA DE GESTION BLENDING</h3>
                <hr />

                <asp:Panel CssClass="panel_informativo" ID="Panel3" runat="server" GroupingText="Ventana de tiempo para la consulta">
                    <table class="tabla">
                        <tr>
                            <td>
                                <p class="etiquetas">Fecha Inicial:</p>
                                <asp:TextBox ID="CE_Fecha_Inicial" runat="server" Text="2016-01-01 00:00" Style="display: none"></asp:TextBox>
                                <input class="caja_de_texto" type="text" value="" id="CEH_Fecha_Inicial" autocomplete="off" onchange="return Traer_Fecha()" placeholder="Select date" />

                            </td>
                            <td class="auto-style21">
                                <p class="etiquetas">Fecha Final:</p>
                                <asp:TextBox ID="CE_Fecha_Final" runat="server" Text="2016-01-01 00:00" Style="display: none"></asp:TextBox>
                                <input class="caja_de_texto" type="text" value="" id="CEH_Fecha_Final" autocomplete="off" onchange="return Traer_Fecha_Final()" placeholder="Select date" />

                            </td>
                        </tr>
                    </table>
                    <script>
                        $('#CEH_Fecha_Inicial').datetimepicker({
                            format: 'Y/m/d',
                            minDate: '2016/09/01',
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
                        function Traer_Fecha_Final() {
                            var fecha = document.getElementById('CEH_Fecha_Final').value;
                            document.getElementById("<%= CE_Fecha_Final.ClientID %>").value = fecha;
                        }
                    </script>
                    <script>
                        function Traer_Fecha() {
                            var fecha = document.getElementById('CEH_Fecha_Inicial').value;
                            document.getElementById("<%= CE_Fecha_Inicial.ClientID %>").value = fecha;
                        }
                    </script>
                </asp:Panel>

                <asp:Panel CssClass="panel_informativo" ID="Panel2" runat="server" GroupingText="Seleccione la gestión a consultar">
                    <table class="tabla">
                        <tr>
                            <td>
                                <div class="caja_boton">
                                    <asp:Button CssClass="botones_Consulta_Gestion" ID="Activacion" runat="server" Text="Activación" OnClick="Activacion_Click" />
                                </div>
                            </td>
                            <td>
                                <div class="caja_boton">
                                    <asp:Button CssClass="botones_Consulta_Gestion" ID="Convenio" runat="server" Text="Convenio Electrónico" OnClick="Convenio_Click" />
                                </div>
                            </td>
                            <td>
                                <div class="caja_boton">
                                    <asp:Button CssClass="botones_Consulta_Gestion" ID="Detrectores" runat="server" Text="Detractores" OnClick="Detrectores_Click" />
                                </div>
                            </td>
                            <td>
                                <div class="caja_boton">
                                    <asp:Button CssClass="botones_Consulta_Gestion" ID="Reincidencia" runat="server" Text="Reincidencia" OnClick="Reincidencia_Click" />
                                </div>
                            </td>
                            <td>
                                <div class="caja_boton">
                                    <asp:Button CssClass="botones_Consulta_Gestion" ID="Ventas" runat="server" Text="Ventas" OnClick="Ventas_Click" />
                                </div>
                            </td>
                            <td>
                                <div class="caja_boton">
                                    <asp:Button CssClass="botones_Consulta_Gestion" ID="Logistica" runat="server" Text="Logistica Inversa" OnClick="Logistica_Click" />
                                </div>
                            </td>
                            <td>
                                <div class="caja_boton">
                                    <asp:Button CssClass="botones_Consulta_Gestion" ID="Claro_Video" runat="server" Text="Claro Video" OnClick="Claro_Video_Click"/>
                                </div>
                            </td>
                        </tr>
                    </table>

                </asp:Panel>

                <asp:GridView CssClass="mGrid" ID="CONSULTA_ACTIVACION" runat="server" AutoGenerateColumns="False" AllowPaging="True">
                </asp:GridView>
                <asp:GridView CssClass="mGrid" ID="CONSULTA_CONVENIO" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnRowDataBound="CONSULTA_CONVENIO_RowDataBound">

                    <Columns>
                        <asp:BoundField DataField="Fecha_Gestion" HeaderText="Fecha de Gestion" />
                        <asp:BoundField DataField="Hora_Gestion" HeaderText="Hora de Gestion" />
                        <asp:BoundField DataField="Usuario_Gestion" HeaderText="Usuario de Gestion" />
                        <asp:BoundField DataField="Aliado_Gestion" HeaderText="Aliado de Gestion" />
                        <asp:BoundField DataField="Linea_Gestion" HeaderText="Linea de Gestion" />
                        <asp:BoundField DataField="Cuenta_Cliente" HeaderText="Cuenta Cliente" />
                        <%--<asp:BoundField DataField="Nombre_Cliente" HeaderText="Nombre de Cliente" />
                        <asp:BoundField DataField="Apellido_Cliente" HeaderText="Apellido del Cliente" />
                        <asp:BoundField DataField="Direccion_Instalacion" HeaderText="Direccion de Instalacion" />
                        <asp:BoundField DataField="Direccion_Correspondencia_Actual" HeaderText="Direccion de Correspondencia Actual" />
                        <asp:BoundField DataField="Telefono_Telmex" HeaderText="Telefono Telmex" />
                        <asp:BoundField DataField="Telefono_1" HeaderText="Telefono 1" />
                        <asp:BoundField DataField="Telefono_2" HeaderText="Telefono 2" />
                        <asp:BoundField DataField="Telefono_3" HeaderText="Telefono 3" />
                        <asp:BoundField DataField="Movil_Actual" HeaderText="Movil Actual" />
                        <asp:BoundField DataField="Correo_Actual" HeaderText="Correo Actual" />--%>
                        <asp:BoundField DataField="Tipo_Contacto" HeaderText="Tipo Contacto" />
                        <asp:BoundField DataField="Cierre" HeaderText="Cierre" />
                        <asp:BoundField DataField="Razon" HeaderText="Razon" />
                        <asp:BoundField DataField="Movil_Nuevo" HeaderText="Movil Nuevo" />
                        <asp:BoundField DataField="Nuevo_Correo" HeaderText="Nuevo Correo" />
                        <asp:BoundField DataField="Nueva_Direccion_Correspondencia" HeaderText="Nueva Direccion de Correspondencia" />
                    </Columns>

                </asp:GridView>
                <asp:GridView CssClass="mGrid" ID="CONSULTA_DETRACTORES" runat="server" AutoGenerateColumns="False" AllowPaging="True">
                </asp:GridView>
                <asp:GridView CssClass="mGrid" ID="CONSULTA_REINCIDENCIA" runat="server" AutoGenerateColumns="False" AllowPaging="True">
                </asp:GridView>
                <asp:GridView CssClass="mGrid" ID="CONSULTA_VENTAS" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnRowDataBound="CONSULTA_VENTAS_RowDataBound">
                    <Columns>
                        <asp:BoundField DataField="FECHA_GESTION" HeaderText="FECHA DE GESTION" />
                        <asp:BoundField DataField="USUARIO_GESTION" HeaderText="USUARIO DE GESTION" />
                        <asp:BoundField DataField="ALIADO_GESTION" HeaderText="ALIADO DE GESTION" />
                        <asp:BoundField DataField="CUENTA_CLIENTE" HeaderText="CUENTA DEL CLIENTE" />
                        <asp:BoundField DataField="TIPO_DE_CONTACTO" HeaderText="TIPO DE CONTACTO" />
                        <asp:BoundField DataField="CIERRE" HeaderText="CIERRE" />
                        <asp:BoundField DataField="RAZON" HeaderText="RAZON" />
                        <asp:BoundField DataField="ATTRIBUTO_1" HeaderText="ATTRIBUTO 1" />
                        <asp:BoundField DataField="ATTRIBUTO_2" HeaderText="ATTRIBUTO 2" />
                        <asp:BoundField DataField="ATTRIBUTO_3" HeaderText="ATTRIBUTO 3" />
                        <asp:BoundField DataField="ATTRIBUTO_4" HeaderText="ATTRIBUTO 4" />
                        <asp:BoundField DataField="ATTRIBUTO_5" HeaderText="ATTRIBUTO 5" />
                        <asp:BoundField DataField="ATTRIBUTO_6" HeaderText="ATTRIBUTO 6" />
                        <asp:BoundField DataField="ATTRIBUTO_7" HeaderText="ATTRIBUTO 7" />
                        <asp:BoundField DataField="ATTRIBUTO_8" HeaderText="ATTRIBUTO 8" />
                        <asp:BoundField DataField="ATTRIBUTO_9" HeaderText="ATTRIBUTO 9" />
                        <asp:BoundField DataField="ATTRIBUTO_10" HeaderText="ATTRIBUTO 10" />
                        <asp:BoundField DataField="OBSERVACIONES" HeaderText="OBSERVACIONES" />
                    </Columns>
                </asp:GridView>
                <asp:GridView CssClass="mGrid" ID="CONSULTA_LOGISTICA" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnRowDataBound="CONSULTA_LOGISTICA_RowDataBound">
                    <Columns>
                        <asp:BoundField DataField="FECHA_GESTION" HeaderText="FECHA DE GESTION" />
                        <asp:BoundField DataField="HORA_GESTION" HeaderText="HORA DE GESTION" />
                        <asp:BoundField DataField="USUARIO_GESTION" HeaderText="USUARIO DE GESTION" />
                        <asp:BoundField DataField="ALIADO_GESTION" HeaderText="ALIADO DE GESTION" />
                        <asp:BoundField DataField="CUENTA_CLIENTE" HeaderText="CUENTA DEL CLIENTE" />
                        <asp:BoundField DataField="TIPO_CONTACTO" HeaderText="TIPO DE CONTACTO" />
                        <asp:BoundField DataField="CIERRE" HeaderText="CIERRE" />
                        <asp:BoundField DataField="RAZON" HeaderText="RAZON" />
                        <asp:BoundField DataField="FECHA_AGENDA" HeaderText="FECHA DE AGENDAMIENTO" />
                        <asp:BoundField DataField="PERSONA_CONTACTO" HeaderText="PERSONA DE CONTACTO" />
                        <asp:BoundField DataField="TELEFONO_CONTACTO" HeaderText="TELEFONO DE CONTACTO" />
                        <asp:BoundField DataField="DIRECCION_ALTERNA" HeaderText="DIRECCION ALTERNA" />
                        <asp:BoundField DataField="OBSERVACIONES" HeaderText="OBSERVACIONES" />
                        <asp:BoundField DataField="DEPARTAMENTO" HeaderText="DEPARTAMENTO" />
                        <asp:BoundField DataField="CIUDAD" HeaderText="CIUDAD" />
                    </Columns>
                </asp:GridView>
                <asp:GridView CssClass="mGrid" ID="CONSULTA_CLARO_VIDEO" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnRowDataBound="CONSULTA_CLARO_VIDEO_RowDataBound">
                    <Columns>
                        <asp:BoundField DataField="FECHA_GESTION" HeaderText="FECHA DE GESTION" />
                        <asp:BoundField DataField="USUARIO_GESTION" HeaderText="USUARIO DE GESTION" />
                        <asp:BoundField DataField="NOMBRE_USUARIO_GESTION" HeaderText="NOMBRE USUARIO DE GESTION" />
                        <asp:BoundField DataField="ALIADO_GESTION" HeaderText="ALIADO DE GESTION" />
                        <asp:BoundField DataField="OPERACION_GESTION" HeaderText="OPERACION DE GESTION" />
                        <asp:BoundField DataField="CUENTA_CLIENTE" HeaderText="CUENTA DEL CLIENTE" />
                        <asp:BoundField DataField="TIPO_DE_CONTACTO" HeaderText="TIPO DE CONTACTO" />
                        <asp:BoundField DataField="TIPO_DE_GESTION" HeaderText="TIPO DE GESTIÓN" />
                        <asp:BoundField DataField="CIERRE" HeaderText="CIERRE" />
                        <asp:BoundField DataField="RAZON" HeaderText="RAZON" />
                        <asp:BoundField DataField="ATTRIBUTO_1" HeaderText="CLARO VIDEO" />
                        <asp:BoundField DataField="ATTRIBUTO_2" HeaderText="ELEGIDO FIJO MÓVIL" />
                        <asp:BoundField DataField="OBSERVACIONES" HeaderText="OBSERVACIÓNES" />
                    </Columns>
                </asp:GridView>

                <asp:TextBox ID="Fecha_Inicial" runat="server" Style="display: none"></asp:TextBox>
                <asp:TextBox ID="Fecha_Final" runat="server" Style="display: none"></asp:TextBox>
                <table>
                    <tr>
                        <td class="auto-style25">
                            <asp:Button CssClass="button" ID="Exportar_Activacion" runat="server" Text="Exportar a Excel" Visible="false" OnClick="Exportar_Activacion_Click" />
                            <asp:Button CssClass="button" ID="Exportar_Convenio" runat="server" Text="Exportar a Excel" Visible="false" OnClick="Exportar_Convenio_Click" />
                            <asp:Button CssClass="button" ID="Exportar_Detractores" runat="server" Text="Exportar a Excel" Visible="false" OnClick="Exportar_Detractores_Click" />
                            <asp:Button CssClass="button" ID="Exportar_Reincidencia" runat="server" Text="Exportar a Excel" Visible="false" OnClick="Exportar_Reincidencia_Click" />
                            <asp:Button CssClass="button" ID="Exportar_Ventas" runat="server" Text="Exportar a Excel" Visible="false" OnClick="Exportar_Ventas_Click" />
                            <asp:Button CssClass="button" ID="Exportar_Logistica" runat="server" Text="Exportar a Excel" Visible="false" OnClick="Exportar_Logistica_Click" />
                            <asp:Button CssClass="button" ID="Exportar_Claro_Video" runat="server" Text="Exportar a Excel" Visible="false" OnClick="Exportar_Claro_Video_Click" />
                        </td>
                    </tr>
                </table>
                <br />

            </div>
        </div>
    </asp:Panel>
</asp:Content>

