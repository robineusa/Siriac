using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
    public class D_Docsis_Overlap: D_Conexion_BD
    {
        public D_Docsis_Overlap() { }
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
                cmd.CommandText = "[dbo].[Consulta_Cliente_Temporal_Docsis]";
                cmd.Parameters.AddWithValue("@Cuenta_Cliente", pCuenta_Cliente);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar los datos del cliente de Docsis", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Cuenta_Seguimiento(double pCuenta_Cliente)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Cuenta_Seguimiento]";
                cmd.Parameters.AddWithValue("@Cuenta", pCuenta_Cliente);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar los datos del cliente de Docsis", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Cliente_Docsis_Gestionado(double pCuenta_Cliente)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Cliente_Docsis_Gestionado]";
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
        public DataSet Consulta_Admin_Docsis_Overlap(string pFecha_Inicial, string pFecha_Final)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Admin_Docsis_Overlap]";
                cmd.Parameters.AddWithValue("@Fecha_Inicial", pFecha_Inicial);
                cmd.Parameters.AddWithValue("@Fecha_Final", pFecha_Final);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al sconsultar el registro en Docsis y Overlap", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public int abcDocsis_Overlap(string pAccion, E_Docsis_Overlap Obj_Docsis_Overlap)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abc_Docsis_Overlap", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Fecha_gestion", Obj_Docsis_Overlap.Fecha_Gestion);
            cmd.Parameters.AddWithValue("@Usuario_gestion", Obj_Docsis_Overlap.Usuario_Gestion);
            cmd.Parameters.AddWithValue("@Nombre_Usuario_gestion", Obj_Docsis_Overlap.Nombre_Usuario_Gestion);
            cmd.Parameters.AddWithValue("@Aliado_gestion", Obj_Docsis_Overlap.Aliado_Gestion);
            cmd.Parameters.AddWithValue("@Operacion_Gestion", Obj_Docsis_Overlap.Operacion_Gestion);
            cmd.Parameters.AddWithValue("@Nombre_Base", Obj_Docsis_Overlap.Nombre_Base);
            cmd.Parameters.AddWithValue("@Cuenta_cliente", Obj_Docsis_Overlap.Cuenta_Cliente);
            cmd.Parameters.AddWithValue("@Nombre_cliente", Obj_Docsis_Overlap.Nombre_Cliente);
            cmd.Parameters.AddWithValue("@Apellido_cliente", Obj_Docsis_Overlap.Apellido_Cliente);
            cmd.Parameters.AddWithValue("@Direccion_instalacion", Obj_Docsis_Overlap.Direccion_Instalacion);
            cmd.Parameters.AddWithValue("@Direccion_correspondencia", Obj_Docsis_Overlap.Direccion_Correspondencia);
            cmd.Parameters.AddWithValue("@Correo_electronico", Obj_Docsis_Overlap.Correo_Electronico);
            cmd.Parameters.AddWithValue("@Telefono_1", Obj_Docsis_Overlap.Telefono_1);
            cmd.Parameters.AddWithValue("@Telefono_2", Obj_Docsis_Overlap.Telefono_2);
            cmd.Parameters.AddWithValue("@Telefono_3", Obj_Docsis_Overlap.Telefono_3);
            cmd.Parameters.AddWithValue("@Movil_1", Obj_Docsis_Overlap.Movil_1);
            cmd.Parameters.AddWithValue("@Movil_2", Obj_Docsis_Overlap.Movil_2);
            cmd.Parameters.AddWithValue("@Paquete_actual", Obj_Docsis_Overlap.Paquete_Actual);
            cmd.Parameters.AddWithValue("@Tipo_de_contacto", Obj_Docsis_Overlap.Tipo_Contacto);
            cmd.Parameters.AddWithValue("@Gestion", Obj_Docsis_Overlap.Gestion);
            cmd.Parameters.AddWithValue("@Cierre", Obj_Docsis_Overlap.Cierre);
            cmd.Parameters.AddWithValue("@Razon", Obj_Docsis_Overlap.Razon);
            cmd.Parameters.AddWithValue("@Observaciones", Obj_Docsis_Overlap.Observaciones);
            cmd.Parameters.AddWithValue("@Fecha_Agenda", Obj_Docsis_Overlap.Fecha_Seguimiento);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar almacenar,modificar o eliminar datos de la tabla de Docsis Overlap", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public int abcLogDocsis_OVerlap(string pAccion, E_Docsis_Overlap Obj_Docsis_Overlap)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abcLog_Docsis_overlap", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Fecha_gestion", Obj_Docsis_Overlap.Fecha_Gestion);
            cmd.Parameters.AddWithValue("@Usuario_gestion", Obj_Docsis_Overlap.Usuario_Gestion);
            cmd.Parameters.AddWithValue("@Nombre_Usuario_gestion", Obj_Docsis_Overlap.Nombre_Usuario_Gestion);
            cmd.Parameters.AddWithValue("@Aliado_gestion", Obj_Docsis_Overlap.Aliado_Gestion);
            cmd.Parameters.AddWithValue("@Operacion_Gestion", Obj_Docsis_Overlap.Operacion_Gestion);
            cmd.Parameters.AddWithValue("@Nombre_Base", Obj_Docsis_Overlap.Nombre_Base);
            cmd.Parameters.AddWithValue("@Cuenta_cliente", Obj_Docsis_Overlap.Cuenta_Cliente);
            cmd.Parameters.AddWithValue("@Nombre_cliente", Obj_Docsis_Overlap.Nombre_Cliente);
            cmd.Parameters.AddWithValue("@Apellido_cliente", Obj_Docsis_Overlap.Apellido_Cliente);
            cmd.Parameters.AddWithValue("@Direccion_instalacion", Obj_Docsis_Overlap.Direccion_Instalacion);
            cmd.Parameters.AddWithValue("@Direccion_correspondencia", Obj_Docsis_Overlap.Direccion_Correspondencia);
            cmd.Parameters.AddWithValue("@Correo_electronico", Obj_Docsis_Overlap.Correo_Electronico);
            cmd.Parameters.AddWithValue("@Telefono_1", Obj_Docsis_Overlap.Telefono_1);
            cmd.Parameters.AddWithValue("@Telefono_2", Obj_Docsis_Overlap.Telefono_2);
            cmd.Parameters.AddWithValue("@Telefono_3", Obj_Docsis_Overlap.Telefono_3);
            cmd.Parameters.AddWithValue("@Movil_1", Obj_Docsis_Overlap.Movil_1);
            cmd.Parameters.AddWithValue("@Movil_2", Obj_Docsis_Overlap.Movil_2);
            cmd.Parameters.AddWithValue("@Paquete_actual", Obj_Docsis_Overlap.Paquete_Actual);
            cmd.Parameters.AddWithValue("@Tipo_de_contacto", Obj_Docsis_Overlap.Tipo_Contacto);
            cmd.Parameters.AddWithValue("@Gestion", Obj_Docsis_Overlap.Gestion);
            cmd.Parameters.AddWithValue("@Cierre", Obj_Docsis_Overlap.Cierre);
            cmd.Parameters.AddWithValue("@Razon", Obj_Docsis_Overlap.Razon);
            cmd.Parameters.AddWithValue("@Observaciones", Obj_Docsis_Overlap.Observaciones);
            cmd.Parameters.AddWithValue("@Fecha_Agenda", Obj_Docsis_Overlap.Fecha_Seguimiento);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar almacenar,modificar o eliminar datos de la tabla de Docsis Overlap", e);
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
