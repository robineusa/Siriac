using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Negocios
{
    public class N_Siembra_HD
    {
        D_Siembra_HD Consultas_Siembra_HD = new D_Siembra_HD();
        public DataSet Consulta_Falta_Siembra_HD(double pCuenta)
        {
            return Consultas_Siembra_HD.Consulta_Falta_Siembra_HD(pCuenta);
        }
        public DataSet Consulta_Cliente_Activacion_Siembra_HD(double pCuenta)
        {
            return Consultas_Siembra_HD.Consulta_Cliente_Activacion_Siembra_HD(pCuenta);
        }
        public int abc_Activacion_Siembra_HD(string pAccion, E_Siembra_HD Obj_Entidad_Siembra_HD)
        {
            return Consultas_Siembra_HD.abc_Activacion_Siembra_HD(pAccion, Obj_Entidad_Siembra_HD);
        }
    }
}
