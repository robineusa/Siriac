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
    public class N_Ciudades
    {
        public D_Ciudades Consultas_Ciudades = new D_Ciudades();
        public DataSet Consulta_Departamentos()
        {
            return Consultas_Ciudades.Consulta_Departamentos();
        }
        public DataSet Consulta_Municipios(int pId_Departamento)
        {
            return Consultas_Ciudades.Consulta_Municipios(pId_Departamento);
        }
    
    }
}
