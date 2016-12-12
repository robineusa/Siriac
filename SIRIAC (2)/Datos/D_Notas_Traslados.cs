using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
    public class D_Notas_Traslados: D_Conexion_BD
    {
        public D_Notas_Traslados() { }

        public int Inserta_Nota_Traslado(string pAccion, E_Notas_Traslados objE_Notas_Traslados)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("Inserta_Notas_Traslados", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Id_Nota", objE_Notas_Traslados.Id_Nota);
            cmd.Parameters.AddWithValue("@Id_Traslado", objE_Notas_Traslados.Id_Traslado);
            cmd.Parameters.AddWithValue("@Cuenta_Cliente", objE_Notas_Traslados.Cuenta_Cliente);
            cmd.Parameters.AddWithValue("@Usuario", objE_Notas_Traslados.Usuario);
            cmd.Parameters.AddWithValue("@Nombre_Linea_Nota", objE_Notas_Traslados.Nombre_Linea_Nota);
            cmd.Parameters.AddWithValue("@Fecha_Nota", objE_Notas_Traslados.Fecha_Nota);
            cmd.Parameters.AddWithValue("@Hora_Nota", objE_Notas_Traslados.Hora_Nota);
            cmd.Parameters.AddWithValue("@Nota", objE_Notas_Traslados.Nota);
            cmd.Parameters.AddWithValue("@Razon", objE_Notas_Traslados.Razon);
            cmd.Parameters.AddWithValue("@Subrazon", objE_Notas_Traslados.Subrazon);
            cmd.Parameters.AddWithValue("@Estado", objE_Notas_Traslados.Estado);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar insertar la nota del traslado", e);
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
