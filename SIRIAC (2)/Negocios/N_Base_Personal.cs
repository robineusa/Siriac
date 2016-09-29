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
    public class N_Base_Personal
    {
        D_Base_Personal Consultas_Personal_Holos = new D_Base_Personal();
        public DataSet Consulta_Informacion_Usuario(string pCedula)
        {
            return Consultas_Personal_Holos.Consulta_Informacion_Usuario(pCedula);
        }
    }
}
