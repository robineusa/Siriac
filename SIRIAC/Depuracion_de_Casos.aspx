<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Perfil_Celula.master" CodeFile="Depuracion_de_Casos.aspx.cs" Inherits="Depuracion_de_Casos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" href="Estilos/Style_Ingreso_Casos.css?1.0.0" />


    <script type="text/javascript">
        function mensaje3() {

            alert('Registro Almacenado');
        }
    </script>
    <script type="text/javascript">
        function mensaje4() {

            alert('El Back no puede dejar casos en estado abierto a su misma linea de trabajo, seleccione otra área a escalar o cambie el estado del caso');
        }
    </script>
    <style type="text/css">
        .auto-style19 {
            height: 39px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label2" runat="server" Text="Label" Style="display: none"></asp:Label>
    <asp:Panel CssClass="panel" ID="Panel1" runat="server">
        <div id="tab-container">
            <ul class="tab-menu">
                <li id="html" class="active" onclick="otorgar_permisos()">DEPURACIÓN DE CASOS</li>
            </ul>
            <div class="clear"></div>
            <div class="tab-top-border"></div>
            <div id="html-tab" class="tab-content active">
                <h3 class="Titulos">FORMULARIO DE GESTIÓN Y DEPURACIÓN DE CASOS</h3>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Panel CssClass="panel_informativo" ID="Panel6" runat="server" GroupingText="Interacciones del Caso">
                            <table class="tabla">
                                <tr>
                                    <td>
                                        <div class="Titulo_Usuarios6">
                                            <p class="etiquetas5">Interacciones del Caso:</p>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="8">
                                        <asp:GridView CssClass="mGrid2" ID="GVNOTAS" runat="server" AutoGenerateColumns="False" GridLines="None">
                                            <Columns>
                                                <asp:BoundField DataField="ID_INGRESO" HeaderText="ID DE INGRESO" />
                                                <asp:BoundField DataField="CUENTA_CLIENTE" HeaderText="CUENTA CLIENTE" />
                                                <asp:BoundField DataField="TICKET" HeaderText="TICKET" />
                                                <asp:BoundField DataField="USUARIO" HeaderText="USUARIO" />
                                                <asp:BoundField DataField="PERFIL" HeaderText="PERFIL" />
                                                <asp:BoundField DataField="NOMBRE_LINEA_NOTA" HeaderText="NOMBRE LINEA NOTA"></asp:BoundField>
                                                <asp:BoundField DataField="FECHA_NOTA" HeaderText="FECHA NOTA" />
                                                <asp:BoundField DataField="HORA_NOTA" HeaderText="HORA NOTA" />
                                                <asp:BoundField DataField="LLAMADA_CLIENTE" HeaderText="LLAMADA CLIENTE" />
                                                <asp:BoundField DataField="NOTA" HeaderText="NOTA"></asp:BoundField>
                                                <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" />
                                            </Columns>
                                        </asp:GridView>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <asp:Panel CssClass="panel_informativo" ID="Panel7" runat="server" GroupingText="Clic para Gestionar">
                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                <ContentTemplate>
                                    <table class="tabla">
                                        <asp:Label ID="Label1" runat="server" Text="NDT" Style="display: none"></asp:Label>
                                        <tr>
                                            <td>
                                                <asp:Button CssClass="button" ID="Gestionar" runat="server" Text="Gestionar" OnClick="Gestionar_Click" />
                                            </td>
                                        </tr>
                                    </table>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </asp:Panel>
                        <asp:Panel CssClass="panel_informativo" ID="Panel3" runat="server" GroupingText="Información de Creación">
                            <table class="tabla">
                                <tr>
                                    <td>
                                        <p class="texto_informativo">Id de ingreso:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Id_Ingreso" runat="server" AutoPostBack="true" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Cuenta del cliente:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Cuenta_Cliente" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Número Ticket RR:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Ticket" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Fecha de apertura:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Fecha_Apertura" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Hora de apertura:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Hora_Apertura" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Usuario de apertura:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Usuario_Apertura" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Aliado de apertura:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Aliado_Apertura" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <p class="texto_informativo">Fecha actualización:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Fecha_Ult_Actualizacion" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Usuario actualización:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Usuario_Ult_Actualizacion" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Hora actualización:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Hora_Actualizacion" runat="server"></asp:TextBox>
                                    </td>

                                </tr>
                            </table>
                        </asp:Panel>
                        <asp:Panel CssClass="panel_informativo" ID="Panel2" runat="server" GroupingText="Información del Cliente">
                            <table class="tabla">
                                <tr>
                                    <td>
                                        <p class="texto_informativo">Nombre del cliente:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Nombre_Cliente" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Apellido del cliente:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Apellido_Cliente" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Documento de identidad:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Doc_Identidad" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Teléfono telmex:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Telefono_Telmex" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Teléfono 1:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Telefono_1" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Teléfono 2:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Telefono_2" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Teléfono 3:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Telefono_3" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>

                                    <td class="auto-style19">
                                        <p class="texto_informativo">Teléfono personal:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Telefono_Personal" runat="server"></asp:TextBox>
                                    </td>
                                    <td class="auto-style19">
                                        <p class="texto_informativo">Dirección de instalación:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Dir_Instalacion" runat="server"></asp:TextBox>
                                    </td>
                                    <td class="auto-style19">
                                        <p class="texto_informativo">Correspondencia:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Dir_Correspondencia" runat="server"></asp:TextBox>
                                    </td>
                                    <td class="auto-style19">
                                        <p class="texto_informativo">Correo electrónico:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Correo_Electronico" runat="server"></asp:TextBox>
                                    </td>
                                    <td class="auto-style19">
                                        <p class="texto_informativo">Red:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Red" runat="server"></asp:TextBox>
                                    </td>
                                    <td class="auto-style19">
                                        <p class="texto_informativo">División:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Division" runat="server"></asp:TextBox>
                                    </td>
                                    <td class="auto-style19">
                                        <p class="texto_informativo">Área:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Area" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <p class="texto_informativo">Zona:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Zona" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Distrito:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Distrito" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Nombre comunidad:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Nombre_Comunidad" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Estrato:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Estrato" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Tipo Cliente:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Tipo_Cliente" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Descripción:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Descripcion" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>

                        <asp:Panel CssClass="panel_informativo" ID="Panel4" runat="server" GroupingText="Árbol de Escalamiento">
                            <table class="tabla">
                                <tr>
                                    <td>
                                        <p class="texto_informativo">Macroproceso:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Macroproceso" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Proceso:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Proceso" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Sub proceso:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Subproceso" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Marcación:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Marcacion" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Servicios afectados:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Servicios" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                            <table class="tabla">
                                <tr>
                                    <td>
                                        <div class="Titulo_Usuarios6">
                                            <p class="etiquetas5">Posible causa:</p>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="6">
                                        <div class="Que_Hacer">
                                            <asp:Label ID="Posible_Causa" runat="server" Text=""></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <div class="Titulo_Usuarios6">
                                            <p class="etiquetas5">¿Que hacer?:</p>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="6">
                                        <div class="Que_Hacer">
                                            <asp:Label ID="Que_Hacer" runat="server" Text=""></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="6">
                                        <div class="Titulo_Usuarios6">
                                            <p class="etiquetas5">Codigos de cierre:</p>
                                        </div>
                                        <div class="Que_Hacer">
                                            <asp:Label ID="Codigos_Cierre" runat="server" Text=""></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>

                        <asp:Panel CssClass="panel_informativo" ID="Panel5" runat="server" GroupingText="Gestión Célula o Back">

                            <table class="tabla">
                                <tr>
                                    <td colspan="6"></td>
                                </tr>
                                <tr>
                                    <td>
                                        <h4 class="Titulo_Informativo2">ESTADO CASO:</h4>
                                        <asp:DropDownList CssClass="dropdown1" ID="Estado_Caso" runat="server" AutoPostBack="True" OnSelectedIndexChanged="Estado_Caso_SelectedIndexChanged">
                                        </asp:DropDownList>

                                    </td>
                                    <td>
                                        <h4 class="Titulo_Informativo2">ÁREA A ESCALAR:</h4>
                                        <asp:DropDownList CssClass="dropdown1" ID="Area_Escalar" runat="server"></asp:DropDownList>

                                    </td>

                                    <td>
                                        <h4 class="Titulo_Informativo2">¿APLICA RECHAZO?:</h4>
                                        <asp:DropDownList CssClass="dropdown1" ID="Rechazo" runat="server" AutoPostBack="true" OnSelectedIndexChanged="Rechazo_SelectedIndexChanged">
                                            <asp:ListItem>NO</asp:ListItem>
                                            <asp:ListItem>SI</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td colspan="4">
                                        <h4 class="Titulo_Informativo2">¿PORQUE LO RECHAZA?:</h4>
                                        <asp:TextBox CssClass="notas_casos3" ID="Motivo_Rechazo" runat="server" TextMode="MultiLine" Enabled="false"></asp:TextBox>
                                    </td>

                                </tr>
                            </table>

                            <table class="tabla">
                                <tr>
                                    <td colspan="6">
                                        <h4 class="Titulo_Informativo2">NOTAS:</h4>
                                        <asp:TextBox CssClass="notas_casos" ID="Notas" runat="server" TextMode="MultiLine" Required="true"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <asp:Button CssClass="button" ID="Button3" runat="server" OnClick="Button3_Click" Text="Guardar" Enabled="false" />
                        <asp:Label ID="Label3" runat="server" Text="Label" Style="display: none"></asp:Label>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>

    </asp:Panel>
</asp:Content>
