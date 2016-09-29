using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Paloteo
    {
        #region Atributos
        private double __Id_Ingreso;
        private double _Cuenta_Cliente;
        private double _Ticket;
        private string _Usuario;
        private string _Nombre_Usuario;
        private string _Perfil_Usuario;
        private string _Nombre_Linea_Nota;
        private string _Aliado_Apertura;
        private string _Fecha_Interaccion;
        private string _Hora_Interaccion;
        private string _Contacto_Cliente;
        private string _Macroproceso;
        private string _Proceso;
        private string _Subproceso;
        private string _Marcacion;
        private string _Division;
        private string _Area;
        private string _Zona;
        private string _Distrito;
        private string _Nombre_Comunidad;
        private string _Nodo;
        private string _Nota;
        private string _Estado_Caso;
        private string _Fecha_Inicial;
        private string _Fecha_Final;
        #endregion
        #region Constructor
        public E_Paloteo()
        {
            __Id_Ingreso = 0;
            _Cuenta_Cliente = 0;
            _Ticket = 0;
            _Usuario = string.Empty;
            _Nombre_Usuario = string.Empty;
            _Perfil_Usuario = string.Empty;
            _Nombre_Linea_Nota = string.Empty;
            _Aliado_Apertura = string.Empty;
            _Fecha_Interaccion = string.Empty;
            _Hora_Interaccion = string.Empty;
            _Contacto_Cliente = string.Empty;
            _Macroproceso = string.Empty;
            _Proceso = string.Empty;
            _Subproceso = string.Empty;
            _Marcacion = string.Empty;
            _Division = string.Empty;
            _Area = string.Empty;
            _Zona = string.Empty;
            _Distrito = string.Empty;
            _Nombre_Comunidad = string.Empty;
            _Nodo = string.Empty;
            _Nota = string.Empty;
            _Estado_Caso = string.Empty;
        }
        #endregion
        #region Encapsulamientos
        public double _Id_Ingreso
        {
            get { return __Id_Ingreso; }
            set { __Id_Ingreso = value; }
        }
        public double Cuenta_Cliente
        {
            get { return _Cuenta_Cliente; }
            set { _Cuenta_Cliente = value; }
        }
        public double Ticket
        {
            get { return _Ticket; }
            set { _Ticket = value; }
        }
        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }
        public string Nombre_Usuario
        {
            get { return _Nombre_Usuario; }
            set { _Nombre_Usuario = value; }
        }
        public string Perfil_Usuario
        {
            get { return _Perfil_Usuario; }
            set { _Perfil_Usuario = value; }
        }
        public string Nombre_Linea_Nota
        {
            get { return _Nombre_Linea_Nota; }
            set { _Nombre_Linea_Nota = value; }
        }
        public string Aliado_Apertura
        {
            get { return _Aliado_Apertura; }
            set { _Aliado_Apertura = value; }
        }
        public string Fecha_Interaccion
        {
            get { return _Fecha_Interaccion; }
            set { _Fecha_Interaccion = value; }
        }
        public string Hora_Interaccion
        {
            get { return _Hora_Interaccion; }
            set { _Hora_Interaccion = value; }
        }
        public string Contacto_Cliente
        {
            get { return _Contacto_Cliente; }
            set { _Contacto_Cliente = value; }
        }
        public string Macroproceso
        {
            get { return _Macroproceso; }
            set { _Macroproceso = value; }
        }

        public string Proceso
        {
            get { return _Proceso; }
            set { _Proceso = value; }
        }

        public string Subproceso
        {
            get { return _Subproceso; }
            set { _Subproceso = value; }
        }

        public string Marcacion
        {
            get { return _Marcacion; }
            set { _Marcacion = value; }
        }

        public string Division
        {
            get { return _Division; }
            set { _Division = value; }
        }

        public string Area
        {
            get { return _Area; }
            set { _Area = value; }
        }

        public string Zona
        {
            get { return _Zona; }
            set { _Zona = value; }
        }

        public string Distrito
        {
            get { return _Distrito; }
            set { _Distrito = value; }
        }

        public string Nombre_Comunidad
        {
            get { return _Nombre_Comunidad; }
            set { _Nombre_Comunidad = value; }
        }

        public string Nodo
        {
            get { return _Nodo; }
            set { _Nodo = value; }
        }

        public string Nota
        {
            get { return _Nota; }
            set { _Nota = value; }
        }

        public string Estado_Caso
        {
            get { return _Estado_Caso; }
            set { _Estado_Caso = value; }
        }

        public string Fecha_Inicial
        {
            get { return _Fecha_Inicial; }
            set { _Fecha_Inicial = value; }
        }
        public string Fecha_Final
        {
            get { return _Fecha_Final; }
            set { _Fecha_Final = value; }
        }

        #endregion
    }
}
