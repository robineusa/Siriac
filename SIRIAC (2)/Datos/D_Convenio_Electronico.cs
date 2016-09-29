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
    public class D_Convenio_Electronico :D_Conexion_BD
    {
        public D_Convenio_Electronico() { }

        public int abc_Convenioo_Electronico(string pAccion, E_Convenio_Electronico Obj_Convenio_Electronico)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abcConvenio_Electronico", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Fecha_Gestion",Obj_Convenio_Electronico.Fecha_Gestion);
            cmd.Parameters.AddWithValue("@Hora_Gestion",Obj_Convenio_Electronico.Hora_Gestion);
            cmd.Parameters.AddWithValue("@Usuario_Gestion",Obj_Convenio_Electronico.Usuario_Gestion);
            cmd.Parameters.AddWithValue("@Aliado_Gestion",Obj_Convenio_Electronico.Aliado_Gestion);
            cmd.Parameters.AddWithValue("@Linea_Gestion",Obj_Convenio_Electronico.Linea_Gestion);
            cmd.Parameters.AddWithValue("@Cuenta_Cliente",Obj_Convenio_Electronico.Cuenta_Cliente);
            cmd.Parameters.AddWithValue("@Nombre_Cliente",Obj_Convenio_Electronico.Nombre_Cliente);
            cmd.Parameters.AddWithValue("@Apellido_Cliente",Obj_Convenio_Electronico.Apellido_Cliente);
            cmd.Parameters.AddWithValue("@Direccion_Instalacion",Obj_Convenio_Electronico.Direccion_Instalacion);
            cmd.Parameters.AddWithValue("@Direccion_Correspondencia_Actual",Obj_Convenio_Electronico.Direccion_Correspondencia);
            cmd.Parameters.AddWithValue("@Telefono_Telmex",Obj_Convenio_Electronico.Telefono_Telmex);
            cmd.Parameters.AddWithValue("@Telefono_1",Obj_Convenio_Electronico.Telefono_1);
            cmd.Parameters.AddWithValue("@Telefono_2",Obj_Convenio_Electronico.Telefono_2);
            cmd.Parameters.AddWithValue("@Telefono_3",Obj_Convenio_Electronico.Telefono_3);
            cmd.Parameters.AddWithValue("@Movil_Actual",Obj_Convenio_Electronico.Movil_Actual);
            cmd.Parameters.AddWithValue("@Correo_Actual",Obj_Convenio_Electronico.Correo_Actual);
            cmd.Parameters.AddWithValue("@Tipo_Contacto",Obj_Convenio_Electronico.Tipo_Contacto);
            cmd.Parameters.AddWithValue("@Cierre",Obj_Convenio_Electronico.Cierre);
            cmd.Parameters.AddWithValue("@Razon",Obj_Convenio_Electronico.Razon);
            cmd.Parameters.AddWithValue("@Movil_Nuevo",Obj_Convenio_Electronico.Movil_Nuevo);
            cmd.Parameters.AddWithValue("@Nuevo_Correo",Obj_Convenio_Electronico.Nuevo_Correo);
            cmd.Parameters.AddWithValue("@Nueva_Direccion_Correspondencia", Obj_Convenio_Electronico.Direccion_de_Correspondencia_Nueva);
            
             try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar almacenar,modificar o eliminar datos de la tabla de convenio electronico", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public int abc_Convenioo_Electronico_Log(string pAccion, E_Convenio_Electronico Obj_Convenio_Electronico)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abcConvenio_Electronico_Log", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Fecha_Gestion", Obj_Convenio_Electronico.Fecha_Gestion);
            cmd.Parameters.AddWithValue("@Hora_Gestion", Obj_Convenio_Electronico.Hora_Gestion);
            cmd.Parameters.AddWithValue("@Usuario_Gestion", Obj_Convenio_Electronico.Usuario_Gestion);
            cmd.Parameters.AddWithValue("@Aliado_Gestion", Obj_Convenio_Electronico.Aliado_Gestion);
            cmd.Parameters.AddWithValue("@Linea_Gestion", Obj_Convenio_Electronico.Linea_Gestion);
            cmd.Parameters.AddWithValue("@Cuenta_Cliente", Obj_Convenio_Electronico.Cuenta_Cliente);
            cmd.Parameters.AddWithValue("@Nombre_Cliente", Obj_Convenio_Electronico.Nombre_Cliente);
            cmd.Parameters.AddWithValue("@Apellido_Cliente", Obj_Convenio_Electronico.Apellido_Cliente);
            cmd.Parameters.AddWithValue("@Direccion_Instalacion", Obj_Convenio_Electronico.Direccion_Instalacion);
            cmd.Parameters.AddWithValue("@Direccion_Correspondencia_Actual", Obj_Convenio_Electronico.Direccion_Correspondencia);
            cmd.Parameters.AddWithValue("@Telefono_Telmex", Obj_Convenio_Electronico.Telefono_Telmex);
            cmd.Parameters.AddWithValue("@Telefono_1", Obj_Convenio_Electronico.Telefono_1);
            cmd.Parameters.AddWithValue("@Telefono_2", Obj_Convenio_Electronico.Telefono_2);
            cmd.Parameters.AddWithValue("@Telefono_3", Obj_Convenio_Electronico.Telefono_3);
            cmd.Parameters.AddWithValue("@Movil_Actual", Obj_Convenio_Electronico.Movil_Actual);
            cmd.Parameters.AddWithValue("@Correo_Actual", Obj_Convenio_Electronico.Correo_Actual);
            cmd.Parameters.AddWithValue("@Tipo_Contacto", Obj_Convenio_Electronico.Tipo_Contacto);
            cmd.Parameters.AddWithValue("@Cierre", Obj_Convenio_Electronico.Cierre);
            cmd.Parameters.AddWithValue("@Razon", Obj_Convenio_Electronico.Razon);
            cmd.Parameters.AddWithValue("@Movil_Nuevo", Obj_Convenio_Electronico.Movil_Nuevo);
            cmd.Parameters.AddWithValue("@Nuevo_Correo", Obj_Convenio_Electronico.Nuevo_Correo);
            cmd.Parameters.AddWithValue("@Nueva_Direccion_Correspondencia", Obj_Convenio_Electronico.Direccion_de_Correspondencia_Nueva);

            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar almacenar,modificar o eliminar datos de la tabla de convenio electronico", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
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
                cmd.CommandText = "[dbo].[Valida_Registro_Convenio]";
                cmd.Parameters.AddWithValue("@Cuenta_Cliente", pCuenta);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al sconsultar el registro en convenio electronico", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Admin_Convenio(string pFecha_Inicial, string pFecha_Final)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Admin_Convenio_Electronico]";
                cmd.Parameters.AddWithValue("@Fecha_Inicial", pFecha_Inicial);
                cmd.Parameters.AddWithValue("@Fecha_Final", pFecha_Final);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al sconsultar el registro en convenio electronico", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Falta_Convenio(string pCuenta)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Falta_Convenio_Electronico]";
                cmd.Parameters.AddWithValue("@CUENTA", pCuenta);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al sconsultar el registro en convenio electronico temporal", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
