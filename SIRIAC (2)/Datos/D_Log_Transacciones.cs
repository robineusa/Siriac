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
    public class D_Log_Transacciones: D_Conexion_BD
    {
        public D_Log_Transacciones() { }
        public int acb_Log_Transacciones (E_Log_Transacciones Obj_Ent_Transacciones){
        
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("Registro_Log_de_Transacciones", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id_Log", Obj_Ent_Transacciones.Id_Log);
            cmd.Parameters.AddWithValue("@Id_Ingreso", Obj_Ent_Transacciones.Id_Ingreso);
            cmd.Parameters.AddWithValue("@Transaccion", Obj_Ent_Transacciones.Transaccion);
            cmd.Parameters.AddWithValue("@Usuario", Obj_Ent_Transacciones.Usuario);
            cmd.Parameters.AddWithValue("@Fecha", Obj_Ent_Transacciones.Fecha);
            cmd.Parameters.AddWithValue("@Hora", Obj_Ent_Transacciones.Hora);
            
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar registrar la transaccion realizada", e);
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
