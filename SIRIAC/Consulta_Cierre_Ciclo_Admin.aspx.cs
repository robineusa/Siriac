using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Consulta_Cierre_Ciclo_Admin : System.Web.UI.Page
{
    E_Cierre_Ciclo Obj_Entidad_Cierre_Ciclo = new E_Cierre_Ciclo();
    N_Cierre_Ciclo Obj_Cierre_Ciclo = new N_Cierre_Ciclo();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Consulta_Cierre_Ciclo_LOG(object sender, EventArgs e)
    {
        Fecha_Inicial.Text = CC_Fecha_Inicial.Text;
        Fecha_Final.Text = CC_Fecha_Final.Text;
        DataSet ds = new DataSet();
        Obj_Entidad_Cierre_Ciclo.Fecha_Inicial = CC_Fecha_Inicial.Text;
        Obj_Entidad_Cierre_Ciclo.Fecha_Final = CC_Fecha_Final.Text;
        ds = Obj_Cierre_Ciclo.Consulta_Admin_Cierre_Ciclo(Obj_Entidad_Cierre_Ciclo.Fecha_Inicial, Obj_Entidad_Cierre_Ciclo.Fecha_Final);

        if (ds.Tables[0].Rows.Count > 0)
        {
            CONSULTA_CIERRE_CICLO.DataSource = ds.Tables[0];
            CONSULTA_CIERRE_CICLO.DataBind();
        }
        else
        {
            CONSULTA_CIERRE_CICLO.DataSource = null;
            CONSULTA_CIERRE_CICLO.DataBind();
        }
    }
    
    protected void Exportar_Convenio_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        Obj_Entidad_Cierre_Ciclo.Fecha_Inicial = Fecha_Inicial.Text;
        Obj_Entidad_Cierre_Ciclo.Fecha_Final = Fecha_Final.Text;
        ds = Obj_Cierre_Ciclo.Consulta_Admin_Cierre_Ciclo(Obj_Entidad_Cierre_Ciclo.Fecha_Inicial, Obj_Entidad_Cierre_Ciclo.Fecha_Final);

        GridView gv = new GridView();
        gv.DataSource = ds;
        gv.DataBind();
        Response.ClearContent();
        Response.Buffer = true;
        Response.AddHeader("content-disposition", "attachment; filename=Base_Cierre_Ciclo-" + DateTime.Now.ToShortDateString() + ".xls");
        Response.ContentType = "application/ms-excel";
        Response.Charset = "";

        StringWriter sw = new StringWriter();
        HtmlTextWriter htw = new HtmlTextWriter(sw);
        gv.RenderControl(htw);
        Response.Output.Write(sw.ToString());
        Response.Flush();
        Response.End();
    }
    

    protected void CONSULTA_CIERRE_CICLO_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        CONSULTA_CIERRE_CICLO.PageIndex = e.NewPageIndex;
        Consulta_Cierre_Ciclo_LOG(sender, e);

    }
}