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
    public class D_Cuentas_Genericas:D_Conexion_BD
    {
        public D_Cuentas_Genericas() { }

        public DataSet Consultar_Cuenta_Generica(Int64 pCuenta_Cliente) {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Cuenta_Universal]";
                cmd.Parameters.AddWithValue("@Cuenta", pCuenta_Cliente);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception ex)
            { throw new Exception("Error al seleccionar la cuenta universal", ex); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }

    }
}
