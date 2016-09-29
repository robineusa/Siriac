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
    public class N_Rechazos
    {
        D_Rechazos Consultas_Rechazos = new D_Rechazos();
        public DataSet Consulta_Rechazos_Asesor(string pFecha_Inicial, string pFecha_Final, string pUsuario)
        {
            return Consultas_Rechazos.Consulta_Rechazos_Asesor(pFecha_Inicial, pFecha_Final, pUsuario);
        }
        public int Inserta_Rechazo(double pId_Ingreso, E_Rechazos Obj_Rechazos)
        {
            return Consultas_Rechazos.Inserta_Rechazo(pId_Ingreso, Obj_Rechazos);
        }
        public DataSet Consulta_Duplicado_Rechazo(Int64 pId_Ingreso)
        {
            return Consultas_Rechazos.Consulta_Duplicado_Rechazo(pId_Ingreso);
        }
        public DataSet Consulta_Rechazos_Admin(string pFecha_1, string pFecha_2)
        {
            return Consultas_Rechazos.Consulta_Rechazos_Admin(pFecha_1, pFecha_2);
        }
        
    }

}
