using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Logistica_Inversa
    {
        #region Atributos
        private string _Fecha_Gestion;
        private string _Hora_Gestion;
        private string _Usuario_Gestion;
        private string _Aliado_Gestion;
        private double _Cuenta_Cliente;
        private string _Nombre_Cliente;
        private string _Apellido_Cliente;
        private string _Direccion_Instalacion;
        private string _Direccion_Correspondencia;
        private double _Telefono_Telmex;
        private double _Telefono_1;
        private double _Telefono_2;
        private double _Telefono_3;
        private double _Movil_Portpago;
        private string _Tipo_Contacto;
        private string _Cierre;
        private string _Razon;
        private DateTime _Fecha_Agenda;
        private string _Persona_Contacto;
        private double _Telefono_Contacto;
        private string _Direccion_Alterna;
        private string _Observaciones;
        private double _Cantidad;
        private string _Departamento;
        private string _Ciudad;
        private string _Fecha_Inicial;
        private string _Fecha_Final;
        #endregion
        #region Constructor
        public E_Logistica_Inversa()
        {
            _Fecha_Gestion = string.Empty;
            _Hora_Gestion = string.Empty;
            _Usuario_Gestion = string.Empty;
            _Aliado_Gestion = string.Empty;
            _Cuenta_Cliente = 0;
            _Nombre_Cliente = string.Empty;
            _Apellido_Cliente = string.Empty;
            _Direccion_Instalacion = string.Empty;
            _Direccion_Correspondencia = string.Empty;
            _Telefono_Telmex = 0;
            _Telefono_1 = 0;
            _Telefono_2 = 0;
            _Telefono_3 = 0;
            _Movil_Portpago = 0;
            _Tipo_Contacto = string.Empty;
            _Cierre = string.Empty;
            _Razon = string.Empty;
            _Fecha_Agenda = DateTime.Now;
            _Persona_Contacto = string.Empty;
            _Telefono_Contacto = 0;
            _Direccion_Alterna = string.Empty;
            _Observaciones = string.Empty;
            _Cantidad = 0;
            _Departamento = string.Empty;
            _Ciudad = string.Empty;
            _Fecha_Inicial = string.Empty;
            _Fecha_Final = string.Empty;
        }
        #endregion
        #region Encapsulamientos
        public string Fecha_Gestion
        {
            get { return _Fecha_Gestion; }
            set { _Fecha_Gestion = value; }
        }
        public string Hora_Gestion
        {
            get { return _Hora_Gestion; }
            set { _Hora_Gestion = value; }
        }

        public string Usuario_Gestion
        {
            get { return _Usuario_Gestion; }
            set { _Usuario_Gestion = value; }
        }

        public string Aliado_Gestion
        {
            get { return _Aliado_Gestion; }
            set { _Aliado_Gestion = value; }
        }

        public double Cuenta_Cliente
        {
            get { return _Cuenta_Cliente; }
            set { _Cuenta_Cliente = value; }
        }

        public string Nombre_Cliente
        {
            get { return _Nombre_Cliente; }
            set { _Nombre_Cliente = value; }
        }

        public string Apellido_Cliente
        {
            get { return _Apellido_Cliente; }
            set { _Apellido_Cliente = value; }
        }

        public string Direccion_Instalacion
        {
            get { return _Direccion_Instalacion; }
            set { _Direccion_Instalacion = value; }
        }

        public string Direccion_Correspondencia
        {
            get { return _Direccion_Correspondencia; }
            set { _Direccion_Correspondencia = value; }
        }

        public double Telefono_Telmex
        {
            get { return _Telefono_Telmex; }
            set { _Telefono_Telmex = value; }
        }

        public double Telefono_1
        {
            get { return _Telefono_1; }
            set { _Telefono_1 = value; }
        }

        public double Telefono_2
        {
            get { return _Telefono_2; }
            set { _Telefono_2 = value; }
        }

        public double Telefono_3
        {
            get { return _Telefono_3; }
            set { _Telefono_3 = value; }
        }

        public double Movil_Portpago
        {
            get { return _Movil_Portpago; }
            set { _Movil_Portpago = value; }
        }

        public string Tipo_Contacto
        {
            get { return _Tipo_Contacto; }
            set { _Tipo_Contacto = value; }
        }

        public string Cierre
        {
            get { return _Cierre; }
            set { _Cierre = value; }
        }

        public string Razon
        {
            get { return _Razon; }
            set { _Razon = value; }
        }

        public DateTime Fecha_Agenda
        {
            get { return _Fecha_Agenda; }
            set { _Fecha_Agenda = value; }
        }

        public string Persona_Contacto
        {
            get { return _Persona_Contacto; }
            set { _Persona_Contacto = value; }
        }

        public double Telefono_Contacto
        {
            get { return _Telefono_Contacto; }
            set { _Telefono_Contacto = value; }
        }

        public string Direccion_Alterna
        {
            get { return _Direccion_Alterna; }
            set { _Direccion_Alterna = value; }
        }

        public string Observaciones
        {
            get { return _Observaciones; }
            set { _Observaciones = value; }
        }
        public double Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }
        public string Departamento
        {
            get { return _Departamento; }
            set { _Departamento = value; }
        }
        public string Ciudad
        {
            get { return _Ciudad; }
            set { _Ciudad = value; }
        }

        public string Fecha_Inicial
        {
            get
            {
                return _Fecha_Inicial;
            }

            set
            {
                _Fecha_Inicial = value;
            }
        }

        public string Fecha_Final
        {
            get
            {
                return _Fecha_Final;
            }

            set
            {
                _Fecha_Final = value;
            }
        }
        #endregion
    }
}
