using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Servicios
    {
        #region Atributos
        private int _Id_Servicio;
        private string _Servicios;
        #endregion
        #region Constructor
        public E_Servicios() {
            _Id_Servicio = 0;
            _Servicios = string.Empty;
            }
        #endregion
        #region Encapsulamientos
        public int Id_Servicio
        {
            get { return _Id_Servicio; }
            set { _Id_Servicio = value; }
        }
        public string Servicios
        {
            get { return _Servicios; }
            set { _Servicios = value; }
        }
        #endregion
    }
}
