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
    public class D_Ventas : D_Conexion_BD
    {
        public D_Ventas() { }
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
                cmd.CommandText = "[dbo].[Consulta_Cliente_Temporal_Ventas]";
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
        public int abcVentas(string pAccion, E_Ventas Obj_Ventas)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abcVentas", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Fecha_gestion", Obj_Ventas.Fecha_Gestion);
            cmd.Parameters.AddWithValue("@Usuario_gestion", Obj_Ventas.Usuario_Gestion);
            cmd.Parameters.AddWithValue("@Aliado_gestion", Obj_Ventas.Aliado_Gestion);
            cmd.Parameters.AddWithValue("@Cuenta_cliente", Obj_Ventas.Cuenta_Cliente);
            cmd.Parameters.AddWithValue("@Nombre_cliente", Obj_Ventas.Nombre_Cliente);
            cmd.Parameters.AddWithValue("@Apellido_cliente", Obj_Ventas.Apellido_Cliente);
            cmd.Parameters.AddWithValue("@Direccion_instalacion", Obj_Ventas.Direccion_Instalacion);
            cmd.Parameters.AddWithValue("@Direccion_correspondencia", Obj_Ventas.Direccion_Correspondencia);
            cmd.Parameters.AddWithValue("@Correo_electronico", Obj_Ventas.Correo_Electronico);
            cmd.Parameters.AddWithValue("@Telefono_1", Obj_Ventas.Telefono_1);
            cmd.Parameters.AddWithValue("@Telefono_2", Obj_Ventas.Telefono_2);
            cmd.Parameters.AddWithValue("@Telefono_3", Obj_Ventas.Telefono_3);
            cmd.Parameters.AddWithValue("@Movil_1", Obj_Ventas.Movil_1);
            cmd.Parameters.AddWithValue("@Movil_2", Obj_Ventas.Movil_2);
            cmd.Parameters.AddWithValue("@Paquete_actual", Obj_Ventas.Paquete_Actual);
            cmd.Parameters.AddWithValue("@Tipo_de_contacto", Obj_Ventas.Tipo_Contacto);
            cmd.Parameters.AddWithValue("@Cierre", Obj_Ventas.Cierre);
            cmd.Parameters.AddWithValue("@Razon", Obj_Ventas.Razon);
            cmd.Parameters.AddWithValue("@Attributo_1", Obj_Ventas.Atributo_1);
            cmd.Parameters.AddWithValue("@Attributo_2", Obj_Ventas.Atributo_2);
            cmd.Parameters.AddWithValue("@Attributo_3", Obj_Ventas.Atributo_3);
            cmd.Parameters.AddWithValue("@Attributo_4", Obj_Ventas.Atributo_4);
            cmd.Parameters.AddWithValue("@Attributo_5", Obj_Ventas.Atributo_5);
            cmd.Parameters.AddWithValue("@Attributo_6", Obj_Ventas.Atributo_6);
            cmd.Parameters.AddWithValue("@Attributo_7", Obj_Ventas.Atributo_7);
            cmd.Parameters.AddWithValue("@Attributo_8", Obj_Ventas.Atributo_8);
            cmd.Parameters.AddWithValue("@Attributo_9", Obj_Ventas.Atributo_9);
            cmd.Parameters.AddWithValue("@Attributo_10", Obj_Ventas.Atributo_10);
            cmd.Parameters.AddWithValue("@Observaciones", Obj_Ventas.Observaciones);
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
        public DataSet Consulta_Cliente_Venta_Gestionado(double pCuenta_Cliente)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Cliente_Ventas_Gestionado]";
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
        public int abcLog_Ventas(string pAccion, E_Ventas Obj_Ventas)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abcLog_Ventas", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Fecha_gestion", Obj_Ventas.Fecha_Gestion);
            cmd.Parameters.AddWithValue("@Usuario_gestion", Obj_Ventas.Usuario_Gestion);
            cmd.Parameters.AddWithValue("@Aliado_gestion", Obj_Ventas.Aliado_Gestion);
            cmd.Parameters.AddWithValue("@Cuenta_cliente", Obj_Ventas.Cuenta_Cliente);
            cmd.Parameters.AddWithValue("@Nombre_cliente", Obj_Ventas.Nombre_Cliente);
            cmd.Parameters.AddWithValue("@Apellido_cliente", Obj_Ventas.Apellido_Cliente);
            cmd.Parameters.AddWithValue("@Direccion_instalacion", Obj_Ventas.Direccion_Instalacion);
            cmd.Parameters.AddWithValue("@Direccion_correspondencia", Obj_Ventas.Direccion_Correspondencia);
            cmd.Parameters.AddWithValue("@Correo_electronico", Obj_Ventas.Correo_Electronico);
            cmd.Parameters.AddWithValue("@Telefono_1", Obj_Ventas.Telefono_1);
            cmd.Parameters.AddWithValue("@Telefono_2", Obj_Ventas.Telefono_2);
            cmd.Parameters.AddWithValue("@Telefono_3", Obj_Ventas.Telefono_3);
            cmd.Parameters.AddWithValue("@Movil_1", Obj_Ventas.Movil_1);
            cmd.Parameters.AddWithValue("@Movil_2", Obj_Ventas.Movil_2);
            cmd.Parameters.AddWithValue("@Paquete_actual", Obj_Ventas.Paquete_Actual);
            cmd.Parameters.AddWithValue("@Tipo_de_contacto", Obj_Ventas.Tipo_Contacto);
            cmd.Parameters.AddWithValue("@Cierre", Obj_Ventas.Cierre);
            cmd.Parameters.AddWithValue("@Razon", Obj_Ventas.Razon);
            cmd.Parameters.AddWithValue("@Attributo_1", Obj_Ventas.Atributo_1);
            cmd.Parameters.AddWithValue("@Attributo_2", Obj_Ventas.Atributo_2);
            cmd.Parameters.AddWithValue("@Attributo_3", Obj_Ventas.Atributo_3);
            cmd.Parameters.AddWithValue("@Attributo_4", Obj_Ventas.Atributo_4);
            cmd.Parameters.AddWithValue("@Attributo_5", Obj_Ventas.Atributo_5);
            cmd.Parameters.AddWithValue("@Attributo_6", Obj_Ventas.Atributo_6);
            cmd.Parameters.AddWithValue("@Attributo_7", Obj_Ventas.Atributo_7);
            cmd.Parameters.AddWithValue("@Attributo_8", Obj_Ventas.Atributo_8);
            cmd.Parameters.AddWithValue("@Attributo_9", Obj_Ventas.Atributo_9);
            cmd.Parameters.AddWithValue("@Attributo_10", Obj_Ventas.Atributo_10);
            cmd.Parameters.AddWithValue("@Observaciones", Obj_Ventas.Observaciones);
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
        public DataSet Consulta_Admin_Log_Ventas(string pFecha_Inicial, string pFecha_Final)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Genera_Sabana_Log_Ventas_Out]";
                cmd.Parameters.AddWithValue("@Fecha_Inicial", pFecha_Inicial);
                cmd.Parameters.AddWithValue("@Fecha_Final", pFecha_Final);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar la base de ventas", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;

        }
    }
}
