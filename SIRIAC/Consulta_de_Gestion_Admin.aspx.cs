﻿using System;
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
    public N_Perfiles Obj_Neg_Perfiles = new N_Perfiles();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Acceso_6"].ToString() == "1") { } else { Response.Redirect("Bienvenida_Administrador.aspx?Acceso= " + Session["ACCESO_6"].ToString() + "--DENEGADO Consulta de Gestión"); }
        Carga_Aliado();
        
    }
    
    protected void Button4_Click(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Gestion_General.Fecha_Interaccion = CG_Fecha_Inicial.Text;
        Obj_Entidad_Gestion_General.Fecha_Interaccion_2 = CG_Fecha_Final.Text;
        Obj_Entidad_Gestion_General.Aliado_Apertura = CG_Aliado_Oculto.Text;
        dt = Obj_Neg_Gestion_General.Consulta_de_Gestion_Admin(Obj_Entidad_Gestion_General.Fecha_Interaccion, Obj_Entidad_Gestion_General.Fecha_Interaccion_2, Obj_Entidad_Gestion_General.Aliado_Apertura);

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
        Obj_Entidad_Gestion_General.Fecha_Interaccion = CG_Fecha_Inicial.Text;
        Obj_Entidad_Gestion_General.Fecha_Interaccion_2 = CG_Fecha_Final.Text;
        Obj_Entidad_Gestion_General.Aliado_Apertura = CG_Aliado_Oculto.Text;
        dt = Obj_Neg_Gestion_General.Consulta_de_Gestion_Admin(Obj_Entidad_Gestion_General.Fecha_Interaccion, Obj_Entidad_Gestion_General.Fecha_Interaccion_2, Obj_Entidad_Gestion_General.Aliado_Apertura);

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
    protected void Carga_Aliado()
    {
        DataSet dt = new DataSet();
        dt = Obj_Neg_Perfiles.Aliado_Usuario();

        if (dt.Tables[0].Rows.Count > 0)
        {

            Aliado_CG.DataSource = dt;
            Aliado_CG.DataTextField = "ALIADO";
            Aliado_CG.DataValueField = "ALIADO";
            Aliado_CG.DataBind();
        }
    }

    protected void CG_Consulta_Click(object sender, EventArgs e)
    {
        Consulta_De_Gestion();
    }
}