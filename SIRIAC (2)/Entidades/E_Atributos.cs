using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    public class E_Atributos
    {
        #region Atributos
        private int _Id_Atributo;
        private string _Servicio;
        private string _Atributo;
        #endregion
        #region Constructor
        public E_Atributos()
        {
            _Id_Atributo = 0;
            _Servicio = string.Empty;
            _Atributo = string.Empty;
        }
        #endregion
        #region Encapsulamientos
        public int Id_Atributo
        {
            get { return _Id_Atributo; }
            set { _Id_Atributo = value; }
        }
        public string Servicio
        {
            get { return _Servicio; }
            set { _Servicio = value; }
        }
        public string Atributo
        {
            get { return _Atributo; }
            set { _Atributo = value; }
        }
        #endregion
    }
}
