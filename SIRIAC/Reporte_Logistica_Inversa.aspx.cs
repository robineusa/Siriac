using Datos;
using Entidades;
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

public partial class Reportes_Admin : System.Web.UI.Page
{
    N_Reportes obj_Neg_Reportes = new N_Reportes();
    E_Reportes Obj_Entidad_Reportes = new E_Reportes();
    D_Conexion_BD Conexion = new D_Conexion_BD();
    SqlDataReader ds;

    protected void Page_Load(object sender, EventArgs e)
    {   
        Reporte_Tipo_Contacto();
        Reporte_Cierre();
        
    }
    protected void Reportes(object sender, EventArgs e)
    {
        Reporte_Tipo_Contacto_Fecha();
        Reporte_cierre_Fecha();
    }
    protected void Reporte_Tipo_Contacto()
    {
        Session["Datos_Contacto"] = "";
        Session["Datos_Contacto_Fecha"]="";
        SqlDataReader ds;
        ds = obj_Neg_Reportes.Reporte_LI_Tipo_Contacto();

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
        Session["Datos_Cierre_Fecha"] = "";

        ds = obj_Neg_Reportes.Gestiones();

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
    protected void Reporte_Tipo_Contacto_Fecha()
    {
        Session["Datos_Contacto"] = "";
        SqlDataReader ds;
        Obj_Entidad_Reportes.Fecha_Inicial = Fecha_Inicial.Text;
        Obj_Entidad_Reportes.Fecha_Final = Fecha_Final.Text;
        ds = obj_Neg_Reportes.Reporte_LI_Tipo_Contacto_F(Obj_Entidad_Reportes.Fecha_Inicial, Obj_Entidad_Reportes.Fecha_Final);

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
        Session["Datos_Contacto_Fecha"] = JSON.ToString();
        Conexion.Cerrar_Conexion();
        ds.Dispose();
    }
    protected void Reporte_cierre_Fecha()
    {
        Session["Datos_Cierre"] = "";
        SqlDataReader ds;
        Obj_Entidad_Reportes.Fecha_Inicial = Fecha_Inicial.Text;
        //Session["FI"] = string.Empty;
        //TextBox1.Text = Fecha_Final.Text;
        Session["FI"] = Fecha_Inicial.Text;
        Obj_Entidad_Reportes.Fecha_Final = Fecha_Final.Text;
        ds = obj_Neg_Reportes.Reporte_LI_Cierre_F(Obj_Entidad_Reportes.Fecha_Inicial, Obj_Entidad_Reportes.Fecha_Final);

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
        Session["Datos_Cierre_Fecha"] = JSON.ToString();
        Conexion.Cerrar_Conexion();
        ds.Dispose();   
    }
}