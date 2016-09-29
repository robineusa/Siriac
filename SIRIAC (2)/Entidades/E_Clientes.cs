using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Clientes
    {
        #region Atributos
        private string _Cuenta_Cliente;
        private string _Home_Pass;
        private string _Estado;
        private string _Nombre_Cliente;
        private string _Apellido_Cliente;
        private string _Cedula_Cliente;
        private string _Telefono_Telmex;
        private string _Telefono_1;
        private string _Telefono_2;
        private string _Telefono_3;
        private string _Direccion_Instalacion;
        private string _Correo_Electronico;
        private string _Nodo;
        private string _Red;
        private string _Division;
        private string _Area;
        private string _Zona;
        private string _Distrito;
        private string _Nombre_Comunidad;
        private string _Departamento;
        private string _Estrato;
        private string _Tipo_Cliente;
        private string _Descripcion;
        private string _Grupo_Seg;
        private string _Telefono_Conv;
        #endregion
        #region Constructor
        public E_Clientes()
        {
            _Cuenta_Cliente = string.Empty;
            _Home_Pass = string.Empty;
            _Estado = string.Empty;
            _Nombre_Cliente = string.Empty;
            _Apellido_Cliente = string.Empty;
            _Cedula_Cliente = string.Empty;
            _Telefono_Telmex = string.Empty;
            _Telefono_1 = string.Empty;
            _Telefono_2 = string.Empty;
            _Telefono_3 = string.Empty;
            _Direccion_Instalacion = string.Empty;
            _Correo_Electronico = string.Empty;
            _Nodo = string.Empty;
            _Red = string.Empty;
            _Division = string.Empty;
            _Area = string.Empty;
            _Zona = string.Empty;
            _Distrito = string.Empty;
            _Nombre_Comunidad = string.Empty;
            _Departamento = string.Empty;
            _Estrato = string.Empty;
            _Tipo_Cliente = string.Empty;
            _Descripcion = string.Empty;
            _Grupo_Seg = string.Empty;
            _Telefono_Conv = string.Empty;
        }
        #endregion
        #region Encapsulamientos
        public string Cuenta_Cliente
        {
            get { return _Cuenta_Cliente; }
            set { _Cuenta_Cliente = value; }
        }
        public string Home_Pass
        {
            get { return _Home_Pass; }
            set { _Home_Pass = value; }
        }
        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
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
        public string Cedula_Cliente
        {
            get { return _Cedula_Cliente; }
            set { _Cedula_Cliente = value; }
        }
        public string Telefono_Telmex
        {
            get { return _Telefono_Telmex; }
            set { _Telefono_Telmex = value; }
        }
        public string Telefono_1
        {
            get { return _Telefono_1; }
            set { _Telefono_1 = value; }
        }
        public string Telefono_2
        {
            get { return _Telefono_2; }
            set { _Telefono_2 = value; }
        }
        public string Telefono_3
        {
            get { return _Telefono_3; }
            set { _Telefono_3 = value; }
        }
        public string Direccion_Instalacion
        {
            get { return _Direccion_Instalacion; }
            set { _Direccion_Instalacion = value; }
        }
        public string Correo_Electronico
        {
            get { return _Correo_Electronico; }
            set { _Correo_Electronico = value; }
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
        public string Nombre_Comunidad
        {
            get { return _Nombre_Comunidad; }
            set { _Nombre_Comunidad = value; }
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
        public string Tipo_Cliente
        {
            get { return _Tipo_Cliente; }
            set { _Tipo_Cliente = value; }
        }
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        public string Grupo_Seg
        {
            get { return _Grupo_Seg; }
            set { _Grupo_Seg = value; }
        }
        public string Telefono_Conv
        {
            get { return _Telefono_Conv; }
            set { _Telefono_Conv = value; }
        }
        #endregion
    }
}
