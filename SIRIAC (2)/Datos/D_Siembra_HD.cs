using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
    public class D_Siembra_HD : D_Conexion_BD
    {
        public DataSet Consulta_Falta_Siembra_HD(double pCuenta)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Falta_Siembra_HD]";
                cmd.Parameters.AddWithValue("@CUENTA", pCuenta);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al sconsultar el registro en siembra HD temporal", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Cliente_Activacion_Siembra_HD(double pCuenta)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Siembra_HD]";
                cmd.Parameters.AddWithValue("@CUENTA", pCuenta);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al sconsultar el registro en siembra HD", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public int abc_Activacion_Siembra_HD(string pAccion, E_Siembra_HD Obj_Entidad_Siembra_HD)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("Abc_Activacion_Siembra_HD", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Fecha_gestion", Obj_Entidad_Siembra_HD.Fecha_Gestion);
            cmd.Parameters.AddWithValue("@Usuario_gestion", Obj_Entidad_Siembra_HD.Usuario_Gestion);
            cmd.Parameters.AddWithValue("@Nombre_Usuario_gestion", Obj_Entidad_Siembra_HD.Nombre_Usuario_Gestion);
            cmd.Parameters.AddWithValue("@Aliado_gestion", Obj_Entidad_Siembra_HD.Aliado_Gestion);
            cmd.Parameters.AddWithValue("@Cuenta_cliente", Obj_Entidad_Siembra_HD.Cuenta_Cliente);
            cmd.Parameters.AddWithValue("@Ofrecimiento", Obj_Entidad_Siembra_HD.Ofrecimiento);
            cmd.Parameters.AddWithValue("@Aceptacion_Siembra_HD", Obj_Entidad_Siembra_HD.Aceptacion_Siembra_HD);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar almacenar,modificar o eliminar datos de la tabla de siembra HD", e);
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
