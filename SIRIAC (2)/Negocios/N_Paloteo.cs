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
    public class N_Paloteo
    {
        D_Paloteo Consultas_Paloteo = new D_Paloteo();
        public DataSet Consulta_Admin_Paloteo(string pFecha_1, string pFecha_2)
        {
            return Consultas_Paloteo.Consulta_Admin_Paloteo(pFecha_1, pFecha_2);
        }
    }
}
