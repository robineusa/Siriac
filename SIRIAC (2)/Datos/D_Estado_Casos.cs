using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
     public class D_Estado_Casos: D_Conexion_BD
    {
         public D_Estado_Casos() { }
         public DataSet Estado_Casos() {
             SqlCommand cmd = new SqlCommand();
             DataSet ds = new DataSet();
             SqlDataAdapter dt = new SqlDataAdapter();
             try
             {
                 Abrir_Conexion();
                 cmd.Connection = Conexion;
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.CommandText = "[dbo].[Estado_Casos]";
                 dt.SelectCommand = cmd;
                 dt.Fill(ds);
             }
             catch (Exception e)
             { throw new Exception("Error al traer la lista de estados de los casos", e); }
             finally
             {
                 Conexion.Close();
                 cmd.Dispose();
             }
             return ds;
         }
         public DataSet Estado_Casos_Outbound()
         {
             SqlCommand cmd = new SqlCommand();
             DataSet ds = new DataSet();
             SqlDataAdapter dt = new SqlDataAdapter();
             try
             {
                 Abrir_Conexion();
                 cmd.Connection = Conexion;
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.CommandText = "[dbo].[Estado_Casos_Outbound]";
                 dt.SelectCommand = cmd;
                 dt.Fill(ds);
             }
             catch (Exception e)
             { throw new Exception("Error al traer la lista de estados de los casos", e); }
             finally
             {
                 Conexion.Close();
                 cmd.Dispose();
             }
             return ds;
         }
    }
}
