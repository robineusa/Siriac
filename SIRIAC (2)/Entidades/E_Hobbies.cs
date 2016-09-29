using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Hobbies
    {
        #region Atributos
        private string _Hobby_Cliente;
        #endregion
        #region Constructor
        public E_Hobbies() {
            _Hobby_Cliente = string.Empty;
        }
        #endregion
        #region Encapsulamientos
        public string Hobby_Cliente
        {
            get { return _Hobby_Cliente; }
            set { _Hobby_Cliente = value; }
        }
        #endregion
    }
}
