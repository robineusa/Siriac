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
     public class N_Marcaciones
    {
         public D_Marcaciones Obj_Datos_Marcaciones = new D_Marcaciones();
         public DataSet Consulta_Marcaciones(string pDescripcion)
         {
             return Obj_Datos_Marcaciones.Consulta_Marcaciones(pDescripcion);
         }
         public DataSet Consulta_Marcaciones_Id(int pId_Marcacion)
         {
             return Obj_Datos_Marcaciones.Consulta_Marcaciones_Id(pId_Marcacion);
         }
    }
}
