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
    public class N_Ofrecimientos_Incremento
    {
        public D_Ofrecimientos_Incremento Obj_Incremento_Tarifa = new D_Ofrecimientos_Incremento();
        public int Registro_de_Ofrecimientos(E_Ofrecimientos_Incremento Obj_R_Ofrecimiento) {
            return Obj_Incremento_Tarifa.Registro_de_Ofrecimientos(Obj_R_Ofrecimiento);
        }
    }
}
