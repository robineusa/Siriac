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
    public class D_Midas : D_Conexion_BD
    {
        public D_Midas() { }

        public int abcMidas(string pAccion, E_Midas objE_Midas)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abc_Midas_Activacion", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Fecha_de_Gestion", objE_Midas.Fecha_de_Gestion);
            cmd.Parameters.AddWithValue("@Usuario_de_Gestion", objE_Midas.Usuario_de_Gestion);
            cmd.Parameters.AddWithValue("@Aliado_de_Gestion", objE_Midas.Aliado_Gestion);
            cmd.Parameters.AddWithValue("@Ciudad", objE_Midas.Ciudad);
            cmd.Parameters.AddWithValue("@Nodo", objE_Midas.Nodo);
            cmd.Parameters.AddWithValue("@Mix_Basico", objE_Midas.Mix_Basico);
            cmd.Parameters.AddWithValue("@Tipo_Servicio", objE_Midas.Tipo_Servicio);
            cmd.Parameters.AddWithValue("@ciclo_Facturacion", objE_Midas.Ciclo_Facturacion);
            cmd.Parameters.AddWithValue("@Renta", objE_Midas.Renta);
            cmd.Parameters.AddWithValue("@Tipo_Tv", objE_Midas.Tipo_Tv);
            cmd.Parameters.AddWithValue("@Velocidad_Internet", objE_Midas.Velovidad_Internet);
            cmd.Parameters.AddWithValue("@Cuenta_Cliente", objE_Midas.Cuenta_Cliente);
            cmd.Parameters.AddWithValue("@Estado_Cuenta", objE_Midas.Estado_Cuenta);
            cmd.Parameters.AddWithValue("@Motivo_Desconexion", objE_Midas.Motivo_Desconexion);
            cmd.Parameters.AddWithValue("@Nombre_Cliente", objE_Midas.Nombre_Cliente);
            cmd.Parameters.AddWithValue("@Apellido_1", objE_Midas.Apellido_1);
            cmd.Parameters.AddWithValue("@Apellido_2", objE_Midas.Apellido_2);
            cmd.Parameters.AddWithValue("@Contrato", objE_Midas.Contrato);
            cmd.Parameters.AddWithValue("@Telefono_1", objE_Midas.Telefono_1);
            cmd.Parameters.AddWithValue("@Telefono_2", objE_Midas.Telefono_2);
            cmd.Parameters.AddWithValue("@Telefono_3", objE_Midas.Telefono_3);
            cmd.Parameters.AddWithValue("@Movil_1", objE_Midas.Movil_1);
            cmd.Parameters.AddWithValue("@Movil_2", objE_Midas.Movil_2);
            cmd.Parameters.AddWithValue("@Movil_3", objE_Midas.Movil_3);
            cmd.Parameters.AddWithValue("@Estrato", objE_Midas.Estrato);
            cmd.Parameters.AddWithValue("@Historico", objE_Midas.Historico);
            cmd.Parameters.AddWithValue("@Tipo_hipotesis", objE_Midas.Tipo_Hipotesis);
            cmd.Parameters.AddWithValue("@Tipo_Contacto", objE_Midas.Tipo_Contacto);
            cmd.Parameters.AddWithValue("@Gestion", objE_Midas.Gestion);
            cmd.Parameters.AddWithValue("@Cierre", objE_Midas.Cierre);
            cmd.Parameters.AddWithValue("@Razon", objE_Midas.Razon);
            cmd.Parameters.AddWithValue("@Causa", objE_Midas.Causa);
            cmd.Parameters.AddWithValue("@Id_Estado", objE_Midas.Id_Estado);
            cmd.Parameters.AddWithValue("@Nps", objE_Midas.Nps);
            cmd.Parameters.AddWithValue("@Campana", objE_Midas.Campana);
            cmd.Parameters.AddWithValue("@Estado_Campana", objE_Midas.Estado_Campana);
            cmd.Parameters.AddWithValue("@Satisfaccion", objE_Midas.Satisfaccion);
            cmd.Parameters.AddWithValue("@Atributo_1", objE_Midas.Atributo_1);
            cmd.Parameters.AddWithValue("@Atributo_2", objE_Midas.Atributo_2);
            cmd.Parameters.AddWithValue("@Atributo_3", objE_Midas.Atributo_3);
            cmd.Parameters.AddWithValue("@Atributo_4", objE_Midas.Atributo_4);
            cmd.Parameters.AddWithValue("@Atributo_5", objE_Midas.Atributo_5);
            cmd.Parameters.AddWithValue("@Atributo_6", objE_Midas.Atributo_6);
            cmd.Parameters.AddWithValue("@Atributo_7", objE_Midas.Atributo_7);
            cmd.Parameters.AddWithValue("@Atributo_8", objE_Midas.Atributo_8);
            cmd.Parameters.AddWithValue("@Atributo_9", objE_Midas.Atributo_9);
            cmd.Parameters.AddWithValue("@Atributo_10", objE_Midas.Atributo_10);
            cmd.Parameters.AddWithValue("@Ofrecimiento_1", objE_Midas.Ofrecimiento_1);
            cmd.Parameters.AddWithValue("@Ofrecimiento_2", objE_Midas.Ofrecimiento_2);
            cmd.Parameters.AddWithValue("@Ofrecimiento_3", objE_Midas.Ofrecimiento_3);
            cmd.Parameters.AddWithValue("@Ofrecimiento_4", objE_Midas.Ofrecimiento_4);
            cmd.Parameters.AddWithValue("@Ofrecimiento_5", objE_Midas.Ofrecimiento_5);
            cmd.Parameters.AddWithValue("@Ofrecimiento_6", objE_Midas.Ofrecimiento_6);
            cmd.Parameters.AddWithValue("@Ofrecimiento_7", objE_Midas.Ofrecimiento_7);
            cmd.Parameters.AddWithValue("@Ofrecimiento_8", objE_Midas.Ofrecimiento_8);
            cmd.Parameters.AddWithValue("@Ofrecimiento_9", objE_Midas.Ofrecimiento_9);
            cmd.Parameters.AddWithValue("@Ofrecimiento_10", objE_Midas.Ofrecimiento_10);
            
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar almacenar,modificar o eliminar datos de la tabla de midas", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public DataSet Consulta_Temporal_Midas(double pCuenta)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Temporal_Activacion]";
                cmd.Parameters.AddWithValue("@Cuenta_Cliente", pCuenta);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar llos casos en seguimiento", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Registro(double pCuenta)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Valida_Cuentas_Midas]";
                cmd.Parameters.AddWithValue("@Cuenta_Cliente", pCuenta);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar llos casos en seguimiento", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public int abcMidas_Log(string pAccion, E_Midas objE_Midas)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abc_Midas_Activacion_Log", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Fecha_de_Gestion", objE_Midas.Fecha_de_Gestion);
            cmd.Parameters.AddWithValue("@Usuario_de_Gestion", objE_Midas.Usuario_de_Gestion);
            cmd.Parameters.AddWithValue("@Aliado_de_Gestion", objE_Midas.Aliado_Gestion);
            cmd.Parameters.AddWithValue("@Ciudad", objE_Midas.Ciudad);
            cmd.Parameters.AddWithValue("@Nodo", objE_Midas.Nodo);
            cmd.Parameters.AddWithValue("@Mix_Basico", objE_Midas.Mix_Basico);
            cmd.Parameters.AddWithValue("@Tipo_Servicio", objE_Midas.Tipo_Servicio);
            cmd.Parameters.AddWithValue("@ciclo_Facturacion", objE_Midas.Ciclo_Facturacion);
            cmd.Parameters.AddWithValue("@Renta", objE_Midas.Renta);
            cmd.Parameters.AddWithValue("@Tipo_Tv", objE_Midas.Tipo_Tv);
            cmd.Parameters.AddWithValue("@Velocidad_Internet", objE_Midas.Velovidad_Internet);
            cmd.Parameters.AddWithValue("@Cuenta_Cliente", objE_Midas.Cuenta_Cliente);
            cmd.Parameters.AddWithValue("@Estado_Cuenta", objE_Midas.Estado_Cuenta);
            cmd.Parameters.AddWithValue("@Motivo_Desconexion", objE_Midas.Motivo_Desconexion);
            cmd.Parameters.AddWithValue("@Nombre_Cliente", objE_Midas.Nombre_Cliente);
            cmd.Parameters.AddWithValue("@Apellido_1", objE_Midas.Apellido_1);
            cmd.Parameters.AddWithValue("@Apellido_2", objE_Midas.Apellido_2);
            cmd.Parameters.AddWithValue("@Contrato", objE_Midas.Contrato);
            cmd.Parameters.AddWithValue("@Telefono_1", objE_Midas.Telefono_1);
            cmd.Parameters.AddWithValue("@Telefono_2", objE_Midas.Telefono_2);
            cmd.Parameters.AddWithValue("@Telefono_3", objE_Midas.Telefono_3);
            cmd.Parameters.AddWithValue("@Movil_1", objE_Midas.Movil_1);
            cmd.Parameters.AddWithValue("@Movil_2", objE_Midas.Movil_2);
            cmd.Parameters.AddWithValue("@Movil_3", objE_Midas.Movil_3);
            cmd.Parameters.AddWithValue("@Estrato", objE_Midas.Estrato);
            cmd.Parameters.AddWithValue("@Historico", objE_Midas.Historico);
            cmd.Parameters.AddWithValue("@Tipo_hipotesis", objE_Midas.Tipo_Hipotesis);
            cmd.Parameters.AddWithValue("@Tipo_Contacto", objE_Midas.Tipo_Contacto);
            cmd.Parameters.AddWithValue("@Gestion", objE_Midas.Gestion);
            cmd.Parameters.AddWithValue("@Cierre", objE_Midas.Cierre);
            cmd.Parameters.AddWithValue("@Razon", objE_Midas.Razon);
            cmd.Parameters.AddWithValue("@Causa", objE_Midas.Causa);
            cmd.Parameters.AddWithValue("@Id_Estado", objE_Midas.Id_Estado);
            cmd.Parameters.AddWithValue("@Nps", objE_Midas.Nps);
            cmd.Parameters.AddWithValue("@Campana", objE_Midas.Campana);
            cmd.Parameters.AddWithValue("@Estado_Campana", objE_Midas.Estado_Campana);
            cmd.Parameters.AddWithValue("@Satisfaccion", objE_Midas.Satisfaccion);
            cmd.Parameters.AddWithValue("@Atributo_1", objE_Midas.Atributo_1);
            cmd.Parameters.AddWithValue("@Atributo_2", objE_Midas.Atributo_2);
            cmd.Parameters.AddWithValue("@Atributo_3", objE_Midas.Atributo_3);
            cmd.Parameters.AddWithValue("@Atributo_4", objE_Midas.Atributo_4);
            cmd.Parameters.AddWithValue("@Atributo_5", objE_Midas.Atributo_5);
            cmd.Parameters.AddWithValue("@Atributo_6", objE_Midas.Atributo_6);
            cmd.Parameters.AddWithValue("@Atributo_7", objE_Midas.Atributo_7);
            cmd.Parameters.AddWithValue("@Atributo_8", objE_Midas.Atributo_8);
            cmd.Parameters.AddWithValue("@Atributo_9", objE_Midas.Atributo_9);
            cmd.Parameters.AddWithValue("@Atributo_10", objE_Midas.Atributo_10);
            cmd.Parameters.AddWithValue("@Ofrecimiento_1", objE_Midas.Ofrecimiento_1);
            cmd.Parameters.AddWithValue("@Ofrecimiento_2", objE_Midas.Ofrecimiento_2);
            cmd.Parameters.AddWithValue("@Ofrecimiento_3", objE_Midas.Ofrecimiento_3);
            cmd.Parameters.AddWithValue("@Ofrecimiento_4", objE_Midas.Ofrecimiento_4);
            cmd.Parameters.AddWithValue("@Ofrecimiento_5", objE_Midas.Ofrecimiento_5);
            cmd.Parameters.AddWithValue("@Ofrecimiento_6", objE_Midas.Ofrecimiento_6);
            cmd.Parameters.AddWithValue("@Ofrecimiento_7", objE_Midas.Ofrecimiento_7);
            cmd.Parameters.AddWithValue("@Ofrecimiento_8", objE_Midas.Ofrecimiento_8);
            cmd.Parameters.AddWithValue("@Ofrecimiento_9", objE_Midas.Ofrecimiento_9);
            cmd.Parameters.AddWithValue("@Ofrecimiento_10", objE_Midas.Ofrecimiento_10);

            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar almacenar,modificar o eliminar datos de la tabla de midas log ", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public DataSet Consulta_Midas_Admin(string pFecha_Inicial,string pFecha_Final)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Midas_Admin]";
                cmd.Parameters.AddWithValue("@Fecha_Gestion_1", pFecha_Inicial);
                cmd.Parameters.AddWithValue("@Fecha_Gestion_2", pFecha_Final);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar la informacion de la base del log de midas", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
    }

    
}
