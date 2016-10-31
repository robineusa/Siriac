using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_Docsis_Overlap
    {
        #region Atributos
        private string _Fecha_Gestion;
        private string _Usuario_Gestion;
        private string _Nombre_Usuario_Gestion;
        private string _Aliado_Gestion;
        private string _Operacion_Gestion;
        private string _Nombre_Base;
        private double _Cuenta_Cliente;
        private string _Nombre_Cliente;
        private string _Apellido_Cliente;
        private string _Direccion_Instalacion;
        private string _Direccion_Correspondencia;
        private string _Correo_Electronico;
        private double _Telefono_Telmex;
        private double _Telefono_1;
        private double _Telefono_2;
        private double _Telefono_3;
        private double _Movil_1;
        private double _Movil_2;
        private string _Paquete_Actual;
        private string _Tipo_Contacto;
        private string _Gestion;
        private string _Cierre;
        private string _Razon;
        private string _Observaciones;
        private string _Fecha_Seguimiento;
        private string _Fecha_Inicial;
        private string _Fecha_Final;
        
        #endregion
        #region Constructor
        public E_Docsis_Overlap()
        {
            _Fecha_Gestion = string.Empty;
           _Usuario_Gestion = string.Empty;
            _Nombre_Usuario_Gestion = string.Empty;
            _Aliado_Gestion = string.Empty;
            _Operacion_Gestion = string.Empty;
            _Nombre_Base = string.Empty;
            _Cuenta_Cliente = 0;
            _Nombre_Cliente = string.Empty;
            _Apellido_Cliente = string.Empty;
            _Direccion_Instalacion = string.Empty;
            _Direccion_Correspondencia = string.Empty;
            _Correo_Electronico = string.Empty;
            _Telefono_Telmex = 0;
            _Telefono_1 = 0;
            _Telefono_2 = 0;
            _Telefono_3 = 0;
            _Movil_1 = 0;
            _Movil_1 = 0;
            _Paquete_Actual = string.Empty;
            _Tipo_Contacto = string.Empty;
            _Gestion = string.Empty;
            _Cierre = string.Empty;
            _Razon = string.Empty;
            _Observaciones = string.Empty;
            _Fecha_Seguimiento = string.Empty;
            _Fecha_Inicial = string.Empty;
            _Fecha_Final = string.Empty;
            
        }
        #endregion
        #region Encapsulamientos
        public string Fecha_Gestion
        {
            get
            {
                return _Fecha_Gestion;
            }

            set
            {
                _Fecha_Gestion = value;
            }
        }

        public string Usuario_Gestion
        {
            get
            {
                return _Usuario_Gestion;
            }

            set
            {
                _Usuario_Gestion = value;
            }
        }

        public string Aliado_Gestion
        {
            get
            {
                return _Aliado_Gestion;
            }

            set
            {
                _Aliado_Gestion = value;
            }
        }

        public string Operacion_Gestion
        {
            get
            {
                return _Operacion_Gestion;
            }

            set
            {
                _Operacion_Gestion = value;
            }
        }

        public string Nombre_Base
        {
            get
            {
                return _Nombre_Base;
            }

            set
            {
                _Nombre_Base = value;
            }
        }

        public double Cuenta_Cliente
        {
            get
            {
                return _Cuenta_Cliente;
            }

            set
            {
                _Cuenta_Cliente = value;
            }
        }

        public string Nombre_Cliente
        {
            get
            {
                return _Nombre_Cliente;
            }

            set
            {
                _Nombre_Cliente = value;
            }
        }

        public string Apellido_Cliente
        {
            get
            {
                return _Apellido_Cliente;
            }

            set
            {
                _Apellido_Cliente = value;
            }
        }

        public string Direccion_Instalacion
        {
            get
            {
                return _Direccion_Instalacion;
            }

            set
            {
                _Direccion_Instalacion = value;
            }
        }

        public string Direccion_Correspondencia
        {
            get
            {
                return _Direccion_Correspondencia;
            }

            set
            {
                _Direccion_Correspondencia = value;
            }
        }

        public double Telefono_Telmex
        {
            get
            {
                return _Telefono_Telmex;
            }

            set
            {
                _Telefono_Telmex = value;
            }
        }

        public double Telefono_1
        {
            get
            {
                return _Telefono_1;
            }

            set
            {
                _Telefono_1 = value;
            }
        }

        public double Telefono_2
        {
            get
            {
                return _Telefono_2;
            }

            set
            {
                _Telefono_2 = value;
            }
        }

        public double Telefono_3
        {
            get
            {
                return _Telefono_3;
            }

            set
            {
                _Telefono_3 = value;
            }
        }

        public double Movil_1
        {
            get
            {
                return _Movil_1;
            }

            set
            {
                _Movil_1 = value;
            }
        }

        public double Movil_2
        {
            get
            {
                return _Movil_2;
            }

            set
            {
                _Movil_2 = value;
            }
        }

        public string Paquete_Actual
        {
            get
            {
                return _Paquete_Actual;
            }

            set
            {
                _Paquete_Actual = value;
            }
        }

        public string Tipo_Contacto
        {
            get
            {
                return _Tipo_Contacto;
            }

            set
            {
                _Tipo_Contacto = value;
            }
        }

        public string Cierre
        {
            get
            {
                return _Cierre;
            }

            set
            {
                _Cierre = value;
            }
        }

        public string Razon
        {
            get
            {
                return _Razon;
            }

            set
            {
                _Razon = value;
            }
        }

        public string Observaciones
        {
            get
            {
                return _Observaciones;
            }

            set
            {
                _Observaciones = value;
            }
        }

        public string Fecha_Seguimiento
        {
            get
            {
                return _Fecha_Seguimiento;
            }

            set
            {
                _Fecha_Seguimiento = value;
            }
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

        public string Correo_Electronico
        {
            get
            {
                return _Correo_Electronico;
            }

            set
            {
                _Correo_Electronico = value;
            }
        }

        public string Nombre_Usuario_Gestion
        {
            get
            {
                return _Nombre_Usuario_Gestion;
            }

            set
            {
                _Nombre_Usuario_Gestion = value;
            }
        }

        public string Gestion
        {
            get
            {
                return _Gestion;
            }

            set
            {
                _Gestion = value;
            }
        }
        #endregion
    }
}
