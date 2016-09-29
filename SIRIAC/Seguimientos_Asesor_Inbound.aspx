<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Perfil_Asesor.master" CodeFile="Seguimientos_Asesor_Inbound.aspx.cs" Inherits="Seguimientos_Asesor_Inbound" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


    <script src="jquery/jquery.dropdownPlain.js?1.0.0"></script>
    <script src="javascript/Funciones.js?1.0.0"></script>
    <link href="Estilos/Style_Perfil_Asesor.css?1.0.0" rel="stylesheet" />
    <link href="Estilos/Style_Ingreso_Casos.css?1.0.0" rel="stylesheet" />
    <link href="Estilos/Menu.css?1.0.0" rel="stylesheet" />


    <script type="text/javascript">
        function editar(obj) {

            var imageID = document.getElementById('imagen' + obj);
            window.location.href = 'Actualizar_Casos.aspx?id=' + obj;

        };
    </script>
    <script type="text/javascript">
        function mensaje1() {

            alert('Usted no tiene casos en seguimiento');
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:Panel CssClass="panel" ID="Panel1" runat="server">
        <asp:UpdatePanel ID="UpdatePanel9" runat="server">
            <ContentTemplate>
                <div id="tab-container">
                    <ul class="tab-menu">
                        <li id="html" class="active" onclick="otorgar_permisos()">SEGUIMIENTO DE CASOS</li>
                    </ul>
                    <div class="clear"></div>
                    <div class="tab-top-border"></div>
                    <div id="html-tab" class="tab-content active">

                        <h3 class="Titulos">FORMULARIO DE CASOS EN SEGUIMIENTO</h3>
                        <table class="tabla">
                            <tr>
                                <td>
                                    <asp:TextBox ID="TextBox1" runat="server" Style="display: none"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:GridView CssClass="mGrid" ID="SEGUIMIENTOS_ASESOR" runat="server" AutoGenerateColumns="False" AllowPaging="True" PageSize="5" OnPageIndexChanging="SEGUIMIENTOS_ASESOR_PageIndexChanging">
                                        <Columns>
                                            <asp:TemplateField ShowHeader="False" HeaderText="EDITAR">
                                                <ItemTemplate>
                                                    <a href='javascript:editar("<%# Eval("ID INGRESO") %>");'>
                                                        <img class="c1" id='imageningreso_<%# Eval("ID INGRESO") %>' alt="Clic para mostrar u ocultar" src="Estilos/Imagenes/edita.png" />
                                                    </a>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:BoundField DataField="ID INGRESO" HeaderText="ID INGRESO" />
                                            <asp:BoundField DataField="CUENTA CLIENTE" HeaderText="CUENTA CLIENTE" />
                                            <asp:BoundField DataField="TICKET" HeaderText="TICKET" />
                                            <asp:BoundField DataField="FECHA APERTURA" HeaderText="FECHA APERTURA" />
                                            <asp:BoundField DataField="HORA APERTURA" HeaderText="HORA APERTURA" />
                                            <asp:BoundField DataField="USUARIO APERTURA" HeaderText="USUARIO APERTURA" />
                                            <asp:BoundField DataField="FECHA ULTIMA ACTUALIZACION" HeaderText="FECHA ULTIMA ACTUALIZACION" />
                                            <asp:BoundField DataField="USUARIO ULTIMA ACTUALIZACION" HeaderText="USUARIO ULTIMA ACTUALIZACION" />
                                            <asp:BoundField DataField="MACROPROCESO" HeaderText="MACROPROCESO" />
                                            <asp:BoundField DataField="MARCACION" HeaderText="MARCACION" />
                                            <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" />
                                        </Columns>

                                    </asp:GridView>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </asp:Panel>
</asp:Content>
