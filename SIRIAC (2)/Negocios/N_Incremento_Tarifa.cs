using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos;
using Entidades;

namespace Negocios
{
    public class N_Incremento_Tarifa
    {
        public D_Incremento_Tarifa abc_Incrmento_Tarifa = new D_Incremento_Tarifa();
        public DataSet Consulta_Incremento(Int64 pCuenta) {
            return abc_Incrmento_Tarifa.Consulta_Incremento(pCuenta);
        }

    }
}
