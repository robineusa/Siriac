using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
    public class D_Back_Elite: D_Conexion_BD
    {
        public D_Back_Elite() { }

        public int abc_Back_Elite(string pAccion, E_Back_Elite Obj_Back_Elite)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abc_Back_Elite", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Cuenta", Obj_Back_Elite.Cuenta);
            cmd.Parameters.AddWithValue("@LLSot", Obj_Back_Elite.LLSOT);
            cmd.Parameters.AddWithValue("@Tipo", Obj_Back_Elite.Tipo);
            cmd.Parameters.AddWithValue("@Detalle", Obj_Back_Elite.Detalle);
            cmd.Parameters.AddWithValue("@Fecha_Inicio", Obj_Back_Elite.Fecha_Inicio);
            cmd.Parameters.AddWithValue("@Hora_Inicio", Obj_Back_Elite.Hora_Inicio);
            cmd.Parameters.AddWithValue("@Usuario", Obj_Back_Elite.Usuario);
            cmd.Parameters.AddWithValue("@Notas", Obj_Back_Elite.Notas);
            cmd.Parameters.AddWithValue("@Nodo", Obj_Back_Elite.Nodo);
            cmd.Parameters.AddWithValue("@Aliado_Tec", Obj_Back_Elite.Aliado_Tec);
            cmd.Parameters.AddWithValue("@Divisional", Obj_Back_Elite.Divisional);
            cmd.Parameters.AddWithValue("@Red", Obj_Back_Elite.Red);
            cmd.Parameters.AddWithValue("@Cedula", Obj_Back_Elite.Cedula);
            cmd.Parameters.AddWithValue("@Nombre", Obj_Back_Elite.Nombre);
            cmd.Parameters.AddWithValue("@Cargo", Obj_Back_Elite.Cargo);
            cmd.Parameters.AddWithValue("@Estado", Obj_Back_Elite.Estado);
            cmd.Parameters.AddWithValue("@Aliado_Call", Obj_Back_Elite.Aliado_Call);
            cmd.Parameters.AddWithValue("@Operacion", Obj_Back_Elite.Operacion);
            cmd.Parameters.AddWithValue("@Mal_Escalado", Obj_Back_Elite.Mal_Escalado);
            cmd.Parameters.AddWithValue("@Error_Marcacion", Obj_Back_Elite.Error_Marcacion);
            cmd.Parameters.AddWithValue("@Notas_Incompletas", Obj_Back_Elite.Notas_Incompletas);
            cmd.Parameters.AddWithValue("@Gestion", Obj_Back_Elite.Gestion);
            cmd.Parameters.AddWithValue("@Observacion", Obj_Back_Elite.Observacion);
            cmd.Parameters.AddWithValue("@Estado_Ticket", Obj_Back_Elite.Estado_Ticket);
            cmd.Parameters.AddWithValue("@Tiempo_Horas ", Obj_Back_Elite.Tiempo_Horas);
            cmd.Parameters.AddWithValue("@Fecha_Final", Obj_Back_Elite.Fecha_Final);
            cmd.Parameters.AddWithValue("@Hora_Final", Obj_Back_Elite.Hora_Final);
            cmd.Parameters.AddWithValue("@ModMejoram", Obj_Back_Elite.ModMejoram);
            cmd.Parameters.AddWithValue("@Notas_Seg", Obj_Back_Elite.Notas_Seg);
            cmd.Parameters.AddWithValue("@Usuario_Ult_Gest", Obj_Back_Elite.Usuario_Ult_Gest);
            cmd.Parameters.AddWithValue("@Fecha_Ult_Gest", Obj_Back_Elite.Fecha_Ult_Gest);
            cmd.Parameters.AddWithValue("@Hora_Ult_Gest", Obj_Back_Elite.Hora_Ult_Gest);
            cmd.Parameters.AddWithValue("@Tipo_Trabajo", Obj_Back_Elite.Tipo_Trabajo);
            cmd.Parameters.AddWithValue("@Fecha_Agenda", Obj_Back_Elite.Fecha_Agenda);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar almacenar,modificar o eliminar datos de la tabla Elite", e);
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
