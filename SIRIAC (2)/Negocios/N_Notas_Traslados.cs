using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Negocios
{
    public class N_Notas_Traslados
    {
        public D_Notas_Traslados obj_Notas_Traslados = new D_Notas_Traslados();
        public int Inserta_Nota_Traslados(string pAccion, E_Notas_Traslados objE_Notas_Casos_Traslados)
        {
            return obj_Notas_Traslados.Inserta_Nota_Traslado(pAccion, objE_Notas_Casos_Traslados);
        }
        public DataSet Consultar_Traslados_Id(Int64 pId_Traslado)
        {
            return obj_Notas_Traslados.Consultar_Traslados_Id(pId_Traslado);
        }
    }
}
