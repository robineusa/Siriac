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

public partial class Consulta_Rechazos_Asesor_Inbound : System.Web.UI.Page
{
    public E_Rechazos Obj_Entidad_Rechazos = new E_Rechazos();
    public N_Rechazos Obj_Neg_Rechazos = new N_Rechazos();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Rol_Usuario"].ToString() == "3") { }
        else { Response.Redirect("Inicio_de_Sesion.aspx?id=" + Session["Rol_Usuario"].ToString() + ""); }

    }
    protected void Cargar_Rechazos()
    {
        DataSet dt = new DataSet();
     Obj_Entidad_Rechazos.Usuario_Creacion=Session["Usuario_Logueado"].ToString();
     Obj_Entidad_Rechazos.Fecha_del_Rechazo = Fecha_Inicial.Text;
     Obj_Entidad_Rechazos.Fecha_del_Rechazo_2 = Fecha_Final.Text;
     dt = Obj_Neg_Rechazos.Consulta_Rechazos_Asesor(Obj_Entidad_Rechazos.Fecha_del_Rechazo, Obj_Entidad_Rechazos.Fecha_del_Rechazo_2, Obj_Entidad_Rechazos.Usuario_Creacion);
        if (dt.Tables[0].Rows.Count > 0)
        {

            RECHAZOS_ASESOR.DataSource = dt.Tables[0];
            RECHAZOS_ASESOR.DataBind();

        }
        else
        {
            RECHAZOS_ASESOR.DataSource = null;
            RECHAZOS_ASESOR.DataBind();
        }
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
    protected void Fecha_Inicial_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Fecha_Inicial.Text = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
        Calendar1.Visible = false;
        Cargar_Rechazos();

    }
    protected void Fecha_Final_TextChanged(object sender, EventArgs e)
    {

       
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
        Cargar_Rechazos();
    }
    protected void RECHAZOS_ASESOR_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {

        }
    }

    protected void RECHAZOS_ASESOR_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        RECHAZOS_ASESOR.PageIndex = e.NewPageIndex;
        Cargar_Rechazos();
    }
}