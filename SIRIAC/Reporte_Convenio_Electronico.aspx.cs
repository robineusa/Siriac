
using Datos;
using Negocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Reporte_Convenio_Electronico : System.Web.UI.Page
{
    public N_Reportes obj_Neg_Reportes = new N_Reportes();
    public D_Conexion_BD Conexion = new D_Conexion_BD();

    protected void Page_Load(object sender, EventArgs e)
    {
        Reporte_Tipo_Contacto();
        Reporte_Cierre();
        Reporte_Razon();
        Reporte_Transacciones_Dia();
    }
    protected void Reporte_Tipo_Contacto() {
        Session["Datos_Contacto"] ="";
        //Conexion.Abrir_Conexion();
        SqlDataReader ds;
        ds = obj_Neg_Reportes.Reporte_CE_Tipo_Contacto();

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
        Session["Datos_Contacto"] = JSON.ToString();
        Conexion.Cerrar_Conexion();
        ds.Dispose();
        
    }
    protected void Reporte_Cierre() {
        Session["Datos_Cierre"] = "";
        //Conexion.Abrir_Conexion();
        SqlDataReader ds;
        ds = obj_Neg_Reportes.Reporte_CE_Cierre();

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
        Session["Datos_Cierre"] = JSON.ToString();
        Conexion.Cerrar_Conexion();
        ds.Dispose();
    }
    protected void Reporte_Razon()
    {
        Session["Datos_Razon"] = "";
        //Conexion.Abrir_Conexion();
        SqlDataReader ds;
        ds = obj_Neg_Reportes.Reporte_CE_Razon();

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
        Session["Datos_Razon"] = JSON.ToString();
        Conexion.Cerrar_Conexion();
        ds.Dispose();
    }
    protected void Reporte_Transacciones_Dia() {
        Session["Datos_Transacciones_Dia"] = "";
        //Conexion.Abrir_Conexion();
        SqlDataReader ds;
        ds = obj_Neg_Reportes.Reporte_CE_Transacciones_Fecha();

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
        Session["Datos_Transacciones_Dia"] = JSON.ToString();
        Conexion.Cerrar_Conexion();
        ds.Dispose();
    }
}