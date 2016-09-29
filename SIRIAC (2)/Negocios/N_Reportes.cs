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
    public class N_Reportes
    {
        public D_Reportes Consulta_Gestiones = new D_Reportes();
        public SqlDataReader Gestiones()
        {
            return Consulta_Gestiones.Reporte_LI_Cierre();
        }
        public SqlDataReader Reporte_CE_Tipo_Contacto()
        {
          return  Consulta_Gestiones.Reporte_CE_Tipo_Contacto();
        }
        public SqlDataReader Reporte_CE_Cierre()
        {
            return Consulta_Gestiones.Reporte_CE_Cierre();
        }
        public SqlDataReader Reporte_CE_Razon()
        {
            return Consulta_Gestiones.Reporte_CE_Razon();
        }
        public SqlDataReader Reporte_LI_Cierre_F(string pFecha_Inicial, string pFecha_Final)
        {
            return Consulta_Gestiones.Reporte_F_LI_Cierre(pFecha_Inicial, pFecha_Final);
        }
        public SqlDataReader Reporte_CE_Transacciones_Fecha()
        {
            return Consulta_Gestiones.Reporte_CE_Transacciones_Fecha();
        }
        public SqlDataReader Reporte_LI_Tipo_Contacto()
        {
            return Consulta_Gestiones.Reporte_LI_Tipo_Contacto();
        }
        public SqlDataReader Reporte_LI_Tipo_Contacto_F(string pFecha_Inicial, string pFecha_Final)
        {
            return Consulta_Gestiones.Reporte_F_LI_Tipo_Contacto(pFecha_Inicial, pFecha_Final);
        }
        public SqlDataReader Reporte_V_Tipo_Contacto()
        {
            return Consulta_Gestiones.Reporte_V_Tipo_Contacto();
        }
        public SqlDataReader Reporte_V_Cierre()
        {
            return Consulta_Gestiones.Reporte_V_Cierre();
        }
        public SqlDataReader Reporte_V_Razon()
        {
            return Consulta_Gestiones.Reporte_V_Razon();
        }
        public SqlDataReader Reporte_V_Transacciones_Fecha()
        {
            return Consulta_Gestiones.Reporte_V_Transacciones_Fecha();
        }
        public SqlDataReader Reporte_V_Transacciones_Fecha_Aliado()
        {
            return Consulta_Gestiones.Reporte_V_Transacciones_Fecha_Aliado();
        }
        public SqlDataReader Reporte_V_Transacciones_Fecha_Aliado_Usuarios()
        {
            return Consulta_Gestiones.Reporte_V_Transacciones_Fecha_Aliado_Usuarios();
        }
        public SqlDataReader Reporte_V_Pronostico()
        {
            return Consulta_Gestiones.Reporte_V_Pronostico();
        }
    }
}
