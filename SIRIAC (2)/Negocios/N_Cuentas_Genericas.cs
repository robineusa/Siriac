using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Datos;
using Entidades;
namespace Negocios
{
    public class N_Cuentas_Genericas
    {
        public D_Cuentas_Genericas Obj_Cliente_Generico = new D_Cuentas_Genericas();
        public DataSet Consultar_Cuenta_Generica(Int64 pCuenta_Cliente) {
            return Obj_Cliente_Generico.Consultar_Cuenta_Generica(pCuenta_Cliente);
        }
    }
}
