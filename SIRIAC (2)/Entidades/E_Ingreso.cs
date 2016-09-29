using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    public class E_Ingreso
    {
        #region Atributos
        private double _Id_Ingreso;
        private double _Cuenta_Cliente;
        private double _Ticket;
        private string _Fecha_Apertura;
        private string _Hora_Apertura;
        private string _Fecha_Cierre;
        private string _Hora_Cierre;
        private string _Usuario_Apertura;
        private string _Usuario_Cierre;
        private string _Fecha_Ultima_Actualizacion;
        private string _Usuario_Ultima_Actualizacion;
        private string _Hora_Ultima_Actualizacion;
        private string _Macroproceso;
        private string _Proceso;
        private string _Subproceso;
        private string _Marcacion;
        private int _Id_Estado;
        private string _Semaforo;
        private double _Tiempo_Respuesta;
        private string _Usuario_Backoffice;
        private string _Aliado_Apertura;
        private string _Nombre_Linea_Ingreso;
        private string _Nombre_Linea_Escalado;
        private int _Id_Servicio;
        private string _Descripcion_Estado;
        private string _Descripcion_Marcacion;
#endregion
        #region Constructor
        public E_Ingreso()
        {
            _Id_Ingreso = 0;
            _Cuenta_Cliente = 0;
            _Ticket = 0;
            _Fecha_Apertura = string.Empty;
            _Hora_Apertura = string.Empty;
            _Fecha_Cierre = string.Empty;
            _Hora_Cierre = string.Empty;
            _Usuario_Apertura = string.Empty;
            _Usuario_Cierre = string.Empty;
            _Fecha_Ultima_Actualizacion = string.Empty;
            _Usuario_Ultima_Actualizacion = string.Empty;
            _Hora_Ultima_Actualizacion = string.Empty;
            _Macroproceso = string.Empty;
            _Proceso = string.Empty;
            _Subproceso = string.Empty;
            _Marcacion = string.Empty;
            _Id_Estado = 0;
            _Semaforo = string.Empty;
            _Tiempo_Respuesta = 0;
            _Usuario_Backoffice = string.Empty;
            _Aliado_Apertura = string.Empty;
            _Nombre_Linea_Ingreso = string.Empty;
            _Nombre_Linea_Escalado = string.Empty;
            _Id_Servicio = 0;
            _Descripcion_Estado = string.Empty;
            _Descripcion_Marcacion = string.Empty;
        }
        #endregion
        #region Encapsulamientos
        public double Id_Ingreso
        {
            get { return _Id_Ingreso; }
            set { _Id_Ingreso = value; }
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
        public string Fecha_Apertura
        {
            get { return _Fecha_Apertura; }
            set { _Fecha_Apertura = value; }
        }
        public string Hora_Apertura
        {
            get { return _Hora_Apertura; }
            set { _Hora_Apertura = value; }
        }
        public string Fecha_Cierre
        {
            get { return _Fecha_Cierre; }
            set { _Fecha_Cierre = value; }
        }
        public string Hora_Cierre
        {
            get { return _Hora_Cierre; }
            set { _Hora_Cierre = value; }
        }
        public string Usuario_Apertura
        {
            get { return _Usuario_Apertura; }
            set { _Usuario_Apertura = value; }
        }
        public string Usuario_Cierre
        {
            get { return _Usuario_Cierre; }
            set { _Usuario_Cierre = value; }
        }
        public string Fecha_Ultima_Actualizacion
        {
            get { return _Fecha_Ultima_Actualizacion; }
            set { _Fecha_Ultima_Actualizacion = value; }
        }
        public string Usuario_Ultima_Actualizacion
        {
            get { return _Usuario_Ultima_Actualizacion; }
            set { _Usuario_Ultima_Actualizacion = value; }
        }
        public string Hora_Ultima_Actualizacion
        {
            get { return _Hora_Ultima_Actualizacion; }
            set { _Hora_Ultima_Actualizacion = value; }
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
        public int Id_Estado
        {
            get { return _Id_Estado; }
            set { _Id_Estado = value; }
        }
        public string Semaforo
        {
            get { return _Semaforo; }
            set { _Semaforo = value; }
        }
        public double Tiempo_Respuesta
        {
            get { return _Tiempo_Respuesta; }
            set { _Tiempo_Respuesta = value; }
        }
        public string Usuario_Backoffice
        {
            get { return _Usuario_Backoffice; }
            set { _Usuario_Backoffice = value; }
        }
        public string Aliado_Apertura
        {
            get { return _Aliado_Apertura; }
            set { _Aliado_Apertura = value; }
        }
        public string Nombre_Linea_Ingreso
        {
            get { return _Nombre_Linea_Ingreso; }
            set { _Nombre_Linea_Ingreso = value; }
        }
        public string Nombre_Linea_Escalado
        {
            get { return _Nombre_Linea_Escalado; }
            set { _Nombre_Linea_Escalado = value; }
        }
        public int Id_Servicio
        {
            get { return _Id_Servicio; }
            set { _Id_Servicio = value; }
        }
        public string Descripcion_Estado
        {
            get { return _Descripcion_Estado; }
            set { _Descripcion_Estado = value; }
        }
        public string Descripcion_Marcacion
        {
            get { return _Descripcion_Marcacion; }
            set { _Descripcion_Marcacion = value; }
        }
        #endregion
    }
}
