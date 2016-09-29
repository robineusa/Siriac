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
    public class D_Logistica_Inversa: D_Conexion_BD
    {
        public D_Logistica_Inversa() { }
        public int abc_Logistica_Inversa(string pAccion, E_Logistica_Inversa Obj_Logistica_Inversa)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abcLogisticaInversa", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Fecha_Gestion", Obj_Logistica_Inversa.Fecha_Gestion);
            cmd.Parameters.AddWithValue("@Hora_gestion", Obj_Logistica_Inversa.Hora_Gestion);
            cmd.Parameters.AddWithValue("@Usuario_gestion", Obj_Logistica_Inversa.Usuario_Gestion);
            cmd.Parameters.AddWithValue("@Aliado_gestion", Obj_Logistica_Inversa.Aliado_Gestion);
            cmd.Parameters.AddWithValue("@Cuenta_cliente", Obj_Logistica_Inversa.Cuenta_Cliente);
            cmd.Parameters.AddWithValue("@Nombre_cliente", Obj_Logistica_Inversa.Nombre_Cliente);
            cmd.Parameters.AddWithValue("@Apellido_cliente", Obj_Logistica_Inversa.Apellido_Cliente);
            cmd.Parameters.AddWithValue("@Direccion_instalacion", Obj_Logistica_Inversa.Direccion_Instalacion);
            cmd.Parameters.AddWithValue("@Direccion_correspondencia", Obj_Logistica_Inversa.Direccion_Correspondencia);
            cmd.Parameters.AddWithValue("@Telefono_telmex", Obj_Logistica_Inversa.Telefono_Telmex);
            cmd.Parameters.AddWithValue("@Telefono_1", Obj_Logistica_Inversa.Telefono_1);
            cmd.Parameters.AddWithValue("@Telefono_2", Obj_Logistica_Inversa.Telefono_2);
            cmd.Parameters.AddWithValue("@Telefono_3", Obj_Logistica_Inversa.Telefono_3);
            cmd.Parameters.AddWithValue("@Movil_postpago", Obj_Logistica_Inversa.Movil_Portpago);
            cmd.Parameters.AddWithValue("@Tipo_contacto", Obj_Logistica_Inversa.Tipo_Contacto);
            cmd.Parameters.AddWithValue("@Cierre", Obj_Logistica_Inversa.Cierre);
            cmd.Parameters.AddWithValue("@Razon", Obj_Logistica_Inversa.Razon);
            cmd.Parameters.AddWithValue("@Fecha_agenda", Obj_Logistica_Inversa.Fecha_Agenda);
            cmd.Parameters.AddWithValue("@Persona_contacto", Obj_Logistica_Inversa.Persona_Contacto);
            cmd.Parameters.AddWithValue("@Telefono_contacto", Obj_Logistica_Inversa.Telefono_Contacto);
            cmd.Parameters.AddWithValue("@Direccion_alterna", Obj_Logistica_Inversa.Direccion_Alterna);
            cmd.Parameters.AddWithValue("@Observaciones", Obj_Logistica_Inversa.Observaciones);
            cmd.Parameters.AddWithValue("@Departamento", Obj_Logistica_Inversa.Departamento);
            cmd.Parameters.AddWithValue("@Ciudad", Obj_Logistica_Inversa.Ciudad);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar almacenar,modificar o eliminar datos de la tabla de Logistica inversa", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public int abc_Log_Logistica_Inversa(string pAccion, E_Logistica_Inversa Obj_Logistica_Inversa)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abclog_LogisticaInversa", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Fecha_Gestion", Obj_Logistica_Inversa.Fecha_Gestion);
            cmd.Parameters.AddWithValue("@Hora_gestion", Obj_Logistica_Inversa.Hora_Gestion);
            cmd.Parameters.AddWithValue("@Usuario_gestion", Obj_Logistica_Inversa.Usuario_Gestion);
            cmd.Parameters.AddWithValue("@Aliado_gestion", Obj_Logistica_Inversa.Aliado_Gestion);
            cmd.Parameters.AddWithValue("@Cuenta_cliente", Obj_Logistica_Inversa.Cuenta_Cliente);
            cmd.Parameters.AddWithValue("@Nombre_cliente", Obj_Logistica_Inversa.Nombre_Cliente);
            cmd.Parameters.AddWithValue("@Apellido_cliente", Obj_Logistica_Inversa.Apellido_Cliente);
            cmd.Parameters.AddWithValue("@Direccion_instalacion", Obj_Logistica_Inversa.Direccion_Instalacion);
            cmd.Parameters.AddWithValue("@Direccion_correspondencia", Obj_Logistica_Inversa.Direccion_Correspondencia);
            cmd.Parameters.AddWithValue("@Telefono_telmex", Obj_Logistica_Inversa.Telefono_Telmex);
            cmd.Parameters.AddWithValue("@Telefono_1", Obj_Logistica_Inversa.Telefono_1);
            cmd.Parameters.AddWithValue("@Telefono_2", Obj_Logistica_Inversa.Telefono_2);
            cmd.Parameters.AddWithValue("@Telefono_3", Obj_Logistica_Inversa.Telefono_3);
            cmd.Parameters.AddWithValue("@Movil_postpago", Obj_Logistica_Inversa.Movil_Portpago);
            cmd.Parameters.AddWithValue("@Tipo_contacto", Obj_Logistica_Inversa.Tipo_Contacto);
            cmd.Parameters.AddWithValue("@Cierre", Obj_Logistica_Inversa.Cierre);
            cmd.Parameters.AddWithValue("@Razon", Obj_Logistica_Inversa.Razon);
            cmd.Parameters.AddWithValue("@Fecha_agenda", Obj_Logistica_Inversa.Fecha_Agenda);
            cmd.Parameters.AddWithValue("@Persona_contacto", Obj_Logistica_Inversa.Persona_Contacto);
            cmd.Parameters.AddWithValue("@Telefono_contacto", Obj_Logistica_Inversa.Telefono_Contacto);
            cmd.Parameters.AddWithValue("@Direccion_alterna", Obj_Logistica_Inversa.Direccion_Alterna);
            cmd.Parameters.AddWithValue("@Observaciones", Obj_Logistica_Inversa.Observaciones);
            cmd.Parameters.AddWithValue("@Departamento", Obj_Logistica_Inversa.Departamento);
            cmd.Parameters.AddWithValue("@Ciudad", Obj_Logistica_Inversa.Ciudad);

            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar almacenar,modificar o eliminar datos de la tabla de log Logistica inversa", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public DataSet Consultar_Registro(double pCuenta_Cliente)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consultar_Registro_Logistica]";
                cmd.Parameters.AddWithValue("@Cuenta_Cliente", pCuenta_Cliente);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar la gestion de logistica inversa", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Reporte_Cierre()
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Reporte_Cierre_LI]";
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al generar datos para el grafico", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Admin_Logistica(string pFecha_Inicial, string pFecha_Final)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Admin_Logistica_Inversa]";
                cmd.Parameters.AddWithValue("@Fecha_Inicial", pFecha_Inicial);
                cmd.Parameters.AddWithValue("@Fecha_Final", pFecha_Final);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al sconsultar el registro en Logistica Inversa", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
