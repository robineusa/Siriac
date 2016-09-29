using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using Datos;


namespace Negocios
{
    public class N_Nombre_Linea
    {
        public D_Nombre_Linea Obj_Nombre_Linea = new D_Nombre_Linea();
        public DataSet Consulta_Nombre_Linea(string pNombre__Linea) {
            return Obj_Nombre_Linea.Consulta_Nombre_Linea(pNombre__Linea);
        }
        public DataSet Nombre_Linea_Celulas()
        {
            return Obj_Nombre_Linea.Nombre_Linea_Celulas();
        }
        public DataSet Selecciona_Nombre_Linea_Celula()
        {
            return Obj_Nombre_Linea.Selecciona_Nombre_Linea_Celula();
        }
        public DataSet Selecciona_Nombre_Linea_Asesor()
        {
            return Obj_Nombre_Linea.Selecciona_Nombre_Linea_Asesor();
        }
    }
}
