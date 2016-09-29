<%@ Page Title="" Language="C#" MasterPageFile="~/Perfil_Administrador.master" AutoEventWireup="true" CodeFile="Modificacion_Casos_Admin.aspx.cs" Inherits="Modificacion_Casos_Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="jquery/jquery-1.11.1.js?1.0.0"></script>
    <script src="jquery/jquery.dropdownPlain.js?1.0.0"></script>
    <script src="javascript/Funciones.js?1.0.0"></script>
    <link href="Estilos/Style_Perfil_Asesor.css?1.0.0" rel="stylesheet" />
    <link href="Estilos/Style_Ingreso_Casos.css?1.0.0" rel="stylesheet" />
    <link href="Estilos/Menu.css?1.0.0" rel="stylesheet" />
    <script src="jquery/jquery-1.11.1.js?1.0.0"></script>
    <script src="jquery/jquery.datetimepicker.js?1.0.0"></script>
    <link href="Estilos/jquery.datetimepicker.css?1.0.0" rel="stylesheet" />
    <link href="Estilos/Style_Ingreso_Casos.css?1.0.0" rel="stylesheet" />
    <script src="javascript/Funciones.js?1.0.0"></script>
    <script lang="ja">
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

    <script lang="ja">
        function otorgar_permisos2() {

            var activeTabIndex = -1;
            var tabNames = ["Li1", "Li2", "Li3"];

            $(".tab-menu2 > li").click(function (e) {
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

            alert('Registro Actualizado');
        }
    </script>
    <script type="text/javascript">
        function mensaje2() {

            alert('Debe seleccionar un proceso a realizar');
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel CssClass="panel" ID="Panel1" runat="server">

        <div id="tab-container">
            <ul class="tab-menu">
                <li id="html" class="active" onclick="otorgar_permisos()">ADMINISTRACIÓN DE CASOS</li>
            </ul>
            <div class="clear"></div>
            <div class="tab-top-border"></div>
            <div id="html-tab" class="tab-content active">
                <h3 class="Titulos">FORMULARIO PARA ADMINISTRAR CASOS</h3>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>

                <asp:Panel CssClass="panel_informativo" ID="Panel3" runat="server" GroupingText="Detalle del Escalamiento">
                    <table class="tabla">
                        <tr>
                            <td>
                                <asp:Label CssClass="texto_informativo" ID="Label1" runat="server" Text="Id de Ingreso"></asp:Label><br />
                                <asp:TextBox CssClass="caja_de_texto" ID="Id_Ingreso" runat="server" Enabled="false"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label CssClass="texto_informativo" ID="Label2" runat="server" Text="Cuenta del Cliente"></asp:Label><br />
                                <asp:TextBox CssClass="caja_de_texto" ID="Cuenta_Cliente" runat="server" Enabled="false"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label CssClass="texto_informativo" ID="Label3" runat="server" Text="Ticket"></asp:Label><br />
                                <asp:TextBox CssClass="caja_de_texto" ID="Ticket" runat="server" Enabled="false"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label CssClass="texto_informativo" ID="Label4" runat="server" Text="Marcacion"></asp:Label><br />
                                <asp:TextBox CssClass="caja_de_texto" ID="Marcacion" runat="server" Enabled="false"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label CssClass="texto_informativo" ID="Label5" runat="server" Text="Fecha de Apertura"></asp:Label><br />
                                <asp:TextBox CssClass="caja_de_texto" ID="Fecha_Apertura" runat="server" Enabled="false"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label CssClass="texto_informativo" ID="Label6" runat="server" Text="Aliado Apertura"></asp:Label><br />
                                <asp:TextBox CssClass="caja_de_texto" ID="Aliado_Apertura" runat="server" Enabled="false"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label CssClass="texto_informativo" ID="Label7" runat="server" Text="Línea de Ingreso"></asp:Label><br />
                                <asp:TextBox CssClass="caja_de_texto" ID="Linea_de_Ingreso" runat="server" Enabled="false"></asp:TextBox>
                            </td>
                        </tr>
                    </table>

                </asp:Panel>

                <asp:Panel CssClass="panel_informativo" ID="Panel5" runat="server" GroupingText="Modificación a Realizar">

                    <table class="tabla2">
                        <tr>
                            <td>

                                <div class="SingleCheckbox">
                                    <asp:CheckBox ID="CheckBox1" runat="server" ValidationGroup="1" OnCheckedChanged="CheckBox1_CheckedChanged" AutoPostBack="true" />
                                    <asp:Label ID="Label17" AssociatedControlID="CheckBox1" runat="server" Text="Cambiar de Célula" CssClass="CheckBoxLabel"></asp:Label>
                                </div>
                            </td>
                            <td>
                                <div class="SingleCheckbox">
                                    <asp:CheckBox ID="CheckBox2" runat="server" ValidationGroup="1" OnCheckedChanged="CheckBox2_CheckedChanged" AutoPostBack="true" />
                                    <asp:Label ID="Label18" AssociatedControlID="CheckBox2" runat="server"
                                        Text="Reasignar a otro Back" CssClass="CheckBoxLabel"></asp:Label>
                                </div>
                            </td>
                            <td>
                                <div class="SingleCheckbox">
                                    <asp:CheckBox ID="CheckBox3" runat="server" ValidationGroup="1" OnCheckedChanged="CheckBox3_CheckedChanged" AutoPostBack="true" />
                                    <asp:Label ID="Label19" AssociatedControlID="CheckBox3" runat="server"
                                        Text="Cambiar de Estado" CssClass="CheckBoxLabel"></asp:Label>
                                </div>
                            </td>
                        </tr>
                    </table>

                </asp:Panel>
                <asp:Panel CssClass="panel_informativo" ID="Panel2" runat="server" GroupingText="Realice la Modificación" Visible="true">
                    <table class="tabla">
                        <tr>
                            <td colspan="2">
                                <asp:Label CssClass="texto_informativo" ID="Label9" runat="server" Text="Seleccione la Célula"></asp:Label><br />
                                <asp:DropDownList CssClass="dropdown3" ID="Celulas" runat="server" AutoPostBack="True"></asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label CssClass="texto_informativo" ID="Label12" runat="server" Text="Seleccione el Back"></asp:Label><br />
                                <asp:DropDownList CssClass="dropdown3" ID="Usuarios_Back" runat="server" AutoPostBack="True"></asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label CssClass="texto_informativo" ID="Label14" runat="server" Text="Seleccione el Estado"></asp:Label><br />
                                <asp:DropDownList CssClass="dropdown1" ID="Estado_Caso" runat="server" AutoPostBack="True"></asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>

                <asp:Panel CssClass="panel_informativo" ID="Panel4" runat="server" GroupingText="Notas del Cambio">
                    <table class="tabla">
                        <tr>
                            <td>
                                <asp:TextBox CssClass="ofrecimientos" ID="Notas" runat="server" Required="true"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>

                <asp:Button CssClass="button" ID="Actualizar" runat="server" Text="Guardar" OnClick="Actualizar_Click" />
            </div>
        </div>
    </asp:Panel>
</asp:Content>

