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

    <asp:Panel CssClass="panel" ID="Panel1" runat="server">
        <div id="tab-container">
            <ul class="tab-menu">
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
                        <asp:GridView CssClass="mGrid" ID="GVINGRESOS" runat="server" AutoGenerateColumns="False" OnPageIndexChanging="GVINGRESOS_PageIndexChanging">
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
                                <asp:BoundField DataField="FECHA_APERTURA" HeaderText="FECHA DE APERTURA" />
                                <asp:BoundField DataField="HORA_APERTURA" HeaderText="HORA APERTURA" />
                                <asp:BoundField DataField="USUARIO_APERTURA" HeaderText="USUARIO APERTURA" />
                                <asp:BoundField DataField="MACROPROCESO" HeaderText="MACROPROCESO" />
                                <asp:BoundField DataField="PROCESO" HeaderText="PROCESO" />
                                <asp:BoundField DataField="SUBPROCESO" HeaderText="SUBPROCESO" />
                                <asp:BoundField DataField="MARCACION" HeaderText="MARCACION" />
                                <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" />
                                <asp:BoundField DataField="ALIADO_APERTURA" HeaderText="ALIADO APERTURA" />

                                <asp:TemplateField Visible="False"></asp:TemplateField>
                                <asp:ImageField DataImageUrlField="SEMAFORO" DataImageUrlFormatString="~/Estilos/Imagenes/{0}" HeaderText="SEMAFORO" ItemStyle-HorizontalAlign="Center" ControlStyle-Width="20px">
                                    <ControlStyle Width="20px"></ControlStyle>

                                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                </asp:ImageField>
                            </Columns>
                        </asp:GridView>

                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    </asp:Panel>

</asp:Content>

