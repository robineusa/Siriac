<%@ Page Title="" Language="C#" MasterPageFile="~/Perfil_Celula.master" AutoEventWireup="true" CodeFile="Depuracion_Traslados.aspx.cs" Inherits="Depuracion_Traslados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script>
        function Aviso1() {
            alert('Este caso ya se encuentra en gestion por otro usuario, por favor seleccionar otro de la lista');
        }
        function Aviso2() {
            alert('Ocurrio un problema al cargar la información, intente nuevamente por favor dando clic en gestionar.');
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Panel CssClass="panel" ID="Panel1" runat="server">
        <div id="tab-container">
            <ul class="tab-menu">
                <li id="html" class="active" onclick="otorgar_permisos()">DEPURACIÓN DE SOLICITUDES</li>
            </ul>
            <div class="clear"></div>
            <div class="tab-top-border"></div>
            <div id="html-tab" class="tab-content active">
                <h3 class="Titulos">FORMULARIO DE GESTIÓN Y DEPURACIÓN SOLICITUDES CREACION DE DIRECCION</h3>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Panel CssClass="panel_informativo" ID="Panel6" runat="server" GroupingText="Interacciones del Caso">
                            <table class="tabla">
                                <tr>
                                    <td>
                                        <div class="Titulo_Usuarios6" style="width:200px;">
                                            <p class="etiquetas5" style="width:200px;">Interacciones del Traslado:</p>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="8">
                                        <asp:GridView CssClass="mGrid2" ID="GVNOTAS" runat="server" AutoGenerateColumns="False" GridLines="None">
                                            <Columns>
                                                <asp:BoundField DataField="ID_TRASLADO" HeaderText="ID TRASLADO" />
                                                <asp:BoundField DataField="CUENTA_CLIENTE" HeaderText="CUENTA CLIENTE" />                                                
                                                <asp:BoundField DataField="USUARIO" HeaderText="USUARIO INTERACCION"/>
                                                <asp:BoundField DataField="NOMBRE_LINEA_NOTA" HeaderText="NOMBRE LINEA INTERACCION"></asp:BoundField>
                                                <asp:BoundField DataField="FECHA_NOTA" HeaderText="FECHA INTERACCION" />
                                                <asp:BoundField DataField="HORA_NOTA" HeaderText="HORA INTERACCION" />
                                                <asp:BoundField DataField="NOTA" HeaderText="OBSERVACIONES"></asp:BoundField>
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
                                        <p class="texto_informativo">Id de Traslado:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Id_Traslado" runat="server" AutoPostBack="true" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Fecha Creación:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Fecha_Creacion" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Hora Creación:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Hora_Creacion" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Usuario Creación:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Usuario_Creacion" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Aliado Creación:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Aliado_Creacion" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Nombre Linea Ingreso:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Nombre_Linea_Ingreso" runat="server" Enabled="false"></asp:TextBox>
                                    </td>

                                </tr>
                               
                            </table>
                        </asp:Panel>
                         <asp:Panel CssClass="panel_informativo" ID="Panel8" runat="server" GroupingText="Información de la Solicitud">
                             <table class="tabla">
                                <tr>
                                    <td>
                                        <p class="texto_informativo">Cuenta del Cliente:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Cuenta_Cliente" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Teléfono Celular:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Telefono_Celular" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Teléfono Fijo:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Telefono_Fijo" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Fecha Actualización:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Fecha_Actualizacion" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Usuario Actualización:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Usuario_Actualizacion" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Hora Actualización:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Hora_Actualizacion" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Estado del Caso:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Estado_Actual_del_Caso" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                </tr>
                                </table>
                         </asp:Panel>
                        <asp:Panel CssClass="panel_informativo" ID="Panel2" runat="server" GroupingText="Información de la Dirección">
                            <table class="tabla">
                                <tr>
                                    <td colspan="7">
                                        <p class="texto_informativo">Dirección a Crear:</p>
                                        <asp:TextBox CssClass="textbox_buscar" ID="Direccion" runat="server" Width="900px" Enabled="false"></asp:TextBox>
                                    </td>
                                    </tr>
                                <tr>
                                    <td>
                                        <p class="texto_informativo">Estrato:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Estrato" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Nodo:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Nodo" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Nombre del Nodo:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Nombre_Nodo" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Código División:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="DIV" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Código Comunidad:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="COM" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Divisional:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Divisional" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                     <td>
                                        <p class="texto_informativo">Área:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Area" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                   
                                    <td>
                                        <p class="texto_informativo">Distrito:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Distrito" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Unidad de Gestión:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Unidad_Gestion" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Estado del Nodo:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Estado_Nodo" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                    <td>
                                        <p class="texto_informativo">Red:</p>
                                        <asp:TextBox CssClass="caja_de_texto" ID="Red" runat="server" Enabled="false"></asp:TextBox>
                                    </td>
                                </tr>
                               
                            </table>
                        </asp:Panel>


                        <asp:Panel CssClass="panel_informativo" ID="Panel5" runat="server" GroupingText="Gestión Célula o Back">
                            <table style="margin-left:5px;">
                                <tr>
                                    <td>
                                     <p class="texto_informativo">Gestión Realizada:</p>
                                        <asp:DropDownList ID="Gestion_Realizada" CssClass="dropdown3" runat="server">
                                            <asp:ListItem>--SELECCIONE--</asp:ListItem>
                                            <asp:ListItem>CIUDAD NO ESTA EN POLITICAS ACTUALES DTH</asp:ListItem>
                                            <asp:ListItem>CUENTA PYMES</asp:ListItem>
                                            <asp:ListItem>DIRECCION ESTA ASOCIADA A UNA MATRIZ</asp:ListItem>
                                            <asp:ListItem>DIRECCION ESTABA CREADA EN EL SISTEMA</asp:ListItem>
                                            <asp:ListItem>DIRECCION FUERA DE COBERTURA</asp:ListItem>
                                            <asp:ListItem>DIRECCION INCOMPLETA</asp:ListItem>
                                            <asp:ListItem>HHPP REQUIERE CREACION DE MATRIZ</asp:ListItem>
                                            <asp:ListItem>MIGRACION</asp:ListItem>
                                            <asp:ListItem>NO COINCIDE COM Y DIV CON LA RED</asp:ListItem>
                                            <asp:ListItem>NO INFORMA SI EL HHPP ES CASA O PISO</asp:ListItem>
                                            <asp:ListItem>SE CREA DIRECCION CORRECTAMENTE</asp:ListItem>
                                            <asp:ListItem>VENTA NUEVA</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                     <td>
                                     <p class="texto_informativo">Estado del Caso:</p>
                                         <asp:DropDownList ID="Estado_del_Caso" CssClass="dropdown1" runat="server">
                                             <asp:ListItem>--SELECCIONE--</asp:ListItem>
                                             <asp:ListItem>EN GESTION</asp:ListItem>
                                             <asp:ListItem>FINALIZADO</asp:ListItem>
                                         </asp:DropDownList>
                                    </td>
                                </tr>
                            </table><br />
                            <table class="tabla">
                                <tr>
                                    <td colspan="6">
                                        <h4 class="Titulo_Informativo2">NOTAS:</h4>
                                        <asp:TextBox CssClass="notas_casos" ID="Observaciones" runat="server" TextMode="MultiLine"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <asp:Button CssClass="button" ID="Guardar_Interaccion" runat="server" Text="Guardar" OnClick="Guardar_Interaccion_Click" />
                        <asp:Label ID="Label3" runat="server" Text="Label" Style="display: none"></asp:Label><hr />
                        <asp:Label ID="Alerta" runat="server" Text="Label" Style="display:none;color :red; font-size:16px;font-family:'Century Gothic';"></asp:Label>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>

    </asp:Panel>


</asp:Content>

