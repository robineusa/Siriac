using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Cuentas_Genericas
    {
        #region Atributos
        private Int64 _Cuenta_Cliente;
        #endregion
        #region Constructor
        public E_Cuentas_Genericas() {
            _Cuenta_Cliente = 0;
        }
        #endregion
        #region Encapsulamientos
        public Int64 Cuenta_Cliente
        {
            get { return _Cuenta_Cliente; }
            set { _Cuenta_Cliente = value; }
        }
        #endregion
    }
}
