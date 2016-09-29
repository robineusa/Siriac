using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
    public class D_Reportes : D_Conexion_BD
    {
        public D_Reportes() { }
        public SqlDataReader Reporte_LI_Cierre()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dt;
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Reporte_M_Cierre_LI]";
                //dt.SelectCommand = cmd;
                //dt.Fill(ds);
                dt = cmd.ExecuteReader();
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar el numero de gestiones", e); }
            finally
            {
                //Conexion.Close();
                cmd.Dispose();
            }
            return dt;
        }
        public SqlDataReader Reporte_CE_Tipo_Contacto()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dt;
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Reporte_M_Tipo_Contacto_CE]";
                //dt.SelectCommand = cmd;
                //dt.Fill(ds);
                dt = cmd.ExecuteReader();
            }
            catch (Exception e)
            { throw new Exception("al generar el reporte de convenio electronico, por tipo de contacto", e); }
            finally
            {
                //Conexion.Close();
                cmd.Dispose();
            }
            return dt;
           
        }
        public SqlDataReader Reporte_CE_Cierre()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dt;
            
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Reporte_M_Cierre_CE]";
                //dt.SelectCommand = cmd;
                //dt.Fill(ds);
                dt = cmd.ExecuteReader();
                //Conexion.Close();
                cmd.Dispose();
           
            return dt;
        }
        public SqlDataReader Reporte_CE_Razon()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dt;

            Abrir_Conexion();
            cmd.Connection = Conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[dbo].[Reporte_M_Razon_CE]";
            //dt.SelectCommand = cmd;
            //dt.Fill(ds);
            dt = cmd.ExecuteReader();
            //Conexion.Close();
            cmd.Dispose();

            return dt;
        }
        public SqlDataReader Reporte_F_LI_Cierre(string pFecha_Inicial, string pFecha_Final)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dt;
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Reporte_F_Cierre_LI]";
                cmd.Parameters.AddWithValue("@Fecha_Inicial", pFecha_Inicial);
                cmd.Parameters.AddWithValue("@Fecha_Final", pFecha_Final);
                //dt.SelectCommand = cmd;
                //dt.Fill(ds);
                dt = cmd.ExecuteReader();
            }
            catch (Exception e)
            { throw new Exception("Error al generar el reporte por fechas de Logistica Inversa", e); }
            finally
            {
                //Conexion.Close();
                cmd.Dispose();
            }
            return dt;
        }
        public SqlDataReader Reporte_CE_Transacciones_Fecha()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dt;
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Reporte_M_CE_Fechas]";
                //dt.SelectCommand = cmd;
                //dt.Fill(ds);
                dt = cmd.ExecuteReader();
            }
            catch (Exception e)
            { throw new Exception("Error al generar el reporte por fechas de Convenio electronico", e); }
            finally
            {
                //Conexion.Close();
                cmd.Dispose();
            }
            return dt;
        }
        public SqlDataReader Reporte_LI_Tipo_Contacto()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dt;
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Reporte_M_Tipo_Contacto_LI]";
                //dt.SelectCommand = cmd;
                //dt.Fill(ds);
                dt = cmd.ExecuteReader();
            }
            catch (Exception e)
            { throw new Exception("al generar el reporte de logistica inversa, por tipo de contacto", e); }
            finally
            {
                //Conexion.Close();
                cmd.Dispose();
            }
            return dt;
        }
        public SqlDataReader Reporte_F_LI_Tipo_Contacto(string pFecha_Inicial, string pFecha_Final)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dt;
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Reporte_F_Tipo_Contacto_LI]";
                cmd.Parameters.AddWithValue("@Fecha_Inicial", pFecha_Inicial);
                cmd.Parameters.AddWithValue("@Fecha_Final", pFecha_Final);
                //dt.SelectCommand = cmd;
                //dt.Fill(ds);
                dt = cmd.ExecuteReader();
            }
            catch (Exception e)
            { throw new Exception("Error al generar el reporte por fechas de Logistica Inversa", e); }
            finally
            {
                //Conexion.Close();
                cmd.Dispose();
            }
            return dt;
        }
        public SqlDataReader Reporte_V_Tipo_Contacto()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dt;
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Reporte_M_Tipo_Contacto_V]";
                //dt.SelectCommand = cmd;
                //dt.Fill(ds);
                dt = cmd.ExecuteReader();
            }
            catch (Exception e)
            { throw new Exception("al generar el reporte de Ventas, por tipo de contacto", e); }
            finally
            {
                //Conexion.Close();
                cmd.Dispose();
            }
            return dt;
        }
        public SqlDataReader Reporte_V_Cierre()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dt;
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Reporte_M_Cierre_V]";
                //dt.SelectCommand = cmd;
                //dt.Fill(ds);
                dt = cmd.ExecuteReader();
            }
            catch (Exception e)
            { throw new Exception("al generar el reporte de Ventas, por tipo de Cierre", e); }
            finally
            {
                //Conexion.Close();
                cmd.Dispose();
            }
            return dt;
        }
        public SqlDataReader Reporte_V_Razon()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dt;

            Abrir_Conexion();
            cmd.Connection = Conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[dbo].[Reporte_M_Razon_V]";
            //dt.SelectCommand = cmd;
            //dt.Fill(ds);
            dt = cmd.ExecuteReader();
            //Conexion.Close();
            cmd.Dispose();

            return dt;
        }
        public SqlDataReader Reporte_V_Transacciones_Fecha()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dt;
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Reporte_M_V_Fechas]";
                //dt.SelectCommand = cmd;
                //dt.Fill(ds);
                dt = cmd.ExecuteReader();
            }
            catch (Exception e)
            { throw new Exception("Error al generar el reporte por fechas de Ventas", e); }
            finally
            {
                //Conexion.Close();
                cmd.Dispose();
            }
            return dt;
        }
        public SqlDataReader Reporte_V_Transacciones_Fecha_Aliado()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dt;
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Reporte_M_V_Fechas_Aliado]";
                //dt.SelectCommand = cmd;
                //dt.Fill(ds);
                dt = cmd.ExecuteReader();
            }
            catch (Exception e)
            { throw new Exception("Error al generar el reporte por fechas de Ventas por aliado", e); }
            finally
            {
                //Conexion.Close();
                cmd.Dispose();
            }
            return dt;
        }
        public SqlDataReader Reporte_V_Transacciones_Fecha_Aliado_Usuarios()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dt;
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Reporte_M_V_Fechas_Aliado_Usuario]";
                //dt.SelectCommand = cmd;
                //dt.Fill(ds);
                dt = cmd.ExecuteReader();
            }
            catch (Exception e)
            { throw new Exception("Error al generar el reporte por fechas de Ventas por aliado y usuarios", e); }
            finally
            {
                //Conexion.Close();
                cmd.Dispose();
            }
            return dt;
        }
        public SqlDataReader Reporte_V_Pronostico()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dt;
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Grafico_Pronostico]";
                //dt.SelectCommand = cmd;
                //dt.Fill(ds);
                dt = cmd.ExecuteReader();
            }
            catch (Exception e)
            { throw new Exception("Error al generar el reporte de pronostico", e); }
            finally
            {
                //Conexion.Close();
                cmd.Dispose();
            }
            return dt;
        }
    }
}
