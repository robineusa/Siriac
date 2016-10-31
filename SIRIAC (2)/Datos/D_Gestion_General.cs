using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class D_Gestion_General:D_Conexion_BD
    {
        public D_Gestion_General() { }
        public DataSet Consulta_de_Gestion_Asesor(string pFecha_Inicial, string pFecha_Final, string pUsuario)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Gestion_General]";
                cmd.Parameters.AddWithValue("@Fecha_Apertura",pFecha_Inicial);
                cmd.Parameters.AddWithValue("@Fecha_Apertura_2", pFecha_Final);
                cmd.Parameters.AddWithValue("@Usuario_Apertura", pUsuario);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al Seleccionar gestion del asesor", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_de_Gestion_Celula(string pFecha_Inicial, string pFecha_Final, string pUsuario)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Gestion_Celula]";
                cmd.Parameters.AddWithValue("@Fecha_Inicial", pFecha_Inicial);
                cmd.Parameters.AddWithValue("@Fecha_Final", pFecha_Final);
                cmd.Parameters.AddWithValue("@Usuario_Backoffice", pUsuario);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al Seleccionar gestion de la celula", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_de_Gestion_Admin(string pFecha_Inicial, string pFecha_Final, string pAliado)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Gestion_General_Admin]";
                cmd.Parameters.AddWithValue("@Fecha_Apertura", pFecha_Inicial);
                cmd.Parameters.AddWithValue("@Fecha_Apertura_2", pFecha_Final);
                cmd.Parameters.AddWithValue("@Aliado", pAliado);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al Seleccionar gestion general", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
