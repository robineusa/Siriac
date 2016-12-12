using Datos;
using Entidades;
using System;
using System.Collections.Generic;
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
    }
}
