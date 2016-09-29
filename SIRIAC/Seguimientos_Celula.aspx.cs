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

public partial class Seguimientos_Celula : System.Web.UI.Page
{
    public E_Ingreso Obj_Entidad_Ingresos = new E_Ingreso();
    public N_Ingresos Obj_Neg_Ingresos = new N_Ingresos();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Acceso_2"].ToString() == "1") { } else { Response.Redirect("Bienvenida_Celula.aspx?Acceso= " + Session["ACCESO_2"].ToString() + " --DENEGADO Seguimientos Celula"); }
        Carga_Seguimientos_Celula();
    }
    protected void Carga_Seguimientos_Celula() {
        DataSet dt = new DataSet();
        Obj_Entidad_Ingresos.Usuario_Backoffice = Session["Usuario_Logueado"].ToString();
        dt = Obj_Neg_Ingresos.Consulta_Seguimientos_Celula(Obj_Entidad_Ingresos.Usuario_Backoffice);
        if (dt.Tables[0].Rows.Count > 0)
        {

            GVINGRESOS.DataSource = dt.Tables[0];
            GVINGRESOS.DataBind();

        }
        else
        {
            GVINGRESOS.DataSource = null;
            GVINGRESOS.DataBind();
            string script = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje1", script, true);
        }
    }
    protected void GVINGRESOS_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GVINGRESOS.PageIndex = e.NewPageIndex;
        Carga_Seguimientos_Celula();
    }
}