using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Negocios
{
    public class N_Mejor_Oferta
    {
        D_Mejor_Oferta Consultas_Mejor_Oferta = new D_Mejor_Oferta();

        public DataSet Consulta_Temporal_Cuentas(double pCuenta_Cliente)
        {
            return Consultas_Mejor_Oferta.Consulta_Temporal_Cuentas(pCuenta_Cliente);
        }
        public DataSet Consulta_Cliente_Mejor_Oferta_Gestionado(double pCuenta_Cliente)
        {
            return Consultas_Mejor_Oferta.Consulta_Cliente_Mejor_Oferta_Gestionado(pCuenta_Cliente);
        }
        public int abcVentas_Inbound(string pAccion, E_Mejor_Oferta Obj_Mejor_Oferta)
        {
            return Consultas_Mejor_Oferta.abcVentas_Inbound(pAccion, Obj_Mejor_Oferta);
        }
        public int abc_LogVentas_Inbound(string pAccion, E_Mejor_Oferta Obj_Mejor_Oferta)
        {
            return Consultas_Mejor_Oferta.abc_LogVentas_Inbound(pAccion, Obj_Mejor_Oferta);
        }
    }
}
