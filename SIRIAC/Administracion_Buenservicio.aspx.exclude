<%@ Page Title="" Language="C#" MasterPageFile="~/Perfil_Administrador.master" AutoEventWireup="true" CodeFile="Administracion_Buenservicio.aspx.cs" Inherits="Administracion_Buenservicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function mensaje1() {

            alert('Publicacion Realizada');
        }
    </script>
    <script type="text/javascript">
        function mensaje2() {

            alert('La publicacion no se pudo realizar, por favor intente nuevamente');
        }
    </script>

    <script type="text/javascript">
        function editar(obj) {
            var bt1 = document.getElementById("<%= Refrescar.ClientID %>");
             bt1.click();
             var imageID = document.getElementById('imagen' + obj);
             window.location.href = 'Visualizador_Imagenes_BS.aspx?id=' + obj;

         };
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel CssClass="panel" ID="Panel2" runat="server">

        <div id="tab-container">
            <ul class="tab-menu">
                <li id="html" class="active" onclick="otorgar_permisos()">NOTIFICACIONES</li>

            </ul>
            <div class="clear"></div>
            <div class="tab-top-border"></div>
            <div id="Primer_div">
                <div id="html-tab" class="tab-content active">
                    <h3 class="Titulos">FORMULARIO PARA LA PUBLICACION DE NOTIFICACIONES</h3>
                    <hr />

                    <table class="Tabla_Buen_Servicio">
                        <tr>
                            <th>UBICACION DE LA IMAGEN</th>
                            <th>DESCRIPCION</th>
                            <th>LINK DIRECCIONAMIENTO</th>
                            <th>IMAGEN</th>

                        </tr>
                        <tr>
                            <td>
                                <asp:FileUpload ID="Cargar_Archivo" runat="server" />
                                <asp:Button ID="Cargar" runat="server" Text="Cargar" OnClick="Cargar_Click" />
                            </td>
                            <td>
                                <asp:TextBox ID="Descripcion" runat="server" TextMode="MultiLine" Required="true"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="Link" runat="server" TextMode="MultiLine" Required="true"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Image CssClass="Imagen_Buen_Servicio_Cargue" ID="Imagen_Cargada" runat="server" />
                            </td>

                        </tr>
                    </table>
                    <asp:ScriptManager ID="ScriptManager2" runat="server">
                    </asp:ScriptManager>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <hr />

                            <table class="Tabla_Buen_Servicio">
                                <tr>
                                    <th>ALIADO DESTINO</th>
                                    <th>PERFIL DESTINO</th>
                                    <th>OPERACION DESTINO</th>
                                    <th>ESTADO NOTIFICACION</th>

                                </tr>
                                <tr>
                                    <td>
                                        <asp:DropDownList CssClass="dropdown1" ID="Aliado_Destino" runat="server">
                                            <asp:ListItem>TODOS</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td>
                                        <asp:DropDownList CssClass="dropdown1" ID="Perfil_Destino" runat="server">
                                            <asp:ListItem>TODOS</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td>
                                        <asp:DropDownList CssClass="dropdown1" ID="Operacion_Destino" runat="server">
                                            <asp:ListItem>TODOS</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td>
                                        <asp:DropDownList CssClass="dropdown1" ID="Estado_Notificacion" runat="server">
                                            <asp:ListItem>ACTIVA</asp:ListItem>
                                            <asp:ListItem>INACTIVA</asp:ListItem>
                                            <asp:ListItem>PENDIENTE</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                            </table>
                            <hr />

                            <asp:Button CssClass="button" ID="Guardar" runat="server" Text="Guardar" OnClick="Guardar_Click" />
                            <hr />

                            <h3 class="Titulos">PUBLICACIONES REGISTRADAS</h3>
                            <hr />

                            <asp:Button CssClass="button" ID="Refrescar" runat="server" Text="Refrescar" OnClick="Refrescar_Click" />
                            <asp:GridView CssClass="mGrid" ID="PUBLICACIONES" runat="server" AutoGenerateColumns="False" DataKeyNames="ID_NOTIFICADO" Width="50%" AllowPaging="True" PageSize="5" OnPageIndexChanging="PUBLICACIONES_PageIndexChanging" Visible="false">
                                <Columns>
                                    <asp:TemplateField ShowHeader="False" HeaderText="EDITAR">
                                        <ItemTemplate>
                                            <a href='javascript:editar("<%# Eval("ID_NOTIFICADO") %>");'>
                                                <img class="Imagen_ir" id='imageningreso_<%# Eval("ID_NOTIFICADO") %>' alt="Clic para mostrar u ocultar" src="Estilos/Imagenes/ir.png" width="50px" />
                                            </a>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:BoundField DataField="ID_NOTIFICADO" HeaderText="ID NOTIFICACION" />
                                    <asp:BoundField DataField="FECHA_PUBLICACION" HeaderText="FECHA DE PUBLICACION" />
                                    <asp:BoundField DataField="USUARIO_PUBLICACION" HeaderText="USUARIO DE PUBLICACION" />
                                    <asp:BoundField DataField="DESCRIPCION" HeaderText="DESCRIPCION DE LA IMAGEN" />
                                    <asp:ImageField DataImageUrlField="NOMBRE_IMAGEN" DataImageUrlFormatString="~/Imagenes/Imagenes_BS/{0}" HeaderText="IMAGEN" ItemStyle-HorizontalAlign="Center" ControlStyle-Width="100px">
                                        <ControlStyle Width="100px"></ControlStyle>

                                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                    </asp:ImageField>
                                    <asp:BoundField DataField="ALIADO_DESTINO" HeaderText="ALIADO DESTINO" />
                                    <asp:BoundField DataField="PERFIL_DESTINO" HeaderText="PERFIL DESTINO" />
                                    <asp:BoundField DataField="NOMBRE_LINEA_DESTINO" HeaderText="OPERACION DESTINO" />
                                    <asp:BoundField DataField="ESTADO_NOTIFICACION" HeaderText="ESTADO DE LA NOTIFICACION" />
                                </Columns>

                            </asp:GridView>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
        </div>

    </asp:Panel>
</asp:Content>

