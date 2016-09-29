using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Fraude
    {
        #region Atributos
        private string _Fecha_gestion;
        private string _Usuario_gestion;
        private string _Aliado_gestion;
        private double _Cuenta_cliente;
        private string _Home_pass;
        private string _Estado;
        private string _Nombre_cliente;
        private string _Apellido_cliente;
        private string _Direccion_instalacion;
        private string _Direccion_correspondencia;
        private double _Telefono_telmex;
        private double _Telefono_1;
        private double _Telefono_2;
        private double _Telefono_3;
        private double _Movil_postpago;
        private string _Correo;
        private string _Nodo;
        private string _Red;
        private string _Division;
        private string _Area;
        private string _Zona;
        private string _Distrito;
        private string _Nombre_comunidad;
        private string _Departamento;
        private string _Estrato;
        private string _Tipo_cliente;
        private string _Servicios;
        private double _Fecha_digitacion;
        private string _Telefonos_fijos_buro;
        private string _Telefonos_moviles_buro;
        private string _Tipo_contacto;
        private string _Cierre;
        private string _Razon;
        private string _Observaciones;
        #endregion
        #region Constructor
        public E_Fraude() {
            _Fecha_gestion = string.Empty;
            _Usuario_gestion = string.Empty;
            _Aliado_gestion = string.Empty;
            _Cuenta_cliente =0;
            _Home_pass = string.Empty;
            _Estado = string.Empty;
            _Nombre_cliente = string.Empty;
            _Apellido_cliente = string.Empty;
            _Direccion_instalacion = string.Empty;
            _Direccion_correspondencia = string.Empty;
            _Telefono_telmex = 0;
            _Telefono_1 = 0;
            _Telefono_2 = 0;
            _Telefono_3 = 0;
            _Movil_postpago = 0;
            _Correo = string.Empty;
            _Nodo = string.Empty;
            _Red = string.Empty;
            _Division = string.Empty;
            _Area = string.Empty;
            _Zona = string.Empty;
            _Distrito = string.Empty;
            _Nombre_comunidad = string.Empty;
            _Departamento = string.Empty;
            _Estrato = string.Empty;
            _Tipo_cliente = string.Empty;
            _Servicios = string.Empty;
            _Fecha_digitacion = 0;
            _Telefonos_fijos_buro = string.Empty;
            _Telefonos_moviles_buro = string.Empty;
            _Tipo_contacto = string.Empty;
            _Cierre = string.Empty;
            _Razon = string.Empty;
            _Observaciones = string.Empty;
        }
        #endregion
        #region Encapsulamientos
        public string Fecha_gestion
        {
            get { return _Fecha_gestion; }
            set { _Fecha_gestion = value; }
        }
        public string Usuario_gestion
        {
            get { return _Usuario_gestion; }
            set { _Usuario_gestion = value; }
        }

        public string Aliado_gestion
        {
            get { return _Aliado_gestion; }
            set { _Aliado_gestion = value; }
        }

        public double Cuenta_cliente
        {
            get { return _Cuenta_cliente; }
            set { _Cuenta_cliente = value; }
        }

        public string Home_pass
        {
            get { return _Home_pass; }
            set { _Home_pass = value; }
        }

        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        public string Nombre_cliente
        {
            get { return _Nombre_cliente; }
            set { _Nombre_cliente = value; }
        }

        public string Apellido_cliente
        {
            get { return _Apellido_cliente; }
            set { _Apellido_cliente = value; }
        }

        public string Direccion_instalacion
        {
            get { return _Direccion_instalacion; }
            set { _Direccion_instalacion = value; }
        }

        public string Direccion_correspondencia
        {
            get { return _Direccion_correspondencia; }
            set { _Direccion_correspondencia = value; }
        }

        public double Telefono_telmex
        {
            get { return _Telefono_telmex; }
            set { _Telefono_telmex = value; }
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

        public double Movil_postpago
        {
            get { return _Movil_postpago; }
            set { _Movil_postpago = value; }
        }

        public string Correo
        {
            get { return _Correo; }
            set { _Correo = value; }
        }

        public string Nodo
        {
            get { return _Nodo; }
            set { _Nodo = value; }
        }

        public string Red
        {
            get { return _Red; }
            set { _Red = value; }
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

        public string Nombre_comunidad
        {
            get { return _Nombre_comunidad; }
            set { _Nombre_comunidad = value; }
        }

        public string Departamento
        {
            get { return _Departamento; }
            set { _Departamento = value; }
        }

        public string Estrato
        {
            get { return _Estrato; }
            set { _Estrato = value; }
        }

        public string Tipo_cliente
        {
            get { return _Tipo_cliente; }
            set { _Tipo_cliente = value; }
        }

        public string Servicios
        {
            get { return _Servicios; }
            set { _Servicios = value; }
        }

        public double Fecha_digitacion
        {
            get { return _Fecha_digitacion; }
            set { _Fecha_digitacion = value; }
        }

        public string Telefonos_fijos_buro
        {
            get { return _Telefonos_fijos_buro; }
            set { _Telefonos_fijos_buro = value; }
        }

        public string Telefonos_moviles_buro
        {
            get { return _Telefonos_moviles_buro; }
            set { _Telefonos_moviles_buro = value; }
        }

        public string Tipo_contacto
        {
            get { return _Tipo_contacto; }
            set { _Tipo_contacto = value; }
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

        public string Observaciones
        {
            get { return _Observaciones; }
            set { _Observaciones = value; }
        }
       


        #endregion
    }
}
