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
    public class N_Reincidencias
    {
        D_Reincidencias Consultas_Reincidencias = new D_Reincidencias();
        public DataSet Consulta_Temporal_Cuentas(double pCuenta_Cliente)
        {
            return Consultas_Reincidencias.Consulta_Temporal_Cuentas(pCuenta_Cliente);
        }
        public DataSet Consulta_Cliente_Reincidencias_Gestionado(double pCuenta_Cliente)
        {
            return Consultas_Reincidencias.Consulta_Cliente_Reincidencias_Gestionado (pCuenta_Cliente);
        }
        public int abc_Reincidencias(string pAccion, E_Reincidencias Obj_Reincidencias)
        {
            return Consultas_Reincidencias.abc_Reincidencias(pAccion, Obj_Reincidencias);
        }
        public int abcLog_Reincidencias(string pAccion, E_Reincidencias Obj_Reincidencias)
        {
            return Consultas_Reincidencias.abcLog_Reincidencias(pAccion, Obj_Reincidencias);
        }
        //public DataSet Consulta_Temporal_Cuentas(double pCuenta_Cliente)
        //{
        //    //return Consultas_Reincidencias.(pCuenta_Cliente);
        //}

    }
}
