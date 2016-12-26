using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Seguimiento_Celula_Traslados : System.Web.UI.Page
{
    public E_Traslados Obj_Entidad_Traslados = new E_Traslados();
    public N_Traslados Obj_Neg_Traslados = new N_Traslados();
    protected void Page_Load(object sender, EventArgs e)
    {
        Carga_Seguimientos_Celula_Traslados();
    }

    protected void Carga_Seguimientos_Celula_Traslados()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Traslados.Usuario_Backoffice = Session["Usuario_Logueado"].ToString();
        dt = Obj_Neg_Traslados.Consulta_Casos_Escalados_Traslados_Por_Estado_Celula(Obj_Entidad_Traslados.Usuario_Backoffice);
        if (dt.Tables[0].Rows.Count > 0)
        {

            CASOS_SEGUIMIENTOS_TRASLADOS.DataSource = dt.Tables[0];
            CASOS_SEGUIMIENTOS_TRASLADOS.DataBind();

        }
        else
        {
            CASOS_SEGUIMIENTOS_TRASLADOS.DataSource = null;
            CASOS_SEGUIMIENTOS_TRASLADOS.DataBind();
            string script = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje1", script, true);
        }
    }
    protected void GVINGRESOS_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        CASOS_SEGUIMIENTOS_TRASLADOS.PageIndex = e.NewPageIndex;
        Carga_Seguimientos_Celula_Traslados();
    }

}