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
    public class N_Regleta_Adicionales 
    {
        D_Regleta_Adicionales Obj_Consultas_Regleta_Adicionales = new D_Regleta_Adicionales();
        public DataSet Regleta_Adicional(int pEstrato)
        {
            return Obj_Consultas_Regleta_Adicionales.Regleta_Adicional(pEstrato);
        }
    }
}
