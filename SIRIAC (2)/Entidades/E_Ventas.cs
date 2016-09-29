using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    public class E_Ventas
    {
        #region Atributos
        private string _Fecha_Gestion;
        private string _Usuario_Gestion;
        private string _Aliado_Gestion;
        private double _Cuenta_Cliente;
        private string _Nombre_Cliente;
        private string _Apellido_Cliente;
        private string _Direccion_Instalacion;
        private string _Direccion_Correspondencia;
        private string _Correo_Electronico;
        private double _Telefono_1;
        private double _Telefono_2;
        private double _Telefono_3;
        private double _Movil_1;
        private double _Movil_2;
        private string _Paquete_Actual;
        private string _Tipo_Contacto;
        private string _Cierre;
        private string _Razon;
        private int _Atributo_1;
        private int _Atributo_2;
        private int _Atributo_3;
        private int _Atributo_4;
        private int _Atributo_5;
        private int _Atributo_6;
        private int _Atributo_7;
        private int _Atributo_8;
        private int _Atributo_9;
        private int _Atributo_10;
        private string _Observaciones;
        private string _Fecha_Inicial;

        
        private string _Fecha_Final;

        
        #endregion
        #region Constructor
        public E_Ventas(){
            _Fecha_Gestion = string.Empty;
            _Usuario_Gestion = string.Empty;
            _Aliado_Gestion = string.Empty;
            _Cuenta_Cliente = 0;
            _Nombre_Cliente = string.Empty;
            _Apellido_Cliente = string.Empty;
            _Direccion_Instalacion = string.Empty;
            _Direccion_Correspondencia = string.Empty;
            _Correo_Electronico = string.Empty;
            _Telefono_1 = 0;
            _Telefono_2 = 0;
            _Telefono_3 = 0;
            _Movil_1 = 0;
            _Movil_2 = 0;
            _Paquete_Actual = string.Empty;
            _Tipo_Contacto = string.Empty;
            _Cierre = string.Empty;
            _Razon = string.Empty;
             _Atributo_1 =0;
             _Atributo_2 = 0;
            _Atributo_3 = 0;
            _Atributo_4 = 0;
            _Atributo_5 = 0;
            _Atributo_6 = 0;
            _Atributo_7 = 0;
            _Atributo_8 = 0;
            _Atributo_9 = 0;
            _Atributo_10 = 0;
            _Observaciones = string.Empty;
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
        public string Correo_Electronico
        {
            get { return _Correo_Electronico; }
            set { _Correo_Electronico = value; }
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
        public string Paquete_Actual
        {
            get { return _Paquete_Actual; }
            set { _Paquete_Actual = value; }
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
        public int Atributo_1
        {
            get { return _Atributo_1; }
            set { _Atributo_1 = value; }
        }
        public int Atributo_2
        {
            get { return _Atributo_2; }
            set { _Atributo_2 = value; }
        }
        public int Atributo_3
        {
            get { return _Atributo_3; }
            set { _Atributo_3 = value; }
        }
        public int Atributo_4
        {
            get { return _Atributo_4; }
            set { _Atributo_4 = value; }
        }
        public int Atributo_5
        {
            get { return _Atributo_5; }
            set { _Atributo_5 = value; }
        }
        public int Atributo_6
        {
            get { return _Atributo_6; }
            set { _Atributo_6 = value; }
        }
        public int Atributo_7
        {
            get { return _Atributo_7; }
            set { _Atributo_7 = value; }
        }
        public int Atributo_8
        {
            get { return _Atributo_8; }
            set { _Atributo_8 = value; }
        }
        public int Atributo_9
        {
            get { return _Atributo_9; }
            set { _Atributo_9 = value; }
        }
        public int Atributo_10
        {
            get { return _Atributo_10; }
            set { _Atributo_10 = value; }
        }
        public string Observaciones
        {
            get { return _Observaciones; }
            set { _Observaciones = value; }
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
