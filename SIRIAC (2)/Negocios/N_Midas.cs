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
    public class N_Midas
    {
        D_Midas Consultas_Midas = new D_Midas();
        public int abcMidas(string pAccion, E_Midas objE_Midas)
        {
            return Consultas_Midas.abcMidas(pAccion, objE_Midas);
        }
        public DataSet Consulta_Temporal_Midas(double pCuenta)
        {
            return Consultas_Midas.Consulta_Temporal_Midas(pCuenta);
        }
        public DataSet Consulta_Registro(double pCuenta)
        {
            return Consultas_Midas.Consulta_Registro(pCuenta);
        }
        public int abcMidas_Log(string pAccion, E_Midas objE_Midas)
        {
            return Consultas_Midas.abcMidas_Log(pAccion, objE_Midas);
        }
        public DataSet Consulta_Midas_Admin(string pFecha_Inicial, string pFecha_Final)
        {
            return Consultas_Midas.Consulta_Midas_Admin(pFecha_Inicial, pFecha_Final);
        }
    }
}
