using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios
{
    public class N_Back_Elite
    {
        D_Back_Elite Consultas_Back_Elite = new D_Back_Elite();

        public int abc_Back_Elite(string pAccion, E_Back_Elite Obj_Back_Elite)
        {
            return Consultas_Back_Elite.abc_Back_Elite(pAccion, Obj_Back_Elite);
        }
    }
}
