<%@ Page Title="" Language="C#" MasterPageFile="~/Perfil_Administrador.master" AutoEventWireup="true" CodeFile="Visualizador_Imagenes_BS.aspx.cs" Inherits="Visualizador_Imagenes_BS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

      
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div> 
    
        </div>
    <div >
       
     <h5 class="Titulos">VISUALIZADOR DE NOTIFICACIONES PUBLICADAS</h5>
        <hr />
             
      <asp:HyperLink runat="server" ID="URL" target="_blank"><asp:Image CssClass="imagen_Base_de_Datos" ID="Imagen_Seleccionada" runat="server" /></asp:HyperLink><hr />
        <input class="Button_Enviar_Imagen" type="button" id="Enviar_notificacion" value="Enviar Notificación" />
    </div>
    
    <asp:Textbox ID="Nombre_Usuario_T" runat="server" Style="display:none"></asp:Textbox>
    <asp:Label ID="Nombre_Imagen" runat="server" Text="Label" Style="display:none"></asp:Label>
    <asp:Label ID="Ruta_Imagen" runat="server" Text="Label" Style="display:none" ></asp:Label>
    <asp:Label ID="Id_Notificado" runat="server" Text="Label" Style="display:none" ></asp:Label>
    <asp:Label ID="Descripcion_Imagen" runat="server" Text="Label" Style="display:none" ></asp:Label>

   
                <script src="Js/jquery-1.12.4.js"></script>
                <script src="Js/jquery-ui.js"></script>
                <script src="scripts/jquery.signalR-2.2.0.js"></script>
                <script src="scripts/jquery.signalR-2.2.0.min.js"></script>
                <script src="signalr/hubs"></script>
                <link href="Estilos/Style_Perfil_Asesor.css?1.0.3" rel="stylesheet" />

             <script>
                    $(function () {
                        $('#Chat_Completo').draggable();
                    });
                </script>
                <div id="Chat_Completo" class="Chat_Completo">
                    <div id="header-chat" class="header-chat">
                        Notificaciones Administración
                    </div>
                    <div id="chat">

                        <div id="cuerpo_chat" class="cuerpo-chat">
                        </div>
                    </div>
                    <div id="caja-mensaje">

                        <textarea class="Caja_Chat" placeholder="Escribir mensaje..." id="Mensaje" rows="5"></textarea>
                        <input class="Button_Chat" type="button" id="Enviar_Mensaje" value="Enviar" />
                    </div>

                </div>
          
    <script type="text/javascript">
                    $(function Enviar_Mensage_Global() {
                        var chat = $.connection.chatHub;
                        Llama_Metodos_Clientes(chat);

                        $.connection.hub.start().done(function () {
                            Registra_Eventos(chat)
                        });

                    });

                    function Registra_Eventos(chat) {
                        $('#Enviar_notificacion').click(function () {
                            chat.server.send($(<%=Nombre_Imagen.ClientID%>).text(), $(<%=Ruta_Imagen.ClientID%>).text(),
                                $(<%=Id_Notificado.ClientID%>).text(), $(<%=Descripcion_Imagen.ClientID%>).text());
                            alert('Notificacion Generada');
                        });

                        $('#Enviar_Mensaje').click(function () {
                            chat.server.enviar($(<%=Nombre_Usuario_T.ClientID%>).val(), $('#Mensaje').val());
                            $('#Mensaje').val('');
                        });

                        $("#Mensaje").keypress(function (e) {
                            if (e.which == 13) {
                                $("#Enviar_Mensaje").click();
                            }
                        });

                    }

                    function Llama_Metodos_Clientes(chat) {
                        chat.client.broadcastMessage = function (Nombre_Imagen, Ruta_Imagen, Id_Notificado, Descripcion_Imagen) {
                            var V_Nombre_Imagen = $('<div/>').text(Nombre_Imagen).html();
                            var V_Ruta_Imagen = $('<div/>').text(Ruta_Imagen).html();
                            var V_Id_Notificado = $('<div/>').text(Id_Notificado).html();
                            var V_Descripcion_Imagen = $('<div/>').text(Descripcion_Imagen).html();
                            //$('#chat').append('<div class="Contenido_Mensajes" ><ul><li>' + V_Nombre_Imagen + ':&nbsp;&nbsp;' + V_Ruta_Imagen + ':&nbsp;&nbsp;' + V_Id_Notificado + ':&nbsp;&nbsp;' + V_Descripcion_Imagen + '</li></ul></div>');
                        }

                        chat.client.Mensajes = function (Nombre, Mensaje) {
                            var V_Nombre_U = $('<div/>').text(Nombre).html();
                            var V_Mensaje = $('<div/>').text(Mensaje).html();
                            $('#chat').append('<div class="Contenido_Mensajes" ><ul><li>' + V_Nombre_U + ':&nbsp;&nbsp;' + V_Mensaje + '</li></ul></div>');
                        }
                    }

                </script>
               
    
</asp:Content>

