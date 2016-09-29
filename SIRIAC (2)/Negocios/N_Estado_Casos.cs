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
    public class N_Estado_Casos
    {
        public D_Estado_Casos Obj_Estado_Casos = new D_Estado_Casos();
        public DataSet Estado_Casos() {
            return Obj_Estado_Casos.Estado_Casos();
        }
        public DataSet Estado_Casos_Outbound()
        {
            return Obj_Estado_Casos.Estado_Casos_Outbound();
        }
    }
}
