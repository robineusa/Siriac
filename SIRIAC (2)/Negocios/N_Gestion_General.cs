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
    public class N_Gestion_General
    {
        D_Gestion_General Obj_Consultas_de_Gestion = new D_Gestion_General();
        public DataSet Consulta_de_Gestion_Asesor(string pFecha_Inicial, string pFecha_Final, string pUsuario)
        {
            return Obj_Consultas_de_Gestion.Consulta_de_Gestion_Asesor(pFecha_Inicial, pFecha_Final, pUsuario);
        }
        public DataSet Consulta_de_Gestion_Celula(string pFecha_Inicial, string pFecha_Final, string pUsuario)
        {
            return Obj_Consultas_de_Gestion.Consulta_de_Gestion_Celula(pFecha_Inicial, pFecha_Final, pUsuario);
        }
        public DataSet Consulta_de_Gestion_Admin(string pFecha_Inicial, string pFecha_Final)
        {
            return Obj_Consultas_de_Gestion.Consulta_de_Gestion_Admin(pFecha_Inicial, pFecha_Final);
        }
    }
}
