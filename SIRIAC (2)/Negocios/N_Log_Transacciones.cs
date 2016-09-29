using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using Datos;

namespace Negocios
{
    public class N_Log_Transacciones
    {
        public D_Log_Transacciones Registro_Transaccion = new D_Log_Transacciones();
        public int acb_Log_Transacciones(E_Log_Transacciones Obj_Ent_Transacciones) {
            return Registro_Transaccion.acb_Log_Transacciones(Obj_Ent_Transacciones);
        }
    }
}
