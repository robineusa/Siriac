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

public partial class Gestion_Casos_Celula : System.Web.UI.Page
{
    public E_Ingreso Obj_Entidad_Ingresos = new E_Ingreso();
    public N_Ingresos Obj_Neg_Ingresos = new N_Ingresos();

    protected void Page_Load(object sender, EventArgs e)
    {
        Cargar_Casos();
    }
    protected void Cargar_Casos() {
        var Aliado_Celula = Session["Aliado_Usuario"].ToString();

        if (Aliado_Celula.Trim() == "OUTSOURCING PEREIRA")
        {
            DataSet dt = new DataSet();
            Obj_Entidad_Ingresos.Nombre_Linea_Escalado = Session["Nombre_Linea_Usuario"].ToString();
            dt = Obj_Neg_Ingresos.Consulta_Casos_Abiertos_Celula_2(Obj_Entidad_Ingresos.Nombre_Linea_Escalado);

            if (dt.Tables[0].Rows.Count > 0)
            {

                CASOS_ESCALADOS.DataSource = dt.Tables[0];
                CASOS_ESCALADOS.DataBind();
            }
            else
            {
                CASOS_ESCALADOS.DataSource = null;
                CASOS_ESCALADOS.DataBind();
            }
        }
        else
        {

            DataSet dt = new DataSet();
            Obj_Entidad_Ingresos.Aliado_Apertura = Session["Aliado_Usuario"].ToString();
            Obj_Entidad_Ingresos.Nombre_Linea_Escalado = Session["Nombre_Linea_Usuario"].ToString();
            dt = Obj_Neg_Ingresos.Consulta_Casos_Abiertos_Celula(Obj_Entidad_Ingresos.Aliado_Apertura, Obj_Entidad_Ingresos.Nombre_Linea_Escalado);

            if (dt.Tables[0].Rows.Count > 0)
            {

                CASOS_ESCALADOS.DataSource = dt.Tables[0];
                CASOS_ESCALADOS.DataBind();
            }
            else
            {
                CASOS_ESCALADOS.DataSource = null;
                CASOS_ESCALADOS.DataBind();
            }
        }
    }
    protected void CASOS_ESCALADOS_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        CASOS_ESCALADOS.PageIndex = e.NewPageIndex;
        Cargar_Casos();
    }
    protected void Cuenta_Cliente_TextChanged(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Ingresos.Cuenta_Cliente = Convert.ToDouble(Cuenta_Cliente.Text);
        dt = Obj_Neg_Ingresos.Consulta_Casos_Abiertos_Cuenta(Obj_Entidad_Ingresos.Cuenta_Cliente);

        if (dt.Tables[0].Rows.Count > 0)
        {

            CONSULTA_CASOS.DataSource = dt.Tables[0];
            CONSULTA_CASOS.DataBind();
        }
        else
        {
            CONSULTA_CASOS.DataSource = null;
            CONSULTA_CASOS.DataBind();
        }
    }
    protected void Id_Ingreso_TextChanged(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Ingresos.Id_Ingreso = Convert.ToDouble(Id_Ingreso.Text);
        dt = Obj_Neg_Ingresos.Consulta_Casos_Abiertos_Id(Obj_Entidad_Ingresos.Id_Ingreso);

        if (dt.Tables[0].Rows.Count > 0)
        {

            CONSULTA_CASOS.DataSource = dt.Tables[0];
            CONSULTA_CASOS.DataBind();
        }
        else
        {
            CONSULTA_CASOS.DataSource = null;
            CONSULTA_CASOS.DataBind();
        }
    }
    protected void Exportar_Click(object sender, EventArgs e)
    {
        var Aliado_Celula = Session["Aliado_Usuario"].ToString();

        if (Aliado_Celula.Trim() == "OUTSOURCING PEREIRA")
        {
            DataSet dt = new DataSet();
            Obj_Entidad_Ingresos.Nombre_Linea_Escalado = Session["Nombre_Linea_Usuario"].ToString();
            dt = Obj_Neg_Ingresos.Consulta_Casos_Abiertos_Celula_2(Obj_Entidad_Ingresos.Nombre_Linea_Escalado);

            if (dt.Tables[0].Rows.Count > 0)
            {

                CASOS_ESCALADOS.DataSource = dt.Tables[0];
                CASOS_ESCALADOS.DataBind();

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
            else
            {
                CASOS_ESCALADOS.DataSource = null;
                CASOS_ESCALADOS.DataBind();
            }
        }
        else
        {

            DataSet dt = new DataSet();
            Obj_Entidad_Ingresos.Aliado_Apertura = Session["Aliado_Usuario"].ToString();
            Obj_Entidad_Ingresos.Nombre_Linea_Escalado = Session["Nombre_Linea_Usuario"].ToString();
            dt = Obj_Neg_Ingresos.Consulta_Casos_Abiertos_Celula(Obj_Entidad_Ingresos.Aliado_Apertura, Obj_Entidad_Ingresos.Nombre_Linea_Escalado);

            if (dt.Tables[0].Rows.Count > 0)
            {

                CASOS_ESCALADOS.DataSource = dt.Tables[0];
                CASOS_ESCALADOS.DataBind();

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
            else
            {
                CASOS_ESCALADOS.DataSource = null;
                CASOS_ESCALADOS.DataBind();
            }
        }

        

        
    }
    public override void VerifyRenderingInServerForm(Control control)
    {

    }

}