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
    public class N_Fraude
    {
        public D_Fraude Consulas_Fraudes = new D_Fraude();
        public DataSet Consulta_Cuenta_Fraude(double pCuenta_Cliente)
        {
            return Consulas_Fraudes.Consulta_Cuenta_Fraude(pCuenta_Cliente);
        }
        public int abcFraudes(string pAccion, E_Fraude objE_Fraude)
        {
            return Consulas_Fraudes.abcFraudes(pAccion, objE_Fraude);
        }
        public int abcLog_Fraudes(string pAccion, E_Fraude objE_Fraude)
        {
            return Consulas_Fraudes.abcLog_Fraudes(pAccion, objE_Fraude);
        }
        public DataSet Consulta_Cuenta_Gestionada_Fraude(double pCuenta_Cliente)
        {
            return Consulas_Fraudes.Consulta_Cuenta_Gestionada_Fraude(pCuenta_Cliente);
        }
    }
}
