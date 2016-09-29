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
    public class D_Regleta : D_Conexion_BD
    {
        public  D_Regleta(){}
        public DataSet Tipo_Regleta(string pPoblacion, string pEstrato) {

            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Tipo_Regleta]";
                cmd.Parameters.AddWithValue("@Poblacion", pPoblacion);
                cmd.Parameters.AddWithValue("@Estrato", pEstrato);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al Seleccionar el tipo de Regleta", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Paquetes_Triples(string pPoblacion, string pEstrato, string pTipo_Regleta) {

            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Paquetes_Triples]";
                cmd.Parameters.AddWithValue("@Poblacion", pPoblacion);
                cmd.Parameters.AddWithValue("@Estrato", pEstrato);
                cmd.Parameters.AddWithValue("@Tipo_Regleta", pTipo_Regleta);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al Seleccionar los paquetes Triples", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Paquetes_Dobles(string pPoblacion, string pEstrato, string pTipo_Regleta)
        {

            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Paquetes_Dobles]";
                cmd.Parameters.AddWithValue("@Poblacion", pPoblacion);
                cmd.Parameters.AddWithValue("@Estrato", pEstrato);
                cmd.Parameters.AddWithValue("@Tipo_Regleta", pTipo_Regleta);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al Seleccionar los paquetes Dobles", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Paquetes_Sencillos(string pPoblacion, string pEstrato, string pTipo_Regleta)
        {

            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Paquetes_Sencillos]";
                cmd.Parameters.AddWithValue("@Poblacion", pPoblacion);
                cmd.Parameters.AddWithValue("@Estrato", pEstrato);
                cmd.Parameters.AddWithValue("@Tipo_Regleta", pTipo_Regleta);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al Seleccionar los paquetes Sencillos", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Valor_Paquetes(string pPoblacion, string pEstrato, string pTipo_Regleta,string pLista_Paquetes)
        {

            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Valor_Paquete]";
                cmd.Parameters.AddWithValue("@Poblacion", pPoblacion);
                cmd.Parameters.AddWithValue("@Estrato", pEstrato);
                cmd.Parameters.AddWithValue("@Tipo_Regleta", pTipo_Regleta);
                cmd.Parameters.AddWithValue("@Listado_Paquetes", pLista_Paquetes);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al Seleccionar el valor del paquete", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Total_Poblaciones() {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Ciudades_Regleta]";
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al Seleccionar las ciudades de la regleta", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Estratos_Regleta(string pPoblacion)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Estratos_Regleta]";
                cmd.Parameters.AddWithValue("@Poblacion", pPoblacion);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al Seleccionar el estrato", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Detalle_Regleta(string pPoblacion, string pEstrato, string pTipo_Regleta, string pLista_Paquetes)
        {

            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Detalle_Regleta]";
                cmd.Parameters.AddWithValue("@Poblacion", pPoblacion);
                cmd.Parameters.AddWithValue("@Estrato", pEstrato);
                cmd.Parameters.AddWithValue("@Tipo_Regleta", pTipo_Regleta);
                cmd.Parameters.AddWithValue("@Listado_Paquetes", pLista_Paquetes);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al Seleccionar el detalle de la regleta", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
