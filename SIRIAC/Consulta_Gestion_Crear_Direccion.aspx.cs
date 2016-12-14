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


public partial class Consulta_Gestion_Crear_Direccion : System.Web.UI.Page
{
    E_Traslados Obj_Entidad_Traslados = new E_Traslados();
    N_Traslados Obj_Negocio_Traslados = new N_Traslados();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Consulta_Cierre_Ciclo_LOG(object sender, EventArgs e)
    {
        Fecha_Inicial.Text = CC_Fecha_Inicial.Text;
        Fecha_Final.Text = CC_Fecha_Final.Text;
        DataSet ds = new DataSet();
        Obj_Entidad_Traslados.Fecha_Inicial = CC_Fecha_Inicial.Text;
        Obj_Entidad_Traslados.Fecha_Final = CC_Fecha_Final.Text;
        ds = Obj_Negocio_Traslados.Consulta_Admin_Gestion_Crear_Direccion(Obj_Entidad_Traslados.Fecha_Inicial, Obj_Entidad_Traslados.Fecha_Final);

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
        Obj_Entidad_Traslados.Fecha_Inicial = CC_Fecha_Inicial.Text;
        Obj_Entidad_Traslados.Fecha_Final = CC_Fecha_Final.Text;
        ds = Obj_Negocio_Traslados.Consulta_Admin_Gestion_Crear_Direccion(Obj_Entidad_Traslados.Fecha_Inicial, Obj_Entidad_Traslados.Fecha_Final);

        GridView gv = new GridView();
        gv.DataSource = ds;
        gv.DataBind();
        Response.ClearContent();
        Response.Buffer = true;
        Response.AddHeader("content-disposition", "attachment; filename=Base_Interacciones_Creacion_Direccion-" + DateTime.Now.ToShortDateString() + ".xls");
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