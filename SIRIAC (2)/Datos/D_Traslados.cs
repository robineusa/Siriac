using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
    public class D_Traslados:D_Conexion_BD
    {
        public D_Traslados() { }

        public int abcTraslados(string pAccion, E_Traslados objE_Traslados)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abcTraslados", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Id_Traslado", objE_Traslados.Id_Traslado);
            cmd.Parameters.AddWithValue("@Cuenta_Cliente", objE_Traslados.Cuenta_Cliente);
            cmd.Parameters.AddWithValue("@Direccion", objE_Traslados.Direccion);
            cmd.Parameters.AddWithValue("@Estrato", objE_Traslados.Estrato);
            cmd.Parameters.AddWithValue("@Nodo", objE_Traslados.Nodo);
            cmd.Parameters.AddWithValue("@Red", objE_Traslados.Red);
            cmd.Parameters.AddWithValue("@Telefono_Celular", objE_Traslados.Telefono_Celular);
            cmd.Parameters.AddWithValue("@Telefono_Fijo", objE_Traslados.Telefono_Fijo);
            cmd.Parameters.AddWithValue("@Fecha_Apertura", objE_Traslados.Fecha_Apertura);
            cmd.Parameters.AddWithValue("@Hora_Apertura", objE_Traslados.Hora_Apertura);
            cmd.Parameters.AddWithValue("@Fecha_Cierre", objE_Traslados.Fecha_Cierre);
            cmd.Parameters.AddWithValue("@Hora_Cierre", objE_Traslados.Hora_Cierre);
            cmd.Parameters.AddWithValue("@Usuario_Apertura", objE_Traslados.Usuario_Apertura);
            cmd.Parameters.AddWithValue("@Usuario_Cierre", objE_Traslados.Usuario_Cierre);
            cmd.Parameters.AddWithValue("@Fecha_Ultima_Actualizacion", objE_Traslados.Fecha_Ultima_Actualizacion);
            cmd.Parameters.AddWithValue("@Usuario_Ultima_Actualizacion", objE_Traslados.Usuario_Ultima_Actualizacion);
            cmd.Parameters.AddWithValue("@Hora_Ultima_Actualizacion", objE_Traslados.Hora_Ultima_Actualizacion);
            cmd.Parameters.AddWithValue("@Razon", objE_Traslados.Razon);
            cmd.Parameters.AddWithValue("@Subrazon", objE_Traslados.Subrazon);
            cmd.Parameters.AddWithValue("@Estado", objE_Traslados.Estado);
            cmd.Parameters.AddWithValue("@Usuario_Backoffice", objE_Traslados.Usuario_Backoffice);
            cmd.Parameters.AddWithValue("@Aliado_Apertura", objE_Traslados.Aliado_Apertura);
            cmd.Parameters.AddWithValue("@Nombre_Linea_Ingreso", objE_Traslados.Nombre_Linea_Ingreso);
            cmd.Parameters.AddWithValue("@Nombre_Linea_Escalado", objE_Traslados.Nombre_Linea_Escalado);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar almacenar,modificar o eliminar datos de la tabla de Traslados", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
<<<<<<< HEAD

        public DataSet Consulta_Casos_Abiertos_Traslados(string pAliado, string pNombre_Linea)
=======
        public DataSet Selecciona_Maximo_Ingreso_Traslados(double p_Cuenta)
>>>>>>> origin/master
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
<<<<<<< HEAD
                cmd.CommandText = "[dbo].[Casos_Abiertos_Traslados]";
                cmd.Parameters.AddWithValue("@Aliado_Apertura", pAliado);
                cmd.Parameters.AddWithValue("@Nombre_Linea_Escalado", pNombre_Linea);
=======
                cmd.CommandText = "[dbo].[Selecciona_Maximo_Id_Ingreso_Traslados]";
                cmd.Parameters.AddWithValue("@Cuenta_Cliente", p_Cuenta);
>>>>>>> origin/master
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
<<<<<<< HEAD
            { throw new Exception("Error al seleccionar los casos abiertos para los traslados", e); }
=======
            { throw new Exception("Error al Seleccionar Maximo Id de Ingreso de traslados", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Cuenta_Traslados(double p_Cuenta)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consultar_Cuenta_Traslado_En_Gestion]";
                cmd.Parameters.AddWithValue("@Cuenta_Cliente", p_Cuenta);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al Seleccionar la cuenta de Ingreso de traslados", e); }
>>>>>>> origin/master
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
