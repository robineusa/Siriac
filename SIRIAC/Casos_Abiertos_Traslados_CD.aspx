<%@ Page Title="" Language="C#" MasterPageFile="~/Perfil_Celula.master" AutoEventWireup="true" CodeFile="Casos_Abiertos_Traslados_CD.aspx.cs" Inherits="Casos_Abiertos_Traslados_CD" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <script type="text/javascript">
        $(document).ready(function () {
            if ('<%=Session["Acceso_1"]%>' == "1") {

            } else {
                $("#Primer_div").hide();
                $("#html").hide();
            }
            if ('<%=Session["Acceso_3"]%>' == "1") {
                if ('<%=Session["Acceso_1"]%>' == "1") {

                } else {
                    $("#css").addClass("active");
                    $("#css-tab").addClass("tab-content active");
                }
            } else {
                $("#Segundo_div").hide();
                $("#css").hide();
            }
        });

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
    <script type="text/javascript">
        function editar(obj) {

            var imageID = document.getElementById('imagen' + obj);
            window.location.href = 'Depuracion_de_Casos.aspx?id=' + obj;
        };
    </script>
    <asp:Panel CssClass="panel" ID="Panel1" runat="server" style="width:1060px;">
        <div id="tab-container" style="width:1040px;">
            <ul class="tab-menu">
                <li id="html" class="active" onclick="otorgar_permisos()">CASOS ABIERTOS</li>
                <li id="css" onclick="otorgar_permisos()">CONSULTA DE CASOS</li>
            </ul>
            <div class="clear"></div>
            <div class="tab-top-border"></div>
            <div id="Primer_div">
                <div id="html-tab" class="tab-content active">
                    <h3 class="Titulos">BOLSA DE CASOS ABIERTOS ESCALADOS A LA CÉLULA PARA LA CREACIÓN DE DIRECCIONES</h3>
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:Label ID="Label1" runat="server" Text="Label" Style="display: none"></asp:Label>
                            <asp:Label ID="Label2" runat="server" Text="Label" Style="display: none"></asp:Label>
                            <asp:GridView CssClass="mGrid" ID="CASOS_ESCALADOS_TRASLADOS" runat="server" AutoGenerateColumns="False" AllowPaging="true" >
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
                                    <asp:BoundField DataField="DIRECCION" HeaderText="DIRECCION" />
                                    <asp:BoundField DataField="ESTRATO" HeaderText="ESTRATO" />
                                    <asp:BoundField DataField="NODO" HeaderText="NODO" />
                                    <asp:BoundField DataField="RED" HeaderText="RED" />
                                    <asp:BoundField DataField="TELEFONO_CELULAR" HeaderText="TELEFONO CELULAR" />
                                    <asp:BoundField DataField="TELEFONO_FIJO" HeaderText="TELEFONO FIJO" />
                                    <asp:BoundField DataField="FECHA_APERTURA" HeaderText="FECHA DE APERTURA" />
                                    <asp:BoundField DataField="HORA_APERTURA" HeaderText="HORA DE APERTURA" />
                                    <asp:BoundField DataField="USUARIO_APERTURA" HeaderText="USUARIO DE APERTURA" />
                                    <asp:BoundField DataField="RAZON" HeaderText="RAZON" />
                                    <asp:BoundField DataField="SUBRAZON" HeaderText="SUBRAZON" />
                                    <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" />
                                    <asp:BoundField DataField="ALIADO_APERTURA" HeaderText="ALIADO DE APERTURA" />
                                    <asp:BoundField DataField="NOMBRE_LINEA_INGRESO" HeaderText="NOMBRE LINEA INGRESO" />
                                    <asp:BoundField DataField="NOMBRE_LINEA_ESCALADO" HeaderText="NOMBRE LINEA ESCALADO" />
                                    <asp:TemplateField Visible="False"></asp:TemplateField>
                                    
                                    
                                </Columns>
                            </asp:GridView>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <%--<asp:Button CssClass="button" ID="Exportar" runat="server" Text="Exportar" OnClick="Exportar_Click" />--%>
                </div>
            </div>

            <div id="Segundo_div">
                <div id="css-tab" class="tab-content">
                    <h3 class="Titulos">FORMULARIO PARA LA CONSULTA DE CASOS ESCALADOS</h3>
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                            <asp:Panel CssClass="panel_informativo" ID="Panel3" runat="server" GroupingText="Datos del Escalamiento">
                                <table class="tabla">
                                    <tr>
                                        <td>
                                            <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                                <ContentTemplate>
                                                    <p class="texto_informativo">Cuenta Cliente:</p>
                                                    <asp:TextBox CssClass="caja_de_texto" ID="Cuenta_Cliente" runat="server" OnTextChanged="Cuenta_Cliente_TextChanged" AutoPostBack="true"></asp:TextBox>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </td>
                                        <td>
                                            <p class="texto_informativo">Id de Ingreso:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="Id_Ingreso" runat="server" OnTextChanged="Id_Ingreso_TextChanged" AutoPostBack="true"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                            <asp:Panel CssClass="panel_informativo" ID="Panel2" runat="server" GroupingText="Resultado de la Consulta">
                                <asp:GridView CssClass="mGrid" ID="CONSULTA_CASOS" runat="server" AutoGenerateColumns="False">
                                    <Columns>
                                        <asp:TemplateField ShowHeader="False" HeaderText="EDITAR">
                                            <ItemTemplate>
                                                <a href='javascript:editar("<%# Eval("ID_INGRESO") %>");'>
                                                    <img class="c1" id='imageningreso_<%# Eval("ID_INGRESO") %>' alt="Clic para mostrar u ocultar" src="Estilos/Imagenes/edita.png" />
                                                </a>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="ID_INGRESO" HeaderText="ID INGRESO" />
                                        <asp:BoundField DataField="CUENTA_CLIENTE" HeaderText="CUENTA CLIENTE" />
                                        <asp:BoundField DataField="TICKET" HeaderText="TICKET" />
                                        <asp:BoundField DataField="FECHA_APERTURA" HeaderText="FECHA DE APERTURA" />
                                        <asp:BoundField DataField="USUARIO_APERTURA" HeaderText="USUARIO DE APERTURA" />
                                        <asp:BoundField DataField="MACROPROCESO" HeaderText="MACROPROCESO" />
                                        <asp:BoundField DataField="PROCESO" HeaderText="PROCESO" />
                                        <asp:BoundField DataField="SUBPROCESO" HeaderText="SUBPROCESO" />
                                        <asp:BoundField DataField="MARCACION" HeaderText="MARCACION" />
                                        <asp:BoundField DataField="ALIADO_APERTURA" HeaderText="ALIADO APERTURA" />
                                        <asp:BoundField DataField="NOMBRE_LINEA_INGRESO" HeaderText="NOMBRE LINEA INGRESO" />
                                        <asp:BoundField DataField="NOMBRE_LINEA_ESCALADO" HeaderText="NOMBRE LINEA ESCALADO" />
                                        <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" />
                                        <asp:BoundField DataField="SEMAFORO" HeaderText="SEMAFORO" Visible="False" />

                                        <asp:TemplateField Visible="False"></asp:TemplateField>
                                        <asp:ImageField DataImageUrlField="SEMAFORO" DataImageUrlFormatString="~/Estilos/Imagenes/{0}" HeaderText="SEMAFORO" ItemStyle-HorizontalAlign="Center" ControlStyle-Width="20px">
                                            <ControlStyle Width="20px"></ControlStyle>

                                            <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                        </asp:ImageField>
                                        <asp:TemplateField></asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </asp:Panel>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
        </div>

    </asp:Panel>
</asp:Content>

