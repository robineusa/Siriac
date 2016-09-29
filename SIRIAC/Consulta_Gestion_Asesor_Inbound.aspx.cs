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

public partial class Consulta_Gestion_Asesor_Inbound : System.Web.UI.Page
{
    public E_Gestion_General Obj_Entidad_Gestion_General = new E_Gestion_General();
    public N_Gestion_General Obj_Neg_Gestion_General = new N_Gestion_General();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Rol_Usuario"].ToString() == "3") { }
        else { Response.Redirect("Inicio_de_Sesion.aspx?id=" + Session["Rol_Usuario"].ToString() + ""); }
    }
       protected void Abrir_Cal_1_Click(object sender, EventArgs e)
    {
        Calendar1.SelectedDate = DateTime.Now;
        if (Calendar1.Visible == true) { Calendar1.Visible = false; }
        else
        {
            Calendar1.Visible = true;

        }
        Calendar1.VisibleDate = Calendar1.TodaysDate;

        Calendar1.SelectedDates.Clear();

    }
    protected void Abrir_Cal_2_Click(object sender, EventArgs e)
    {
        Calendar2.SelectedDate = DateTime.Now;
        if (Calendar2.Visible == true) { Calendar2.Visible = false; }
        else
        {
            Calendar2.Visible = true;

        }
        Calendar2.VisibleDate = Calendar2.TodaysDate;

        Calendar2.SelectedDates.Clear();
    }
    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        Fecha_Final.Text = Calendar2.SelectedDate.ToString("yyyy-MM-dd");
        Calendar2.Visible = false;
        this.Cargar_Casos(sender, e);
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Fecha_Inicial.Text = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
        Calendar1.Visible = false;
        this.Cargar_Casos(sender,e);
    }
    protected void Cargar_Casos(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Gestion_General.Fecha_Interaccion = Fecha_Inicial.Text;
        Obj_Entidad_Gestion_General.Fecha_Interaccion_2 = Fecha_Final.Text;
       Obj_Entidad_Gestion_General.Usuario_Interaccion = Session["Usuario_Logueado"].ToString();
        dt = Obj_Neg_Gestion_General.Consulta_de_Gestion_Asesor(Obj_Entidad_Gestion_General.Fecha_Interaccion,Obj_Entidad_Gestion_General.Fecha_Interaccion_2, Obj_Entidad_Gestion_General.Usuario_Interaccion);

        if (dt.Tables[0].Rows.Count > 0)
        {

            CASOS_GESTIONADOS.DataSource = dt.Tables[0];
            CASOS_GESTIONADOS.DataBind();

        }
        else
        {
            CASOS_GESTIONADOS.DataSource = null;
            CASOS_GESTIONADOS.DataBind();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Gestion_General.Fecha_Interaccion = Fecha_Inicial.Text;
        Obj_Entidad_Gestion_General.Fecha_Interaccion_2 = Fecha_Final.Text;
        Obj_Entidad_Gestion_General.Usuario_Interaccion = Session["Usuario_Logueado"].ToString();
        dt = Obj_Neg_Gestion_General.Consulta_de_Gestion_Asesor(Obj_Entidad_Gestion_General.Fecha_Interaccion, Obj_Entidad_Gestion_General.Fecha_Interaccion_2, Obj_Entidad_Gestion_General.Usuario_Interaccion);

        if (dt.Tables[0].Rows.Count > 0)
        {


           

        }
        else
        {
           
        }
        GridView gv = new GridView();
        gv.DataSource = dt;
        gv.DataBind();
        Response.ClearContent();
        Response.Buffer = true;
        Response.AddHeader("content-disposition", "attachment; filename=Base_de_Gestion-" + DateTime.Now.ToShortDateString() + ".xls");
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
    protected void CASOS_GESTIONADOS_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {

            }
        }

    protected void CASOS_GESTIONADOS_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        CASOS_GESTIONADOS.PageIndex = e.NewPageIndex;
        this.Cargar_Casos(sender,e);
    }
}