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
    public class N_Perfiles
    {
        D_Perfiles Consultas_Perfiles = new D_Perfiles();
        public DataSet Perfil_Usuario()
        {
            return Consultas_Perfiles.Perfil_Usuario();
        }
        public DataSet Aliado_Usuario()
        {
            return Consultas_Perfiles.Aliado_Usuario();
        }
    }
}
