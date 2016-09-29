using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
    public class D_Mejor_Oferta : D_Conexion_BD
    {
        public D_Mejor_Oferta(){}

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
                cmd.CommandText = "[dbo].[Consulta_Cliente_Temporal_Mejor_Oferta]";
                cmd.Parameters.AddWithValue("@Cuenta_Cliente", pCuenta_Cliente);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar los datos del cliente mejor oferta", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Cliente_Mejor_Oferta_Gestionado(double pCuenta_Cliente)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Cliente_Mejor_Oferta_Gestionado]";
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
        public int abcVentas_Inbound(string pAccion, E_Mejor_Oferta Obj_Mejor_Oferta)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("AbcVentas_Inbound", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@FECHA_GESTION", Obj_Mejor_Oferta.Fecha_Gestion);
            cmd.Parameters.AddWithValue("@USUARIO_GESTION", Obj_Mejor_Oferta.Usuario_Gestion);
            cmd.Parameters.AddWithValue("@ALIADO_GESTION", Obj_Mejor_Oferta.Aliado_Gestion);
            cmd.Parameters.AddWithValue("@CUENTA", Obj_Mejor_Oferta.Cuenta);
            cmd.Parameters.AddWithValue("@OFRECIMIENTO_1", Obj_Mejor_Oferta.Ofrecimiento_1_Envio);
            cmd.Parameters.AddWithValue("@OFRECIMIENTO_2", Obj_Mejor_Oferta.Ofrecimiento_2_Envio);
            cmd.Parameters.AddWithValue("@OFRECIMIENTO_3", Obj_Mejor_Oferta.Ofrecimiento_3_Envio);
            cmd.Parameters.AddWithValue("@P_SERVICIO_1", Obj_Mejor_Oferta.Servicio_1);
            cmd.Parameters.AddWithValue("@P_SERVICIO_2", Obj_Mejor_Oferta.Servicio_2);
            cmd.Parameters.AddWithValue("@P_SERVICIO_3", Obj_Mejor_Oferta.Servicio_3);
            cmd.Parameters.AddWithValue("@P_SERVICIO_4", Obj_Mejor_Oferta.Servicio_4);
            cmd.Parameters.AddWithValue("@P_SERVICIO_5", Obj_Mejor_Oferta.Servicio_5);
            cmd.Parameters.AddWithValue("@P_SERVICIO_6", Obj_Mejor_Oferta.Servicio_6);
            cmd.Parameters.AddWithValue("@P_SERVICIO_7", Obj_Mejor_Oferta.Servicio_7);
            cmd.Parameters.AddWithValue("@P_SERVICIO_8", Obj_Mejor_Oferta.Servicio_8);
            cmd.Parameters.AddWithValue("@P_SERVICIO_9", Obj_Mejor_Oferta.Servicio_9);
            cmd.Parameters.AddWithValue("@P_SERVICIO_10", Obj_Mejor_Oferta.Servicio_10);
            cmd.Parameters.AddWithValue("@P_SERVICIO_11", Obj_Mejor_Oferta.Servicio_11);
            cmd.Parameters.AddWithValue("@P_SERVICIO_12", Obj_Mejor_Oferta.Servicio_12);
            cmd.Parameters.AddWithValue("@P_SERVICIO_13", Obj_Mejor_Oferta.Servicio_13);
            cmd.Parameters.AddWithValue("@P_SERVICIO_14", Obj_Mejor_Oferta.Servicio_14);
            cmd.Parameters.AddWithValue("@P_SERVICIO_15", Obj_Mejor_Oferta.Servicio_15);
            cmd.Parameters.AddWithValue("@P_SERVICIO_16", Obj_Mejor_Oferta.Servicio_16);
            cmd.Parameters.AddWithValue("@P_SERVICIO_17", Obj_Mejor_Oferta.Servicio_17);
            cmd.Parameters.AddWithValue("@P_SERVICIO_18", Obj_Mejor_Oferta.Servicio_18);
            cmd.Parameters.AddWithValue("@P_SERVICIO_19", Obj_Mejor_Oferta.Servicio_19);
            cmd.Parameters.AddWithValue("@P_SERVICIO_20", Obj_Mejor_Oferta.Servicio_20);
            cmd.Parameters.AddWithValue("@P_SERVICIO_21", Obj_Mejor_Oferta.Servicio_21);
            cmd.Parameters.AddWithValue("@P_SERVICIO_22", Obj_Mejor_Oferta.Servicio_22);
            cmd.Parameters.AddWithValue("@P_SERVICIO_23", Obj_Mejor_Oferta.Servicio_23);
            cmd.Parameters.AddWithValue("@P_SERVICIO_24", Obj_Mejor_Oferta.Servicio_24);
            cmd.Parameters.AddWithValue("@P_SERVICIO_25", Obj_Mejor_Oferta.Servicio_25);
            cmd.Parameters.AddWithValue("@P_SERVICIO_26", Obj_Mejor_Oferta.Servicio_26);
            cmd.Parameters.AddWithValue("@P_SERVICIO_27", Obj_Mejor_Oferta.Servicio_27);
            cmd.Parameters.AddWithValue("@P_SERVICIO_28", Obj_Mejor_Oferta.Servicio_28);
            cmd.Parameters.AddWithValue("@P_SERVICIO_29", Obj_Mejor_Oferta.Servicio_29);
            cmd.Parameters.AddWithValue("@P_SERVICIO_30", Obj_Mejor_Oferta.Servicio_30);
            cmd.Parameters.AddWithValue("@P_SERVICIO_31", Obj_Mejor_Oferta.Servicio_31);
            cmd.Parameters.AddWithValue("@P_SERVICIO_32", Obj_Mejor_Oferta.Servicio_32);
            cmd.Parameters.AddWithValue("@P_SERVICIO_33", Obj_Mejor_Oferta.Servicio_33);
            cmd.Parameters.AddWithValue("@TIPO_CONTACTO", Obj_Mejor_Oferta.Tipo_Contacto);
            cmd.Parameters.AddWithValue("@GESTION", Obj_Mejor_Oferta.Gestion);
            cmd.Parameters.AddWithValue("@CIERRE", Obj_Mejor_Oferta.Cierre);
            cmd.Parameters.AddWithValue("@RAZON", Obj_Mejor_Oferta.Razon);
            cmd.Parameters.AddWithValue("@OBERVACIONES", Obj_Mejor_Oferta.Observaciones);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar almacenar,modificar o eliminar datos de la tabla de ventas inbound", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public int abc_LogVentas_Inbound(string pAccion, E_Mejor_Oferta Obj_Mejor_Oferta)
        {

            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("[Abc_Log_Ventas_Inbound]", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@FECHA_GESTION", Obj_Mejor_Oferta.Fecha_Gestion);
            cmd.Parameters.AddWithValue("@USUARIO_GESTION", Obj_Mejor_Oferta.Usuario_Gestion);
            cmd.Parameters.AddWithValue("@ALIADO_GESTION", Obj_Mejor_Oferta.Aliado_Gestion);
            cmd.Parameters.AddWithValue("@CUENTA", Obj_Mejor_Oferta.Cuenta);
            cmd.Parameters.AddWithValue("@OFRECIMIENTO_1", Obj_Mejor_Oferta.Ofrecimiento_1_Envio);
            cmd.Parameters.AddWithValue("@OFRECIMIENTO_2", Obj_Mejor_Oferta.Ofrecimiento_2_Envio);
            cmd.Parameters.AddWithValue("@OFRECIMIENTO_3", Obj_Mejor_Oferta.Ofrecimiento_3_Envio);
            cmd.Parameters.AddWithValue("@P_SERVICIO_1", Obj_Mejor_Oferta.Servicio_1);
            cmd.Parameters.AddWithValue("@P_SERVICIO_2", Obj_Mejor_Oferta.Servicio_2);
            cmd.Parameters.AddWithValue("@P_SERVICIO_3", Obj_Mejor_Oferta.Servicio_3);
            cmd.Parameters.AddWithValue("@P_SERVICIO_4", Obj_Mejor_Oferta.Servicio_4);
            cmd.Parameters.AddWithValue("@P_SERVICIO_5", Obj_Mejor_Oferta.Servicio_5);
            cmd.Parameters.AddWithValue("@P_SERVICIO_6", Obj_Mejor_Oferta.Servicio_6);
            cmd.Parameters.AddWithValue("@P_SERVICIO_7", Obj_Mejor_Oferta.Servicio_7);
            cmd.Parameters.AddWithValue("@P_SERVICIO_8", Obj_Mejor_Oferta.Servicio_8);
            cmd.Parameters.AddWithValue("@P_SERVICIO_9", Obj_Mejor_Oferta.Servicio_9);
            cmd.Parameters.AddWithValue("@P_SERVICIO_10", Obj_Mejor_Oferta.Servicio_10);
            cmd.Parameters.AddWithValue("@P_SERVICIO_11", Obj_Mejor_Oferta.Servicio_11);
            cmd.Parameters.AddWithValue("@P_SERVICIO_12", Obj_Mejor_Oferta.Servicio_12);
            cmd.Parameters.AddWithValue("@P_SERVICIO_13", Obj_Mejor_Oferta.Servicio_13);
            cmd.Parameters.AddWithValue("@P_SERVICIO_14", Obj_Mejor_Oferta.Servicio_14);
            cmd.Parameters.AddWithValue("@P_SERVICIO_15", Obj_Mejor_Oferta.Servicio_15);
            cmd.Parameters.AddWithValue("@P_SERVICIO_16", Obj_Mejor_Oferta.Servicio_16);
            cmd.Parameters.AddWithValue("@P_SERVICIO_17", Obj_Mejor_Oferta.Servicio_17);
            cmd.Parameters.AddWithValue("@P_SERVICIO_18", Obj_Mejor_Oferta.Servicio_18);
            cmd.Parameters.AddWithValue("@P_SERVICIO_19", Obj_Mejor_Oferta.Servicio_19);
            cmd.Parameters.AddWithValue("@P_SERVICIO_20", Obj_Mejor_Oferta.Servicio_20);
            cmd.Parameters.AddWithValue("@P_SERVICIO_21", Obj_Mejor_Oferta.Servicio_21);
            cmd.Parameters.AddWithValue("@P_SERVICIO_22", Obj_Mejor_Oferta.Servicio_22);
            cmd.Parameters.AddWithValue("@P_SERVICIO_23", Obj_Mejor_Oferta.Servicio_23);
            cmd.Parameters.AddWithValue("@P_SERVICIO_24", Obj_Mejor_Oferta.Servicio_24);
            cmd.Parameters.AddWithValue("@P_SERVICIO_25", Obj_Mejor_Oferta.Servicio_25);
            cmd.Parameters.AddWithValue("@P_SERVICIO_26", Obj_Mejor_Oferta.Servicio_26);
            cmd.Parameters.AddWithValue("@P_SERVICIO_27", Obj_Mejor_Oferta.Servicio_27);
            cmd.Parameters.AddWithValue("@P_SERVICIO_28", Obj_Mejor_Oferta.Servicio_28);
            cmd.Parameters.AddWithValue("@P_SERVICIO_29", Obj_Mejor_Oferta.Servicio_29);
            cmd.Parameters.AddWithValue("@P_SERVICIO_30", Obj_Mejor_Oferta.Servicio_30);
            cmd.Parameters.AddWithValue("@P_SERVICIO_31", Obj_Mejor_Oferta.Servicio_31);
            cmd.Parameters.AddWithValue("@P_SERVICIO_32", Obj_Mejor_Oferta.Servicio_32);
            cmd.Parameters.AddWithValue("@P_SERVICIO_33", Obj_Mejor_Oferta.Servicio_33);
            cmd.Parameters.AddWithValue("@TIPO_CONTACTO", Obj_Mejor_Oferta.Tipo_Contacto);
            cmd.Parameters.AddWithValue("@GESTION", Obj_Mejor_Oferta.Gestion);
            cmd.Parameters.AddWithValue("@CIERRE", Obj_Mejor_Oferta.Cierre);
            cmd.Parameters.AddWithValue("@RAZON", Obj_Mejor_Oferta.Razon);
            cmd.Parameters.AddWithValue("@OBERVACIONES", Obj_Mejor_Oferta.Observaciones);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar almacenar,modificar o eliminar datos de la tabla de Log ventas inbound", e);
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
