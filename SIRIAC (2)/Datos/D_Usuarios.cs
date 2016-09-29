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
    public class D_Usuarios : D_Conexion_BD
    {
        public D_Usuarios() { }
        public int abcUsuarios(string pAccion, E_Usuarios objE_Usuarios)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abcUsuarios", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Id_Usuario", objE_Usuarios.Id_Usuario);
            cmd.Parameters.AddWithValue("@Cedula", objE_Usuarios.Cedula);
            cmd.Parameters.AddWithValue("@Nombre", objE_Usuarios.Nombre);
            cmd.Parameters.AddWithValue("@Usuario_RR", objE_Usuarios.Usuario_RR);
            cmd.Parameters.AddWithValue("@Usuario_Agendamiento", objE_Usuarios.Usuario_Agendamiento);
            cmd.Parameters.AddWithValue("@Contrasena", objE_Usuarios.Contrasena);
            cmd.Parameters.AddWithValue("@Id_Rol", objE_Usuarios.Id_Rol);
            cmd.Parameters.AddWithValue("@Id_Nombre_Linea", objE_Usuarios.Id_Nombre_Linea);
            cmd.Parameters.AddWithValue("@Acceso_1", objE_Usuarios.Acceso_1);
            cmd.Parameters.AddWithValue("@Acceso_2", objE_Usuarios.Acceso_2);
            cmd.Parameters.AddWithValue("@Acceso_3", objE_Usuarios.Acceso_3);
            cmd.Parameters.AddWithValue("@Acceso_4", objE_Usuarios.Acceso_4);
            cmd.Parameters.AddWithValue("@Acceso_5", objE_Usuarios.Acceso_5);
            cmd.Parameters.AddWithValue("@Acceso_6", objE_Usuarios.Acceso_6);
            cmd.Parameters.AddWithValue("@Acceso_7", objE_Usuarios.Acceso_7);
            cmd.Parameters.AddWithValue("@Acceso_8", objE_Usuarios.Acceso_8);
            cmd.Parameters.AddWithValue("@Acceso_9", objE_Usuarios.Acceso_9);
            cmd.Parameters.AddWithValue("@Acceso_10", objE_Usuarios.Acceso_10);
            cmd.Parameters.AddWithValue("@Acceso_11", objE_Usuarios.Acceso_11);
            cmd.Parameters.AddWithValue("@Acceso_12", objE_Usuarios.Acceso_12);
            cmd.Parameters.AddWithValue("@Acceso_13", objE_Usuarios.Acceso_13);
            cmd.Parameters.AddWithValue("@Acceso_14", objE_Usuarios.Acceso_14);
            cmd.Parameters.AddWithValue("@Acceso_15", objE_Usuarios.Acceso_15);
            cmd.Parameters.AddWithValue("@Acceso_16", objE_Usuarios.Acceso_16);
            cmd.Parameters.AddWithValue("@Acceso_17", objE_Usuarios.Acceso_17);
            cmd.Parameters.AddWithValue("@Acceso_18", objE_Usuarios.Acceso_18);
            cmd.Parameters.AddWithValue("@Acceso_19", objE_Usuarios.Acceso_19);
            cmd.Parameters.AddWithValue("@Acceso_20", objE_Usuarios.Acceso_20);
            cmd.Parameters.AddWithValue("@Acceso_21", objE_Usuarios.Acceso_21);
            cmd.Parameters.AddWithValue("@Acceso_22", objE_Usuarios.Acceso_22);
            cmd.Parameters.AddWithValue("@Acceso_23", objE_Usuarios.Acceso_23);
            cmd.Parameters.AddWithValue("@Acceso_24", objE_Usuarios.Acceso_24);
            cmd.Parameters.AddWithValue("@Acceso_25", objE_Usuarios.Acceso_25);
            cmd.Parameters.AddWithValue("@Acceso_26", objE_Usuarios.Acceso_26);
            cmd.Parameters.AddWithValue("@Acceso_27", objE_Usuarios.Acceso_27);
            cmd.Parameters.AddWithValue("@Acceso_28", objE_Usuarios.Acceso_28);
            cmd.Parameters.AddWithValue("@Acceso_29", objE_Usuarios.Acceso_29);
            cmd.Parameters.AddWithValue("@Acceso_30", objE_Usuarios.Acceso_30);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar almacenar,modificar o eliminar datos de la tabla de ingresos", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }

        public DataSet Identifica_Usuario(string pUsuario_RR, string pContrasena)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Inicio_de_sesion]";
                cmd.Parameters.AddWithValue("@Usuario_RR", pUsuario_RR);
                cmd.Parameters.AddWithValue("@Contrasena", pContrasena);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al Seleccionar Usuario", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Datos_Usuario(string pUsuario_RR)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Datos_Usuario]";
                cmd.Parameters.AddWithValue("@Usuario_RR", pUsuario_RR);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al Seleccionar Usuario", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public int Actualizar_Contrasena(string pAccion, E_Usuarios objE_Usuarios)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("Actualizar_Contrasena_Usuario", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Contrasena", objE_Usuarios.Contrasena);
            cmd.Parameters.AddWithValue("@Usuario_RR", objE_Usuarios.Usuario_RR);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar actualizar la contrasena", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public DataSet Consulta_Usuarios_Cedula(string pCedula)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Usuarios_Por_Cedula]";
                cmd.Parameters.AddWithValue("@Cedula", pCedula);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al Seleccionar Usuario por cedula", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Informacion_Usuario(double pCedula)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Informacion_Usuarios_Siriac]";
                cmd.Parameters.AddWithValue("@Cedula", pCedula);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al Seleccionar informacion del Usuario", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Nombres_Usuarios_Celula()
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Nombres_Usuarios_Celula]";
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al Seleccionar los usuarios de la celula", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Selecciona_Usuarios_Masivo(string pAliado, string pId_Rol)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Usuarios_Masivo]";
                cmd.Parameters.AddWithValue("@Aliado", pAliado);
                cmd.Parameters.AddWithValue("@Id_Rol", pId_Rol);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al Seleccionar Usuario", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }

    }
}
