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
    public class N_Datos_Cliente
    {
        public D_Datos_Clientes Obj_Datos_Clientes = new D_Datos_Clientes();
        public DataSet Consulta_Datos_Cliente(Int64 pCuenta_Cliente)
        {
            return Obj_Datos_Clientes.Consulta_Datos_Cliente(pCuenta_Cliente);
        }
        public int acb_Datos_Adicionales_Clientes(string pAccion, E_Datos_Clientes Obj_Datos_Ad_Clientes) {
            return Obj_Datos_Clientes.acb_Datos_Adicionales_Clientes(pAccion, Obj_Datos_Ad_Clientes);
        }
        public DataSet Consulta_Cliente_Back(Int64 pCuenta_Cliente)
        {
            return Obj_Datos_Clientes.Consulta_Cliente_Back(pCuenta_Cliente);
        }
    }
}
