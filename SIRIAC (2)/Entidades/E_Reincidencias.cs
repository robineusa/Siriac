using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Reincidencias
    {
        #region Atributos
        private string _Fecha_Gestion;
        //private string _Hora_Gestion;
        private string _Usuario_Gestion;
        private string _Nombre_Usuario_Gestion;
        private string _Aliado_Gestion;
        private string _Operacion_Gestion;
        private double _Cuenta_Cliente;
        private string _Nombre_Cliente;
        private string _Apellido_Cliente;
        private string _Direccion_Instalacion;
        private string _Direccion_Correspondencia;
        private double _Telefono_Telmex;
        private double _Telefono_1;
        private double _Telefono_2;
        private double _Telefono_3;
        private double _Movil_1;
        private double _Movil_2;
        private string _Paquete_Actual;
        private string _Correo_Actual;
        private string _Tipo_Contacto;
        private string _Gestion;
        private string _Cierre;
        private string _Razon;
        private string _Nuevo_Correo;
        private string _Direccion_de_Correspondencia_Nueva;
        private string _Fecha_Inicial;
        private string _Fecha_Final;
        private string _Motivo_Reincidencia;
        private string _Razon_Varicacion_Tarifa;
        private string _ofrecimiento_1;
        private string _ofrecimiento_2;
        private string _ofrecimiento_3;
        private int _Atributo_1;
        private int _Atributo_2;
        private int _Atributo_3;
        private string _Observaciones;

        #endregion
        #region Constructor
        public E_Reincidencias()
        {
            _Fecha_Gestion = string.Empty;
            _Usuario_Gestion = string.Empty;
            _Nombre_Usuario_Gestion = string.Empty;
            _Aliado_Gestion = string.Empty;
            _Operacion_Gestion = string.Empty;
            _Cuenta_Cliente = 0;
            _Nombre_Cliente = string.Empty;
            _Apellido_Cliente = string.Empty;
            _Direccion_Instalacion = string.Empty;
            _Direccion_Correspondencia = string.Empty;
            _Telefono_Telmex = 0;
            _Telefono_1 = 0;
            _Telefono_2 = 0;
            _Telefono_3 = 0;
            _Movil_1 = 0;
            _Movil_2 = 0;
            _Correo_Actual = string.Empty;
            _Tipo_Contacto = string.Empty;
            _Cierre = string.Empty;
            _Razon = string.Empty;
            _Nuevo_Correo = string.Empty;
            _Direccion_de_Correspondencia_Nueva = string.Empty;
            _Fecha_Inicial = string.Empty;
            _Fecha_Final = string.Empty;
            _Paquete_Actual = string.Empty;
            _Gestion = string.Empty;
            _Motivo_Reincidencia = string.Empty;
            _Razon_Varicacion_Tarifa = string.Empty;
            _Observaciones = string.Empty;
            _ofrecimiento_1 = string.Empty;
            _ofrecimiento_2 = string.Empty;
            _ofrecimiento_3 = string.Empty;
            _Atributo_1 = 0;
            _Atributo_2 = 0;
            _Atributo_3 = 0;
        }
        #endregion
        #region Encapsulamientos
        public string Fecha_Gestion
        {
            get { return _Fecha_Gestion; }
            set { _Fecha_Gestion = value; }
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
        public string Linea_Gestion
        {
            get { return _Operacion_Gestion; }
            set { _Operacion_Gestion = value; }
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
        public double Movil_1
        {
            get { return _Movil_1; }
            set { _Movil_1 = value; }
        }
        public string Correo_Actual
        {
            get { return _Correo_Actual; }
            set { _Correo_Actual = value; }
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
        public double Movil_2
        {
            get { return _Movil_2; }
            set { _Movil_2 = value; }
        }
        public string Nuevo_Correo
        {
            get { return _Nuevo_Correo; }
            set { _Nuevo_Correo = value; }
        }
        public string Direccion_de_Correspondencia_Nueva
        {
            get { return _Direccion_de_Correspondencia_Nueva; }
            set { _Direccion_de_Correspondencia_Nueva = value; }
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
        public string Nombre_Usuario_Gestion
        {
            get { return _Nombre_Usuario_Gestion; }
            set { _Nombre_Usuario_Gestion = value; }
        }
        public string Paquete_Actual
        {
            get { return _Paquete_Actual; }
            set { _Paquete_Actual = value; }
        }
        public string Gestion
        {
            get { return _Gestion; }
            set { _Gestion = value; }
        }

        public string Motivo_Reincidencia
        {
            get { return _Motivo_Reincidencia; }
            set { _Motivo_Reincidencia = value; }
        }
        public string Razon_Varicacion_Tarifa
        {
            get { return _Razon_Varicacion_Tarifa; }
            set { _Razon_Varicacion_Tarifa = value; }
        }
        public string Observaciones
        {
            get { return _Observaciones; }
            set { _Observaciones = value; }
        }

        public string Ofrecimiento_1
        {
            get
            {
                return _ofrecimiento_1;
            }

            set
            {
                _ofrecimiento_1 = value;
            }
        }

        public string Ofrecimiento_2
        {
            get
            {
                return _ofrecimiento_2;
            }

            set
            {
                _ofrecimiento_2 = value;
            }
        }

        public string Ofrecimiento_3
        {
            get
            {
                return _ofrecimiento_3;
            }

            set
            {
                _ofrecimiento_3 = value;
            }
        }

        public int Atributo_1
        {
            get
            {
                return _Atributo_1;
            }

            set
            {
                _Atributo_1 = value;
            }
        }

        public int Atributo_2
        {
            get
            {
                return _Atributo_2;
            }

            set
            {
                _Atributo_2 = value;
            }
        }

        public int Atributo_3
        {
            get
            {
                return _Atributo_3;
            }

            set
            {
                _Atributo_3 = value;
            }
        }
        #endregion

    }
}
