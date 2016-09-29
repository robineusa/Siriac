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
    public class D_Seguimientos_Midas : D_Conexion_BD
    {
        public D_Seguimientos_Midas() { }
        public int abcSeguimientos_Midas(string pAccion, E_Seguimientos_Midas Obj_Seguimientos_Midas)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abcSeguimientos_Midas", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Id_Seguimiento", Obj_Seguimientos_Midas.Id_Seguimiento);
            cmd.Parameters.AddWithValue("@Usuario_Creacion", Obj_Seguimientos_Midas.Usuario_Creacion);
            cmd.Parameters.AddWithValue("@Fecha_Creacion", Obj_Seguimientos_Midas.Fecha_Creacion);
            cmd.Parameters.AddWithValue("@Motivo_Seguimiento", Obj_Seguimientos_Midas.Motivo_Seguimiento);
            cmd.Parameters.AddWithValue("@Cuenta_Cliente", Obj_Seguimientos_Midas.Cuenta_Cliente);
            cmd.Parameters.AddWithValue("@Fecha_Hora_Seguimiento", Obj_Seguimientos_Midas.Fecha_Hora_Seguimiento);
            cmd.Parameters.AddWithValue("@Tipo_Hipotesis", Obj_Seguimientos_Midas.Tipo_Hipotesis);
           
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar almacenar,modificar o eliminar datos de la tabla de seguimientos midas", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public DataSet Consulta_Seguimientos_Midas(double pCuenta)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Select_Seguimientos_Midas]";
                cmd.Parameters.AddWithValue("@Cuenta_Cliente", pCuenta);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar los seguimientos midas", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
