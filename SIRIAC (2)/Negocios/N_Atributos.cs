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
    public class N_Atributos
    {
        D_Atributos Consultas_Maestro_Atributos = new D_Atributos();
        public DataSet Consulta_Servicios()
        {
            return Consultas_Maestro_Atributos.Consulta_Servicios();
        }
        public DataSet Consulta_Atributos(string pServicio)
        {
            return Consultas_Maestro_Atributos.Consulta_Atributos(pServicio);
        }
    }
}
