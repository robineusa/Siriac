<%@ Page Title="" Language="C#" MasterPageFile="~/Perfil_Asesor.master" AutoEventWireup="true" CodeFile="Formulario_Blending.aspx.cs" Inherits="Formulario_Blendign" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <link href="Estilos/Style_Perfil_Asesor.css?1.0.4" rel="stylesheet" />
    <script src="Js/jquery.datetimepicker.full.js"></script>
    <link href="Estilos/jquery.datetimepicker.css?1.0.2" rel="stylesheet" />

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
            document.getElementById('datetimepicker').value = "";
            document.getElementById("<%= LI_Fecha_Agenda.ClientID %>").value = "";
        }
    </script>
    <script type="text/javascript">
        function mensaje2() {

            alert('Registro NO Almacenado');
        }
    </script>
    <script type="text/javascript">
        function mensaje3() {

            alert('Registro Actualizado');
            document.getElementById('datetimepicker').value = "";
            document.getElementById("<%= LI_Fecha_Agenda.ClientID %>").value = "";

        }
    </script>
    <script type="text/javascript">
        function mensaje4() {

            alert('Registro NO Actualizado');
        }
    </script>
    <script type="text/javascript">
        function mensaje5() {

            alert('¡El número de cuenta ingresado no existe!');
        }
    </script>
    <script type="text/javascript">
        function mensaje6() {

            alert('¡Debe ingresar un número de cuenta!');
        }
    </script>
    <script type="text/javascript">
        function mensaje7() {

            alert('¡Debe seleccionar una fecha de agenda!');
        }
    </script>
    <script type="text/javascript">
        function mensaje8() {


        }
    </script>
    <script type="text/javascript">
        function mensaje9() {
            alert('¡Debe seleccionar un Servicio!');
        }
    </script>
    <script type="text/javascript">
        function mensaje10() {
            alert('¡Debe Seleccionar una opción en Inscripcion del Convenio Electronico!');
        }
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:Panel CssClass="panel" ID="Panel1" runat="server">
        <asp:UpdatePanel ID="UpdatePanel9" runat="server">
            <ContentTemplate>
                <div id="tab-container">
                    <ul class="tab-menu">
                        <li id="html" class="active" onclick="otorgar_permisos()">GESTION BLENDING</li>

                    </ul>
                    <div class="clear"></div>
                    <div class="tab-top-border"></div>
                    <div id="html-tab" class="tab-content active">

                        <h3 class="Titulos">FORMULARIO DE GESTION BLENDING</h3>

                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <asp:Panel CssClass="panel_informativo" ID="Cabezote" runat="server" GroupingText="Seleccione la gestión a realizar">
                                    <table class="tabla">
                                        <tr>
                                            <td>
                                                <div id="Activacion_div" class="referencia" runat="server"><a href="#Activacion">Activación</a></div>
                                            </td>
                                            <td>
                                                <div id="Convenio_div" class="referencia" runat="server"><a href="#Convenio_Electronico">Convenio Electrónico</a></div>
                                            </td>
                                            <td>
                                                <div id="Detractores_div" class="referencia" runat="server"><a href="#Detractores">Detractores</a></div>
                                            </td>
                                            <td>
                                                <div id="Reincidencia_div" class="referencia" runat="server"><a href="#Reincidencia">Reincidencia</a></div>
                                            </td>
                                            <td>
                                                <div id="Ventas_div" class="referencia" runat="server"><a href="#Ventas">Ventas</a></div>
                                            </td>
                                            <td>
                                                <div id="Logistica_div" class="referencia" runat="server"><a href="#Logistica_Inversa">Logística Inversa</a></div>
                                            </td>

                                        </tr>
                                        <tr>
                                            <td>
                                                <div id="Fraudes_div" class="referencia" runat="server"><a href="#Fraudes">Fraudes</a></div>
                                            </td>
                                            <td>
                                                <div id="Claro_Video_div" class="referencia" runat="server"><a href="#Claro_Video">Claro Video</a></div>
                                            </td>
                                            <td>
                                                <div id="Docsis_Overlap_div" class="referencia" runat="server"><a href="#Docsis_Overlap">Docsis y Overlap</a></div>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </ContentTemplate>

                        </asp:UpdatePanel>
                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </asp:Panel>

    <div class="modal-wrapper" id="Activacion">
        <div class="Activacion-contenedor">
            <a class="Activacion-cerrar" href="#">X</a>
            <h2>FORMULARIO DE ACTIVACIÓN</h2>
            <hr />
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <p class="etiquetas">Este formulario se encuentra en construcción:</p>

                    <hr />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
    <!-- NUEVO SCRIP DE DISEÑO-->
    <div class="modal-wrapper" id="Convenio_Electronico">
        <div class="Convenio_Electronico-contenedor">
            <a class="Convenio_Electronico-cerrar" href="#">X</a>
            <h2>FORMULARIO CONVENIO ELECTRÓNICO</h2>
            <hr />
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                        <ContentTemplate>
                            <asp:Panel CssClass="panel_informativo" ID="Panel2" runat="server" GroupingText="Datos del Cliente">
                                <table class="tabla">
                                    <tr>
                                        <td>
                                            <p class="etiquetas">Cuenta del Cliente:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="CE_Cuenta_Cliente" runat="server" OnTextChanged="CE_Cuenta_Cliente_TextChanged" AutoPostBack="true" onkeypress="return justNumbers(event);" Placeholder="Ingrese la Cuenta"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Nombre Cliente:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="CE_Nombre_Cliente" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Apellido Cliente:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="CE_Apellido_Cliente" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Dir. Instalación:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="CE_Direccion_Instalacion" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Dir. Correspondencia:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="CD_Direccion_Correspondencia" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Teléfono Telmex:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="CE_Telefono_Telmex" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Teléfono 1:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="CE_Telefono_1" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>

                                        <td>
                                            <p class="etiquetas">Teléfono 2:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="CE_Telefono_2" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Teléfono 3:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="CE_Telefono_3" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Móvil Actual:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="CE_Móvil_Actual" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Correo Actual:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="CE_Correo_Electronico_Actual" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <hr />
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                            <asp:Panel CssClass="panel_informativo" ID="Panel3" runat="server" GroupingText="Árbol de Tipificación">
                                <table class="tabla">
                                    <tr>
                                        <td>
                                            <p class="etiquetas">Tipo de Contacto:</p>
                                            <asp:DropDownList CssClass="dropdown2" ID="CE_Tipo_de_Contacto" runat="server" OnSelectedIndexChanged="CE_Tipo_de_Contacto_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Cierre:</p>
                                            <asp:DropDownList CssClass="dropdown3" ID="CE_Cierre" runat="server" OnSelectedIndexChanged="CE_Cierre_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Razón:</p>
                                            <asp:DropDownList CssClass="dropdown3" ID="CE_Razon" runat="server"></asp:DropDownList>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                            <hr />
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <asp:Panel CssClass="panel_informativo" ID="Panel4" runat="server" GroupingText="Datos Actualizables">
                        <table class="tabla">
                            <tr>
                                <td>
                                    <p class="etiquetas">Correo Nuevo:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="CE_Correo_Nuevo" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Móvil Nuevo:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="CE_Movil_Nuevo" runat="server" onkeypress="return justNumbers(event);"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Dirección C. Nueva:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="CE_Correspondencia_Nueva" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>

                    <asp:Button CssClass="button" ID="CE_Guardar" runat="server" Text="Guardar" OnClick="CE_Guardar_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
    <!-- NUEVO SCRIP DE DISEÑO-->
    <div class="modal-wrapper" id="Detractores">
        <div class="Detractores-contenedor">
            <a class="Detractores-cerrar" href="#">X</a>
            <h2>FORMULARIO DETRACTORES</h2>
            <hr />
            <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                <ContentTemplate>
                    <p class="etiquetas">Este formulario se encuentra en construcción:</p>
                    <hr />
                    <div class="referencia"><a href="#Convenio_Electronico">Convenio Electrónico</a></div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
    <!-- NUEVO SCRIP DE DISEÑO-->
    <div class="modal-wrapper" id="Docsis_Overlap">
        <div class="Docsis_Overlap-contenedor">
            <a class="Docsis_Overlap-cerrar" href="#">X</a>
            <h2>FORMULARIO OUTBOUND DOCSIS Y OVERLAP</h2>
            <hr />
            <asp:Panel CssClass="panel_informativo" ID="Panel22" runat="server" GroupingText="Datos del Cliente">
                <asp:UpdatePanel ID="UpdatePanel20" runat="server">
                    <ContentTemplate>
                        <table class="tabla">
                            <tr>
                                <td>
                                    <p class="etiquetas">Cuenta del Cliente:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="D_Cuenta_Cliente" runat="server" Placeholder="Ingrese la Cuenta" AutoPostBack="true" OnTextChanged="D_Cuenta_Cliente_TextChanged"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Nombre del Cliente:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="D_Nombre_Cliente" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Apellido del Cliente:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="D_Apellido_Cliente" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Dirección:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="D_Direccion" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Dir. Correspondencia:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="D_Direccion_Corres" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Teléfono 1:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="D_Telefono_1" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Teléfono 2:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="D_Telefono_2" runat="server"></asp:TextBox>
                                </td>
                                
                            </tr>
                            <tr>
                                <td>
                                    <p class="etiquetas">Celular 1:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="D_Celular_1" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Celular 2:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="D_Celular_2" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Teléfono Telmex:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="D_Telefono_Telmex" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Ciudad:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="D_Ciudad" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Correo Actual:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="D_Correo_Actual" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Estrato:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="D_Estrato" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Tipo de Cliente:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="D_Tipo_Cliente" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <p class="etiquetas">Paquete Actual:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="D_Paquete_Actual" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Móvil Postpago:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="D_Movil_Pospago" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                        <asp:Label ID="D_Operacion" runat="server" Visible="false"></asp:Label>
                        <asp:Label ID="D_Base" runat="server" Visible="false"></asp:Label>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:Panel>
            <hr />
            <asp:Panel CssClass="panel_informativo" ID="Panel23" runat="server" GroupingText="Árbol de Tipificación">
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <table class="tabla">
                            <tr>
                                <td>
                                    <p class="etiquetas">Tipo de Contacto:</p>
                                    <asp:DropDownList CssClass="dropdown2" ID="D_Tipo_Contacto" runat="server" OnSelectedIndexChanged="D_Tipo_Contacto_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                                </td>
                                <td>
                                    <p class="etiquetas">Cierre:</p>
                                    <asp:DropDownList CssClass="dropdown4" ID="D_Cierre" runat="server" OnSelectedIndexChanged="D_Cierre_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                                </td>
                                <td>
                                    <p class="etiquetas">Razón:</p>
                                    <asp:DropDownList CssClass="dropdown3" ID="D_Razon" runat="server"></asp:DropDownList>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:Panel>
            <hr />
            <asp:Panel CssClass="panel_informativo" ID="Panel24" runat="server" GroupingText="Datos Actualizables">
                <asp:Panel ID="D_Tabla_Fecha_Seguimiento" runat="server" Style="display: none">
                    <table class="tabla">
                        <tr>
                            <td>
                                <p class="etiquetas">Seleccione fecha y hora del seguimiento:</p>
                                <%--<input type="Text" class="caja_de_texto" id="D_Fecha_Seguimiento" />--%>
                                <asp:TextBox runat="server" CssClass="caja_de_texto" ID="D_Fecha_Seguimiento" Placeholder="Select Date"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
                <script type="text/javascript">
                    $('#<%=D_Fecha_Seguimiento.ClientID%>').datetimepicker({
                        minDate: '0',
                        dateFormat: 'yy.mm.dd 00:00',
                        timepicker: true,
                        //step: 1
                    });

                    function Mostra_Div() {
                        document.getElementById("<%=D_Tabla_Fecha_Seguimiento.ClientID%>").style.display = 'block';
                    }
                    function No_Mostra_Div() {
                        document.getElementById("<%=D_Tabla_Fecha_Seguimiento.ClientID%>").style.display = 'none';
                    }
                    function Casos_Seguimiento() {
                        document.getElementById("hrg").style.display = 'block';
                        document.getElementById("<%=Panel25.ClientID%>").style.display = 'block';
                    }
                    function No_Casos_Seguimiento() {
                        document.getElementById("hrg").style.display = 'none';
                        document.getElementById("<%=Panel25.ClientID%>").style.display = 'none';
                    }
                </script>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <table class="tabla">
                            <tr>
                                <td colspan="7">
                                    <p class="etiquetas">Observaciones:</p>
                                    <asp:TextBox CssClass="notas_casos" ID="D_Observaciones" runat="server" autocomplete="off"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:Panel>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:Button CssClass="button" ID="D_Guardar" runat="server" Text="Guardar" OnClick="D_Guardar_Click"/>
                </ContentTemplate>
            </asp:UpdatePanel>
            <hr id="hrg" style="display:none"/>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:Panel CssClass="panel_informativo" ID="Panel25" runat="server" GroupingText="Historico de Casos" style="display:none" >
                        <asp:GridView CssClass="mGrid" ID="GV_Seguimientos" runat="server" AutoGenerateColumns="False" Style="max-width: 100%; margin-left: 10px; margin-top: 10px;" Autopostback="true" >
                            <Columns>
                                <asp:BoundField DataField="FECHA_GESTION" HeaderText="FECHA DE GESTION" />
                                <asp:BoundField DataField="NOMBRE_USUARIO_GESTION" HeaderText="NOMBRE ASESOR" />
                                <asp:BoundField DataField="ALIADO_GESTION" HeaderText="ALIADO" />
                                <asp:BoundField DataField="TIPO_DE_CONTACTO" HeaderText="TIPO DE CONTACTO" />
                                <asp:BoundField DataField="CIERRE" HeaderText="CIERRE" />
                                <asp:BoundField DataField="RAZON" HeaderText="RAZON" />
                                <asp:BoundField DataField="OBSERVACIONES" HeaderText="OBSERVACIONES" />
                                 <asp:BoundField DataField="FECHA_SEGUIMIENTO" HeaderText="FECHA DE SEGUIMIENTO" />
                            </Columns>
                        </asp:GridView>
                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>

    <!-- NUEVO SCRIP DE DISEÑO-->
    <div class="modal-wrapper" id="Reincidencia">
        <div class="Reincidencia-contenedor">
            <a class="Reincidencia-cerrar" href="#">X</a>
            <h2>FORMULARIO REINCIDENCIA</h2>
            <hr />
            <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                <ContentTemplate>
                    <asp:Panel CssClass="panel_informativo" ID="Panel18" runat="server" GroupingText="Datos del Cliente">
                        <!---- INICIO--->
                        <table class="tabla">
                            <tr>
                                <td>
                                    <p class="etiquetas">Cuenta del Cliente:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="R_Cuenta_Cliente" runat="server" OnTextChanged="R_Cuenta_Cliente_TextChanged" AutoPostBack="true" Placeholder="Ingrese la Cuenta"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Nombre Cliente:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="R_Nombre_Cliente" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Apellido Cliente:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="R_Apellido" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Dir. Instalación:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="R_Direccion_Instalacion" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Dir. Correspondencia:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="R_Direccion_Corres" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Teléfono 1:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="R_Telefono_1" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Teléfono 2:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="R_Telefono_2" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>

                                <td>
                                    <p class="etiquetas">Teléfono 3:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="R_Telefono_3" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Móvil 1:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="R_celular_1" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Móvil 2:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="R_celular_2" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Telefono Telmex:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="R_Telefono_Telmex" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Nombre Comunidad:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="R_Ciudad" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Correo Actual:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="R_Correo" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Estrato:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="R_Estrato" runat="server" Enabled="false"></asp:TextBox>
                                </td>

                            </tr>
                            <tr>

                                <td>
                                    <p class="etiquetas">Tipo de Cliente:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="R_Tipo_Cliente" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Paquete Actual:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="R_Paquete_Actual" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Móvil Postpago:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="R_Movil_Postpago" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Motivo Reincidencia:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="R_Motivo_Reincidencia" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                    <hr />
                </ContentTemplate>
            </asp:UpdatePanel>
            <!--- FIN       --->
            <!--Inicio Árbol de tipificación --->
            <asp:UpdatePanel ID="UpdatePanel18" runat="server">
                <ContentTemplate>
                    <asp:Panel CssClass="panel_informativo" ID="Panel21" runat="server" GroupingText="Ofrecimientos">
                        <table class="tabla">
                            <tr>
                                <td colspan="6">
                                    <div class="Titulo_Ofrecimientos">
                                        <p class="etiquetas_Ofrecimiento">Primer Ofrecimiento:</p>
                                    </div>
                                    <asp:TextBox CssClass="ofrecimientos" ID="R_T_Ofrecimiento_1" runat="server" TextMode="MultiLine" Enabled="false"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                        <table class="tabla">
                            <tr>
                                <td colspan="6">
                                    <div class="Titulo_Ofrecimientos">
                                        <p class="etiquetas_Ofrecimiento">Segundo Ofrecimiento:</p>
                                    </div>
                                    <asp:TextBox CssClass="ofrecimientos" ID="R_T_Ofrecimiento_2" runat="server" TextMode="MultiLine" Enabled="false"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                        <table class="tabla">
                            <tr>
                                <td colspan="6">
                                    <div class="Titulo_Ofrecimientos">
                                        <p class="etiquetas_Ofrecimiento">Tercer Ofrecimiento:</p>
                                    </div>
                                    <asp:TextBox CssClass="ofrecimientos" ID="R_T_Ofrecimiento_3" runat="server" TextMode="MultiLine" Enabled="false"></asp:TextBox>
                                </td>
                            </tr>
                        </table>

                    </asp:Panel>
                    <hr />
                    <asp:Panel CssClass="panel_informativo" ID="Panel19" runat="server" GroupingText="Árbol de Tipificación">
                        <table class="tabla">
                            <tr>
                                <td>
                                    <p class="etiquetas">Tipo de Contacto:</p>
                                    <asp:DropDownList CssClass="dropdown2" ID="R_Tipo_Contacto" runat="server" OnSelectedIndexChanged="R_Tipo_Contacto_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                                </td>
                                <td>
                                    <p class="etiquetas">Tipo de Gestión:</p>
                                    <asp:DropDownList CssClass="dropdown2" ID="R_Tipo_Gestion" runat="server" AutoPostBack="true" OnSelectedIndexChanged="R_Tipo_Gestion_SelectedIndexChanged"></asp:DropDownList>
                                </td>
                                <td>
                                    <p class="etiquetas">Cierre:</p>
                                    <asp:DropDownList CssClass="dropdown4" ID="R_Cierre" runat="server" AutoPostBack="true" OnSelectedIndexChanged="R_Tipo_Cierre_SelectedIndexChanged"></asp:DropDownList>
                                </td>
                                <td>
                                    <p class="etiquetas">Razón:</p>
                                    <asp:DropDownList CssClass="dropdown3" ID="R_Razon" runat="server"></asp:DropDownList>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                    <hr />
                </ContentTemplate>
            </asp:UpdatePanel>
            <!--FIN Árbol de tipificación --->
            <asp:UpdatePanel ID="UpdatePanel19" runat="server">
                <ContentTemplate>
                    <asp:Panel CssClass="panel_informativo" ID="Panel20" runat="server" GroupingText="Datos Actualizables">
                        <table class="tabla">
                            <tr>
                                <td colspan="3">
                                    <div class="Titulo_Usuarios5" style="width: 370PX;">
                                        <p class="etiquetas5" style="width: 400PX;">¿Cliente Acepta Inscripcion del Convenio Electrónico?</p>
                                    </div>
                                    <div class="soluciones" style="width: 200PX;">
                                        <asp:CheckBox CssClass="etiquetas" ID="CheckBox6" runat="server" />
                                        <asp:Label ID="Label18" AssociatedControlID="CheckBox6" runat="server" Text="Si" CssClass="CheckBoxLabel" Style="color: black;"></asp:Label>
                                    </div>
                                    <div class="soluciones" style="width: 200PX;">
                                        <asp:CheckBox CssClass="etiquetas" ID="CheckBox9" runat="server" />
                                        <asp:Label ID="Label1" AssociatedControlID="CheckBox9" runat="server" Text="No" CssClass="CheckBoxLabel" Style="color: black;"></asp:Label>
                                    </div>
                                </td>
                            </tr>
                        </table>
                        <table class="tabla">
                            <tr>
                                <td colspan="4">
                                    <p class="etiquetas">Observaciones:</p>
                                    <asp:TextBox CssClass="notas_casos" ID="R_Observaciones" runat="server" autocomplete="off"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                    <hr />
                    <asp:Button CssClass="button" ID="R_Guardar" runat="server" Text="Guardar" OnClick="R_Guardar_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>

    <!-- NUEVO SCRIP DE DISEÑO-->
    <div class="modal-wrapper" id="Ventas">
        <div class="Ventas-contenedor">
            <a class="Ventas-cerrar" href="#">X</a>
            <h2>FORMULARIO VENTAS</h2>
            <hr />
            <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                <ContentTemplate>
                    <asp:UpdatePanel ID="UpdatePanel13" runat="server">
                        <ContentTemplate>
                            <asp:Panel CssClass="panel_informativo" ID="Panel12" runat="server" GroupingText="Datos del Cliente">
                                <table class="tabla">
                                    <tr>
                                        <td>
                                            <p class="etiquetas">Cuenta del Cliente:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="V_Cuenta_Cliente" runat="server" OnTextChanged="V_Cuenta_Cliente_TextChanged" AutoPostBack="true" onkeypress="return justNumbers(event);" Placeholder="Ingrese la Cuenta"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Nombre Cliente:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="V_Nombre_Cliente" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Apellido Cliente:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="V_Apellido_Cliente" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Dir. Instalación:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="V_Direccion_de_Instalacion" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Dir. Correspondencia:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="V_Direccion_de_Correspondencia" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Teléfono 1:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="V_Telefono_1" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Teléfono 2:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="V_Telefono_2" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>

                                        <td>
                                            <p class="etiquetas">Teléfono 3:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="V_Telefono_3" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Móvil 1:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="V_Movil_1" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Móvil 2:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="V_Movil_2" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Nombre Comunidad:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="V_Nombre_Comunidad" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Correo Actual:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="V_Correo_Electronico" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Estrato:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="V_Estrato" runat="server" Enabled="false"></asp:TextBox>
                                        </td>

                                        <td>
                                            <p class="etiquetas">Tipo de Cliente:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="V_Tipo_Cliente" runat="server" Enabled="false"></asp:TextBox>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td>
                                            <p class="etiquetas">Paquete Actual:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="V_Paquete_Actual" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Móvil Postpago:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="V_Movil_Portpago" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <hr />
                    <asp:UpdatePanel ID="UpdatePanel14" runat="server">
                        <ContentTemplate>
                            <asp:Panel CssClass="panel_informativo" ID="Panel13" runat="server" GroupingText="Árbol de Tipificación">
                                <table class="tabla">
                                    <tr>
                                        <td>
                                            <p class="etiquetas">Tipo de Contacto:</p>
                                            <asp:DropDownList CssClass="dropdown2" ID="V_Tipo_de_Contacto" runat="server" OnSelectedIndexChanged="V_Tipo_de_Contacto_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Cierre:</p>
                                            <asp:DropDownList CssClass="dropdown3" ID="V_Cierre" runat="server" OnSelectedIndexChanged="V_Cierre_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Razón:</p>
                                            <asp:DropDownList CssClass="dropdown3" ID="V_Razon" runat="server"></asp:DropDownList>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                            <hr />
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <asp:Panel CssClass="panel_informativo" ID="Panel14" runat="server" GroupingText="Datos Actualizables">
                        <table class="tabla">
                            <tr>
                                <td colspan="2">
                                    <div class="Titulo_Usuarios5">
                                        <p class="etiquetas5">Servicio Ofrecido:</p>
                                    </div>
                                    <div class="soluciones">
                                        <asp:CheckBox CssClass="etiquetas" ID="CheckBox1" runat="server" Text="Siembra HD" GroupName="Servicio" />
                                    </div>
                                    <div class="soluciones">
                                        <asp:CheckBox CssClass="etiquetas" ID="CheckBox2" runat="server" Text="Upgrade" GroupName="Servicio" />
                                    </div>
                                    <div class="soluciones">
                                        <asp:CheckBox CssClass="etiquetas" ID="CheckBox3" runat="server" Text="Siembra MTA" GroupName="Servicio" />
                                    </div>
                                </td>
                            </tr>
                        </table>
                        <table class="tabla">
                            <tr>
                                <td colspan="4">
                                    <p class="etiquetas">Observaciones:</p>
                                    <asp:TextBox CssClass="notas_casos" ID="V_Observaciones" runat="server" autocomplete="off"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>

                    <asp:Button CssClass="button" ID="V_Guardar" runat="server" Text="Guardar" OnClick="V_Guardar_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
    <!-- NUEVO SCRIP DE DISEÑO-->
    <div class="modal-wrapper" id="Logistica_Inversa">
        <div class="Logistica_Inversa-contenedor">
            <a class="Logistica_Inversa-cerrar" href="#">X</a>
            <h2>FORMULARIO LOGÍSTICA INVERSA</h2>
            <hr />

            <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                <ContentTemplate>
                    <asp:Panel CssClass="panel_informativo" ID="Panel5" runat="server" GroupingText="Datos del Cliente">
                        <table class="tabla">
                            <tr>
                                <td>
                                    <p class="etiquetas">Cuenta del Cliente:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="LI_Cuenta_Cliente" runat="server" OnTextChanged="LI_Cuenta_Cliente_TextChanged" AutoPostBack="true" onkeypress="return justNumbers(event);" Placeholder="Ingrese la Cuenta"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Nombre Cliente:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="LI_Nombre_Cliente" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Apellido Cliente:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="LI_Apellido_Cliente" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Dir. Instalación:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="LI_Dir_Instalacion" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Dir. Correspondencia:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="LI_Dir_Correspondencia" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Teléfono Telmex:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="LI_Telefono_Telmex" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Teléfono 1:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="LI_Telefono_1" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>

                                <td>
                                    <p class="etiquetas">Teléfono 2:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="LI_Telefono_2" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Teléfono 3:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="LI_Telefono_3" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Móvil Potpago:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="LI_Movil_Postpago" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>
            <hr />
            <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                <ContentTemplate>
                    <asp:Panel CssClass="panel_informativo" ID="Panel6" runat="server" GroupingText="Árbol de Tipificación">
                        <table class="tabla">
                            <tr>
                                <td>
                                    <p class="etiquetas">Tipo de Contacto:</p>
                                    <asp:DropDownList CssClass="dropdown2" ID="LI_Tipo_Contacto" runat="server" OnSelectedIndexChanged="LI_Tipo_Contacto_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                                </td>
                                <td>
                                    <p class="etiquetas">Cierre:</p>
                                    <asp:DropDownList CssClass="dropdown3" ID="LI_Cierre" runat="server" OnSelectedIndexChanged="LI_Cierre_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                                </td>
                                <td>
                                    <p class="etiquetas">Razón:</p>
                                    <asp:DropDownList CssClass="dropdown3" ID="LI_Razon" runat="server"></asp:DropDownList>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                    <hr />
                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:Panel CssClass="panel_informativo" ID="Panel7" runat="server" GroupingText="Datos Actualizables">
                <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                    <ContentTemplate>
                        <table class="tabla">
                            <tr>
                                <td>
                                    <p class="etiquetas">Persona de Contacto:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="LI_Persona_Contacto" runat="server" autocomplete="off"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Telefono de Contacto:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="LI_Telefono_Contacto" runat="server" Text="0" autocomplete="off" MaxLength="10"></asp:TextBox>
                                </td>

                                <td>
                                    <p class="etiquetas">Dirección Alterna:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="LI_Direccion_Alterna" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Departamento de Entrega:</p>
                                    <asp:DropDownList CssClass="dropdown2" ID="LI_Departamento" runat="server" OnSelectedIndexChanged="LI_Departamento_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                                </td>
                                <td>
                                    <p class="etiquetas">Ciudad de Entrega:</p>
                                    <asp:DropDownList CssClass="dropdown2" ID="LI_Ciudad_de_Entrega" runat="server"></asp:DropDownList>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <table class="tabla">
                    <tr>
                        <td>
                            <p class="etiquetas">Fecha de Agenda:</p>
                            <asp:TextBox ID="LI_Fecha_Agenda" runat="server" Text="" Style="display: none"></asp:TextBox>
                            <input class="caja_de_texto" type="text" value="" id="datetimepicker" onchange="return Traer_Fecha()" autocomplete="off" placeholder="Select date" onfocus="this.blur()" />
                            <!--<script>

                                $('#datetimepicker').datetimepicker({
                                    dayOfWeekStart: 1,
                                    lang: 'es',
                                    dateformat: 'Y-m-d 00:00',
                                    disabledWeekDays: [1, 2, 4, 5, 0],
                                    disabledDates: ['2016/05/04']
                                });

                                $('.some_class').datetimepicker();

                            </script>-->
                            <script>
                                ////lenguaje
                                //$.datetimepicker.setLocale('es');
                                ////bloquea dias de la semana y dias adicionales
                                //var dateToDisable = new Date();
                                //dateToDisable.setDate(dateToDisable.getDate());
                                //var dateToDisable2 = new Date();
                                //dateToDisable2.setDate(dateToDisable2.getDate() + 1);
                                //$('#datetimepicker').datetimepicker({
                                //    disabledWeekDays: [0, 1, 2, 4, 5, 7],
                                //    beforeShowDay: function (date) {
                                //        if (date.getMonth() == dateToDisable.getMonth() && (date.getDate() == dateToDisable.getDate() || date.getDate() == dateToDisable2.getDate())) {
                                //            return [false, ""]
                                //        }
                                //        return [true, ""];
                                //    },
                                //    allowTimes: [
                                //           '07:00',
                                //           '08:00',
                                //           '09:00',
                                //           '10:00',
                                //           '11:00',
                                //           '12:00',
                                //           '13:00',
                                //           '14:00',
                                //           '15:00',
                                //           '16:00',
                                //           '17:00']
                                //});


                                $.datetimepicker.setLocale('es');

                                var dateToDisable;
                                var dateToDisable2;
                                var dateToDisable3;
                                var dateToDisable4;

                                function fechas() {
                                    dateToDisable = new Date();
                                    dateToDisable2 = new Date();
                                    dateToDisable3 = new Date();
                                    dateToDisable4 = new Date();

                                    dateToDisable.setDate(dateToDisable.getDate());
                                    dateToDisable2.setDate(dateToDisable2.getDate() + 1);

                                    if (dateToDisable3.getDay() == 4 || dateToDisable3.getDay() == 1) {
                                        dateToDisable.setDate(dateToDisable3.getDate() + 2);
                                    }
                                    else if (dateToDisable3.getDay() == 0 || dateToDisable3.getDay() == 3) {
                                        dateToDisable.setDate(dateToDisable3.getDate() + 3);
                                    }
                                    else if (dateToDisable3.getDay() == 2 || dateToDisable3.getDay() == 6) {
                                        dateToDisable.setDate(dateToDisable3.getDate() + 4);
                                    }
                                    else if (dateToDisable3.getDay() == 5 || dateToDisable3.getDay() == 1) {
                                        dateToDisable.setDate(dateToDisable3.getDate() + 5);
                                        dateToDisable.setDate(dateToDisable4.getDate() + 5);
                                    }
                                }

                                fechas();
                                $('#datetimepicker').datetimepicker({
                                    disabledWeekDays: [0, 1, 2, 4, 5, 7],
                                    beforeShowDay: function (date) {

                                        if (date.getMonth() == dateToDisable.getMonth() && (date.getDate() == dateToDisable.getDate() || date.getDate() == dateToDisable2.getDate() || date.getDate() == dateToDisable3.getDate() || date.getDate() == dateToDisable4.getDate())) {
                                            return [false, ""]
                                        }
                                        return [true, ""];
                                    },
                                    minDate: '-1970/01/1',
                                    allowTimes: [
                                           '08:00',
                                           '09:00',
                                           '10:00',
                                           '11:00',
                                           '12:00',
                                           '13:00',
                                           '14:00',
                                           '15:00',
                                           '16:00',
                                           '17:00']
                                });

                            </script>
                            <script>
                                function Traer_Fecha() {
                                    var fecha = document.getElementById('datetimepicker').value;
                                    document.getElementById("<%= LI_Fecha_Agenda.ClientID %>").value = fecha;

                                }
                            </script>
                        </td>
                    </tr>
                </table>
                <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                    <ContentTemplate>
                        <table class="tabla">
                            <tr>
                                <td colspan="4">
                                    <p class="etiquetas">Observaciones:</p>
                                    <asp:TextBox CssClass="notas_casos" ID="LI_Observaciones" runat="server" autocomplete="off"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>

            </asp:Panel>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:Button CssClass="button" ID="LI_Guardar" runat="server" Text="Guardar" OnClick="LI_Guardar_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
    <!-- NUEVO SCRIP DE DISEÑO-->
    <div class="modal-wrapper" id="Fraudes">
        <div class="Fraudes-contenedor">
            <a class="Fraudes-cerrar" href="#">X</a>
            <h2>FORMULARIO GESTIÓN FRAUDES</h2>
            <hr />
            <asp:UpdatePanel ID="UpdatePanel12" runat="server">
                <ContentTemplate>
                    <asp:Panel CssClass="panel_informativo" ID="Panel8" runat="server" GroupingText="Datos del cliente en RR">
                        <table class="tabla">
                            <tr>
                                <td>
                                    <p class="etiquetas">Cuenta del Cliente:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="F_Cuenta_Cliente" runat="server" OnTextChanged="F_Cuenta_Cliente_TextChanged" AutoPostBack="true" onkeypress="return justNumbers(event);" Placeholder="Ingrese la Cuenta"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Home Pass:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="F_Home_Pass" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Estado Cliente:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="F_Estado_Cliente" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Nombre Cliente :</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="F_Nombre_Cliente" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Apellido Cliente:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="F_Apellido_Cliente" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Dirección Instalación:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="F_Direccion_Instalacion" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Dir Correspondencia:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="F_Direccion_Correspondencia" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <p class="etiquetas">Teléfono Telmex:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="F_Telefono_Telmex" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Teléfono 1:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="F_Telefono_1" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Teléfono 2:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="F_Telefono_2" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Teléfono 3:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="F_Telefono_3" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Móvil Postpago:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="F_Movil_Postpago" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Correo:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="F_Correo" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Nodo:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="F_Nodo" runat="server"></asp:TextBox>
                                </td>

                            </tr>
                            <tr>
                                <td>
                                    <p class="etiquetas">Red:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="F_Red" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">División:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="F_Division" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Área:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="F_Area" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Zona:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="F_Zona" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Distrito:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="F_Distrito" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Nombre Comunidad:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="F_Nombre_Comunidad" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Departamento:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="F_Departamento" runat="server"></asp:TextBox>
                                </td>

                            </tr>
                            <tr>
                                <td>
                                    <p class="etiquetas">Estrato:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="F_Estrato" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Tipo cliente:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="F_Tipo_Cliente" runat="server"></asp:TextBox>
                                </td>

                            </tr>
                        </table>
                    </asp:Panel>
                    <asp:Panel CssClass="panel_informativo" ID="Panel9" runat="server" GroupingText="Datos del cliente en Buró">
                        <table class="tabla">
                            <tr>
                                <td>
                                    <p class="etiquetas">Servicios:</p>
                                    <asp:TextBox CssClass="caja_de_texto_consulta" ID="F_Servicios" runat="server"></asp:TextBox>
                                </td>

                                <td>
                                    <p class="etiquetas">Fijos Buró:</p>
                                    <asp:TextBox CssClass="caja_de_texto_consulta" ID="F_Fijos_Buro" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="etiquetas">Moviles Buró:</p>
                                    <asp:TextBox CssClass="caja_de_texto_consulta" ID="F_Moviles_Buro" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <p class="etiquetas">Fecha Digitación:</p>
                                    <asp:TextBox CssClass="caja_de_texto" ID="F_Fecha_Digitacion" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                    <hr />
                    <asp:Panel CssClass="panel_informativo" ID="Panel10" runat="server" GroupingText="Árbol de Tipificación">
                        <table class="tabla">
                            <tr>
                                <td>
                                    <p class="etiquetas">Tipo de Contacto:</p>
                                    <asp:DropDownList CssClass="dropdown2" ID="F_Tipo_Contacto" runat="server" AutoPostBack="true" OnSelectedIndexChanged="F_Tipo_Contacto_SelectedIndexChanged"></asp:DropDownList>
                                </td>
                                <td>
                                    <p class="etiquetas">Cierre:</p>
                                    <asp:DropDownList CssClass="dropdown3" ID="F_Cierre" runat="server" AutoPostBack="true" OnSelectedIndexChanged="F_Cierre_SelectedIndexChanged"></asp:DropDownList>
                                </td>
                                <td>
                                    <p class="etiquetas">Razón:</p>
                                    <asp:DropDownList CssClass="dropdown3" ID="F_Razon" runat="server"></asp:DropDownList>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                    <asp:Panel CssClass="panel_informativo" ID="Panel11" runat="server" GroupingText="Notas">
                        <table class="tabla">
                            <tr>
                                <td colspan="4">
                                    <p class="etiquetas">Observaciones:</p>
                                    <asp:TextBox CssClass="notas_casos" ID="F_Observaciones" runat="server" autocomplete="off"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                    <hr />
                    <asp:Button CssClass="button" ID="F_Guardar" runat="server" Text="Guardar" OnClick="F_Guardar_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
    <!-- NUEVO SCRIP DE DISEÑO-->
    <div class="modal-wrapper" id="Claro_Video">
        <div class="Claro_Video-contenedor">
            <a class="Claro_Video-cerrar" href="#">X</a>
            <h2>FORMULARIO CLARO VIDEO</h2>
            <hr />
            <asp:UpdatePanel ID="UpdatePanel15" runat="server">
                <ContentTemplate>
                    <asp:UpdatePanel ID="UpdatePanel16" runat="server">
                        <ContentTemplate>
                            <asp:Panel CssClass="panel_informativo" ID="Panel15" runat="server" GroupingText="Datos del Cliente">
                                <table class="tabla">
                                    <tr>
                                        <td>
                                            <p class="etiquetas">Cuenta del Cliente:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="CV_Cuenta_Cliente" runat="server" AutoPostBack="true" OnTextChanged="CV_Cuenta_Cliente_TextChanged" onkeypress="return justNumbers(event);" Placeholder="Ingrese la Cuenta"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Nombre Cliente:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="CV_Nombre_Cliente" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Apellido Cliente:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="CV_Apellido_Cliente" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Dir. Instalación:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="CV_Direccion_de_Instalacion" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Dir. Correspondencia:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="CV_Direccion_de_Correspondencia" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Teléfono 1:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="CV_Telefono_1" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Teléfono 2:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="CV_Telefono_2" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class="etiquetas">Teléfono 3:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="CV_Telefono_3" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Móvil 1:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="CV_Movil_1" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Móvil 2:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="CV_Movil_2" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Nombre Comunidad:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="CV_Nombre_Comunidad" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Correo Actual:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="CV_Correo_Electronico" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Estrato:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="CV_Estrato" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Tipo de Cliente:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="CV_Tipo_Cliente" runat="server" Enabled="false"></asp:TextBox>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td>
                                            <p class="etiquetas">Paquete Actual:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="CV_Paquete_Actual" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Móvil Postpago:</p>
                                            <asp:TextBox CssClass="caja_de_texto" ID="CV_Movil_Portpago" runat="server" Enabled="false"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <hr />
                    <asp:UpdatePanel ID="UpdatePanel17" runat="server">
                        <ContentTemplate>
                            <asp:Panel CssClass="panel_informativo" ID="Panel16" runat="server" GroupingText="Árbol de Tipificación">
                                <table class="tabla">
                                    <tr>
                                        <td>
                                            <p class="etiquetas">Tipo de Contacto:</p>
                                            <asp:DropDownList CssClass="dropdown2" ID="CV_Tipo_Contacto" runat="server" OnSelectedIndexChanged="CV_Tipo_Contacto_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Tipo de Gestión:</p>
                                            <asp:DropDownList CssClass="dropdown2" ID="CV_Tipo_Gestion" runat="server" AutoPostBack="true" OnSelectedIndexChanged="CV_Tipo_Gestion_SelectedIndexChanged"></asp:DropDownList>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Cierre:</p>
                                            <asp:DropDownList CssClass="dropdown4" ID="CV_Tipo_Cierre" runat="server" AutoPostBack="true" OnSelectedIndexChanged="CV_Tipo_Cierre_SelectedIndexChanged"></asp:DropDownList>
                                        </td>
                                        <td>
                                            <p class="etiquetas">Razón:</p>
                                            <asp:DropDownList CssClass="dropdown3" ID="CV_Tipo_Razon" runat="server"></asp:DropDownList>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                            <hr />
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <asp:Panel CssClass="panel_informativo" ID="Panel17" runat="server" GroupingText="Datos Actualizables">
                        <table class="tabla">
                            <tr>
                                <td colspan="2">
                                    <div class="Titulo_Usuarios5">
                                        <p class="etiquetas5">Servicio Ofrecido:</p>
                                    </div>
                                    <div class="soluciones">
                                        <asp:CheckBox CssClass="etiquetas" ID="CheckBox4" runat="server" Text="Claro Video" GroupName="Servicio" />
                                    </div>
                                    <div class="soluciones">
                                        <asp:CheckBox CssClass="etiquetas" ID="CheckBox5" runat="server" Text="Elegido fijo móvil" GroupName="Servicio" />
                                        <asp:Label ID="CV_Operacion" runat="server" Visible="false"></asp:Label>
                                        <asp:Label ID="CV_Nombre_Asesor" runat="server" Visible="true"></asp:Label>
                                    </div>
                                </td>
                            </tr>
                        </table>
                        <table class="tabla">
                            <tr>
                                <td colspan="4">
                                    <p class="etiquetas">Observaciones:</p>
                                    <asp:TextBox CssClass="notas_casos" ID="CV_Observaciones" runat="server" autocomplete="off"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>

                    <asp:Button CssClass="button" ID="CV_Guardar" runat="server" Text="Guardar" OnClick="CV_Guardar_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>

