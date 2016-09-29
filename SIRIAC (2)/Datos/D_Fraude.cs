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
    public class D_Fraude: D_Conexion_BD
    {
        public D_Fraude() { }
        public DataSet Consulta_Cuenta_Fraude(double pCuenta_Cliente)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Cuentas_Fraude]";
                cmd.Parameters.AddWithValue("@Cuenta_Cliente", pCuenta_Cliente);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar la informacion de la tabla temporal de fraudes", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public int abcFraudes(string pAccion, E_Fraude objE_Fraude)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abcFraudes", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Fecha_gestion", objE_Fraude.Fecha_gestion);
            cmd.Parameters.AddWithValue("@Usuario_gestion", objE_Fraude.Usuario_gestion);
            cmd.Parameters.AddWithValue("@Aliado_gestion", objE_Fraude.Aliado_gestion);
            cmd.Parameters.AddWithValue("@Cuenta_cliente", objE_Fraude.Cuenta_cliente);
            cmd.Parameters.AddWithValue("@Home_pass", objE_Fraude.Home_pass);
            cmd.Parameters.AddWithValue("@Estado", objE_Fraude.Estado);
            cmd.Parameters.AddWithValue("@Nombre_cliente", objE_Fraude.Nombre_cliente);
            cmd.Parameters.AddWithValue("@Apellido_cliente", objE_Fraude.Apellido_cliente);
            cmd.Parameters.AddWithValue("@Direccion_instalacion", objE_Fraude.Direccion_instalacion);
            cmd.Parameters.AddWithValue("@Direccion_correspondencia", objE_Fraude.Direccion_correspondencia);
            cmd.Parameters.AddWithValue("@Telefono_telmex", objE_Fraude.Telefono_telmex);
            cmd.Parameters.AddWithValue("@Telefono_1", objE_Fraude.Telefono_1);
            cmd.Parameters.AddWithValue("@Telefono_2", objE_Fraude.Telefono_2);
            cmd.Parameters.AddWithValue("@Telefono_3", objE_Fraude.Telefono_3);
            cmd.Parameters.AddWithValue("@Movil_postpago", objE_Fraude.Movil_postpago);
            cmd.Parameters.AddWithValue("@Correo", objE_Fraude.Correo);
            cmd.Parameters.AddWithValue("@Nodo", objE_Fraude.Nodo);
            cmd.Parameters.AddWithValue("@Red", objE_Fraude.Red);
            cmd.Parameters.AddWithValue("@Division", objE_Fraude.Division);
            cmd.Parameters.AddWithValue("@Area", objE_Fraude.Area);
            cmd.Parameters.AddWithValue("@Zona", objE_Fraude.Zona);
            cmd.Parameters.AddWithValue("@Distrito", objE_Fraude.Distrito);
            cmd.Parameters.AddWithValue("@Nombre_comunidad", objE_Fraude.Nombre_comunidad);
            cmd.Parameters.AddWithValue("@Departamento", objE_Fraude.Departamento);
            cmd.Parameters.AddWithValue("@Estrato", objE_Fraude.Estrato);
            cmd.Parameters.AddWithValue("@Tipo_cliente", objE_Fraude.Tipo_cliente);
            cmd.Parameters.AddWithValue("@Servicios", objE_Fraude.Servicios);
            cmd.Parameters.AddWithValue("@Fecha_digitalizacion", objE_Fraude.Fecha_digitacion);
            cmd.Parameters.AddWithValue("@Telefonos_fijos_buro", objE_Fraude.Telefonos_fijos_buro);
            cmd.Parameters.AddWithValue("@Telefonos_moviles_buro", objE_Fraude.Telefonos_moviles_buro);
            cmd.Parameters.AddWithValue("@Tipo_contacto", objE_Fraude.Tipo_contacto);
            cmd.Parameters.AddWithValue("@Cierre", objE_Fraude.Cierre);
            cmd.Parameters.AddWithValue("@Razon", objE_Fraude.Razon);
            cmd.Parameters.AddWithValue("@Observaciones", objE_Fraude.Observaciones);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar almacenar,modificar o eliminar datos de la tabla de gestion fraudes", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public int abcLog_Fraudes(string pAccion, E_Fraude objE_Fraude)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abcLog_Fraudes", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Fecha_gestion", objE_Fraude.Fecha_gestion);
            cmd.Parameters.AddWithValue("@Usuario_gestion", objE_Fraude.Usuario_gestion);
            cmd.Parameters.AddWithValue("@Aliado_gestion", objE_Fraude.Aliado_gestion);
            cmd.Parameters.AddWithValue("@Cuenta_cliente", objE_Fraude.Cuenta_cliente);
            cmd.Parameters.AddWithValue("@Home_pass", objE_Fraude.Home_pass);
            cmd.Parameters.AddWithValue("@Estado", objE_Fraude.Estado);
            cmd.Parameters.AddWithValue("@Nombre_cliente", objE_Fraude.Nombre_cliente);
            cmd.Parameters.AddWithValue("@Apellido_cliente", objE_Fraude.Apellido_cliente);
            cmd.Parameters.AddWithValue("@Direccion_instalacion", objE_Fraude.Direccion_instalacion);
            cmd.Parameters.AddWithValue("@Direccion_correspondencia", objE_Fraude.Direccion_correspondencia);
            cmd.Parameters.AddWithValue("@Telefono_telmex", objE_Fraude.Telefono_telmex);
            cmd.Parameters.AddWithValue("@Telefono_1", objE_Fraude.Telefono_1);
            cmd.Parameters.AddWithValue("@Telefono_2", objE_Fraude.Telefono_2);
            cmd.Parameters.AddWithValue("@Telefono_3", objE_Fraude.Telefono_3);
            cmd.Parameters.AddWithValue("@Movil_postpago", objE_Fraude.Movil_postpago);
            cmd.Parameters.AddWithValue("@Correo", objE_Fraude.Correo);
            cmd.Parameters.AddWithValue("@Nodo", objE_Fraude.Nodo);
            cmd.Parameters.AddWithValue("@Red", objE_Fraude.Red);
            cmd.Parameters.AddWithValue("@Division", objE_Fraude.Division);
            cmd.Parameters.AddWithValue("@Area", objE_Fraude.Area);
            cmd.Parameters.AddWithValue("@Zona", objE_Fraude.Zona);
            cmd.Parameters.AddWithValue("@Distrito", objE_Fraude.Distrito);
            cmd.Parameters.AddWithValue("@Nombre_comunidad", objE_Fraude.Nombre_comunidad);
            cmd.Parameters.AddWithValue("@Departamento", objE_Fraude.Departamento);
            cmd.Parameters.AddWithValue("@Estrato", objE_Fraude.Estrato);
            cmd.Parameters.AddWithValue("@Tipo_cliente", objE_Fraude.Tipo_cliente);
            cmd.Parameters.AddWithValue("@Servicios", objE_Fraude.Servicios);
            cmd.Parameters.AddWithValue("@Fecha_digitalizacion", objE_Fraude.Fecha_digitacion);
            cmd.Parameters.AddWithValue("@Telefonos_fijos_buro", objE_Fraude.Telefonos_fijos_buro);
            cmd.Parameters.AddWithValue("@Telefonos_moviles_buro", objE_Fraude.Telefonos_moviles_buro);
            cmd.Parameters.AddWithValue("@Tipo_contacto", objE_Fraude.Tipo_contacto);
            cmd.Parameters.AddWithValue("@Cierre", objE_Fraude.Cierre);
            cmd.Parameters.AddWithValue("@Razon", objE_Fraude.Razon);
            cmd.Parameters.AddWithValue("@Observaciones", objE_Fraude.Observaciones);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar almacenar,modificar o eliminar datos de la tabla de log gestion fraudes", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public DataSet Consulta_Cuenta_Gestionada_Fraude(double pCuenta_Cliente)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_cuenta_Fraudes]";
                cmd.Parameters.AddWithValue("@Cuenta_Cliente", pCuenta_Cliente);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar la informacion de la tabla temporal de fraudes", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
