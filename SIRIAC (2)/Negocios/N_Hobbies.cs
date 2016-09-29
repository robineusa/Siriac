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
    public class N_Hobbies
    {
        public D_Hobbies Obj_Selecciona_Hobbies = new D_Hobbies();
        public DataSet Selecciona_Hobbies() {

            return Obj_Selecciona_Hobbies.Selecciona_Hobbies();
        }
    }
}
