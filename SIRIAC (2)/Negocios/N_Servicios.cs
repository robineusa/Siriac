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
    public class N_Servicios
    {
        public D_Servicios Obj_Selecciona_Servicios = new D_Servicios();
        public DataSet Selecciona_Servicios() {
            return Obj_Selecciona_Servicios.Selecciona_Servicios();
        }

    }
}
