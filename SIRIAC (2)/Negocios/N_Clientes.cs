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
    public class N_Clientes
    {
        public D_Base_Clientes Obj_Clientes = new D_Base_Clientes();
        public DataSet Consulta_Cliente(string pCuenta_Cliente)
        {
            return Obj_Clientes.Consulta_Cliente(pCuenta_Cliente);
        }
        public DataSet Consulta_Datos_Cliente_Back(double pCuenta_Cliente)
        {
            return Obj_Clientes.Consulta_Datos_Cliente_Back(pCuenta_Cliente);
        }
        public DataSet Consulta_Cliente_Cedula(string pCedula)
        {
            return Obj_Clientes.Consulta_Cliente_Cedula(pCedula);
        }
        public DataSet Consulta_Cliente_Global(string pCedula)
        {
            return Obj_Clientes.Consulta_Cliente_Global(pCedula);
        }
    }
}
