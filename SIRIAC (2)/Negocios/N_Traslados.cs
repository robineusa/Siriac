using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Negocios
{
    public class N_Traslados
    {
        D_Traslados objTraslados = new D_Traslados();
        public int abcIngresos(string pAccion, E_Traslados objE_Traslados)
        {
            return objTraslados.abcTraslados(pAccion, objE_Traslados);
        }
        public DataSet Consulta_Casos_Abiertos_Traslados(string pAliado, string pNombre_Linea)
        {
            return objTraslados.Consulta_Casos_Abiertos_Traslados(pAliado, pNombre_Linea);
        }
    }
}
