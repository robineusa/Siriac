﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Perfil_Jefe : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.AddHeader("cache-control", "private");
        Response.AddHeader("pragma", "no-cache");
        Response.AddHeader("Cache-Control", "must-revalidate");
        Response.AddHeader("Cache-Control", "no-cache");

        if (Session["Rol_Usuario"].ToString() == "5") { } else { Response.Redirect("Inicio_de_Sesion.aspx?id=" + Session["Rol_Usuario"].ToString() + ""); };
        Label1.Text = Session["Nombre_Usuario"].ToString();
    }

    private void salir(object sender, EventArgs e)
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
