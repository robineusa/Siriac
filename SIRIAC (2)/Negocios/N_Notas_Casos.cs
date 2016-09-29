using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocios
{
    public class N_Notas_Casos
    {
        public D_Notas_Casos Obj_Inserta_Notas = new D_Notas_Casos();
        public int Inserta_Nota_Inicial(string pAccion, E_Notas_Casos objE_Notas_Casos_Inicial)
        {
            return Obj_Inserta_Notas.Inserta_Nota_Inicial(pAccion, objE_Notas_Casos_Inicial);
        }
        public DataSet Consultar_Notas_Id(Int64 pId_Ingreso) {
            return Obj_Inserta_Notas.Consultar_Notas_Id(pId_Ingreso);
        }
    }
}
