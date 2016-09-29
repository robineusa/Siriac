<%@ Page Title="" Language="C#" MasterPageFile="~/Perfil_Administrador.master" AutoEventWireup="true" CodeFile="Administracion_de_Casos.aspx.cs" Inherits="Administracion_de_Casos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script src="jquery/jquery-1.11.1.js?1.0.3"></script>
    <script src="jquery/jquery.dropdownPlain.js?1.0.3"></script>
    <link href="Estilos/Style_Perfil_Asesor.css?1.0.3" rel="stylesheet" />
    <link href="Estilos/Style_Ingreso_Casos.css?1.0.3" rel="stylesheet" />
    <link href="Estilos/Menu.css?1.0.3" rel="stylesheet" />


    <script type="text/javascript">
        function editar(obj) {

            var imageID = document.getElementById('imagen' + obj);
            window.location.href = 'Modificacion_Casos_Admin.aspx?id=' + obj;

        };
    </script>
    <script type="text/javascript">
        $(document).ready(function () {
            if ('<%=Session["Acceso_4"]%>' == "1") {

            } else {
                $("#Primer_div").hide();
                $("#html").hide();
            }
            if ('<%=Session["Acceso_9"]%>' == "1") {
                if ('<%=Session["Acceso_4"]%>' == "1") {

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
        function mensaje1() {

            alert('No existen casos creados para registro ingresado');
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel CssClass="panel" ID="Panel1" runat="server">

        <div id="tab-container">
            <ul class="tab-menu">
                <li id="html" class="active" onclick="otorgar_permisos()">CONSULTA DE CASOS</li>
                <li id="css" onclick="otorgar_permisos()">ACTUALIZACIÓN DE CASOS</li>

            </ul>
            <div class="clear"></div>
            <div class="tab-top-border"></div>
            <div id="Primer_div">
                <div id="html-tab" class="tab-content active">
                    <h3 class="Titulos">FORMULARIO PARA CONSULTAR CASOS</h3>
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                    <asp:Panel CssClass="panel_informativo" ID="Panel3" runat="server" GroupingText="Posibilidades de Consulta">
                        <table id="T1" class="tabla">
                            <tr>
                                <td>
                                    <asp:Label CssClass="texto_informativo" ID="Label1" runat="server" Text="Cuenta del Cliente:"></asp:Label><br />
                                    <asp:TextBox CssClass="caja_de_texto" ID="Cuenta_Cliente" runat="server" AutoPostBack="true" OnTextChanged="Cuenta_Cliente_TextChanged"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label CssClass="texto_informativo" ID="Label6" runat="server" Text="Ticket RR:"></asp:Label><br />
                                    <asp:TextBox CssClass="caja_de_texto" ID="Ticket" runat="server" AutoPostBack="true" OnTextChanged="Ticket_TextChanged"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label CssClass="texto_informativo" ID="Label2" runat="server" Text="Id de Ingreso:"></asp:Label><br />
                                    <asp:TextBox CssClass="caja_de_texto" ID="Id_Ingreso" runat="server" AutoPostBack="true" OnTextChanged="Id_Ingreso_TextChanged"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label CssClass="texto_informativo" ID="Label3" runat="server" Text="Usuario de Creación:"></asp:Label><br />
                                    <asp:TextBox CssClass="caja_de_texto" ID="Usuario_Creacion" runat="server" AutoPostBack="true" OnTextChanged="Usuario_Creacion_TextChanged"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>

                    <asp:Panel CssClass="panel_informativo" ID="Panel4" runat="server" GroupingText="Resultado de la consulta">
                        <asp:GridView CssClass="mGrid" ID="CONSULTA_CASOS" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="ID_INGRESO" HeaderText="ID DE INGRESO" />
                                <asp:BoundField DataField="CUENTA_CLIENTE" HeaderText="CUENTA CLIENTE" />
                                <asp:BoundField DataField="TICKET" HeaderText="TICKET" />
                                <asp:BoundField DataField="FECHA_APERTURA" HeaderText="FECHA DE APERTURA" />
                                <asp:BoundField DataField="HORA_APERTURA" HeaderText="HORA DE APERTURA" />
                                <asp:BoundField DataField="USUARIO_APERTURA" HeaderText="USUARIO DE APERTURA" />
                                <asp:BoundField DataField="NOMBRE_LINEA_INGRESO" HeaderText="NOMBRE LINEA INGRESO" />
                                <asp:BoundField DataField="NOMBRE_LINEA_ESCALADO" HeaderText="NOMBRE LINEA ESCALADO" />
                                <asp:BoundField DataField="ALIADO_APERTURA" HeaderText="ALIADO APERTURA" />
                                <asp:BoundField DataField="MACROPROCESO" HeaderText="MACROPROCESO" />
                                <asp:BoundField DataField="PROCESO" HeaderText="PROCESO" />
                                <asp:BoundField DataField="MARCACION" HeaderText="MARCACION" />
                                <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" />
                                <asp:TemplateField Visible="False"></asp:TemplateField>
                                <asp:ImageField DataImageUrlField="SEMAFORO" DataImageUrlFormatString="~/Estilos/Imagenes/{0}" HeaderText="SEMAFORO" ItemStyle-HorizontalAlign="Center" ControlStyle-Width="20px">
                                    <ControlStyle Width="20px"></ControlStyle>

                                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                </asp:ImageField>
                            </Columns>
                        </asp:GridView>

                    </asp:Panel>
                </div>
            </div>

            <div id="Segundo_div">
                <div id="css-tab" class="tab-content">
                    <h3 class="Titulos">FORMULARIO PARA ACTUALIZAR CASOS</h3>
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
                                            <asp:Label CssClass="texto_informativo" ID="Label5" runat="server" Text="Ticket RR:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="A_Ticket" runat="server" AutoPostBack="true" OnTextChanged="A_Ticket_TextChanged"></asp:TextBox>
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
                                <asp:GridView CssClass="mGrid" ID="A_CONSULTA_CASOS" runat="server" AutoGenerateColumns="False" DataKeyNames="ID_INGRESO">
                                    <Columns>
                                        <asp:TemplateField ShowHeader="False" HeaderText="EDITAR">
                                            <ItemTemplate>
                                                <a href='javascript:editar("<%# Eval("ID_INGRESO") %>");'>
                                                    <img class="c1" id='imageningreso_<%# Eval("ID_INGRESO") %>' alt="Clic para mostrar u ocultar" src="Estilos/Imagenes/edita.png" />
                                                </a>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="ID_INGRESO" HeaderText="ID DE INGRESO" />
                                        <asp:BoundField DataField="CUENTA_CLIENTE" HeaderText="CUENTA DEL CLIENTE" />
                                        <asp:BoundField DataField="TICKET" HeaderText="TICKET" />
                                        <asp:BoundField DataField="FECHA_APERTURA" HeaderText="FECHA DE APERTURA" />
                                        <asp:BoundField DataField="HORA_APERTURA" HeaderText="HORA DE APERTURA" />
                                        <asp:BoundField DataField="USUARIO_APERTURA" HeaderText="USUARIO DE APERTURA" />
                                        <asp:BoundField DataField="NOMBRE_LINEA_INGRESO" HeaderText="NOMBRE LINEA INGRESO" />
                                        <asp:BoundField DataField="NOMBRE_LINEA_ESCALADO" HeaderText="NOMBRE LINEA ESCALADO" />
                                        <asp:BoundField DataField="ALIADO_APERTURA" HeaderText="ALIADO DE APERTURA" />
                                        <asp:BoundField DataField="MACROPROCESO" HeaderText="MACROPROCESO" />
                                        <asp:BoundField DataField="PROCESO" HeaderText="PROCESO" />
                                        <asp:BoundField DataField="MARCACION" HeaderText="MARCACION" />
                                        <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" />
                                        <asp:TemplateField Visible="False"></asp:TemplateField>
                                        <asp:ImageField DataImageUrlField="SEMAFORO" DataImageUrlFormatString="~/Estilos/Imagenes/{0}" HeaderText="SEMAFORO" ItemStyle-HorizontalAlign="Center" ControlStyle-Width="20px">
                                            <ControlStyle Width="20px"></ControlStyle>

                                            <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                        </asp:ImageField>

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

