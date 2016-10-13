using Datos;
using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Negocios
{
    public class N_Docsis_Overlap
    {

        D_Docsis_Overlap Consultas_Docsis_Overlap= new D_Docsis_Overlap();
 
        public DataSet Consulta_Admin_Docsis_Overlap(string pFecha_Inicial, string pFecha_Final)
        {
            return Consultas_Docsis_Overlap.Consulta_Admin_Docsis_Overlap(pFecha_Inicial, pFecha_Final);
        }
    }
}
