<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Perfil_Asesor.master" CodeFile="Cambio_Contrasena_Inbound.aspx.cs" Inherits="Cambio_Contrasena_Inbound" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Estilos/Style_Ingreso_Casos.css?1.0.0" rel="stylesheet" />

    <script type="text/javascript">

        function ObtenerValor() {
            var TextBox7 = '<%=Contrasena_1.ClientID%>';
            var TextBox8 = '<%=Contrasena_2.ClientID%>';
            var Button1 = '<%=Button1.ClientID%>';

            var text7 = document.getElementById(TextBox7);
            var text8 = document.getElementById(TextBox8);
            var btn1 = document.getElementById(Button1);


            if (text7.value == text8.value) {
                var r = confirm("Desea actualizar la contraseña para el usuario?")
                if (r == true) {

                    alert("Se genero la actualización de la contraseña " + btn1.click());
                }

                else { }


            }
            else {
                alert("Las contraseñas ingresadas no coinciden")
            }

        }

    </script>
    <script type="text/javascript">
        function mensaje1() {

            alert('Contraseña Actualizada');
        }
    </script>
    <script type="text/javascript">
        function mensaje2() {

            alert('No existen datos para mostrar');
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <asp:Panel CssClass="panel" ID="Panel1" runat="server">
        <asp:UpdatePanel ID="UpdatePanel9" runat="server">
            <ContentTemplate>
                <div id="tab-container">
                    <ul class="tab-menu">
                        <li id="html" class="active" onclick="otorgar_permisos()">CAMBIO DE CONTRASEÑA</li>
                    </ul>
                    <div class="clear"></div>
                    <div class="tab-top-border"></div>
                    <div id="html-tab" class="tab-content active">

                        <h3 class="Titulos">FORMULARIO PARA EL CAMBIO DE LA CONTRASEÑA</h3>

                        <asp:Panel ID="Panel2" runat="server" CssClass="panel_informativo" GroupingText="Información del Usuario Conectado">
                            <table class="tabla">
                                <tr>
                                    <td>
                                        <p class="texto_informativo">Número de Cédula:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Cedula" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Nombre del Usuario:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Nombre_Usuario" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Usuario RR:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Usuario_RR" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Contraseña Actual:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Contrasena_Actual" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Rol del Usuario:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Rol_Usuario" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Usuario Agendamiento:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Usuario_Agendamiento" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <asp:Panel ID="Panel3" runat="server" CssClass="panel_informativo" GroupingText="Información del Usuario Conectado">
                            <table class="tabla">
                                <tr>
                                    <td>

                                        <p class="texto_informativo">Nueva Contraseña:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Contrasena_1" runat="server" Required="true"></asp:TextBox>
                                    </td>
                                    <td>

                                        <p class="texto_informativo">Confirme Contraseña:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Contrasena_2" runat="server" Required="true"></asp:TextBox>

                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <asp:Button CssClass="button" ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" Style="display: none" />
                        <asp:Button CssClass="button" ID="Button2" runat="server" Text="Guardar" OnClientClick="ObtenerValor()" />
                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </asp:Panel>
</asp:Content>
