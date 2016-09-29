using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos;
using Entidades;

namespace Negocios
{
    public class N_Convenio_Electronico
    {
        D_Convenio_Electronico Consultas_Convenio_Electronico = new D_Convenio_Electronico();
        public int abc_Convenioo_Electronico(string pAccion, E_Convenio_Electronico Obj_Convenio_Electronico)
        {
            return Consultas_Convenio_Electronico.abc_Convenioo_Electronico(pAccion,Obj_Convenio_Electronico);
        }
        public DataSet Consulta_Registro(double pCuenta)
        {
            return Consultas_Convenio_Electronico.Consulta_Registro(pCuenta);
        }
        public int abc_Convenioo_Electronico_Log(string pAccion, E_Convenio_Electronico Obj_Convenio_Electronico)
        {
            return Consultas_Convenio_Electronico.abc_Convenioo_Electronico_Log(pAccion, Obj_Convenio_Electronico);
        }
        public DataSet Consulta_Admin_Convenio(string pFecha_Inicial, string pFecha_Final)
        {
            return Consultas_Convenio_Electronico.Consulta_Admin_Convenio(pFecha_Inicial, pFecha_Final);
        }
        public DataSet Consulta_Falta_Convenio(string pCuenta)
        {
            return Consultas_Convenio_Electronico.Consulta_Falta_Convenio(pCuenta);
        }
    }
}
