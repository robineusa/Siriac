using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Data;

namespace Chat
{
    public class ChatHub : Hub
    {
        #region Data Members

        static List<UserDetail> ConnectedUsers = new List<UserDetail>();
        static List<MessageDetail> CurrentMessage = new List<MessageDetail>();

        #endregion

        #region Methods
        public void Connect(string id, string userName)
        {
            //var id = Context.ConnectionId;
            //OnDisconnected(id, true);
            if (ConnectedUsers.Count(x => x.ConnectionId == id) == 0)
            {
                
                ConnectedUsers.Add(new UserDetail { ConnectionId = id, UserName = userName });
                // send to caller
                Clients.Caller.onConnected(id, userName, ConnectedUsers, CurrentMessage);
                // send to all except caller client
                Clients.AllExcept(id).onNewUserConnected(id, userName);
            }
        }
        public void ondisconnected(string id)
        {
            var item = ConnectedUsers.FirstOrDefault(x => x.ConnectionId == id);
            if (item != null)
            {
                ConnectedUsers.Remove(item);
                //var id = Context.ConnectionId;
                Clients.All.onUserDisconnected(id, item.UserName);
            }
        }
        public virtual System.Threading.Tasks.Task OnDisconnected(string id, bool Stop)
        {
            var item = ConnectedUsers.FirstOrDefault(x => x.ConnectionId == id);
            if (item != null)
            {
                ConnectedUsers.Remove(item);
                //var id = Context.ConnectionId;
                Clients.All.onUserDisconnected(id, item.UserName);

            }
            return base.OnDisconnected(Stop);
            //return base.OnDisconnected(Stop);
        }
        public void enviar(string Nombre, string Mensaje)
        {
            Clients.All.Mensajes(Nombre, Mensaje);
        }
        public void send(string Nombre_Imagen, string Ruta_Imagen, string Id_Notificado, string Descripcion_Imagen)
        {
            Clients.All.broadcastMessage(Nombre_Imagen, Ruta_Imagen, Id_Notificado, Descripcion_Imagen);
        }
        public void mec(string NombreUsuario, string Cedula, string CuentaCliente )
        {
            Clients.All.Notificacion(NombreUsuario, Cedula, CuentaCliente);
        }
        public void SendPrivateMessage(string fromUserId, string toUserId, string message)
        {

            //string fromUserId = Context.ConnectionId;

            var toUser = ConnectedUsers.FirstOrDefault(x => x.ConnectionId == toUserId);
            var fromUser = ConnectedUsers.FirstOrDefault(x => x.ConnectionId == fromUserId);

            if (toUser != null && fromUser != null)
            {
                // send to 
                Clients.Client(toUserId).sendPrivateMessage(fromUserId, fromUser.UserName, message);

                // send to caller user
                Clients.Caller.sendPrivateMessage(toUserId, fromUser.UserName, message);
            }

        }
        #endregion
    }
}