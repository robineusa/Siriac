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
    public class D_Perfiles:D_Conexion_BD
    {
        public D_Perfiles() { }
        public DataSet Perfil_Usuario()
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Perfiles]";
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar el perfil del usuario", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Aliado_Usuario()
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Aliados]";
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar el Aliado", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
