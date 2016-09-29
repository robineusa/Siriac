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
    public class D_Ciudades:D_Conexion_BD
    {
        public D_Ciudades() { }

        public DataSet Consulta_Departamentos()
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Departamentos]";
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar los Departamentos", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Municipios(int pId_Departamento)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Municipios]";
                cmd.Parameters.AddWithValue("@Id_Departamento", pId_Departamento);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar los Municipiso", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }

    }
}
