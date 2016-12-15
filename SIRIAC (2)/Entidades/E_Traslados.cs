using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_Traslados
    {
        #region Atributos

        private double _Id_Traslado;
        private double _Cuenta_Cliente;
        private string _Direccion;
        private string _Estrato;
        private string _Nodo;
        private string _Telefono_Celular;
        private string _Telefono_Fijo;
        private string _Fecha_Apertura;
        private string _Hora_Apertura;
        private string _Fecha_Cierre;
        private string _Hora_Cierre;
        private string _Usuario_Apertura;
        private string _Usuario_Cierre;
        private string _Fecha_Ultima_Actualizacion;
        private string _Usuario_Ultima_Actualizacion;
        private string _Hora_Ultima_Actualizacion;
        private string _Razon;
        private string _Subrazon;
        private string _Estado;
        private string _Estado_Backoffice;
        private string _Usuario_Backoffice;
        private string _Fecha_Inicio_Gestion_Back;
        private string _Usuario_Gestion_Outbound;
        private string _Inicio_Gestion_Outbound;
        private string _Aliado_Apertura;
        private string _Nombre_Linea_Ingreso;
        private string _Nombre_Linea_Escalado;
        private string _Fecha_Inicial;
        private string _Fecha_Final;

        #endregion
        #region Constructor
        public E_Traslados()
        {
            _Id_Traslado = 0;
            _Cuenta_Cliente = 0;
            _Direccion = string.Empty;
            _Estrato = string.Empty;
            _Nodo = string.Empty;
            _Telefono_Celular = string.Empty;
            _Telefono_Fijo = string.Empty;
            _Fecha_Apertura = string.Empty;
            _Hora_Apertura = string.Empty;
            _Fecha_Cierre = string.Empty;
            _Hora_Cierre = string.Empty;
            _Usuario_Apertura = string.Empty;
            _Usuario_Cierre = string.Empty;
            _Fecha_Ultima_Actualizacion = string.Empty;
            _Usuario_Ultima_Actualizacion = string.Empty;
            _Hora_Ultima_Actualizacion = string.Empty;
            _Razon = string.Empty;
            _Subrazon = string.Empty;
            _Estado = string.Empty;
            Estado_Backoffice = string.Empty;
            _Usuario_Backoffice = string.Empty;
            Fecha_Inicio_Gestion_Back = string.Empty;
            Usuario_Gestion_Outbound = string.Empty;
            Inicio_Gestion_Outbound = string.Empty;
            _Aliado_Apertura = string.Empty;
            _Nombre_Linea_Ingreso = string.Empty;
            _Nombre_Linea_Escalado = string.Empty;
            Fecha_Inicial = string.Empty;
            Fecha_Final = string.Empty;
        }
        #endregion
        #region Encapsulamientos
        public double Id_Traslado
        {
            get
            {
                return _Id_Traslado;
            }

            set
            {
                _Id_Traslado = value;
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

        public string Direccion
        {
            get
            {
                return _Direccion;
            }

            set
            {
                _Direccion = value;
            }
        }

        public string Estrato
        {
            get
            {
                return _Estrato;
            }

            set
            {
                _Estrato = value;
            }
        }

        public string Nodo
        {
            get
            {
                return _Nodo;
            }

            set
            {
                _Nodo = value;
            }
        }

     
        public string Telefono_Celular
        {
            get
            {
                return _Telefono_Celular;
            }

            set
            {
                _Telefono_Celular = value;
            }
        }

        public string Telefono_Fijo
        {
            get
            {
                return _Telefono_Fijo;
            }

            set
            {
                _Telefono_Fijo = value;
            }
        }

        public string Fecha_Apertura
        {
            get
            {
                return _Fecha_Apertura;
            }

            set
            {
                _Fecha_Apertura = value;
            }
        }

        public string Hora_Apertura
        {
            get
            {
                return _Hora_Apertura;
            }

            set
            {
                _Hora_Apertura = value;
            }
        }

        public string Fecha_Cierre
        {
            get
            {
                return _Fecha_Cierre;
            }

            set
            {
                _Fecha_Cierre = value;
            }
        }

        public string Hora_Cierre
        {
            get
            {
                return _Hora_Cierre;
            }

            set
            {
                _Hora_Cierre = value;
            }
        }

        public string Usuario_Apertura
        {
            get
            {
                return _Usuario_Apertura;
            }

            set
            {
                _Usuario_Apertura = value;
            }
        }

        public string Usuario_Cierre
        {
            get
            {
                return _Usuario_Cierre;
            }

            set
            {
                _Usuario_Cierre = value;
            }
        }

        public string Fecha_Ultima_Actualizacion
        {
            get
            {
                return _Fecha_Ultima_Actualizacion;
            }

            set
            {
                _Fecha_Ultima_Actualizacion = value;
            }
        }

        public string Usuario_Ultima_Actualizacion
        {
            get
            {
                return _Usuario_Ultima_Actualizacion;
            }

            set
            {
                _Usuario_Ultima_Actualizacion = value;
            }
        }

        public string Hora_Ultima_Actualizacion
        {
            get
            {
                return _Hora_Ultima_Actualizacion;
            }

            set
            {
                _Hora_Ultima_Actualizacion = value;
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

        public string Subrazon
        {
            get
            {
                return _Subrazon;
            }

            set
            {
                _Subrazon = value;
            }
        }

        public string Estado
        {
            get
            {
                return _Estado;
            }

            set
            {
                _Estado = value;
            }
        }

        public string Usuario_Backoffice
        {
            get
            {
                return _Usuario_Backoffice;
            }

            set
            {
                _Usuario_Backoffice = value;
            }
        }

        public string Aliado_Apertura
        {
            get
            {
                return _Aliado_Apertura;
            }

            set
            {
                _Aliado_Apertura = value;
            }
        }

        public string Nombre_Linea_Ingreso
        {
            get
            {
                return _Nombre_Linea_Ingreso;
            }

            set
            {
                _Nombre_Linea_Ingreso = value;
            }
        }

        public string Nombre_Linea_Escalado
        {
            get
            {
                return _Nombre_Linea_Escalado;
            }

            set
            {
                _Nombre_Linea_Escalado = value;
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

        public string Estado_Backoffice
        {
            get
            {
                return _Estado_Backoffice;
            }

            set
            {
                _Estado_Backoffice = value;
            }
        }

        public string Fecha_Inicio_Gestion_Back
        {
            get
            {
                return _Fecha_Inicio_Gestion_Back;
            }

            set
            {
                _Fecha_Inicio_Gestion_Back = value;
            }
        }

        public string Usuario_Gestion_Outbound
        {
            get
            {
                return _Usuario_Gestion_Outbound;
            }

            set
            {
                _Usuario_Gestion_Outbound = value;
            }
        }

        public string Inicio_Gestion_Outbound
        {
            get
            {
                return _Inicio_Gestion_Outbound;
            }

            set
            {
                _Inicio_Gestion_Outbound = value;
            }
        }
        #endregion

    }
}
