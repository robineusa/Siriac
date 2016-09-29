using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Log_Transacciones
    {
        #region Atributos
        private Int64 _Id_Log;
        private Int64 _Id_Ingreso;
        private string _Transaccion;
        private string _Usuario;
        private string _Fecha;
        private string _Hora;
        #endregion
        #region Constructor
        public E_Log_Transacciones() {
            _Id_Log = 0;
            _Id_Ingreso = 0;
            _Transaccion = string.Empty;
            _Usuario = string.Empty;
            _Fecha = string.Empty;
            _Hora = string.Empty;
        }
        #endregion
        #region Encapsulamientos
        public Int64 Id_Log
        {
            get { return _Id_Log; }
            set { _Id_Log = value; }
        }
        public Int64 Id_Ingreso
        {
            get { return _Id_Ingreso; }
            set { _Id_Ingreso = value; }
        }
        public string Transaccion
        {
            get { return _Transaccion; }
            set { _Transaccion = value; }
        }
        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }
        public string Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        public string Hora
        {
            get { return _Hora; }
            set { _Hora = value; }
        }
        #endregion
    }
}
