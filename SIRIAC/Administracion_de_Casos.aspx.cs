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

public partial class Administracion_de_Casos : System.Web.UI.Page
{
    public E_Ingreso Obj_Entidad_Ingresos = new E_Ingreso();
    public N_Ingresos Obj_Neg_Ingresos = new N_Ingresos();

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Cuenta_Cliente_TextChanged(object sender, EventArgs e)
    {

        DataSet dt = new DataSet();
        Obj_Entidad_Ingresos.Cuenta_Cliente = Convert.ToDouble(Cuenta_Cliente.Text);
        dt = Obj_Neg_Ingresos.Consulta_Admin_Casos_Cuenta(Obj_Entidad_Ingresos.Cuenta_Cliente);
        if (dt.Tables[0].Rows.Count > 0)
        {

            CONSULTA_CASOS.DataSource = dt.Tables[0];
            CONSULTA_CASOS.DataBind();
        }
        else
        {
            string script = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje1", script, true);
            Limpiar();
        }
        Ticket.Text = "";
        Usuario_Creacion.Text = "";
        Id_Ingreso.Text = "";
        A_Cuenta_Cliente.Text = string.Empty;
        A_Ticket.Text = string.Empty;
        A_Id_Ingreso.Text = string.Empty;
        A_Usuario_Creacion.Text = string.Empty;
    }
    protected void Ticket_TextChanged(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Ingresos.Ticket = Convert.ToDouble(Ticket.Text);
        dt = Obj_Neg_Ingresos.Consulta_Admin_Casos_Ticket(Obj_Entidad_Ingresos.Ticket);
        if (dt.Tables[0].Rows.Count > 0)
        {

            CONSULTA_CASOS.DataSource = dt.Tables[0];
            CONSULTA_CASOS.DataBind();
        }
        else
        {
            string script = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje1", script, true);
            Limpiar();
        }
        Cuenta_Cliente.Text = "";
        Usuario_Creacion.Text = "";
        Id_Ingreso.Text = "";
        A_Cuenta_Cliente.Text = string.Empty;
        A_Ticket.Text = string.Empty;
        A_Id_Ingreso.Text = string.Empty;
        A_Usuario_Creacion.Text = string.Empty;
    }
    protected void Id_Ingreso_TextChanged(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Ingresos.Id_Ingreso = Convert.ToDouble(Id_Ingreso.Text);
        dt = Obj_Neg_Ingresos.Consulta_Admin_Casos_Id(Obj_Entidad_Ingresos.Id_Ingreso);
        if (dt.Tables[0].Rows.Count > 0)
        {

            CONSULTA_CASOS.DataSource = dt.Tables[0];
            CONSULTA_CASOS.DataBind();
        }
        else
        {
            string script = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje1", script, true);
            Limpiar();
        }
        Cuenta_Cliente.Text = "";
        Ticket.Text = "";
        Usuario_Creacion.Text = "";
        A_Cuenta_Cliente.Text = string.Empty;
        A_Ticket.Text = string.Empty;
        A_Id_Ingreso.Text = string.Empty;
        A_Usuario_Creacion.Text = string.Empty;

    }
    protected void Usuario_Creacion_TextChanged(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Ingresos.Usuario_Apertura = Usuario_Creacion.Text;
        dt = Obj_Neg_Ingresos.Consulta_Admin_Casos_Usuario(Obj_Entidad_Ingresos.Usuario_Apertura);
        if (dt.Tables[0].Rows.Count > 0)
        {

            CONSULTA_CASOS.DataSource = dt.Tables[0];
            CONSULTA_CASOS.DataBind();
        }
        else
        {
            string script = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje1", script, true);
            Limpiar();
        }
        Ticket.Text = "";
        Cuenta_Cliente.Text = "";
        Id_Ingreso.Text = "";
        A_Cuenta_Cliente.Text = string.Empty;
        A_Ticket.Text = string.Empty;
        A_Id_Ingreso.Text = string.Empty;
        A_Usuario_Creacion.Text = string.Empty;
    }
    protected void A_Cuenta_Cliente_TextChanged(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Ingresos.Cuenta_Cliente = Convert.ToDouble(A_Cuenta_Cliente.Text);
        dt = Obj_Neg_Ingresos.Consulta_Admin_Casos_Cuenta(Obj_Entidad_Ingresos.Cuenta_Cliente);
        if (dt.Tables[0].Rows.Count > 0)
        {

            A_CONSULTA_CASOS.DataSource = dt.Tables[0];
            A_CONSULTA_CASOS.DataBind();
        }
        else
        {
            string script = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje1", script, true);
            Limpiar();
        }
        A_Ticket.Text = "";
        A_Usuario_Creacion.Text = "";
        A_Id_Ingreso.Text = "";
        Cuenta_Cliente.Text = string.Empty;
        Ticket.Text = string.Empty;
        Id_Ingreso.Text = string.Empty;
        Usuario_Creacion.Text = string.Empty;
    }
    protected void A_Ticket_TextChanged(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Ingresos.Ticket = Convert.ToDouble(A_Ticket.Text);
        dt = Obj_Neg_Ingresos.Consulta_Admin_Casos_Ticket(Obj_Entidad_Ingresos.Ticket);
        if (dt.Tables[0].Rows.Count > 0)
        {

            A_CONSULTA_CASOS.DataSource = dt.Tables[0];
            A_CONSULTA_CASOS.DataBind();
        }
        else
        {
            string script = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje1", script, true);
            Limpiar();
        }
        A_Cuenta_Cliente.Text = "";
        A_Usuario_Creacion.Text = "";
        A_Id_Ingreso.Text = "";
        Cuenta_Cliente.Text = string.Empty;
        Ticket.Text = string.Empty;
        Id_Ingreso.Text = string.Empty;
        Usuario_Creacion.Text = string.Empty;
    }
    protected void A_Id_Ingreso_TextChanged(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Ingresos.Id_Ingreso = Convert.ToDouble(A_Id_Ingreso.Text);
        dt = Obj_Neg_Ingresos.Consulta_Admin_Casos_Id(Obj_Entidad_Ingresos.Id_Ingreso);
        if (dt.Tables[0].Rows.Count > 0)
        {

            A_CONSULTA_CASOS.DataSource = dt.Tables[0];
            A_CONSULTA_CASOS.DataBind();
        }
        else
        {
            string script = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje1", script, true);
            Limpiar();
        }
        A_Cuenta_Cliente.Text = "";
        A_Ticket.Text = "";
        A_Usuario_Creacion.Text = "";
        Cuenta_Cliente.Text = string.Empty;
        Ticket.Text = string.Empty;
        Id_Ingreso.Text = string.Empty;
        Usuario_Creacion.Text = string.Empty;
    }
    protected void A_Usuario_Creacion_TextChanged(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Ingresos.Usuario_Apertura = A_Usuario_Creacion.Text;
        dt = Obj_Neg_Ingresos.Consulta_Admin_Casos_Usuario(Obj_Entidad_Ingresos.Usuario_Apertura);
        if (dt.Tables[0].Rows.Count > 0)
        {

            A_CONSULTA_CASOS.DataSource = dt.Tables[0];
            A_CONSULTA_CASOS.DataBind();
        }
        else
        {
            string script = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje1", script, true);
            Limpiar();
        }
        A_Ticket.Text = "";
        A_Cuenta_Cliente.Text = "";
        A_Id_Ingreso.Text = "";
        Cuenta_Cliente.Text = string.Empty;
        Ticket.Text = string.Empty;
        Id_Ingreso.Text = string.Empty;
        Usuario_Creacion.Text = string.Empty;
    }
    protected void Limpiar()
    {
        Cuenta_Cliente.Text = string.Empty;
        Ticket.Text = string.Empty;
        Id_Ingreso.Text = string.Empty;
        Usuario_Creacion.Text = string.Empty;
        A_Cuenta_Cliente.Text = string.Empty;
        A_Ticket.Text = string.Empty;
        A_Id_Ingreso.Text = string.Empty;
        A_Usuario_Creacion.Text = string.Empty;
        CONSULTA_CASOS.DataSource = null;
        CONSULTA_CASOS.DataBind();
        A_CONSULTA_CASOS.DataSource = null;
        A_CONSULTA_CASOS.DataBind();
    }
}