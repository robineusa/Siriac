using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class D_Claro_Video : D_Conexion_BD
    {
        public DataSet Consulta_Temporal_Cuentas(double pCuenta_Cliente)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Cliente_Temporal_Claro_Video]";
                cmd.Parameters.AddWithValue("@Cuenta_Cliente", pCuenta_Cliente);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar los datos del cliente", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Cliente_Claro_Video_Gestionado(double pCuenta_Cliente)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Cliente_Claro_Video_Gestionado]";
                cmd.Parameters.AddWithValue("@Cuenta_Cliente", pCuenta_Cliente);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar los datos del cliente", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public int abcClaro_Video(string pAccion, E_Claro_Video Obj_Claro_Video)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abcClaro_Video", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Fecha_gestion", Obj_Claro_Video.Fecha_Gestion);
            cmd.Parameters.AddWithValue("@Usuario_gestion", Obj_Claro_Video.Usuario_Gestion);
            cmd.Parameters.AddWithValue("@Nombre_Usuario_gestion", Obj_Claro_Video.Nombre_Usuario_Gestion);
            cmd.Parameters.AddWithValue("@Aliado_gestion", Obj_Claro_Video.Aliado_Gestion);
            cmd.Parameters.AddWithValue("@Operacion_Gestion", Obj_Claro_Video.Operacion_Gestion);
            cmd.Parameters.AddWithValue("@Cuenta_cliente", Obj_Claro_Video.Cuenta_Cliente);
            cmd.Parameters.AddWithValue("@Nombre_cliente", Obj_Claro_Video.Nombre_Cliente);
            cmd.Parameters.AddWithValue("@Apellido_cliente", Obj_Claro_Video.Apellido_Cliente);
            cmd.Parameters.AddWithValue("@Direccion_instalacion", Obj_Claro_Video.Direccion_Instalacion);
            cmd.Parameters.AddWithValue("@Direccion_correspondencia", Obj_Claro_Video.Direccion_Correspondencia);
            cmd.Parameters.AddWithValue("@Correo_electronico", Obj_Claro_Video.Correo_Electronico);
            cmd.Parameters.AddWithValue("@Telefono_1", Obj_Claro_Video.Telefono_1);
            cmd.Parameters.AddWithValue("@Telefono_2", Obj_Claro_Video.Telefono_2);
            cmd.Parameters.AddWithValue("@Telefono_3", Obj_Claro_Video.Telefono_3);
            cmd.Parameters.AddWithValue("@Movil_1", Obj_Claro_Video.Movil_1);
            cmd.Parameters.AddWithValue("@Movil_2", Obj_Claro_Video.Movil_2);
            cmd.Parameters.AddWithValue("@Paquete_actual", Obj_Claro_Video.Paquete_Actual);
            cmd.Parameters.AddWithValue("@Tipo_de_contacto", Obj_Claro_Video.Tipo_Contacto);
            cmd.Parameters.AddWithValue("@Tipo_de_gestion", Obj_Claro_Video.Tipo_Gestion);
            cmd.Parameters.AddWithValue("@Cierre", Obj_Claro_Video.Cierre);
            cmd.Parameters.AddWithValue("@Razon", Obj_Claro_Video.Razon);
            cmd.Parameters.AddWithValue("@Attributo_1", Obj_Claro_Video.Atributo_1);
            cmd.Parameters.AddWithValue("@Attributo_2", Obj_Claro_Video.Atributo_2);
            cmd.Parameters.AddWithValue("@Attributo_3", Obj_Claro_Video.Atributo_3);
            cmd.Parameters.AddWithValue("@Attributo_4", Obj_Claro_Video.Atributo_4);
            cmd.Parameters.AddWithValue("@Attributo_5", Obj_Claro_Video.Atributo_5);
            cmd.Parameters.AddWithValue("@Attributo_6", Obj_Claro_Video.Atributo_6);
            cmd.Parameters.AddWithValue("@Attributo_7", Obj_Claro_Video.Atributo_7);
            cmd.Parameters.AddWithValue("@Attributo_8", Obj_Claro_Video.Atributo_8);
            cmd.Parameters.AddWithValue("@Attributo_9", Obj_Claro_Video.Atributo_9);
            cmd.Parameters.AddWithValue("@Attributo_10", Obj_Claro_Video.Atributo_10);
            cmd.Parameters.AddWithValue("@Observaciones", Obj_Claro_Video.Observaciones);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar almacenar,modificar o eliminar datos de la tabla de ventas", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public int abcLogClaro_Video(string pAccion, E_Claro_Video Obj_Claro_Video)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abcLogClaro_Video", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Fecha_gestion", Obj_Claro_Video.Fecha_Gestion);
            cmd.Parameters.AddWithValue("@Usuario_gestion", Obj_Claro_Video.Usuario_Gestion);
            cmd.Parameters.AddWithValue("@Nombre_Usuario_gestion", Obj_Claro_Video.Nombre_Usuario_Gestion);
            cmd.Parameters.AddWithValue("@Aliado_gestion", Obj_Claro_Video.Aliado_Gestion);
            cmd.Parameters.AddWithValue("@Operacion_Gestion", Obj_Claro_Video.Operacion_Gestion);
            cmd.Parameters.AddWithValue("@Cuenta_cliente", Obj_Claro_Video.Cuenta_Cliente);
            cmd.Parameters.AddWithValue("@Nombre_cliente", Obj_Claro_Video.Nombre_Cliente);
            cmd.Parameters.AddWithValue("@Apellido_cliente", Obj_Claro_Video.Apellido_Cliente);
            cmd.Parameters.AddWithValue("@Direccion_instalacion", Obj_Claro_Video.Direccion_Instalacion);
            cmd.Parameters.AddWithValue("@Direccion_correspondencia", Obj_Claro_Video.Direccion_Correspondencia);
            cmd.Parameters.AddWithValue("@Correo_electronico", Obj_Claro_Video.Correo_Electronico);
            cmd.Parameters.AddWithValue("@Telefono_1", Obj_Claro_Video.Telefono_1);
            cmd.Parameters.AddWithValue("@Telefono_2", Obj_Claro_Video.Telefono_2);
            cmd.Parameters.AddWithValue("@Telefono_3", Obj_Claro_Video.Telefono_3);
            cmd.Parameters.AddWithValue("@Movil_1", Obj_Claro_Video.Movil_1);
            cmd.Parameters.AddWithValue("@Movil_2", Obj_Claro_Video.Movil_2);
            cmd.Parameters.AddWithValue("@Paquete_actual", Obj_Claro_Video.Paquete_Actual);
            cmd.Parameters.AddWithValue("@Tipo_de_contacto", Obj_Claro_Video.Tipo_Contacto);
            cmd.Parameters.AddWithValue("@Tipo_de_gestion", Obj_Claro_Video.Tipo_Gestion);
            cmd.Parameters.AddWithValue("@Cierre", Obj_Claro_Video.Cierre);
            cmd.Parameters.AddWithValue("@Razon", Obj_Claro_Video.Razon);
            cmd.Parameters.AddWithValue("@Attributo_1", Obj_Claro_Video.Atributo_1);
            cmd.Parameters.AddWithValue("@Attributo_2", Obj_Claro_Video.Atributo_2);
            cmd.Parameters.AddWithValue("@Attributo_3", Obj_Claro_Video.Atributo_3);
            cmd.Parameters.AddWithValue("@Attributo_4", Obj_Claro_Video.Atributo_4);
            cmd.Parameters.AddWithValue("@Attributo_5", Obj_Claro_Video.Atributo_5);
            cmd.Parameters.AddWithValue("@Attributo_6", Obj_Claro_Video.Atributo_6);
            cmd.Parameters.AddWithValue("@Attributo_7", Obj_Claro_Video.Atributo_7);
            cmd.Parameters.AddWithValue("@Attributo_8", Obj_Claro_Video.Atributo_8);
            cmd.Parameters.AddWithValue("@Attributo_9", Obj_Claro_Video.Atributo_9);
            cmd.Parameters.AddWithValue("@Attributo_10", Obj_Claro_Video.Atributo_10);
            cmd.Parameters.AddWithValue("@Observaciones", Obj_Claro_Video.Observaciones);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar almacenar,modificar o eliminar datos de la tabla de ventas", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public DataSet Consulta_Admin_Claro_Video(string pFecha_Inicial, string pFecha_Final)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Admin_Claro_Video]";
                cmd.Parameters.AddWithValue("@Fecha_Inicial", pFecha_Inicial);
                cmd.Parameters.AddWithValue("@Fecha_Final", pFecha_Final);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al sconsultar el registro en Claro Video", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public int abc_Activacion_Claro_Video(string pAccion, E_Claro_Video Obj_Claro_Video)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("Abc_Activacion_Claro_Video", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Fecha_gestion", Obj_Claro_Video.Fecha_Gestion);
            cmd.Parameters.AddWithValue("@Usuario_gestion", Obj_Claro_Video.Usuario_Gestion);
            cmd.Parameters.AddWithValue("@Nombre_Usuario_gestion", Obj_Claro_Video.Nombre_Usuario_Gestion);
            cmd.Parameters.AddWithValue("@Aliado_gestion", Obj_Claro_Video.Aliado_Gestion);
            cmd.Parameters.AddWithValue("@Cuenta_cliente", Obj_Claro_Video.Cuenta_Cliente);
            cmd.Parameters.AddWithValue("@Aceptacion_Claro_Video", Obj_Claro_Video.Aceptacion_Claro_Video);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar almacenar,modificar o eliminar datos de la tabla de activacion claro video", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public DataSet Consulta_Cliente_Activacion_Claro_Video(double pCuenta_Cliente)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Cliente_Activacion_Claro_Video]";
                cmd.Parameters.AddWithValue("@Cuenta", pCuenta_Cliente);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar los datos del cliente", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Falta_Activacion_Claro_Video(double pCuenta)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Falta_Activacion_Claro_Video]";
                cmd.Parameters.AddWithValue("@CUENTA", pCuenta);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al consultar el registro en base cuentas", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
