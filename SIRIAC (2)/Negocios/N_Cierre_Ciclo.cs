using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Negocios
{
    public class N_Cierre_Ciclo
    {
        D_Cierre_Ciclo Concultas_Cierre_Ciclo = new D_Cierre_Ciclo();
        public DataSet Consulta_Temporal_Cuentas(string pCuenta_Cliente)
        {
            return Concultas_Cierre_Ciclo.Consulta_Temporal_Cuentas(pCuenta_Cliente);
        }
        public DataSet Consulta_Cliente_Cierre_Ciclo_Gestionado(string pCuenta_Cliente)
        {
            return Concultas_Cierre_Ciclo.Consulta_Cliente_Cierre_Ciclo_Gestionado(pCuenta_Cliente);
        }
        public int abcCierre_Ciclo(string pAccion, E_Cierre_Ciclo Obj_Cierre_Ciclo)
        {
            return Concultas_Cierre_Ciclo.abcCierre_Ciclo(pAccion, Obj_Cierre_Ciclo);
        }
        public int abc_LogCierre_Ciclo(string pAccion, E_Cierre_Ciclo Obj_Cierre_Ciclo)
        {
            return Concultas_Cierre_Ciclo.abc_LogCierre_Ciclo(pAccion, Obj_Cierre_Ciclo);
        }
        public DataSet Consulta_Admin_Cierre_Ciclo(string pFecha_Inicial, string pFecha_Final)
        {
            return Concultas_Cierre_Ciclo.Consulta_Admin_Cierre_Ciclo(pFecha_Inicial, pFecha_Final);
        }
    }
}
