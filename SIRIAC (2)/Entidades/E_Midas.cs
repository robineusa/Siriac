using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    public class E_Midas
    {
        #region Atributos
        private string _Fecha_de_Gestion;
        private string _Fecha_de_Gestion_2;
        private string _Usuario_de_Gestion;
        private string _Aliado_Gestion;
        private string _Ciudad;
        private string _Nodo;
        private string _Mix_Basico;
        private string _Tipo_Servicio;
        private double _Ciclo_Facturacion;
        private double _Renta;
        private string _Tipo_Tv;
        private double _Velovidad_Internet;
        private double _Cuenta_Cliente;
        private string _Estado_Cuenta;
        private string _Motivo_Desconexion;
        private string _Nombre_Cliente;
        private string _Apellido_1;
        private string _Apellido_2;
        private string _Contrato;
        private double _Telefono_1;
        private double _Telefono_2;
        private double _Telefono_3;
        private double _Movil_1;
        private double _Movil_2;
        private double _Movil_3;
        private string _Estrato;
        private string _Historico;
        private string _Tipo_Hipotesis;
        private string _Tipo_Contacto;
        private string _Gestion;
        private string _Cierre;
        private string _Razon;
        private string _Causa;
        private int _Id_Estado;
        private double _Nps;
        private string _Campana;
        private string _Estado_Campana;
        private string _Satisfaccion;
        private double _Atributo_1;
        private double _Atributo_2;
        private double _Atributo_3;
        private double _Atributo_4;
        private double _Atributo_5;
        private double _Atributo_6;
        private double _Atributo_7;
        private double _Atributo_8;
        private double _Atributo_9;
        private double _Atributo_10;
        private double _Ofrecimiento_1;
        private double _Ofrecimiento_2;
        private double _Ofrecimiento_3;
        private double _Ofrecimiento_4;
        private double _Ofrecimiento_5;
        private double _Ofrecimiento_6;
        private double _Ofrecimiento_7;
        private double _Ofrecimiento_8;
        private double _Ofrecimiento_9;
        private double _Ofrecimiento_10;
#endregion
        #region Constructor
        public E_Midas()
        {
            _Fecha_de_Gestion = string.Empty;
            _Fecha_de_Gestion_2 = string.Empty;
            _Usuario_de_Gestion = string.Empty;
            _Aliado_Gestion = string.Empty;
            _Ciudad = string.Empty;
            _Nodo = string.Empty;
            _Mix_Basico = string.Empty;
            _Tipo_Servicio = string.Empty;
            _Ciclo_Facturacion = 0;
            _Renta = 0;
            _Tipo_Tv = string.Empty;
            _Velovidad_Internet = 0;
            _Cuenta_Cliente = 0;
            _Estado_Cuenta = string.Empty;
            _Motivo_Desconexion = string.Empty;
            _Nombre_Cliente = string.Empty;
            _Apellido_1 = string.Empty;
            _Apellido_2 = string.Empty;
            _Contrato = string.Empty;
            _Telefono_1 = 0;
            _Telefono_2 = 0;
            _Telefono_3 = 0;
            _Movil_1 = 0;
            _Movil_2 = 0;
            _Movil_3 = 0;
            _Estrato = string.Empty;
            _Historico = string.Empty;
            _Tipo_Hipotesis = string.Empty;
            _Tipo_Contacto = string.Empty;
            _Gestion = string.Empty;
            _Cierre = string.Empty;
            _Razon = string.Empty;
            _Causa = string.Empty;
            _Id_Estado = 0;
            _Nps = 0;
            _Campana = string.Empty;
            _Estado_Campana = string.Empty;
            _Satisfaccion = string.Empty;
            _Atributo_1 = 0;
            _Atributo_2 = 0;
            _Atributo_3 = 0;
            _Atributo_4 = 0;
            _Atributo_5 = 0;
            _Atributo_6 = 0;
            _Atributo_7 = 0;
            _Atributo_8 = 0;
            _Atributo_9 = 0;
            _Atributo_10 = 0;
            _Ofrecimiento_1 = 0;
            _Ofrecimiento_2 = 0;
            _Ofrecimiento_3 = 0;
            _Ofrecimiento_4 = 0;
            _Ofrecimiento_5 = 0;
            _Ofrecimiento_6 = 0;
            _Ofrecimiento_7 = 0;
            _Ofrecimiento_8 = 0;
            _Ofrecimiento_9 = 0;
            _Ofrecimiento_10 = 0;
        }
        #endregion
        #region Encapsulamientos
        public string Fecha_de_Gestion
        {
            get { return _Fecha_de_Gestion; }
            set { _Fecha_de_Gestion = value; }
        }

        public string Usuario_de_Gestion
        {
            get { return _Usuario_de_Gestion; }
            set { _Usuario_de_Gestion = value; }
        }

        public string Aliado_Gestion
        {
            get { return _Aliado_Gestion; }
            set { _Aliado_Gestion = value; }
        }

        public string Ciudad
        {
            get { return _Ciudad; }
            set { _Ciudad = value; }
        }

        public string Nodo
        {
            get { return _Nodo; }
            set { _Nodo = value; }
        }

        public string Mix_Basico
        {
            get { return _Mix_Basico; }
            set { _Mix_Basico = value; }
        }

        public string Tipo_Servicio
        {
            get { return _Tipo_Servicio; }
            set { _Tipo_Servicio = value; }
        }

        public double Ciclo_Facturacion
        {
            get { return _Ciclo_Facturacion; }
            set { _Ciclo_Facturacion = value; }
        }

        public double Renta
        { 
            get { return _Renta; }
            set { _Renta = value; }
        }

        public string Tipo_Tv
        {
            get { return _Tipo_Tv; }
            set { _Tipo_Tv = value; }
        }

        public double Velovidad_Internet
        {
            get { return _Velovidad_Internet; }
            set { _Velovidad_Internet = value; }
        }

        public double Cuenta_Cliente
        {
            get { return _Cuenta_Cliente; }
            set { _Cuenta_Cliente = value; }
        }

        public string Estado_Cuenta
        {
            get { return _Estado_Cuenta; }
            set { _Estado_Cuenta = value; }
        }

        public string Motivo_Desconexion
        {
            get { return _Motivo_Desconexion; }
            set { _Motivo_Desconexion = value; }
        }

        public string Nombre_Cliente
        {
            get { return _Nombre_Cliente; }
            set { _Nombre_Cliente = value; }
        }

        public string Apellido_1
        {
            get { return _Apellido_1; }
            set { _Apellido_1 = value; }
        }

        public string Apellido_2
        {
            get { return _Apellido_2; }
            set { _Apellido_2 = value; }
        }

        public string Contrato
        {
            get { return _Contrato; }
            set { _Contrato = value; }
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

        public double Movil_2
        {
            get { return _Movil_2; }
            set { _Movil_2 = value; }
        }

        public double Movil_3
        {
            get { return _Movil_3; }
            set { _Movil_3 = value; }
        }

        public string Estrato
        {
            get { return _Estrato; }
            set { _Estrato = value; }
        }

        public string Historico
        {
            get { return _Historico; }
            set { _Historico = value; }
        }
        public string Tipo_Hipotesis
        {
            get { return _Tipo_Hipotesis; }
            set { _Tipo_Hipotesis = value; }
        }

        public string Tipo_Contacto
        {
            get { return _Tipo_Contacto; }
            set { _Tipo_Contacto = value; }
        }

        public string Gestion
        {
            get { return _Gestion; }
            set { _Gestion = value; }
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

        public string Causa
        {
            get { return _Causa; }
            set { _Causa = value; }
        }

        public int Id_Estado
        {
            get { return _Id_Estado; }
            set { _Id_Estado = value; }
        }

        public double Nps
        {
            get { return _Nps; }
            set { _Nps = value; }
        }

        public string Campana
        {
            get { return _Campana; }
            set { _Campana = value; }
        }

        public string Estado_Campana
        {
            get { return _Estado_Campana; }
            set { _Estado_Campana = value; }
        }

        public string Satisfaccion
        {
            get { return _Satisfaccion; }
            set { _Satisfaccion = value; }
        }

        public double Atributo_1
        {
            get { return _Atributo_1; }
            set { _Atributo_1 = value; }
        }

        public double Atributo_2
        {
            get { return _Atributo_2; }
            set { _Atributo_2 = value; }
        }

        public double Atributo_3
        {
            get { return _Atributo_3; }
            set { _Atributo_3 = value; }
        }

        public double Atributo_4
        {
            get { return _Atributo_4; }
            set { _Atributo_4 = value; }
        }

        public double Atributo_5
        {
            get { return _Atributo_5; }
            set { _Atributo_5 = value; }
        }

        public double Atributo_6
        {
            get { return _Atributo_6; }
            set { _Atributo_6 = value; }
        }

        public double Atributo_7
        {
            get { return _Atributo_7; }
            set { _Atributo_7 = value; }
        }

        public double Atributo_8
        {
            get { return _Atributo_8; }
            set { _Atributo_8 = value; }
        }

        public double Atributo_9
        {
            get { return _Atributo_9; }
            set { _Atributo_9 = value; }
        }

        public double Atributo_10
        {
            get { return _Atributo_10; }
            set { _Atributo_10 = value; }
        }

        public double Ofrecimiento_1
        {
            get { return _Ofrecimiento_1; }
            set { _Ofrecimiento_1 = value; }
        }

        public double Ofrecimiento_2
        {
            get { return _Ofrecimiento_2; }
            set { _Ofrecimiento_2 = value; }
        }

        public double Ofrecimiento_3
        {
            get { return _Ofrecimiento_3; }
            set { _Ofrecimiento_3 = value; }
        }

        public double Ofrecimiento_4
        {
            get { return _Ofrecimiento_4; }
            set { _Ofrecimiento_4 = value; }
        }

        public double Ofrecimiento_5
        {
            get { return _Ofrecimiento_5; }
            set { _Ofrecimiento_5 = value; }
        }

        public double Ofrecimiento_6
        {
            get { return _Ofrecimiento_6; }
            set { _Ofrecimiento_6 = value; }
        }

        public double Ofrecimiento_7
        {
            get { return _Ofrecimiento_7; }
            set { _Ofrecimiento_7 = value; }
        }

        public double Ofrecimiento_8
        {
            get { return _Ofrecimiento_8; }
            set { _Ofrecimiento_8 = value; }
        }

        public double Ofrecimiento_9
        {
            get { return _Ofrecimiento_9; }
            set { _Ofrecimiento_9 = value; }
        }

        public double Ofrecimiento_10
        {
            get { return _Ofrecimiento_10; }
            set { _Ofrecimiento_10 = value; }
        }
        public string Fecha_de_Gestion_2
        {
            get { return _Fecha_de_Gestion_2; }
            set { _Fecha_de_Gestion_2 = value; }
        }

        #endregion
    }
}
