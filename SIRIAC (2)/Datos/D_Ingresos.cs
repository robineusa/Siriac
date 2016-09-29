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
    public class D_Ingresos : D_Conexion_BD
    {
        public D_Ingresos() { }
        public int abcIngresos(string pAccion, E_Ingreso objE_Ingreso)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abcIngresos", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Id_Ingreso", objE_Ingreso.Id_Ingreso);
            cmd.Parameters.AddWithValue("@Cuenta_Cliente", objE_Ingreso.Cuenta_Cliente);
            cmd.Parameters.AddWithValue("@Ticket", objE_Ingreso.Ticket);
            cmd.Parameters.AddWithValue("@Fecha_Apertura", objE_Ingreso.Fecha_Apertura);
            cmd.Parameters.AddWithValue("@Hora_Apertura", objE_Ingreso.Hora_Apertura);
            cmd.Parameters.AddWithValue("@Fecha_Cierre", objE_Ingreso.Fecha_Cierre);
            cmd.Parameters.AddWithValue("@Hora_Cierre", objE_Ingreso.Hora_Cierre);
            cmd.Parameters.AddWithValue("@Usuario_Apertura", objE_Ingreso.Usuario_Apertura);
            cmd.Parameters.AddWithValue("@Usuario_Cierre", objE_Ingreso.Usuario_Cierre);
            cmd.Parameters.AddWithValue("@Fecha_Ultima_Actualizacion", objE_Ingreso.Fecha_Ultima_Actualizacion);
            cmd.Parameters.AddWithValue("@Usuario_Ultima_Actualizacion", objE_Ingreso.Usuario_Ultima_Actualizacion);
            cmd.Parameters.AddWithValue("@Hora_Ultima_Actualizacion", objE_Ingreso.Hora_Ultima_Actualizacion);
            cmd.Parameters.AddWithValue("@Macroproceso", objE_Ingreso.Macroproceso);
            cmd.Parameters.AddWithValue("@Proceso", objE_Ingreso.Proceso);
            cmd.Parameters.AddWithValue("@Subproceso", objE_Ingreso.Subproceso);
            cmd.Parameters.AddWithValue("@Marcacion", objE_Ingreso.Marcacion);
            cmd.Parameters.AddWithValue("@Id_Estado", objE_Ingreso.Id_Estado);
            cmd.Parameters.AddWithValue("@Semaforo", objE_Ingreso.Semaforo);
            cmd.Parameters.AddWithValue("@Tiempo_Respuesta", objE_Ingreso.Tiempo_Respuesta);
            cmd.Parameters.AddWithValue("@Usuario_Backoffice", objE_Ingreso.Usuario_Backoffice);
            cmd.Parameters.AddWithValue("@Aliado_Apertura", objE_Ingreso.Aliado_Apertura);
            cmd.Parameters.AddWithValue("@Nombre_Linea_Ingreso", objE_Ingreso.Nombre_Linea_Ingreso);
            cmd.Parameters.AddWithValue("@Nombre_Linea_Escalado", objE_Ingreso.Nombre_Linea_Escalado);
            cmd.Parameters.AddWithValue("@Id_Servicio", objE_Ingreso.Id_Servicio);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar almacenar,modificar o eliminar datos de la tabla de ingresos", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public DataSet Selecciona_Maximo_Ingreso_Cuenta(double p_Cuenta)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Maximo_Id_Ingreso_Cuenta]";
                cmd.Parameters.AddWithValue("@Cuenta_Cliente", p_Cuenta);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al Seleccionar Maximo Id de Ingreso", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public int Inserta_Ingreso()
        {
        int Resultado = 0;
            SqlCommand cmd = new SqlCommand("Inserta_Ingreso", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.Add("@Cuenta_Cliente");
            cmd.Parameters.Add("@Ticket");
            cmd.Parameters.Add("@Usuario_Apertura");
            cmd.Parameters.Add("@Usuario_Cierre");
            cmd.Parameters.Add("@Usuario_Ultima_Actualizacion");
            cmd.Parameters.Add("@Macroproceso");
            cmd.Parameters.Add("@Proceso");
            cmd.Parameters.Add("@Subproceso");
            cmd.Parameters.Add("@Marcacion");
            cmd.Parameters.Add("@Id_Estado");
            cmd.Parameters.Add("@Aliado_Apertura");
            cmd.Parameters.Add("@Nombre_Linea_Ingreso");
            cmd.Parameters.Add("@Nombre_Linea_Escalado");
            cmd.Parameters.Add("@Id_Servicio");
            
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            
                Cerrar_Conexion();
                cmd.Dispose();
            
            return Resultado;
        
        }
        public DataSet Marcaciones_Escaladas(double pCuenta,string pMarcacion) {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Marcaciones_Escaladas]";
                cmd.Parameters.AddWithValue("@Cuenta_Cliente", pCuenta);
                cmd.Parameters.AddWithValue("@Marcacion", pMarcacion);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar las marcaciones escaladas", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Casos_Abiertos_Tipificador(double pCuenta) {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Casos_Abiertos_Tipificador]";
                cmd.Parameters.AddWithValue("@Cuenta_Cliente", pCuenta);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar los casos abiertos", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Casos_Cerrados_Tipificador(double pCuenta) {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Casos_Cerrados_Tipificador]";
                cmd.Parameters.AddWithValue("@Cuenta_Cliente", pCuenta);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar los casos abiertos", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Ingreso(double pId_Ingreso) {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Informacion_Caso]";
                cmd.Parameters.AddWithValue("@Id_Ingreso", pId_Ingreso);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar la informacion del caso", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public int Actualiza_Ingreso_Front(double Id_Ingreso, E_Ingreso objE_Ingreso)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("Actualiza_Casos_Front", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id_Ingreso", objE_Ingreso.Id_Ingreso);
            cmd.Parameters.AddWithValue("@Macroproceso", objE_Ingreso.Macroproceso);
            cmd.Parameters.AddWithValue("@Proceso", objE_Ingreso.Proceso);
            cmd.Parameters.AddWithValue("@Subproceso", objE_Ingreso.Subproceso);
            cmd.Parameters.AddWithValue("@Marcacion", objE_Ingreso.Marcacion);
            cmd.Parameters.AddWithValue("@Id_Estado", objE_Ingreso.Id_Estado);
            cmd.Parameters.AddWithValue("@Semaforo", objE_Ingreso.Semaforo);
            cmd.Parameters.AddWithValue("@Tiempo_Respuesta", objE_Ingreso.Tiempo_Respuesta);
            cmd.Parameters.AddWithValue("@Usuario_Backoffice", objE_Ingreso.Usuario_Backoffice);
            cmd.Parameters.AddWithValue("@Nombre_Linea_Escalado", objE_Ingreso.Nombre_Linea_Escalado);
            cmd.Parameters.AddWithValue("@Usuario_Cierre", objE_Ingreso.Usuario_Cierre);
            cmd.Parameters.AddWithValue("@Usuario_Actualiza", objE_Ingreso.Usuario_Ultima_Actualizacion);
            cmd.Parameters.AddWithValue("@Ticket", objE_Ingreso.Ticket);
           try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar actualizar datos de la tabla de ingresos", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public DataSet Consulta_Ingreso_General(double pId_Ingreso)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Ingreso_General]";
                cmd.Parameters.AddWithValue("@Id_Ingreso", pId_Ingreso);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar la informacion del caso", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Seguimientos_Asesor(string pUsuario)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Seguimientos_Asesor]";
                cmd.Parameters.AddWithValue("@Usuario_Apertura", pUsuario);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar llos casos en seguimiento", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Casos_Abiertos_Celula(string pAliado, string pNombre_Linea)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Casos_Abiertos_Celula]";
                cmd.Parameters.AddWithValue("@Aliado_Apertura", pAliado);
                cmd.Parameters.AddWithValue("@Nombre_Linea_Escalado", pNombre_Linea);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar los casos abiertos para la celula", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Casos_Abiertos_Celula_2(string pNombre_Linea)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Casos_Abiertos_Celula_2]";
                cmd.Parameters.AddWithValue("@Nombre_Linea_Escalado", pNombre_Linea);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar los casos abiertos para la celula 2", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Casos_Abiertos_Id(double pId_Ingreso)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Ingresos_Id]";
                cmd.Parameters.AddWithValue("@Id_Ingreso", pId_Ingreso);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar los casos abiertos por Id", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Casos_Abiertos_Cuenta(double pCuenta)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Ingresos_Cuenta]";
                cmd.Parameters.AddWithValue("@Cuenta_Cliente", pCuenta);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar los casos abiertos por Cuenta", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Usuario_Back(double pId_Ingreso)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Usuario_Back]";
                cmd.Parameters.AddWithValue("@Id_Ingreso", pId_Ingreso);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al seleccionar el backoficce del caso", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public int Actualiza_Usuario_Back(double Id_Ingreso, E_Ingreso objE_Ingreso)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("Actualizar_Usuario_Back", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id_Ingreso", objE_Ingreso.Id_Ingreso);
            cmd.Parameters.AddWithValue("@Usuario_Backoffice", objE_Ingreso.Usuario_Backoffice);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar actualizar el usuario del back", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public DataSet Consulta_Ingreso_Back(double pId_Ingreso)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Consulta_Ingreso_Back]";
                cmd.Parameters.AddWithValue("@Id_Ingreso", pId_Ingreso);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al consultar la informacion del caso", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Marcacion_Back(double pId_Ingreso)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Marcaciones_Back]";
                cmd.Parameters.AddWithValue("@Id_Ingreso", pId_Ingreso);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al consultar la informacion de la marcacion", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public int Actualiza_Casos_Back(double pId_Ingreso, E_Ingreso Obj_Ingresos)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("Actualiza_Caso_Back", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id_Ingreso", pId_Ingreso);
            cmd.Parameters.AddWithValue("@Usuario_Cierre", Obj_Ingresos.Usuario_Cierre);
            cmd.Parameters.AddWithValue("@Usuario_Ult_Actualizacion", Obj_Ingresos.Usuario_Ultima_Actualizacion);
            cmd.Parameters.AddWithValue("@Id_Estado", Obj_Ingresos.Id_Estado);
            cmd.Parameters.AddWithValue("@Usuario_Backoffice", Obj_Ingresos.Usuario_Backoffice);
            cmd.Parameters.AddWithValue("@Nombre_Linea_Escalado", Obj_Ingresos.Nombre_Linea_Escalado);
            
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            
              
            
                Cerrar_Conexion();
                cmd.Dispose();
            
            return Resultado;
        }
        public int Semaforo()
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("SEMAFORO", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            Abrir_Conexion();
            Resultado = cmd.ExecuteNonQuery();



            Cerrar_Conexion();
            cmd.Dispose();

            return Resultado;
        }
        public DataSet Consulta_Seguimientos_Celula(string pUsuario_Back)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Seguimientos_Celula]";
                cmd.Parameters.AddWithValue("@Usuario_Backoffice", pUsuario_Back);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al consultar llos seguimientos de la celula", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Admin_Casos_Cuenta(double pCuenta)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Ingreso_Admin_Cuenta]";
                cmd.Parameters.AddWithValue("@Cuenta_Cliente", pCuenta);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al consultar caso por cuenta", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Admin_Casos_Ticket(double pTicket)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Ingreso_Admin_Ticket]";
                cmd.Parameters.AddWithValue("@Ticket", pTicket);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al consultar caso por ticket", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Admin_Casos_Usuario(string pUsuario)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Ingreso_Admin_Usuario]";
                cmd.Parameters.AddWithValue("@Usuario_Apertura", pUsuario);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al consultar caso por usuario", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public DataSet Consulta_Admin_Casos_Id(double pId_Ingreso)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter();
            try
            {
                Abrir_Conexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Selecciona_Ingreso_Admin_Id]";
                cmd.Parameters.AddWithValue("@Id_Ingreso", pId_Ingreso);
                dt.SelectCommand = cmd;
                dt.Fill(ds);
            }
            catch (Exception e)
            { throw new Exception("Error al consultar caso por id", e); }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
        public int Actualiza_Ingreso_Celula(double Id_Ingreso, E_Ingreso objE_Ingreso)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("Actualizar_Caso_Celula", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Ingreso", objE_Ingreso.Id_Ingreso);
            cmd.Parameters.AddWithValue("@Nombre_Linea_escalado", objE_Ingreso.Nombre_Linea_Escalado);
            cmd.Parameters.AddWithValue("@Fecha_Actualizacion", objE_Ingreso.Fecha_Ultima_Actualizacion);
            cmd.Parameters.AddWithValue("@Hora_Actualizacion", objE_Ingreso.Hora_Ultima_Actualizacion);
            cmd.Parameters.AddWithValue("@Usuario_Actualizacion", objE_Ingreso.Usuario_Ultima_Actualizacion);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar actualizar el la celula escalada", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public int Actualiza_Ingreso_Back(double Id_Ingreso, E_Ingreso objE_Ingreso)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("Actualizar_Caso_Back", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Ingreso", objE_Ingreso.Id_Ingreso);
            cmd.Parameters.AddWithValue("@Usuario_Backoffice", objE_Ingreso.Usuario_Backoffice);
            cmd.Parameters.AddWithValue("@Fecha_Actualizacion", objE_Ingreso.Fecha_Ultima_Actualizacion);
            cmd.Parameters.AddWithValue("@Hora_Actualizacion", objE_Ingreso.Hora_Ultima_Actualizacion);
            cmd.Parameters.AddWithValue("@Usuario_Actualizacion", objE_Ingreso.Usuario_Ultima_Actualizacion);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar actualizar el usuario del back", e);
            }
            finally
            {
                Cerrar_Conexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        public int Actualiza_Ingreso_Estado(double Id_Ingreso, E_Ingreso objE_Ingreso)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("Actualizar_Caso_Estado", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Ingreso", objE_Ingreso.Id_Ingreso);
            cmd.Parameters.AddWithValue("@Id_Estado", objE_Ingreso.Id_Estado);
            cmd.Parameters.AddWithValue("@Fecha_Cierre", objE_Ingreso.Fecha_Cierre);
            cmd.Parameters.AddWithValue("@Hora_Cierre", objE_Ingreso.Hora_Cierre);
            cmd.Parameters.AddWithValue("@Usuario_Cierre", objE_Ingreso.Usuario_Cierre);
            cmd.Parameters.AddWithValue("@Fecha_Actualizacion", objE_Ingreso.Fecha_Ultima_Actualizacion);
            cmd.Parameters.AddWithValue("@Hora_Actualizacion", objE_Ingreso.Hora_Ultima_Actualizacion);
            cmd.Parameters.AddWithValue("@Usuario_Actualizacion", objE_Ingreso.Usuario_Ultima_Actualizacion);
            try
            {
                Abrir_Conexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar actualizar el estado del caso", e);
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
