using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Regleta_Adicionales
    {
        #region Atributos
        private string _Nombre_Tarifa;


        private int _Estrato;


        private Int64 _Renta;

        
        #endregion
        #region Constructor
        public E_Regleta_Adicionales() {
            _Nombre_Tarifa = string.Empty;
            _Estrato = 0;
            _Renta = 0;
        }
        #endregion
        #region Encapsulamientos
        public string Nombre_Tarifa
        {
            get { return _Nombre_Tarifa; }
            set { _Nombre_Tarifa = value; }
        }
        public int Estrato
        {
            get { return _Estrato; }
            set { _Estrato = value; }
        }
        public Int64 Renta
        {
            get { return _Renta; }
            set { _Renta = value; }
        }
        #endregion
    }
}
