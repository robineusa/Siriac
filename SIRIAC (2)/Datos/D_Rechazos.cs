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
    public class D_Rechazos : D_Conexion_BD
    {
        public D_Rechazos() { }

        public DataSet Consulta_Rechazos_Asesor(string pFecha_Inicial,string pFecha_Final , string pUsuario)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Rechazos_Asesor]";
                cmd.Parameters.AddWithValue("@Fecha_Rechazo", pFecha_Inicial);
                cmd.Parameters.AddWithValue("@Fecha_Rechazo_2", pFecha_Final);
                cmd.Parameters.AddWithValue("@Usuario_Apertura", pUsuario);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar los rechazos del asesor", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public int Inserta_Rechazo(double pId_Ingreso,E_Rechazos Obj_Rechazos)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("Registra_Rechazo", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Ingreso", pId_Ingreso);
            cmd.Parameters.AddWithValue("@Fecha_Creacion", Obj_Rechazos.Fecha_Creacion);
            cmd.Parameters.AddWithValue("@Hora_Creacion", Obj_Rechazos.Hora_de_Creacion);
            cmd.Parameters.AddWithValue("@Usuario_Creacion", Obj_Rechazos.Usuario_Creacion);
            cmd.Parameters.AddWithValue("@Notas_Rechazo", Obj_Rechazos.Notas_del_Rechazo);
            cmd.Parameters.AddWithValue("@Usuario_Rechaza", Obj_Rechazos.Usuario_Rechaza);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar insertar el rechazo", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public DataSet Consulta_Duplicado_Rechazo(Int64 pId_Ingreso)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Duplicado_Rechazo]";
                cmd.Parameters.AddWithValue("@Id_Ingreso", pId_Ingreso);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar los rechazos del asesor", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Rechazos_Admin(string pFecha_1, string pFecha_2)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Rechazos_Admin]";
                cmd.Parameters.AddWithValue("@Fecha_Apertura_1", pFecha_1);
                cmd.Parameters.AddWithValue("@Fecha_Apertura_2", pFecha_2);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar los rechazos en la consulta del administrador", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        
    }
}
