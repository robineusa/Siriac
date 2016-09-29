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
    public class D_Ofrecimientos_Incremento : D_Conexion_BD
    {
        public D_Ofrecimientos_Incremento() { }
        public int Registro_de_Ofrecimientos(E_Ofrecimientos_Incremento Obj_R_Ofrecimiento) {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("Inserta_Ofrecimiento_Incremento", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            
            cmd.Parameters.AddWithValue("@Fecha_Gestion", Obj_R_Ofrecimiento.Fecha_Gestion);
            cmd.Parameters.AddWithValue("@Usuario_Gestion", Obj_R_Ofrecimiento.Usuario_Gestion);
            cmd.Parameters.AddWithValue("@Cuenta_Cliente", Obj_R_Ofrecimiento.Cuenta_Cliente);
            cmd.Parameters.AddWithValue("@Periodo_Incremento", Obj_R_Ofrecimiento.Periodo_Incremento);
            cmd.Parameters.AddWithValue("@Ofrecimiento_1", Obj_R_Ofrecimiento.Ofrecimiento_1);
            cmd.Parameters.AddWithValue("@Ofrecimiento_2", Obj_R_Ofrecimiento.Ofrecimiento_2);
            cmd.Parameters.AddWithValue("@Ofrecimiento_3", Obj_R_Ofrecimiento.Ofrecimiento_3);
            cmd.Parameters.AddWithValue("@Ofrecimiento_4", Obj_R_Ofrecimiento.Ofrecimiento_4);
            cmd.Parameters.AddWithValue("@Ofrecimiento_5", Obj_R_Ofrecimiento.Ofrecimiento_5);
            cmd.Parameters.AddWithValue("@Ofrecimiento_6", Obj_R_Ofrecimiento.Ofrecimiento_6);
            
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar almacenar la informacion del ofrecimiento realizado", e);
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
