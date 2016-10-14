using Datos;
using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Negocios
{
    public class N_Docsis_Overlap
    {

        D_Docsis_Overlap Consultas_Docsis_Overlap= new D_Docsis_Overlap();
 
        public DataSet Consulta_Admin_Docsis_Overlap(string pFecha_Inicial, string pFecha_Final)
        {
            return Consultas_Docsis_Overlap.Consulta_Admin_Docsis_Overlap(pFecha_Inicial, pFecha_Final);
        }
        public DataSet Consulta_Temporal_Cuentas(double pCuenta_Cliente)
        {
            return Consultas_Docsis_Overlap.Consulta_Temporal_Cuentas(pCuenta_Cliente);
        }
        public DataSet Consulta_Cuenta_seguimiento(double pCuenta_Cliente)
        {
            return Consultas_Docsis_Overlap.Consulta_Cuenta_Seguimiento(pCuenta_Cliente);
        }
        public DataSet Consulta_Cliente_Docsis_Gestionado(double pCuenta_Cliente)
        {
            return Consultas_Docsis_Overlap.Consulta_Cliente_Docsis_Gestionado(pCuenta_Cliente);
        }
        public int abcDocsis_Overlap(string pAccion, E_Docsis_Overlap Obj_Docsis_Overlap)
        {
            return Consultas_Docsis_Overlap.abcDocsis_Overlap(pAccion, Obj_Docsis_Overlap);
        }
        public int abcLogClaro_Video(string pAccion, E_Docsis_Overlap Obj_Docsis_Overlap)
        {
            return Consultas_Docsis_Overlap.abcLogDocsis_OVerlap(pAccion, Obj_Docsis_Overlap);
        }
    }
}
