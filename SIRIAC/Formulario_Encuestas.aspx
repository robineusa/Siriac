<%@ Page Title="" Language="C#" MasterPageFile="~/Perfil_Lider.master" AutoEventWireup="true" CodeFile="Formulario_Encuestas.aspx.cs" Inherits="Fomrulario_Encuestas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <link href="Estilos/Style_Ingreso_Casos.css?1.0.0" rel="stylesheet" />
    <link href="Estilos/Style_Ingreso_Casos.css" rel="stylesheet" />


    <script type="text/javascript">
        function justNumbers(e) {
            var keynum = window.event ? window.event.keyCode : e.which;
            if ((keynum == 8) || (keynum == 46))
                return true;

            return /\d/.test(String.fromCharCode(keynum));
        }

    </script>
    <script type="text/javascript">
        function mensaje1() {

            alert('Registro Almacenado');

        }
    </script>
    <script type="text/javascript">
        function mensaje2() {

            alert('Registro NO Almacenado');
        }
    </script>

    <script type="text/javascript">
        function mensaje5() {

            alert('¡El número de cuenta igresado no existe!');
        }
    </script>
    <script type="text/javascript">
        function mensaje6() {

            alert('¡Debe ingresar un número de cuenta!');
        }
    </script>
    <script type="text/javascript">
        function click1() {
            if ($("#Cancelaciones").attr("f") === "0") {
                document.getElementById("Cancelaciones").style.display = "block";
                $("#Cancelaciones").attr("f", "1");
            } else {
                document.getElementById("Cancelaciones").style.display = "none";
                $("#Cancelaciones").attr("f", "0");
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:Panel CssClass="panel" ID="Panel1" runat="server">
        <div id="tab-container">
            <ul class="tab-menu">
                <li id="html" class="active" onclick="otorgar_permisos()">ENCUESTAS</li>

            </ul>
            <div class="clear"></div>
            <div class="tab-top-border"></div>
            <div id="html-tab" class="tab-content active">
                <h3 class="Titulos">FORMULARIO DE ENCUESTAS </h3>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Panel CssClass="panel_informativo" ID="Panel3" runat="server" GroupingText="Datos del Cliente">
                            <table class="tabla">
                                <tr>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label3" runat="server" Text="Número de Cuenta:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Cuenta_Cliente" runat="server" AutoPostBack="true" Placeholder="Ingrese la cuenta"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label4" runat="server" Text="Nombre del Cliente:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Nombre_Cliente" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label5" runat="server" Text="Apellido 1:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Apellido_Cliente_1" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label6" runat="server" Text="Apellido 2:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Apellido_Cliente_2" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label1" runat="server" Text="Documento de Identidad:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="TextBox1" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label7" runat="server" Text="Ciudad:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Ciudad" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label8" runat="server" Text="Nodo:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Nodo" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                            <table class="tabla">
                                <tr>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label17" runat="server" Text="Contrato:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Contrato" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label18" runat="server" Text="Teléfono 1:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Telefono_1" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label19" runat="server" Text="Teléfono 2:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Telefono_2" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label20" runat="server" Text="Teléfono 3:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Telefono_3" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label23" runat="server" Text="Teléfono Móvil 1:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Telefono_Movil_1" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label29" runat="server" Text="Teléfono Móvil 2:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Telefono_Movil_2" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label30" runat="server" Text="Teléfono Móvil 3:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Telefono_Movil_3" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                            <table class="tabla">
                                <tr>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label21" runat="server" Text="Estrato:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Estrato" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <asp:Panel CssClass="panel_informativo" ID="Panel2" runat="server" GroupingText="Datos del Asesor">
                            <table class="tabla">
                                <tr>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label2" runat="server" Text="Cédula:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="TextBox2" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label9" runat="server" Text="Nombre del Asesor:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="TextBox3" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label10" runat="server" Text="Operación:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="TextBox4" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label11" runat="server" Text="Fecha de Gestión:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="TextBox5" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                            <table class="tabla">
                                <tr>
                                    <td colspan="5">
                                        <div class="Titulo_Usuarios5">
                                            <p class="etiquetas5">Observaciones:</p>
                                        </div>
                                        <asp:TextBox CssClass="ofrecimientos" ID="Historico" runat="server" TextMode="MultiLine" Enabled="false"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <ContentTemplate>
                        <asp:Panel CssClass="panel_informativo" ID="Cabezote" runat="server" GroupingText="Seleccione la encuesta a realizar">
                            <table class="tabla">
                                <tr>
                                    <td>
                                        <div class="referencia" runat="server" onclick="click1()"><a>Cancelaciones</a></div>
                                        <%--<asp:Button class="referencia" ID="Button1" runat="server" OnClick="click" Text="Cancelaciones" />--%>
                                    </td>
                                    <td>
                                        <div class="referencia"><a>CGV</a></div>
                                    </td>
                                    <td>
                                        <div class="referencia"><a>TMK</a></div>
                                    </td>
                                    <td>
                                        <div class="referencia"><a>SAC</a></div>
                                    </td>
                                    <td>
                                        <div class="referencia"><a>Alto Valor</a></div>
                                    </td>
                                    <td>
                                        <div class="referencia"><a>VIP</a></div>
                                    </td>

                                </tr>
                            </table>
                        </asp:Panel>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                    <ContentTemplate>
                        <div id="Cancelaciones" f="0" style="display: none">
                            <asp:Panel CssClass="panel_informativo" ID="Panel9" runat="server" GroupingText="CANCELACIONES">
                                <br />
                                <asp:Panel CssClass="panel_informativo" ID="Panel5" runat="server" GroupingText="Arbol de Tipificacion">
                                </asp:Panel>
                                <br />
                                <asp:Panel CssClass="panel_informativo" ID="Panel4" runat="server" GroupingText="Preguntas">
                                    <table class="tabla">
                                        <tr>
                                            <td>
                                                <div class="Encuestas">
                                                    <p class="etiquetas_encuestas">¿Como fue la amabilidad y la atención por parte del asesor?: </p>
                                                </div>
                                                <asp:DropDownList CssClass="dropdown3" ID="D1" runat="server">
                                                    <asp:ListItem>1</asp:ListItem>
                                                    <asp:ListItem>2</asp:ListItem>
                                                    <asp:ListItem>3</asp:ListItem>
                                                    <asp:ListItem>4</asp:ListItem>
                                                    <asp:ListItem>5</asp:ListItem>
                                                    <asp:ListItem>6</asp:ListItem>
                                                    <asp:ListItem>7</asp:ListItem>
                                                    <asp:ListItem>8</asp:ListItem>
                                                    <asp:ListItem>9</asp:ListItem>
                                                    <asp:ListItem>10</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div class="Encuestas">
                                                    <p class="etiquetas_encuestas">Los tiempos de espera durante la llamada (Enfocarlos a la llamada donde el cliente acepto los servicios): </p>
                                                </div>
                                                <asp:DropDownList CssClass="dropdown3" ID="D2" runat="server">
                                                    <asp:ListItem>1</asp:ListItem>
                                                    <asp:ListItem>2</asp:ListItem>
                                                    <asp:ListItem>3</asp:ListItem>
                                                    <asp:ListItem>4</asp:ListItem>
                                                    <asp:ListItem>5</asp:ListItem>
                                                    <asp:ListItem>6</asp:ListItem>
                                                    <asp:ListItem>7</asp:ListItem>
                                                    <asp:ListItem>8</asp:ListItem>
                                                    <asp:ListItem>9</asp:ListItem>
                                                    <asp:ListItem>10</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div class="Encuestas">
                                                    <p class="etiquetas_encuestas">El asesor escucho y atendió su necesidad: </p>
                                                </div>
                                                <asp:DropDownList CssClass="dropdown3" ID="DropDownList1" runat="server">
                                                    <asp:ListItem>1</asp:ListItem>
                                                    <asp:ListItem>2</asp:ListItem>
                                                    <asp:ListItem>3</asp:ListItem>
                                                    <asp:ListItem>4</asp:ListItem>
                                                    <asp:ListItem>5</asp:ListItem>
                                                    <asp:ListItem>6</asp:ListItem>
                                                    <asp:ListItem>7</asp:ListItem>
                                                    <asp:ListItem>8</asp:ListItem>
                                                    <asp:ListItem>9</asp:ListItem>
                                                    <asp:ListItem>10</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div class="Encuestas">
                                                    <p class="etiquetas_encuestas">La solucion brindada se ajusta a sus necesidades: </p>
                                                </div>
                                                <asp:DropDownList CssClass="dropdown3" ID="DropDownList2" runat="server">
                                                    <asp:ListItem>1</asp:ListItem>
                                                    <asp:ListItem>2</asp:ListItem>
                                                    <asp:ListItem>3</asp:ListItem>
                                                    <asp:ListItem>4</asp:ListItem>
                                                    <asp:ListItem>5</asp:ListItem>
                                                    <asp:ListItem>6</asp:ListItem>
                                                    <asp:ListItem>7</asp:ListItem>
                                                    <asp:ListItem>8</asp:ListItem>
                                                    <asp:ListItem>9</asp:ListItem>
                                                    <asp:ListItem>10</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                    </table>
                                    <asp:Button CssClass="button" ID="CE_Guardar" runat="server" Text="Guardar" /><br />
                                    <br />
                                </asp:Panel>
                            </asp:Panel>

                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    </asp:Panel>
</asp:Content>

