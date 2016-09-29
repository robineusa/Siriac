using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    public class E_Regleta
    {
        #region Atributos
        private string _Cod_Tarifa_Residencial;
        private string _Cod_Tarifa_Soho;
        private string _Tipo_Original;
        private string _Tipo_Regleta;
        private string _Poblacion;
        private string _Tipo_Tv;
        private string _Internet;
        private string _Voz;
        private string _Hd;
        private string _Pvr;
        private string _Paquete;
        private string _Producto;
        private string _Nombre_Paquete;
        private string _Nombre_Paquete_Final;
        private string _Estrato;
        private double _Tarifa_Tv;
        private double _Tarifa_Claro_Video;
        private double _Tarifa_Internet;
        private double _Tariva_Voz;
        private double _Tarifa_Hd;
        private double _Tarifa_Pvr;
        private double _Tarifa_Hbo_Fox;
        private double _Total_Tarifa;
        private string _Claro_Video;
        private string _Tv_Player;
        private string _Decos;
        private string _Detalle_Decos;
        private string _Campana;
        private string _Descuento_Hd;
        private string _Descuento_Pvr;
        private double _Tarifa_Promo;
        private double _Segunda_Linea;
        #endregion
        #region Constructor
        public E_Regleta() {
            _Cod_Tarifa_Residencial = string.Empty;
            _Cod_Tarifa_Soho = string.Empty;
            _Tipo_Original = string.Empty;
            _Tipo_Regleta = string.Empty;
            _Poblacion = string.Empty;
            _Tipo_Tv = string.Empty;
            _Internet = string.Empty;
            _Voz = string.Empty;
            _Hd = string.Empty;
            _Pvr = string.Empty;
            _Paquete = string.Empty;
            _Producto = string.Empty;
            _Nombre_Paquete = string.Empty;
            _Nombre_Paquete_Final = string.Empty;
            _Estrato = string.Empty;
            _Tarifa_Tv = 0;
            _Tarifa_Claro_Video = 0;
            _Tarifa_Internet = 0;
            _Tariva_Voz = 0;
            _Tarifa_Hd = 0;
            _Tarifa_Pvr = 0;
            _Tarifa_Hbo_Fox = 0;
            _Total_Tarifa = 0;
            _Claro_Video = string.Empty;
            _Tv_Player = string.Empty;
            _Decos = string.Empty;
            _Detalle_Decos = string.Empty;
            _Campana = string.Empty;
            _Descuento_Hd = string.Empty;
            _Descuento_Pvr = string.Empty;
            _Tarifa_Promo = 0;
            _Segunda_Linea = 0;
        }
        #endregion
        #region Encapsulamientos
        public string Cod_Tarifa_Residencial
        {
            get { return _Cod_Tarifa_Residencial; }
            set { _Cod_Tarifa_Residencial = value; }
        }
        public string Cod_Tarifa_Soho
        {
            get { return _Cod_Tarifa_Soho; }
            set { _Cod_Tarifa_Soho = value; }
        }
        public string Tipo_Original
        {
            get { return _Tipo_Original; }
            set { _Tipo_Original = value; }
        }
        public string Tipo_Regleta
        {
            get { return _Tipo_Regleta; }
            set { _Tipo_Regleta = value; }
        }
        public string Poblacion
        {
            get { return _Poblacion; }
            set { _Poblacion = value; }
        }
        public string Tipo_Tv
        {
            get { return _Tipo_Tv; }
            set { _Tipo_Tv = value; }
        }
        public string Internet
        {
            get { return _Internet; }
            set { _Internet = value; }
        }
        public string Voz
        {
            get { return _Voz; }
            set { _Voz = value; }
        }
        public string Hd
        {
            get { return _Hd; }
            set { _Hd = value; }
        }
        public string Pvr
        {
            get { return _Pvr; }
            set { _Pvr = value; }
        }
        public string Paquete
        {
            get { return _Paquete; }
            set { _Paquete = value; }
        }
        public string Producto
        {
            get { return _Producto; }
            set { _Producto = value; }
        }
        public string Nombre_Paquete
        {
            get { return _Nombre_Paquete; }
            set { _Nombre_Paquete = value; }
        }
        public string Nombre_Paquete_Final
        {
            get { return _Nombre_Paquete_Final; }
            set { _Nombre_Paquete_Final = value; }
        }
        public string Estrato
        {
            get { return _Estrato; }
            set { _Estrato = value; }
        }
        public double Tarifa_Tv
        {
            get { return _Tarifa_Tv; }
            set { _Tarifa_Tv = value; }
        }
        public double Tarifa_Claro_Video
        {
            get { return _Tarifa_Claro_Video; }
            set { _Tarifa_Claro_Video = value; }
        }
        public double Tarifa_Internet
        {
            get { return _Tarifa_Internet; }
            set { _Tarifa_Internet = value; }
        }
        public double Tariva_Voz
        {
            get { return _Tariva_Voz; }
            set { _Tariva_Voz = value; }
        }
        public double Tarifa_Hd
        {
            get { return _Tarifa_Hd; }
            set { _Tarifa_Hd = value; }
        }
        public double Tarifa_Pvr
        {
            get { return _Tarifa_Pvr; }
            set { _Tarifa_Pvr = value; }
        }
        public double Tarifa_Hbo_Fox
        {
            get { return _Tarifa_Hbo_Fox; }
            set { _Tarifa_Hbo_Fox = value; }
        }
        public double Total_Tarifa
        {
            get { return _Total_Tarifa; }
            set { _Total_Tarifa = value; }
        }
        public string Claro_Video
        {
            get { return _Claro_Video; }
            set { _Claro_Video = value; }
        }
        public string Tv_Player
        {
            get { return _Tv_Player; }
            set { _Tv_Player = value; }
        }
        public string Decos
        {
            get { return _Decos; }
            set { _Decos = value; }
        }
        public string Detalle_Decos
        {
            get { return _Detalle_Decos; }
            set { _Detalle_Decos = value; }
        }
        public string Campana
        {
            get { return _Campana; }
            set { _Campana = value; }
        }
        public string Descuento_Hd
        {
            get { return _Descuento_Hd; }
            set { _Descuento_Hd = value; }
        }
        public string Descuento_Pvr
        {
            get { return _Descuento_Pvr; }
            set { _Descuento_Pvr = value; }
        }
        public double Tarifa_Promo
        {
            get { return _Tarifa_Promo; }
            set { _Tarifa_Promo = value; }
        }
        public double Segunda_Linea
        {
            get { return _Segunda_Linea; }
            set { _Segunda_Linea = value; }
        }

        #endregion
    }
}
