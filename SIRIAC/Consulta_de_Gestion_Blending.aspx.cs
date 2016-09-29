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



public partial class Consulta_de_Gestion_Blending : System.Web.UI.Page
{
    E_Convenio_Electronico Obj_Entidad_Convenio = new E_Convenio_Electronico();
    N_Convenio_Electronico Obj_Neg_Conveio = new N_Convenio_Electronico();
    E_Ventas Obj_Entidad_Ventas = new E_Ventas();
    N_Ventas Obj_Neg_Ventas = new N_Ventas();
    E_Logistica_Inversa obj_Entidad_Logistica = new E_Logistica_Inversa();
    N_Logistica_Inversa obj_Neg_Logistica = new N_Logistica_Inversa();
    E_Claro_Video obj_Entidad_Claro_Video = new E_Claro_Video();
    N_Claro_Video obj_Neg_Claro_Video = new N_Claro_Video();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Acceso_16"].ToString() == "1") { } else { Response.Redirect("Bienvenida_Administrador.aspx?Acceso= " + Session["ACCESO_16"].ToString() + "-- DENEGADO Consulta Gestion Blending"); } 
    }
    protected void Activacion_Click(object sender, EventArgs e)
    {
        Exportar_Activacion.Visible = true;
        Panel2.Visible = false;
    }
    protected void Convenio_Click(object sender, EventArgs e)
    {
        Fecha_Inicial.Text = CE_Fecha_Inicial.Text;
        Fecha_Final.Text = CE_Fecha_Final.Text;

        Exportar_Convenio.Visible = true;
        Panel2.Visible = false;
        DataSet ds = new DataSet();
        Obj_Entidad_Convenio.Fecha_Inicial = Fecha_Inicial.Text;
        Obj_Entidad_Convenio.Fecha_Final = Fecha_Final.Text;
        ds = Obj_Neg_Conveio.Consulta_Admin_Convenio(Obj_Entidad_Convenio.Fecha_Inicial, Obj_Entidad_Convenio.Fecha_Final);

        if (ds.Tables[0].Rows.Count > 0)
        {

            CONSULTA_CONVENIO.DataSource = ds.Tables[0];
            CONSULTA_CONVENIO.DataBind();
        }
        else
        {
            CONSULTA_CONVENIO.DataSource = null;
            CONSULTA_CONVENIO.DataBind();
        }

    }
    protected void Detrectores_Click(object sender, EventArgs e)
    {
        Exportar_Detractores.Visible = true;
        Panel2.Visible = false;
    }
    protected void Reincidencia_Click(object sender, EventArgs e)
    {
        Exportar_Reincidencia.Visible = true;
        Panel2.Visible = false;
    }
    protected void Ventas_Click(object sender, EventArgs e)
    {
        Exportar_Ventas.Visible = true;
        Panel2.Visible = false;

        Fecha_Inicial.Text = CE_Fecha_Inicial.Text;
        Fecha_Final.Text = CE_Fecha_Final.Text;

        DataSet ds = new DataSet();
        Obj_Entidad_Ventas.Fecha_Inicial = Fecha_Inicial.Text;
        Obj_Entidad_Ventas.Fecha_Final = Fecha_Final.Text;
        ds = Obj_Neg_Ventas.Consulta_Admin_Log_Ventas(Obj_Entidad_Ventas.Fecha_Inicial, Obj_Entidad_Ventas.Fecha_Final);

        if (ds.Tables[0].Rows.Count > 0)
        {

            CONSULTA_VENTAS.DataSource = ds.Tables[0];
            CONSULTA_VENTAS.DataBind();
        }
        else
        {
            CONSULTA_VENTAS.DataSource = null;
            CONSULTA_VENTAS.DataBind();
        }

    }
    protected void Logistica_Click(object sender, EventArgs e)
    {
        Exportar_Logistica.Visible = true;
        Panel2.Visible = false;

        Fecha_Inicial.Text = CE_Fecha_Inicial.Text;
        Fecha_Final.Text = CE_Fecha_Final.Text;

        DataSet ds = new DataSet();
        obj_Entidad_Logistica.Fecha_Inicial = Fecha_Inicial.Text;
        obj_Entidad_Logistica.Fecha_Final = Fecha_Final.Text;
        ds = obj_Neg_Logistica.Consulta_Admin_Logistica(obj_Entidad_Logistica.Fecha_Inicial, obj_Entidad_Logistica.Fecha_Final);

        if (ds.Tables[0].Rows.Count > 0)
        {

            CONSULTA_LOGISTICA.DataSource = ds.Tables[0];
            CONSULTA_LOGISTICA.DataBind();
        }
        else
        {
            CONSULTA_LOGISTICA.DataSource = null;
            CONSULTA_LOGISTICA.DataBind();
        }
    }
    protected void Claro_Video_Click(object sender, EventArgs e)
    {
        Exportar_Claro_Video.Visible = true;
        Panel2.Visible = false;

        Fecha_Inicial.Text = CE_Fecha_Inicial.Text;
        Fecha_Final.Text = CE_Fecha_Final.Text;

        DataSet ds = new DataSet();
        obj_Entidad_Claro_Video.Fecha_Inicial = Fecha_Inicial.Text;
        obj_Entidad_Claro_Video.Fecha_Final = Fecha_Final.Text;
        ds = obj_Neg_Claro_Video.Consulta_Admin_Claro_Video(obj_Entidad_Claro_Video.Fecha_Inicial, obj_Entidad_Claro_Video.Fecha_Final);

        if (ds.Tables[0].Rows.Count > 0)
        {

            CONSULTA_CLARO_VIDEO.DataSource = ds.Tables[0];
            CONSULTA_CLARO_VIDEO.DataBind();
        }
        else
        {
            CONSULTA_CLARO_VIDEO.DataSource = null;
            CONSULTA_CLARO_VIDEO.DataBind();
        }
    }
    protected void Exportar_Activacion_Click(object sender, EventArgs e)
    {

    }
    protected void Exportar_Convenio_Click(object sender, EventArgs e)
    {
        Exportar_Convenio.Enabled = false;
        Exportar_Convenio.Visible = false;
        DataSet ds = new DataSet();
        Obj_Entidad_Convenio.Fecha_Inicial = Fecha_Inicial.Text;
        Obj_Entidad_Convenio.Fecha_Final = Fecha_Final.Text;
        ds = Obj_Neg_Conveio.Consulta_Admin_Convenio(Obj_Entidad_Convenio.Fecha_Inicial, Obj_Entidad_Convenio.Fecha_Final);

        GridView gv = new GridView();
        gv.DataSource = ds;
        gv.DataBind();
        Response.ClearContent();
        Response.Buffer = true;
        Response.AddHeader("content-disposition", "attachment; filename=Base_Convenio_Electronico-" + DateTime.Now.ToShortDateString() + ".xls");
        Response.ContentType = "application/ms-excel";
        Response.Charset = "";

        StringWriter sw = new StringWriter();
        HtmlTextWriter htw = new HtmlTextWriter(sw);
        gv.RenderControl(htw);
        Response.Output.Write(sw.ToString());
        Response.Flush();
        Response.End();
    }
    protected void Exportar_Detractores_Click(object sender, EventArgs e)
    {

    }
    protected void Exportar_Reincidencia_Click(object sender, EventArgs e)
    {

    }
    protected void Exportar_Ventas_Click(object sender, EventArgs e)
    {

        Exportar_Ventas.Enabled = false;
        Exportar_Ventas.Visible = false;
        DataSet ds = new DataSet();
        Obj_Entidad_Ventas.Fecha_Inicial = Fecha_Inicial.Text;
        Obj_Entidad_Ventas.Fecha_Final = Fecha_Final.Text;
        ds = Obj_Neg_Ventas.Consulta_Admin_Log_Ventas(Obj_Entidad_Ventas.Fecha_Inicial, Obj_Entidad_Ventas.Fecha_Final);

        GridView gv = new GridView();
        gv.DataSource = ds;
        gv.DataBind();
        Response.ClearContent();
        Response.Buffer = true;
        Response.AddHeader("content-disposition", "attachment; filename=Base_Ventas-" + DateTime.Now.ToShortDateString() + ".xls");
        Response.ContentType = "application/ms-excel";
        Response.Charset = "";

        StringWriter sw = new StringWriter();
        HtmlTextWriter htw = new HtmlTextWriter(sw);
        gv.RenderControl(htw);
        Response.Output.Write(sw.ToString());
        Response.Flush();
        Response.End();

    }
    protected void Exportar_Logistica_Click(object sender, EventArgs e)
    {
        Exportar_Logistica.Enabled = false;
        Exportar_Logistica.Visible = false;
        DataSet ds = new DataSet();
        obj_Entidad_Logistica.Fecha_Inicial = Fecha_Inicial.Text;
        obj_Entidad_Logistica.Fecha_Final = Fecha_Final.Text;
        ds = obj_Neg_Logistica.Consulta_Admin_Logistica(obj_Entidad_Logistica.Fecha_Inicial, obj_Entidad_Logistica.Fecha_Final);

        GridView gv = new GridView();
        gv.DataSource = ds;
        gv.DataBind();
        Response.ClearContent();
        Response.Buffer = true;
        Response.AddHeader("content-disposition", "attachment; filename=Base_Logistica_Inversa-" + DateTime.Now.ToShortDateString() + ".xls");
        Response.ContentType = "application/ms-excel";
        Response.Charset = "";

        StringWriter sw = new StringWriter();
        HtmlTextWriter htw = new HtmlTextWriter(sw);
        gv.RenderControl(htw);
        Response.Output.Write(sw.ToString());
        Response.Flush();
        Response.End();
    }
    protected void Exportar_Claro_Video_Click(object sender, EventArgs e)
    {
        Exportar_Claro_Video.Enabled = false;
        Exportar_Claro_Video.Visible = false;

        DataSet ds = new DataSet();
        obj_Entidad_Claro_Video.Fecha_Inicial = Fecha_Inicial.Text;
        obj_Entidad_Claro_Video.Fecha_Final = Fecha_Final.Text;
        ds = obj_Neg_Claro_Video.Consulta_Admin_Claro_Video(obj_Entidad_Claro_Video.Fecha_Inicial, obj_Entidad_Claro_Video.Fecha_Final);
        
        GridView gv = new GridView();
        gv.DataSource = ds;
        gv.DataBind();
        Response.ClearContent();
        Response.Buffer = true;
        Response.AddHeader("content-disposition", "attachment; filename=Base_Claro_Video-" + DateTime.Now.ToShortDateString() + ".xls");
        Response.ContentType = "application/ms-excel";
        Response.Charset = "";

        StringWriter sw = new StringWriter();
        HtmlTextWriter htw = new HtmlTextWriter(sw);
        gv.RenderControl(htw);
        Response.Output.Write(sw.ToString());
        Response.Flush();
        Response.End();
    }
    public override void VerifyRenderingInServerForm(Control control)
    {

    }
    protected void CONSULTA_CONVENIO_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {

        }
    }
    protected void CONSULTA_VENTAS_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {

        }
    }

    protected void CONSULTA_LOGISTICA_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {

        }
    }
    protected void CONSULTA_CLARO_VIDEO_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {

        }
    }

    
}