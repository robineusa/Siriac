using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Seguimiento_Celula_Traslados : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Carga_Seguimientos_Celula()
    {
        DataSet dt = new DataSet();
        //Obj_Entidad_Ingresos.Usuario_Backoffice = Session["Usuario_Logueado"].ToString();
        //dt = Obj_Neg_Ingresos.Consulta_Seguimientos_Celula(Obj_Entidad_Ingresos.Usuario_Backoffice);
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