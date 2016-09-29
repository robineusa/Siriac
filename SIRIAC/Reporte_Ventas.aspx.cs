using Datos;
using Negocios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Reporte_Ventas : System.Web.UI.Page
{
    public N_Reportes obj_Neg_Reportes = new N_Reportes();
    public D_Conexion_BD Conexion = new D_Conexion_BD();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Acceso_17"].ToString() == "1") { } else { Response.Redirect("Bienvenida_Administrador.aspx?Acceso= " + Session["ACCESO_17"].ToString() + "-- DENEGADO Reporte de Ventas"); } 
        Reporte_Tipo_Contacto();
        Reporte_Cierre();
        Reporte_Razon();
        Reporte_Transacciones_Dia();
        Reporte_Transacciones_Dia_Aliado();
        Reporte_Transacciones_Dia_Aliado_Usuario();
        Reporte_Pronostico();
    }
    protected void Reporte_Tipo_Contacto()
    {
        Session["Datos_Contacto_V"] = "";
        //Conexion.Abrir_Conexion();
        SqlDataReader ds;
        ds = obj_Neg_Reportes.Reporte_V_Tipo_Contacto();

        StringBuilder JSON = new StringBuilder();
        string prefix = "";
        JSON.Append("[");
        while (ds.Read())
        {
            JSON.Append(prefix + "{");
            JSON.Append("\"TIPO_CONTACTO\":" + "\"" + ds[0] + "\",");
            JSON.Append("\"CANTIDAD\":" + ds[1]);
            JSON.Append("}");
            prefix = ",";

        }
        JSON.Append("];");
        Session["Datos_Contacto_V"] = JSON.ToString();
        Conexion.Cerrar_Conexion();
        ds.Dispose();

    }
    protected void Reporte_Cierre()
    {
        Session["Datos_Cierre_V"] = "";
        //Conexion.Abrir_Conexion();
        SqlDataReader ds;
        ds = obj_Neg_Reportes.Reporte_V_Cierre() ;

        StringBuilder JSON = new StringBuilder();
        string prefix = "";
        JSON.Append("[");
        while (ds.Read())
        {
            JSON.Append(prefix + "{");
            JSON.Append("\"CIERRE\":" + "\"" + ds[0] + "\",");
            JSON.Append("\"CANTIDAD\":" + ds[1]);
            JSON.Append("}");
            prefix = ",";

        }
        JSON.Append("];");
        Session["Datos_Cierre_V"] = JSON.ToString();
        Conexion.Cerrar_Conexion();
        ds.Dispose();
    }
    protected void Reporte_Razon()
    {
        Session["Datos_Razon_V"] = "";
        //Conexion.Abrir_Conexion();
        SqlDataReader ds;
        ds = obj_Neg_Reportes.Reporte_V_Razon();

        StringBuilder JSON = new StringBuilder();
        string prefix = "";
        JSON.Append("[");
        while (ds.Read())
        {
            JSON.Append(prefix + "{");
            JSON.Append("\"RAZON\":" + "\"" + ds[0] + "\",");
            JSON.Append("\"CANTIDAD\":" + ds[1]);
            JSON.Append("}");
            prefix = ",";

        }
        JSON.Append("];");
        Session["Datos_Razon_V"] = JSON.ToString();
        Conexion.Cerrar_Conexion();
        ds.Dispose();
    } 
    protected void Reporte_Transacciones_Dia()
    {
        Session["Datos_Transacciones_Dia_V"] = "";
        //Conexion.Abrir_Conexion();
        SqlDataReader ds;
        ds = obj_Neg_Reportes.Reporte_V_Transacciones_Fecha();

        StringBuilder JSON = new StringBuilder();
        string prefix = "";
        JSON.Append("[");
        while (ds.Read())
        {
            JSON.Append(prefix + "{");
            JSON.Append("\"FECHA_GESTION\":" + "\"" + ds[0] + "\",");
            JSON.Append("\"CANTIDAD\":" + ds[1]);
            JSON.Append("}");
            prefix = ",";

        }
        JSON.Append("];");
        Session["Datos_Transacciones_Dia_V"] = JSON.ToString();
        Conexion.Cerrar_Conexion();
        ds.Dispose();
    }
    protected void Reporte_Transacciones_Dia_Aliado()
    {
        Session["Datos_Transacciones_Dia_Aliado_"] = "";
        //Conexion.Abrir_Conexion();
        SqlDataReader ds;
        ds = obj_Neg_Reportes.Reporte_V_Transacciones_Fecha_Aliado();

        StringBuilder JSON = new StringBuilder();
        string prefix = "";
        JSON.Append("[");
        while (ds.Read())
        {
            JSON.Append(prefix + "{");
            JSON.Append("\"FECHA_GESTION\":" + "\"" + ds[0] + "\",");
            JSON.Append("\"ATENTO_COLOMBIA\":" + ds[1] + ",");
            JSON.Append("\"BRM\":" + ds[2] + ",");
            JSON.Append("\"OUTSOURCING_PEREIRA\":" + ds[3] + ",");
            JSON.Append("\"ATENTO_COLOMBIA_PEREIRA\":" + ds[4]);
            JSON.Append("}");
            prefix = ",";

        }
        JSON.Append("];");
        Session["Datos_Transacciones_Dia_Aliado_"] = JSON.ToString();
        Conexion.Cerrar_Conexion();
        ds.Dispose();
    }
    protected void Reporte_Transacciones_Dia_Aliado_Usuario()
    {
        Session["Datos_Transacciones_Dia_Aliado_U"] = "";
        //Conexion.Abrir_Conexion();
        SqlDataReader ds;
        ds = obj_Neg_Reportes.Reporte_V_Transacciones_Fecha_Aliado_Usuarios();

        StringBuilder JSON1 = new StringBuilder();
        string prefix = "";
        JSON1.Append("[");
        while (ds.Read())
        {
            JSON1.Append(prefix + "{");
            JSON1.Append("\"FECHA_GESTION\":" + "\"" + ds[0] + "\",");
            JSON1.Append("\"ATENTO_COLOMBIA\":" + ds[1] + ",");
            JSON1.Append("\"BRM\":" + ds[2] + ",");
            JSON1.Append("\"OUTSOURCING_PEREIRA\":" + ds[3] + ",");
            JSON1.Append("\"ATENTO_COLOMBIA_PEREIRA\":" + ds[4] +",");
            JSON1.Append("\"CANT_ATENTO_COLOMBIA\":" + ds[5] + ",");
            JSON1.Append("\"CANT_BRM\":" + ds[6] + ",");
            JSON1.Append("\"CANT_OUTSOURCING_PEREIRA\":" + ds[7] + ",");
            JSON1.Append("\"CANT_ATENTO_COLOMBIA_PEREIRA\":" + ds[8]);
            JSON1.Append("}");
            prefix = ",";

        }
        JSON1.Append("];");
        Session["Datos_Transacciones_Dia_Aliado_U"] = JSON1.ToString();
        Conexion.Cerrar_Conexion();
        ds.Dispose();
    }
    protected void Reporte_Pronostico()
    {
        Session["Datos_Pronostico_V"] = "";
        //Conexion.Abrir_Conexion();
        SqlDataReader ds;
        ds = obj_Neg_Reportes.Reporte_V_Pronostico();

        StringBuilder JSON1 = new StringBuilder();
        string prefix = "";
        JSON1.Append("[");
        while (ds.Read())
        {
            JSON1.Append(prefix + "{");
            JSON1.Append("\"FECHA\":" + "\"" + ds[0] + "\",");
            JSON1.Append("\"CANTIDAD\":" + ds[1]);
            JSON1.Append("}");
            prefix = ",";

        }
        JSON1.Append("];");
        Session["Datos_Pronostico_V"] = JSON1.ToString();
        Conexion.Cerrar_Conexion();
        ds.Dispose();
    }
}
