using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
using System.Data;

namespace Negocios
{
    public class N_Ventas
    {
        D_Ventas Consultas_Ventas = new D_Ventas();
        public DataSet Consulta_Temporal_Cuentas(double pCuenta_Cliente)
        {
            return Consultas_Ventas.Consulta_Temporal_Cuentas(pCuenta_Cliente);
        }
        public int abcVentas(string pAccion, E_Ventas Obj_Ventas)
        {
            return Consultas_Ventas.abcVentas(pAccion, Obj_Ventas);
        }
        public DataSet Consulta_Cliente_Venta_Gestionado(double pCuenta_Cliente)
        {
            return Consultas_Ventas.Consulta_Cliente_Venta_Gestionado(pCuenta_Cliente);
        }
        public int abcLog_Ventas(string pAccion, E_Ventas Obj_Ventas)
        {
            return Consultas_Ventas.abcLog_Ventas(pAccion, Obj_Ventas);
        }
        public DataSet Consulta_Admin_Log_Ventas(string pFecha_Inicial, string pFecha_Final)
        {
            return Consultas_Ventas.Consulta_Admin_Log_Ventas(pFecha_Inicial,pFecha_Final);
        }
    }
}
