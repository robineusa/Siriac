using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_Reportes
    {
        #region Atributos
        private string _Cierre;
        private int _Cantidad;
        private string _Fecha_Inicial;
        private string _Fecha_Final;
        #endregion
        #region Constructor
        public E_Reportes()
        {
            _Cierre = string.Empty;
            _Cantidad = 0;
            _Fecha_Inicial = string.Empty;
            _Fecha_Final = string.Empty;
        }
        #endregion
        #region Encapsulamientos
        public string Cierre
        {
            get { return _Cierre; }
            set { _Cierre = value; }
        }
        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
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
