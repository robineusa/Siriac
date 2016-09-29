using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Notas_Casos
    {
        #region Atributos
        private Int64 _Id_Nota;
        private Int64 _Id_Ingreso;
        private Int64 _Cuenta_Cliente;
        private Int64 _Ticket;
        private string _Usuario;
        private string _Nombre_Linea_Nota;
        private string _Fecha_Nota;
        private string _Hora_Nota;
        private string _Llamada_Cliente;
        private string _Nota;
        private int _Id_Estado;
        private string _Descripcion_Estado;
        #endregion
        #region Constructor
        public E_Notas_Casos() {
            _Id_Nota = 0;
            _Id_Ingreso = 0;
            _Cuenta_Cliente = 0;
            _Ticket = 0;
            _Usuario = string.Empty;
            _Nombre_Linea_Nota = string.Empty;
            _Fecha_Nota = string.Empty;
            _Hora_Nota = string.Empty;
            _Llamada_Cliente = string.Empty;
            _Nota = string.Empty;
            _Id_Estado = 0;
            _Descripcion_Estado = string.Empty;
        }
        #endregion
        #region Encapsulamientos
        public Int64 Id_Nota
        {
            get { return _Id_Nota; }
            set { _Id_Nota = value; }
        }
        public Int64 Id_Ingreso
        {
            get { return _Id_Ingreso; }
            set { _Id_Ingreso = value; }
        }
        public Int64 Cuenta_Cliente
        {
            get { return _Cuenta_Cliente; }
            set { _Cuenta_Cliente = value; }
        }
        public Int64 Ticket
        {
            get { return _Ticket; }
            set { _Ticket = value; }
        }
        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }
        public string Nombre_Linea_Nota
        {
            get { return _Nombre_Linea_Nota; }
            set { _Nombre_Linea_Nota = value; }
        }
        public string Fecha_Nota
        {
            get { return _Fecha_Nota; }
            set { _Fecha_Nota = value; }
        }
        public string Hora_Nota
        {
            get { return _Hora_Nota; }
            set { _Hora_Nota = value; }
        }
        public string Llamada_Cliente
        {
            get { return _Llamada_Cliente; }
            set { _Llamada_Cliente = value; }
        }
        public string Nota
        {
            get { return _Nota; }
            set { _Nota = value; }
        }
        public int Id_Estado
        {
            get { return _Id_Estado; }
            set { _Id_Estado = value; }
        }
        public string Descripcion_Estado
        {
            get { return _Descripcion_Estado; }
            set { _Descripcion_Estado = value; }
        }
        #endregion
    }
}
