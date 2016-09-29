using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class E_Datos_Clientes
    {
        #region Atributos
        private Int64 _Cuenta_Cliente;
        private string _Correo_Electronico;
        private Int64 _Telefono_Personal;
        private string _Fecha_Cumpleanos;
        private string _Rango_Edad;
        private string _Nivel_Estudios;
        private string _Hobbie;
        private string _Twitter;
        private string _Facebook;
        private string _Instagram;
        private string _Otro;
        private string _Numero_Hijos;
        private string _Edad_Hijos;
        #endregion
        #region Construrtor
        public E_Datos_Clientes()
        {
            _Cuenta_Cliente = 0;
            _Correo_Electronico = string.Empty;
            _Telefono_Personal = 0;
            _Fecha_Cumpleanos = string.Empty;
            _Rango_Edad = string.Empty;
            _Nivel_Estudios = string.Empty;
            _Hobbie = string.Empty;
            _Twitter = string.Empty;
            _Facebook = string.Empty;
            _Instagram = string.Empty;
            _Otro = string.Empty;
            _Numero_Hijos = string.Empty;
            _Edad_Hijos = string.Empty;
        }
        #endregion
        #region Encapsulamientos
        public Int64 Cuenta_Cliente
        {
            get { return _Cuenta_Cliente; }
            set { _Cuenta_Cliente = value; }
        }
        public string Correo_Electronico
        {
            get { return _Correo_Electronico; }
            set { _Correo_Electronico = value; }
        }
        public Int64 Telefono_Personal
        {
            get { return _Telefono_Personal; }
            set { _Telefono_Personal = value; }
        }
        public string Fecha_Cumpleanos
        {
            get { return _Fecha_Cumpleanos; }
            set { _Fecha_Cumpleanos = value; }
        }
        public string Rango_Edad
        {
            get { return _Rango_Edad; }
            set { _Rango_Edad = value; }
        }
        public string Nivel_Estudios
        {
            get { return _Nivel_Estudios; }
            set { _Nivel_Estudios = value; }
        }
        public string Hobbie
        {
            get { return _Hobbie; }
            set { _Hobbie = value; }
        }
        public string Twitter
        {
            get { return _Twitter; }
            set { _Twitter = value; }
        }
        public string Facebook
        {
            get { return _Facebook; }
            set { _Facebook = value; }
        }
        public string Instagram
        {
            get { return _Instagram; }
            set { _Instagram = value; }
        }
        public string Otro
        {
            get { return _Otro; }
            set { _Otro = value; }
        }
        public string Numero_Hijos
        {
            get { return _Numero_Hijos; }
            set { _Numero_Hijos = value; }
        }
        public string Edad_Hijos
        {
            get { return _Edad_Hijos; }
            set { _Edad_Hijos = value; }
        }
        #endregion
    }
}
