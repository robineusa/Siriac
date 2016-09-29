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
    public class D_Buen_Servicio:D_Conexion_BD
    {
        public D_Buen_Servicio() { }
        public int abcBuenServicio(string pAccion, E_Buen_Servicio objE_Buen_Servicio)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abcBuenServicio", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Id_Notificacion", objE_Buen_Servicio.Id_Notificacion);
            cmd.Parameters.AddWithValue("@Fecha_Publicacion", objE_Buen_Servicio.Fecha_Publicacion);
            cmd.Parameters.AddWithValue("@usuario_Publicacion", objE_Buen_Servicio.Usuario_Publicacion);
            cmd.Parameters.AddWithValue("@Imagen_Publicacion", objE_Buen_Servicio.Imagen_Notificacion);
            cmd.Parameters.AddWithValue("@Nombre_Imagen", objE_Buen_Servicio.Nombre_Imagen);
            cmd.Parameters.AddWithValue("@Link_Direccionamiento", objE_Buen_Servicio.Link_Direccionamiento);
            cmd.Parameters.AddWithValue("@Descripcion", objE_Buen_Servicio.Descripcion);
            cmd.Parameters.AddWithValue("@Aliado_Destino", objE_Buen_Servicio.Aliado_Destino);
            cmd.Parameters.AddWithValue("@Perfil_Destino", objE_Buen_Servicio.Perfil_Destino);
            cmd.Parameters.AddWithValue("@Nombre_Linea_Destino", objE_Buen_Servicio.Operacion_Destino);
            cmd.Parameters.AddWithValue("@Estado_Publicacion", objE_Buen_Servicio.Estado_Publicacion);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar almacenar,modificar o eliminar datos de la tabla de notificaciones buen servicio", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public DataSet Consulta_Imagen_Buen_Servicio(int Id_Imagen)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Admin_Imagen_BS]";
                cmd.Parameters.AddWithValue("@Id_Notificacion", Id_Imagen);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar la imagen", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Imagen_General_Buen_Servicio()
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Admin_Imagen_Genral_BS]";
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar la imagen", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Notificaciones(string p_Usuario)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Notificaciones]";
                cmd.Parameters.AddWithValue("@USUARIO", p_Usuario);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            {throw new Exception("Error al seleccionar las notificaciones", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public int Inserta_Notificacion(E_Buen_Servicio objE_Buen_Servicio)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("Inserta_Notificacion", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_NOTIFICADO", objE_Buen_Servicio.Id_Notificacion);
            cmd.Parameters.AddWithValue("@USUARIO", objE_Buen_Servicio.Usuario);
            cmd.Parameters.AddWithValue("@IMAGEN_VISTA", objE_Buen_Servicio.Imagen_Vista);
            cmd.Parameters.AddWithValue("@NOMBRE_IMAGEN_VISTA", objE_Buen_Servicio.Nombre_Imagen_Vista);
            cmd.Parameters.AddWithValue("@LINK_DIRECCIONAMIENTO", objE_Buen_Servicio.Link_Direccionamiento);
            cmd.Parameters.AddWithValue("@DESCRIPCION_IMAGEN_VISTA", objE_Buen_Servicio.Descripcion_Imagen_Vista);
            cmd.Parameters.AddWithValue("@ALIADO_USUARIO", objE_Buen_Servicio.Aliado_Usuario);
            cmd.Parameters.AddWithValue("@PERFIL_USUARIO", objE_Buen_Servicio.Perfil_Usuario);
            cmd.Parameters.AddWithValue("@NOMBRE_LINEA_USUARIO", objE_Buen_Servicio.Operacion_Usuario);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar guardar el usuario que fue notificado", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
           
            return Resultado;
        }

    }
}
