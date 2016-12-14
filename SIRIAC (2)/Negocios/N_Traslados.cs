using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Negocios
{
    public class N_Traslados
    {
        D_Traslados objTraslados = new D_Traslados();
        public int abcIngresos(string pAccion, E_Traslados objE_Traslados)
        {
            return objTraslados.abcTraslados(pAccion, objE_Traslados);
        }
        public DataSet Consulta_Casos_Abiertos_Traslados(string pNombre_Linea)
        {
            return objTraslados.Consulta_Casos_Abiertos_Traslados(pNombre_Linea);
        }
        public DataSet Selecciona_Maximo_Ingreso_Traslados(double p_Cuenta)
        {
            return objTraslados.Selecciona_Maximo_Ingreso_Traslados(p_Cuenta);
        }
        public DataSet Consulta_Cuenta_Traslados(double p_Cuenta)
        {
            return objTraslados.Consulta_Cuenta_Traslados(p_Cuenta);
        }
        public DataSet Consulta_Casos_Escalados_Traslados()
        {
            return objTraslados.Consulta_Casos_Escalados_Traslados();
        }
        public DataSet Consulta_Casos_Abiertos_Id(double pId_Ingreso)
        {
            return objTraslados.Consulta_Casos_Abiertos_Id(pId_Ingreso);
        }
        public DataSet Consulta_Casos_Abiertos_Cuenta(double pCuenta)
        {
            return objTraslados.Consulta_Casos_Abiertos_Cuenta(pCuenta);
        }






























        public DataSet Consulta_Admin_Solicitudes_Crear_Direccion(string pFecha_Inicial, string pFecha_Final)
        {
            return objTraslados.Consulta_Admin_Solicitudes_Crear_Direccion(pFecha_Inicial, pFecha_Final);
        }
    }
}
