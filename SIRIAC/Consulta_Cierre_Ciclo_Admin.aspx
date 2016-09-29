<%@ Page Title="" Language="C#" MasterPageFile="~/Perfil_Administrador.master" AutoEventWireup="true" CodeFile="Consulta_Cierre_Ciclo_Admin.aspx.cs" Inherits="Consulta_Cierre_Ciclo_Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="jquery/jquery-1.11.1.js"></script>
    <link href="Estilos/Style_Perfil_Asesor.css?1.0.0" rel="stylesheet" />
    <link href="Estilos/Style_Ingreso_Casos.css?1.0.0" rel="stylesheet" />
    <script src="Js/jquery.datetimepicker.full.js?1.0.0"></script>
    <link href="Estilos/jquery.datetimepicker.css?1.0.0" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <script type="text/javascript">
        function si1() {
            alert('si');
        }

    </script>
    <asp:Panel CssClass="panel4" ID="Panel1" runat="server">
        <div id="tab-container2">
            <ul class="tab-menu2">
                <li id="html" class="active" onclick="otorgar_permisos()">GESTION CIERRE DE CICLO</li>
            </ul>
            <div class="clear"></div>
            <div class="tab-top-border"></div>
            <div id="html-tab" class="tab-content active">
                <h3 class="Titulos">CONSULTA DE GESTION CIERRE DE CICLO</h3>

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
                            <asp:BoundField DataField="FECHA_GESTION" HeaderText="Fecha de Gestion" />
                            <asp:BoundField DataField="USUARIO_GESTION" HeaderText="Usuario de Gestion" />
                            <asp:BoundField DataField="ALIADO_GESTION" HeaderText="Aliado de Gestion" />
                            <asp:BoundField DataField="CUENTA" HeaderText="Cuenta Cliente" />
                            <asp:BoundField DataField="OFRECIMIENTO_1" HeaderText="Ofrecimiento 1" />
                            <asp:BoundField DataField="OFRECIMIENTO_2" HeaderText="Ofrecimiento 2" />
                            <asp:BoundField DataField="OFRECIMIENTO_3" HeaderText="Ofrecimiento 3" />
                            <asp:BoundField DataField="P_SERVICIO_1" HeaderText="Telefonia" />
                            <asp:BoundField DataField="P_SERVICIO_2" HeaderText="Televisión Análoga" />
                            <asp:BoundField DataField="P_SERVICIO_3" HeaderText="Televisión Avanzada" />
                            <asp:BoundField DataField="P_SERVICIO_4" HeaderText="Televisión Básica" />
                            <asp:BoundField DataField="P_SERVICIO_5" HeaderText="Televisión Satelital" />
                            <asp:BoundField DataField="P_SERVICIO_6" HeaderText="Upgrade TV" />
                            <asp:BoundField DataField="P_SERVICIO_7" HeaderText="Upgrade Internet" />
                            <asp:BoundField DataField="P_SERVICIO_8" HeaderText="Internet 3MB" />
                            <asp:BoundField DataField="P_SERVICIO_9" HeaderText="Internet 5MB" />
                            <asp:BoundField DataField="P_SERVICIO_10" HeaderText="Internet 10MB" />
                            <asp:BoundField DataField="P_SERVICIO_11" HeaderText="Internet 20MB" />
                            <asp:BoundField DataField="P_SERVICIO_12" HeaderText="Internet 50MB" />
                            <asp:BoundField DataField="P_SERVICIO_13" HeaderText="Internet 100MB" />
                            <asp:BoundField DataField="P_SERVICIO_14" HeaderText="Claro Video" />
                            <asp:BoundField DataField="P_SERVICIO_15" HeaderText="Fox+" />
                            <asp:BoundField DataField="P_SERVICIO_16" HeaderText="Golden Premier HD" />
                            <asp:BoundField DataField="P_SERVICIO_17" HeaderText="HBO" />
                            <asp:BoundField DataField="P_SERVICIO_18" HeaderText="HD" />
                            <asp:BoundField DataField="P_SERVICIO_19" HeaderText="Hot Pack" />
                            <asp:BoundField DataField="P_SERVICIO_20" HeaderText="Internet Movil 1.5" />
                            <asp:BoundField DataField="P_SERVICIO_21" HeaderText="Internet Movil 750" />
                            <asp:BoundField DataField="P_SERVICIO_22" HeaderText="IP Fija" />
                            <asp:BoundField DataField="P_SERVICIO_23" HeaderText="Local Extendida" />
                            <asp:BoundField DataField="P_SERVICIO_24" HeaderText="Mcafee" />
                            <asp:BoundField DataField="P_SERVICIO_25" HeaderText="Mini Fox" />
                            <asp:BoundField DataField="P_SERVICIO_26" HeaderText="Mini HBO" />
                            <asp:BoundField DataField="P_SERVICIO_27" HeaderText="Módem Adicional" />
                            <asp:BoundField DataField="P_SERVICIO_28" HeaderText="PVR" />
                            <asp:BoundField DataField="P_SERVICIO_29" HeaderText="PVR + HD" />
                            <asp:BoundField DataField="P_SERVICIO_30" HeaderText="Revista 15 Min" />
                            <asp:BoundField DataField="P_SERVICIO_31" HeaderText="Segundo Módem" />
                            <asp:BoundField DataField="P_SERVICIO_32" HeaderText="UFC Network" />
                            <asp:BoundField DataField="P_SERVICIO_33" HeaderText="VOD" />
                            <asp:BoundField DataField="P_SERVICIO_34" HeaderText="Elegido Fijo Móvil" />
                            <asp:BoundField DataField="P_SERVICIO_35" HeaderText="Claro Video" />
                            <asp:BoundField DataField="P_SERVICIO_36" HeaderText="Convenio Electronico" />
                            <asp:BoundField DataField="TIPO_CONTACTO" HeaderText="Tipo de Contacto" />
                            <asp:BoundField DataField="GESTION" HeaderText="Gestión" />
                            <asp:BoundField DataField="CIERRE" HeaderText="Cierre" />
                            <asp:BoundField DataField="RAZON" HeaderText="Razon"/>
                            <asp:BoundField DataField="OBERVACIONES" HeaderText="Observaciones" />
                            <asp:BoundField DataField="BASE" HeaderText="Base" />
                            <asp:BoundField DataField="OPERACION_GESTION" HeaderText="Operacion de Gestion" />
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

