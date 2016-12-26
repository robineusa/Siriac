<%@ Page Title="" Language="C#" MasterPageFile="~/Perfil_Celula.master" AutoEventWireup="true" CodeFile="Seguimiento_Celula_Traslados.aspx.cs" Inherits="Seguimiento_Celula_Traslados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script>
        function editar(obj) {
            var imageID = document.getElementById('imagen' + obj);
            window.location.href = 'Depuracion_Traslados.aspx?id=' + obj;
        };
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Panel CssClass="panel4" ID="Panel" runat="server">
        <div id="tab-container2">
            <ul class="tab-menu2">
                <li id="html" class="active" onclick="otorgar_permisos()">CASOS EN SEGUIMIENTO</li>
            </ul>
            <div class="clear"></div>
            <div class="tab-top-border"></div>
            <div id="html-tab" class="tab-content active">
                <h3 class="Titulos">LISTADO DE CASOS EN SEGUIMIENTO</h3>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Label ID="Label1" runat="server" Text="Label" Style="display: none"></asp:Label>
                        <asp:GridView CssClass="mGrid2" ID="CASOS_SEGUIMIENTOS_TRASLADOS" runat="server" AutoGenerateColumns="False" AllowPaging="true">
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
                                    <asp:BoundField DataField="DIRECCION" HeaderText="DIRECCION" ItemStyle-Width="500" ControlStyle-Width="500" ControlStyle-CssClass="textbox3"/>
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
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    </asp:Panel>

</asp:Content>

