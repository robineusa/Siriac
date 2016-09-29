using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Incremento_Tarifa
    {
        #region Atributos
        private Int64 _Cuenta_Cliente;
        private string _Tarifa_Anterior;
        private string _Tarifa_Nueva;
        private Int64 _Incremento_Real;
        private Int64 _Renta_sin_Incremento;
        private Int64 _Nueva_Renta;
        private string _Productos;
        private string _Velocidad_Internet;
        private string _Tipo_Television;
        private string _Servicio_Hd;
        private string _Elegido_Movil;
        private string _Claro_Video;
        private string _Postpago_Movil;
        private string _Ld_30;
        private string _Tecnologia;
        private string _Renta_Tarifa_Vigentes;
        private Int64 _Diferencia;
        private string _Nombre_Tarifa;
        private string _Valor_Llamadas_Comcel;
        private string _Ld_Otros_Operadores;
        private string _Primer_Ofrecimiento;
        private string _Segundo_Ofrecimiento;
        private string _Tercer_Ofrecimiento;
        private string _Cuarto_Ofrecimiento;
        private string _Quinto_Ofrecimiento;
        private string _Sexto_Ofrecimiento;
        private string _Categoria_Comercial;
        private Int64 _Periodo_Incremento;
        private string _Estado;
        #endregion
        #region Constructor
        public E_Incremento_Tarifa()
        {
            _Cuenta_Cliente = 0;
            _Tarifa_Anterior = string.Empty;
            _Tarifa_Nueva = string.Empty;
            _Incremento_Real = 0;
            _Renta_sin_Incremento = 0;
            _Nueva_Renta = 0;
            _Productos = string.Empty;
            _Velocidad_Internet = string.Empty;
            _Tipo_Television = string.Empty;
            _Servicio_Hd = string.Empty;
            _Elegido_Movil = string.Empty;
            _Claro_Video = string.Empty;
            _Postpago_Movil = string.Empty;
            _Ld_30 = string.Empty;
            _Tecnologia = string.Empty;
            _Renta_Tarifa_Vigentes = string.Empty;
            _Diferencia = 0;
            _Nombre_Tarifa = string.Empty;
            _Valor_Llamadas_Comcel = string.Empty;
            _Ld_Otros_Operadores = string.Empty;
            _Primer_Ofrecimiento = string.Empty;
            _Segundo_Ofrecimiento = string.Empty;
            _Tercer_Ofrecimiento = string.Empty;
            _Cuarto_Ofrecimiento = string.Empty;
            _Quinto_Ofrecimiento = string.Empty;
            _Sexto_Ofrecimiento = string.Empty;
            _Categoria_Comercial = string.Empty;
            _Periodo_Incremento = 0;
            _Estado = string.Empty;
        }
        #endregion
        #region Encapsulamientos
        public Int64 Cuenta_Cliente
        {
            get { return _Cuenta_Cliente; }
            set { _Cuenta_Cliente = value; }
        }
        public string Tarifa_Anterior
        {
            get { return _Tarifa_Anterior; }
            set { _Tarifa_Anterior = value; }
        }
        public string Tarifa_Nueva
        {
            get { return _Tarifa_Nueva; }
            set { _Tarifa_Nueva = value; }
        }
        public Int64 Incremento_Real
        {
            get { return _Incremento_Real; }
            set { _Incremento_Real = value; }
        }
        public Int64 Renta_sin_Incremento
        {
            get { return _Renta_sin_Incremento; }
            set { _Renta_sin_Incremento = value; }
        }
        public Int64 Nueva_Renta
        {
            get { return _Nueva_Renta; }
            set { _Nueva_Renta = value; }
        }
        public string Productos
        {
            get { return _Productos; }
            set { _Productos = value; }
        }
        public string Velocidad_Internet
        {
            get { return _Velocidad_Internet; }
            set { _Velocidad_Internet = value; }
        }
        public string Servicio_Hd
        {
            get { return _Servicio_Hd; }
            set { _Servicio_Hd = value; }
        }
        public string Tipo_Television
        {
            get { return _Tipo_Television; }
            set { _Tipo_Television = value; }
        }
        public string Elegido_Movil
        {
            get { return _Elegido_Movil; }
            set { _Elegido_Movil = value; }
        }
        public string Claro_Video
        {
            get { return _Claro_Video; }
            set { _Claro_Video = value; }
        }
        public string Postpago_Movil
        {
            get { return _Postpago_Movil; }
            set { _Postpago_Movil = value; }
        }
        public string Ld_30
        {
            get { return _Ld_30; }
            set { _Ld_30 = value; }
        }
        public string Tecnologia
        {
            get { return _Tecnologia; }
            set { _Tecnologia = value; }
        }
        public string Renta_Tarifa_Vigentes
        {
            get { return _Renta_Tarifa_Vigentes; }
            set { _Renta_Tarifa_Vigentes = value; }
        }
        public Int64 Diferencia
        {
            get { return _Diferencia; }
            set { _Diferencia = value; }
        }
        public string Nombre_Tarifa
        {
            get { return _Nombre_Tarifa; }
            set { _Nombre_Tarifa = value; }
        }
        public string Valor_Llamadas_Comcel
        {
            get { return _Valor_Llamadas_Comcel; }
            set { _Valor_Llamadas_Comcel = value; }
        }
        public string Ld_Otros_Operadores
        {
            get { return _Ld_Otros_Operadores; }
            set { _Ld_Otros_Operadores = value; }
        }
        public string Primer_Ofrecimiento
        {
            get { return _Primer_Ofrecimiento; }
            set { _Primer_Ofrecimiento = value; }
        }
        public string Segundo_Ofrecimiento
        {
            get { return _Segundo_Ofrecimiento; }
            set { _Segundo_Ofrecimiento = value; }
        }
        public string Tercer_Ofrecimiento
        {
            get { return _Tercer_Ofrecimiento; }
            set { _Tercer_Ofrecimiento = value; }
        }
        public string Cuarto_Ofrecimiento
        {
            get { return _Cuarto_Ofrecimiento; }
            set { _Cuarto_Ofrecimiento = value; }
        }
        public string Quinto_Ofrecimiento
        {
            get { return _Quinto_Ofrecimiento; }
            set { _Quinto_Ofrecimiento = value; }
        }
        public string Sexto_Ofrecimiento
        {
            get { return _Sexto_Ofrecimiento; }
            set { _Sexto_Ofrecimiento = value; }
        }
        public string Categoria_Comercial
        {
            get { return _Categoria_Comercial; }
            set { _Categoria_Comercial = value; }
        }
        public Int64 Periodo_Incremento
        {
            get { return _Periodo_Incremento; }
            set { _Periodo_Incremento = value; }
        }
        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        #endregion

    }
}
