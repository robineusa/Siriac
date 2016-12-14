using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Perfil_Administrador : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Acceso_20"].ToString() == "1") { Consulta_Solicitudes.Attributes.CssStyle.Add("Display", "block"); } else { Consulta_Solicitudes.Attributes.CssStyle.Add("Display", "none"); }
        if (Session["Acceso_21"].ToString() == "1") { Consulta_Interac.Attributes.CssStyle.Add("Display", "block"); } else { Consulta_Interac.Attributes.CssStyle.Add("Display", "none"); }
        Response.AddHeader("cache-control", "private");
        Response.AddHeader("pragma", "no-cache");
        Response.AddHeader("Cache-Control", "must-revalidate");
        Response.AddHeader("Cache-Control", "no-cache");

        if (Session["Rol_Usuario"].ToString() == "1") { } else { Response.Redirect("Inicio_de_Sesion.aspx?id=" + Session["Rol_Usuario"].ToString() + ""); };
        Nombre_Usuario.Text = Session["Nombre_Usuario"].ToString();
    }
    protected void salir(object sender, EventArgs e)
    {
        Session["Usuario_Logueado"] = "";
        Session["Nombre_Usuario"] = "";
        Session["Rol_Usuario"] = "";
        Session["Aliado_Usuario"] = "";
        Session["Nombre_Linea_Usuario"] = "";
        Response.Redirect("Inicio_de_Sesion.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["Usuario_Logueado"] = "";
        Session["Nombre_Usuario"] = "";
        Session["Rol_Usuario"] = "";
        Session["Aliado_Usuario"] = "";
        Session["Nombre_Linea_Usuario"] = "";
        Response.Redirect("Inicio_de_Sesion.aspx");
    }
}
