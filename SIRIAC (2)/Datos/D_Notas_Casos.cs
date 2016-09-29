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
    public class D_Notas_Casos: D_Conexion_BD
    {
        public D_Notas_Casos() { }
        public int Inserta_Nota_Inicial(string pAccion, E_Notas_Casos objE_Notas_Casos_Inicial)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("Inserta_Notas_Casos", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Id_Nota",objE_Notas_Casos_Inicial.Id_Nota );
            cmd.Parameters.AddWithValue("@Id_Ingreso", objE_Notas_Casos_Inicial.Id_Ingreso);
            cmd.Parameters.AddWithValue("@Cuenta_Cliente", objE_Notas_Casos_Inicial.Cuenta_Cliente);
            cmd.Parameters.AddWithValue("@Ticket", objE_Notas_Casos_Inicial.Ticket);
            cmd.Parameters.AddWithValue("@Usuario", objE_Notas_Casos_Inicial.Usuario);
            cmd.Parameters.AddWithValue("@Nombre_Linea_Nota", objE_Notas_Casos_Inicial.Nombre_Linea_Nota);
            cmd.Parameters.AddWithValue("@Fecha_Nota", objE_Notas_Casos_Inicial.Fecha_Nota);
            cmd.Parameters.AddWithValue("@Hora_Nota", objE_Notas_Casos_Inicial.Hora_Nota);
            cmd.Parameters.AddWithValue("@Llamada_Cliente", objE_Notas_Casos_Inicial.Llamada_Cliente);
            cmd.Parameters.AddWithValue("@Nota", objE_Notas_Casos_Inicial.Nota);
            cmd.Parameters.AddWithValue("@Id_Estado", objE_Notas_Casos_Inicial.Id_Estado);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar insertar la nota inicial del caso", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public DataSet Consultar_Notas_Id(Int64 pId_Ingreso){
        SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Notas_Ingreso]";
                cmd.Parameters.AddWithValue("@Id_Ingreso", pId_Ingreso);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar las interacciones del caso", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
