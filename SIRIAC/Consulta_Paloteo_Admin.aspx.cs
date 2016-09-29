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

public partial class Consulta_Paloteo_Admin : System.Web.UI.Page
{
    public E_Paloteo Obj_Entidad_Paloteo = new E_Paloteo();
    public N_Paloteo Obj_Neg_Paloteo = new N_Paloteo();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Acceso_5"].ToString() == "1") { } else { Response.Redirect("Bienvenida_Administrador.aspx?Acceso= " + Session["ACCESO_5"].ToString() + "--DENEGADO Consulta de Paloteo"); }
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
        Consultar_Datos();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Paloteo.Fecha_Inicial = TextBox3.Text;
        Obj_Entidad_Paloteo.Fecha_Final = TextBox4.Text;
        dt = Obj_Neg_Paloteo.Consulta_Admin_Paloteo(Obj_Entidad_Paloteo.Fecha_Inicial, Obj_Entidad_Paloteo.Fecha_Final);

        GridView gv = new GridView();
        gv.DataSource = dt;
        gv.DataBind();
        Response.ClearContent();
        Response.Buffer = true;
        Response.AddHeader("content-disposition", "attachment; filename=Base_Paloteo-" + DateTime.Now.ToShortDateString() + ".xls");
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
    protected void Consultar_Datos() {
        DataSet dt = new DataSet();
        Obj_Entidad_Paloteo.Fecha_Inicial = TextBox3.Text;
        Obj_Entidad_Paloteo.Fecha_Final = TextBox4.Text;
        dt = Obj_Neg_Paloteo.Consulta_Admin_Paloteo(Obj_Entidad_Paloteo.Fecha_Inicial, Obj_Entidad_Paloteo.Fecha_Final);

        if (dt.Tables[0].Rows.Count > 0)
        {

            PALOTEO.DataSource = dt.Tables[0];
            PALOTEO.DataBind();
        }
        else
        {
            PALOTEO.DataSource = null;
            PALOTEO.DataBind();
        }
    }
    protected void PALOTEO_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        PALOTEO.PageIndex = e.NewPageIndex;
        Consultar_Datos();
    }
    
}