using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Buen_Servicio
    {
        #region Atributos
        private Int64 _Id_Notificacion;
        private string _Fecha_Publicacion;
        private string _Usuario_Publicacion;
        private Byte[] _Imagen_Notificacion;
        private string _Nombre_Imagen;
        private string _Link_Direccionamiento;
        private string _Descripcion;
        private string _Aliado_Destino;
        private string _Perfil_Destino;
        private string _Operacion_Destino;
        private string _Estado_Publicacion;
        public string _Usuario;
        private string _Fecha_Visto;
        private string _Imagen_Vista;
        private string _Nombre_Imagen_Vista;
        private string _Descripcion_Imagen_Vista;
        private string _Aliado_Usuario;
        private string _Perfil_Usuario;
        private string _Operacion_Usuario;
        private double _Id_Notificacion_v;
        #endregion
        #region Constructor
        public E_Buen_Servicio() {
            _Id_Notificacion = 0;
            _Fecha_Publicacion = string.Empty;
            _Usuario_Publicacion = string.Empty;
            _Nombre_Imagen = string.Empty;
            _Link_Direccionamiento = string.Empty;
            _Descripcion = string.Empty;
            _Aliado_Destino = string.Empty;
            _Perfil_Destino = string.Empty;
            _Operacion_Destino = string.Empty;
            _Estado_Publicacion = string.Empty;
            _Usuario = string.Empty;
            _Fecha_Visto=string.Empty;
            _Imagen_Vista = string.Empty;
            _Nombre_Imagen_Vista = string.Empty;
            _Link_Direccionamiento = string.Empty;
            _Descripcion_Imagen_Vista = string.Empty;
            _Aliado_Usuario = string.Empty;
            _Perfil_Usuario = string.Empty;
            _Operacion_Usuario = string.Empty;
            _Id_Notificacion_v = 0;
        }
        #endregion
        #region Encapsulamientos
        public Int64 Id_Notificacion
        {
            get { return _Id_Notificacion; }
            set { _Id_Notificacion = value; }
        }
        public string Fecha_Publicacion
        {
            get { return _Fecha_Publicacion; }
            set { _Fecha_Publicacion = value; }
        }
        public string Usuario_Publicacion
        {
            get { return _Usuario_Publicacion; }
            set { _Usuario_Publicacion = value; }
        }
        public Byte [] Imagen_Notificacion
        {
            get { return _Imagen_Notificacion; }
            set { _Imagen_Notificacion = value; }
        }
        public string Nombre_Imagen
        {
            get { return _Nombre_Imagen; }
            set { _Nombre_Imagen = value; }
        }
        public string Link_Direccionamiento
        {
            get { return _Link_Direccionamiento; }
            set { _Link_Direccionamiento = value; }
        }
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        public string Aliado_Destino
        {
            get { return _Aliado_Destino; }
            set { _Aliado_Destino = value; }
        }
        public string Perfil_Destino
        {
            get { return _Perfil_Destino; }
            set { _Perfil_Destino = value; }
        }
        public string Operacion_Destino
        {
            get { return _Operacion_Destino; }
            set { _Operacion_Destino = value; }
        }
        public string Estado_Publicacion
        {
            get { return _Estado_Publicacion; }
            set { _Estado_Publicacion = value; }
        }
        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }
        public string Fecha_Visto
        {
            get { return _Fecha_Visto; }
            set { _Fecha_Visto = value; }
        }
        public string Imagen_Vista
        {
            get { return _Imagen_Vista; }
            set { _Imagen_Vista = value; }
        }
        public string Nombre_Imagen_Vista
        {
            get { return _Nombre_Imagen_Vista; }
            set { _Nombre_Imagen_Vista = value; }
        }
        public string Descripcion_Imagen_Vista
        {
            get { return _Descripcion_Imagen_Vista; }
            set { _Descripcion_Imagen_Vista = value; }
        }
        public string Aliado_Usuario
        {
            get { return _Aliado_Usuario; }
            set { _Aliado_Usuario = value; }
        }
        public string Perfil_Usuario
        {
            get { return _Perfil_Usuario; }
            set { _Perfil_Usuario = value; }
        }
        public string Operacion_Usuario
        {
            get { return _Operacion_Usuario; }
            set { _Operacion_Usuario = value; }
        }
        public double Id_Notificacion_v
        {
            get
            { return _Id_Notificacion_v; }
            set { _Id_Notificacion_v = value; }
        }
        #endregion
    }
}
