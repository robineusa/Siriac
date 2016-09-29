using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    public class E_Rechazos
    {
        #region Atributos
        private Int64 _Id_Ingreso;
        private string _Fecha_Creacion;
        private string _Hora_de_Creacion;
        private string _Usuario_Creacion;
        private string _Nombre_Usuario_Creacion;
        private string _Usuario_Rechaza;
        private string _Nombre_Usuario_Rechaza;
        private string _Nombre_Linea_Usuario_Rechaza;
        private string _Aliado_Rechaza;
        private string _Fecha_del_Rechazo;
        private string _Fecha_del_Rechazo_2;
        private string _Hora_del_Rechazo;
        private string _Notas_del_Rechazo;
        #endregion
        #region Constructor
        public E_Rechazos()
        {
            _Id_Ingreso = 0;
            _Fecha_Creacion = string.Empty;
            _Hora_de_Creacion = string.Empty;
            _Usuario_Creacion = string.Empty;
            _Nombre_Usuario_Creacion = string.Empty;
            _Usuario_Rechaza = string.Empty;
            _Nombre_Usuario_Rechaza = string.Empty;
            _Nombre_Linea_Usuario_Rechaza = string.Empty;
            _Aliado_Rechaza = string.Empty;
            _Fecha_del_Rechazo = string.Empty;
            _Fecha_del_Rechazo_2 = string.Empty;
            _Hora_del_Rechazo = string.Empty;
            _Notas_del_Rechazo = string.Empty;
        }
        #endregion
        #region Encapsulamientos
        public Int64 Id_Ingreso
        {
            get { return _Id_Ingreso; }
            set { _Id_Ingreso = value; }
        }
        public string Fecha_Creacion
        {
            get { return _Fecha_Creacion; }
            set { _Fecha_Creacion = value; }
        }
        public string Hora_de_Creacion
        {
            get { return _Hora_de_Creacion; }
            set { _Hora_de_Creacion = value; }
        }
        public string Usuario_Creacion
        {
            get { return _Usuario_Creacion; }
            set { _Usuario_Creacion = value; }
        }
        public string Nombre_Usuario_Creacion
        {
            get { return _Nombre_Usuario_Creacion; }
            set { _Nombre_Usuario_Creacion = value; }
        }
        public string Usuario_Rechaza
        {
            get { return _Usuario_Rechaza; }
            set { _Usuario_Rechaza = value; }
        }
        public string Nombre_Usuario_Rechaza
        {
            get { return _Nombre_Usuario_Rechaza; }
            set { _Nombre_Usuario_Rechaza = value; }
        }
        public string Nombre_Linea_Usuario_Rechaza
        {
            get { return _Nombre_Linea_Usuario_Rechaza; }
            set { _Nombre_Linea_Usuario_Rechaza = value; }
        }
        public string Aliado_Rechaza
        {
            get { return _Aliado_Rechaza; }
            set { _Aliado_Rechaza = value; }
        }
        public string Fecha_del_Rechazo
        {
            get { return _Fecha_del_Rechazo; }
            set { _Fecha_del_Rechazo = value; }
        }
        public string Fecha_del_Rechazo_2
        {
            get { return _Fecha_del_Rechazo_2; }
            set { _Fecha_del_Rechazo_2 = value; }
        }
        public string Hora_del_Rechazo
        {
            get { return _Hora_del_Rechazo; }
            set { _Hora_del_Rechazo = value; }
        }
        public string Notas_del_Rechazo
        {
            get { return _Notas_del_Rechazo; }
            set { _Notas_del_Rechazo = value; }
        }
        #endregion
    }
}
