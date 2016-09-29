using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Perfiles
    {
        #region Atributos
        private int _Id_perfil;
        private string _Perfil;
        #endregion
        #region Constructor
        public E_Perfiles()
        {
            _Id_perfil = 0;
            _Perfil = string.Empty;
        }
        #endregion
        #region Encapsulamientos
        public int Id_perfil
        {
            get { return _Id_perfil; }
            set { _Id_perfil = value; }
        }
        public string Perfil
        {
            get { return _Perfil; }
            set { _Perfil = value; }
        }
        #endregion
    }
}
