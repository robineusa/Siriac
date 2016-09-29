<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Perfil_Asesor.master" CodeFile="Actualizar_Casos.aspx.cs" Inherits="Actualizar_Casos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Estilos/Style_Perfil_Asesor.css?1.0.3" rel="stylesheet" />
    <link href="Estilos/Style_Ingreso_Casos.css?1.0.3" rel="stylesheet" />
    <link href="Estilos/Menu.css?1.0.3" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script lang="ja">
        function otorgar_permisos() {

            var activeTabIndex = -1;
            var tabNames = ["html"];
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

            alert('Se registró la interacción del caso');
        }
    </script>
    <script type="text/javascript">
        function mensaje2() {

            alert('No se pudo registrar la interacción del caso');
        }
    </script>
    <script type="text/javascript">
        function mensaje3() {

            alert('No se ha seleccionado una marcacion');
        }
    </script>
    <script type="text/javascript">
        function mensaje4() {

            alert('Este caso ya esta cerrado, no puedes agregar interacciones');
        }
    </script>
    <asp:Panel CssClass="panel" ID="Panel1" runat="server">
        <asp:UpdatePanel ID="UpdatePanel9" runat="server">
            <ContentTemplate>
                <div id="tab-container">
                    <ul class="tab-menu">
                        <li id="html" class="active" onclick="otorgar_permisos()">ACTUALIZAR CASOS</li>

                    </ul>
                    <div class="clear"></div>
                    <div class="tab-top-border"></div>
                    <div id="html-tab" class="tab-content active">

                        <h3 class="Titulos">FORMULARIO PARA ACTUALIZAR CASOS Y AGREGAR INTERACCIONES</h3>
                       
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <asp:Panel CssClass="panel_informativo" ID="Panel4" runat="server" GroupingText="Registro de Interacciones">
                                    <table class="tabla">
                                        <tr>
                                            <td>

                                                <asp:TextBox ID="TextBox1" runat="server" Style="display: none"></asp:TextBox>

                                            </td>
                                        </tr>
                                    </table>
                                    <table class="tabla">
                                        <tr>
                                            <td>
                                                <asp:GridView CssClass="mGrid2" ID="GVNOTAS" runat="server" AutoGenerateColumns="False" GridLines="None">
                                                    <Columns>
                                                        <asp:BoundField DataField="ID_INGRESO" HeaderText="ID DE INGRESO" />
                                                        <asp:BoundField DataField="CUENTA_CLIENTE" HeaderText="CUENTA CLIENTE" />
                                                        <asp:BoundField DataField="TICKET" HeaderText="TICKET" />
                                                        <asp:BoundField DataField="USUARIO" HeaderText="USUARIO NOTA" />
                                                        <asp:BoundField DataField="PERFIL" HeaderText="PERFIL USUARIO" />
                                                        <asp:BoundField DataField="NOMBRE_LINEA_NOTA" HeaderText="NOMBRE LINEA NOTA" />
                                                        <asp:BoundField DataField="FECHA_NOTA" HeaderText="FECHA NOTA" />
                                                        <asp:BoundField DataField="HORA_NOTA" HeaderText="HORA NOTA" />
                                                        <asp:BoundField DataField="LLAMADA_CLIENTE" HeaderText="LLAMADA CLIENTE" />
                                                        <asp:BoundField DataField="NOTA" HeaderText="NOTA" />
                                                        <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" />
                                                    </Columns>
                                                </asp:GridView>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <asp:Panel CssClass="panel_informativo" ID="Panel2" runat="server" GroupingText="Información de Ingreso">
                                    <table class="tabla">

                                        <tr>
                                            <td>
                                                <asp:Label CssClass="texto_informativo" ID="Label1" runat="server" Text="Id de Ingreso:"></asp:Label><br />
                                                <asp:TextBox CssClass="caja_de_texto" ID="Id_Ingreso" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:Label CssClass="texto_informativo" ID="Label2" runat="server" Text="Número de Cuenta:"></asp:Label><br />
                                                <asp:TextBox CssClass="caja_de_texto" ID="Cuenta_Cliente" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:Label CssClass="texto_informativo" ID="Label3" runat="server" Text="Número de Ticket:"></asp:Label><br />
                                                <asp:TextBox CssClass="caja_de_texto" ID="Ticket" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:Button CssClass="button" ID="Gestionar" runat="server" Text="Cambiar Datos" OnClick="Gestionar_Click" /></td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <asp:Panel CssClass="panel_informativo" ID="Panel3" runat="server" GroupingText="Mapa de Marcaciones">
                                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                        <ContentTemplate>
                                            <table class="tabla">
                                                <tr>
                                                    <td colspan="6">
                                                        <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                                            <ContentTemplate>
                                                                <asp:Label CssClass="texto_informativo" ID="Label5" runat="server" Text="Ingrese datos para consultar:"></asp:Label><br />
                                                                <asp:TextBox CssClass="caja_de_texto_consulta" ID="Caja_Consulta" runat="server" AutoPostBack="true" OnTextChanged="Caja_Consulta_TextChanged"></asp:TextBox>
                                                            </ContentTemplate>
                                                        </asp:UpdatePanel>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="7">
                                                        <div class="base_marcacion">
                                                            <asp:RadioButtonList ID="Lista_Marcaciones" runat="server" AutoPostBack="True" OnSelectedIndexChanged="Lista_Marcaciones_SelectedIndexChanged">
                                                            </asp:RadioButtonList>
                                                        </div>
                                                    </td>
                                                </tr>
                                            </table>
                                            <table class="tabla">

                                                <tr>
                                                    <td colspan="2">
                                                        <asp:Label CssClass="texto_informativo" ID="Label34" runat="server" Text="Servicio:"></asp:Label><br />
                                                        <asp:DropDownList CssClass="dropdown1" ID="Servicios" runat="server"></asp:DropDownList>

                                                    </td>
                                                    <td colspan="2">
                                                        <asp:Label CssClass="texto_informativo" ID="Label35" runat="server" Text="Macroproceso:"></asp:Label><br />
                                                        <asp:DropDownList CssClass="dropdown2" ID="Macroproceso_C" runat="server">
                                                        </asp:DropDownList>

                                                    </td>
                                                    <td colspan="3">
                                                        <asp:Label CssClass="texto_informativo" ID="Label36" runat="server" Text="Proceso:"></asp:Label><br />
                                                        <asp:DropDownList CssClass="dropdown3" ID="Proceso_C" runat="server">
                                                        </asp:DropDownList>

                                                    </td>
                                                    <td>
                                                        <asp:Label CssClass="texto_informativo" ID="Label37" runat="server" Text="Subproceso:"></asp:Label><br />
                                                        <asp:DropDownList CssClass="dropdown3" ID="Subproceso_C" runat="server">
                                                        </asp:DropDownList>

                                                    </td>
                                                </tr>
                                            </table>
                                            <table class="tabla">
                                                <tr>
                                                    <td colspan="6">
                                                        <h4 class="Titulo_Informativo2">POSIBLE CAUSA:</h4>
                                                        <div class="marcacion">
                                                            <asp:Label ID="Posible_Causa" runat="server"></asp:Label>
                                                        </div>
                                                        <br />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="7">
                                                        <h4 class="Titulo_Informativo2">QUE HACER:</h4>
                                                        <div class="marcacion">
                                                            <asp:Label ID="Que_Hacer" runat="server"></asp:Label>
                                                        </div>
                                                        <br />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="7">
                                                        <h4 class="Titulo_Informativo2">CÓDIGOS DE CIERRE:</h4>
                                                        <div class="marcacion">
                                                            <asp:Label ID="Codigos_de_Cierre" runat="server"></asp:Label>
                                                        </div>
                                                        <br />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="7">
                                                        <h4 class="Titulo_Informativo2">ÁREA USUARIO A ESCALAR:</h4>
                                                        <div class="marcacion">
                                                            <asp:Label ID="Usuario_a_Escalar" runat="server"></asp:Label>
                                                        </div>
                                                        <br />
                                                    </td>
                                                </tr>
                                            </table>
                                            <table class="tabla">
                                                <tr>
                                                    <td>
                                                        <h4 class="Titulo_Informativo2">MARCACIÓN:</h4>
                                                        <asp:DropDownList CssClass="dropdown1" ID="Marcacion" runat="server" AutoPostBack="true">
                                                        </asp:DropDownList>
                                                    </td>
                                                    <td>
                                                        <h4 class="Titulo_Informativo2">TIPO DE ATENCIÓN:</h4>
                                                        <asp:DropDownList CssClass="dropdown1" ID="Tipo_Atencion" runat="server">
                                                        </asp:DropDownList>

                                                    </td>
                                                    <td>
                                                        <h4 class="Titulo_Informativo2">PRODUCTO ASOCIADO:</h4>
                                                        <asp:DropDownList CssClass="dropdown1" ID="Producto_Asociado" runat="server">
                                                        </asp:DropDownList>

                                                    </td>
                                                    <td>
                                                        <h4 class="Titulo_Informativo2">SPC:</h4>
                                                        <asp:DropDownList CssClass="dropdown1" ID="Spc" runat="server">
                                                        </asp:DropDownList>

                                                    </td>
                                                </tr>
                                            </table>
                                            <table class="tabla">
                                                <tr>
                                                    <td colspan="7">
                                                        <h4 class="Titulo_Informativo2">NOTAS:</h4>
                                                        <asp:TextBox CssClass="notas_casos" ID="Notas" runat="server" TextMode="MultiLine"></asp:TextBox>
                                                        <br />
                                                    </td>
                                                </tr>
                                            </table>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                    <asp:UpdateProgress ID="UpdateProgress2" runat="server" DisplayAfter="0" AssociatedUpdatePanelID="UpdatePanel1">
                                        <ProgressTemplate>
                                        </ProgressTemplate>
                                    </asp:UpdateProgress>



                                </asp:Panel>
                                <asp:Panel CssClass="panel_informativo" ID="Panel5" runat="server" GroupingText="Estado de la Interacción">
                                    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                        <ContentTemplate>
                                            <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                                <ContentTemplate>
                                                    <table class="tabla">
                                                        <tr>
                                                            <td>

                                                                <h4 class="Titulo_Informativo2">ESTADO CASO:</h4>
                                                                <asp:DropDownList CssClass="dropdown1" ID="Estado_del_Caso" runat="server" OnSelectedIndexChanged="Estado_del_Caso_SelectedIndexChanged" AutoPostBack="true">
                                                                </asp:DropDownList>

                                                            </td>
                                                            <td colspan="1">
                                                                <h4 class="Titulo_Informativo2">AREA A ESCALAR:</h4>
                                                                <asp:DropDownList CssClass="dropdown2" ID="Nombre_de_Linea" runat="server"></asp:DropDownList>



                                                            </td>
                                                            <td>
                                                                <h4 class="Titulo_Informativo2">LLAMADA CLIENTE:</h4>
                                                                <asp:DropDownList CssClass="dropdown1" ID="Llamada_Cliente" runat="server">
                                                                    <asp:ListItem>NO</asp:ListItem>
                                                                    <asp:ListItem>SI</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </td>
                                                        </tr>

                                                    </table>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                            <asp:Label ID="Label4" runat="server" Text="" Style="display: none"></asp:Label>
                                            <asp:Label ID="Label6" runat="server" Text="" Style="display: none"></asp:Label>
                                            <asp:Label ID="Label7" runat="server" Text="" Style="display: none"></asp:Label>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </asp:Panel>
                                <asp:Button CssClass="button" ID="Guardar_Interaccion" runat="server" Text="Guardar" OnClick="Guardar_Interaccion_Click" />

                            </ContentTemplate>

                        </asp:UpdatePanel>
                        <asp:UpdateProgress ID="UpdateProgress1" runat="server" DisplayAfter="0" AssociatedUpdatePanelID="UpdatePanel1">
                        </asp:UpdateProgress>
                    </div>
                </div>


            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdateProgress ID="UpdateProgress8" runat="server" DisplayAfter="0">
        </asp:UpdateProgress>
    </asp:Panel>
</asp:Content>

