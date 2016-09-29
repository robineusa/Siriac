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
    public class N_Logistica_Inversa
    {
        D_Logistica_Inversa Consultas_Logistica_Inversa= new D_Logistica_Inversa();
        public int abc_Logistica_Inversa(string pAccion, E_Logistica_Inversa Obj_Logistica_Inversa)
        {
            return Consultas_Logistica_Inversa.abc_Logistica_Inversa(pAccion, Obj_Logistica_Inversa);
        }
        public int abc_Log_Logistica_Inversa(string pAccion, E_Logistica_Inversa Obj_Logistica_Inversa)
        {
            return Consultas_Logistica_Inversa.abc_Log_Logistica_Inversa(pAccion, Obj_Logistica_Inversa);
        }
        public DataSet Consultar_Registro(double pCuenta_Cliente)
        {
            return Consultas_Logistica_Inversa.Consultar_Registro(pCuenta_Cliente);
        }
        public DataSet Reporte_Cierre()
        {
            return Consultas_Logistica_Inversa.Reporte_Cierre();
        }
        public DataSet Consulta_Admin_Logistica(string pFecha_Inicial, string pFecha_Final)
        {
            return Consultas_Logistica_Inversa.Consulta_Admin_Logistica(pFecha_Inicial, pFecha_Final);
        }
    }
}
