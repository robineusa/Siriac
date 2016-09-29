using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Drawing;
using System.IO;
using Entidades;
using Negocios;


public partial class Seguimientos_Asesor_Inbound : System.Web.UI.Page
{
    public E_Ingreso Obj_Entidad_Ingresos = new E_Ingreso();
    public N_Ingresos Obj_Neg_Ingresos = new N_Ingresos();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Rol_Usuario"].ToString() == "3") { }
        else { Response.Redirect("Inicio_de_Sesion.aspx?id=" + Session["Rol_Usuario"].ToString() + ""); }
        Cargar_Seguimientos();
    }
    protected void Cargar_Seguimientos()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Ingresos.Usuario_Apertura = Session["Usuario_Logueado"].ToString();
        dt = Obj_Neg_Ingresos.Consulta_Seguimientos_Asesor(Obj_Entidad_Ingresos.Usuario_Apertura);
        if (dt.Tables[0].Rows.Count > 0)
        {

            SEGUIMIENTOS_ASESOR.DataSource = dt.Tables[0];
            SEGUIMIENTOS_ASESOR.DataBind();

        }
        else
        {
            SEGUIMIENTOS_ASESOR.DataSource = null;
            SEGUIMIENTOS_ASESOR.DataBind();
            string script = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje1", script, true);
        }
    }
    protected void SEGUIMIENTOS_ASESOR_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        SEGUIMIENTOS_ASESOR.PageIndex = e.NewPageIndex;
        Cargar_Seguimientos();
    }
}