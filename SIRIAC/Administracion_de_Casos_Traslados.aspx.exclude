<%@ Page Title="" Language="C#" MasterPageFile="~/Perfil_Administrador.master" AutoEventWireup="true" CodeFile="Administracion_de_Casos_Traslados.aspx.cs" Inherits="Administracion_de_Casos_Traslados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function editar(obj) {
            var imageID = document.getElementById('imagen' + obj);
            window.location.href = 'Modificacion_Traslados_Admin.aspx?id=' + obj;
        };
    </script>
    <script type="text/javascript">
        function otorgar_permisos() {

            var activeTabIndex = -1;
            var tabNames = ["html", "javascript", "css"];
            $(".tab-menu > li").click(function (e) {

                for (var i = 0; i < tabNames.length; i++) {
                    if (e.target.id == tabNames[i]) {
                        activeTabIndex = i;
                    } else {
                        $("#" + tabNames[i]).removeClass("active");
                        $("#" + tabNames[i] + "-tab").css("display", "none");
                    }
                }
                $("#" + tabNames[activeTabIndex] + "-tab").fadeIn();
                $("#" + tabNames[activeTabIndex]).addClass("active");
                return false;
            });

        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:Panel CssClass="panel" ID="Panel1" runat="server"  Style="width: 1130px;">

        <div id="tab-container" style="width: 1110px;">
            <ul class="tab-menu">
                <li id="css" class="active" onclick="otorgar_permisos()">ACTUALIZACIÓN DE CASOS</li>

            </ul>
            <div class="clear"></div>
            <div class="tab-top-border"></div>

            <div id="css-tab" class="tab-content active">
                <h3 class="Titulos">FORMULARIO PARA ACTUALIZAR CASOS DE TRASLADOS</h3>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Panel CssClass="panel_informativo" ID="Panel2" runat="server" GroupingText="Posibilidades de Consulta">
                            <table class="tabla">
                                <tr>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label4" runat="server" Text="Cuenta del Cliente:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="A_Cuenta_Cliente" runat="server" AutoPostBack="true" OnTextChanged="A_Cuenta_Cliente_TextChanged"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label7" runat="server" Text="Id de Ingreso:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="A_Id_Ingreso" runat="server" AutoPostBack="true" OnTextChanged="A_Id_Ingreso_TextChanged"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label8" runat="server" Text="Usuario de Creación:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="A_Usuario_Creacion" runat="server" AutoPostBack="true" OnTextChanged="A_Usuario_Creacion_TextChanged"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <asp:Panel CssClass="panel_informativo" ID="Panel5" runat="server" GroupingText="Resultado de la Consulta">
                            <asp:GridView CssClass="mGrid" ID="A_CONSULTA_CASOS" runat="server" AutoGenerateColumns="False" DataKeyNames="ID_TRASLADO">
                                <Columns>
                                    <asp:TemplateField ShowHeader="False" HeaderText="EDITAR">
                                        <ItemTemplate>
                                            <a href='javascript:editar("<%# Eval("ID_TRASLADO") %>");'>
                                                <img class="c1" id='imageningreso_<%# Eval("ID_TRASLADO") %>' alt="Clic para mostrar u ocultar" src="Estilos/Imagenes/edita.png" />
                                            </a>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="ID_TRASLADO" HeaderText="ID TRASLADO" />
                                    <asp:BoundField DataField="CUENTA_CLIENTE" HeaderText="CUENTA CLIENTE" />
                                    <asp:BoundField DataField="DIRECCION" HeaderText="DIRECCION" ItemStyle-Width="500" ControlStyle-Width="500" ControlStyle-CssClass="textbox3" />
                                    <asp:BoundField DataField="ESTRATO" HeaderText="ESTRATO" />
                                    <asp:BoundField DataField="NODO" HeaderText="NODO" />
                                    <asp:BoundField DataField="TELEFONO_CELULAR" HeaderText="TELEFONO CELULAR" />
                                    <asp:BoundField DataField="TELEFONO_FIJO" HeaderText="TELEFONO FIJO" />
                                    <asp:BoundField DataField="FECHA_APERTURA" HeaderText="FECHA DE APERTURA" />
                                    <asp:BoundField DataField="HORA_APERTURA" HeaderText="HORA DE APERTURA" />
                                    <asp:BoundField DataField="USUARIO_APERTURA" HeaderText="USUARIO DE APERTURA" />
                                    <asp:BoundField DataField="RAZON" HeaderText="RAZON" />
                                    <asp:BoundField DataField="SUBRAZON" HeaderText="SUBRAZON" />
                                    <asp:BoundField DataField="USUARIO_BACKOFFICE" HeaderText="USUARIO BACKOFFICE" />
                                    <asp:BoundField DataField="ESTADO_BACKOFFICE" HeaderText="ESTADO BACKOFFICE" />
                                    <asp:BoundField DataField="ESTADO_CASO" HeaderText="ESTADO CASO" />
                                    <asp:BoundField DataField="ALIADO_APERTURA" HeaderText="ALIADO DE APERTURA" />
                                    <asp:BoundField DataField="NOMBRE_LINEA_INGRESO" HeaderText="NOMBRE LINEA INGRESO" />
                                    <asp:BoundField DataField="NOMBRE_LINEA_ESCALADO" HeaderText="NOMBRE LINEA ESCALADO" />
                                </Columns>
                            </asp:GridView>
                        </asp:Panel>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    </asp:Panel>
</asp:Content>

