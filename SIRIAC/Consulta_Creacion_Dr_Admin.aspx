<%@ Page Title="" Language="C#" MasterPageFile="~/Perfil_Administrador.master" AutoEventWireup="true" CodeFile="Consulta_Creacion_Dr_Admin.aspx.cs" Inherits="Consulta_Creacion_Dr_Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <script src="jquery/jquery-1.11.1.js"></script>
    <link href="Estilos/Style_Perfil_Asesor.css?1.0.0" rel="stylesheet" />
    <link href="Estilos/Style_Ingreso_Casos.css?1.0.0" rel="stylesheet" />
    <script src="Js/jquery.datetimepicker.full.js?1.0.0"></script>
    <link href="Estilos/jquery.datetimepicker.css?1.0.0" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script type="text/javascript">
        function si1() {
            alert('si');
        }

    </script>
    <asp:Panel CssClass="panel4" ID="Panel1" runat="server">
        <div id="tab-container2">
            <ul class="tab-menu2">
                <li id="html" class="active" onclick="otorgar_permisos()">CREACION DE DIRECCION</li>
            </ul>
            <div class="clear"></div>
            <div class="tab-top-border"></div>
            <div id="html-tab" class="tab-content active">
                <h3 class="Titulos">CONSULTA SOLICITUDES CREACION DE DIRECCION</h3>

                <asp:Panel CssClass="panel_informativo" ID="Panel3" runat="server" GroupingText="Ventana de tiempo para la consulta">
                    <table class="tabla">
                        <tr>
                            <td>
                                <p class="etiquetas">Fecha Inicial:</p>
                                <asp:TextBox ID="CC_Fecha_Inicial" runat="server" Text="2016-01-01 00:00" Style="display: none"></asp:TextBox>
                                <input class="caja_de_texto" type="text" value="" id="CCH_Fecha_Inicial" autocomplete="off" onchange="return Traer_Fecha()" placeholder="Select date" />
                            </td>
                            <td class="auto-style21">
                                <p class="etiquetas">Fecha Final:</p>
                                <asp:TextBox ID="CC_Fecha_Final" runat="server" Text="2016-01-01 00:00" Style="display: none"></asp:TextBox>
                                <input class="caja_de_texto" type="text" value="" id="CCH_Fecha_Final" autocomplete="off" onchange="return Traer_Fecha_Final()" placeholder="Select date" />
                            </td>
                        </tr>
                    </table>
                    <asp:Button ID="CC_Consulta" runat="server" OnClick="Consulta_Cierre_Ciclo_LOG" Style="display: none" />
                    <script>
                        $('#CCH_Fecha_Inicial').datetimepicker({
                            format: 'Y/m/d',
                            minDate: '2016/09/01',
                            maxDate: '+0d',
                            timepicker: false
                        });

                        $('#CCH_Fecha_Final').datetimepicker({
                            format: 'Y/m/d',
                            onShow: function (ct) {
                                this.setOptions({
                                    minDate: $('#CCH_Fecha_Inicial').val() ? $('#CCH_Fecha_Inicial').val() : false
                                })
                            },
                            maxDate: '+0d',
                            timepicker: false
                        });
                    </script>
                    <script>
                        function Traer_Fecha_Final() {
                            var fecha = document.getElementById('CCH_Fecha_Final').value;
                            document.getElementById("<%= CC_Fecha_Final.ClientID %>").value = fecha;
                            var click = document.getElementById("<%=CC_Consulta.ClientID %>");
                            click.click();
                        }
                    </script>
                    <script>
                        function Traer_Fecha() {
                            var fecha = document.getElementById('CCH_Fecha_Inicial').value;
                            document.getElementById("<%= CC_Fecha_Inicial.ClientID %>").value = fecha;
                        }
                    </script>
                </asp:Panel>
                <asp:GridView CssClass="mGrid" ID="CONSULTA_CIERRE_CICLO" runat="server" AutoGenerateColumns="False" AllowPaging="True"  OnPageIndexChanging="CONSULTA_CIERRE_CICLO_PageIndexChanging">

                        <Columns>
                            <asp:BoundField DataField="ID_TRASLADO" HeaderText="ID TRASLADO" />
                            <asp:BoundField DataField="CUENTA_CLIENTE" HeaderText="CUENTA CLIENTE" />
                            <asp:BoundField DataField="DIRECCION" HeaderText="DIRECCION" />
                            <asp:BoundField DataField="ESTRATO" HeaderText="ESTRATO" />
                            <asp:BoundField DataField="NODO" HeaderText="NODO" />
                            <asp:BoundField DataField="NOMBRE_NODO" HeaderText="NOMBRE NODO" />
                            <asp:BoundField DataField="DIV" HeaderText="DIV" />
                            <asp:BoundField DataField="COM" HeaderText="COM" />
                            <asp:BoundField DataField="DIVISIONAL" HeaderText="DIVISIONAL" />
                            <asp:BoundField DataField="AREA" HeaderText="AREA" />
                            <asp:BoundField DataField="DISTRITO" HeaderText="DISTRITO" />
                            <asp:BoundField DataField="UGESTION" HeaderText="UGESTION" />
                            <asp:BoundField DataField="ESTADO_NODO" HeaderText="ESTADO NODO" />
                            <asp:BoundField DataField="RED" HeaderText="RED" />
                            <asp:BoundField DataField="TELEFONO_CELULAR" HeaderText="TELEFONO CELULAR" />
                            <asp:BoundField DataField="TELEFONO_FIJO" HeaderText="TELEFONO FIJO" />
                            <asp:BoundField DataField="FECHA_APERTURA" HeaderText="FECHA APERTURA" />
                            <asp:BoundField DataField="HORA_APERTURA" HeaderText="HORA APERTURA" />
                            <asp:BoundField DataField="FECHA_CIERRE" HeaderText="FECHA CIERRE" />
                            <asp:BoundField DataField="HORA_CIERRE" HeaderText="HORA CIERRE" />
                            <asp:BoundField DataField="USUARIO_APERTURA" HeaderText="USUARIO APERTURA" />
                            <asp:BoundField DataField="USUARIO_CIERRE" HeaderText="USUARIO CIERRE" />
                            <asp:BoundField DataField="FECHA_ULTIMA_ACTUALIZACION" HeaderText="FECHA ULTIMA ACTUALIZACION" />
                            <asp:BoundField DataField="USUARIO_ULTIMA_ACTUALIZACION" HeaderText="USUARIO ULTIMA ACTUALIZACION" />
                            <asp:BoundField DataField="HORA_ULTIMA_ACTUALIZACION" HeaderText="HORA ULTIMA ACTUALIZACION" />
                            <asp:BoundField DataField="RAZON" HeaderText="RAZON" />
                            <asp:BoundField DataField="SUBRAZON" HeaderText="SUBRAZON" />
                            <asp:BoundField DataField="ESTADO_CASO" HeaderText="ESTADO CASO" />
                            <asp:BoundField DataField="USUARIO_BACKOFFICE" HeaderText="USUARIO BACKOFFICE" />
                            <asp:BoundField DataField="ALIADO_APERTURA" HeaderText="ALIADO APERTURA" />
                            <asp:BoundField DataField="NOMBRE_LINEA_INGRESO" HeaderText="NOMBRE LINEA INGRESO" />
                            <asp:BoundField DataField="NOMBRE_LINEA_ESCALADO" HeaderText="NOMBRE LINEA ESCALADO" />
                            
                        </Columns>
                    </asp:GridView>
                <asp:TextBox ID="Fecha_Inicial" runat="server" Style="display: none"></asp:TextBox>
                <asp:TextBox ID="Fecha_Final" runat="server" Style="display: none"></asp:TextBox>
                <table>
                        <tr>
                            <td class="auto-style25">

                                <asp:Button CssClass="button" ID="Exportar_Cierre_Ciclo" runat="server" Text="Exportar a Excel"  OnClick="Exportar_Convenio_Click" />

                            </td>
                        </tr>
                </table>
            </div>
        </div>
    </asp:Panel>

</asp:Content>

