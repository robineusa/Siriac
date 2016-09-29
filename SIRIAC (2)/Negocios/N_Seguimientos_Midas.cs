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
    public class N_Seguimientos_Midas
    {
        D_Seguimientos_Midas Consultas_Seguimientos_Midas = new D_Seguimientos_Midas();
        public int abcSeguimientos_Midas(string pAccion, E_Seguimientos_Midas Obj_Seguimientos_Midas)
        {
            return Consultas_Seguimientos_Midas.abcSeguimientos_Midas(pAccion, Obj_Seguimientos_Midas);
        }
        public DataSet Consulta_Seguimientos_Midas(double pCuenta)
        {
            return Consultas_Seguimientos_Midas.Consulta_Seguimientos_Midas(pCuenta);
        }
    }
}
