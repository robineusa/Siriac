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
    public class D_Datos_Clientes: D_Conexion_BD
    {
        public D_Datos_Clientes() {}
        public DataSet Consulta_Datos_Cliente(Int64 pCuenta_Cliente)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Datos_Clientes]";
                cmd.Parameters.AddWithValue("@Cuenta_Cliente", pCuenta_Cliente);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception ex)
            { throw new Exception("Error al seleccionar los datos adicionales del Cliente", ex); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public int acb_Datos_Adicionales_Clientes(string pAccion, E_Datos_Clientes Obj_Datos_Ad_Clientes) {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abcAdicionales_Cliente", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Cuenta", Obj_Datos_Ad_Clientes.Cuenta_Cliente);
            cmd.Parameters.AddWithValue("@Correo_Electronico", Obj_Datos_Ad_Clientes.Correo_Electronico);
            cmd.Parameters.AddWithValue("@Telefono_Personal", Obj_Datos_Ad_Clientes.Telefono_Personal);
            cmd.Parameters.AddWithValue("@Fecha_Cumpleanos", Obj_Datos_Ad_Clientes.Fecha_Cumpleanos);
            cmd.Parameters.AddWithValue("@Rango_de_Edad",Obj_Datos_Ad_Clientes.Rango_Edad);
            cmd.Parameters.AddWithValue("@Nivel_de_Estudios", Obj_Datos_Ad_Clientes.Nivel_Estudios);
            cmd.Parameters.AddWithValue("@Hobbie", Obj_Datos_Ad_Clientes.Hobbie);
            cmd.Parameters.AddWithValue("@Twitter", Obj_Datos_Ad_Clientes.Twitter);
            cmd.Parameters.AddWithValue("@Facebook", Obj_Datos_Ad_Clientes.Facebook);
            cmd.Parameters.AddWithValue("@Instagram", Obj_Datos_Ad_Clientes.Instagram);
            cmd.Parameters.AddWithValue("@Otro", Obj_Datos_Ad_Clientes.Otro);
            cmd.Parameters.AddWithValue("@Numero_Hijos", Obj_Datos_Ad_Clientes.Numero_Hijos);
            cmd.Parameters.AddWithValue("@Edad_Hijos", Obj_Datos_Ad_Clientes.Edad_Hijos);
            
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            
            
            Cerrar_Conexion();
            cmd.Dispose();
            
             return Resultado;
        }
        public DataSet Consulta_Cliente_Back(Int64 pCuenta_Cliente)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Datos_Adicionales_Cliente_back]";
                cmd.Parameters.AddWithValue("@Cuenta_Cliente", pCuenta_Cliente);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception ex)
            { throw new Exception("Error al seleccionar los datos adicionales del Cliente", ex); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        }

    }

