using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Nombre_Linea
    {
        #region Atributos
        private int _Id_Nombre_Linea;
        private string _Nombre_Linea;
        #endregion
        #region Constructor
        public E_Nombre_Linea() {
            _Id_Nombre_Linea = 0;
            _Nombre_Linea = string.Empty;
        }
        #endregion
        #region Encapsulamientos
        public int Id_Nombre_Linea
        {
            get { return _Id_Nombre_Linea; }
            set { _Id_Nombre_Linea = value; }
        }
        public string Nombre_Linea
        {
            get { return _Nombre_Linea; }
            set { _Nombre_Linea = value; }
        }
        #endregion
    }
}
