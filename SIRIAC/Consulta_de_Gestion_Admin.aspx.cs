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


public partial class Consulta_de_Gestion_Admin : System.Web.UI.Page
{
    public E_Gestion_General Obj_Entidad_Gestion_General = new E_Gestion_General();
    public N_Gestion_General Obj_Neg_Gestion_General = new N_Gestion_General();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Acceso_6"].ToString() == "1") { } else { Response.Redirect("Bienvenida_Administrador.aspx?Acceso= " + Session["ACCESO_6"].ToString() + "--DENEGADO Consulta de Gestión"); }
        
    }
    protected void Button2_Click(object sender, EventArgs e)
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

    protected void Button3_Click(object sender, EventArgs e)
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

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextBox3.Text = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
        Calendar1.Visible = false;
    }

    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        TextBox4.Text = Calendar2.SelectedDate.ToString("yyyy-MM-dd");
        Calendar2.Visible = false;
        Consulta_De_Gestion();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Gestion_General.Fecha_Interaccion = TextBox3.Text;
        Obj_Entidad_Gestion_General.Fecha_Interaccion_2 = TextBox4.Text;
        dt = Obj_Neg_Gestion_General.Consulta_de_Gestion_Admin(Obj_Entidad_Gestion_General.Fecha_Interaccion, Obj_Entidad_Gestion_General.Fecha_Interaccion_2);

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
    protected void GINGRESOS_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {

        }
    }
    protected void Consulta_De_Gestion() {

        DataSet dt = new DataSet();
        Obj_Entidad_Gestion_General.Fecha_Interaccion = TextBox3.Text;
        Obj_Entidad_Gestion_General.Fecha_Interaccion_2 = TextBox4.Text;
        dt = Obj_Neg_Gestion_General.Consulta_de_Gestion_Admin(Obj_Entidad_Gestion_General.Fecha_Interaccion, Obj_Entidad_Gestion_General.Fecha_Interaccion_2);

        if (dt.Tables[0].Rows.Count > 0)
        {

            GVINGRESOS.DataSource = dt.Tables[0];
            GVINGRESOS.DataBind();

        }
        else
        {
            GVINGRESOS.DataSource = null;
            GVINGRESOS.DataBind();
        }
    }
}