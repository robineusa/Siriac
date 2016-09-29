<%@ Page Title="" Language="C#" MasterPageFile="~/Perfil_MEC.master" AutoEventWireup="true" CodeFile="Monitoreo.aspx.cs" Inherits="Monitoreo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="Estilos/Banner_Alertas_Asesor_In.css?1.0.2" rel="stylesheet" />
    <link href="Estilos/Style_Perfil_Asesor.css?1.0.7" rel="stylesheet" />
    <script src="Js/jquery-1.12.4.js"></script>
    <script src="Js/jquery-ui.js?1.0.1"></script>
    <script src="scripts/jquery.signalR-2.2.0.js"></script>
    <script src="scripts/jquery.signalR-2.2.0.min.js"></script>
    <script src="signalr/hubs"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
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
    <script type="text/javascript">
        function mensaje1() {

            alert('Número de cuenta no existe');
        }
    </script>
    <script type="text/javascript">
        function Activar_Convenio() {
            document.getElementById('Menu_Opciones_MEC').style.display = 'block';
            document.getElementById('Icono_1_MEC').style.display = 'block';
        }
    </script>
    <script type="text/javascript">
        function No_Activar_Convenio() {
            document.getElementById('Icono_1_MEC').style.display = 'none';
        }
    </script>
    <script type="text/javascript">
        function SMO_Activar() {
            document.getElementById('Menu_Opciones_MEC').style.display = 'block';
            document.getElementById('Icono_4_MEC').style.display = 'block';
        }
    </script>
    <script type="text/javascript">
        function SMO_Desactivar() {
            document.getElementById('Icono_4_MEC').style.display = 'none';
        }
    </script>
    <script type="text/javascript">
        function Banner_Alertas_Inicio() {

            document.getElementById('Menu_Opciones_MEC').style.display = 'none';
            document.getElementById('Icono_1_MEC').style.display = 'none';
            document.getElementById('Icono_2_MEC').style.display = 'none';
            document.getElementById('Icono_3_MEC').style.display = 'none';
            document.getElementById('Icono_4_MEC').style.display = 'none';
        }
    </script>
    <script>
        function In_Out_SMO() {
            if ($('#SMO').attr('sw') == '0') {
                document.getElementById('SMO').style.display = 'block';
                $('#SMO').attr('sw', '1');
            }
            else {
                document.getElementById('SMO').style.display = 'none';
                $('#SMO').attr('sw', '0');
            }
        }
        $(function () {
            $('#Chat_Completo_P').draggable();
        });
    </script>
    <div id="Usuarios_Chat">
        Asesores Conectados  
        <div class="Logo_conectados"></div>
        <br />
        <br />
        <div id="divusers">

            <input id="hdId" type="text" />
            <input id="hdUserName" type="text" />
        </div>
    </div>

    <script type="text/javascript">

        $(function Enviar_MEC() {
            var chat2 = $.connection.chatHub;
            Llama_Metodos_Clientes2(chat2);
            $.connection.hub.start().done(function () {
                Registra_Eventos2(chat2);
            });

        });
        function Registra_Eventos2(chat2) {
            var Usuario_RR = '<%=Session["Usuario_Logueado"]%>';
            var Nombre_Usuario = '<%=Session["Nombre_Usuario"]%>';
            //chat2.server.ondisconnected(Usuario_RR.toString());
            chat2.server.connect(Usuario_RR.toString(), Nombre_Usuario.toString());

        }

        function Llama_Metodos_Clientes2(chat2) {
            chat2.client.Notificacion = function (NombreUsuario, Cedula, CuentaCliente) {
                var V_Nombre_U = $('<div/>').text(NombreUsuario).html();
                var V_Cuenta_Cliente = $('<div/>').text(CuentaCliente).html();
                $('#div_MEC').append('<div class="Contenido_Mensajes_MEC" ><a onclick="Carga_Datos(' + Cedula + ',' + CuentaCliente +
                    ')" style="cursor:pointer"><ul><li> &nbsp;' + V_Nombre_U + ': Cuenta &nbsp;#' + V_Cuenta_Cliente + '</li></ul></a></div>');
            }
            chat2.client.onConnected = function (id, userName, allUsers, messages) {
                $('#hdId').val(id);
                $('#hdUserName').val(userName);
                // Add All Users
                for (i = 0; i < allUsers.length; i++) {
                    AddUser(chat2, allUsers[i].ConnectionId, allUsers[i].UserName);
                }
                // Add Existing Messages
                for (i = 0; i < messages.length; i++) {
                    AddMessage(messages[i].UserName, messages[i].Message);
                }
            }
            // On New User Connected
            chat2.client.onNewUserConnected = function (id, name) {
                AddUser(chat, id, name);
            }
            // On User Disconnected
            chat2.client.onUserDisconnected = function (id, userName) {
                $('#' + id).remove();
                var ctrId = 'private_' + id;
                $('#' + ctrId).remove();

                var disc = $('<div class="disconnect">"' + userName + '" logged off.</div>');
                $(disc).hide();
                $('#chat').prepend(disc);
                $(disc).fadeIn(200).delay(2000).fadeOut(200);
            }
            chat2.client.sendPrivateMessage = function (windowId, fromUserName, message) {

                var ctrId = 'private_' + windowId;
                if ($('#' + ctrId).length == 0) {
                    createPrivateChatWindow(chat2, windowId, ctrId, fromUserName);
                }
                $('#' + ctrId).find('#chat').append('<div class="Contenido_Mensajes"><ul><li>' + fromUserName + ':&nbsp;&nbsp;' + message + '</li></ul></div>');

                // set scrollbar
                //var height = $('#' + ctrId).find('#divMessage')[0].scrollHeight;
                //$('#' + ctrId).find('#divMessage').scrollTop(height);

            }
        }

        function AddUser(chatHub, id, name) {

            var userId = $('#hdId').val();
            var code = "";
            if (userId == id) {
                code = $('<div class="user">' + name + "</div>");

            }
            else {
                code = $('<div id="' + id + '" class="users">' + name + '<div>');
                $(code).dblclick(function () {
                    var id = $(this).attr('id');
                    if (userId != id)
                        OpenPrivateChatWindow(chatHub, id, name);
                });
            }
            //alert('si');
            $("#divusers").append(code);

        }
        function AddMessage(userName, message) {
            $('#chat').append('<div class="message"><span class="userName">' + userName + '</span>: ' + message + 'otro mensaje</div>');
            alert('si');
            var height = $('#chat')[0].scrollHeight;
            $('#chat').scrollTop(height);
        }
        function OpenPrivateChatWindow(chatHub, id, userName) {
            var ctrId = 'private_' + id;
            if ($('#' + ctrId).length > 0)
                return;

            createPrivateChatWindow(chatHub, id, ctrId, userName);
        }
        function createPrivateChatWindow(chatHub, userId, ctrId, userName) {
            var Usuario_RR2 = '<%=Session["Usuario_Logueado"]%>';
            var Chatdiv = '<div id="Chat_Completo_P" class="Chat_Completo">' +
                               '<div id="' + ctrId + '">' +
                                   '<div class="header-chat">' +
                                       '<div style="float: right;">' +
                                            '<a id="CerrarX" style="cursor: pointer; text-decoration: none;">X</a>' +
                                       '</div>' +
                                       '<span style="font-size:12px;"rel="0">' + userName + '</span>' +
                                   '</div>' +
                                '<div id="chat">' +
                                    '<div id="cuerpo_chat" class="cuerpo-chat">' +
                                    '</div>' +
                                '</div>' +
                                '<div id="caja-mensaje" style="">' +
                                    '<textarea class="Caja_Chat" placeholder="Escribir mensaje..." id="Mensaje_p" rows="5"></textarea>' +
                                    '<input class="Button_Chat" type="button" id="Enviar_Mensaje_p" value="Enviar" />' +
                                '</div>' +
                            '</div>' +
                          '</div>';

            // Text Box event
            
            $('#tab-container').prepend(Chatdiv);
            $('#Chat_Completo_P').draggable({
                
            });
            $('#CerrarX').click(function () {
                $('#' + ctrId).remove();
                $('#Chat_Completo_P').remove();
            });
            $('#Enviar_Mensaje_p').click(function () {
                var msg = $("#Mensaje_p").val();
                if (msg.length > 0) {
                    
                    chatHub.server.sendPrivateMessage(Usuario_RR2.toString(), userId, msg);
                    $("#Mensaje_p").val('');
                }
            });
            $('#Mensaje_p').keypress(function (e) {
                if (e.which == 13) {
                    $('#Enviar_Mensaje_p').click();
                }
            });
        }

        function Carga_Datos(Cedula, Cuenta) {
            $(<%=C_Cedula.ClientID%>).val(Cedula);
            $(<%=Cuenta_Cliente.ClientID%>).val(Cuenta);
            document.getElementById('<%=Buscar_Cliente.ClientID%>').click();
        }
        
        

    </script>
    <asp:Panel CssClass="panel" ID="Panel1" runat="server">
        <div id="tab-container">

            <ul class="tab-menu">
                <li id="html" class="active" onclick="otorgar_permisos()">MONITOREO</li>
            </ul>
            <div class="clear"></div>
            <div class="tab-top-border"></div>

            <div id="html-tab" class="tab-content active">
                <h3 class="Titulos">FORMULARIO PARA MONITOREO DE ASESORES</h3>
                <div id="Notificaciones_MEC" class="Notificacion_MEC">
                    <div id="header-Notificaciones" class="header-Notificaciones">
                        Notificación Tipificado de Asesores
                    </div>
                    <div id="div_MEC">
                        <div id="cuerpo_Notificaciones" class="cuerpo_Notificaciones">
                        </div>

                    </div>

                </div>
                <hr />
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <asp:Panel CssClass="panel_informativo" ID="Panel4" runat="server" GroupingText="Datos del Asesor">
                            <table class="tabla">
                                <tr>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label44" runat="server" Text="Documento de Identidad:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="C_Cedula" runat="server"></asp:TextBox>

                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label45" runat="server" Text="Nombre del Usuario:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="C_Nombre_Usuario" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label46" runat="server" Text="Aliado:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="C_Aliado" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label47" runat="server" Text="Nombre de Linea:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="C_Nombre_Linea" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label53" runat="server" Text="Operación:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="C_Operacion" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label54" runat="server" Text="Grupo:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="C_Grupo" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label55" runat="server" Text="Cargo:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="C_Cargo" runat="server"></asp:TextBox>
                                    </td>
                                </tr>

                            </table>

                        </asp:Panel>

                        <asp:Panel CssClass="panel_informativo" ID="Panel3" runat="server" GroupingText="Datos del Cliente">
                            <table class="tabla">
                                <tr>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label1" runat="server" Text="Número de Cuenta:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Cuenta_Cliente" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label2" runat="server" Text="Nombre del Cliente:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Nombre_Cliente" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label3" runat="server" Text="Apellido del Cliente:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Apellido_Cliente" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label4" runat="server" Text="Documento de Identidad:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Cedula_Cliente" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label6" runat="server" Text="Teléfono Telmex:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Telefono_Telmex" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label7" runat="server" Text="Teléfono 1:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Telefono_1" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label8" runat="server" Text="Teléfono 2:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Telefono_2" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label9" runat="server" Text="Teléfono 3:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Telefono_3" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label11" runat="server" Text="Dirección de Instalación:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Direccion_Instalacion" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label12" runat="server" Text="Correspondencia:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Direccion_Correspondencia" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label13" runat="server" Text="Correo Electrónico:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Correo_Electronico" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label14" runat="server" Text="Nodo:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Nodo" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label15" runat="server" Text="Red:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Red" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label16" runat="server" Text="División:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Division" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>

                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label17" runat="server" Text="Área"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Area" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label18" runat="server" Text="Zona:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Zona" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label19" runat="server" Text="Distrito:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Distrito" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label20" runat="server" Text="Nombre Comunidad:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Nombre_Comunidad" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label21" runat="server" Text="Estrato:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Estrato" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label22" runat="server" Text="Tipo de Cliente:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Tipo_Cliente" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="texto_informativo" ID="Label23" runat="server" Text="Descripción:"></asp:Label><br />
                                        <asp:TextBox CssClass="caja_de_texto" ID="Descripcion" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                            <asp:Button runat="server" ID="Buscar_Cliente" OnClick="Cuenta_Cliente_TextChanged" Style="display: none" />
                        </asp:Panel>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <asp:Panel CssClass="panel_informativo" ID="Panel2" runat="server" GroupingText="Ofertas Activas">
                            <div id="Menu_Opciones_MEC" style="display: none">
                                <div id="Latido" class="latir_MEC">
                                    <%--a href="#Iframe_Paradigma" onclick="document.getElementById('Iframe_Paradigma').style.display = 'block';">--%>
                                    <div id="Icono_1_MEC" style="display: none"></div>
                                    <%-- </a>--%>
                                    <div id="Icono_2_MEC" style="display: none"></div>
                                    <div id="Icono_3_MEC" style="display: none"></div>
                                    <a onclick="return In_Out_SMO()">
                                        <div id="Icono_4_MEC" style="display: none"></div>
                                    </a>
                                </div>
                            </div>
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <div id="SMO" sw="0" style="display: none">
                                <br />
                                <h2>Siguiente Mejor Oferta</h2>
                                <br />
                                <table class="tabla">
                                    <tr>
                                        <td colspan="10">
                                            <div class="Titulo_Usuarios5" style="width: 200px;">
                                                <p class="etiquetas5" style="width: 200px;">Informacion Actual de Servicios: </p>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                                <table class="tabla">
                                    <tr>
                                        <div class="Texto_Informativo_CC">Mix Básico:</div>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label100" runat="server" Text="Paquete Actual:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="SMO_Mix_Basico" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                                <table class="tabla">
                                    <tr>
                                        <div class="Texto_Informativo_CC">Servicios Principales:</div>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label38" runat="server" Text="Television:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="SMO_Television" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label5" runat="server" Text="Internet:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="SMO_Internet" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label56" runat="server" Text="Telefonia:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="SMO_Telefonia" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                                <table class="tabla">
                                    <tr>
                                        <div class="Texto_Informativo_CC">Servicios Adicionales:</div>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label57" runat="server" Text="Servico HD:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="SMO_HD" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label58" runat="server" Text="Servicio HBO:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="SMO_HBO" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label59" runat="server" Text="Servicio FOX:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="SMO_FOX" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label60" runat="server" Text="Servicio Adulto:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="SMO_Adulto" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label61" runat="server" Text="Servicio Claro Video:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="SMO_Servicio_Claro_Video" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label62" runat="server" Text="Numero Decos:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="SMO_Num_Decos" runat="server"></asp:TextBox>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label63" runat="server" Text="Revista:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="SMO_Revista" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label64" runat="server" Text="Elegido Fijo Móvil:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="SMO_Elegido_Fijo_Movil" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label65" runat="server" Text="Siembra HD:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="SMO_Siembra_HD" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label66" runat="server" Text="Blindaje Internet:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="SMO_Blindaje_Internet" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label67" runat="server" Text="Siembra Voz:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="SMO_Siembra_Voz" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label68" runat="server" Text="Activacion Claro Video:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="SMO_Activacion_Claro_Video" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                    </tr>
                                </table>
                                <table class="tabla">
                                    <tr>
                                        <td colspan="10">
                                            <div class="Titulo_Usuarios5" style="width: 200px;">
                                                <p class="etiquetas5" style="width: 200px;">Ofrecimientos: </p>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                                <table class="tabla">
                                    <tr>
                                        <td colspan="6">
                                            <div class="Titulo_Ofrecimientos" id="CC_1">
                                                <p class="etiquetas5">Primer Ofrecimiento:</p>
                                            </div>
                                            <asp:UpdatePanel runat="server">
                                                <ContentTemplate>
                                                    <asp:TextBox CssClass="ofrecimientos" ID="SMO_T_Ofrecimiento_1" runat="server" TextMode="MultiLine" Enabled="false" Style="max-width: 900px; min-width: 900px;"></asp:TextBox>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </td>
                                    </tr>
                                </table>
                                <table class="tabla">
                                    <tr>
                                        <td colspan="6">
                                            <div class="Titulo_Ofrecimientos" id="CC_2">
                                                <p class="etiquetas5">Segundo Ofrecimiento:</p>
                                            </div>
                                            <asp:UpdatePanel runat="server">
                                                <ContentTemplate>
                                                    <asp:TextBox CssClass="ofrecimientos" ID="SMO_T_Ofrecimiento_2" runat="server" TextMode="MultiLine" Enabled="false" Style="max-width: 900px; min-width: 900px;"></asp:TextBox>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </td>
                                    </tr>
                                </table>
                                <table class="tabla">
                                    <tr>
                                        <td colspan="6">
                                            <div class="Titulo_Ofrecimientos" id="CC_3">
                                                <p class="etiquetas5">Tercer Ofrecimiento:</p>
                                            </div>
                                            <asp:UpdatePanel runat="server">
                                                <ContentTemplate>
                                                    <asp:TextBox CssClass="ofrecimientos" ID="SMO_T_Ofrecimiento_3" runat="server" TextMode="MultiLine" Enabled="false" Style="max-width: 900px; min-width: 900px;"></asp:TextBox>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </td>
                                    </tr>
                                </table>

                                <table class="tabla">
                                    <tr>
                                        <td colspan="10">
                                            <div class="Titulo_Usuarios5">
                                                <p class="etiquetas5" style="width: 200px;">Paleta de servicios: </p>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                                <div class="SMO_Contenedor" style="margin: auto; width: 97%; background-color: rgba(255,255,255,0.5);">
                                    <div class="Texto_Informativo_SMO_2">Servicios Principales</div>
                                    <table class="tabla2">
                                        <tr>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_VOZ" runat="server" />
                                                    <asp:Label ID="Label123" AssociatedControlID="SMO_S_VOZ" runat="server"
                                                        Text="Telefonía" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="tabla2">
                                        <tr>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_ANALOGA" runat="server" />
                                                    <asp:Label ID="Label113" AssociatedControlID="SMO_S_ANALOGA" runat="server"
                                                        Text="Televisión Análoga" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_AVANZADA" runat="server" />
                                                    <asp:Label ID="Label114" AssociatedControlID="SMO_S_AVANZADA" runat="server"
                                                        Text="Televisión Avanzada" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_BASICA" runat="server" />
                                                    <asp:Label ID="Label115" AssociatedControlID="SMO_S_BASICA" runat="server"
                                                        Text="Televisión Básica" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_SATELITAL" runat="server" />
                                                    <asp:Label ID="Label116" AssociatedControlID="SMO_S_SATELITAL" runat="server"
                                                        Text="Televisión Satelital" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="tabla2">
                                        <tr>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_INTERNET_3M" runat="server" />
                                                    <asp:Label ID="Label117" AssociatedControlID="SMO_S_INTERNET_3M" runat="server"
                                                        Text="Internet 3 Megas" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_INTERNET_5M" runat="server" />
                                                    <asp:Label ID="Label118" AssociatedControlID="SMO_S_INTERNET_5M" runat="server"
                                                        Text="Internet 5 Megas" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_INTERNET_10M" runat="server" />
                                                    <asp:Label ID="Label119" AssociatedControlID="SMO_S_INTERNET_10M" runat="server"
                                                        Text="Internet 10 Megas" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_INTERNET_20M" runat="server" />
                                                    <asp:Label ID="Label120" AssociatedControlID="SMO_S_INTERNET_20M" runat="server"
                                                        Text="Internet 20 Megas" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_INTERNET_50M" runat="server" />
                                                    <asp:Label ID="Label121" AssociatedControlID="SMO_S_INTERNET_50M" runat="server"
                                                        Text="Internet 50 Megas" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_INTERNET_100M" runat="server" />
                                                    <asp:Label ID="Label122" AssociatedControlID="SMO_S_INTERNET_100M" runat="server"
                                                        Text="Internet 100 Megas" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                                <br />
                                <div class="SMO_Contenedor" style="width: 97%; margin: auto; background-color: rgba(255,255,255,0.5);">
                                    <div class="Texto_Informativo_SMO_2">Servicios Adicionales</div>
                                    <table class="tabla2">
                                        <tr>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_CLARO_VIDEO" runat="server" />
                                                    <asp:Label ID="Label124" AssociatedControlID="SMO_S_CLARO_VIDEO" runat="server"
                                                        Text="Claro Video" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_FOX" runat="server" />
                                                    <asp:Label ID="Label125" AssociatedControlID="SMO_S_FOX" runat="server"
                                                        Text="Fox +" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_GOLDEN_PREMIER_HD" runat="server" />
                                                    <asp:Label ID="Label126" AssociatedControlID="SMO_S_GOLDEN_PREMIER_HD" runat="server"
                                                        Text="Golden Premier HD" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_HBO" runat="server" />
                                                    <asp:Label ID="Label127" AssociatedControlID="SMO_S_HBO" runat="server"
                                                        Text="HBO" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_HD" runat="server" />
                                                    <asp:Label ID="Label128" AssociatedControlID="SMO_S_HD" runat="server"
                                                        Text="HD" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_HOTPACK" runat="server" />
                                                    <asp:Label ID="Label129" AssociatedControlID="SMO_S_HOTPACK" runat="server"
                                                        Text="Hot Pack" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_INTERNET_MOVIL_1_5" runat="server" />
                                                    <asp:Label ID="Label130" AssociatedControlID="SMO_S_INTERNET_MOVIL_1_5" runat="server"
                                                        Text="Internet Móvil 1.5" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_INTERNET_MOVIL_750" runat="server" />
                                                    <asp:Label ID="Label144" AssociatedControlID="SMO_S_INTERNET_MOVIL_750" runat="server"
                                                        Text="Internet Móvil 750" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_IP_FIJA" runat="server" />
                                                    <asp:Label ID="Label131" AssociatedControlID="SMO_S_IP_FIJA" runat="server"
                                                        Text="IP Fija" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_LOCAL_EXTENDIDA" runat="server" />
                                                    <asp:Label ID="Label132" AssociatedControlID="SMO_S_LOCAL_EXTENDIDA" runat="server"
                                                        Text="Local extendida" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_MACAFEE" runat="server" />
                                                    <asp:Label ID="Label133" AssociatedControlID="SMO_S_MACAFEE" runat="server"
                                                        Text="Macafee" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_MINI_FOX" runat="server" />
                                                    <asp:Label ID="Label134" AssociatedControlID="SMO_S_MINI_FOX" runat="server"
                                                        Text="Mini Fox" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_MINI_HBO" runat="server" />
                                                    <asp:Label ID="Label135" AssociatedControlID="SMO_S_MINI_HBO" runat="server"
                                                        Text="Mini HBO" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_MODEM_ADICIONAL" runat="server" />
                                                    <asp:Label ID="Label136" AssociatedControlID="SMO_S_MODEM_ADICIONAL" runat="server"
                                                        Text="Modem Adicional" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>

                                        </tr>
                                        <tr>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_PVR" runat="server" />
                                                    <asp:Label ID="Label137" AssociatedControlID="SMO_S_PVR" runat="server"
                                                        Text="PVR" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_PVR_HD" runat="server" />
                                                    <asp:Label ID="Label138" AssociatedControlID="SMO_S_PVR_HD" runat="server"
                                                        Text="PVR + HD" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_REVISTA" runat="server" />
                                                    <asp:Label ID="Label139" AssociatedControlID="SMO_S_REVISTA" runat="server"
                                                        Text="Revista 15 Min" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_SEGUNDO_MODEM" runat="server" />
                                                    <asp:Label ID="Label141" AssociatedControlID="SMO_S_SEGUNDO_MODEM" runat="server"
                                                        Text="Segundo Modem" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_UFC" runat="server" />
                                                    <asp:Label ID="Label142" AssociatedControlID="SMO_S_UFC" runat="server"
                                                        Text="UFC Network" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                            <td>
                                                <div class="SingleCheckbox">
                                                    <asp:CheckBox ID="SMO_S_VOD" runat="server" />
                                                    <asp:Label ID="Label143" AssociatedControlID="SMO_S_VOD" runat="server"
                                                        Text="VOD" CssClass="CheckBoxLabel"></asp:Label>
                                                </div>
                                            </td>
                                        </tr>
                                    </table>
                                </div>

                                <br />
                            </div>
                            <br />
                            <br />

                        </asp:Panel>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <br />
                <br />
            </div>
        </div>
    </asp:Panel>
</asp:Content>

