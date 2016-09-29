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
    public class N_Ingresos
    {
        D_Ingresos objRegistrar_Ingreso = new D_Ingresos();
        public int abcIngresos(string pAccion, E_Ingreso objE_Ingreso)
        {
            return objRegistrar_Ingreso.abcIngresos(pAccion, objE_Ingreso);
        }
        public DataSet Selecciona_Maximo_Ingreso_Cuenta(double p_Cuenta)
        {
            return objRegistrar_Ingreso.Selecciona_Maximo_Ingreso_Cuenta(p_Cuenta);
        }
        public int Inserta_Ingreso()
        {
            return objRegistrar_Ingreso.Inserta_Ingreso();
        }
        public DataSet Marcaciones_Escaladas(double pCuenta, string pMarcacion) {
            return objRegistrar_Ingreso.Marcaciones_Escaladas(pCuenta, pMarcacion);
        }
        public DataSet Casos_Abiertos_Tipificador(double pCuenta) {
            return objRegistrar_Ingreso.Casos_Abiertos_Tipificador(pCuenta);
        }
        public DataSet Casos_Cerrados_Tipificador(double pCuenta)
        {
            return objRegistrar_Ingreso.Casos_Cerrados_Tipificador(pCuenta);
        }
        public DataSet Consulta_Ingreso(double pId_Ingreso) {
            return objRegistrar_Ingreso.Consulta_Ingreso(pId_Ingreso);
        }
        public int Actualiza_Ingreso_Front(double Id_Ingreso, E_Ingreso objE_Ingreso)
        { 
            return objRegistrar_Ingreso.Actualiza_Ingreso_Front(Id_Ingreso, objE_Ingreso);
        }
        public DataSet Consulta_Ingreso_General(double pId_Ingreso)
        {
            return objRegistrar_Ingreso.Consulta_Ingreso_General(pId_Ingreso);
        }
        public DataSet Consulta_Seguimientos_Asesor(string pUsuario)
        {
            return objRegistrar_Ingreso.Consulta_Seguimientos_Asesor(pUsuario);
        }
        public DataSet Consulta_Casos_Abiertos_Celula(string pAliado, string pNombre_Linea)
        {
            return objRegistrar_Ingreso.Consulta_Casos_Abiertos_Celula(pAliado, pNombre_Linea);
        }
        public DataSet Consulta_Casos_Abiertos_Celula_2(string pNombre_Linea)
        {
            return objRegistrar_Ingreso.Consulta_Casos_Abiertos_Celula_2(pNombre_Linea);
        }
        public DataSet Consulta_Casos_Abiertos_Id(double pId_Ingreso)
        {
            return objRegistrar_Ingreso.Consulta_Casos_Abiertos_Id(pId_Ingreso);
        }
        public DataSet Consulta_Casos_Abiertos_Cuenta(double pCuenta)
        {
            return objRegistrar_Ingreso.Consulta_Casos_Abiertos_Cuenta(pCuenta);
        }
        public DataSet Consulta_Usuario_Back(double pId_Ingreso)
        {
            return objRegistrar_Ingreso.Consulta_Usuario_Back(pId_Ingreso);
        }
        public int Actualiza_Usuario_Back(double Id_Ingreso, E_Ingreso objE_Ingreso)
        {
            return objRegistrar_Ingreso.Actualiza_Usuario_Back(Id_Ingreso, objE_Ingreso);
        }
        public DataSet Consulta_Ingreso_Back(double pId_Ingreso)
        {
            return objRegistrar_Ingreso.Consulta_Ingreso_Back(pId_Ingreso);
        }
        public DataSet Consulta_Marcacion_Back(double pId_Ingreso)
        {
            return objRegistrar_Ingreso.Consulta_Marcacion_Back(pId_Ingreso);
        }
        public int Actualiza_Casos_Back(double pId_Ingreso, E_Ingreso Obj_Ingresos)
        {
            return objRegistrar_Ingreso.Actualiza_Casos_Back(pId_Ingreso, Obj_Ingresos);
        }
        public int Semaforo()
        {
         return objRegistrar_Ingreso.Semaforo();
        }
        public DataSet Consulta_Seguimientos_Celula(string pUsuario_Back)
        {
            return objRegistrar_Ingreso.Consulta_Seguimientos_Celula(pUsuario_Back);
        }
        public DataSet Consulta_Admin_Casos_Cuenta(double pCuenta)
        {
            return objRegistrar_Ingreso.Consulta_Admin_Casos_Cuenta(pCuenta);
        }
         public DataSet Consulta_Admin_Casos_Ticket(double pTicket)
        {
            return objRegistrar_Ingreso.Consulta_Admin_Casos_Ticket(pTicket);
        }
         public DataSet Consulta_Admin_Casos_Usuario(string pUsuario)
        {
            return objRegistrar_Ingreso.Consulta_Admin_Casos_Usuario(pUsuario);
        }
         public DataSet Consulta_Admin_Casos_Id(double pId_Ingreso)
         {
             return objRegistrar_Ingreso.Consulta_Admin_Casos_Id(pId_Ingreso);
         }
         public int Actualiza_Ingreso_Celula(double Id_Ingreso, E_Ingreso objE_Ingreso)
         {
             return objRegistrar_Ingreso.Actualiza_Ingreso_Celula(Id_Ingreso, objE_Ingreso);
         }
         public int Actualiza_Ingreso_Back(double Id_Ingreso, E_Ingreso objE_Ingreso)
         {
             return objRegistrar_Ingreso.Actualiza_Ingreso_Back(Id_Ingreso, objE_Ingreso);
         }
         public int Actualiza_Ingreso_Estado(double Id_Ingreso, E_Ingreso objE_Ingreso)
         {
             return objRegistrar_Ingreso.Actualiza_Ingreso_Estado(Id_Ingreso, objE_Ingreso);
         }
         
    }
}
