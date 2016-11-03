using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
    public class D_Cierre_Ciclo : D_Conexion_BD
    {
        public D_Cierre_Ciclo() { }
        public DataSet Consulta_Temporal_Cuentas(string pCuenta_Cliente)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Cliente_Cierre_Ciclo]";
                cmd.Parameters.AddWithValue("@Cuenta", pCuenta_Cliente);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar los datos del cliente Cierre Ciclo", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Cliente_Cierre_Ciclo_Gestionado(string pCuenta_Cliente)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Cliente_Cierre_Ciclo_Gestionado]";
                cmd.Parameters.AddWithValue("@Cuenta", pCuenta_Cliente);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar los datos del cliente en cierre ciclo", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public int abcCierre_Ciclo(string pAccion, E_Cierre_Ciclo Obj_Cierre_Ciclo)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("AbcCierre_Ciclo", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@FECHA_GESTION", Obj_Cierre_Ciclo.Fecha_Gestion);
            cmd.Parameters.AddWithValue("@USUARIO_GESTION", Obj_Cierre_Ciclo.Usuario_Gestion);
            cmd.Parameters.AddWithValue("@ALIADO_GESTION", Obj_Cierre_Ciclo.Aliado_Gestion);
            cmd.Parameters.AddWithValue("@CUENTA", Obj_Cierre_Ciclo.Cuenta);
            cmd.Parameters.AddWithValue("@OFRECIMIENTO_1", Obj_Cierre_Ciclo.Ofrecimiento_1_Envio);
            cmd.Parameters.AddWithValue("@OFRECIMIENTO_2", Obj_Cierre_Ciclo.Ofrecimiento_2_Envio);
            cmd.Parameters.AddWithValue("@OFRECIMIENTO_3", Obj_Cierre_Ciclo.Ofrecimiento_3_Envio);
            cmd.Parameters.AddWithValue("@P_SERVICIO_1", Obj_Cierre_Ciclo.Servicio_1);
            cmd.Parameters.AddWithValue("@P_SERVICIO_2", Obj_Cierre_Ciclo.Servicio_2);
            cmd.Parameters.AddWithValue("@P_SERVICIO_3", Obj_Cierre_Ciclo.Servicio_3);
            cmd.Parameters.AddWithValue("@P_SERVICIO_4", Obj_Cierre_Ciclo.Servicio_4);
            cmd.Parameters.AddWithValue("@P_SERVICIO_5", Obj_Cierre_Ciclo.Servicio_5);
            cmd.Parameters.AddWithValue("@P_SERVICIO_6", Obj_Cierre_Ciclo.Servicio_6);
            cmd.Parameters.AddWithValue("@P_SERVICIO_7", Obj_Cierre_Ciclo.Servicio_7);
            cmd.Parameters.AddWithValue("@P_SERVICIO_8", Obj_Cierre_Ciclo.Servicio_8);
            cmd.Parameters.AddWithValue("@P_SERVICIO_9", Obj_Cierre_Ciclo.Servicio_9);
            cmd.Parameters.AddWithValue("@P_SERVICIO_10", Obj_Cierre_Ciclo.Servicio_10);
            cmd.Parameters.AddWithValue("@P_SERVICIO_11", Obj_Cierre_Ciclo.Servicio_11);
            cmd.Parameters.AddWithValue("@P_SERVICIO_12", Obj_Cierre_Ciclo.Servicio_12);
            cmd.Parameters.AddWithValue("@P_SERVICIO_13", Obj_Cierre_Ciclo.Servicio_13);
            cmd.Parameters.AddWithValue("@P_SERVICIO_14", Obj_Cierre_Ciclo.Servicio_14);
            cmd.Parameters.AddWithValue("@P_SERVICIO_15", Obj_Cierre_Ciclo.Servicio_15);
            cmd.Parameters.AddWithValue("@P_SERVICIO_16", Obj_Cierre_Ciclo.Servicio_16);
            cmd.Parameters.AddWithValue("@P_SERVICIO_17", Obj_Cierre_Ciclo.Servicio_17);
            cmd.Parameters.AddWithValue("@P_SERVICIO_18", Obj_Cierre_Ciclo.Servicio_18);
            cmd.Parameters.AddWithValue("@P_SERVICIO_19", Obj_Cierre_Ciclo.Servicio_19);
            cmd.Parameters.AddWithValue("@P_SERVICIO_20", Obj_Cierre_Ciclo.Servicio_20);
            cmd.Parameters.AddWithValue("@P_SERVICIO_21", Obj_Cierre_Ciclo.Servicio_21);
            cmd.Parameters.AddWithValue("@P_SERVICIO_22", Obj_Cierre_Ciclo.Servicio_22);
            cmd.Parameters.AddWithValue("@P_SERVICIO_23", Obj_Cierre_Ciclo.Servicio_23);
            cmd.Parameters.AddWithValue("@P_SERVICIO_24", Obj_Cierre_Ciclo.Servicio_24);
            cmd.Parameters.AddWithValue("@P_SERVICIO_25", Obj_Cierre_Ciclo.Servicio_25);
            cmd.Parameters.AddWithValue("@P_SERVICIO_26", Obj_Cierre_Ciclo.Servicio_26);
            cmd.Parameters.AddWithValue("@P_SERVICIO_27", Obj_Cierre_Ciclo.Servicio_27);
            cmd.Parameters.AddWithValue("@P_SERVICIO_28", Obj_Cierre_Ciclo.Servicio_28);
            cmd.Parameters.AddWithValue("@P_SERVICIO_29", Obj_Cierre_Ciclo.Servicio_29);
            cmd.Parameters.AddWithValue("@P_SERVICIO_30", Obj_Cierre_Ciclo.Servicio_30);
            cmd.Parameters.AddWithValue("@P_SERVICIO_31", Obj_Cierre_Ciclo.Servicio_31);
            cmd.Parameters.AddWithValue("@P_SERVICIO_32", Obj_Cierre_Ciclo.Servicio_32);
            cmd.Parameters.AddWithValue("@P_SERVICIO_33", Obj_Cierre_Ciclo.Servicio_33);
            cmd.Parameters.AddWithValue("@P_SERVICIO_34", Obj_Cierre_Ciclo.Servicio_34);
            cmd.Parameters.AddWithValue("@P_SERVICIO_35", Obj_Cierre_Ciclo.Servicio_35);
            cmd.Parameters.AddWithValue("@P_SERVICIO_36", Obj_Cierre_Ciclo.Servicio_36);
            cmd.Parameters.AddWithValue("@TIPO_CONTACTO", Obj_Cierre_Ciclo.Tipo_Contacto);
            cmd.Parameters.AddWithValue("@GESTION", Obj_Cierre_Ciclo.Gestion);
            cmd.Parameters.AddWithValue("@CIERRE", Obj_Cierre_Ciclo.Cierre);
            cmd.Parameters.AddWithValue("@RAZON", Obj_Cierre_Ciclo.Razon);
            cmd.Parameters.AddWithValue("@OBERVACIONES", Obj_Cierre_Ciclo.Observaciones);
            cmd.Parameters.AddWithValue("@BASE", Obj_Cierre_Ciclo.Base);
            cmd.Parameters.AddWithValue("@OPERACION_GESTION", Obj_Cierre_Ciclo.Operacion_Gestion);
            cmd.Parameters.AddWithValue("@MOTIVO", Obj_Cierre_Ciclo.Motivo);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar almacenar,modificar o eliminar datos de la tabla de ventas OUTbound", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public int abc_LogCierre_Ciclo(string pAccion, E_Cierre_Ciclo Obj_Cierre_Ciclo)
        {

            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("[Abc_Log_Cierre_Ciclo]", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@FECHA_GESTION", Obj_Cierre_Ciclo.Fecha_Gestion);
            cmd.Parameters.AddWithValue("@USUARIO_GESTION", Obj_Cierre_Ciclo.Usuario_Gestion);
            cmd.Parameters.AddWithValue("@ALIADO_GESTION", Obj_Cierre_Ciclo.Aliado_Gestion);
            cmd.Parameters.AddWithValue("@CUENTA", Obj_Cierre_Ciclo.Cuenta);
            cmd.Parameters.AddWithValue("@OFRECIMIENTO_1", Obj_Cierre_Ciclo.Ofrecimiento_1_Envio);
            cmd.Parameters.AddWithValue("@OFRECIMIENTO_2", Obj_Cierre_Ciclo.Ofrecimiento_2_Envio);
            cmd.Parameters.AddWithValue("@OFRECIMIENTO_3", Obj_Cierre_Ciclo.Ofrecimiento_3_Envio);
            cmd.Parameters.AddWithValue("@P_SERVICIO_1", Obj_Cierre_Ciclo.Servicio_1);
            cmd.Parameters.AddWithValue("@P_SERVICIO_2", Obj_Cierre_Ciclo.Servicio_2);
            cmd.Parameters.AddWithValue("@P_SERVICIO_3", Obj_Cierre_Ciclo.Servicio_3);
            cmd.Parameters.AddWithValue("@P_SERVICIO_4", Obj_Cierre_Ciclo.Servicio_4);
            cmd.Parameters.AddWithValue("@P_SERVICIO_5", Obj_Cierre_Ciclo.Servicio_5);
            cmd.Parameters.AddWithValue("@P_SERVICIO_6", Obj_Cierre_Ciclo.Servicio_6);
            cmd.Parameters.AddWithValue("@P_SERVICIO_7", Obj_Cierre_Ciclo.Servicio_7);
            cmd.Parameters.AddWithValue("@P_SERVICIO_8", Obj_Cierre_Ciclo.Servicio_8);
            cmd.Parameters.AddWithValue("@P_SERVICIO_9", Obj_Cierre_Ciclo.Servicio_9);
            cmd.Parameters.AddWithValue("@P_SERVICIO_10", Obj_Cierre_Ciclo.Servicio_10);
            cmd.Parameters.AddWithValue("@P_SERVICIO_11", Obj_Cierre_Ciclo.Servicio_11);
            cmd.Parameters.AddWithValue("@P_SERVICIO_12", Obj_Cierre_Ciclo.Servicio_12);
            cmd.Parameters.AddWithValue("@P_SERVICIO_13", Obj_Cierre_Ciclo.Servicio_13);
            cmd.Parameters.AddWithValue("@P_SERVICIO_14", Obj_Cierre_Ciclo.Servicio_14);
            cmd.Parameters.AddWithValue("@P_SERVICIO_15", Obj_Cierre_Ciclo.Servicio_15);
            cmd.Parameters.AddWithValue("@P_SERVICIO_16", Obj_Cierre_Ciclo.Servicio_16);
            cmd.Parameters.AddWithValue("@P_SERVICIO_17", Obj_Cierre_Ciclo.Servicio_17);
            cmd.Parameters.AddWithValue("@P_SERVICIO_18", Obj_Cierre_Ciclo.Servicio_18);
            cmd.Parameters.AddWithValue("@P_SERVICIO_19", Obj_Cierre_Ciclo.Servicio_19);
            cmd.Parameters.AddWithValue("@P_SERVICIO_20", Obj_Cierre_Ciclo.Servicio_20);
            cmd.Parameters.AddWithValue("@P_SERVICIO_21", Obj_Cierre_Ciclo.Servicio_21);
            cmd.Parameters.AddWithValue("@P_SERVICIO_22", Obj_Cierre_Ciclo.Servicio_22);
            cmd.Parameters.AddWithValue("@P_SERVICIO_23", Obj_Cierre_Ciclo.Servicio_23);
            cmd.Parameters.AddWithValue("@P_SERVICIO_24", Obj_Cierre_Ciclo.Servicio_24);
            cmd.Parameters.AddWithValue("@P_SERVICIO_25", Obj_Cierre_Ciclo.Servicio_25);
            cmd.Parameters.AddWithValue("@P_SERVICIO_26", Obj_Cierre_Ciclo.Servicio_26);
            cmd.Parameters.AddWithValue("@P_SERVICIO_27", Obj_Cierre_Ciclo.Servicio_27);
            cmd.Parameters.AddWithValue("@P_SERVICIO_28", Obj_Cierre_Ciclo.Servicio_28);
            cmd.Parameters.AddWithValue("@P_SERVICIO_29", Obj_Cierre_Ciclo.Servicio_29);
            cmd.Parameters.AddWithValue("@P_SERVICIO_30", Obj_Cierre_Ciclo.Servicio_30);
            cmd.Parameters.AddWithValue("@P_SERVICIO_31", Obj_Cierre_Ciclo.Servicio_31);
            cmd.Parameters.AddWithValue("@P_SERVICIO_32", Obj_Cierre_Ciclo.Servicio_32);
            cmd.Parameters.AddWithValue("@P_SERVICIO_33", Obj_Cierre_Ciclo.Servicio_33);
            cmd.Parameters.AddWithValue("@P_SERVICIO_34", Obj_Cierre_Ciclo.Servicio_34);
            cmd.Parameters.AddWithValue("@P_SERVICIO_35", Obj_Cierre_Ciclo.Servicio_35);
            cmd.Parameters.AddWithValue("@P_SERVICIO_36", Obj_Cierre_Ciclo.Servicio_36);
            cmd.Parameters.AddWithValue("@TIPO_CONTACTO", Obj_Cierre_Ciclo.Tipo_Contacto);
            cmd.Parameters.AddWithValue("@GESTION", Obj_Cierre_Ciclo.Gestion);
            cmd.Parameters.AddWithValue("@CIERRE", Obj_Cierre_Ciclo.Cierre);
            cmd.Parameters.AddWithValue("@RAZON", Obj_Cierre_Ciclo.Razon);
            cmd.Parameters.AddWithValue("@OBERVACIONES", Obj_Cierre_Ciclo.Observaciones);
            cmd.Parameters.AddWithValue("@BASE", Obj_Cierre_Ciclo.Base);
            cmd.Parameters.AddWithValue("@OPERACION_GESTION", Obj_Cierre_Ciclo.Operacion_Gestion);
            cmd.Parameters.AddWithValue("@MOTIVO", Obj_Cierre_Ciclo.Motivo);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar almacenar,modificar o eliminar datos de la tabla de Log ventas outbound", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public DataSet Consulta_Admin_Cierre_Ciclo(string pFecha_Inicial, string pFecha_Final)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Admin_Cierre_Ciclo]";
                cmd.Parameters.AddWithValue("@Fecha_Inicial", pFecha_Inicial);
                cmd.Parameters.AddWithValue("@Fecha_Final", pFecha_Final);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al sconsultar el registro en Cierre de ciclo", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
