using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Negocios
{
    public class N_Claro_Video
    {
        D_Claro_Video Consultas_Claro_Video = new D_Claro_Video();
        public DataSet Consulta_Temporal_Cuentas(double pCuenta_Cliente)
        {
            return Consultas_Claro_Video.Consulta_Temporal_Cuentas(pCuenta_Cliente);
        }
        public DataSet Consulta_Cliente_Claro_Video_Gestionado(double pCuenta_Cliente)
        {
            return Consultas_Claro_Video.Consulta_Cliente_Claro_Video_Gestionado(pCuenta_Cliente);
        }
        public int abcClaro_Video(string pAccion, E_Claro_Video Obj_Claro_Video)
        {
            return Consultas_Claro_Video.abcClaro_Video(pAccion, Obj_Claro_Video);
        }
        public int abcLogClaro_Video(string pAccion, E_Claro_Video Obj_Claro_Video)
        {
            return Consultas_Claro_Video.abcLogClaro_Video(pAccion, Obj_Claro_Video);
        }
        public DataSet Consulta_Admin_Claro_Video(string pFecha_Inicial, string pFecha_Final)
        {
            return Consultas_Claro_Video.Consulta_Admin_Claro_Video(pFecha_Inicial, pFecha_Final);
        }
        public int abc_Activacion_Claro_Video(string pAccion, E_Claro_Video Obj_Claro_Video)
        {
            return Consultas_Claro_Video.abc_Activacion_Claro_Video(pAccion, Obj_Claro_Video);
        }
        public DataSet Consulta_Cliente_Activacion_Claro_Video(double pCuenta_Cliente)
        {
            return Consultas_Claro_Video.Consulta_Cliente_Activacion_Claro_Video(pCuenta_Cliente);
        }
        public DataSet Consulta_Falta_Activacion_Claro_Video(double pCuenta)
        {
            return Consultas_Claro_Video.Consulta_Falta_Activacion_Claro_Video(pCuenta);
        }
    }
}
