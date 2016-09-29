using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    public class E_Estado_Casos
    {
        #region Atributos
        private int _Id_Estado;
        private string _Estado;
        #endregion
        #region Constructor
        public E_Estado_Casos() {
            _Id_Estado = 0;
            _Estado = string.Empty;
        }
        #endregion
        #region Encapsulamientos
        public int Id_Estado
        {
            get { return _Id_Estado; }
            set { _Id_Estado = value; }
        }
        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
        #endregion

    }
}
