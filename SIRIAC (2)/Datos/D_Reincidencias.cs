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
    public class D_Reincidencias : D_Conexion_BD
    {
        public D_Reincidencias () { }
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
                cmd.CommandText = "[dbo].[Consulta_Cliente_Temporal_Reincidencia]";
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
        public DataSet Consulta_Cliente_Reincidencias_Gestionado(double pCuenta_Cliente)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Cliente_Reincidencias_Gestionado]";
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
        public int abc_Reincidencias(string pAccion, E_Reincidencias Obj_Reincidencias)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abcReincidencias", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Fecha_Gestion", Obj_Reincidencias.Fecha_Gestion);
            cmd.Parameters.AddWithValue("@Usuario_Gestion", Obj_Reincidencias.Usuario_Gestion);
            cmd.Parameters.AddWithValue("@Nombre_Usuario_gestion", Obj_Reincidencias.Nombre_Usuario_Gestion);
            cmd.Parameters.AddWithValue("@Aliado_Gestion", Obj_Reincidencias.Aliado_Gestion);
            cmd.Parameters.AddWithValue("@Operacion_Gestion", Obj_Reincidencias.Linea_Gestion);
            cmd.Parameters.AddWithValue("@Cuenta_Cliente", Obj_Reincidencias.Cuenta_Cliente);
            cmd.Parameters.AddWithValue("@Nombre_Cliente", Obj_Reincidencias.Nombre_Cliente);
            cmd.Parameters.AddWithValue("@Apellido_Cliente", Obj_Reincidencias.Apellido_Cliente);
            cmd.Parameters.AddWithValue("@Direccion_Instalacion", Obj_Reincidencias.Direccion_Instalacion);
            cmd.Parameters.AddWithValue("@Direccion_correspondencia", Obj_Reincidencias.Direccion_Correspondencia);
            cmd.Parameters.AddWithValue("@Correo_electronico", Obj_Reincidencias.Correo_Actual);
            cmd.Parameters.AddWithValue("@Telefono_1", Obj_Reincidencias.Telefono_1);
            cmd.Parameters.AddWithValue("@Telefono_2", Obj_Reincidencias.Telefono_2);
            cmd.Parameters.AddWithValue("@Telefono_3", Obj_Reincidencias.Telefono_3);
            cmd.Parameters.AddWithValue("@Movil_1", Obj_Reincidencias.Movil_1);
            cmd.Parameters.AddWithValue("@Movil_2", Obj_Reincidencias.Movil_2);
            cmd.Parameters.AddWithValue("@Paquete_actual", Obj_Reincidencias.Paquete_Actual);
            cmd.Parameters.AddWithValue("@Tipo_de_contacto", Obj_Reincidencias.Tipo_Contacto);
            cmd.Parameters.AddWithValue("@Gestion", Obj_Reincidencias.Gestion);
            cmd.Parameters.AddWithValue("@Cierre", Obj_Reincidencias.Cierre);
            cmd.Parameters.AddWithValue("@Razon", Obj_Reincidencias.Razon);
            cmd.Parameters.AddWithValue("@Motivo_Reincidencia", Obj_Reincidencias.Motivo_Reincidencia);
            cmd.Parameters.AddWithValue("@Ofrecimiento_1", Obj_Reincidencias.Ofrecimiento_1);
            cmd.Parameters.AddWithValue("@Ofrecimiento_2", Obj_Reincidencias.Ofrecimiento_2);
            cmd.Parameters.AddWithValue("@Ofrecimiento_3", Obj_Reincidencias.Ofrecimiento_3);
            cmd.Parameters.AddWithValue("@Attributo_1", Obj_Reincidencias.Atributo_1);
            cmd.Parameters.AddWithValue("@Attributo_2", Obj_Reincidencias.Atributo_2);
            cmd.Parameters.AddWithValue("@Attributo_3", Obj_Reincidencias.Atributo_3);
            cmd.Parameters.AddWithValue("@Observaciones", Obj_Reincidencias.Observaciones);

            
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            
               
            
                Cerrar_Conexion();
                cmd.Dispose();
            
            return Resultado;
        }
        public int abcLog_Reincidencias(string pAccion, E_Reincidencias Obj_Reincidencias)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abcLog_Reincidencias", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Fecha_Gestion", Obj_Reincidencias.Fecha_Gestion);
            cmd.Parameters.AddWithValue("@Usuario_Gestion", Obj_Reincidencias.Usuario_Gestion);
            cmd.Parameters.AddWithValue("@Nombre_Usuario_gestion", Obj_Reincidencias.Nombre_Usuario_Gestion);
            cmd.Parameters.AddWithValue("@Aliado_Gestion", Obj_Reincidencias.Aliado_Gestion);
            cmd.Parameters.AddWithValue("@Operacion_Gestion", Obj_Reincidencias.Linea_Gestion);
            cmd.Parameters.AddWithValue("@Cuenta_Cliente", Obj_Reincidencias.Cuenta_Cliente);
            cmd.Parameters.AddWithValue("@Nombre_Cliente", Obj_Reincidencias.Nombre_Cliente);
            cmd.Parameters.AddWithValue("@Apellido_Cliente", Obj_Reincidencias.Apellido_Cliente);
            cmd.Parameters.AddWithValue("@Direccion_Instalacion", Obj_Reincidencias.Direccion_Instalacion);
            cmd.Parameters.AddWithValue("@Direccion_correspondencia", Obj_Reincidencias.Direccion_Correspondencia);
            cmd.Parameters.AddWithValue("@Correo_electronico", Obj_Reincidencias.Correo_Actual);
            cmd.Parameters.AddWithValue("@Telefono_1", Obj_Reincidencias.Telefono_1);
            cmd.Parameters.AddWithValue("@Telefono_2", Obj_Reincidencias.Telefono_2);
            cmd.Parameters.AddWithValue("@Telefono_3", Obj_Reincidencias.Telefono_3);
            cmd.Parameters.AddWithValue("@Movil_1", Obj_Reincidencias.Movil_1);
            cmd.Parameters.AddWithValue("@Movil_2", Obj_Reincidencias.Movil_2);
            cmd.Parameters.AddWithValue("@Paquete_actual", Obj_Reincidencias.Paquete_Actual);
            cmd.Parameters.AddWithValue("@Tipo_de_contacto", Obj_Reincidencias.Tipo_Contacto);
            cmd.Parameters.AddWithValue("@Gestion", Obj_Reincidencias.Gestion);
            cmd.Parameters.AddWithValue("@Cierre", Obj_Reincidencias.Cierre);
            cmd.Parameters.AddWithValue("@Razon", Obj_Reincidencias.Razon);
            cmd.Parameters.AddWithValue("@Motivo_Reincidencia", Obj_Reincidencias.Motivo_Reincidencia);
            cmd.Parameters.AddWithValue("@Ofrecimiento_1", Obj_Reincidencias.Ofrecimiento_1);
            cmd.Parameters.AddWithValue("@Ofrecimiento_2", Obj_Reincidencias.Ofrecimiento_2);
            cmd.Parameters.AddWithValue("@Ofrecimiento_3", Obj_Reincidencias.Ofrecimiento_3);
            cmd.Parameters.AddWithValue("@Attributo_1", Obj_Reincidencias.Atributo_1);
            cmd.Parameters.AddWithValue("@Attributo_2", Obj_Reincidencias.Atributo_2);
            cmd.Parameters.AddWithValue("@Attributo_3", Obj_Reincidencias.Atributo_3);
            cmd.Parameters.AddWithValue("@Observaciones", Obj_Reincidencias.Observaciones);

            
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            
               
            
                Cerrar_Conexion();
                cmd.Dispose();
            
            return Resultado;
        }

    }
}
