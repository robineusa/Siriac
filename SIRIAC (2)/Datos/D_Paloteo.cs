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
    public class D_Paloteo : D_Conexion_BD
    {
        public D_Paloteo() { }
        public DataSet Consulta_Admin_Paloteo(string pFecha_1, string pFecha_2)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[consulta_Paloteo]";
                cmd.Parameters.AddWithValue("@Fecha_Apertura_1", pFecha_1);
                cmd.Parameters.AddWithValue("@Fecha_Apertura_2", pFecha_2);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            
                Conexion.Close();
                cmd.Dispose();
           
            return ds;
        }
        
    }
}
