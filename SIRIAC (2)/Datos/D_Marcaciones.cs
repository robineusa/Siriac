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
   public class D_Marcaciones: D_Conexion_BD
    {
       public D_Marcaciones() { }
       public DataSet Consulta_Marcaciones(string pDescripcion) 
       {
           SqlCommand cmd = new SqlCommand();
           DataSet ds = new DataSet();
           SqlDataAdapter dt = new SqlDataAdapter();
           try
           {
               Abrir_Conexion();
               cmd.Connection = Conexion;
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.CommandText = "[dbo].[Selecciona_Marcaciones]";
               cmd.Parameters.AddWithValue("@Descripcion", pDescripcion);
               dt.SelectCommand = cmd;
               dt.Fill(ds);
           }
           catch (Exception e)
           { throw new Exception("Error al consultar la marcacion", e); }
           finally
           {
               Conexion.Close();
               cmd.Dispose();
           }
           return ds;
       }
       public DataSet Consulta_Marcaciones_Id(int pId_Marcacion)
       {
           SqlCommand cmd = new SqlCommand();
           DataSet ds = new DataSet();
           SqlDataAdapter dt = new SqlDataAdapter();
           try
           {
               Abrir_Conexion();
               cmd.Connection = Conexion;
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.CommandText = "[dbo].[Seleccion_Marcaciones_Id]";
               cmd.Parameters.AddWithValue("@Id_Marcacion", pId_Marcacion);
               dt.SelectCommand = cmd;
               dt.Fill(ds);
           }
           catch (Exception e)
           { throw new Exception("Error al consultar la marcacionpor Id", e); }
           finally
           {
               Conexion.Close();
               cmd.Dispose();
           }
           return ds;
       }
      
    }
}
