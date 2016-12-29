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
            cmd.Parameters.AddWithValue("@Telefono_Celular", objE_Traslados.Telefono_Celular);
            cmd.Parameters.AddWithValue("@Telefono_Fijo", objE_Traslados.Telefono_Fijo);
            cmd.Parameters.AddWithValue("@Fecha_Apertura", objE_Traslados.Fecha_Apertura);
            cmd.Parameters.AddWithValue("@Hora_Apertura", objE_Traslados.Hora_Apertura);
            cmd.Parameters.AddWithValue("@Usuario_Apertura", objE_Traslados.Usuario_Apertura);
            cmd.Parameters.AddWithValue("@Fecha_Ultima_Actualizacion", objE_Traslados.Fecha_Ultima_Actualizacion);
            cmd.Parameters.AddWithValue("@Usuario_Ultima_Actualizacion", objE_Traslados.Usuario_Ultima_Actualizacion);
            cmd.Parameters.AddWithValue("@Hora_Ultima_Actualizacion", objE_Traslados.Hora_Ultima_Actualizacion);
            cmd.Parameters.AddWithValue("@Razon", objE_Traslados.Razon);
            cmd.Parameters.AddWithValue("@Subrazon", objE_Traslados.Subrazon);
            cmd.Parameters.AddWithValue("@Estado", objE_Traslados.Estado);
            cmd.Parameters.AddWithValue("@Aliado_Apertura", objE_Traslados.Aliado_Apertura);
            cmd.Parameters.AddWithValue("@Nombre_Linea_Ingreso", objE_Traslados.Nombre_Linea_Ingreso);
            cmd.Parameters.AddWithValue("@Nombre_Linea_Escalado", objE_Traslados.Nombre_Linea_Escalado);
           
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
           
                Cerrar_Conexion();
                cmd.Dispose();
            
            return Resultado;
        }
        public DataSet Consulta_Casos_Abiertos_Traslados(string pNombre_Linea)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Casos_Abiertos_Traslados]";
                cmd.Parameters.AddWithValue("@Nombre_Linea_Escalado", pNombre_Linea);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar los casos abiertos para los traslados", e); }
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
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Selecciona_Maximo_Ingreso_Traslados(double p_Cuenta)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Maximo_Id_Ingreso_Traslados]";
                cmd.Parameters.AddWithValue("@Cuenta_Cliente", p_Cuenta);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al Seleccionar Maximo Id de Ingreso de traslados", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Casos_Escalados_Traslados()
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Casos_Escalados_Traslados]";
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar los casos escalados para los traslados", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Casos_Escalados_Traslados_Por_Estado(string pEstado)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Casos_Escalados_Traslados_Por_Estado]";
                cmd.Parameters.AddWithValue("@Estado_Caso", pEstado);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar los casos escalados para los traslados", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Casos_Abiertos_Id(double pId_Traslado)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Traslados_Id]";
                cmd.Parameters.AddWithValue("@Id_Traslado", pId_Traslado);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar los casos abiertos por Id", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Casos_Abiertos_Cuenta(double pCuenta)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Traslados_Cuenta]";
                cmd.Parameters.AddWithValue("@Cuenta_Cliente", pCuenta);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar los casos abiertos por Cuenta", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }

        public DataSet Consulta_Usuario_Back(double pId_Traslado)
            {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "[dbo].[Usuario_Back_Traslados]";
                cmd.Parameters.AddWithValue("@Id_Traslado", pId_Traslado);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)

            { throw new Exception("Error al seleccionar el backoficce del caso", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Usuario_Outbound(double pId_Traslado)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "[dbo].[Usuario_Outbound_Traslados]";
                cmd.Parameters.AddWithValue("@Id_Traslado", pId_Traslado);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)

            { throw new Exception("Error al seleccionar el usuario outbound del caso", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }

        public int Actualiza_Usuario_Back(double Id_Ingreso, E_Traslados objE_Traslados)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("Actualizar_Usuario_Back_Traslados", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Traslado", objE_Traslados.Id_Traslado);
            cmd.Parameters.AddWithValue("@Usuario_Backoffice", objE_Traslados.Usuario_Backoffice);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar actualizar el usuario del back", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public int Actualiza_Usuario_Back_Gestion(double Id_Ingreso, E_Traslados objE_Traslados)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("Actualizar_Usuario_Back_Traslados_Gestion", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Traslado", objE_Traslados.Id_Traslado);
            cmd.Parameters.AddWithValue("@Usuario_Backoffice", objE_Traslados.Usuario_Backoffice);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar actualizar el usuario del back", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public int Actualiza_Usuario_Outbound_Inicio(double Id_Ingreso, E_Traslados objE_Traslados)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("Actualizar_Gestion_Outbound_Inicio", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Traslado", objE_Traslados.Id_Traslado);
            cmd.Parameters.AddWithValue("@Usuario_Onbound", objE_Traslados.Usuario_Gestion_Outbound);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar actualizar el usuario de la gestion outbound", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public int Actualiza_Usuario_Outbound_Gestion(double Id_Ingreso, E_Traslados objE_Traslados)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("Actualizar_Gestion_Outbound_Gestion", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Traslado", objE_Traslados.Id_Traslado);
            cmd.Parameters.AddWithValue("@Usuario_Onbound", objE_Traslados.Usuario_Gestion_Outbound);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar actualizar el usuario de la gestion outbound", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public DataSet Consulta_Admin_Gestion_Crear_Direccion(string pFecha_Inicial, string pFecha_Final)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Admin_Gestion_Crear_Direccion]";
                cmd.Parameters.AddWithValue("@Fecha_Inicial", pFecha_Inicial);
                cmd.Parameters.AddWithValue("@Fecha_Final", pFecha_Final);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al consultar la gestion de creacion de direccion en la tabla de traslados", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Admin_Solicitudes_Crear_Direccion(string pFecha_Inicial, string pFecha_Final)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Admin_Solicitud_Crear_Direccion]";
                cmd.Parameters.AddWithValue("@Fecha_Inicial", pFecha_Inicial);
                cmd.Parameters.AddWithValue("@Fecha_Final", pFecha_Final);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al consultar las solicitudes de creacion de direccion en la tabla de traslados", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Traslados_PorID(double pId_Traslado)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Caso_PorId_Traslados]";
                cmd.Parameters.AddWithValue("@Id_Traslado", pId_Traslado);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al consultar la tabla de traslados por Id", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public int Actualizar_Traslado_Cierre(string pAccion, E_Traslados objE_Traslados)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("Actualizar_Caso_Cierre_Back_Traslados", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Id_Traslado", objE_Traslados.Id_Traslado);
            cmd.Parameters.AddWithValue("@Fecha_Cierre", objE_Traslados.Fecha_Cierre);
            cmd.Parameters.AddWithValue("@Hora_Cierre", objE_Traslados.Hora_Cierre);
            cmd.Parameters.AddWithValue("@Usuario_Cierre", objE_Traslados.Usuario_Cierre);
            cmd.Parameters.AddWithValue("@Fecha_Ultima_Actualizacion", objE_Traslados.Fecha_Ultima_Actualizacion);
            cmd.Parameters.AddWithValue("@Usuario_Ultima_Actualizacion", objE_Traslados.Usuario_Ultima_Actualizacion);
            cmd.Parameters.AddWithValue("@Hora_Ultima_Actualizacion", objE_Traslados.Hora_Ultima_Actualizacion);
            cmd.Parameters.AddWithValue("@Razon", objE_Traslados.Razon);
            cmd.Parameters.AddWithValue("@Subrazon", objE_Traslados.Subrazon);
            cmd.Parameters.AddWithValue("@Estado", objE_Traslados.Estado);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar actualizar la tabla de Traslados", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public int Actualizar_Traslado_Gestion(string pAccion, E_Traslados objE_Traslados)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("Actualizar_Caso_Gestion_Back_Traslados", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Id_Traslado", objE_Traslados.Id_Traslado);
            cmd.Parameters.AddWithValue("@Fecha_Ultima_Actualizacion", objE_Traslados.Fecha_Ultima_Actualizacion);
            cmd.Parameters.AddWithValue("@Usuario_Ultima_Actualizacion", objE_Traslados.Usuario_Ultima_Actualizacion);
            cmd.Parameters.AddWithValue("@Hora_Ultima_Actualizacion", objE_Traslados.Hora_Ultima_Actualizacion);
            cmd.Parameters.AddWithValue("@Razon", objE_Traslados.Razon);
            cmd.Parameters.AddWithValue("@Subrazon", objE_Traslados.Subrazon);
            cmd.Parameters.AddWithValue("@Estado", objE_Traslados.Estado);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar actualizar la tabla de Traslados", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public int Actualizar_Traslado_Gestion_Outbound(string pAccion, E_Traslados objE_Traslados)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("Actualizar_Caso_Gestion_Outbound_Traslados", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Id_Traslado", objE_Traslados.Id_Traslado);
            cmd.Parameters.AddWithValue("@Fecha_Ultima_Actualizacion", objE_Traslados.Fecha_Ultima_Actualizacion);
            cmd.Parameters.AddWithValue("@Usuario_Ultima_Actualizacion", objE_Traslados.Usuario_Ultima_Actualizacion);
            cmd.Parameters.AddWithValue("@Hora_Ultima_Actualizacion", objE_Traslados.Hora_Ultima_Actualizacion);
            cmd.Parameters.AddWithValue("@Razon", objE_Traslados.Razon);
            cmd.Parameters.AddWithValue("@Subrazon", objE_Traslados.Subrazon);
            cmd.Parameters.AddWithValue("@Estado", objE_Traslados.Estado);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar actualizar la tabla de Traslados", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public DataSet Consultar_Nodo_Existente(string pNodo)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            { 
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consultar_Nodo_Existente]";
                cmd.Parameters.AddWithValue("@Nodo", pNodo);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al consultar la existencia del nodo", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Casos_Escalados_Traslados_Por_Estado_Celula(string pBack)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Casos_Escalados_Traslados_Por_Estado_Celula]";
                cmd.Parameters.AddWithValue("@Usuario_Back", pBack);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar los casos escalados para los traslados", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Admin_Casos_Traslados_Cuenta(double pCuenta)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Traslado_Admin_Cuenta]";
                cmd.Parameters.AddWithValue("@Cuenta_Cliente", pCuenta);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al consultar caso por cuenta dce traslados", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Admin_Casos_Traslados_Usuario(string pUsuario)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Traslado_Admin_Usuario]";
                cmd.Parameters.AddWithValue("@Usuario_Apertura", pUsuario);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al consultar caso por usuario", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Admin_Casos_Traslados_Id(double pId_Traslado)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Traslado_Admin_Id]";
                cmd.Parameters.AddWithValue("@Id_Traslado", pId_Traslado);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al consultar caso por id de traslado", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public int Actualiza_Ingreso_Back_Traslados(double Id_Traslado, E_Traslados objE_Traslados)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("Actualizar_Caso_Back_Traslados", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Traslado", objE_Traslados.Id_Traslado);
            cmd.Parameters.AddWithValue("@Usuario_Backoffice", objE_Traslados.Usuario_Backoffice);
            cmd.Parameters.AddWithValue("@Usuario_Actualizacion", objE_Traslados.Usuario_Ultima_Actualizacion);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar actualizar el usuario del back", e);
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
